using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSTELARR1
{
    class AssessmentData : PageData
    {
        private int[] AnswerKey = new int[5];
        private string[] Questions = new string[5];
        private double Grade;

        public AssessmentData(int n, string title, string desc): base(n, title, desc)
        {
        }

        public void SetQuestions(int n, string s) 
        {
            Questions[n] = s;
        }

        public void SetAnswerKey(int n, int a)
        {
            AnswerKey[n] = a;
        }

        public double GetGrade(int n)
        {
            Grade = n / 5;
            return Grade;
        }

        public char GetLetterGrade()
        {
            if (Grade == 1)
                return 'A';
            else if (Grade == 0.80)
                return 'B';
            else if (Grade == 0.70)
                return 'C';
            else if (Grade == 0.60)
                return 'D';
            else
                return 'F';
        }

    }
}
