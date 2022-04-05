using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSTELARR1.Classes.Users
{
    class User
    {
        private int ID;
        private string FirstName;
        private string LastName;
        private string UserName;
        private string Pass;

        public User(int id, string fname, string lname, string uname, string pass)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            UserName = uname;
            Pass = pass;
        }

        public User() : this(0, "", "", "", "")
        {
        }

        public void SetID(int id)
        {
            ID = id;
        }

        public void SetFirstName(string fname)
        {
            FirstName = fname;
        }

        public void SetLastName(string lname)
        {
            LastName = lname;
        }

        public void SetUsername(string uname)
        {
            UserName = uname;
        }

        public void SetPassword(string pword)
        {
            Pass = pword;
        }

        public int GetID()
        {
            return ID;
        }

        public string GetName()
        {
            return FirstName + " " + LastName;
        }

        public string GetUsername()
        {
            return UserName;
        }

        public string GetPassword()
        {
            return Pass;
        }


        public override string ToString()
        {
            String n = "ID: " + ID +
                "\nName: " + FirstName + " " + LastName +
                "\nUsername: " + UserName +
                "\nPassword: " + Pass;
            return n;
        }
    }
}
