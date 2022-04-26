using STELARR3.Classes.Folio.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR3.Classes.Folio

{
    public class Folder
    {
        private int _id;
        private string _name;
        private int _size;
        private List<Lesson> _packet;
        private bool _completionStatus;

        public Folder(string name)
        {
            _packet = new List<Lesson>();
            _name = name;
            _size = 0;
            _completionStatus = false;
        }

        public Lesson GetLesson(int i)
        {
            return _packet[i];
        }

        public void Add(Lesson value)
        {
            _packet.Add(value);
            _size++;
        }

        public void Discard(int i)
        {
            _packet.RemoveAt(i);
            _size--;
        }

        public bool CompletionStatus
        {
            get { return _completionStatus; }
            set { _completionStatus = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Clear()
        {
            _packet.Clear();
            _name = "";
            _size = 0;
            _completionStatus = false;
        }

        public string GetContents()
        {
            string contents = "";
            if (_size == 0)
                return "This folder is empty.";
            else
                for (int i = 0; i < _packet.Count; i++)
                    contents += "\n" + _packet[i].ToString();
            return contents;
        }

    }
}
