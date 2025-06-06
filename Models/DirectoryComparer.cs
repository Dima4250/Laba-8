using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8.Models
{
    public class DirectoryComparer
    {
        public List<FileDifference> CompareDirectories(string dir1, string dir2)
        {
            var differences = new List<FileDifference>();

            CompareDirectory(dir1, dir2, differences);
            CompareDirectory(dir2, dir1, differences, true);

            return differences;
        }

        private void CompareDirectory(string sourceDir, string targetDir, List<FileDifference> differences, bool reverse = false)
        {
            if (!Directory.Exists(sourceDir)) return;

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                var relativePath = GetRelativePath(file, sourceDir);
                var targetFile = Path.Combine(targetDir, relativePath);

                if (!File.Exists(targetFile))
                {
                    differences.Add(new FileDifference
                    {
                        FileName = relativePath,
                        Type = reverse ? FileDifferenceType.Deleted : FileDifferenceType.Created,
                        SourceDirectory = reverse ? targetDir : sourceDir,
                        TargetDirectory = reverse ? sourceDir : targetDir
                    });
                }
                else if (File.GetLastWriteTime(file) != File.GetLastWriteTime(targetFile))
                {
                    differences.Add(new FileDifference
                    {
                        FileName = relativePath,
                        Type = FileDifferenceType.Modified,
                        SourceDirectory = reverse ? targetDir : sourceDir,
                        TargetDirectory = reverse ? sourceDir : targetDir
                    });
                }
            }

            foreach (var dir in Directory.GetDirectories(sourceDir))
            {
                var relativePath = GetRelativePath(dir, sourceDir);
                var targetSubDir = Path.Combine(targetDir, relativePath);

                CompareDirectory(dir, targetSubDir, differences, reverse);
            }
        }

        private string GetRelativePath(string fullPath, string basePath)
        {
            if (!basePath.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                basePath += Path.DirectorySeparatorChar;
            }

            return fullPath.Substring(basePath.Length);
        }
    }
}
