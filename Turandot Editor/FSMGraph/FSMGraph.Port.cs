using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KLib;

namespace FSMGraph
{
    public class Port
    {
        public static int size = 10;

        public Point Location;
        public Node BelongsTo = null;

        private Rectangle _box;

        public Port() { }

        public Port(Node belongsTo, int x, int y)
        {
            BelongsTo = belongsTo;
            MoveTo(x, y);
        }

        public void MoveTo(int x, int y)
        {
            Location = new Point(x, y);
            UpdateRectangle();
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Coral, _box);
        }

        public bool Contains(Point point)
        {
            return _box.Contains(point);
        }

        void UpdateRectangle()
        {
            _box = Geometry.RectangleByCenter(Location, size, size);
        }

    }
}
