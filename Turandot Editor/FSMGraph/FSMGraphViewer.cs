using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using FSMGraph;

namespace KLib.Controls
{
    public partial class FSMGraphViewer : UserControl
    {

        Graph _graph =  new Graph();

        float _currentScale = 1.0f;
        float _dx = 0f;
        float _dy = 0f;

        ToolStripTextBox _scaleTextBox = null;
        Matrix _inverseTransform;

        bool _altKey = false;
        bool _controlKey = false;

        // Edge insertion
        bool _insertingEdge = false;
        Port _activePort = null;
        Port _sourcePort = null;
        Point _currentInsertionEnd;

        DragMode _dragMode = DragMode.Off;
        Point _dragStartPoint;

        PanState _panState;

        List<Node> _selectedNodes = new List<Node>();
        Rectangle _selectionRectangle = new Rectangle();
        Point _rightMouseDownPoint;

        Edge _selectedEdge = null;
        Node _nodeAttachedToEdgeControlPoint = null;
        Edge _edgeToInsert = null;
        Node _insertEdgeAt = null;

        readonly float _minScale = 0.25f;
        readonly float _maxScale = 1.25f;

        bool _snapToGrid = true;
        int _gridSize = 10;

        protected string defaultNodeName = "Node";
        protected FSMGraphAttributes _attr = new FSMGraphAttributes();

        public NodeActionHandler OnNodeAdded = null;
        public NodeActionHandler OnNodeSelected = null;
        public NodeDeleteHandler OnNodesDeleted = null;
        public NodesDuplicatedHandler OnNodesDuplicated = null;
        public EdgeActionHandler OnEdgeAdded = null;
        public EdgeActionHandler OnEdgeSelected = null;
        public EdgeActionHandler OnEdgeDeleted = null;

        public FSMGraphViewer()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            this.MouseDown += new MouseEventHandler(FSMGraph_MouseDown);
            this.MouseMove += new MouseEventHandler(FSMGraph_MouseMove);
            this.MouseUp += new MouseEventHandler(FSMGraph_MouseUp);
            this.Paint += new PaintEventHandler(FSMGraph_Paint);

            _graph = new Graph();
            RefreshGraph();
        }

        public void InsertToolStrip(ToolStrip toolStrip)
        {
            toolStrip.Items.Add(new ToolStripSeparator());

            ToolStripButton button = new ToolStripButton("Zoom in", imageList.Images["ZoomIn"], zoomInButton_Click);
            button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStrip.Items.Add(button);

            button = new ToolStripButton("Zoom out", imageList.Images["ZoomOut"], zoomOutButton_Click);
            button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStrip.Items.Add(button);

            _scaleTextBox = new ToolStripTextBox();
            _scaleTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            _scaleTextBox.BorderStyle = BorderStyle.FixedSingle;
            _scaleTextBox.AutoSize = false;
            _scaleTextBox.Width = 50;
            _scaleTextBox.Text = "100%";
            _scaleTextBox.KeyPress += scaleTextBox_KeyPress;
            toolStrip.Items.Add(_scaleTextBox);

            button = new ToolStripButton("Size to fit", imageList.Images["AutoSize"], autoSizeButton_Click);
            button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStrip.Items.Add(button);

        }

        public Graph Graph
        {
            get { return _graph; }
            set
            {
                _graph = value;
                _selectedNodes.Clear();
                _selectedEdge = null;
                RefreshGraph();
            }
        }

        public float CurrentScale
        {
            get { return _currentScale; }
            set
            {
                if (value >= 0.1f && value <= 1.5f)
                {
                    _currentScale = value;
                    Invalidate();
                }
            }
        }

        public void RefreshGraph()
        {
            if (_graph != null)
            {
                _graph.Layout();
            }
            Invalidate();
        }

        public void RenameNode(string oldName, string newName)
        {
            Graph.RenameNode(oldName, newName);
            Invalidate();
        }

        public void ClearNodeOutgoing(string name)
        {
            Graph.ClearNodeOutgoing(name);
            Invalidate();
        }

        private void FSMGraph_Paint(object sender, PaintEventArgs e)
        {
            if (_graph != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                e.Graphics.TranslateTransform(_dx, _dy);
                e.Graphics.ScaleTransform(_currentScale, _currentScale);
                _inverseTransform = e.Graphics.Transform.Clone();
                _inverseTransform.Invert();

                _graph.Draw(e.Graphics, _selectedEdge);

                if (_dragMode == DragMode.Select) DrawSelectionRectangle(e.Graphics);
                if (_insertingEdge) DrawEdgeInsertion(e.Graphics);
                if (_dragMode == DragMode.EdgePoint && _activePort != null) _activePort.Draw(e.Graphics);
            }
        }

        private void DrawSelectionRectangle(Graphics g)
        {
            using (var pen = new Pen(Color.Black, 1))
            {
                g.DrawRectangle(pen, _selectionRectangle);
            }
        }

        private void DrawEdgeInsertion(Graphics g)
        {
            if (_activePort != null) _activePort.Draw(g);
            if (_sourcePort != null)
            {
                _sourcePort.Draw(g);

                using (var pen = new Pen(_edgeToInsert.LineColor.SystemColor, 2))
                {
                    g.DrawLine(pen, _sourcePort.Location, _currentInsertionEnd);
                } 
            }
        }

        private void FSMGraph_MouseDown(object sender, MouseEventArgs e)
        {
            Point mousePoint = ScreenToGraph(e.Location);

            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = BuildContextMenu(e.Location);
                cm.Show(this, e.Location);
                return;
            }

            if (ProcessEdgeInsertionMouseDown(mousePoint)) return;
            if (ProcessEdgeSelectionMouseDown(mousePoint)) return;
            if (ProcessPanMouseDown(e.Location)) return;
            if (ProcessNodeMouseDown(mousePoint)) return;

            _selectionRectangle = new Rectangle(0, 0, 0, 0);
            _dragStartPoint = mousePoint;
            _dragMode = DragMode.Select;
        }

        bool ProcessEdgeInsertionMouseDown(Point point)
        {
            if (!_insertingEdge) return false;

            Port port = _graph.PortUnderMouse(point);
            if (port == null)
            {
                AbortEdgeInsertion();
            }
            else if (_sourcePort == null)
            {
                _sourcePort = port;
                _currentInsertionEnd = point;
            }
            Refresh();
            return true;
        }

        bool ProcessEdgeSelectionMouseDown(Point point)
        {
            if (_selectedEdge == null) return false;
            if (_selectedEdge.TestLabelDrag(point))
            {
                _dragMode = DragMode.EdgeLabel;
                _dragStartPoint = point;
                Refresh();
            }
            else if (_selectedEdge.TestControlDrag(point))
            {
                _dragMode = DragMode.EdgePoint;
                _dragStartPoint = point;
                _nodeAttachedToEdgeControlPoint = _graph.Nodes.Find(n => n.Name == _selectedEdge.DraggedControlAttachedTo);
            }
            return true;
        }

        bool ProcessPanMouseDown(Point point)
        {
            if (!_altKey) return false;
            _dragMode = DragMode.Pan;
            _panState = new PanState(point, _dx, _dy);
            return true;
        }

        bool ProcessNodeMouseDown(Point point)
        {
            Node nodeUnder = _graph.NodeUnderMouse(point);

            if (_controlKey || nodeUnder == null) return false;

            _dragStartPoint = point;
            _dragMode = DragMode.NodePending;
            return true;
        }

        private void FSMGraph_MouseUp(object sender, MouseEventArgs e)
        {
            if (_graph == null) return;

            Point mousePoint = ScreenToGraph(e.Location);

            if (ProcessEdgeInsertionMouseUp(mousePoint)) return;
            if (ProcessEdgeLabelMouseUp(mousePoint)) return;
            if (ProcessDragSelectionMouseUp()) return;
            if (ProcessDragControlPointMouseUp(mousePoint)) return;
            if (ProcessEdgeSelectionMouseUp(mousePoint)) return;

            ProcessNodeSelectionMouseUp(mousePoint);
        }

        private void MouseUpOnNode(Node node)
        {
            if (!_controlKey)
                ClearNodeSelection();

            node.IsSelected = !node.IsSelected;
            if (node.IsSelected)
                _selectedNodes.Add(node);
            else
                _selectedNodes.Remove(node);
        }

        private bool ProcessDragSelectionMouseUp()
        {
            if (_dragMode != DragMode.Select || _selectionRectangle.Width == 0) return false;

            if (!_controlKey)
            ClearNodeSelection();

            foreach (Node n in _graph.Nodes)
            {
                if (_selectionRectangle.IntersectsWith(n.BoundingBox))
                {
                    n.IsSelected = !n.IsSelected;
                    if (n.IsSelected)
                        _selectedNodes.Add(n);
                    else
                        _selectedNodes.Remove(n);
                }
            }

            _dragMode = DragMode.Off;
            Cursor = Cursors.Default;

            Refresh();

            return true;
        }

        private bool ProcessDragControlPointMouseUp(Point point)
        {
            if (_dragMode != DragMode.EdgePoint) return false;

            _selectedEdge.EndControlDrag();
            _dragMode = DragMode.Off;
            Cursor = Cursors.Default;

            Refresh();
            return true;
        }

        private bool ProcessEdgeLabelMouseUp(Point point)
        {
            if (_dragMode != DragMode.EdgeLabel) return false;

            _selectedEdge.EndLabelDrag();
            _dragMode = DragMode.Off;

            Refresh();
            return true;
        }

        private bool ProcessEdgeSelectionMouseUp(Point point)
        {
            bool handled = true;

            Edge edgeUnderMouse = _graph.EdgeUnderMouse(point);

            if (_selectedEdge == null && edgeUnderMouse == null) return false;

            if (_selectedEdge == edgeUnderMouse)
                _selectedEdge = null;
            else
            {
                _selectedEdge = edgeUnderMouse;

                if (edgeUnderMouse != null)
                {
                    ClearNodeSelection();
                    _selectedEdge.Select();
                    if (OnEdgeSelected != null)
                        OnEdgeSelected(_selectedEdge.SourceName, _selectedEdge.TargetName, _selectedEdge.Label.Text, _selectedEdge.UserData);
                }
                else
                {
                    handled = false;
                }
            }

            _dragMode = DragMode.Off;
            Cursor = Cursors.Default;

            Refresh();
            return handled;
        }

        private bool ProcessNodeSelectionMouseUp(Point point)
        {
            Node nodeUnderMouse = _graph.NodeUnderMouse(point);

            if (nodeUnderMouse != null)
            {
                _selectedEdge = null;
                if (_dragMode != DragMode.Nodes)
                    MouseUpOnNode(nodeUnderMouse);
                else
                    foreach (Node n in _selectedNodes)
                        n.EndDrag();
                if (OnNodeSelected != null)
                    OnNodeSelected(_selectedNodes.Count == 1 ? _selectedNodes[0].Name : null);
            }
            else if (!_controlKey)
            {
                ClearNodeSelection();
                if (OnNodeSelected != null) OnNodeSelected(null);
            }

            _dragMode = DragMode.Off;
            Cursor = Cursors.Default;

            Refresh();
            return true;
        }

        private void ClearNodeSelection()
        {
            foreach (Node n in _selectedNodes)
                n.IsSelected = false;
            _selectedNodes.Clear();
        }

        private void FSMGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (_graph == null) return;

            Point mousePoint = ScreenToGraph(e.Location);

            if (ProcessEdgeInsertionMouseMove(mousePoint)) return;
            if (ProcessEdgeLabelMouseMove(mousePoint)) return;
            if (ProcessEdgePointMouseMove(mousePoint)) return;
            if (ProcessNodeMouseMove(mousePoint)) return;
            if (ProcessPanMouseMove(e.Location)) return;
            if (ProcessDragSelectionMouseMove(mousePoint)) return;
        }

        private bool ProcessEdgeInsertionMouseMove(Point point)
        {
            if (!_insertingEdge) return false;

            Port portUnder = _graph.PortUnderMouse(point);
            if (_sourcePort == null && portUnder != null && portUnder.BelongsTo != _insertEdgeAt)
            {
                _activePort = null;
                return true;
            }

            _activePort = portUnder;

            if (_sourcePort != null) _currentInsertionEnd = point;
            Refresh();

            return true;
        }

        private bool ProcessEdgePointMouseMove(Point point)
        {
            if (_dragMode != DragMode.EdgePoint) return false;

            if (_nodeAttachedToEdgeControlPoint != null)
            {
                Port p = _graph.PortUnderMouse(point);
                if (p != null)
                {
                    _selectedEdge.DragControlPointTo(p.Location);
                }
            }
            else
            {
                _selectedEdge.DragControlPointTo(point);
            }

            Refresh();

            return true;
        }

        private bool ProcessEdgeLabelMouseMove(Point point)
        {
            if (_dragMode != DragMode.EdgeLabel) return false;

            _selectedEdge.DragLabelTo(point.X - _dragStartPoint.X, point.Y - _dragStartPoint.Y);
            Refresh();

            return true;
        }

        private bool ProcessNodeMouseMove(Point point)
        {
            if (_dragMode != DragMode.NodePending && _dragMode != DragMode.Nodes) return false;

            if (_dragMode == DragMode.NodePending)
            {
                if (DistanceMovedSquared(_dragStartPoint, point) > 1)
                {
                    Node nodeUnder = _graph.NodeUnderMouse(point);

                    if (nodeUnder != null)
                    {
                        StartNodeDrag(nodeUnder);
                        _dragMode = DragMode.Nodes;
                    }
                    else
                    {
                        _dragMode = DragMode.Off;
                    }
                }
            }
            else
            {
                foreach (Node n in _selectedNodes)
                    n.DragTo(point.X - _dragStartPoint.X, point.Y - _dragStartPoint.Y, _snapToGrid ? _gridSize : 1);
            }

            Refresh();
            return true;
        }

        private bool ProcessPanMouseMove(Point dragTo)
        {
            if (_dragMode != DragMode.Pan) return false;
            _dx = _panState.dx_start + dragTo.X - _panState.startPoint.X;
            _dy = _panState.dy_start + dragTo.Y - _panState.startPoint.Y;

            Refresh();
            return true;
        }

        private bool ProcessDragSelectionMouseMove(Point mousePoint)
        {
            if (_dragMode != DragMode.Select) return false;

            _selectionRectangle.X = Math.Min(_dragStartPoint.X, mousePoint.X);
            _selectionRectangle.Y = Math.Min(_dragStartPoint.Y, mousePoint.Y);
            _selectionRectangle.Width = Math.Abs(mousePoint.X - _dragStartPoint.X);
            _selectionRectangle.Height = Math.Abs(mousePoint.Y - _dragStartPoint.Y);

            Refresh();
            return true;
        }

        private double DistanceMovedSquared(Point start, Point stop)
        {
            return (Math.Pow((stop.X - start.X), 2) + Math.Pow((stop.Y - start.Y), 2));
        }

        private void StartNodeDrag(Node n)
        {
            if (!n.IsSelected)
            {
                ClearNodeSelection();
                n.IsSelected = true;
                _selectedNodes.Add(n);
            }
            foreach (Node node in _selectedNodes)
                node.StartDrag(_snapToGrid ? _gridSize : 1);
        }

        private void FSMGraph_MouseLeave(object sender, EventArgs e)
        {
            _dragMode = DragMode.Off;
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            ChangeScale(_currentScale + 0.25f);
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            ChangeScale(_currentScale - 0.25f);
        }

        private void autoSizeButton_Click(object sender, EventArgs e)
        {
            Rectangle bounds = GetContentBounds();

            float newScale = (float)this.Width / (float)bounds.Width;
            ChangeScale(Math.Min(newScale, 1.0f));

            _dx = (this.Width - bounds.Width) / 2 - bounds.Left;
            _dy = (this.Height - bounds.Height) / 2 - bounds.Top;
        }

        private void scaleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)13)
            {
                float newVal;
                if (float.TryParse(_scaleTextBox.Text, out newVal))
                {
                    ChangeScale(0.01f * newVal);
                }
                else
                {
                    ShowCurrentScaleInTextBox();
                }
            }
        }

        private void ChangeScale(float value)
        {
            _currentScale = CoerceScale(value);
            ShowCurrentScaleInTextBox();
            Invalidate();
        }

        private float CoerceScale(float value)
        {
            value = Math.Min(value, _maxScale);
            value = Math.Max(value, _minScale);
            return value;
        }

        private void ShowCurrentScaleInTextBox()
        {
            _scaleTextBox.Text = Math.Round(_currentScale * 100).ToString("F0") + "%";
        }

        private Rectangle GetContentBounds()
        {
            int xmin = int.MaxValue;
            int xmax = int.MinValue;
            int ymin = int.MaxValue;
            int ymax = int.MinValue;

            foreach (Node n in _graph.Nodes)
            {
                xmin = Math.Min(xmin, n.BoundingBox.Left);
                xmax = Math.Max(xmax, n.BoundingBox.Right);
                ymin = Math.Min(ymin, n.BoundingBox.Top);
                ymax = Math.Max(ymax, n.BoundingBox.Bottom);
            }

            return new Rectangle(xmin, ymin, xmax - xmin, ymax - ymin);
        }

        private Point ScreenToGraph(Point point)
        {
            if (_inverseTransform == null)
                return new Point(0, 0);

            var pf = new[] { new Point(point.X, point.Y) };
            _inverseTransform.TransformPoints(pf);
            return new Point(pf[0].X, pf[0].Y);
        }

        #region Nested types
        enum DragMode { Off, NodePending, Nodes, Pan, Select, EdgeInsertion, EdgePoint, EdgeLabel};
        public class PanState
        {
            public Point startPoint;
            public float dx_start;
            public float dy_start;
            public PanState(Point startPoint, float dx_start, float dy_start)
            {
                this.startPoint = startPoint;
                this.dx_start = dx_start;
                this.dy_start = dy_start;
            }
        }
        public delegate void NodeActionHandler(string name);
        public delegate void NodesDuplicatedHandler(List<string> names);
        public delegate void NodeDeleteHandler(List<string> names);
        public delegate void EdgeActionHandler(string source, string target, string label, object userData);
        #endregion

        private void FSMGraphViewer_KeyDown(object sender, KeyEventArgs e)
        {
            _controlKey = e.Control;
            _altKey = e.Alt;
            if (_altKey)
            {
                Cursor = Cursors.Hand;
            }
        }

        private void FSMGraphViewer_KeyUp(object sender, KeyEventArgs e)
        {
            if (_altKey)
                Cursor = Cursors.Default;
            _altKey = false;
            _controlKey = false;
        }

        private void FSMGraphViewer_MouseLeave(object sender, EventArgs e)
        {
            _dragMode = DragMode.Off;
            Cursor = Cursors.Default;
        }

        private ContextMenu BuildContextMenu(Point point)
        {
            _rightMouseDownPoint = point;

            ContextMenu cm = BuildEdgeSelectedContextMenu(point);

            if (cm.MenuItems.Count > 0) return cm;

            MenuItem mi;

            mi = new MenuItem();
            mi.Text = "Add " + defaultNodeName.ToLower();
            mi.Click += insertNode_Click;
            cm.MenuItems.Add(mi);

            if (_selectedNodes.Count > 0)
            {
                mi = new MenuItem();
                mi.Text = "Duplicate selected";
                mi.Click += duplicateSelectedNodes_Click;
                cm.MenuItems.Add(mi);

                mi = new MenuItem();
                mi.Text = "Delete selected";
                mi.Click += deleteSelectedNode_Click;
                cm.MenuItems.Add(mi);
            }

            Node nodeUnder = _graph.NodeUnderMouse(ScreenToGraph(point));
            if (_graph.Nodes.Count > 1 && nodeUnder != null)
            {
                BuildEdgeContextMenu(cm, nodeUnder.Name);
                _insertEdgeAt = nodeUnder;
            }

            return cm;
        }

        protected virtual void BuildEdgeContextMenu(ContextMenu cm, string nodeName)
        {
            MenuItem mi = new MenuItem();
            mi.Text = "-";
            cm.MenuItems.Add(mi);

            mi = new MenuItem();
            mi.Text = "Add edge";
            mi.Click += insertEdge_Click;
            cm.MenuItems.Add(mi);
        }

        private ContextMenu BuildEdgeSelectedContextMenu(Point point)
        {
            var cm = new ContextMenu();

            MenuItem mi;

            if (_selectedEdge != null)
            {
                if (_selectedEdge.IsInteriorControlPoint(ScreenToGraph(point)))
                {
                    mi = new MenuItem();
                    mi.Text = "Delete control point";
                    mi.Click += deleteControlPoint_Click;
                    cm.MenuItems.Add(mi);
                }
                else
                {
                    mi = new MenuItem();
                    mi.Text = "Insert control point";
                    mi.Click += insertControlPoint_Click;
                    cm.MenuItems.Add(mi);

                    mi = new MenuItem();
                    mi.Text = "Delete selected";
                    mi.Click += deleteSelectedEdge_Click;
                    cm.MenuItems.Add(mi);
                }
            }
            return cm;
        }

        void insertNode_Click(object sender, EventArgs e)
        {
            Point pt = ScreenToGraph(_rightMouseDownPoint);
            Node node = _graph.AddNodeAutoName(pt.X / _gridSize * _gridSize, pt.Y / _gridSize * _gridSize, defaultNodeName);
            node.Shape = Node.NodeShape.End;
            node.BannerColor = _attr.endColor;
            Refresh();

            if (OnNodeAdded != null)
                OnNodeAdded(node.Name);
        }

        void duplicateSelectedNodes_Click(object sender, EventArgs e)
        {
            if (_graph == null || _selectedNodes.Count == 0) return;

            Point pt = ScreenToGraph(_rightMouseDownPoint);
            var copied = DuplicateSelectedNodes(new Size(pt.X - _selectedNodes[0].Center.X, pt.Y - _selectedNodes[0].Center.Y));

            if (OnNodesDuplicated != null) OnNodesDuplicated(copied);
        }

        void insertEdge_Click(object sender, EventArgs e)
        {
            StartEdgeInsertion();
            Refresh();
        }

        void insertControlPoint_Click(object sender, EventArgs e)
        {
            _selectedEdge.InsertControlPoint(ScreenToGraph(_rightMouseDownPoint));
            Refresh();
        }

        void deleteControlPoint_Click(object sender, EventArgs e)
        {
            _selectedEdge.DeleteControlPoint(ScreenToGraph(_rightMouseDownPoint));
            Refresh();
        }

        void deleteSelectedNode_Click(object sender, EventArgs e)
        {
            if (_graph == null || _selectedNodes.Count == 0) return;

            List<string> deleteNodes = new List<string>();
            foreach (Node n in _selectedNodes)
            {
                deleteNodes.Add(n.Name);
                _graph.RemoveNode(n);
            }

            if (OnNodesDeleted != null)
                OnNodesDeleted(deleteNodes);

            _selectedNodes.Clear();
            Refresh();
        }

        void deleteSelectedEdge_Click(object sender, EventArgs e)
        {
            _graph.RemoveEdge(_selectedEdge);

            if (OnEdgeDeleted != null)
                OnEdgeDeleted(_selectedEdge.SourceName, _selectedEdge.TargetName, _selectedEdge.Label.Text, _selectedEdge.UserData);

            _selectedEdge = null;
            Refresh();
        }

        protected void StartEdgeInsertion()
        {
            StartEdgeInsertion(new Edge("Edge", Color.Black, null));
        }

        protected void StartEdgeInsertion(Edge newEdge)
        {
            ClearNodeSelection();

            _activePort = _sourcePort = null;

            _edgeToInsert = newEdge;

            _insertingEdge = true;
            Cursor = Cursors.Cross;
        }

        bool ProcessEdgeInsertionMouseUp(Point point)
        {
            if (!_insertingEdge) return false;

            Port port = _graph.PortUnderMouse(point);
            if (port != null && _sourcePort!=null && port.BelongsTo != _sourcePort.BelongsTo)
            {
                _graph.AddEdge(_edgeToInsert, _sourcePort, port);

                if (OnEdgeAdded != null)
                    OnEdgeAdded(_edgeToInsert.SourceName, _edgeToInsert.TargetName, _edgeToInsert.Label.Text, _edgeToInsert.UserData);

            }
            AbortEdgeInsertion();
            Refresh();

            return true;
        }

        void AbortEdgeInsertion()
        {
            _activePort = _sourcePort = null;
            _insertingEdge = false;
            Cursor = Cursors.Default;
        }

        public void Write(string path)
        {
            FSMGraphContainer container = new FSMGraphContainer(new GraphViewAttributes(_currentScale, _dx, _dy), _graph);

            XmlSerializer serializer = new XmlSerializer(typeof(FSMGraphContainer));
            using (Stream s = File.Create(path))
            {
                serializer.Serialize(s, container);
            }
        }

        public int Read(string path)
        {
            int version = -1;

            FSMGraphContainer container;

            XmlSerializer serializer = new XmlSerializer(typeof(FSMGraphContainer));
            using (Stream s = File.OpenRead(path))
            {
                container = (FSMGraphContainer)serializer.Deserialize(s);
            }

            _currentScale = container.attr.scale;
            _dx = container.attr.dx;
            _dy = container.attr.dy;
            _graph = container.graph;
            _graph.Relink();
            version = container.version;

            ShowCurrentScaleInTextBox();

            RefreshGraph();

            return version;
        }

        public List<string> DuplicateSelectedNodes()
        {
            return DuplicateSelectedNodes(new Size(_gridSize, _gridSize));
        }

        public List<string> DuplicateSelectedNodes(Size offset)
        {
            List<string> duplicated = new List<string>();

            if (_graph == null || _selectedNodes.Count == 0) return duplicated;


            List<Node> addedNodes = new List<Node>();
            foreach (var n in _selectedNodes)
            {
                duplicated.Add(n.Name);

                n.IsSelected = false;
                Node node = _graph.AddNode(n.Name + " copy", n.Center.X  + offset.Width, n.Center.Y + offset.Height);
                node.Shape = n.Shape;
                node.BannerColor = n.BannerColor;
                node.IsSelected = true;

                foreach (var b in n.Badges) node.AddBadge(b.Icon);

                addedNodes.Add(node);
            }

            _selectedNodes.Clear();
            foreach (var n in addedNodes) _selectedNodes.Add(n);

            Refresh();

            return duplicated;
        }



    }
}
