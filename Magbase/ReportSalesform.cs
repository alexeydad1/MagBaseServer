using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MagbaseServer
{
    public partial class ReportSalesform : Form
    {
       
        sqldb _SQl = new sqldb();
       
        public ReportSalesform()
        {
            InitializeComponent();
        }

        private void ReportSalesform_Load(object sender, EventArgs e)
        {
            string SqlCmbLoad = "SELECT * FROM GroupT order by name";
            DataTable CmbLoadTable = _SQl.ExecuteSQL(SqlCmbLoad);

            cmbGruptSales.DataSource = CmbLoadTable;
            cmbGruptSales.DisplayMember = "Name";
            cmbGruptSales.ValueMember = "id";
            cmbGruptSales.SelectedValue = 0;
        }

        private void btnRepSales_Click(object sender, EventArgs e)
        {
            btnRepSales.Enabled = false;
            Application.DoEvents();
            ReportSalesAll();
            Application.DoEvents();
            btnRepSales.Enabled = true;

        }
        private void ReportSales()
        {
            dgvRepSales.Rows.Clear();
            
            string periodN = func.replace_date_sql(Convert.ToString(dtpSalesN.Value));
            string periodE = func.replace_date_sql(Convert.ToString(dtpSalesE.Value.AddDays(1)));
            string QueryReportSales = "Select kod,(Select dbase.name from dbase where dbase.kod=sales.kod) as namet,rcena,count,zcena,(Select name from groupt where id= (Select dbase.id_group from dbase where dbase.kod=sales.kod)) as groupt,(select dbase.zcena from dbase where dbase.kod=sales.kod) as zcenaNow,(select dbase.rcena from dbase where dbase.kod=sales.kod) as rcenaNow from Sales where date >'" + periodN + "' and date <'" + periodE + "' order by kod";
            DataTable ReportSalesTable = _SQl.ExecuteSQL(QueryReportSales);
            
            double coutnsrednee = 0;
            double summZsrednee = 0;
            double summRsrednee = 0;
            int flaguot = 0;
            for (int i = 0; i < ReportSalesTable.Rows.Count; i++)
            {
                
               

                string kod = ReportSalesTable.Rows[i][0].ToString();
                string namet = ReportSalesTable.Rows[i][1].ToString();
                double zcenanow = Convert.ToDouble(ReportSalesTable.Rows[i][6].ToString());
                double rcenanow = Convert.ToDouble(ReportSalesTable.Rows[i][7].ToString());
                double countt = Convert.ToDouble(ReportSalesTable.Rows[i][3].ToString());
                string groupt = ReportSalesTable.Rows[i][5].ToString();

                for (int l = 0; l < ReportSalesTable.Rows.Count; l++)
                {
                    for (int irow = 0; irow < dgvRepSales.Rows.Count; irow++)
                    {
                        if (dgvRepSales.Rows.Count != 0)
                        {
                            if (dgvRepSales.Rows[irow].Cells[0].Value.ToString() == kod)
                            {
                                flaguot = 1;
                                break;
                            }
                        }
                    }
                    if (flaguot == 1)
                    {
                        flaguot = 0;
                        break;

                    }
                    if (kod == ReportSalesTable.Rows[l][0].ToString())
                    {
                        coutnsrednee = coutnsrednee + Convert.ToDouble(ReportSalesTable.Rows[l][3].ToString());
                        summZsrednee = summZsrednee + (Convert.ToDouble(ReportSalesTable.Rows[l][4].ToString()) * Convert.ToDouble(ReportSalesTable.Rows[l][3].ToString()));
                        summRsrednee = summRsrednee + Math.Round((Convert.ToDouble(ReportSalesTable.Rows[l][2].ToString()) * Convert.ToDouble(ReportSalesTable.Rows[l][3].ToString())), 0);
                    }
                    if (l == ReportSalesTable.Rows.Count - 1)
                    {
                        dgvRepSales.Rows.Add(kod, namet, zcenanow, rcenanow, coutnsrednee, summZsrednee, Math.Round(summRsrednee, 0), Math.Round((((rcenanow / zcenanow) - 1) * 100), 2), groupt, Math.Round(summZsrednee / coutnsrednee, 2), Math.Round(summRsrednee / coutnsrednee, 2), Math.Round(((((Math.Round((summRsrednee / coutnsrednee), 2) / Math.Round((summZsrednee / coutnsrednee), 2)) - 1)) * 100), 2));
                      
                        coutnsrednee = 0;
                        summZsrednee = 0;
                        summRsrednee = 0;

                    }
                }
            }
            double itogZsumm = 0;
            double itogRsumm = 0;
            //double itogMargin = 0;
            double itogSRMargin = 0;
            double itogQty = 0;

            for (int irowItog = 0; irowItog < dgvRepSales.Rows.Count; irowItog++)
            {
                itogQty = itogQty + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[4].Value);
                itogZsumm = itogZsumm + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[5].Value);
                itogRsumm = itogRsumm + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[6].Value);
                //itogMargin = itogMargin + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[7].Value);
                itogSRMargin = itogSRMargin + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[11].Value);

                if (irowItog == dgvRepSales.Rows.Count - 1)
                {
                    dgvRepSales.Rows.Add("", "", "", "Итоги", itogQty, itogZsumm, itogRsumm, Math.Round((((itogRsumm / itogZsumm) - 1) * 100), 2), "", "", "", (itogSRMargin / dgvRepSales.Rows.Count));
                    return;
                }
            }

        }

        private void ReportSalesAll ()
        {
            
            dgvRepSales.Rows.Clear();
            dgvRepSales.Update();

            string periodN = func.replace_date_sql(Convert.ToString(dtpSalesN.Value));
            string periodE = func.replace_date_sql(Convert.ToString(dtpSalesE.Value.AddDays(1)));
            string QueryReportSales = "";
            string QueryDbase = "";

            if (cmbGruptSales.Text != "")
            {
                QueryReportSales = "Select kod,rcena,count,zcena from Sales where date >'" + periodN + "' and date <'" + periodE + "' order by kod";
                QueryDbase = "Select kod,name,(Select name from groupt where id= id_group) as groupt,quantity,zcena,rcena,(Select name from suppliers where id= id_suppliers) as sup from dbase where id_group="+ cmbGruptSales.SelectedValue +" order by kod";
            }
            else
            {
                QueryReportSales = "Select kod,rcena,count,zcena from Sales where date >'" + periodN + "' and date <'" + periodE + "' order by kod";
                QueryDbase = "Select kod,name,(Select name from groupt where id= id_group) as groupt,quantity,zcena,rcena,(Select name from suppliers where id= id_suppliers) as sup from dbase order by kod";
            }
            DataTable ReportSalesTable = _SQl.ExecuteSQL(QueryReportSales);
            DataTable QueryDbaseTable = _SQl.ExecuteSQL(QueryDbase);

            double coutnsrednee = 0;
            double summZsrednee = 0;
            double summRsrednee = 0;

            

            for (int l = 0; l < QueryDbaseTable.Rows.Count; l++)
            {
                
               
                string kod = QueryDbaseTable.Rows[l][0].ToString();
                string namet = QueryDbaseTable.Rows[l][1].ToString();
                string groupt = QueryDbaseTable.Rows[l][2].ToString();
                double zcenanow = Convert.ToDouble(QueryDbaseTable.Rows[l][4].ToString());
                double rcenanow = Convert.ToDouble(QueryDbaseTable.Rows[l][5].ToString());
                double ostatok = Convert.ToDouble(QueryDbaseTable.Rows[l][3].ToString());
                string suppliers = QueryDbaseTable.Rows[l][6].ToString();

                CallBackMy.callbackEventHandlerProgressBar(QueryDbaseTable.Rows.Count, l, namet);
                

                for (int irow = 0; irow < ReportSalesTable.Rows.Count; irow++)
                {
                    if (kod == ReportSalesTable.Rows[irow][0].ToString())
                    {
                        coutnsrednee = coutnsrednee + Convert.ToDouble(ReportSalesTable.Rows[irow][2].ToString());
                        summZsrednee = summZsrednee + (Convert.ToDouble(ReportSalesTable.Rows[irow][2].ToString()) * Convert.ToDouble(ReportSalesTable.Rows[irow][3].ToString()));
                        summRsrednee = summRsrednee + Math.Round((Convert.ToDouble(ReportSalesTable.Rows[irow][2].ToString()) * Convert.ToDouble(ReportSalesTable.Rows[irow][1].ToString())), 0);
                    }
                    if (irow == ReportSalesTable.Rows.Count - 1)
                    {
                        dgvRepSales.Rows.Add(kod, namet, zcenanow, rcenanow, coutnsrednee,ostatok, summZsrednee, Math.Round(summRsrednee, 0), Math.Round((((rcenanow / zcenanow) - 1) * 100), 2), groupt, Math.Round(summZsrednee / coutnsrednee, 2), Math.Round(summRsrednee / coutnsrednee, 2), Math.Round(((((Math.Round((summRsrednee / coutnsrednee), 2) / Math.Round((summZsrednee / coutnsrednee), 2)) - 1)) * 100), 2),suppliers);
                        
                        coutnsrednee = 0;
                        summZsrednee = 0;
                        summRsrednee = 0;
                    }
                }

            }
            double itogZsumm = 0;
            double itogRsumm = 0;
            //double itogMargin = 0;
            double itogSRMargin = 0;
            double itogQty = 0;

            for (int irowItog = 0; irowItog < dgvRepSales.Rows.Count; irowItog++)
            {
                itogQty = itogQty + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[4].Value);
                itogZsumm = itogZsumm + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[6].Value);
                itogRsumm = itogRsumm + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[7].Value);
                //itogMargin = itogMargin + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[7].Value);
                itogSRMargin = itogSRMargin + Convert.ToDouble(dgvRepSales.Rows[irowItog].Cells[12].Value);

                if (irowItog == dgvRepSales.Rows.Count - 1)
                {
                    dgvRepSales.Rows.Add("", "", "", "Итоги", Math.Round(Convert.ToDouble(itogQty),3),"", Math.Round(Convert.ToDouble(itogZsumm),2), Math.Round(Convert.ToDouble(itogRsumm),2), Math.Round((((itogRsumm / itogZsumm) - 1) * 100), 2), "", "", "", (itogSRMargin / dgvRepSales.Rows.Count));
                    return;
                }
                dgvRepSales.Rows[irowItog].Cells["Ostatok"].Style.BackColor=Color.LightYellow;
                
            }
        }

        private void ReportSalesform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       
    }
}
