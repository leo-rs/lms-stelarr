using Caliburn.Micro;
using STELARR2.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR2.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _username;
        private string _password;
        private bool _success = false;


        public LoginViewModel()
        {
            _username = "Leo";
            _password = "Ras";
        }

        public bool Success
        {
            get { return _success; }
        }


        public string Password
        {
            get { return _password; }
            set
            { 
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }

        public string Username
        {
            get { return _username; }
            set 
            { 
                _username = value; 
                NotifyOfPropertyChange(() => Username);
            }
        }


        public void Login()
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                _success = true;
                this.TryCloseAsync();
            }
        }

    }
}
