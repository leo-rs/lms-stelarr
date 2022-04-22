using Caliburn.Micro;
using STELARR2.Models.Portfolio;
using STELARR2.Models.Portfolio.Lessons;
using STELARR2.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace STELARR2.ViewModels
{
    public class LibraryViewModel : Conductor<object>
    {
        private Learner _learner;
        private string _content = "Click next to begin lesson.";
        private Folder _currFolder;
        private int _curr = 0;

        public LibraryViewModel(Learner learner)
        {
            _learner = learner;
            _currFolder = _learner.UserLibrary.GetFolderAt(0);
        }

        public string Content
        {
            get { return _content; }
            set 
            {
                _content = value;
                NotifyOfPropertyChange(() => Content);
            }
        }

        
        public void LoadNumbers()
        {
            _currFolder = _learner.UserLibrary.GetFolderAt(1);
            _curr = 0;
            _content = "Click next to begin lesson.";
            NotifyOfPropertyChange(() => Content);
        }

        public void LoadMath()
        {
            _currFolder = _learner.UserLibrary.GetFolderAt(0);
            _curr = 0;
            _content = "Click next to begin lesson.";
            NotifyOfPropertyChange(() => Content);
        }

        public void LoadLetters()
        {
            _currFolder = _learner.UserLibrary.GetFolderAt(2);
            _curr = 0;
            _content = "Click next to begin lesson.";
            NotifyOfPropertyChange(() => Content);
        }

        public void NextPage()
        {
            _curr++;

            if (_curr < _currFolder.Size)
            {
                string s1 = _currFolder.GetLesson(_curr).Content;
                string s2 = s1.Replace(",", "\n");
                Content = s2;
                //lblPage.Content = (String)"" + (n + 1) + "/" + lp.GetSize();

                NotifyOfPropertyChange(() => Content);
            }
            else
            {
                _curr = _currFolder.Size - 1;
                MessageBox.Show("You have reached the end of this lesson.");
            }
        }

        public void PreviousPage()
        {
            _curr--;

            if (_curr >= 1)
            {
                string s1 = _currFolder.GetLesson(_curr).Content;
                string s2 = s1.Replace(",", "\n");
                Content = s2;
                //lblPage.Content = (String)"" + (n + 1) + "/" + lp.GetSize();

                NotifyOfPropertyChange(() => Content);
            }
            else
            {
                _curr = 1;
                MessageBox.Show("You have reached the beginning this lesson.");
            }

        }

        public bool CanNextPage()
        {
            return _curr < _currFolder.Size;
        }

        public bool CanPreviousPage()
        {
            return _curr >= 0;
        }
    }
}
