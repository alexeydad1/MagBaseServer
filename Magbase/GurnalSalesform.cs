using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagbaseServer
{
    public partial class GurnalSalesform : Form
    {
        sqldb _SQl = new sqldb();
        
        public GurnalSalesform()
        {
            InitializeComponent();
        }

        private void btnGurSalesRep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (dgvCheki.RowCount != 0)
            {
                dgvCheki.DataSource = "";
                dgvSostavChek.Rows.Clear();
            }
            string dateSales = func.replace_date_sql(mCalendar.SelectionStart.ToString());
            string QuerySalesDayNow = "select Kod,Rcena,Count,Chek,Date,id_type_pay,(Select Users.login from Users where Users.id=sales.users_bd) as user  from sales where date like'%" + dateSales + "%' order by chek";
            DataTable SalesDayNowTable = _SQl.ExecuteSQL(QuerySalesDayNow);
            
            DataTable chekiTable = new DataTable();
            chekiTable.Columns.Add("numChek");
            chekiTable.Columns.Add("time");
            chekiTable.Columns.Add("summChek");
            chekiTable.Columns.Add("typeChek");
            chekiTable.Columns.Add("userChek");


            double summChekAll = 0;
            int flagUniq = 0;
            double nal = 0;
            double beznal = 0;
            bool CountNull = false;
            int arrI=0;
            string[] arrNullsales = new string[SalesDayNowTable.Rows.Count];

            for (int i = 0; i < SalesDayNowTable.Rows.Count; i++)
            {
                if (SalesDayNowTable.Rows[i][5].ToString() == "Н")
                {

                    nal = nal + (Math.Round(Convert.ToDouble(SalesDayNowTable.Rows[i][1].ToString()) * Convert.ToDouble(SalesDayNowTable.Rows[i][2].ToString()), 0));

                }
                else
                {
                    beznal = beznal + (Math.Round(Convert.ToDouble(SalesDayNowTable.Rows[i][1].ToString()) * Convert.ToDouble(SalesDayNowTable.Rows[i][2].ToString()), 0));
                }

                for (int l = 0; l < SalesDayNowTable.Rows.Count; l++)
                {
                    for (int idvg = 0; idvg < chekiTable.Rows.Count; idvg++)
                    {

                        if (SalesDayNowTable.Rows[i][3].ToString() == chekiTable.Rows[idvg]["numChek"].ToString())
                        {
                            flagUniq = 1;
                            break;
                        }
                    }

                    if (flagUniq == 1)
                    {

                        flagUniq = 0;
                        break;
                    }
                    if (SalesDayNowTable.Rows[i][3].ToString() == SalesDayNowTable.Rows[l][3].ToString())
                    {
                        summChekAll = summChekAll + (Math.Round(Convert.ToDouble(SalesDayNowTable.Rows[l][1].ToString()) * Convert.ToDouble(SalesDayNowTable.Rows[l][2].ToString()), 0));
                        if (Convert.ToDouble(SalesDayNowTable.Rows[l][2].ToString()) <= 0)
                        {
                            CountNull = true;
                        }

                    }
                    if (l == SalesDayNowTable.Rows.Count - 1)
                    {

                        chekiTable.Rows.Add(SalesDayNowTable.Rows[i][3].ToString(), SalesDayNowTable.Rows[i][4].ToString().Remove(0, 11), summChekAll, SalesDayNowTable.Rows[i][5].ToString(), SalesDayNowTable.Rows[i][6].ToString());

                        if (CountNull == true)
                        {

                            arrNullsales[arrI] = SalesDayNowTable.Rows[i][3].ToString();
                            arrI++;
                            CountNull = false;

                        }
                        summChekAll = 0;
                    }

                }
            }

            dgvCheki.DataSource = chekiTable;

                       
            dgvCheki.Columns["numChek"].HeaderText="№ Чека";
            dgvCheki.Columns["time"].HeaderText="Время";
            dgvCheki.Columns["summChek"].HeaderText="Сумма";
            dgvCheki.Columns["typeChek"].HeaderText="Тип платежа";
            dgvCheki.Columns["userChek"].HeaderText="Пользователь";

            this.Cursor = Cursors.Default;
            for (int i = 0; i < dgvCheki.Rows.Count; i++)
            {
                for (int l = 0; l < arrNullsales.Length; l++)
                {
                    if (dgvCheki.Rows[i].Cells[0].Value.ToString() == arrNullsales[l])
                    {
                        dgvCheki.Rows[i].DefaultCellStyle.BackColor = Color.Plum;
                    }
                }
                if (dgvCheki.Rows[i].Cells[2].Value.ToString() == "0")
                {
                    dgvCheki.Rows[i].DefaultCellStyle.BackColor = Color.Plum;
                }


            }

            lblallvir.Text = Convert.ToString(nal + beznal);
            lblnalvir.Text = Convert.ToString(nal);
            lblbeznalvir.Text = Convert.ToString(beznal);
            dgvCheki.Focus();

           //dgvCheki.Rows.Clear();
           //dgvSostavChek.Rows.Clear();
           //string dateSales=func.replace_date_sql(mCalendar.SelectionStart.ToString());
           //string QuerySalesDayNow = "select Kod,Rcena,Count,Chek,Date,id_type_pay,(Select Users.login from Users where Users.id=sales.users_bd) as user  from sales where date like'%" + dateSales + "%' order by chek";
           //DataTable SalesDayNowTable = _SQl.ExecuteSQL(QuerySalesDayNow);
           //double summChekAll = 0;
           //int flagUniq = 0;
           //double nal = 0;
           //double beznal = 0;
           //bool CountNull=false ;
           //for (int i = 0; i < SalesDayNowTable.Rows.Count; i++)
           //{
           //    if (SalesDayNowTable.Rows[i][5].ToString() == "Н")
           //    {

           //        nal = nal + (Math.Round(Convert.ToDouble(SalesDayNowTable.Rows[i][1].ToString()) * Convert.ToDouble(SalesDayNowTable.Rows[i][2].ToString()),0));
                   
           //    }
           //    else
           //    {
           //        beznal = beznal + (Math.Round(Convert.ToDouble(SalesDayNowTable.Rows[i][1].ToString()) * Convert.ToDouble(SalesDayNowTable.Rows[i][2].ToString()),0));
           //    }
           //    for (int l = 0; l < SalesDayNowTable.Rows.Count; l++)
           //    {
           //        for (int idvg = 0; idvg < dgvCheki.RowCount; idvg++)
           //        {

           //            if (SalesDayNowTable.Rows[i][3].ToString() == dgvCheki.Rows[idvg].Cells["NumChek"].Value.ToString())
           //             {
           //                 flagUniq = 1;
           //                 break;
           //             }
           //        }

           //            if (flagUniq == 1)
           //            {

           //                flagUniq = 0;
           //                break;
           //            }
           //            if (SalesDayNowTable.Rows[i][3].ToString() == SalesDayNowTable.Rows[l][3].ToString())
           //            {
           //                summChekAll = summChekAll + (Math.Round(Convert.ToDouble(SalesDayNowTable.Rows[l][1].ToString()) * Convert.ToDouble(SalesDayNowTable.Rows[l][2].ToString()),0));
           //                if (Convert.ToDouble(SalesDayNowTable.Rows[l][2].ToString()) <= 0)
           //                {
           //                    CountNull = true;
           //                }
                       
           //            }
           //            if (l == SalesDayNowTable.Rows.Count - 1)
           //            {

           //                dgvCheki.Rows.Add(SalesDayNowTable.Rows[i][3].ToString(), SalesDayNowTable.Rows[i][4].ToString().Remove(0, 11), summChekAll, SalesDayNowTable.Rows[i][5].ToString(), SalesDayNowTable.Rows[i][6].ToString());

           //                if (CountNull == true)
           //                {

           //                    dgvCheki.Rows[dgvCheki.Rows.Count-1].DefaultCellStyle.BackColor = Color.Plum;
           //                    CountNull = false;

           //                }
           //                summChekAll = 0;
           //            }

           //    }
           //}
           //for (int i = 0; i < dgvCheki.Rows.Count; i++)
           //{
           //    if (dgvCheki.Rows[i].Cells[2].Value.ToString() == "0")
           //    {
           //        dgvCheki.Rows[i].DefaultCellStyle.BackColor = Color.Plum;
           //    }


           //}

           //lblallvir.Text = Convert.ToString(nal + beznal);
           //lblnalvir.Text = Convert.ToString(nal);
           //lblbeznalvir.Text = Convert.ToString(beznal);
           //dgvCheki.Focus();

        }

        private void dgvCheki_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool CountNull = false;
            if (e.KeyChar == 32)
            {
                if (dgvCheki.Rows.Count > 0)
                {
                    dgvSostavChek.Rows.Clear();
                    int irow = dgvCheki.CurrentRow.Index;
                    string QuerySostavCheka = "Select kod,(Select dbase.name from dbase where dbase.kod=sales.kod) as namet,rcena,count from Sales where chek='" + dgvCheki.Rows[irow].Cells["NumChek"].Value.ToString() + "'";
                    DataTable SostavChekaTable = _SQl.ExecuteSQL(QuerySostavCheka);
                    for (int i = 0; i < SostavChekaTable.Rows.Count; i++)
                    {
                        string kodt = SostavChekaTable.Rows[i][0].ToString();
                        string namet = SostavChekaTable.Rows[i][1].ToString();
                        double rcenat = Convert.ToDouble(SostavChekaTable.Rows[i][2].ToString());
                        double countt = Convert.ToDouble(SostavChekaTable.Rows[i][3].ToString());
                        if (countt <= 0)
                        {
                            CountNull = true;
                        }
                        double summt = Math.Round(rcenat * countt,0);
                        dgvSostavChek.Rows.Add(kodt, namet, rcenat, countt, summt);
                        if (CountNull == true)
                        {

                            dgvSostavChek.Rows[dgvSostavChek.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Plum;
                            CountNull = false;

                        }
                    }
                    dgvCheki.Focus();
                }
                 
            }
        }

        private void GurnalSalesform_Load(object sender, EventArgs e)
        {
            if (Sform.id_access == 0)
            {
                btnNB.Visible = true;
            }
            else
            {
                btnNB.Visible = false;
            }
        }

        private void GurnalSalesform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tform GurSalFrm = (Tform)this.Owner;
            GurSalFrm.txtShtovar.Focus();
        }

        private void btnNB_Click(object sender, EventArgs e)
        {
            if (dgvCheki.RowCount > 0)
            {
                DialogResult changeNalBez = MessageBox.Show("Изменить тип оплаты?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (changeNalBez == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (dgvCheki.Rows.Count > 0)
                    {
                        int idrowNB = dgvCheki.CurrentRow.Index;
                        string type_pay = dgvCheki.Rows[idrowNB].Cells[3].Value.ToString();
                        int chek_num = Convert.ToInt32(dgvCheki.Rows[idrowNB].Cells[0].Value.ToString());
                        string QueryChangeNB = "";

                        if (type_pay == "Н")
                        {
                            QueryChangeNB = "update sales set id_type_pay='Б' where chek=" + chek_num + "";
                        }
                        else
                        {
                            QueryChangeNB = "update sales set id_type_pay='Н' where chek=" + chek_num + "";
                        }
                        _SQl.SQL_Query(QueryChangeNB);
                        btnGurSalesRep.PerformClick();
                    }
                }
            }
        }

        private void GurnalSalesform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

                
    }
}
