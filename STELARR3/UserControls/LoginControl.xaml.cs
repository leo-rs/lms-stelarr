using STELARR3.Classes.Data;
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
        private string name = "Leo";
        private string last = "Ras";
        private bool _loggedIn;
        private Session _sesh;

        private Excel xl;

        public LoginControl()
        {
            InitializeComponent();

        }

        public Session Sesh()
        {
            return _sesh;
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
                _sesh = new Session(new Learner(name, last));
                LoginWarning.Visibility = Visibility.Hidden;
                this.Visibility = Visibility.Hidden;
            }
            else
                LoginWarning.Visibility = Visibility.Visible;
        }

        public bool LoginSuccess()
        {
            return _loggedIn;
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
                int i = 0;
                int j = 0;

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

            bool success;
            string user = UserTxt.Text;
            string pw = PassTxt.Text;

            if (user == null || pw == null)
                success = false;
            if (user == "" || pw == "")
                success = false;
            else
                success = CreateAccount(user, pw);

            if (!success)
            {
                LoginWarning.Text = "Create Account Failed";
                LoginWarning.Background = new SolidColorBrush(Colors.Red);
                LoginWarning.Foreground = new SolidColorBrush(Colors.Black);
                LoginWarning.Visibility = Visibility.Visible;
            }
            else
            {
                LoginWarning.Text = "Account Created";
                LoginWarning.Background = new SolidColorBrush(Colors.Green);
                LoginWarning.Foreground = new SolidColorBrush(Colors.White);
                LoginWarning.Visibility = Visibility.Visible;
            }
                

            CreateAccountBtn.Visibility=Visibility.Hidden;
            LoginBtn.Visibility = Visibility.Visible;
            NewAccountBtn.Visibility = Visibility.Visible;
            UserTxt.Text = "";
            PassTxt.Text = "";

        }

        public bool CreateAccount(string user, string pw)
        {
            
            Excel wxl = new Excel(@"C:\Users\janle\source\repos\lms-stelarr\STELARR3\Resources\Files\users.xlsx", 1);

            int i = 3;
            int j = 1;
            

            wxl.WriteCell(i, j, user);
            wxl.WriteCell(i, j+1, pw);
            wxl.SaveWorkbook();
            wxl.CloseWorkbook();

            return true;
        }




    }
}
