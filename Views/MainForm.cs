using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba_8.Models;

namespace Laba_8.Views
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string Directory1
        {
            get => txtDir1.Text;
            set => txtDir1.Text = value;
        }

        public string Directory2
        {
            get => txtDir2.Text;
            set => txtDir2.Text = value;
        }

        public void SetDifferences(List<FileDifference> differences)
        {
            lstDifferences.Items.Clear();
            foreach (var diff in differences)
            {
                lstDifferences.Items.Add(diff.ToString());
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBrowseDir1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Directory1 = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnBrowseDir2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Directory2 = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Directory1) || string.IsNullOrEmpty(Directory2))
            {
                ShowMessage("Пожалуйста, выберите обе директории");
                return;
            }

            var presenter = this.Tag as Presenters.MainPresenter;
            presenter?.CompareDirectories();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Directory1) || string.IsNullOrEmpty(Directory2))
            {
                ShowMessage("Пожалуйста, выберите обе директории");
                return;
            }

            var presenter = this.Tag as Presenters.MainPresenter;
            presenter?.SynchronizeDirectories();
        }
    }
}
