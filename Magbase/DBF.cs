using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.IO;

namespace MagbaseServer
{
    class DBF
    {
        
        public static void export_dbf(string kod,string plu,string name,string pref_ean_ves,string rcena,string life_goods,string PathFile,string filename)
        {
            
            Source _SRC = new Source();
            using (var dBaseConnection = new OleDbConnection(
                    @"Provider=Microsoft.Jet.OLEDB.4.0;" +// " 
                    @" Data Source=" + PathFile + "; " +
                    @"Extended Properties=dBase IV"))
            {
                dBaseConnection.Open();
                
                
                Encoding cp1251 = Encoding.GetEncoding(1251);
                Encoding cp866 = Encoding.GetEncoding(866);
                string pref_kod = _SRC.pref_kod();
                string createTableSyntax =
                       "insert into "+ filename+"(PRD_ID,PRD_CODE,PRD_NAME,PRD_PREF,PRD_PLU,PRD_PRCE,PRD_LIFE)"+
                   "values('" + kod + "','" + kod.Substring(pref_kod.Length) + "','" + cp866.GetString(cp1251.GetBytes(name)) + "','" + pref_ean_ves + "','" + plu + "','" + rcena + "','" + life_goods + "') ";// дописать код товара   
                var cmd = new OleDbCommand(createTableSyntax, dBaseConnection);
                cmd.ExecuteNonQuery();
                
                dBaseConnection.Close();

            }
        }
        public static void create_db(string PathFile,string filename)
        {
            
            
                using (var dBaseConnection = new OleDbConnection(
                    "Provider=Microsoft.Jet.OLEDB.4.0;" +// " 
                    " Data Source="+ PathFile +"; " +
                    "Extended Properties=dBase IV"))
                {
                    dBaseConnection.Open();
                    string createTableSyntax =
                    "Create Table " + filename + " " +
                    "(PRD_ID char(12), PRD_NAME char(254), FLG_CNTR char(1), PRD_CODE char(32), PRD_PLU char(8), PRD_PREF char(2)," +
                    "PRD_BAR char(13), GRP_ID char(12), GRP_NAME char(254), MSR_ID char(3), MSR_NAME char(25), PRD_PRCE char(15)," +
                    "PRD_CERT char(4), PRD_CMP1 char(254), PRD_CMP2 char(254), PRD_TARE char(15), PRD_LIFE char(16), PRD_DATE char(16), PRD_INFO char(254))";
                    var cmd = new OleDbCommand(createTableSyntax, dBaseConnection);
                    cmd.ExecuteNonQuery();
                    dBaseConnection.Close();
                }


        }

         
    }
}
