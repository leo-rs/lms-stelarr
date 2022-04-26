using STELARR3.Classes.Folio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR3.Classes.Users
{
    public class Learner : User
    {
        private int _gradeLevel;
        private double _gpa;
        private Library _userLibrary;


        public Learner(string firstname, string lastname) : base(firstname, lastname)
        {
            _gradeLevel = 0;
            _gpa = 0;
            _userLibrary = new Library();
        }

        public Library UserLibrary
        {
            get { return _userLibrary; }
            set { _userLibrary = value; }
        }

        public double GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public int GradeLevel
        {
            get { return _gradeLevel; }
            set { _gradeLevel = value; }
        }

    }
}
