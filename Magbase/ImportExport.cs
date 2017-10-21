using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using System.Windows.Forms;
using SD = System.Data;
using System.IO;
namespace MagbaseServer
{
   class ImportExport
    {
       public string kod { get; set; }
       public string qty { get; set; }


       public void piece(string line)
       {
           string[] parts = line.Split(';');  //Разделитель в CVS файле.
           kod = parts[0];
           double num;
           if (double.TryParse(parts[1], out num))
           {
               qty = parts[1];
           }
           else
           {
               qty = "2";
           }
       }
 

       public static List<ImportExport> ImportToCsv()
       {
           string filename = string.Empty;
           OpenFileDialog oFile = new OpenFileDialog();
           oFile.Filter = "CSV (разделитель-'';'') (*.csv)|*.csv|Все файлы (*.*)|*.*";
           oFile.AddExtension = true;
           oFile.DefaultExt = "*.csv";
           oFile.CheckPathExists = true;
           oFile.InitialDirectory = Environment.CurrentDirectory;
           
           oFile.ShowDialog();
           List<ImportExport> res = new List<ImportExport>();
           if (oFile.FileName != "")
           {
               
               using (StreamReader sr = new StreamReader(oFile.FileName))
               {
                   string line;
                   while ((line = sr.ReadLine()) != null)
                   {
                       ImportExport p = new ImportExport();
                       if (line.IndexOf(';') >= 0)
                       {
                           p.piece(line);
                           res.Add(p);
                       }
                       
                   }
               }
               
           }
           return res;
       }

        //public  void ExportToExcel(DataGridView dgv,string filename)
        //{
        //    Excel.Application exApp = new Excel.Application();

        //    exApp.Visible = false;
        //    exApp.Workbooks.Add();

        //    Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            
                     

        //    object[,] d = new object[dgv.RowCount, dgv.ColumnCount];

        //    for (int i = 0; i < dgv.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dgv.Columns.Count; j++)
        //        {
        //            if (i == 0)
        //            {
        //                workSheet.Cells[1,j+1].Value2 = dgv.Columns[j].HeaderText;
        //            }
        //                d[i, j] = Convert.ToString( dgv.Rows[i].Cells[j].Value);
        //        }
        //    }

        //    workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[dgv.RowCount + 1, dgv.ColumnCount]].NumberFormat = "@";
        //    workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[dgv.RowCount+1, dgv.ColumnCount]].Value = d;
            
        //    SaveFileDialog sFile = new SaveFileDialog();
        //    sFile.Filter = "Книга Microsoft Office Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
        //    sFile.AddExtension = true;
        //    sFile.DefaultExt = "*.xls";
        //    sFile.CheckPathExists = true;
        //    sFile.InitialDirectory = Environment.CurrentDirectory;
        //    sFile.FileName = filename;
        //    sFile.ShowDialog();
        //    if (sFile.FileName != "")
        //    {
                
        //        string filepath = sFile.FileName;
        //        workSheet.SaveAs(filepath);
        //        exApp.Visible = true;
        //        //exApp.Quit();
        //    }
        //    else
        //    {
        //        //exApp.ThisWorkbook.Close(false);
        //        exApp.Quit();
        //    }
        //}
    }
}
