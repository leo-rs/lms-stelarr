using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSTELARR1
{
    public class PageData
    {
        private int PageID;
        private string PageTitle;
        private string PageContent;

        public PageData(int id, string pt, string pc)
        {
            PageID = id;
            PageTitle = pt;
            PageContent = pc;
        }

        public PageData() : this(0, "", "")
        {
        }

        //setters
        public void SetID(int i)
        {
            PageID = i;
        }

        public void SetTitle(string t)
        {
            PageTitle = t;
        }

        public void SetContent(string c)
        {
            PageContent = c;
        }

        //getters
        public int GetID()
        {
            return PageID;
        }

        public string GetTitle()
        {
            return PageTitle;
        }

        public string GetContent()
        {
            return PageContent;
        }

        //override toString
        public override string ToString()
        {
            return "\n(" + PageID + ") " + PageTitle + "\n" + PageContent;
        }
    }

}

