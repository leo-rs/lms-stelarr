using Caliburn.Micro;
using STELARR2.Models.Portfolio.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR2.ViewModels
{
    public class LibraryListViewModel : Conductor<object>
    {

        private BindableCollection<Lesson> _lessons = new BindableCollection<Lesson>();

        public LibraryListViewModel()
        {
        }

        public BindableCollection<Lesson> Lessons
        {
            get { return _lessons; }
            set { _lessons = value; }
        }

    }
}
