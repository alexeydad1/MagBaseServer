using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading;

namespace MagbaseServer
{
   public class Source
    {
       sqldb _SQl = new sqldb();
       public int chek()
       {
           while (true)
           {
               _SQl.SQL_Query("INSERT INTO BlockT (kod_dbase) Values('Check')");
               if (_SQl.uniqBlockT == 0 && _SQl.sql_con.State.ToString() == "Closed")
               {
                   break;
               }
               Thread.Sleep(500);
           }

           string SqlQueryChek = "select chek from source";
           DataTable ChekTable = _SQl.ExecuteSQL(SqlQueryChek);
           int Chek = Convert.ToInt32(ChekTable.Rows[0][0].ToString());
           Chek += 1;
           string SqlUpdateChek = "Update  Source Set  chek =" + Chek + "";
           _SQl.SQL_Query(SqlUpdateChek);
           Chek -= 1;
           _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='Check'");
           Thread.Sleep(200);
           return Chek;
       }
       public  String pref_kod ()
       {
            string SqlQueryPrefKod = "select pref_kod from source";
            DataTable PrefKodTable = _SQl.ExecuteSQL(SqlQueryPrefKod);
            string prefix_kod = PrefKodTable.Rows[0][0].ToString();
           return prefix_kod;
       }

       public int kod_mag()
       {
           while (true)
           {
               _SQl.SQL_Query("INSERT INTO BlockT (kod_dbase) Values('KOD')");
               if (_SQl.uniqBlockT == 0 && _SQl.sql_con.State.ToString() == "Closed")
               {
                   break;
               }
               Thread.Sleep(500);
           }

           string SqlQueryKod_mag = "select kod_mag from source";
           DataTable NumdockP = _SQl.ExecuteSQL(SqlQueryKod_mag);
           int kod_mag = Convert.ToInt32(NumdockP.Rows[0][0].ToString());
           kod_mag += 1;
           
           string txtSQLUpdadeKodMag = "update  source set  kod_mag ='" + kod_mag + "'";
           _SQl.SQL_Query(txtSQLUpdadeKodMag);
           
           kod_mag -= 1;
           
           _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='KOD'");
           Thread.Sleep(200);
           
           return kod_mag;
       }

       public String pref_dok_prihod()
       {
           string SqlQueryPrefPrih = "select pref_dok_prihod from source";
           DataTable PrefPrih = _SQl.ExecuteSQL(SqlQueryPrefPrih);
           string pref_dok_prihod = PrefPrih.Rows[0][0].ToString();
           return pref_dok_prihod;
       }
       public String pref_dok_rashod()
       {
           string SqlQueryPrefRash = "select pref_dok_rashod from source";
           DataTable PrefRash = _SQl.ExecuteSQL(SqlQueryPrefRash);
           string pref_dok_rashod = PrefRash.Rows[0][0].ToString();
           return pref_dok_rashod;
       }
       public int number_dok_prihod()
       {
           while (true)
           {
               _SQl.SQL_Query("INSERT INTO BlockT (kod_dbase) Values('Prihod')");
               if (_SQl.uniqBlockT == 0 && _SQl.sql_con.State.ToString() == "Closed")
               {
                   break;
               }
               Thread.Sleep(500);
           }
           string SqlQueryNumDockP = "select number_dok_prihod from source";
           DataTable NumdockP = _SQl.ExecuteSQL(SqlQueryNumDockP);
           int number_dok_prihod = Convert.ToInt32(NumdockP.Rows[0][0].ToString());
           number_dok_prihod += 1;
           
           string Sqlnumber_dok_prihod = "update source set number_dok_prihod=" + number_dok_prihod + "";
           _SQl.SQL_Query(Sqlnumber_dok_prihod);
           
           number_dok_prihod -= 1;
           
           _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='Prihod'");
           Thread.Sleep(200);
           return number_dok_prihod;
       }
       public int number_dok_rashod()
       {
           while (true)
           {
               _SQl.SQL_Query("INSERT INTO BlockT (kod_dbase) Values('Rashod')");
               if (_SQl.uniqBlockT == 0 && _SQl.sql_con.State.ToString() == "Closed")
               {
                   break;
               }
               Thread.Sleep(500);
           }
           string SqlQueryNumDockR = "select number_dok_rashod from source";
           DataTable NumdockR = _SQl.ExecuteSQL(SqlQueryNumDockR);
           int number_dok_rashod = Convert.ToInt32(NumdockR.Rows[0][0].ToString());
           number_dok_rashod += 1;

           string Sqlnumber_dok_rashod = "update source set number_dok_rashod=" + number_dok_rashod + "";
           _SQl.SQL_Query(Sqlnumber_dok_rashod);

           number_dok_rashod -= 1;
           _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='Rashod'");
           Thread.Sleep(200);
           
           return number_dok_rashod;
       }
       public string ean_mag()
       {
           string SqlQueryEan_mag = "select ean_mag from source";
           DataTable Ean_mag = _SQl.ExecuteSQL(SqlQueryEan_mag);
           string ean_mag = Ean_mag.Rows[0][0].ToString();
           return ean_mag;
       }


     
    }
}
