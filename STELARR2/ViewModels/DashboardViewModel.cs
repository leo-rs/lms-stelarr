using STELARR2.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR2.ViewModels
{
    public class DashboardViewModel
    {
        private User _user;

        public DashboardViewModel(User user)
        {
            _user = user;
        }

        public string FullName
        {
            get { return _user.FirstName + " " + _user.LastName + "!"; }
        }

    }
}
