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
    /// <summary>
    /// Interaction logic for DashControl.xaml
    /// </summary>
    public partial class DashControl : UserControl
    {

        Learner _learner;

        public DashControl(Learner learner)
        {
            InitializeComponent();
            _learner = learner;

            User.Text = learner.FirstName + " " + learner.LastName;
        }
    }
}
