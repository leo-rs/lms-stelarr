using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace STELARR2.Models
{
    public class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }

        public void CloseWorkbook()
        {
            wb.Close(false);
        }

        //private string _lessonContent;
        //int _currCol = 0;
        //int _currRow = 0;
        //Excel xl;

        //public ShellViewModel()
        //{
        //    xl = new Excel(@"C:\Users\janle\source\repos\lms-stelarr\STELARR2\Files\lessons.xlsx", 1);
        //}

        //public string LessonContent
        //{
        //    get { return _lessonContent; }
        //}

        //public void LoadLesson()
        //{
        //    _lessonContent = xl.ReadCell(_currRow, _currCol);
        //    NotifyOfPropertyChange(() => LessonContent);
        //    _currRow++;
        //}

        //public void ExitLesson()
        //{
        //    xl.CloseWorkbook();
        //    MessageBox.Show("Exiting lesson.");
        //}
    }
}
