using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FileManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool windstate;
        private bool toolsMenu;
        private string path;
        private List<string> files = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        /* Directory */
        private void OpenFolder()
        {
            using (var folder = new System.Windows.Forms.FolderBrowserDialog())
            {
                if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!folder.SelectedPath.Contains(@"C:\Windows") && Directory.Exists(folder.SelectedPath))
                        folderViewUpdate(folder.SelectedPath);
                    else
                    {
                        MessageBox.Show("This directory cannot be selected.", "File Manager",
                            (MessageBoxButton)System.Windows.Forms.MessageBoxButtons.OK,
                            (MessageBoxImage)System.Windows.Forms.MessageBoxIcon.Warning);
                        path = "";
                    }
                }
            }
        }

        private void folderViewUpdate(string s)
        {
            path = s;
            FolderDirectory.Text = s;
            files = new List<string>(Directory.EnumerateFiles(s));
            FolderPopulate();
        }

        private void FolderPopulate()
        {
            FilesContainer.Children.Clear();
            files.Sort((x, y) => x.Length.CompareTo(y.Length));

            foreach (var filePath in files)
            {
                var filePanel = new FileControl();
                filePanel.Filepath = filePath;
                filePanel.Margin = new Thickness(5);
                FilesContainer.Children.Add(filePanel);
                Debug.WriteLine("Adding file: " + filePath);
            }
        }

        /* File Actions */
        private void RenameAllFiles()
        {
            var RW = new RenameWindow();
            if (RW.ShowDialog() == true)
            {
                int tag = 0;

                foreach (var file in files)
                {
                    File.Move(file, path + "/" + RW.NewName + "_" + tag + Path.GetExtension(file));
                    tag += 1;
                }

                folderViewUpdate(path);
            }
        }

        private void DeleteAllFiles()
        {
            var DW = new DeleteWindow();
            if (DW.ShowDialog() == true)
            {
                foreach (var file in files)
                    File.Delete(file);

                folderViewUpdate(path);
            }
        }

        static string GetHash(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return Encoding.UTF8.GetString(new SHA1Managed().ComputeHash(fileStream));
            }
        }

        private void DeleteAllDupes()
        {
            var DW = new DeleteWindow();
            if (DW.ShowDialog() == true)
            {
                Directory.GetFiles(path)
                    .Select(f => new { FileName = f, FileHash = GetHash(f) })
                    .GroupBy(f => f.FileHash)
                    .Select(g => new { FileHash = g.Key, Files = g.Select(z => z.FileName).ToList() })
                    .SelectMany(f => f.Files.Skip(1))
                    .ToList()
                    .ForEach(File.Delete);

                folderViewUpdate(path);
            }
        }

        private void ButtonHandler(object sender, RoutedEventArgs e)
        {
            var b = (Button)sender;
            switch (b.Name)
            {
                /* Titlebar buttons */
                case "CloseApplication":
                    Application.Current.Shutdown();
                    break;

                case "WinState":
                    windstate = !windstate;
                    WindowState = windstate ? WindowState.Maximized : WindowState.Normal;
                    WinState.Content = windstate ? "2" : "1";
                    break;

                case "Minimize":
                    WindowState = WindowState.Minimized;
                    break;

                /* Folder */
                case "OpenDirectory":
                    OpenFolder();
                    break;

                /* Major actions */
                case "RenameAll":
                    RenameAllFiles();
                    break;

                case "DeleteAll":
                    DeleteAllFiles();
                    break;

                case "DeleteDup":
                    DeleteAllDupes();
                    break;

                case "OpenTools":
                    toolsMenu = !toolsMenu;
                    Content.Width = toolsMenu ? 675 : 800;
                    break;

                default:
                    break;
            }
        }

        private void DragControl(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
