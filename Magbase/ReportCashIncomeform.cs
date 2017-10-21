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
    public partial class ReportCashIncomeform : Form
    {
        sqldb _SQl = new sqldb();
        public ReportCashIncomeform()
        {
            InitializeComponent();
        }

        private void btnRepCash_Click(object sender, EventArgs e)
        {
            ReportCashAll();
        }

        private void ReportCashAll()
        {
            dgvRepCash.Rows.Clear();
            int monthN = dtpMonth.Value.Month;
            int yearN = dtpMonth.Value.Year;
            int yearE = dtpMonth.Value.Year;
            int monthE = dtpMonth.Value.Month + 1;
            int dayM = DateTime.DaysInMonth(yearN, monthN);
            if (monthE> 12)
            {
                monthE = 1;
                yearE = yearE + 1;
            }

            
            string periodN = yearN.ToString() + "-" + monthN.ToString().PadLeft(2, '0') +"-" + "01";
            string periodE = yearE.ToString() + "-" + monthE.ToString().PadLeft(2, '0') +"-" + "01";
            string QueryReportCashSales = "Select rcena,count,date,zcena,id_type_pay from sales where date >'" + periodN + "' and date <'" + periodE + "' order by date";
            string QueryReportCashIncoming = "Select count,zcena,date from incoming where date >'" + periodN + "' and date <'" + periodE + "' order by date";
            string QueryReportCashOutgoing = "Select count,zcena,date from outgoing where date >'" + periodN + "' and date <'" + periodE + "' order by date";

            DataTable ReportCashSalesTBL = _SQl.ExecuteSQL(QueryReportCashSales);
            DataTable ReportCashIncomingTBL = _SQl.ExecuteSQL(QueryReportCashIncoming);
            DataTable ReportCashOutgoingTBL = _SQl.ExecuteSQL(QueryReportCashOutgoing);

            for (int day = 1; day < (dayM+1); day++)
            {
                dgvRepCash.Rows.Add(day.ToString().PadLeft(2,'0')+"."+monthN.ToString().PadLeft(2,'0')+"."+yearN);
            }


            
            double summR = 0;
            double summZ = 0;
            double nal = 0;
            double beznal = 0;
            double summRashod = 0;
            double summZakup = 0;

            for (int irow = 0; irow < dgvRepCash.Rows.Count; irow++)
            {
               string dateDGV = dgvRepCash.Rows[irow].Cells["date"].Value.ToString();
///Таблица продажи-----------------------------------------------
                 for (int iSales = 0; iSales < ReportCashSalesTBL.Rows.Count; iSales++)
                 {
                     string dateSales = ReportCashSalesTBL.Rows[iSales][2].ToString().Remove(10);
                     if (dateSales == dateDGV)
                     {
                         if (ReportCashSalesTBL.Rows[iSales][4].ToString().ToLower() == "н")
                         {
                             nal += Math.Round((Convert.ToDouble(ReportCashSalesTBL.Rows[iSales][0].ToString()) * Convert.ToDouble(ReportCashSalesTBL.Rows[iSales][1].ToString())), 0);
                         }
                         else
                         {
                             beznal += Math.Round((Convert.ToDouble(ReportCashSalesTBL.Rows[iSales][0].ToString()) * Convert.ToDouble(ReportCashSalesTBL.Rows[iSales][1].ToString())), 0);
                         }
                         summR = summR + Math.Round((Convert.ToDouble(ReportCashSalesTBL.Rows[iSales][0].ToString()) * Convert.ToDouble(ReportCashSalesTBL.Rows[iSales][1].ToString())), 0);
                         summZ = summZ + Math.Round((Convert.ToDouble(ReportCashSalesTBL.Rows[iSales][3].ToString()) * Convert.ToDouble(ReportCashSalesTBL.Rows[iSales][1].ToString())), 2);

                     }
                     if (ReportCashSalesTBL.Rows.Count - 1 == iSales)
                     {
                         dgvRepCash.Rows[irow].Cells["purchase"].Value = summZ;
                         dgvRepCash.Rows[irow].Cells["nal"].Value = nal;
                         dgvRepCash.Rows[irow].Cells["beznal"].Value = beznal;
                         dgvRepCash.Rows[irow].Cells["sales"].Value = summR;
                         dgvRepCash.Rows[irow].Cells["income"].Value = (summR - summZ);
                         dgvRepCash.Rows[irow].Cells["marginofday"].Value = Math.Round(((summR / summZ) - 1) * 100, 2);
                         summR = 0;
                         summZ = 0;
                         beznal = 0;
                         nal = 0;
                     }
                 }
///Таблица приходы-----------------------------------------------
                 for (int iIncom = 0; iIncom < ReportCashIncomingTBL.Rows.Count; iIncom++)
                 {
                     string dateIncom = ReportCashIncomingTBL.Rows[iIncom][2].ToString().Remove(10);
                     if (dateIncom == dateDGV)
                     {
                         summZakup = summZakup + Math.Round((Convert.ToDouble(ReportCashIncomingTBL.Rows[iIncom][0].ToString()) * Convert.ToDouble(ReportCashIncomingTBL.Rows[iIncom][1].ToString())), 2);
                     }
                     if (ReportCashIncomingTBL.Rows.Count - 1 == iIncom)
                     {
                         dgvRepCash.Rows[irow].Cells["purchased"].Value = summZakup;
                         summZakup = 0;
                     }


                 }
///Таблица Расходы-----------------------------------------------
///
                 for (int iRashod = 0; iRashod < ReportCashOutgoingTBL.Rows.Count; iRashod++)
                 {
                     string dateRashod = ReportCashOutgoingTBL.Rows[iRashod][2].ToString().Remove(10);
                     if (dateRashod == dateDGV)
                     {
                         summRashod = summRashod + Math.Round((Convert.ToDouble(ReportCashOutgoingTBL.Rows[iRashod][0].ToString()) * Convert.ToDouble(ReportCashOutgoingTBL.Rows[iRashod][1].ToString())), 2);
                     }
                     if (ReportCashOutgoingTBL.Rows.Count - 1 == iRashod)
                     {
                         dgvRepCash.Rows[irow].Cells["salvage"].Value = summRashod;
                         summRashod = 0;
                     }
                }
            }

 
            double itogZsumm = 0;
            double itogRsumm = 0;
            double itogCash = 0;
            double itogZakup = 0;
            double itogVosvart = 0;
            double itogSpisanie = 0;
            double itogNal = 0;
            double itogBeznal = 0;

            for (int irowItog = 0; irowItog < dgvRepCash.Rows.Count; irowItog++)
            {
                itogCash = itogCash + Convert.ToDouble(dgvRepCash.Rows[irowItog].Cells[5].Value);
                itogZsumm = itogZsumm + Convert.ToDouble(dgvRepCash.Rows[irowItog].Cells[4].Value);
                itogRsumm = itogRsumm + Convert.ToDouble(dgvRepCash.Rows[irowItog].Cells[1].Value);
                //itogVosvart = itogVosvart + Convert.ToDouble(dgvRepCash.Rows[irowItog].Cells[5].Value);
                itogSpisanie = itogSpisanie + Convert.ToDouble(dgvRepCash.Rows[irowItog].Cells[8].Value);
                itogZakup = itogZakup + Convert.ToDouble(dgvRepCash.Rows[irowItog].Cells[6].Value);

                itogNal = itogNal + Convert.ToDouble(dgvRepCash.Rows[irowItog].Cells[2].Value);
                itogBeznal = itogBeznal + Convert.ToDouble(dgvRepCash.Rows[irowItog].Cells[3].Value);

                if (irowItog == dgvRepCash.Rows.Count - 1)
                {
                    dgvRepCash.Rows.Add("Итоги", itogRsumm, itogNal, itogBeznal, itogZsumm, itogCash, itogZakup, itogVosvart, itogSpisanie, Math.Round((((itogRsumm / itogZsumm) - 1) * 100), 2));
                    return;
                }

          
            }
      }

        private void ReportCashIncomeform_Load(object sender, EventArgs e)
        {
            
        }

        private void ReportCashIncomeform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var expExcel = new Export();
            //expExcel.ExportToExcel(dgvRepCash,this.Text);
        }
    }
}
