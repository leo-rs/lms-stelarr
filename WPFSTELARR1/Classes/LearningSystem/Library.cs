using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSTELARR1.Classes.LearningSystem
{
    class Library
    {
        private int LibraryID;
        private List<Folder> Books;
        private int size;

        public Library(int i)
        {
            LibraryID = i;
            Books = new List<Folder>();
            size = 0;
        }

        public Library() : this(0) { }

        public void AddToLibrary(Folder d)
        {
            Books.Add(d);
            size++;
        }

        public void DeleteFromLibrary(int i)
        {
            Books.RemoveAt(i);
            size--;
        }

        public void PrintContents()
        {
            foreach (LessonPacket d in Books)
                Console.WriteLine(d.ToString());
        }
    }
}
