using Caliburn.Micro;
using STELARR2.Models;
using STELARR2.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace STELARR2.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private Session _session;

        private DateTime d;
        private string _clock;
        private DispatcherTimer timer = new DispatcherTimer();

        private DashboardViewModel dash;
        private LibraryViewModel lib;
        private LoginViewModel login;

        private bool _menuBarIsVisible = false;

        private string user;
        private string password;
        private bool loginSuccess;

        public ShellViewModel()
        {

            login = new LoginViewModel();

            ActiveItem = login;

            ActivateMenu();
            
        }

        public void ActivateMenu()
        {
            if (user != null)
            {
                timer.Tick += DashTimer;
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Start();

                _session = new Session(new Learner(user, password));

                dash = new DashboardViewModel(_session.Learner);
                lib = new LibraryViewModel(_session.Learner);

                ActiveItem = dash;
                MenuBarIsVisible = true;
            }
        }


        public Session Session
        {
            get { return _session; }
        }

        private void DashTimer(object sender, EventArgs e)
        {
            d = DateTime.Now;
            _clock = d.Hour + " : " + d.Minute;
            NotifyOfPropertyChange(() => Clock);
        }

        public string Clock
        {
            get { return _clock; }
        }

        public void LoadLibrary()
        {
            ActivateItemAsync(lib);
        }

        public void LoadHome()
        {
            ActivateItemAsync(dash);
        }

        public bool MenuBarIsVisible
        {
            get { return _menuBarIsVisible; }
            set
            {
                _menuBarIsVisible = value;
                NotifyOfPropertyChange(() => MenuBarIsVisible);
            }
        }

    }
}
