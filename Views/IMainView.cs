using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8.Views
{
    public interface IMainView
    {
        string Directory1 { get; set; }
        string Directory2 { get; set; }
        void SetDifferences(List<Models.FileDifference> differences);
        void ShowMessage(string message);
    }
}
