using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba_8.Presenters;
using Laba_8.Views;

namespace Laba_8
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new MainForm();
            var presenter = new MainPresenter(view);
            view.Tag = presenter;

            Application.Run(view);
        }
    }
}
