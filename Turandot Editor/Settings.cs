using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KLib;

namespace Turandot_Editor
{
    public class Settings
    {
        public string lastFolder = "";
        public Rectangle lastPosition = new Rectangle();
        public bool normalize = false;
        public SerializeableDictionary<string> metrics = new SerializeableDictionary<string>();
        public string wavFolder = "";
        public string calFolder = "";
        public string lastFile = "";
        public string transducer = "Bose";

        public Settings() { }
    }
}
