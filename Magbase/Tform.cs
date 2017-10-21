using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace MagbaseServer
{
    public partial class Tform : Form
    {
        sqldb _SQl = new sqldb();
        Source _SRC = new Source();
        public DataTable dtPrintChek = new DataTable();
        public DataTable LoadDatashkTable = new DataTable();
        public DataTable LoadDatakodTable = new DataTable();
        public DataTable FifoTable = new DataTable();
        public string pref_kod;
        public int FlagSaleMinus = 0;
  
        
   
        
        private void LoadDatashk()
        {
            string SQLqueryLoadSHK = "select Kod,Name,Rcena,Zcena,kod_osnova,obem_spisanie,Quantity from Dbase where EAN like '%" + txtShtovar.Text + "%'";
            LoadDatashkTable = _SQl.ExecuteSQL(SQLqueryLoadSHK);

          if (LoadDatashkTable.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtShtovar.Text = "";
                txtShtovar.Focus();
                return;
            }
          if (LoadDatashkTable.Rows.Count > 1)
            {
                // проверяем не запущена ли форма 
                for (int x = 0; x < this.OwnedForms.Length; x++)
                {
                    if (this.OwnedForms[x].Name == "Viborform")
                    {
                        this.OwnedForms[x].Focus();
                        return;
                    }
                }

                // Запускаем форму если она не запущена

                Data.Tovartbl = LoadDatashkTable;
                // сделать форму с выводом позиций на одном штрихкоде
                Sform.ownerFormName = "Tform";
                Form Viborform = new Viborform();
                Viborform.StartPosition = FormStartPosition.CenterScreen;
                //указываем владельца для формы
               // Viborform.MdiParent = this.MdiParent; // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Viborform.Owner = this;
                Viborform.Show();
                txtShtovar.Text = "";
                
                return;
            }

              string kod = LoadDatashkTable.Rows[0][0].ToString();
              string name = LoadDatashkTable.Rows[0][1].ToString();
              double rcena =Convert.ToDouble(LoadDatashkTable.Rows[0][2].ToString());
              double zcena = Convert.ToDouble(LoadDatashkTable.Rows[0][3].ToString());
              double count = 1;
              double rsumm = count * rcena;
              string kodosnova = LoadDatashkTable.Rows[0][4].ToString();
              double obem_spisanie = Convert.ToDouble(LoadDatashkTable.Rows[0][5].ToString());
              double qty = Convert.ToDouble(LoadDatashkTable.Rows[0][6].ToString());

              dGV.Rows.Add(kod, name, zcena, rcena, count, rsumm, kodosnova, obem_spisanie);
            int resultfind = 0;
            if (dGV.Rows.Count > 0)
            {
                for (int i = 0; i < dGV.Rows.Count - 1; i++)
                {
                    if (dGV.Rows[i].Cells[0].Value.ToString() == kod)
                    {
                        dGV.Rows[i].Cells[4].Value = Convert.ToDouble(dGV.Rows[i].Cells[4].Value.ToString()) + Convert.ToDouble(count);
                        dGV.Rows.RemoveAt(dGV.Rows.Count - 1);
                        dGV.ClearSelection();
                        dGV.Rows[i].Selected = true;
                        dGV.CurrentCell = dGV.Rows[i].Cells[4];
                        resultfind =1;
                        if (qty <= 0)
                        {
                            dGV.Rows[i].DefaultCellStyle.ForeColor = Color.Coral;
                            dGV.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Coral;
                        }
                    }
                    
                }
                    if (resultfind == 0)
                    {
                        dGV.ClearSelection();
                        dGV.Rows[Convert.ToInt32(dGV.Rows.Count - 1)].Selected = true;
                        dGV.CurrentCell = dGV.Rows[dGV.RowCount - 1].Cells[4];
                        if (qty <= 0)
                        {
                            dGV.Rows[dGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Coral;
                            dGV.Rows[dGV.Rows.Count - 1].DefaultCellStyle.SelectionForeColor = Color.Coral;
                        }
                    }

            }
            SummChek();
            //lblSumChekTform.Text = "0";

            //for (int i = 0; i < dGV.Rows.Count; i++)
            //{
            //    if (Convert.ToDouble(dGV.Rows[i].Cells["count"].Value) == 0)
            //    {
            //        dGV.Rows[i].Cells["Count"].Value = 1;
            //    }
            //    dGV.Rows[i].Cells["Rsumm"].Value = Math.Round(Convert.ToDouble(dGV.Rows[i].Cells["Rcena"].Value)*Convert.ToDouble(dGV.Rows[i].Cells["Count"].Value),0) ;
            //    lblSumChekTform.Text = Convert.ToString(Convert.ToDouble(dGV.Rows[i].Cells["Rsumm"].Value) + Convert.ToDouble(lblSumChekTform.Text));
            //}

            
            
                            
            txtShtovar.Text = "";
            serTsave();
        }

        public void LoadDatakod(string kodtovara)
        {
            string SQLqueryLoadKod = "select Kod,Name,Rcena,Zcena,kod_osnova,obem_spisanie,Quantity from Dbase where Kod='" + kodtovara + "'";
            LoadDatakodTable = _SQl.ExecuteSQL(SQLqueryLoadKod);

            if (LoadDatakodTable.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string kod = LoadDatakodTable.Rows[0][0].ToString();
            string name = LoadDatakodTable.Rows[0][1].ToString();
            double rcena = Convert.ToDouble(LoadDatakodTable.Rows[0][2].ToString());
            double zcena = Convert.ToDouble(LoadDatakodTable.Rows[0][3].ToString());
            double count = 1;
            double rsumm = count * rcena;
            string kodosnova = LoadDatakodTable.Rows[0][4].ToString();
            double obem_spisanie = Convert.ToDouble(LoadDatakodTable.Rows[0][5].ToString());
            double qty = Convert.ToDouble(LoadDatakodTable.Rows[0][6].ToString());

            dGV.Rows.Add(kod, name, zcena, rcena, count, rsumm, kodosnova, obem_spisanie);
            int resultfindkod = 0;
            if (dGV.Rows.Count > 0)
            {
                for (int i = 0; i < dGV.Rows.Count - 1; i++)
                {
                    if (dGV.Rows[i].Cells[0].Value.ToString() == kod)
                    {
                        dGV.Rows[i].Cells[4].Value = Convert.ToDouble(dGV.Rows[i].Cells[4].Value.ToString()) + Convert.ToDouble(count);
                        dGV.Rows.RemoveAt(dGV.Rows.Count-1);
                        dGV.ClearSelection();
                        dGV.Rows[i].Selected = true;

                        dGV.CurrentCell = dGV.Rows[i].Cells[4];
                        resultfindkod = 1;
                        if (qty <= 0)
                        {
                            dGV.Rows[i].DefaultCellStyle.ForeColor = Color.Coral;
                            dGV.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Coral;
                            
                        }
                    }

                }
                if (resultfindkod == 0)
                {
                    dGV.ClearSelection();
                    dGV.Rows[dGV.Rows.Count - 1].Selected = true;
                    dGV.CurrentCell = dGV.Rows[dGV.RowCount - 1].Cells[4];
                    if (qty <= 0)
                    {
                        dGV.Rows[dGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Coral;
                        dGV.Rows[dGV.Rows.Count - 1].DefaultCellStyle.SelectionForeColor = Color.Coral;
                        
                    }
                }
            }

            SummChek();

            //lblSumChekTform.Text = "0";

            //for (int i = 0; i < dGV.Rows.Count; i++)
            //{
            //    if (Convert.ToDouble(dGV.Rows[i].Cells["Count"].Value) == 0)
            //    {
            //        dGV.Rows[i].Cells["Count"].Value = 1;
            //    }
            //    dGV.Rows[i].Cells["Rsumm"].Value = Math.Round(Convert.ToDouble(dGV.Rows[i].Cells["Rcena"].Value) * Convert.ToDouble(dGV.Rows[i].Cells["Count"].Value),0);
            //    lblSumChekTform.Text = Convert.ToString(Convert.ToDouble(dGV.Rows[i].Cells["Rsumm"].Value) + Convert.ToDouble(lblSumChekTform.Text));
            //}
 
            txtKod.Text = "";
            serTsave();
            txtShtovar.Focus();

            
        }
        //public void Fifo(string Kod, double Count, double Zcena, double Rcena, int chek, string datechek, string type_pay, string kod_osnova, double obem_spisanie, string Name)
        //{
        //    //Проверка есть ли привязка на списание к основному товару
        //    if (obem_spisanie > 0)
        //    {
        //        FifoTable = _SQl.ExecuteSQL("SELECT numberdock_mag," +
        //                                            "count," +
        //                                            "count_s," +
        //                                            "zcena,id" +
        //                                    " FROM incoming WHERE " +
        //                                            "kod_dbase = '" + kod_osnova + "' " +
        //                                            "AND status = '0' order by date");
        //        Count = Count * obem_spisanie;
        //    }
        //    else
        //    {
        //        FifoTable = _SQl.ExecuteSQL("SELECT numberdock_mag," +
        //                                            "count," +
        //                                            "count_s," +
        //                                            "zcena,id" +
        //                                    " FROM incoming WHERE " +
        //                                            "kod_dbase = '" + Kod + "' " +
        //                                            "AND status = '0' order by date");
        //    }



        //    for (int idrow = 0; idrow < FifoTable.Rows.Count; idrow++)
        //    {

        //        string numberdock_mag_incoming = FifoTable.Rows[idrow][0].ToString();
        //        double count_incoming = Convert.ToDouble(FifoTable.Rows[idrow][1].ToString());
        //        double count_s_incoming = Convert.ToDouble(FifoTable.Rows[idrow][2].ToString());
        //        double zcena_incoming = 0;
        //        if (obem_spisanie > 0)
        //        {
        //            zcena_incoming = Convert.ToDouble(FifoTable.Rows[idrow][3].ToString()) * obem_spisanie;
        //        }
        //        else
        //        {
        //            zcena_incoming = Convert.ToDouble(FifoTable.Rows[idrow][3].ToString());
        //        }
        //        double ostatok_incoming = Math.Round((count_incoming - count_s_incoming), 3);
        //        int id_incoming = Convert.ToInt32(FifoTable.Rows[idrow][4].ToString());

        //        // Количество товара больше или равно свободному остатку в таблице прихода
        //        if (Count >= ostatok_incoming)
        //        {

        //            string txtSQLQueryUpdateIncoming = "update incoming " +
        //                        "set count_s =" + Convert.ToString((ostatok_incoming + count_s_incoming)).Replace(',', '.') + "," +
        //                        "status='1' where id =" + id_incoming + "";
        //            _SQl.SQL_Query(txtSQLQueryUpdateIncoming);

        //            string txtSQLQueryUpdateSales = "";
        //            if (obem_spisanie > 0)
        //            {
        //                txtSQLQueryUpdateSales = "insert into  Sales (Kod," +
        //                                                              "Rcena," +
        //                                                              "Count," +
        //                                                              "Zcena," +
        //                                                              "Date,Chek," +
        //                                                              "numberdock_mag_incoming," +
        //                                                              "id_incoming," +
        //                                                              "id_type_pay,users_bd) " +
        //                                                       "values ('" + Kod + "',"
        //                                                       + Convert.ToString(Rcena).Replace(',', '.') + ","
        //                                                       + Convert.ToString(ostatok_incoming / obem_spisanie).Replace(',', '.') + ","
        //                                                       + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'"
        //                                                       + datechek + "',"
        //                                                       + chek + ",'"
        //                                                       + numberdock_mag_incoming + "',"
        //                                                       + id_incoming + ",'"
        //                                                       + type_pay + "',"
        //                                                       + Sform.id_users + ")";
        //            }
        //            else
        //            {
        //                txtSQLQueryUpdateSales = "insert into  Sales (Kod," +
        //                                                              "Rcena," +
        //                                                              "Count," +
        //                                                              "Zcena," +
        //                                                              "Date," +
        //                                                              "Chek," +
        //                                                              "numberdock_mag_incoming," +
        //                                                              "id_incoming," +
        //                                                              "id_type_pay,users_bd) " +
        //                                                        "values ('" + Kod + "',"
        //                                                        + Convert.ToString(Rcena).Replace(',', '.') + ","
        //                                                        + Convert.ToString(ostatok_incoming).Replace(',', '.') + ","
        //                                                        + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'"
        //                                                        + datechek + "',"
        //                                                        + chek + ",'"
        //                                                        + numberdock_mag_incoming + "',"
        //                                                        + id_incoming + ",'"
        //                                                        + type_pay + "',"
        //                                                        + Sform.id_users + ")";
        //            }
        //            _SQl.SQL_Query(txtSQLQueryUpdateSales);

        //            DataTable QuantityKodTable = new DataTable();
                    
                   
        //            string txtSQLQueryUpdateDbase = "";
        //            if (obem_spisanie > 0)
        //            {
        //                txtSQLQueryUpdateDbase = "update dbase set quantity=((select quantity from dbase where kod='" + kod_osnova + "')-"+ostatok_incoming+") where kod='" + kod_osnova + "'";
                        
        //            }
        //            else
        //            {
                        
        //                txtSQLQueryUpdateDbase = "update dbase set quantity=((select quantity from dbase where kod='" + kod_osnova + "')-"+ostatok_incoming+") where kod='"+ Kod + "'";
        //            }

        //            _SQl.SQL_Query(txtSQLQueryUpdateDbase);

        //            Count = Math.Round((Count - ostatok_incoming), 3);
        //            if (Count <= 0)
        //            {
        //                return;
        //            }

        //        }
        //        else
        //        {
        //            // Количество товара меньше свободного остатка в таблице прихода
        //            string txtSQLQueryUpdateIncoming = "update  incoming set  count_s =" + Convert.ToString((Count + count_s_incoming)).Replace(',', '.') + " where id =" + id_incoming + "";
        //            _SQl.SQL_Query(txtSQLQueryUpdateIncoming);

        //            string txtSQLQueryUpdateSales = "";
        //            if (obem_spisanie > 0)
        //            {
        //                txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(Count / obem_spisanie).Replace(',', '.') + "," + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'" + numberdock_mag_incoming + "'," + id_incoming + ",'" + type_pay + "'," + Sform.id_users + ")";
        //            }
        //            else
        //            {
        //                txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(Count).Replace(',', '.') + "," + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'" + numberdock_mag_incoming + "'," + id_incoming + ",'" + type_pay + "'," + Sform.id_users + ")";
        //            }
        //            _SQl.SQL_Query(txtSQLQueryUpdateSales);


        //            DataTable QuantityKodTable = new DataTable();
                    
        //            string txtSQLQueryUpdateDbase = "";
        //            if (obem_spisanie > 0)
        //            {


        //                txtSQLQueryUpdateDbase = "update dbase set quantity=((select quantity from dbase where kod='" + kod_osnova + "')-" + Count + ") where kod='" + kod_osnova + "'";
        //            }
        //            else
        //            {

        //                txtSQLQueryUpdateDbase = "update dbase set quantity=((select quantity from dbase where kod='" + kod_osnova + "')-" + Count + ") where kod='" + Kod + "'";
        //            }

        //            _SQl.SQL_Query(txtSQLQueryUpdateDbase);

        //            Count = Math.Round((Count - ostatok_incoming), 3);
        //            if (Count <= 0)
        //            {
        //                return;
        //            }
        //        }
        //    }

        //    // Если нет свободного остатка (продажа в минус!!!!!!!!!!!!!!!), а количество товара больше 0!!!!!
        //    if (Count >= 0)
        //    {

        //        string txtSQLQueryUpdateSales = "";
        //        if (obem_spisanie > 0)
        //        {
        //            txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(Count / obem_spisanie).Replace(',', '.') + "," + Convert.ToString(Zcena).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'0',0,'" + type_pay + "'," + Sform.id_users + ")";
        //        }
        //        else
        //        {
        //            txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(Count).Replace(',', '.') + "," + Convert.ToString(Zcena).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'0',0,'" + type_pay + "'," + Sform.id_users + ")";
        //        }

        //        _SQl.SQL_Query(txtSQLQueryUpdateSales);

        //        DataTable QuantityKodTable = new DataTable();
        //        string txtSQLQuerySelectDbase = "";
        //        double Quantity = 0;
        //        string txtSQLQueryUpdateDbase = "";
        //        if (obem_spisanie > 0)
        //        {
        //            txtSQLQuerySelectDbase = "select quantity from dbase where kod='" + kod_osnova + "'";
        //            QuantityKodTable = _SQl.ExecuteSQL(txtSQLQuerySelectDbase);
        //            Quantity = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString()) - Count), 3);
        //            txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + kod_osnova + "'";
        //        }
        //        else
        //        {
        //            txtSQLQuerySelectDbase = "select quantity from dbase where kod='" + Kod + "'";
        //            QuantityKodTable = _SQl.ExecuteSQL(txtSQLQuerySelectDbase);
        //            Quantity = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString()) - Count), 3);
        //            txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + Kod + "'";
        //        }

        //        _SQl.SQL_Query(txtSQLQueryUpdateDbase);

        //        Count = 0;
        //        FlagSaleMinus = 1;


        //    }
        //}
        //public void Fifo(string Kod, double Count, double Zcena, double Rcena, int chek, string datechek, string type_pay, string kod_osnova, double obem_spisanie, string Name)
        //{
        //    DataTable dtblock = new DataTable();
        //    while (true)
        //    {
        //       dtblock=_SQl.ExecuteSQL("SELECT kod_dbase from BlockT where kod_dbase='"+Kod+"'");
        //       if (dtblock.Rows.Count == 0)
        //       {
        //           _SQl.SQL_Query("INSERT INTO BlockT (kod_dbase) Values('" + Kod + "')");
        //           break;
        //       }
        //       else
        //       {
                   
        //           Thread.Sleep(500);
        //       }
        //    }
        //    //Проверка есть ли привязка на списание к основному товару
        //    if (obem_spisanie > 0)
        //    {
        //        FifoTable = _SQl.ExecuteSQL("SELECT numberdock_mag," +
        //                                            "count," +
        //                                            "count_s," +
        //                                            "zcena,id" +
        //                                    " FROM incoming WHERE " +
        //                                            "kod_dbase = '" + kod_osnova + "' " +
        //                                            "AND status = '0' order by date");
        //        Count = Count * obem_spisanie;
        //    }
        //    else
        //    {
        //        FifoTable = _SQl.ExecuteSQL("SELECT numberdock_mag," +
        //                                            "count," +
        //                                            "count_s," +
        //                                            "zcena,id" +
        //                                    " FROM incoming WHERE " +
        //                                            "kod_dbase = '" + Kod + "' " +
        //                                            "AND status = '0' order by date");
        //    }



        //    for (int idrow = 0; idrow < FifoTable.Rows.Count; idrow++)
        //    {

        //        string numberdock_mag_incoming = FifoTable.Rows[idrow][0].ToString();
        //        double count_incoming = Convert.ToDouble(FifoTable.Rows[idrow][1].ToString());
        //        double count_s_incoming = Convert.ToDouble(FifoTable.Rows[idrow][2].ToString());
        //        double zcena_incoming = 0;
        //        if (obem_spisanie > 0)
        //        {
        //            zcena_incoming = Convert.ToDouble(FifoTable.Rows[idrow][3].ToString()) * obem_spisanie;
        //        }
        //        else
        //        {
        //            zcena_incoming = Convert.ToDouble(FifoTable.Rows[idrow][3].ToString());
        //        }
        //        double ostatok_incoming = Math.Round((count_incoming - count_s_incoming), 3);
        //        int id_incoming = Convert.ToInt32(FifoTable.Rows[idrow][4].ToString());

        //        // Количество товара больше или равно свободному остатку в таблице прихода
        //        if (Count >= ostatok_incoming)
        //        {

        //            string txtSQLQueryUpdateIncoming = "update incoming " +
        //                        "set count_s =" + Convert.ToString((ostatok_incoming + count_s_incoming)).Replace(',', '.') + "," +
        //                        "status='1' where id =" + id_incoming + "";
        //            _SQl.SQL_Query(txtSQLQueryUpdateIncoming);

        //            string txtSQLQueryUpdateSales = "";
        //            if (obem_spisanie > 0)
        //            {
        //                txtSQLQueryUpdateSales = "insert into  Sales (Kod," +
        //                                                              "Rcena," +
        //                                                              "Count," +
        //                                                              "Zcena," +
        //                                                              "Date,Chek," +
        //                                                              "numberdock_mag_incoming," +
        //                                                              "id_incoming," +
        //                                                              "id_type_pay,users_bd) " +
        //                                                       "values ('" + Kod + "',"
        //                                                       + Convert.ToString(Rcena).Replace(',', '.') + ","
        //                                                       + Convert.ToString(ostatok_incoming / obem_spisanie).Replace(',', '.') + ","
        //                                                       + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'"
        //                                                       + datechek + "',"
        //                                                       + chek + ",'"
        //                                                       + numberdock_mag_incoming + "',"
        //                                                       + id_incoming + ",'"
        //                                                       + type_pay + "',"
        //                                                       + Sform.id_users + ")";
        //            }
        //            else
        //            {
        //                txtSQLQueryUpdateSales = "insert into  Sales (Kod," +
        //                                                              "Rcena," +
        //                                                              "Count," +
        //                                                              "Zcena," +
        //                                                              "Date," +
        //                                                              "Chek," +
        //                                                              "numberdock_mag_incoming," +
        //                                                              "id_incoming," +
        //                                                              "id_type_pay,users_bd) " +
        //                                                        "values ('" + Kod + "',"
        //                                                        + Convert.ToString(Rcena).Replace(',', '.') + ","
        //                                                        + Convert.ToString(ostatok_incoming).Replace(',', '.') + ","
        //                                                        + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'"
        //                                                        + datechek + "',"
        //                                                        + chek + ",'"
        //                                                        + numberdock_mag_incoming + "',"
        //                                                        + id_incoming + ",'"
        //                                                        + type_pay + "',"
        //                                                        + Sform.id_users + ")";
        //            }
        //            _SQl.SQL_Query(txtSQLQueryUpdateSales);

        //            DataTable QuantityKodTable = new DataTable();
        //            string txtSQLQuerySelectDbase = "";
        //            double Quantity = 0;
        //            string txtSQLQueryUpdateDbase = "";
        //            if (obem_spisanie > 0)
        //            {
        //                txtSQLQuerySelectDbase = "select quantity from dbase where kod='" + kod_osnova + "'";
        //                QuantityKodTable = _SQl.ExecuteSQL(txtSQLQuerySelectDbase);
        //                Quantity = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString()) - ostatok_incoming), 3);
        //                txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + kod_osnova + "'";
        //            }
        //            else
        //            {
        //                txtSQLQuerySelectDbase = "select quantity from dbase where kod='" + Kod + "'";
        //                QuantityKodTable = _SQl.ExecuteSQL(txtSQLQuerySelectDbase);
        //                Quantity = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString()) - ostatok_incoming), 3);
        //                txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + Kod + "'";
        //            }

        //            _SQl.SQL_Query(txtSQLQueryUpdateDbase);

        //            Count = Math.Round((Count - ostatok_incoming), 3);
        //            if (Count <= 0)
        //            {
        //                _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + Kod + "'");
        //                return;
        //            }

        //        }
        //        else
        //        {
        //            // Количество товара меньше свободного остатка в таблице прихода
        //            string txtSQLQueryUpdateIncoming = "update  incoming set  count_s =" + Convert.ToString((Count + count_s_incoming)).Replace(',', '.') + " where id =" + id_incoming + "";
        //            _SQl.SQL_Query(txtSQLQueryUpdateIncoming);

        //            string txtSQLQueryUpdateSales = "";
        //            if (obem_spisanie > 0)
        //            {
        //                txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(Count / obem_spisanie).Replace(',', '.') + "," + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'" + numberdock_mag_incoming + "'," + id_incoming + ",'" + type_pay + "'," + Sform.id_users + ")";
        //            }
        //            else
        //            {
        //                txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(Count).Replace(',', '.') + "," + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'" + numberdock_mag_incoming + "'," + id_incoming + ",'" + type_pay + "'," + Sform.id_users + ")";
        //            }
        //            _SQl.SQL_Query(txtSQLQueryUpdateSales);


        //            DataTable QuantityKodTable = new DataTable();
        //            string txtSQLQuerySelectDbase = "";
        //            double Quantity = 0;
        //            string txtSQLQueryUpdateDbase = "";
        //            if (obem_spisanie > 0)
        //            {
        //                txtSQLQuerySelectDbase = "select quantity from dbase where kod='" + kod_osnova + "'";
        //                QuantityKodTable = _SQl.ExecuteSQL(txtSQLQuerySelectDbase);
        //                Quantity = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString()) - Count), 3);
        //                txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + kod_osnova + "'";
        //            }
        //            else
        //            {
        //                txtSQLQuerySelectDbase = "select quantity from dbase where kod='" + Kod + "'";
        //                QuantityKodTable = _SQl.ExecuteSQL(txtSQLQuerySelectDbase);
        //                Quantity = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString()) - Count), 3);
        //                txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + Kod + "'";
        //            }

        //            _SQl.SQL_Query(txtSQLQueryUpdateDbase);

        //            Count = Math.Round((Count - ostatok_incoming), 3);
        //            if (Count <= 0)
        //            {
        //                _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + Kod + "'");
        //                return;
        //            }
        //        }
        //    }

        //    // Если нет свободного остатка (продажа в минус!!!!!!!!!!!!!!!), а количество товара больше 0!!!!!
        //    if (Count >= 0)
        //    {

        //        string txtSQLQueryUpdateSales = "";
        //        if (obem_spisanie > 0)
        //        {
        //            txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(Count / obem_spisanie).Replace(',', '.') + "," + Convert.ToString(Zcena).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'0',0,'" + type_pay + "'," + Sform.id_users + ")";
        //        }
        //        else
        //        {
        //            txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(Count).Replace(',', '.') + "," + Convert.ToString(Zcena).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'0',0,'" + type_pay + "'," + Sform.id_users + ")";
        //        }

        //        _SQl.SQL_Query(txtSQLQueryUpdateSales);

        //        DataTable QuantityKodTable = new DataTable();
        //        string txtSQLQuerySelectDbase = "";
        //        double Quantity = 0;
        //        string txtSQLQueryUpdateDbase = "";
        //        if (obem_spisanie > 0)
        //        {
        //            txtSQLQuerySelectDbase = "select quantity from dbase where kod='" + kod_osnova + "'";
        //            QuantityKodTable = _SQl.ExecuteSQL(txtSQLQuerySelectDbase);
        //            Quantity = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString()) - Count), 3);
        //            txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + kod_osnova + "'";
        //        }
        //        else
        //        {
        //            txtSQLQuerySelectDbase = "select quantity from dbase where kod='" + Kod + "'";
        //            QuantityKodTable = _SQl.ExecuteSQL(txtSQLQuerySelectDbase);
        //            Quantity = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString()) - Count), 3);
        //            txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + Kod + "'";
        //        }

        //        _SQl.SQL_Query(txtSQLQueryUpdateDbase);

        //        Count = 0;
        //        FlagSaleMinus = 1;
                
        //        _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + Kod + "'");

        //    }
        //}
        public void Fifo(string Kod, double Count, double Zcena, double Rcena, int chek, string datechek, string type_pay, string kod_osnova, double obem_spisanie, string Name)
        {
            // ПРОВЕРИТЬ С ВИРТУАЛЬНЫМИ КОДАМИ БЛОКИРОВКУ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            string KODFIFO = "";
            if (obem_spisanie > 0)
            {
                KODFIFO = kod_osnova;
                Count =  Math.Round((Count * obem_spisanie),3);
            }
            else
            {
                KODFIFO = Kod;
            }

            //Блокируем код товара всем потокам для работы с ним по всем запросам 
            while (true)
            {
                _SQl.SQL_Query("INSERT INTO BlockT (kod_dbase) Values('" + KODFIFO + "')");
                    if (_SQl.uniqBlockT == 0 && _SQl.sql_con.State.ToString()=="Closed")
                    {
                        break;
                    }
                    Thread.Sleep(500);
            }
            //Проверка есть ли привязка на списание к основному товару
            double QTYDBASE = 0;//количество из dbase
            DataTable QuantityKodTable = new DataTable();
           
            FifoTable = _SQl.ExecuteSQL("SELECT numberdock_mag," +
                                                   "count," +
                                                   "count_s," +
                                                   "zcena,id" +
                                           " FROM incoming WHERE " +
                                                   "kod_dbase = '" + KODFIFO + "' " +
                                                   "AND status = '0' order by date");

            QuantityKodTable = _SQl.ExecuteSQL("select quantity from dbase where kod='" + KODFIFO + "'");
            QTYDBASE = Math.Round((Convert.ToDouble(QuantityKodTable.Rows[0][0].ToString())), 3);//количество товара 
            
            for (int idrow = 0; idrow < FifoTable.Rows.Count; idrow++)
            {

                string numberdock_mag_incoming = FifoTable.Rows[idrow][0].ToString();
                double count_incoming = Math.Round(Convert.ToDouble(FifoTable.Rows[idrow][1].ToString()),3);
                double count_s_incoming = Math.Round(Convert.ToDouble(FifoTable.Rows[idrow][2].ToString()),3);
                double zcena_incoming = 0;
                if (obem_spisanie > 0)
                {
                    zcena_incoming = Convert.ToDouble(FifoTable.Rows[idrow][3].ToString()) * obem_spisanie;
                }
                else
                {
                    zcena_incoming = Convert.ToDouble(FifoTable.Rows[idrow][3].ToString());
                }
                double ostatok_incoming = Math.Round((count_incoming - count_s_incoming), 3);
                int id_incoming = Convert.ToInt32(FifoTable.Rows[idrow][4].ToString());

                // Количество товара больше или равно свободному остатку в таблице прихода
                double CountFIFO = 0;
                if (Count >= ostatok_incoming)
                {
                   
                    CountFIFO=Math.Round((ostatok_incoming + count_s_incoming),3);
                    string txtSQLQueryUpdateIncoming = "update incoming " +
                                "set count_s =" + Convert.ToString(CountFIFO).Replace(',', '.') + "," +
                                "status='1' where id =" + id_incoming + "";
                   //выполнение запроса внизу

                  
                    
                    if (obem_spisanie > 0)
                    {
                        CountFIFO = Math.Round((ostatok_incoming / obem_spisanie),3);
                    }
                    else
                    {
                        CountFIFO = ostatok_incoming;
                    }
                    string txtSQLQueryUpdateSales = "insert into  Sales (Kod," +
                                                                     "Rcena," +
                                                                     "Count," +
                                                                     "Zcena," +
                                                                     "Date," +
                                                                     "Chek," +
                                                                     "numberdock_mag_incoming," +
                                                                     "id_incoming," +
                                                                     "id_type_pay,users_bd) " +
                                                               "values ('" + Kod + "',"
                                                               + Convert.ToString(Rcena).Replace(',', '.') + ","
                                                               + Convert.ToString(CountFIFO).Replace(',', '.') + ","
                                                               + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'"
                                                               + datechek + "',"
                                                               + chek + ",'"
                                                               + numberdock_mag_incoming + "',"
                                                               + id_incoming + ",'"
                                                               + type_pay + "',"
                                                               + Sform.id_users + ")";

                    //выполнение запроса внизу
                    
                   
                    double Quantity = 0;
                    string txtSQLQueryUpdateDbase = "";
                    
                        
                    Quantity = Math.Round((QTYDBASE - ostatok_incoming), 3);
                    QTYDBASE = Quantity;
                    txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + KODFIFO + "'";
                    //выполнение запроса внизу



                    _SQl.SQL_Query(txtSQLQueryUpdateIncoming + ";" + txtSQLQueryUpdateSales + ";" + txtSQLQueryUpdateDbase+";");//обновление инокминг
                    //_SQl.SQL_Query(txtSQLQueryUpdateSales);//обновление салес
                    //_SQl.SQL_Query(txtSQLQueryUpdateDbase);//обновляем дбазе
                    
                    Count = Math.Round((Count - ostatok_incoming), 3);

                    if (Count <= 0)
                    {
                        _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + KODFIFO + "'");
                        Thread.Sleep(200);
                        return;
                    }

                }
                else
                {
                    // Количество товара меньше свободного остатка в таблице прихода
                    CountFIFO = Math.Round(Count + count_s_incoming,3);
                    string txtSQLQueryUpdateIncoming = "update  incoming set  count_s =" + Convert.ToString(CountFIFO).Replace(',', '.') + " where id =" + id_incoming + "";
                    //выполнение запроса внизу
                    

                    string txtSQLQueryUpdateSales = "";
                    if (obem_spisanie > 0)
                    {
                        CountFIFO =Math.Round((Count / obem_spisanie),3);
                    }
                    else
                    {
                        CountFIFO = Count;
                    }
                    txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(CountFIFO).Replace(',', '.') + "," + Convert.ToString(zcena_incoming).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'" + numberdock_mag_incoming + "'," + id_incoming + ",'" + type_pay + "'," + Sform.id_users + ")";
                    //выполнение запроса внизу

                   
                    double Quantity = 0;
                    string txtSQLQueryUpdateDbase = "";
                   
                    Quantity = Math.Round((QTYDBASE - Count), 3);
                    QTYDBASE = Quantity;
                    txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(Quantity).Replace(',', '.') + " where kod='" + KODFIFO + "'";
                    //выполнение запроса внизу

                    _SQl.SQL_Query(txtSQLQueryUpdateIncoming + ";" + txtSQLQueryUpdateSales + ";"+ txtSQLQueryUpdateDbase + ";");
                    //_SQl.SQL_Query(txtSQLQueryUpdateSales);
                    //_SQl.SQL_Query(txtSQLQueryUpdateDbase);

                    Count = Math.Round((Count - ostatok_incoming), 3);
                    if (Count <= 0)
                    {
                        _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + KODFIFO + "'");
                        Thread.Sleep(200);
                        return;
                    }
                }
            }

            // Если нет свободного остатка (продажа в минус!!!!!!!!!!!!!!!), а количество товара больше 0!!!!!
            if (Count >= 0)
            {
                double CountFIFOMinus = 0;
                string txtSQLQueryUpdateSales = "";
                if (obem_spisanie > 0)
                {
                    CountFIFOMinus = Math.Round((Count / obem_spisanie),3);
                }
                else
                {
                    CountFIFOMinus = Count;
                }
                txtSQLQueryUpdateSales = "insert into  Sales (Kod,Rcena,Count,Zcena,Date,Chek,numberdock_mag_incoming,id_incoming,id_type_pay,users_bd) values ('" + Kod + "'," + Convert.ToString(Rcena).Replace(',', '.') + "," + Convert.ToString(CountFIFOMinus).Replace(',', '.') + "," + Convert.ToString(Zcena).Replace(',', '.') + ",'" + datechek + "'," + chek + ",'0',0,'" + type_pay + "'," + Sform.id_users + ")";
                //Выполнение запроса внизу

                
                
                double Quantity = 0;
                string txtSQLQueryUpdateDbase = "";

                Quantity = Math.Round((QTYDBASE - Count), 3);
                QTYDBASE = Quantity;
                txtSQLQueryUpdateDbase = "update dbase set quantity=" + Convert.ToString(QTYDBASE).Replace(',', '.') + " where kod='" + KODFIFO + "'";


                _SQl.SQL_Query(txtSQLQueryUpdateSales+";"+txtSQLQueryUpdateDbase+";");
            
                Count = 0;
                FlagSaleMinus = 1;

                _SQl.SQL_Query("DELETE FROM BlockT WHERE kod_dbase='" + KODFIFO + "'");
                Thread.Sleep(200);

            }
        }
     
        private void SummChek()
        {
            lblSumChekTform.Text = "0";
            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                dGV.Rows[i].Cells["Rsumm"].Value = Math.Round(Convert.ToDouble(dGV.Rows[i].Cells["Rcena"].Value) * Convert.ToDouble(dGV.Rows[i].Cells["Count"].Value),0);
                lblSumChekTform.Text = Convert.ToString(Convert.ToDouble(dGV.Rows[i].Cells["Rsumm"].Value) + Convert.ToDouble(lblSumChekTform.Text));
            
            }
            txtShtovar.Focus();
        }


        public Tform()
        {
            CallBackMy.callbackEventHandlerTform = new CallBackMy.callbackEventTform(this.LoadDatakod);
            //перехват нажатия enter
                InitializeComponent();
                
                this.KeyUp += new KeyEventHandler(EnterKeyWait);
                this.KeyUp += new KeyEventHandler(F2KeyWait);
                this.KeyUp += new KeyEventHandler(F5KeyWait);
                

        }


        private void EnterKeyWait(object sender, KeyEventArgs e)
        {
            // Если фокус в штрихкод то выполняем действия
            if (txtShtovar.Focused == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtShtovar.Text != "")
                    {
                        DataTable PrefPlutbl = _SQl.ExecuteSQL("select PrefVesEan,PLUcount,EAnCount,PLUkodnum from source");
                        string prefPlu = PrefPlutbl.Rows[0][0].ToString();
                        int PLUcount = Convert.ToInt32(PrefPlutbl.Rows[0][1].ToString());
                        int EAnCount = Convert.ToInt32(PrefPlutbl.Rows[0][2].ToString());
                        string EanWeight = txtShtovar.Text;

                        if (EanWeight.Length == EAnCount)
                        {
                            if (EanWeight.IndexOf(prefPlu,0,2) >= 0)
                            {
                                weight_goods(PLUcount, EanWeight);
                                return;
                            }

                        }
                        LoadDatashk();
                    }
                }
            }
        }
        private void F2KeyWait(object sender, KeyEventArgs e)
        {
            // Если фокус в штрихкод то выполняе действия
            if (txtShtovar.Focused == true)
            {
                if (e.KeyCode == Keys.F2)
                {
                    int idrow = dGV.Rows.Count;
                    if (idrow>0)
                    {
                        dGV.Focus();
                        dGV.CurrentCell = dGV.Rows[idrow-1].Cells[4];
                    }

                }
            }
        }
        private void F5KeyWait(object sender, KeyEventArgs e)
        {
            if (dGV.RowCount > 0)
            {

                if (e.KeyCode == Keys.F5)
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "calcform")
                        {
                            f.Focus();
                            return;
                        }
                    }

                    btnProbit.PerformClick();

                }
            }
            
        }

        private void Tform_Load(object sender, EventArgs e)
        {
            
            dGV.Columns.Add("Kod", "Код");
            dGV.Columns.Add("Name", "Наименование");
            dGV.Columns.Add("Zcena", "Цена закупки");
            dGV.Columns.Add("Rcena", "Цена");
            dGV.Columns.Add("Count", "Кол-во");
            dGV.Columns.Add("Rsumm", "Сумма");
            dGV.Columns.Add("Privyazka", "Привязка товара");//Колонка в которой код основного товара для списания
            dGV.Columns.Add("Spisanie", "Объем списания");//Колонка в которой код объема списания
            dGV.Columns[2].Visible = false;
            //dGV.Columns[0].Width = 100;
            //dGV.Columns[1].Width = 589;
            //dGV.Columns[3].Width = 100;
            //dGV.Columns[4].Width = 100;
            //dGV.Columns[5].Width = 100;

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[6].Visible = false;
            dGV.Columns[7].Visible = false;

            dGV.Columns[0].ReadOnly = true;
            dGV.Columns[1].ReadOnly = true;
            dGV.Columns[3].ReadOnly = true;
            dGV.Columns[5].ReadOnly = true;

            if(Sform.id_access==1)
            {
                
                btnDel.Enabled = false;
                ckbVozvrat.Enabled = false;
            }
            if (File.Exists(Application.StartupPath + "\\torg.xml"))
            {
                serTload();
                SummChek();
            }
        }



        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGV.CurrentRow.Index;
            string chek_cell = "";
            if (Convert.ToString(dGV.Rows[i].Cells["Count"].Value) == "")
            {
                dGV.Rows[i].Cells["Count"].Value = 1;
            }
            else
            {
                chek_cell = dGV.Rows[i].Cells["Count"].Value.ToString();
            }
            double num;
            if (double.TryParse(chek_cell, out num))
            {
                if (Convert.ToDouble(dGV.Rows[i].Cells["Count"].Value) < 0)
                {
                    dGV.Rows[i].Cells["Count"].Value = 1;
                }
                else
                {
                    dGV.Rows[i].Cells["Count"].Value = Convert.ToDouble(chek_cell);
                }
                SummChek();
                serTsave();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа! В товаре: " + Environment.NewLine + dGV.Rows[i].Cells["Name"].Value, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dGV.Rows[i].Cells["Count"].Value = 1;
                SummChek();
            }

            
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            int l = dGV.RowCount;
            if (l == 0)
            {
                MessageBox.Show("Чек пустой!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtShtovar.Focus();
                return;
            }
            int i = dGV.CurrentRow.Index;
            dGV.Rows.RemoveAt(i);
            SummChek();
            serTsave();
        }

        private void btnProbit_Click(object sender, EventArgs e)
        {
            if (dGV.RowCount > 0)
            {
                // проверяем не запущена ли форма 
                for (int x = 0; x < this.OwnedForms.Length; x++)
                {
                    if (this.OwnedForms[x].Name == "calcform")
                    {
                        this.OwnedForms[x].Focus();
                        return;
                    }
                }

                // Запускаем форму если она не запущена

                Form calcform = new calcform();
                calcform.StartPosition = FormStartPosition.CenterScreen;
                //calcform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                calcform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                calcform.Show();
               
            }

        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {
            txtKod.Text=Regex.Replace(txtKod.Text,"[^0-9]", string.Empty); 
            if (txtKod.TextLength == 6)
            {
                pref_kod = _SRC.pref_kod();
                string kodtovara = pref_kod + txtKod.Text;
                LoadDatakod(kodtovara);
                txtKod.Text = "";
            }
        }

        private void txtShtovar_TextChanged(object sender, EventArgs e)
        {
           txtShtovar.Text=Regex.Replace(txtShtovar.Text, "[^0-9]", string.Empty);
        }

        private void btnFindT_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "FindTovarform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            
            // Запускаем форму если она не запущена
            Sform.ownerFormName = "Tform";
            Form FindTovarform = new FindTovarform();
            FindTovarform.StartPosition = FormStartPosition.CenterScreen;
            //FindTovarform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            FindTovarform.Owner= this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            FindTovarform.Show();
        }

        private void ckbVozvrat_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVozvrat.Checked == true)
            {
                ckbVozvrat.BackColor = Color.Red;
            }
            else
            {
                ckbVozvrat.BackColor = SystemColors.Control;
            }
        }

        private void btnGurnalSales_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "GurnalSalesform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form GurnalSalesform = new GurnalSalesform();
            GurnalSalesform.StartPosition = FormStartPosition.CenterScreen;
            //FindTovarform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            GurnalSalesform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            GurnalSalesform.Show();
        }



        private void Tform_Activated(object sender, EventArgs e)
        {
            txtShtovar.Focus();
        }

        private void Tform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dGV.RowCount>0)
            {
                MessageBox.Show("Пробейте чек или удалите все позиции!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                return;
            }
            
            if (e.CloseReason.ToString() == "UserClosing")
            {
                DialogResult Close_form = MessageBox.Show("Вы действительно хотите закрыть окно ''Торговля'' ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Close_form == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void weight_goods(int PluCount, string EanWeight)
        {
            string PluKod = EanWeight.Substring(2, PluCount);
            string GoodsWeight = EanWeight.Substring(2 + PluCount, 5).Insert(2,",");
            if (GoodsWeight.Remove(1) == "0")
            {
                GoodsWeight = GoodsWeight.Substring(1, 5);
            }
            DataTable PluKodtbl = _SQl.ExecuteSQL("select Kod,Name,Rcena,Zcena,kod_osnova,obem_spisanie from dbase where plukod=" + PluKod + "");

            if (PluKodtbl.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string kod = PluKodtbl.Rows[0][0].ToString();
            string name = PluKodtbl.Rows[0][1].ToString();
            double rcena = Convert.ToDouble(PluKodtbl.Rows[0][2].ToString());
            double zcena = Convert.ToDouble(PluKodtbl.Rows[0][3].ToString());
            double count = Convert.ToDouble(GoodsWeight);
            double rsumm = count * rcena;
            string kodosnova = PluKodtbl.Rows[0][4].ToString();
            double obem_spisanie = Convert.ToDouble(PluKodtbl.Rows[0][5].ToString());

            dGV.Rows.Add(kod, name, zcena, rcena, count, rsumm, kodosnova, obem_spisanie);

            int resultfindkod = 0;
            if (dGV.Rows.Count > 0)
            {
                for (int i = 0; i < dGV.Rows.Count - 1; i++)
                {
                    if (dGV.Rows[i].Cells[0].Value.ToString() == kod)
                    {
                        dGV.Rows[i].Cells[4].Value = Convert.ToDouble(dGV.Rows[i].Cells[4].Value.ToString()) + Convert.ToDouble(count);
                        dGV.Rows.RemoveAt(dGV.Rows.Count - 1);
                        dGV.ClearSelection();
                        dGV.Rows[i].Selected = true;
                        resultfindkod = 1;

                    }

                }
                if (resultfindkod == 0)
                {
                    dGV.ClearSelection();
                    dGV.Rows[Convert.ToInt32(dGV.Rows.Count - 1)].Selected = true;

                }
             }
            txtShtovar.Text = "";
            SummChek();
            serTsave();
        }

        private void Tform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

     
        public void PrintChek(string chek)
        {
            double summchek = 0;
            dtPrintChek.Clear();
            if (dtPrintChek.Columns.Count == 0)
            {
                dtPrintChek.Columns.Add("0");
                dtPrintChek.Columns.Add("1");
                dtPrintChek.Columns.Add("2");
                dtPrintChek.Columns.Add("3");

            }

            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                dtPrintChek.Rows.Add(Convert.ToString(i + 1) + ". " + dGV.Rows[i].Cells[1].Value, dGV.Rows[i].Cells[4].Value, dGV.Rows[i].Cells[3].Value, dGV.Rows[i].Cells[5].Value);
                summchek = summchek + Convert.ToDouble(dGV.Rows[i].Cells[5].Value);
            }

            if (dtPrintChek != null)
            {
                var pHelper = new PrintHelper(dtPrintChek);
                pHelper.PrintChek(this.Text, summchek, dGV.RowCount,chek);
            }
        }

        private void dGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            serTsave();
        }
     

        [Serializable]
        public  class Torg
        {
            public string Kod;
            public string NameT;
            public double Zcena;
            public double Rcena;
            public double Count;
            public double Rsumm;
            public string Privyazka;
            public double Spisanie;
  
        }


        public void serTsave()
        {
            List<Torg> ProfileList = new List<Torg>();
            
            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                DataGridViewRow _row = dGV.Rows[i];

                Torg T = new Torg();
                if (_row.Cells[0].Value != null)
                    T.Kod = (string)_row.Cells[0].Value;

                if (_row.Cells[1].Value != null)
                    T.NameT = (string)_row.Cells[1].Value;

                if (_row.Cells[2].Value != null)
                    T.Zcena = (double)_row.Cells[2].Value;

                if (_row.Cells[3].Value != null)
                    T.Rcena = (double)_row.Cells[3].Value;

                if (_row.Cells[4].Value != null)
                    T.Count = (double)_row.Cells[4].Value;

                if (_row.Cells[5].Value != null)
                    T.Rsumm = (double)_row.Cells[5].Value;

                if (_row.Cells[6].Value != null)
                    T.Privyazka = (string)_row.Cells[6].Value;

                if (_row.Cells[7].Value != null)
                    T.Spisanie = (double)_row.Cells[7].Value;

               
                ProfileList.Add(T);
            }

            serializeTable.Save<List<Torg>>(ProfileList, Application.StartupPath+"\\torg.xml");
        }
        public void serTload()
        {
            List<Torg> ProfileList = new List<Torg>();
            ProfileList = serializeTable.Load<List<Torg>>(Application.StartupPath + "\\torg.xml");

            dGV.Rows.Clear();

            foreach (Torg T in ProfileList)
            {
                
                dGV.Rows.Add(new object[] { T.Kod, T.NameT, T.Zcena, T.Rcena, T.Count, T.Rsumm,T.Privyazka,T.Spisanie });
            }
            
        }

        private void tSMenuSelectAll_Click(object sender, EventArgs e)
        {

            dGV.SelectAll();
        }

        private void tSMenuCopy_Click(object sender, EventArgs e)
        {
            DataObject dataObj = dGV.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }


        public void ReturnGoods()
        {

            string SQLQueryReturnGoods = "";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == "Cash")
                {
                    this.MdiParent.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form Cash = new Cash();
            Cash.StartPosition = FormStartPosition.CenterScreen;
            Cash.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Cash.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Cash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int ch = 0;
            string[] kod ={"ia000001"
                ,"ia000006"
                ,"ia000105"
                ,"ia000106"
                ,"ia000108"  
                ,"ia000110"
                ,"ia000111"
                ,"ia000112"
                ,"ia000113"
                ,"ia000114"
                ,"ia000115"
                ,"ia000117"
                ,"ia000118"
                ,"ia000119"
                ,"ia000121"
                ,"ia000122"
                ,"ia000123"
                ,"ia000124"
                ,"ia000125"
                ,"ia000129"
                ,"ia000130"
                ,"ia000131"
                ,"ia000132"
                ,"ia000138"
                ,"ia000139"
                ,"ia000140"
                ,"ia000141"
                ,"ia000142"
                ,"ia000143"
                ,"ia000144"
                ,"ia000145"
                ,"ia000147"
                ,"ia000156"
                ,"ia000163"
                ,"ia000164"
                ,"ia000165"
                ,"ia000175"
                ,"ia000177"
                ,"ia000178"
                ,"ia000179"
                ,"ia000181"
                ,"ia000183"
                ,"ia000184"
                ,"ia000185"
                ,"ia000186"
                ,"ia000187"
                ,"ia000191"
                ,"ia000195"
                ,"ia000200"
                ,"ia000201"};
            for (int i = 0; i < 50; i++)
            {
                DateTime date1 = DateTime.Now;
                string datechek = date1.ToString("u").Remove(19);
                ch = _SRC.chek();
                //kod[i]
                Fifo("ia000110", 5.0, 41.01, 58.0, ch, datechek, "Н", "0", 0.0, "Пиво Амстел 4,6% 0,5л ж/б");
                
            }
        }

      
     

     
   
    }
}
