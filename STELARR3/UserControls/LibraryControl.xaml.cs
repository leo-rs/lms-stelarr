using STELARR3.Classes.Folio;
using STELARR3.Classes.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace STELARR3.UserControls
{
    public partial class LibraryControl : UserControl
    {

        Learner _learner;
        Folder _currFolder;
        int _curr = 0;
        string _content = "Click next to begin lesson.";

        public LibraryControl(Learner learner)
        {
            InitializeComponent();
            _learner = learner;
        }

        private void LoadNumbers_Click(object sender, RoutedEventArgs e)
        {
            _currFolder = _learner.UserLibrary.GetFolderAt(1);
            _curr = 0;
            Content.Text = _content;
        }


        private void LoadMath_Click(object sender, RoutedEventArgs e)
        {
            _currFolder = _learner.UserLibrary.GetFolderAt(0);
            _curr = 0;
            Content.Text = _content;
        }

        private void LoadLetters_Click(object sender, RoutedEventArgs e)
        {
            _currFolder = _learner.UserLibrary.GetFolderAt(2);
            _curr = 0;
            Content.Text = _content;
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            _curr--;

            if (_curr >= 1)
            {
                string s1 = _currFolder.GetLesson(_curr).Content;
                string s2 = s1.Replace(",", "\n");
                Content.Text = s2;
            }
            else
            {
                _curr = 1;
                MessageBox.Show("You have reached the beginning this lesson.");
            }
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            _curr++;

            if (_curr < _currFolder.Size)
            {
                string s1 = _currFolder.GetLesson(_curr).Content;
                string s2 = s1.Replace(",", "\n");
                Content.Text = s2;
            }
            else
            {
                _curr = _currFolder.Size - 1;
                MessageBox.Show("You have reached the end of this lesson.");
            }
        }

    }
}
