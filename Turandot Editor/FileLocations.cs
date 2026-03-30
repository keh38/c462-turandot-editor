using C462.Shared;
using System;
using System.IO;

namespace Turandot_Editor
{
    public static class FileLocations
    {
        public static string MATLABFolder { get { return Path.Combine(SharedFileLocations.HtsResourcesFolder, "MATLAB"); } }
        public static string SubjectDataFolder { get; set; } = "";
        public static string SubjectMetaDataFolder { get { return Path.Combine(SubjectDataFolder, "meta"); } }
    }
}