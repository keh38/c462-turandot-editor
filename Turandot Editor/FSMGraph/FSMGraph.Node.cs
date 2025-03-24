using System;
using System.Collections.Generic;
using System.Drawing;
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
    public class Node
    {
        public enum NodeShape { Default, Start, Action, End}

        public string Name;
        public NodeShape Shape;
        public XmlColor BannerColor = new XmlColor(Color.LightGray);
        public float LineWidth = 1;
        public float SelectedLineWidth = 3;
        public int Width = 60;
        public int Height = 40;
        public int FontSize = 8;
        public Point Center;
        public List<Badge> Badges = new List<Badge>();
        public object UserData;

        Rectangle _rect;
        Point _dragStartPoint;
        bool _isSelected = false;

        List<Port> _ports = new List<Port>();
        List<Edge> _incoming = new List<Edge>();
        List<Edge> _outgoing = new List<Edge>();

        private float _wedgeFraction = 0.2f;

        public Node() { }

        public Node(string name)
        {
            this.Name = name;
        }

        public Rectangle BoundingBox
        {
            get { return _rect; }
        }

        [XmlIgnore]
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }

        [XmlIgnore]
        public List<Edge> Incoming
        {
            get { return _incoming; }
        }

        [XmlIgnore]
        public List<Edge> Outgoing
        {
            get { return _outgoing; }
        }

        [XmlIgnore]
        public List<Port> Ports
        {
            get { return _ports; }
        }

        public void Layout()
        {
            CalculateRectangle();
            LayoutPorts();
        }

        public void SetShapeAndColor(NodeShape shape, XmlColor color)
        {
            BannerColor = color;
            if (shape != Shape)
            {
                Shape = shape;
                Layout();
                RefreshEdgePorts();
            }
        }

        public void Draw(Graphics g)
        {
            if (Shape == NodeShape.Action || Shape == NodeShape.End)
            {
                DrawLeftWedge(g);
            }
            if (Shape == NodeShape.Start || Shape == NodeShape.End)
            {
                DrawRightWedge(g);
            }

            g.FillRectangle(Brushes.White, _rect);
            g.FillRectangle(new SolidBrush(BannerColor.SystemColor), _rect.X, _rect.Y, _rect.Width, _rect.Height / 2);

            using (var pen = new Pen(Color.Black, _isSelected ? SelectedLineWidth : LineWidth))
            {
                g.DrawRectangle(pen, _rect);
            }

            DrawLabel(g);

            if (Badges.Count > 0) DrawBadges(g);
        }

        private void DrawLeftWedge(Graphics g)
        {
            int wedgeSize = (int)(_wedgeFraction * _rect.Height);
            PointF[] pts = new PointF[4];
            pts[0] = new PointF(_rect.X, _rect.Y);
            pts[1] = new PointF(_rect.X, _rect.Y + _rect.Height);
            pts[2] = new PointF(_rect.X - wedgeSize, _rect.Y + _rect.Height - wedgeSize);
            pts[3] = new PointF(_rect.X - wedgeSize, _rect.Y + wedgeSize);

            g.FillPolygon(new SolidBrush(BannerColor.SystemColor), pts);
            using (var pen = new Pen(Color.Black, _isSelected ? SelectedLineWidth : LineWidth))
            {
                pen.MiterLimit = 1;
                g.DrawPolygon(pen, pts);
            }
        }

        private void DrawRightWedge(Graphics g)
        {
            int wedgeSize = (int)(_wedgeFraction * _rect.Height);
            PointF[] pts = new PointF[4];
            pts[0] = new PointF(_rect.Right, _rect.Y);
            pts[1] = new PointF(_rect.Right, _rect.Y + _rect.Height);
            pts[2] = new PointF(_rect.Right + wedgeSize, _rect.Y + _rect.Height - wedgeSize);
            pts[3] = new PointF(_rect.Right + wedgeSize, _rect.Y + wedgeSize);

            g.FillPolygon(new SolidBrush(BannerColor.SystemColor), pts);
            using (var pen = new Pen(Color.Black, _isSelected ? SelectedLineWidth : LineWidth))
            {
                pen.MiterLimit = 1;
                g.DrawPolygon(pen, pts);
            }
        }

        private void DrawBadges(Graphics g)
        {
            float xc = (_rect.Left + _rect.Right) / 2 - Badge.ImageSize / 2; ;
            float xl = _rect.Left + 2;
            float xr = _rect.Right - 2 - Badge.ImageSize;
            float y = _rect.Bottom - 2 - Badge.ImageSize;

            float x = 0;
            float dx = 0;

            if (Badges.Count > 1)
            {
                x = xl;
                dx = (xr - xl) / (Badges.Count - 1);
            }
            else
            {
                x = xc;
                dx = 0;
            }

            foreach (Badge b in Badge.Sort(Badges))
            {
                b.Draw(g, x, y);
                x += dx;
            }

        }

        void DrawLabel(Graphics g)
        {
            using (StringFormat stringFormat = StringFormat.GenericTypographic)
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                Font scaledFont = ScaleFontToFitWidth(Name, new Font("Arial", FontSize));
                string s = CompactPath(Name, Width - 2, scaledFont, TextFormatFlags.EndEllipsis);
                g.DrawString(s, scaledFont, Brushes.Black, Center.X, Center.Y - Height / 4, stringFormat);
            }
        }

        Font ScaleFontToFitWidth(string s, Font f)
        {
            float fontSize = f.Size;
            Font scaledFont = new Font(f.Name, fontSize);

            while (TextRenderer.MeasureText(s, scaledFont).Width > Width - 4 && fontSize > 6)
            {
                fontSize -= 0.5f;
                scaledFont = new Font(f.Name, fontSize);
            }

            return scaledFont;
        }

        public void AddBadge(Badge.BadgeIcon icon)
        {
            if (Badges.Find(o => o.Icon == icon) == null)
                Badges.Add(new Badge(icon));
        }

        //public void RemoveBadge(string name)
        //{
        //    Badge badge = Badges.Find(b => b.name == name);
        //    Badges.Remove(badge);
        //}

        public string CompactPath(string val, int width, Font font, TextFormatFlags flags)
        {
            string result = string.Copy(val);
            TextRenderer.MeasureText(result, font, new Size(width, 0), flags | TextFormatFlags.ModifyString);
            return result;
        }

        public void StartDrag(int snapSize)
        {
            _dragStartPoint = new Point(Center.X/snapSize * snapSize, Center.Y/snapSize * snapSize);

            foreach (Edge e in _outgoing) e.StartDrag(Edge.DragType.Source);
            foreach (Edge e in _incoming) e.StartDrag(Edge.DragType.Target);
        }

        public void DragTo(int dx, int dy, int snapSize)
        {
            dx = dx / snapSize * snapSize;
            dy = dy / snapSize * snapSize;

            Center.X = _dragStartPoint.X + dx;
            Center.Y = _dragStartPoint.Y + dy;
            CalculateRectangle();

            foreach (Edge e in _outgoing) e.DragTo(dx, dy, Edge.DragType.Source);
            foreach (Edge e in _incoming) e.DragTo(dx, dy, Edge.DragType.Target);
        }

        public void EndDrag()
        {
            LayoutPorts();
            foreach (Edge e in _outgoing) e.EndDrag();
            foreach (Edge e in _incoming) e.EndDrag();
        }

        public Port GetPortUnderMouse(Point mousePoint)
        {
            Port portUnder = null;
            foreach (Port p in _ports)
            {
                if (p.Contains(mousePoint))
                {
                    portUnder = p;
                    break;
                }
            }
            return portUnder;
        }

        public void AddIncoming(Edge e)
        {
            _incoming.Add(e);
        }

        public void RemoveIncoming(Edge e)
        {
            _incoming.Remove(e);
        }

        public void AddOutgoing(Edge e)
        {
            _outgoing.Add(e);
        }

        public void RemoveOutgoing(Edge e)
        {
            _outgoing.Remove(e);
        }

        private void CalculateRectangle()
        {
            _rect = Geometry.RectangleByCenter(Center, Width, Height);
        }

        private void LayoutPorts()
        {
            _ports.Clear();

            int nx = Width / Port.size;
            int ny = Height / Port.size;

            for (int k = 0; k < nx; k++)
            {
                _ports.Add(new Port(this, _rect.Left + k * Port.size, _rect.Top));
                _ports.Add(new Port(this, _rect.Left + k * Port.size, _rect.Bottom));
            }

            int wedgeSize = (int)(_wedgeFraction * _rect.Height);
            int rightOffset = (Shape == NodeShape.Start || Shape == NodeShape.End) ? wedgeSize : 0;
            int leftOffset = (Shape == NodeShape.Action || Shape == NodeShape.End) ? -wedgeSize : 0;

            for (int k = 0; k < ny; k++)
            {
                _ports.Add(new Port(this, _rect.Left + leftOffset, _rect.Top + k * Port.size));
                _ports.Add(new Port(this, _rect.Right + rightOffset, _rect.Top + k * Port.size));
            }

            _ports.Add(new Port(this, _rect.Right, _rect.Bottom));
        }

        public void RefreshEdgePorts()
        {
            foreach (Edge e in _outgoing)
            {
                e.RefreshSourcePort(_ports);
            }
            foreach (Edge e in _incoming)
            {
                e.RefreshTargetPort(_ports);
            }
        }

    }
}
