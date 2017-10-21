using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace MagbaseServer
{
    public partial class Pviewform : Form
    {
        sqldb _SQl = new sqldb();
      
      private int CountPage = 0;
      
      public DataTable dtZayava2 = new DataTable();

        public Pviewform()
        {
            InitializeComponent();

            
        }

        private void Pviewform_Load(object sender, EventArgs e)
        {

            dgvPview.Columns.Add("Kod", "Код");
            dgvPview.Columns.Add("Name", "Наименование");
            dgvPview.Columns.Add("Zcena", "Цена закупки");
            dgvPview.Columns.Add("Count", "Кол-во");
            dgvPview.Columns.Add("Zsumm", "Сумма закупки");
            dgvPview.Columns.Add("Rcena", "Розн. Цена");
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvPview.Columns.Add(chk);
            chk.HeaderText = "Печать";
            chk.Name = "Chek";

            dgvPview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells ;
            dgvPview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPview.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvPview.Columns[0].ReadOnly = true;
            dgvPview.Columns[1].ReadOnly = true;
            dgvPview.Columns[2].ReadOnly = true;
            dgvPview.Columns[3].ReadOnly = true;
            dgvPview.Columns[4].ReadOnly = true;
            dgvPview.Columns[5].ReadOnly = true;
            
            Load_nakladnay();
            CountPage = dgvPview.Rows.Count/24;
        }
        private void Load_nakladnay()
        {
            string QueryNakladnayLoad = "Select kod_dbase,(select name from dbase where kod=kod_dbase) as name,count,zcena,rcena,(select name from suppliers where id=id_suppliers) as sup,datedok,numberdock_sup from incoming where numberdock_mag='" + Data.numDocPrihodRashod + "' ";

            DataTable NakladnayTable = _SQl.ExecuteSQL(QueryNakladnayLoad);
            double summPrihod = 0;
            for (int i = 0; i < NakladnayTable.Rows.Count; i++)
            {
                dgvPview.Rows.Add(NakladnayTable.Rows[i][0].ToString(), NakladnayTable.Rows[i][1].ToString(), NakladnayTable.Rows[i][3].ToString(), NakladnayTable.Rows[i][2].ToString(), Math.Round((Convert.ToDouble(NakladnayTable.Rows[i][3].ToString()) * Convert.ToDouble(NakladnayTable.Rows[i][2].ToString())), 2), NakladnayTable.Rows[i][4].ToString());
                summPrihod = summPrihod + Convert.ToDouble(dgvPview.Rows[i].Cells[4].Value);
                //lblSummPrihod.Text = Convert.ToString(Convert.ToDouble(lblSummPrihod.Text) + Convert.ToDouble(dgvPview.Rows[i].Cells[4].Value));
                dgvPview.Rows[i].Cells["Chek"].Value = true;
            }
            //for (int i = 0; i < dgvPview.Rows.Count; i++)
            
            //{
            //    dgvPview.Rows[i].Cells["Chek"].Value = true;
            //}
            lblSummPrihod.Text = summPrihod.ToString();
            lbllinedok.Text = dgvPview.Rows.Count.ToString();
            cmbSup.Text = NakladnayTable.Rows[0][5].ToString();
            txtDokSup.Text = NakladnayTable.Rows[0][7].ToString();
            msktxtDateDok.Text = NakladnayTable.Rows[0][6].ToString();
            lblNumdokmag.Text = Data.numDocPrihodRashod;
            //for (int l = 0; l < dgvPview.Rows.Count; l++)
            //{
            //    lblSummPrihod.Text = Convert.ToString(Convert.ToDouble(lblSummPrihod.Text) + Convert.ToDouble(dgvPview.Rows[l].Cells[4].Value));
            //}

        }

        private void btnPrintCennik_Click(object sender, EventArgs e)
        {
            
            DataTable PviewPrint = new DataTable();
            PviewPrint.Columns.Add("0");
            PviewPrint.Columns.Add("1");
            PviewPrint.Columns.Add("2");
           
            
            for (int i = 0; i < dgvPview.RowCount; i++)
            {
                //object sss = dgvPview.Rows[i].Cells[6].Value;
                if ((bool)dgvPview.Rows[i].Cells["Chek"].EditedFormattedValue)
                {
                    PviewPrint.Rows.Add(dgvPview.Rows[i].Cells["Kod"].Value.ToString(), dgvPview.Rows[i].Cells["Name"].Value.ToString(), dgvPview.Rows[i].Cells["Rcena"].Value.ToString());
                }
            }
            if (PviewPrint != null)
            {
                var pHelper = new PrintHelper(PviewPrint);
                 pHelper.Print(this.Text);
               
            }
       


        }

   
        private void Pviewform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvPview_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ICell= e.ColumnIndex;
            if (ICell == 6)
            {
                for (int i = 0; i < dgvPview.Rows.Count; i++)
                {
                    if ((bool)dgvPview.Rows[i].Cells["Chek"].EditedFormattedValue)
                    {
                        dgvPview.Rows[i].Cells["Chek"].Value = false;
                    }
                    else
                    {
                        dgvPview.Rows[i].Cells["Chek"].Value = true;
                    }
                }
            }
        }

       
    }
}
