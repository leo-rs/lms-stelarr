using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace WPFSTELARR1.Controls
{
    /// <summary>
    /// Interaction logic for CreateAccountControl.xaml
    /// </summary>
    public partial class CreateAccountControl : UserControl
    {
        
        public CreateAccountControl()
        {
            InitializeComponent();
        }

        
        private void cancelCrAccButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }

        private void createAccButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
