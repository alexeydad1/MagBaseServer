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
    public partial class Viborform : Form
    {
       
       
        public Viborform()
        {
     
            InitializeComponent();
        }

        private void Viborform_Load(object sender, EventArgs e)
        {
           
            dgvvibor.Columns.Add("Kod", "Код");
            dgvvibor.Columns.Add("Name", "Наименование");
            dgvvibor.Columns.Add("Rcena", "Цена");
            dgvvibor.Columns.Add("Qty", "Остаток");
            dgvvibor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvvibor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvvibor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvvibor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            

            dgvvibor.Columns[0].ReadOnly = true;
            dgvvibor.Columns[1].ReadOnly = true;
            dgvvibor.Columns[2].ReadOnly = true;
            dgvvibor.Columns[3].ReadOnly = true;

            string ColumName = "";

            if (Sform.ownerFormName == "Rform")
            {
                ColumName = "Zcena";
            }
            else
            {
                ColumName = "Rcena";
            }
            
           for (int i = 0; i < Data.Tovartbl.Rows.Count; i++)
            {
                string kod = Data.Tovartbl.Rows[i]["Kod"].ToString();
                string name = Data.Tovartbl.Rows[i]["Name"].ToString();
                string rcena = Data.Tovartbl.Rows[i][ColumName].ToString();
                string ostatok = Data.Tovartbl.Rows[i]["Quantity"].ToString();
                dgvvibor.Rows.Add(kod, name, rcena, ostatok);
            }
            lblFindpos.Text = "Найдено " + dgvvibor.Rows.Count + " позиций";
        }

        private void dgvvibor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==32)
            {
                
                int i = dgvvibor.CurrentRow.Index;
                switch(Sform.ownerFormName)
                {
                    case"Pform":
                        CallBackMy.callbackEventHandlerPform(dgvvibor.Rows[i].Cells["Kod"].Value.ToString());
                        break;
                    case "Tform":
                        CallBackMy.callbackEventHandlerTform(dgvvibor.Rows[i].Cells["Kod"].Value.ToString());
                        break;
                    case "Pereocenkaform":
                        CallBackMy.callbackEventHandlerPereocenkaform(dgvvibor.Rows[i].Cells["Kod"].Value.ToString());
                        break;
                    case "Rform":
                        CallBackMy.callbackEventHandlerRform(dgvvibor.Rows[i].Cells["Kod"].Value.ToString());
                        break;
                    default:
                        break;
                }
               
                
                this.Close();
               
            }
        }

        private void Viborform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
       

    }
}
