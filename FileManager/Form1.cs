using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form {
        public static List<string> files = new List<string>();
        public static string path;
        public static int oldfileCount;

        public Form1() {
            InitializeComponent();
        }

        private void OpenFolder(object sender, System.EventArgs e) {
            using (var folder = new FolderBrowserDialog()) {
                if (folder.ShowDialog() == DialogResult.OK) {
                    if (!folder.SelectedPath.Contains(@"C:\Windows") && Directory.Exists(folder.SelectedPath))
                        folderViewUpdate(folder.SelectedPath);
                    else {
                        MessageBox.Show("This directory cannot be selected.", "File Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        path = "";
                    }
                }
            }
        }

        private  void folderViewUpdate(string folderPath) {
            path = folderPath;
            folderDirectory.Text = folderPath;
            files = new List<string>(Directory.EnumerateFiles(folderPath));

            FolderPopulate();
        }

        private void FolderPopulate() {
            // Clear all previous folder items.
            folderView.Controls.Clear();

            files.Sort((x,y) => x.Length.CompareTo(y.Length));
            //files.Reverse(); 

            foreach (var filePath in files) {
                // Create a file panel and give file path.
                var filePanel = new FileManagerUI.file();
                filePanel.filepath = filePath;

                // Add panel to folder view.
                folderView.Controls.Add(filePanel);
            }
            oldfileCount = files.Count;
        }

        private void RenameAll_Click(object s, EventArgs e) {
            renameAll.Enabled = false;

            var newname = new TextBox();
            newname.Dock = DockStyle.Top;
            newname.Height = 30;
            newname.BackColor = Color.FromArgb(32, 32, 32);
            newname.ForeColor = Color.FromArgb(255, 255, 255);
            newname.BorderStyle = BorderStyle.FixedSingle;
            newname.KeyDown += RenameTxt;

            if (folderDirectory.Text.Length > 0) 
                folderOptions.Controls.Add(newname);
            else 
                MessageBox.Show("Must be in an active directory!", "File Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RenameTxt(object s, KeyEventArgs e) {
            var tb = (TextBox)s;
            tb.Focus();

            if (e.KeyCode == Keys.Enter) {
                if (tb.Text.Length > 0) {
                    int tag = 0;

                    foreach (var file in files) {
                        File.Move(file, path + "/" + tb.Text + "_" + tag + Path.GetExtension(file));
                        tag += 1;
                    }

                    renameAll.Enabled = true;
                    folderViewUpdate(path);
                    folderOptions.Controls.Remove(tb);
                }
                else 
                    MessageBox.Show("Must enter a name for the file to be renamed to.", "File Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e) {
            var verifyClick = MessageBox.Show("Are you sure you want to delete all files?", "File Manager", MessageBoxButtons.YesNo);

            if (verifyClick != DialogResult.Yes)
                return;

            if (folderDirectory.Text.Length > 0 || folderDirectory.Text != @"C:\Windows") 
                foreach (var file in files)
                    File.Delete(file);
            else if (folderDirectory.Text == @"C:\Windows") 
                MessageBox.Show("You don't really don't want to delete anything in here.", "File Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else 
                MessageBox.Show("Must be in an active directory!", "File Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            folderViewUpdate(path);
        }

        private void deleteDuplicates_Click(object sender, EventArgs e) {

        }
    }
}
