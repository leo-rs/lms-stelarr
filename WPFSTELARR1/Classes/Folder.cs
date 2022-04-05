using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSTELARR1.Classes
{
    public class Folder
    {
        //create generic list
        int FolderID;
        string FolderName;
        List<PageData> Packet;
        int FolderSize;
        bool IsCompleted;

        public Folder(int i, string n)
        {
            Packet = new List<PageData>();
            FolderName = n;
            FolderID = i;
            FolderSize = 0;
            IsCompleted = false;
        }

        public Folder() : this(0, "NEW")
        {
        }

        //setters
        public void SetName(string n)
        {
            FolderName = n;
        }

        public void SetID(int id)
        {
            FolderID = id;
        }

        public void Complete()
        {
            IsCompleted = true;
        }

        //list functions (add and remove pages)
        public void Staple(PageData d)
        {
            Packet.Add(d);
            FolderSize++;
        }

        public void Discard(int i)
        {
            Packet.RemoveAt(i);
            FolderSize--;
        }

        //getters
        public int GetID()
        {
            return FolderID;
        }

        public string GetName()
        {
            return FolderName;
        }

        public bool Completed()
        {
            return IsCompleted;
        }

        public int GetSize()
        {
            return FolderSize;
        }

        public List<PageData> GetPacket()
        {
            return Packet;
        }

        public PageData GetPacketDataAt(int i)
        {
            return Packet[i];
        }

        public override string ToString()
        {
            String completionStatus;
            if (IsCompleted)
                completionStatus = "-COMPLETE-";
            else
                completionStatus = "-INCOMPLETE-";
            return "\n" + FolderID + ": " + FolderName +
                " (" + FolderSize + ") " + completionStatus;
        }
    }
}

