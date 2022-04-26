using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR3.Classes.Data
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
            if (ws.Cells[i, j].Value2 != null )
                return ws.Cells[i, j].Value2;
            else
                return "";
        }

        public void WriteCell(int i, int j, string data)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = data;
            wb.Save();
        }

        public void CloseWorkbook()
        {
            wb.Close(false);
        }

        public void SaveWorkbook()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
    }
}
