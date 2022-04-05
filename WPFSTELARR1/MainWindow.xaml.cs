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
        int n = 0;

        public MainWindow()
        {
            InitializeComponent();

            PageData page1 = new PageData(1, "Addition", "1 + 1 = 2 \n1 + 2 = 3 \n2 + 2 = 4");
            PageData page2 = new PageData(2, "Subtraction", "2 - 1 = 1 \n5 - 2 = 3 \n8 - 4 = 4");
            PageData page3 = new PageData(3, "Multiplication", "3 x 2 = 6 \n1 x 3 = 3 \n2 x 2 = 4");
            PageData page4 = new PageData(4, "Division", "10 / 2 = 5 \n12 / 4 = 3 \n8 / 2 = 4");

            f1.Staple(page1);
            f1.Staple(page2);
            f1.Staple(page3);
            f1.Staple(page4);

            fPage.TopText.Text = page1.ToString();
            n = 1;
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
                e.Cancel=true;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (n < f1.GetSize())
            {
                fPage.TopText.Text = f1.GetPacketDataAt(n++).ToString();
                FrameLeft.Content = fPage;
            }
            else
                MessageBox.Show("End of lesson.");
        }
    }
}
