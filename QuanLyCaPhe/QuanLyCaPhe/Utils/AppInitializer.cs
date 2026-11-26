using System;
using System.IO;
using System.Reflection;

namespace QuanLyCaPhe
{
    public static class AppInitializer
    {
        public static void ExtractEmbeddedAssets()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var assembly = Assembly.GetExecutingAssembly();
            string prefix = "QuanLyCaPhe.";

            foreach (string resourceName in assembly.GetManifestResourceNames())
            {
                if (!resourceName.StartsWith(prefix + "Database.") &&
                    !resourceName.StartsWith(prefix + "Resources."))
                {
                    continue;
                }

                string relativePart = resourceName.Substring(prefix.Length);
                int lastDotIndex = relativePart.LastIndexOf('.');

                string folderAndName = relativePart.Substring(0, lastDotIndex).Replace('.', Path.DirectorySeparatorChar);
                string extension = relativePart.Substring(lastDotIndex);
                string targetPath = Path.Combine(baseDir, folderAndName + extension);

                if (File.Exists(targetPath)) continue;

                string? targetDir = Path.GetDirectoryName(targetPath);
                if (!string.IsNullOrEmpty(targetDir))
                {
                    Directory.CreateDirectory(targetDir);
                }

                using Stream? stream = assembly.GetManifestResourceStream(resourceName);
                if (stream != null)
                {
                    using FileStream fs = new FileStream(targetPath, FileMode.Create, FileAccess.Write);
                    stream.CopyTo(fs);
                }
            }
        }
    }
}