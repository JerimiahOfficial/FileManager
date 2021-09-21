using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FileManager
{
    /// <summary>
    /// Interaction logic for ConfirmationWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        public DeleteWindow()
        {
            InitializeComponent();
        }

        private void DragControl(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void ButtonHandler(object sender, RoutedEventArgs e)
        {
            var b = (Button)sender;
            switch (b.Name)
            {
                case "No":
                    this.Close();
                    break;

                case "Yes":
                    this.DialogResult = true;
                    break;

                default:
                    break;
            }
        }
    }
}
