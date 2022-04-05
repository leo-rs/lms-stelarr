using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSTELARR1.Classes.LearningSystem;

namespace WPFSTELARR1.Classes.Users
{
    class Learner : User
    {
        private int GradeLevel;
        private double GPA;
        private Library LearnerLibrary;

        public void AddLibrary(Library l)
        {
            LearnerLibrary = l;
        }

        public void SetGradeLevel(int g)
        {
            GradeLevel = g;
        }

        public void SetGPA(double g)
        {
            GPA = g;
        }

        public int GetGradeLevel()
        {
            return GradeLevel;
        }

        public double GetGPA()
        {
            return GPA;
        }

        public Library GetLibrary()
        {
            return LearnerLibrary;
        }

        public override string ToString()
        {
            return base.ToString() + "\nGrade Level: " + GradeLevel + "\nGPA: " + GPA;
        }
    }
}
