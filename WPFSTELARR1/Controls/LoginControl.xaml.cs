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

namespace WPFSTELARR1.Controls
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        int counter = 0;
        public void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (usernameEnter.Text == "" && passwordEnter.Password == "")
            {
                loginErrorMessage.Text = "Please Enter a Username and Password";
            }
            else if (usernameEnter.Text == "y" && passwordEnter.Password == "y")
            {
                Visibility = Visibility.Collapsed;
            }
            else
            {
                counter++;
                loginErrorMessage.Text = $"Invalid Credentials (Attempt {counter})";
            }
            if (counter == 3)
            {
                loginErrorMessage.Text = "Account Locked";
            }
        }

        private void createAccButton(object sender, RoutedEventArgs e)
        {
            content.Content = new CreateAccountControl();
        }
    }
}
