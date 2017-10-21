using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MagbaseServer
{
    
       
 
    static class Data
    {
            public static DataTable Tovartbl { get; set; }//таблица для товар с одинаковыми штрихкодами
            public static string numDocPrihodRashod { get; set; }
                   
            public static int idUser { get; set; }
            public static int RowidUser { get; set; }
           
    
    }
    
}
