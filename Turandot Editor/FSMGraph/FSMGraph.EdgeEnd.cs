using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KLib;
using KLib.KGraphics;

namespace FSMGraph
{
    public class EdgeEnd
    {
        public static int size = 7;

        public EndStyle Style = EndStyle.Plain; 
        public XmlColor FillColor = new XmlColor(Color.Black);
        public XmlColor LineColor = new XmlColor(Color.Black);

        public EdgeEnd() { }
        public EdgeEnd(EndStyle style)
        {
            Style = style;
        }
        public EdgeEnd(EndStyle style, Color lineColor, Color fillColor)
        {
            Style = style;
            LineColor = new XmlColor(lineColor);
            FillColor = new XmlColor(fillColor);
        }

        public void Draw(Graphics g, Point center, Point previous)
        {
            Rectangle r = Geometry.RectangleByCenter(center, size, size);

            switch (Style)
            {
                case EndStyle.Plain:
                    break;
                case EndStyle.Arrow:
                    Point[] pts = GetArrowPoints(center, previous);
                    using (Brush brush = new SolidBrush(FillColor.SystemColor))
                        g.FillPolygon(brush, pts);
                    using (var pen = new Pen(LineColor.SystemColor, 1))
                        g.DrawPolygon(pen, pts);
                    break;

                case EndStyle.Diamond:
                    Point[] dpts = GetDiamondPoints(center, previous);
                    using (Brush brush = new SolidBrush(FillColor.SystemColor))
                        g.FillPolygon(brush, dpts);
                    using (var pen = new Pen(LineColor.SystemColor, 1))
                        g.DrawPolygon(pen, dpts);
                    break;

                case EndStyle.Box:
                    using (Brush brush = new SolidBrush(FillColor.SystemColor))
                        g.FillRectangle(brush, r);
                    using (var pen = new Pen(LineColor.SystemColor, 1))
                        g.DrawRectangle(pen, r);
                    break;
                case EndStyle.Circle:
                    using (Brush brush = new SolidBrush(FillColor.SystemColor))
                        g.FillEllipse(brush, r);
                    using (var pen = new Pen(LineColor.SystemColor, 1))
                        g.DrawEllipse(pen, r);
                    break;
            }
        }

        Point[] GetArrowPoints(Point end, Point start)
        {
            KPointF endF = new KPointF(end);
            KPointF startF = new KPointF(start);

            KPointF dir = (startF - endF);
            dir = dir / dir.Length;

            KPointF ortho = 4 * dir.Rotate((float)Math.PI / 2);
            startF = endF + 3 * size / 2 * dir;

            int dx = (int)ortho.X;
            int dy = (int)ortho.Y;

            Point[] pts = new Point[3];
            pts[0] = new Point((int)startF.X - dx, (int)startF.Y - dy);
            pts[1] = end;
            pts[2] = new Point((int)startF.X + dx, (int)startF.Y + dy);

            return pts;
        }

        Point[] GetDiamondPoints(Point end, Point start)
        {
            KPointF endF = new KPointF(end);
            KPointF startF = new KPointF(start);

            KPointF dir = (startF - endF);
            dir = dir / dir.Length;

            KPointF ortho = 4 * dir.Rotate((float)Math.PI / 2);
            startF = endF + 3 * size / 2 * dir;
            KPointF midF = endF + 3 * size / 4 * dir;

            int dx = (int)ortho.X;
            int dy = (int)ortho.Y;

            Point[] pts = new Point[4];
            pts[0] = new Point((int)startF.X, (int)startF.Y);
            pts[1] = new Point((int)midF.X - dx, (int)midF.Y - dy);
            pts[2] = end;
            pts[3] = new Point((int)midF.X + dx, (int)midF.Y + dy);

            return pts;
        }

        public enum EndStyle { Plain, Arrow, Box, Circle, Diamond}
    }
}
