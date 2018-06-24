using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace LorikeetRESTApp.Classes
{
    public static class MiscStuff
    {
        public static string GetUserTempPath(string directory)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                path = Path.Combine(path, directory);
                Directory.CreateDirectory(path);
            }
            return path;
        }
    }
}
