using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STELARR2.Models.Users;

namespace STELARR2
{
    public class Session
    {
        private User _user;

        public Session(User user)
        {
            _user = user;
        }

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
