using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL13Serialisation
{
    internal class ValidationFolder
    {
        public static (bool, string) Validation(string pathToFolder)
        {
            if (Directory.Exists(pathToFolder) is false)
            {
                return (false, "Folder isn't exist");
            }
            var allFiles = Directory.GetFiles(pathToFolder, "*.json");
            if (allFiles is null)
            {
                return (false, "file with \".json\" format isn't exist.");
            }
            if (allFiles.Length > 1)
            {
                return (false, "Folder has many files with .json format.");
            }
            return (true, "Validation is successful.");
        }
    }
}
