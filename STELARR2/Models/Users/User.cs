using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR2.Models.Users
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _username;
        private string _email;


        public User(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
            _password = "";
            _username = "";
            _email = "";
            _id = 0;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
