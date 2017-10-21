using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Diagnostics;

namespace MagbaseServer
{
   public  class sqldb
    {
       public int uniqBlockT=0;
       public int uniqBlockTCL = 0;
       public  SQLiteConnection sql_con;
       logger _Log = new logger();

       public  void Connect_db() 
       {

           string db_name = Sform.pathDB;
           string pass_db = Sform.passwordDB;
           //string cmd_connect = "Data Source='" + db_name + "';Version=3;Pooling=True;max pool Size=100;Password='" + pass_db + "';"; //Password='" + pass_db + "';
           string cmd_connect = "Data Source='" + db_name + "';Version=3;Pooling=False;Password='" + pass_db + "';"; //Password='" + pass_db + "';
           sql_con=new SQLiteConnection(cmd_connect);
           //sql_con.DefaultTimeout = 10000;
           
       }
       
            
       public  DataTable ExecuteSQL(string SqlQuery)
        {

            //string connect_command = string.Format("Data Source={0}", db_name);     // строка подключения к логу           
            //Program.log.Debug(string.Format("Выполняем запрос: {0}", SqlQuery));
          
            Connect_db();
           
            sql_con.Open();
        
            //DataTable awq = sql_con.GetSchema();
            //var status_conn= sql_con.State;// проверяет открыто ли соединение
            //string server= sql_con.ServerVersion;
           
           //Exception exnull=new Exception();
           //_Log.logwrite(poolcount.ToString() + " статус соединения " + status_conn.ToString(), exnull);
            //var flag= sql_con.Flags;
            //string Typename= sql_con.DefaultTypeName;
            //var DBtype= sql_con.DefaultDbType;
            //string database= sql_con.Database;
            //string con= sql_con.ConnectionString;
          
            
           
            SQLiteCommand sqliteCommand = new SQLiteCommand(sql_con);
           
            DataTable dtbase = new DataTable();
            try
            {
               
                sqliteCommand.CommandText = SqlQuery;
                
                SQLiteDataReader sqliteReader = sqliteCommand.ExecuteReader();
                //int poolcount = sql_con.PoolCount;
                //Debug.WriteLine("Количество подключений {0}", poolcount);
                dtbase.Load(sqliteReader);
                sqliteReader.Close();
                Debug.WriteLine("Server:" + Environment.NewLine, SqlQuery);
                sql_con.Close();
            }
            catch (Exception ex)
            {
                sql_con.Close();
                //Program.log.Error("Ошибка выполнения запроса: " + ex.Message);
                _Log.logwrite("SERVER Ошибка выполнения запроса на получение данных: " + Environment.NewLine
                                + ex.Message + Environment.NewLine + "Запрос:" + SqlQuery, ex);
                MessageBox.Show("SERVER Ошибка выполнения запроса на получение данных: " + Environment.NewLine + ex.Message + Environment.NewLine + "Запрос:" + SqlQuery, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              
            }

            //Debug.WriteLine("Состояние подключения {0}", sql_con.State);
            return dtbase;
        }

       public  void SQL_Query(string SqlQuery)
       {// переписать запрос на изменения в базе!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

           //string connect_command = string.Format("Data Source={0}", db_name);     // строка подключения к логу           
           //Program.log.Debug(string.Format("Выполняем запрос: {0}", SqlQuery));

           Connect_db();
           sql_con.Open();
           
           SQLiteCommand sqliteCommand = new SQLiteCommand(sql_con);

           uniqBlockT = 0;
           try
           {
               
               sqliteCommand.CommandText = SqlQuery;
               
               sqliteCommand.ExecuteNonQuery();
               //int poolcount = sql_con.PoolCount;
               //Debug.WriteLine("Количество подключений {0}", poolcount);
               sql_con.Close();
               Debug.WriteLine("Server:" + Environment.NewLine, SqlQuery);
               //Debug.WriteLine("Состояние подключения {0}", sql_con.State);
           }
               
           catch (SQLiteException uniq)
           {
               if (uniq.ResultCode == SQLiteErrorCode.Constraint)
               {
                   uniqBlockT = 1;
                   sql_con.Close();
               }
               else
               {
                   sql_con.Close();
                   //Program.log.Error("Ошибка выполнения запроса: " + ex.Message);
                   _Log.logwrite("SERVER Ошибка выполнения запроса  на изменение данных: " + Environment.NewLine + uniq.Message + Environment.NewLine + "Запрос:" + SqlQuery, uniq);
                   MessageBox.Show("SERVER Ошибка выполнения запроса  на изменение данных: " + Environment.NewLine + uniq.Message + Environment.NewLine + "Запрос:" + SqlQuery, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               
           }
           catch (Exception ex)
           {

               //sql_con.Close();
               ////Program.log.Error("Ошибка выполнения запроса: " + ex.Message);
               //_Log.logwrite("Ошибка выполнения запроса  на изменение данных: " + Environment.NewLine + ex.Message + Environment.NewLine + "Запрос:" + SqlQuery, ex);
               //MessageBox.Show("Ошибка выполнения запроса  на изменение данных: " + Environment.NewLine + ex.Message + Environment.NewLine + "Запрос:" + SqlQuery, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);


           }

          
         
       }

       public DataTable ExecuteSQL_CL(string SqlQuery)
       {

           //string connect_command = string.Format("Data Source={0}", db_name);     // строка подключения к логу           
           //Program.log.Debug(string.Format("Выполняем запрос: {0}", SqlQuery));

           Connect_db();

           sql_con.Open();

           //DataTable awq = sql_con.GetSchema();
           //var status_conn= sql_con.State;// проверяет открыто ли соединение
           //string server= sql_con.ServerVersion;

           //Exception exnull=new Exception();
           //_Log.logwrite(poolcount.ToString() + " статус соединения " + status_conn.ToString(), exnull);
           //var flag= sql_con.Flags;
           //string Typename= sql_con.DefaultTypeName;
           //var DBtype= sql_con.DefaultDbType;
           //string database= sql_con.Database;
           //string con= sql_con.ConnectionString;



           SQLiteCommand sqliteCommand = new SQLiteCommand(sql_con);

           DataTable dtbase = new DataTable();
           try
           {

               sqliteCommand.CommandText = SqlQuery;
               
               SQLiteDataReader sqliteReader = sqliteCommand.ExecuteReader();
               //int poolcount = sql_con.PoolCount;
               //Debug.WriteLine("Количество подключений {0}", poolcount);
               dtbase.Load(sqliteReader);
               sqliteReader.Close();
               sql_con.Close();
               Debug.WriteLine("Client:"+Environment.NewLine, SqlQuery);
           }
           catch (Exception ex)
           {
               sql_con.Close();
               //Program.log.Error("Ошибка выполнения запроса: " + ex.Message);
               _Log.logwrite("CLIENT Ошибка выполнения запроса на получение данных: " + Environment.NewLine
                               + ex.Message + Environment.NewLine + "Запрос:" + SqlQuery, ex);
               MessageBox.Show("CLIENT Ошибка выполнения запроса на получение данных: " + Environment.NewLine + ex.Message + Environment.NewLine + "Запрос:" + SqlQuery, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }

           //Debug.WriteLine("Состояние подключения {0}", sql_con.State);
           return dtbase;
       }

       public void SQL_Query_CL(string SqlQuery)
       {// переписать запрос на изменения в базе!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

           //string connect_command = string.Format("Data Source={0}", db_name);     // строка подключения к логу           
           //Program.log.Debug(string.Format("Выполняем запрос: {0}", SqlQuery));
           Connect_db();
           sql_con.Open();

           SQLiteCommand sqliteCommand = new SQLiteCommand(sql_con);

           uniqBlockTCL = 0;
           try
           {
               
               sqliteCommand.CommandText = SqlQuery;
               sqliteCommand.ExecuteNonQuery();
               //int poolcount = sql_con.PoolCount;
               //Debug.WriteLine("Количество подключений {0}", poolcount);
               sql_con.Close();
               Debug.WriteLine("Client:"+Environment.NewLine, SqlQuery);
               //Debug.WriteLine("Состояние подключения {0}", sql_con.State);
           }

           catch (SQLiteException uniq)
           {
               if (uniq.ResultCode == SQLiteErrorCode.Constraint)
               {
                   uniqBlockTCL = 1;
                   sql_con.Close();
               }
               else
               {
                   sql_con.Close();
                   //Program.log.Error("Ошибка выполнения запроса: " + ex.Message);
                   _Log.logwrite("CLIENT Ошибка выполнения запроса  на изменение данных: " + Environment.NewLine + uniq.Message + Environment.NewLine + "Запрос:" + SqlQuery, uniq);
                   MessageBox.Show("CLIENT Ошибка выполнения запроса  на изменение данных: " + Environment.NewLine + uniq.Message + Environment.NewLine + "Запрос:" + SqlQuery, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

           }
           catch (Exception ex)
           {

               //sql_con.Close();
               ////Program.log.Error("Ошибка выполнения запроса: " + ex.Message);
               //_Log.logwrite("Ошибка выполнения запроса  на изменение данных: " + Environment.NewLine + ex.Message + Environment.NewLine + "Запрос:" + SqlQuery, ex);
               //MessageBox.Show("Ошибка выполнения запроса  на изменение данных: " + Environment.NewLine + ex.Message + Environment.NewLine + "Запрос:" + SqlQuery, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);


           }



       }

    }
}
