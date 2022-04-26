using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR3.Classes.Library.Pages
{
    public class Lesson
    {
        private int _id;
        private string _subject;
        private string _title;
        private string _content;
        private string _description;

        public Lesson(string subject, string title, string content)
        {
            _id = 0;
            _subject = subject;
            _title = title;
            _content = content;
            _description = "Update description.";
        }

        public Lesson(string subject, string content)
        {
            _id = 0;
            _subject = subject;
            _title = "";
            _content = content;
            _description = "Update description.";
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }


        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
