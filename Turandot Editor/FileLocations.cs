using System;
using System.IO;

namespace Turandot_Editor
{
    public static class FileLocations
    {
        public static readonly string RootFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EPL", "HTS");
        public static string MATLABFolder { get { return Path.Combine(RootFolder, "MATLAB"); } }
    }
}