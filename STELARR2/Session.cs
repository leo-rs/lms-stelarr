using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STELARR2.Models;
using STELARR2.Models.Lib;
using STELARR2.Models.Portfolio;
using STELARR2.Models.Portfolio.Lessons;
using STELARR2.Models.Users;

namespace STELARR2
{
    public class Session
    {
        private User _user;
        private Learner _learner;
        private Library _userLib;

        public Session(User user)
        {
            _user = user;
        }

        public Session(Learner learner)
        {
            _learner = learner;
            _userLib = new Library();

            Excel xl = new Excel(@"C:\Users\janle\source\repos\lms-stelarr\STELARR2\Files\lessons.xlsx", 1);

            Folder f = new Folder(xl.ReadCell(0,1));
            for (int j = 0; j <= 10; j++)
            {
                Lesson l = new Lesson(xl.ReadCell(0,1), xl.ReadCell(j,1));
                f.Add(l);
            }
            _userLib.Add(f);

            Folder f2 = new Folder(xl.ReadCell(0, 0));
            for (int j = 0; j <= 10; j++)
            {
                Lesson l = new Lesson(xl.ReadCell(0, 0), xl.ReadCell(j, 0));
                f2.Add(l);
            }
            _userLib.Add(f2);

            Folder f3 = new Folder(xl.ReadCell(0, 2));
            for (int j = 0; j <= 10; j++)
            {
                Lesson l = new Lesson(xl.ReadCell(0, 2), xl.ReadCell(j, 2));
                f3.Add(l);
            }
            _userLib.Add(f3);

            _learner.UserLibrary = _userLib;

            xl.CloseWorkbook();
        }

        public void CreateLibrary(Library lib, int module)
        {

        }


        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public Learner Learner
        {
            get { return _learner; }
            set { _learner = value; }
        }

        public bool Validate(string username, string password)
        {
            if (_user.Username == username && _user.Password == password)
                return true;
            else
                return false;
        }

    }
}
