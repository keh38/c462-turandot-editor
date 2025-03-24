using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class Label
    {
        static float _fontSize = 8;

        public string Text = "";
        public Point Location;
        public XmlColor FontColor = new XmlColor(Color.Black);

        Rectangle _box;
        Point _dragStartPoint;
        Rectangle _dragStartRect;

        public Label() { }
        public Label(string text)
        {
            Text = text;
        }
        public Label(string text, int x, int y)
        {
            Text = text;
            Location = new Point(x, y);
            CalculateBounds();
        }

        public void Draw(Graphics g, bool outline)
        {
            using (Font font = new Font("Arial", _fontSize, FontStyle.Italic))
            using (StringFormat stringFormat = StringFormat.GenericTypographic)
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                g.DrawString(Text, font, new SolidBrush(FontColor.SystemColor), Location.X, Location.Y, stringFormat);
            }

            if (outline)
            {
                using (var pen = new Pen(Color.Black, 1))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    g.DrawRectangle(pen, _box);
                }
            }

        }

        public bool Contains(Point point)
        {
            return _box.Contains(point);
        }

        public void CalculateBounds()
        {
            using (Font font = new Font("Arial", _fontSize, FontStyle.Italic))
            {
                Size sz = TextRenderer.MeasureText(Text, font);
                _box = Geometry.RectangleByCenter(Location, sz.Width, sz.Height);
            }
        }

        public void StartDrag()
        {
            _dragStartPoint = new Point(Location.X, Location.Y);
            _dragStartRect = new Rectangle(_box.Location, _box.Size);
        }

        public void DragTo(int dx, int dy)
        {
            Location.X = _dragStartPoint.X + dx;
            Location.Y = _dragStartPoint.Y + dy;

            _box = new Rectangle(_dragStartRect.Location, _dragStartRect.Size);
            _box.Offset(dx, dy);
        }

        public void EndDrag()
        {

        }
    }
}