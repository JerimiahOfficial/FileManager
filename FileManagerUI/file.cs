using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileManagerUI {
    public partial class file : UserControl {
        public file() {
            InitializeComponent();
        }

        private string FilePath;
        public string filepath {
            get => FilePath;
            set => FilePath = value;
        }

        private void Location_Click(object sender, EventArgs e) {
            Process.Start(Path.GetDirectoryName(FilePath));
        }

        private void Open_Click(object sender, EventArgs e) {
            Process.Start(FilePath);
        }

        private void Rename_Click(object sender, EventArgs e) {
            var r = new Regex("^[a-zA-Z0-9 _]*$");
            var newName = Interaction.InputBox("", "Renaming '" + Path.GetFileName(FilePath) + "'", "");

            if (r.IsMatch(newName) && newName.Length > 0) {
                File.Move(FilePath, Path.GetDirectoryName(FilePath) + @"\" + newName + Path.GetExtension(FilePath));
                FilePath = Path.GetDirectoryName(FilePath) + @"\" + newName + Path.GetExtension(FilePath);
                FileUpdate();
            }
            else {
                MessageBox.Show("Must enter a name and can't include special characters.", "Rename cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Refresh();
        }

        private void Copy_Click(object sender, EventArgs e) {

        }

        private void Delete_Click(object sender, EventArgs e) {
            File.Delete(FilePath);
            this.Dispose();
        }

        private void file_Load(object sender, EventArgs e) {
            FileName.Text = Path.GetFileName(FilePath);
        }

        private void FileUpdate() {
            FileName.Text = Path.GetFileName(FilePath);
        }
    }
}
