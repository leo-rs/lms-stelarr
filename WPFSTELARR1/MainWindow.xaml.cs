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
using WPFSTELARR1.Classes;
using WPFSTELARR1.Controls;

//Leo Ras
namespace WPFSTELARR1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LessonPage fPage = new LessonPage();
        Folder f1 = new Folder(0, "Math Folder");
        Folder f2 = new Folder(1, "Reading Folder");
        Folder a1 = new Folder(0, "Math Assessment");
        Folder curr;
        int n = 0;

        LessonWindow lw = new LessonWindow();


        public MainWindow()
        {
            InitializeComponent();
            content.Content = new LoginControl();
      

            PageData page1m = new PageData(1, "Addition", "1 + 1 = 2 \n1 + 2 = 3 \n2 + 2 = 4");
            PageData page2m = new PageData(2, "Subtraction", "2 - 1 = 1 \n5 - 2 = 3 \n8 - 4 = 4");
            PageData page3m = new PageData(3, "Multiplication", "3 x 2 = 6 \n1 x 3 = 3 \n2 x 2 = 4");
            PageData page4m = new PageData(4, "Division", "10 / 2 = 5 \n12 / 4 = 3 \n8 / 2 = 4");

            f1.Staple(page1m);
            f1.Staple(page2m);
            f1.Staple(page3m);
            f1.Staple(page4m);

            PageData page1e = new PageData(1, "Vowels", "A a \nE e \nI i \nO o \nU u");
            PageData page2e = new PageData(2, "Consonants", "B b \nC c \nD d");
            PageData page3e = new PageData(3, "Consonants", "X x \nY y \nZ z");
            PageData page4e = new PageData(4, "Sounds", "A - Apple \nB - Boy \nC - Cat");

            f2.Staple(page1e);
            f2.Staple(page2e);
            f2.Staple(page3e);
            f2.Staple(page4e);

            AssessmentData test1m = new AssessmentData(0, "Math Test 1", "Addition");
            string q1, q2, q3, q4, q5;

            q1 = "20 + 3";
            q2 = q1 + " + 6";
            q3 = q2 + " + 19";
            q4 = q3 + " + 38";
            q5 = q4 + " + 55";

            test1m.SetQuestions(0, q1);
            test1m.SetQuestions(1, q2);
            test1m.SetQuestions(2, q3);
            test1m.SetQuestions(3, q4);
            test1m.SetQuestions(4, q5);

            test1m.SetAnswerKey(0, 2);
            test1m.SetAnswerKey(1, 1);
            test1m.SetAnswerKey(2, 1);
            test1m.SetAnswerKey(3, 2);
            test1m.SetAnswerKey(4, 0);

            FrameLeft.Content = fPage;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("See ya!");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            string msg = "Do you want to close without saving?";
            MessageBoxResult result = MessageBox.Show(msg, "STELARR", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            Previous.IsEnabled = true;
            n++;
            if (n < f1.GetSize())
            {
                fPage.TopText.Text = curr.GetPacketDataAt(n).ToString();
                FrameLeft.Content = fPage;
            }
            else
            {
                Next.IsEnabled = false;
                n = curr.GetSize() - 1;
                MessageBox.Show("You have reached the end of this lesson.");
            }
        }

        private void Button_Click_Previous(object sender, RoutedEventArgs e)
        {
            Next.IsEnabled = true;
            n--;
            if (n >= 0)
            {
                fPage.TopText.Text = curr.GetPacketDataAt(n).ToString();
                FrameLeft.Content = fPage;
            }
            else {
                Previous.IsEnabled = false;
                n = 0;
                MessageBox.Show("You have viewed all contents of this lesson.");
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            n = -1;
            if (ModuleCombo.SelectedIndex == 0)
            {
                curr = f1;
                fPage.TopText.Text = "Module 1 Selected";
                Previous.IsEnabled = false;
                Next.IsEnabled = true;
            }
            if (ModuleCombo.SelectedIndex == 1)
            {
                curr = f2;
                fPage.TopText.Text = "Module 2 Selected";
                Previous.IsEnabled = false;
                Next.IsEnabled = true;
            }
        }

        private void Button_Click_Assess(object sender, RoutedEventArgs e)
        {
            AssessmentPage a1 = new AssessmentPage();
            FrameLeft.Content = a1;
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            content.Content = new LoginControl();
        }
    }
}
 