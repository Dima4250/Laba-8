using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8.Models
{
    public enum FileDifferenceType
    {
        Created,
        Modified,
        Deleted
    }

    public class FileDifference
    {
        public string FileName { get; set; }
        public FileDifferenceType Type { get; set; }
        public string SourceDirectory { get; set; }
        public string TargetDirectory { get; set; }

        public override string ToString()
        {
            string action;
            switch (Type)
            {
                case FileDifferenceType.Created:
                    action = "создан";
                    break;
                case FileDifferenceType.Modified:
                    action = "изменен";
                    break;
                case FileDifferenceType.Deleted:
                    action = "удален";
                    break;
                default:
                    action = "неизвестное действие";
                    break;
            }

            return $"Файл\t\"{FileName}\" {action}";
        }
    }
}
