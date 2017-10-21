using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MagbaseServer
{
  public class ChekBase
  {
      sqldb _SQl = new sqldb();
        public  void chek_fields()
        {
            string[] baseColName = { "Access_bd", "Brand","BlockT", "Cash","ClassT", "Dbase", "Groupt", "Incoming", "Outgoing", "Pereocenka", "Sales", "Source", "Suppliers", "Users"};
            string[] Access_bd_Fields = {"id","LevelUsers"};//Access_bd
            string[] Access_bd_FieldsType = {"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT"};//Access_bd

                                        
            string[] Brand_Fields =  {"id","name"};//"Brand"
            string[] Brand_FieldsType = {"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT"}; //"Brand"

                                        
            string[] ClassT_Fields = {"id","name","margin_class"};//"ClassT"
            string[] ClassT_FieldsType ={"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT","REAL"}; //"ClassT"
                                        
                                        
            string[] Dbase_Fields = {"Kod","Name","Quantity","Zcena","Rcena","id_Group","id_Class","id_Brand","id_Suppliers","EAN","kod_osnova","obem_spisanie","plukod","life_goods"};//Dbase
            string[] Dbase_FieldsType = {"TEXT PRIMARY KEY","TEXT","REAL","REAL","REAL","INT","INT","INT","INT","TEXT","TEXT","REAL","INT","INT"};//Dbase
                                        
                                        
            string[] Groupt_Fields = {"id","name"};// Groupt
            string[] Groupt_FieldsType ={"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT"};// Groupt 

                                        
            string[] Incoming_Fields ={"id","kod_dbase","count","count_s","zcena","numberdock_mag","datedok","id_suppliers","status","date","numberdock_sup","rcena","users_bd"};// Incoming
            string[] Incoming_FieldsType ={"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT","REAL","REAL","REAL","TEXT","TEXT","INTEGER","NUMERIC","DATETIME","TEXT","REAL","INT"};// Incoming
                                        
                                        
            string[] Outgoing_Fields = {"id","kod_dbase","count","zcena","numberdock_mag","id_suppliers","date","id_incoming","numberdock_sup","date_dock_sup","users_bd"};// Outgoing
            string[] Outgoing_FieldsType = {"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT","REAL","REAL","TEXT","INTEGER","DATETIME","INTEGER","TEXT","TEXT","INT"}; // Outgoing
                                        
                                        
            string[] Pereocenka_Fields = {"id","kod_dbase","oldRcena","newRcena","date","users_bd"};// Pereocenka
            string[] Pereocenka_FieldsType = {"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT","REAL","REAL","DATETIME","INT"};// Pereocenka
                                        
                                        
            string[] Sales_Fields = {"Kod","Rcena","Count","Chek","Date","Zcena","numberdock_mag_incoming","id_incoming","id_type_pay","users_bd"};// Sales
            string[] Sales_FieldsType ={"TEXT","REAL","REAL","INT","DATETIME","REAL","TEXT","INT","TEXT","INT"}; // Sales


            string[] Source_Fields = { "chek", "pref_kod", "pref_dok_prihod", "pref_dok_rashod", "ean_mag", "urliconame", "kod_mag", "number_dok_rashod", "number_dok_prihod", "min_margin", "ogrn", "inn", "index_city", "street", "dom", "stroenie", "litera", "PrefVesEan", "PLUcount", "EAnCount", "PLUkodnum", "PrinterChek", "PrinterDok","City","SMTP","LoginMail","PassMail","ToMail","SubMail","BodyMail","AttachMail","TimerTime","ServerIP","ServerPort","ClientIP","ClientPort","Cash" };// Source
            string[] Source_FieldsType = { "INT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "INT", "INT", "INT", "REAL", "NUMERIC", "NUMERIC", "NUMERIC", "TEXT", "NUMERIC", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "INT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT","INT" };// Source
                                        
                                        
            string[] Suppliers_Fields = {"id","name","person","phone","adress"};// Suppliers
            string[] Suppliers_FieldsType = {"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT","TEXT","TEXT","TEXT"};// Suppliers
                                        
                                        
            string[] Users_Fields = {"id","login","pass","id_access"};// Users
            string[] Users_FieldsType = {"INTEGER PRIMARY KEY AUTOINCREMENT","TEXT","TEXT","INT"};// Users

            string[] Cash_Fields = { "type", "cashsum", "date", "comment", "users_bd" };// Cash
            string[] Cash_FieldsType = { "TEXT", "INT", "DATETIME", "TEXT","INT" };// Cash

            string[] BlockT_Fields = { "kod_dbase" };// Cash
            string[] BlockT_FieldsType = { "TEXT" };// Cash

            _SQl.SQL_Query("PRAGMA journal_mode=WAL");
            _SQl.SQL_Query("pragma synchronous=1");
            string value = String.Concat<string>(Access_bd_Fields);

            DataTable BaseTable = _SQl.ExecuteSQL("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name");
            int countTable=BaseTable.Rows.Count;
            string[] basearray = new string[countTable];

            for (int i = 0; i < BaseTable.Rows.Count-1; i++)
            {
                basearray[i] = BaseTable.Rows[i][0].ToString();
                
            }

            for (int itbl = 0; itbl < baseColName.Length; itbl++)
            {
                string fieldsname=baseColName[itbl].ToString();
                int searchFields = Array.BinarySearch(basearray, fieldsname);
                if (searchFields >= 0)
                {
                    DataTable BaseTableColumnsFields = _SQl.ExecuteSQL("pragma table_info(" + baseColName[itbl].ToString() + ")");
                    
                    string[] baseColumns = new string[BaseTableColumnsFields.Rows.Count];
                    for (int icol = 0; icol < BaseTableColumnsFields.Rows.Count; icol++)
                    {
                        baseColumns[icol] = BaseTableColumnsFields.Rows[icol][1].ToString();
                    }
                    string ArrayName=baseColName[itbl].ToString() + "_Fields";
                    int i = 0;
                    switch (ArrayName)
                    {

                        case "Access_bd_Fields":
                            foreach (string ColumnsName in Access_bd_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Access_bd_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Brand_Fields":
                            foreach (string ColumnsName in Brand_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Brand_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;

                        case "BlockT_Fields":
                            foreach (string ColumnsName in BlockT_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + BlockT_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Cash_Fields":
                            foreach (string ColumnsName in Cash_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Cash_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "ClassT_Fields":
                            foreach (string ColumnsName in ClassT_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + ClassT_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Dbase_Fields":
                            foreach (string ColumnsName in Dbase_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Dbase_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Groupt_Fields":
                            foreach (string ColumnsName in Groupt_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Groupt_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Incoming_Fields":
                            foreach (string ColumnsName in Incoming_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Incoming_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Outgoing_Fields":
                            foreach (string ColumnsName in Outgoing_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Outgoing_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Pereocenka_Fields":
                            foreach (string ColumnsName in Pereocenka_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("alter TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Pereocenka_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Sales_Fields":
                            foreach (string ColumnsName in Sales_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Sales_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Source_Fields":
                            
                            foreach (string ColumnsName in Source_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Source_FieldsType[i].ToString() + " NOT NULL default(0)");
                                }
                                i++;
                            }
                            i = 0;
                            break;
                        case "Suppliers_Fields":
                            foreach (string ColumnsName in Suppliers_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Suppliers_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        case "Users_Fields":
                            foreach (string ColumnsName in Users_Fields)
                            {
                                int searchColumns = Array.IndexOf(baseColumns, ColumnsName);
                                if (searchColumns < 0)
                                {
                                    _SQl.SQL_Query("ALTER TABLE " + ArrayName.Remove(ArrayName.IndexOf("_Fields")) + " ADD COLUMN " + ColumnsName + " " + Users_FieldsType[i].ToString() + "");
                                }
                                i++;

                            }
                            i = 0;
                            break;
                        default:
                            Console.WriteLine("Такой язык я не знаю");
                            break;
                    }

                }
                else
                {

                   string createtable= "";
                   string ArrayName = fieldsname + "_Fields";
                   int i = 0;
                   string columnsType="";
                   switch (ArrayName)
                   {

                       case "Access_bd_Fields":

                           foreach (string ColumnsName in Access_bd_Fields)
                           {
                               if (i != Access_bd_Fields.Length-1)
                               {
                                   columnsType = columnsType+ColumnsName + " " + Access_bd_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Access_bd_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Brand_Fields":
                           foreach (string ColumnsName in Brand_Fields)
                           {
                               if (i != Brand_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Brand_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Brand_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;
                       case "BlockT_Fields":
                           foreach (string ColumnsName in BlockT_Fields)
                           {
                               if (i != BlockT_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + BlockT_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + BlockT_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType = "";
                           createtable = "";
                           i = 0;
                           break;
                       case "Cash_Fields":
                           foreach (string ColumnsName in Cash_Fields)
                           {
                               if (i != Cash_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Cash_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Cash_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType = "";
                           createtable = "";
                           i = 0;
                           break;

                       case "ClassT_Fields":
                           foreach (string ColumnsName in ClassT_Fields)
                           {
                               if (i != ClassT_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + ClassT_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + ClassT_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;
                              
                       case "Dbase_Fields":
                           foreach (string ColumnsName in Dbase_Fields)
                           {
                               if (i != Dbase_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Dbase_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Dbase_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Groupt_Fields":
                           foreach (string ColumnsName in Groupt_Fields)
                           {
                               if (i != Groupt_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Groupt_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Groupt_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Incoming_Fields":
                           foreach (string ColumnsName in Incoming_Fields)
                           {
                               if (i != Incoming_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Incoming_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Incoming_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Outgoing_Fields":
                           foreach (string ColumnsName in Outgoing_Fields)
                           {
                               if (i != Outgoing_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Outgoing_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Outgoing_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Pereocenka_Fields":
                           foreach (string ColumnsName in Pereocenka_Fields)
                           {
                               if (i != Pereocenka_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Pereocenka_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Pereocenka_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Sales_Fields":
                           foreach (string ColumnsName in Sales_Fields)
                           {
                               if (i != Sales_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Sales_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Sales_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Source_Fields":

                           foreach (string ColumnsName in Source_Fields)
                           {
                               if (i != Source_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Source_FieldsType[i].ToString() + " NOT NULL default(0),";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Source_FieldsType[i].ToString()+" NOT NULL default(0)";
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Suppliers_Fields":
                           foreach (string ColumnsName in Suppliers_Fields)
                           {
                               if (i != Suppliers_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Suppliers_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Suppliers_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       case "Users_Fields":
                           foreach (string ColumnsName in Users_Fields)
                           {
                               if (i != Users_Fields.Length - 1)
                               {
                                   columnsType = columnsType + ColumnsName + " " + Users_FieldsType[i].ToString() + ",";
                               }
                               else
                               {
                                   columnsType = columnsType + ColumnsName + " " + Users_FieldsType[i].ToString();
                               }
                               i++;
                           }
                           createtable = "CREATE TABLE " + fieldsname + " (" + columnsType + ")";
                           _SQl.SQL_Query(createtable);
                           columnsType="";
                           createtable = "";
                           i = 0;
                           break;

                       default:
                           //Console.WriteLine("Такой язык я не знаю");
                           break;
                   }
                
                }
               
            }

        }
    }
}
