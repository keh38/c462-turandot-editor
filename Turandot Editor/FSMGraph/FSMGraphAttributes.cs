using System.Drawing;
using KLib.KGraphics;

namespace KLib.Controls
{
    public class FSMGraphAttributes
    {
        public double nodeWidth = 60;
        public XmlColor nodeColor = new XmlColor(Color.LightGray);
        public XmlColor startColor = new XmlColor(Color.LightGreen);
        public XmlColor targetColor = new XmlColor(Color.LightSkyBlue);
        public XmlColor endColor = new XmlColor(Color.LightCoral);
        public XmlColor actionColor = new XmlColor(Color.Goldenrod);

        public FSMGraphAttributes() { }
    }
}