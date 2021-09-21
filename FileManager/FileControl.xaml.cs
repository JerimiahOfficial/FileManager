using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace FileManager
{
    /// <summary>
    /// Interaction logic for File.xaml
    /// </summary>
    public partial class FileControl : UserControl
    {
        public FileControl()
        {
            InitializeComponent();
        }

        public string Filepath { get; set; }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) => FileName.Content = Path.GetFileName(Filepath);

        private void FileUpdate() => FileName.Content = Path.GetFileName(Filepath);

        private void ButtonHandler(object sender, RoutedEventArgs e)
        {
            var b = (Button)sender;
            switch (b.Name)
            {
                case "OpenLoc":
                    Process.Start("explorer.exe", Path.GetDirectoryName(Filepath));
                    break;

                case "OpenFile":
                    Process.Start("explorer.exe", Filepath);
                    break;

                case "RenameFile":
                    var RW = new RenameWindow();
                    if (RW.ShowDialog() == true)
                    {
                        File.Move(Filepath, Path.GetDirectoryName(Filepath) + @"\" + RW.NewName + Path.GetExtension(Filepath));
                        Filepath = Path.GetDirectoryName(Filepath) + @"\" + RW.NewName + Path.GetExtension(Filepath);
                        FileUpdate();
                    }
                    break;

                case "CopyFile":
                    var paths = new StringCollection();
                    paths.Add(Filepath);
                    Clipboard.SetFileDropList(paths);
                    break;

                case "DeleteFile":
                    var DW = new DeleteWindow();
                    if (DW.ShowDialog() == true)
                    {
                        File.Delete(Filepath);
                        ((Panel)this.Parent).Children.Remove(this);
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
