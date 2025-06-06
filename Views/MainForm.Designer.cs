namespace Laba_8.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDir1 = new System.Windows.Forms.TextBox();
            this.txtDir2 = new System.Windows.Forms.TextBox();
            this.btnBrowseDir1 = new System.Windows.Forms.Button();
            this.btnBrowseDir2 = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.lstDifferences = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDir1
            // 
            this.txtDir1.Location = new System.Drawing.Point(12, 25);
            this.txtDir1.Name = "txtDir1";
            this.txtDir1.Size = new System.Drawing.Size(300, 20);
            this.txtDir1.TabIndex = 0;
            // 
            // txtDir2
            // 
            this.txtDir2.Location = new System.Drawing.Point(12, 64);
            this.txtDir2.Name = "txtDir2";
            this.txtDir2.Size = new System.Drawing.Size(300, 20);
            this.txtDir2.TabIndex = 1;
            // 
            // btnBrowseDir1
            // 
            this.btnBrowseDir1.Location = new System.Drawing.Point(318, 23);
            this.btnBrowseDir1.Name = "btnBrowseDir1";
            this.btnBrowseDir1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDir1.TabIndex = 2;
            this.btnBrowseDir1.Text = "Обзор...";
            this.btnBrowseDir1.UseVisualStyleBackColor = true;
            this.btnBrowseDir1.Click += new System.EventHandler(this.btnBrowseDir1_Click);
            // 
            // btnBrowseDir2
            // 
            this.btnBrowseDir2.Location = new System.Drawing.Point(318, 62);
            this.btnBrowseDir2.Name = "btnBrowseDir2";
            this.btnBrowseDir2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDir2.TabIndex = 3;
            this.btnBrowseDir2.Text = "Обзор...";
            this.btnBrowseDir2.UseVisualStyleBackColor = true;
            this.btnBrowseDir2.Click += new System.EventHandler(this.btnBrowseDir2_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(12, 90);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(381, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Сравнить директории";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(12, 119);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(381, 23);
            this.btnSync.TabIndex = 5;
            this.btnSync.Text = "Синхронизировать";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // lstDifferences
            // 
            this.lstDifferences.FormattingEnabled = true;
            this.lstDifferences.Location = new System.Drawing.Point(12, 148);
            this.lstDifferences.Name = "lstDifferences";
            this.lstDifferences.Size = new System.Drawing.Size(381, 199);
            this.lstDifferences.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Директория 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Директория 2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDifferences);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnBrowseDir2);
            this.Controls.Add(this.btnBrowseDir1);
            this.Controls.Add(this.txtDir2);
            this.Controls.Add(this.txtDir1);
            this.Name = "MainForm";
            this.Text = "Синхронизация директорий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtDir1;
        private System.Windows.Forms.TextBox txtDir2;
        private System.Windows.Forms.Button btnBrowseDir1;
        private System.Windows.Forms.Button btnBrowseDir2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.ListBox lstDifferences;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}