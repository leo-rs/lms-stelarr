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
using System.Windows.Shapes;

namespace WPFSTELARR1
{
    /// <summary>
    /// Interaction logic for LessonView.xaml
    /// </summary>
    public partial class LessonWindow : Window
    {
        LessonPacket lp;
        int n=-1;

        public LessonWindow()
        {
            InitializeComponent();

            lp = new LessonPacket();

            PageData page1 = new PageData(1, "Addition", "1 + 1 = 2 \n1 + 2 = 3 \n2 + 2 = 4");
            PageData page2 = new PageData(2, "Subtraction", "2 - 1 = 1 \n5 - 2 = 3 \n8 - 4 = 4");
            PageData page3 = new PageData(3, "Multiplication", "3 x 2 = 6 \n1 x 3 = 3 \n2 x 2 = 4");
            PageData page4 = new PageData(4, "Division", "10 / 2 = 5 \n12 / 4 = 3 \n8 / 2 = 4");

            lp.Staple(page1);
            lp.Staple(page2);
            lp.Staple(page3);
            lp.Staple(page4);

            txtContent.Text = (String)"Click (Next Page) to being lesson.";
            lblPage.Content = (String)"0/" + lp.GetSize();

        }

        private void btnPre_Click(object sender, RoutedEventArgs e)
        {
            btnNex.IsEnabled = true;
            n--;
            if (n >= 0)
            {
                txtContent.Text = lp.GetPacketDataAt(n).ToString();
                lblPage.Content = (String)""+ (n + 1) + "/" + lp.GetSize();
            }
            else
            {
                btnPre.IsEnabled = false;
                n = 0;
                MessageBox.Show("You have viewed all contents of this lesson.");
            }
        }

        private void btnNex_Click(object sender, RoutedEventArgs e)
        {
            btnPre.IsEnabled = true;
            n++;
            if (n < lp.GetSize())
            {
                txtContent.Text = lp.GetPacketDataAt(n).ToString();
                lblPage.Content = (String)"" + (n + 1) + "/" + lp.GetSize();
            }
            else
            {
                btnNex.IsEnabled = false;
                n = lp.GetSize() - 1;
                MessageBox.Show("You have reached the end of this lesson.");
            }
        }
    }
}
