using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8.Models
{
    public class DirectorySyncModel
    {
        private readonly DirectoryComparer _comparer = new DirectoryComparer();

        public List<FileDifference> GetDifferences(string dir1, string dir2)
        {
            return _comparer.CompareDirectories(dir1, dir2);
        }

        public void SynchronizeDirectories(List<FileDifference> differences)
        {
            foreach (var diff in differences)
            {
                try
                {
                    var sourcePath = Path.Combine(diff.SourceDirectory, diff.FileName);
                    var targetPath = Path.Combine(diff.TargetDirectory, diff.FileName);

                    switch (diff.Type)
                    {
                        case FileDifferenceType.Created:
                        case FileDifferenceType.Modified:
                            Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
                            File.Copy(sourcePath, targetPath, true);
                            break;
                        case FileDifferenceType.Deleted:
                            if (File.Exists(targetPath))
                            {
                                File.Delete(targetPath);
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при синхронизации файла {diff.FileName}: {ex.Message}");
                }
            }
        }
    }
}
