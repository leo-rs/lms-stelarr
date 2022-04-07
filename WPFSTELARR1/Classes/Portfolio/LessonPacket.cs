using System;
using WPFSTELARR1.Classes;

namespace WPFSTELARR1
{
    class LessonPacket : Folder
    {
        private string MainContent;
        private string Description;

        public void SetMainContent(string c)
        {
            MainContent = c;
        }

        public void SetDescription(string c)
        {
            Description = c;
        }

        public string GetMainContent()
        {
            if (MainContent == null)
                return "This packet has no main content.";
            return MainContent;
        }

        public string GetDescription()
        {
            if (Description == null)
                return "This packet has no content description.";
            return Description;

        }

        public void PrintPacket()
        {
            string packetContents = "\n   ";
            foreach (PageData p in this.GetPacket())
                packetContents += p.ToString() + "\n";
            Console.WriteLine(packetContents);
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nContent: " + this.GetMainContent() +
                "\nDescription: " + this.GetDescription();
        }
    }
}
