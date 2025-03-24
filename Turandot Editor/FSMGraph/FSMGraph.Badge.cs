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

namespace FSMGraph
{
    public class Badge
    {
        static Image _sound = Image.FromFile("Images/Music.png");
        static Image _light = Image.FromFile("Images/Light on.png");
        static Image _info = Image.FromFile("Images/information.png");
        static Image _target = Image.FromFile("Images/Target.png");
        static Image _input = Image.FromFile("Images/Pencil.png");
        static Image _score = Image.FromFile("Images/star_green.png");
        static Image _abort = Image.FromFile("Images/Stop.png");
        static public int ImageSize = 20;
        static int _imageSize = 20;

        public enum BadgeIcon { Sound, Target, Light, Info, Score, Input, Abort}

        public BadgeIcon Icon;

        public Badge() { }
        public Badge(BadgeIcon icon)
        {
            Icon = icon;
        }

        public static List<Badge> Sort(List<Badge> unsorted)
        {
            List<Badge> sorted = new List<Badge>();

            foreach (BadgeIcon i in Enum.GetValues(typeof(BadgeIcon)))
            {
                Badge b = unsorted.Find(u => u.Icon == i);
                if (b != null) sorted.Add(b);
            }

            return sorted;
        }

        public void Draw(Graphics g, float x, float y)
        {
            RectangleF r = new RectangleF((float)x, (float)y, _imageSize, _imageSize);
            g.DrawImage(IconToImage(Icon), r);
        }

        private Image IconToImage(BadgeIcon icon)
        {
            Image im = null;
            switch (icon)
            {
                case BadgeIcon.Light:
                    im = _light;
                    break;
                case BadgeIcon.Sound:
                    im = _sound;
                    break;
                case BadgeIcon.Info:
                    im = _info;
                    break;
                case BadgeIcon.Target:
                    im = _target;
                    break;
                case BadgeIcon.Input:
                    im = _input;
                    break;
                case BadgeIcon.Score:
                    im = _score;
                    break;
                case BadgeIcon.Abort:
                    im = _abort;
                    break;
            }
            return im;
        }

    }
}
