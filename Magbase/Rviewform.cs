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
    public partial class Rviewform : Form
    {
        sqldb _SQl = new sqldb();
        public Rviewform()
        {
            InitializeComponent();
        }

        private void Rviewform_Load(object sender, EventArgs e)
        {
            dgvRview.Columns.Add("Kod", "Код");
            dgvRview.Columns.Add("Name", "Наименование");
            dgvRview.Columns.Add("Zcena", "Цена закупки");
            dgvRview.Columns.Add("Count", "Кол-во");
            dgvRview.Columns.Add("Zsumm", "Сумма закупки");

            dgvRview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            

            dgvRview.Columns[0].ReadOnly = true;
            dgvRview.Columns[1].ReadOnly = true;
            dgvRview.Columns[2].ReadOnly = true;
            dgvRview.Columns[3].ReadOnly = true;
            dgvRview.Columns[4].ReadOnly = true;

            Load_nakladnayRV();
        }

        private void Load_nakladnayRV()
        {
            string QueryNakladnayRVLoad = "Select kod_dbase,(select name from dbase where kod=kod_dbase) as name,count,zcena,(select name from suppliers where id=id_suppliers) as sup,date_dock_sup,numberdock_sup from outgoing where numberdock_mag='" + Data.numDocPrihodRashod + "'";

            DataTable NakladnayTableRV = _SQl.ExecuteSQL(QueryNakladnayRVLoad);

            for (int i = 0; i < NakladnayTableRV.Rows.Count; i++)
            {
                dgvRview.Rows.Add(NakladnayTableRV.Rows[i][0].ToString(), NakladnayTableRV.Rows[i][1].ToString(), NakladnayTableRV.Rows[i][3].ToString(), NakladnayTableRV.Rows[i][2].ToString(),Math.Round((Convert.ToDouble(NakladnayTableRV.Rows[i][3].ToString()) * Convert.ToDouble(NakladnayTableRV.Rows[i][2].ToString())),2));
            }
            lbllinedokRV.Text = Convert.ToString(dgvRview.Rows.Count);
            cmbRVSup.Text = NakladnayTableRV.Rows[0][4].ToString();
            txtDokSupRV.Text = NakladnayTableRV.Rows[0][6].ToString();
            msktxtDateDokRV.Text = NakladnayTableRV.Rows[0][5].ToString();
            lblNumdokmagRV.Text = Data.numDocPrihodRashod;
            for (int l = 0; l < dgvRview.Rows.Count; l++)
            {
                lblSummPrihodRV.Text = Convert.ToString(Convert.ToDouble(lblSummPrihodRV.Text) + Convert.ToDouble(dgvRview.Rows[l].Cells[4].Value));
            }
        }

        private void Rviewform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
