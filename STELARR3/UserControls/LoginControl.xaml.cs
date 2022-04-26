using STELARR3.Classes.Excel;
using STELARR3.Classes.Users;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace STELARR3.UserControls
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        private string _username;
        private string _password;
        private bool _loggedIn;
        private Excel xl;

        public LoginControl()
        {
            InitializeComponent();
        }

        public string Username()
        {
            if (_username == null)
                return "";
            else
                return _username;
        }

        public string Password()
        {
            if (_password == null)
                return "";
            else 
                return _password;
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWarning.Visibility = Visibility.Hidden;
            LoginWarning.Text = "Login Failed";
            LoginWarning.Background = new SolidColorBrush(Colors.Red);
            LoginWarning.Foreground = new SolidColorBrush(Colors.Black);

            _username = UserTxt.Text;
            _password = PassTxt.Text;

            _loggedIn = Authenticate(_username, _password);

            if (_loggedIn)
            {
                LoginWarning.Visibility = Visibility.Hidden;
                this.Visibility = Visibility.Hidden;
            }
            else
                LoginWarning.Visibility = Visibility.Visible;
        }

        public bool Authenticate(string username, string password)
        {

            if (username == null || password == null)
                return false;
            if (username == "" || password == "")
                return false;
            else
            {
                xl = new Excel(@"C:\Users\janle\source\repos\lms-stelarr\STELARR3\Resources\Files\users.xlsx", 1);
                int i = 1;
                int j = 1;

                while (i <= 5)
                {
                    if (xl.ReadCell(i, j) == username && xl.ReadCell(i, j + 1) == password)
                    {
                        xl.CloseWorkbook();
                        return true;
                    }
                    else
                        i++;
                }

                xl.CloseWorkbook();
                return false;
            }
        }

        private void NewAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWarning.Visibility = Visibility.Hidden;

            UserTxt.Text = "";
            PassTxt.Text = "";
            LoginBtn.Visibility = Visibility.Hidden;
            NewAccountBtn.Visibility = Visibility.Hidden;
            CreateAccountBtn.Visibility = Visibility.Visible;
        }

        private void CreateAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWarning.Visibility = Visibility.Hidden;
            LoginWarning.Text = "Create Account Failed";
            LoginWarning.Background = new SolidColorBrush(Colors.Red);
            LoginWarning.Foreground = new SolidColorBrush(Colors.Black);

            if (UserTxt.Text != null && PassTxt.Text != null)
            {
                xl = new Excel(@"C:\Users\janle\source\repos\lms-stelarr\STELARR3\Resources\Files\users.xlsx", 1);
                
                int i = 1;
                int j = 1;
                while (i <= 5)
                {
                    if (xl.ReadCell(i, j) == "")
                    {
                        xl.WriteCell(i, j, (string)UserTxt.Text, (string)PassTxt.Text);
                        LoginWarning.Visibility = Visibility.Visible;
                        break;
                    }
                    else
                        i++;
                    
                }

                xl.SaveWorkbook();
            }

            CreateAccountBtn.Visibility=Visibility.Hidden;
            LoginBtn.Visibility = Visibility.Visible;
            NewAccountBtn.Visibility = Visibility.Visible;
            UserTxt.Text = "";
            PassTxt.Text = "";

        }
    }
}
