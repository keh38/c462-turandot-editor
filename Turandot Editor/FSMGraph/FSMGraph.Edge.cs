using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

using KLib;
using KLib.KGraphics;

namespace FSMGraph
{
    public class Edge
    {
        static int _hitSlack = 5;
        static int _controlSize = 8;

        public Label Label = new Label();
        public string SourceName;
        public string TargetName;
        public List<Point> Points = new List<Point>();
        public XmlColor LineColor = new XmlColor(Color.Black);
        public DashStyle LineStyle = DashStyle.Solid;
        public object UserData = null;

        DragType _dragType = DragType.None;
        int _dragPointIndex = -1;
        Point _dragSourceStartPoint;
        Point _dragTargetStartPoint;

        EdgeEnd _sourceEnd = null;
        EdgeEnd _targetEnd = null;
        List<Rectangle> _segRects = new List<Rectangle>();
        List<Rectangle> _controls = new List<Rectangle>();


        public Edge() { }
        public Edge(Port sourcePort, Port targetPort)
        {
            SourceName = sourcePort.BelongsTo.Name;
            TargetName = targetPort.BelongsTo.Name;

            Points.Clear();
            Points.Add(new Point(sourcePort.Location.X, sourcePort.Location.Y));
            Points.Add(new Point(targetPort.Location.X, targetPort.Location.Y));

            CreateLabel("Edge");

            _sourceEnd = new EdgeEnd(TargetEnd.Style);
            _targetEnd = new EdgeEnd(TargetEnd.Style);

            Layout();
        }
        public Edge(string name, Color lineColor, object userData)
        {
            LineColor = new XmlColor(lineColor);
            UserData = userData;

            Label = new Label(name);
            Label.FontColor = LineColor;

            //_targetEnd = new EdgeEnd(style);
            //_targetEnd.LineColor = LineColor;
            //_targetEnd.FillColor = new XmlColor(fillColor);
        }

        public void AssignPorts(Port sourcePort, Port targetPort)
        {
            SourceName = sourcePort.BelongsTo.Name;
            TargetName = targetPort.BelongsTo.Name;

            Points.Clear();
            Points.Add(new Point(sourcePort.Location.X, sourcePort.Location.Y));
            Points.Add(new Point(targetPort.Location.X, targetPort.Location.Y));

            CreateLabel(Label.Text);
            Layout();
        }


        public EdgeEnd SourceEnd
        {
            get { return _sourceEnd; }
            set { _sourceEnd = value; }
        }

        public EdgeEnd TargetEnd
        {
            get { return _targetEnd; }
            set { _targetEnd = value; }
        }

        public string DraggedControlAttachedTo
        {
            get
            {
                string nodeName = "";
                if (_dragPointIndex == 0) nodeName = SourceName;
                if (_dragPointIndex == Points.Count - 1) nodeName = TargetName;

                return nodeName;
            }
        }

        public void CreateLabel(string name)
        {
            Point p1 = Points[0];
            Point p2 = Points[Points.Count - 1];

            int xc = (p1.X + p2.X) / 2;
            int yc = (p1.Y + p2.Y) / 2;

            Label = new Label(name, xc, yc);
            Label.FontColor = LineColor;
        }

        public void Layout()
        {
            _segRects.Clear();
            for (int k=0; k<Points.Count-1; k++)
            {
                _segRects.Add(RectFromLineSegment(Points[k], Points[k + 1], 2*_hitSlack, 2*_hitSlack));
            }
            Label.CalculateBounds();
        }

        public void Draw(Graphics g)
        {
            using (var pen = new Pen(LineColor.SystemColor, 1))
            {
                pen.DashStyle = LineStyle;
                DrawCurve(g, pen);
            }
            if (Label != null) Label.Draw(g, false);
        }

        public void DrawEnds(Graphics g)
        {
            _sourceEnd.Draw(g, Points[0], Points[1]);
            _targetEnd.Draw(g, Points[Points.Count - 1], Points[Points.Count-2]);
        }

        public void DrawSelected(Graphics g)
        {
            using (var pen = new Pen(LineColor.SystemColor, 2))
            {
                DrawCurve(g, pen);
                pen.Width = 1;
                foreach (Rectangle r in _controls) g.DrawEllipse(pen, r);
            }
            if (Label != null) Label.Draw(g, true);
        }

        private void DrawCurve(Graphics g, Pen pen)
        {
            if (Points.Count == 2)
                g.DrawLine(pen, Points[0], Points[1]);
            else
            {
                g.DrawCurve(pen, Points.ToArray());
            }
        }

        public void Select()
        {
            _controls.Clear();
            foreach (Point p in Points) _controls.Add(Geometry.RectangleByCenter(p, _controlSize, _controlSize));
        }

        public bool TestControlDrag(Point point)
        {
            bool hit = false;

            foreach (Rectangle r in _controls)
            {
                if (r.Contains(point))
                {
                    hit = true;
                    StartControlDrag(r);
                    break;
                }
            }

            return hit;
        }

        public bool TestLabelDrag(Point point)
        {
            bool handled = false;
            if (Label.Contains(point))
            {
                Label.StartDrag();
                _dragType = DragType.Label;
                handled = true;
            }
            return handled;
        }

        public void StartDrag(DragType dragType)
        {
            _dragType = dragType;
            switch (dragType)
            {
                case DragType.Source:
                    _dragSourceStartPoint = new Point(Points[0].X, Points[0].Y);
                    break;
                case DragType.Target:
                    int index = Points.Count - 1;
                    _dragTargetStartPoint = new Point(Points[index].X, Points[index].Y);
                    break;
            }
        }

        public void DragTo(int dx, int dy, DragType dragType)
        {
            int x;
            int y;
            int index;

            if (dragType == DragType.Source)
            {
                x = _dragSourceStartPoint.X + dx;
                y = _dragSourceStartPoint.Y + dy;
                index = 0;
            }
            else
            {
                x = _dragTargetStartPoint.X + dx;
                y = _dragTargetStartPoint.Y + dy;
                index = Points.Count - 1;
            }
            Points[index] = new Point(x, y);
        }

        public void EndDrag()
        {
            Layout();
        }

        public bool HitTest(Point point)
        {
            bool hit = false;
            for (int k=0; k<_segRects.Count; k++)
            {
                if (_segRects[k].Contains(point))
                {
                    float d = KPointF.DistToLineSegment(Points[k], Points[k + 1], point);
                    if (d < _hitSlack)
                    {
                        hit = true;
                        break;
                    }
                }
            }
            return hit || Label.Contains(point);
        }

        public bool IsInteriorControlPoint(Point point)
        {
            bool isControlPoint = false;
            for (int k = 1; k < _controls.Count - 1; k++)
            {
                if (_controls[k].Contains(point))
                {
                    isControlPoint = true;
                    break;
                }
            }
            return isControlPoint;
        }

        public void InsertControlPoint(Point point)
        {
            if (Points.Count == 2)
            {
                Point p1 = Points[0];
                Point p2 = Points[Points.Count - 1];

                int xc = (p1.X + p2.X) / 2;
                int yc = (p1.Y + p2.Y) / 2;

                Points.Insert(1, new Point(xc, yc));
            }
            else
            {
                int closestInterior = FindClosestInteriorControl(point);
                int insertAt = (Distance(point, Points[0]) < Distance(point, Points[Points.Count - 1])) ? closestInterior : closestInterior+1;
                Points.Insert(insertAt, new Point(point.X, point.Y));
            }

            Layout();
            Select();
        }

        private int FindClosestInteriorControl(Point p)
        {
            int index = -1;
            float dmax = float.MaxValue;
            for (int k = 1; k < Points.Count - 1; k++)
            {
                float d = Distance(p, Points[k]);
                if (d < dmax)
                {
                    dmax = d;
                    index = k;
                }
            }

            return index;
        }

        private float Distance(Point p1, Point p2)
        {
            return (float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public void DeleteControlPoint(Point point)
        {
            int index = -1;
            for (int k = 1; k < _controls.Count - 1; k++)
            {
                if (_controls[k].Contains(point))
                {
                    index = k;
                    break;
                }
            }

            if (index > -1)
            {
                Points.RemoveAt(index);
                Layout();
                Select();
            }
        }

        private void StartControlDrag(Rectangle r)
        {
            _dragType = DragType.Control;
            _dragPointIndex = _controls.IndexOf(r);
        }

        public void DragControlPointTo(Point point)
        {
            Points[_dragPointIndex] = new Point(point.X, point.Y);
            _controls[_dragPointIndex] = Geometry.RectangleByCenter(Points[_dragPointIndex], _controlSize, _controlSize);
        }

        public void EndControlDrag()
        {
            Layout();
        }

        public void DragLabelTo(int dx, int dy)
        {
            Label.DragTo(dx, dy);
        }

        public void EndLabelDrag()
        {
            _dragType = DragType.None;
            Label.EndDrag();
        }

        Rectangle RectFromLineSegment(Point p1, Point p2, int minWidth, int minHeight)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);

            if (width < minWidth)
            {
                width = minWidth;
                x -= width / 2;
            }
            if (height < minHeight)
            {
                height = minHeight;
                y -= height / 2;
            }
            return new Rectangle(x, y, width, height);
        }


        public enum DragType { None, Source, Target, Control, Label}

        public void RefreshSourcePort(List<Port> ports)
        {
            float dmin = -1;
            Port src = null;

            foreach (Port p in ports)
            {
                float d = Distance(Points[0], p.Location);
                if (dmin < 0 || d < dmin)
                {
                    src = p;
                    dmin = d;
                }
            }

            Points[0] = new Point(src.Location.X, src.Location.Y);
        }

        public void RefreshTargetPort(List<Port> ports)
        {
            int idx = Points.Count - 1;
            float dmin = -1;
            Port src = null;

            foreach (Port p in ports)
            {
                float d = Distance(Points[idx], p.Location);
                if (dmin < 0 || d < dmin)
                {
                    src = p;
                    dmin = d;
                }
            }

            Points[idx] = new Point(src.Location.X, src.Location.Y);
        }

    }
}
