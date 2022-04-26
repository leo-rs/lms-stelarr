using STELARR3.Classes.Users;
using STELARR3.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace STELARR3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User _current;

        public MainWindow()
        {
            InitializeComponent();
            screen.Content = new LoginControl();
            activeView.Content = new DashControl();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("See you later!");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string msg = "Do you want to exit STELARR?";
            MessageBoxResult result = MessageBox.Show(msg, "Exit", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
