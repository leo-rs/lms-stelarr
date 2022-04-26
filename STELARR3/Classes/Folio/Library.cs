using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR3.Classes.Folio
{
    public class Library
    {
        private int _id;
        private int _size;
        private string _name;
        private List<Folder> _books;

        public Library(int id, string name)
        {
            _id = id;
            _name = name;
            _books = new List<Folder>();
            _size = 0;
        }

        public Library() : this(0, "Unnamed") { }


        public void Add(Folder value)
        {
            _books.Add(value);
            _size++;
        }

        public void Remove(int id)
        {
            _books.RemoveAt(id);
            _size--;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Folder GetFolderAt(int i)
        {
            if (_size == 0)
                return null;
            else
                return _books[i];
        }

        public string PrintLibrary()
        {
            string content = "";
            foreach (Folder folder in _books)
                content += folder.Name + "\n";
            return content;
        }

    }
}
