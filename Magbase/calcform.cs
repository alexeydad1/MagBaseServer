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
    public partial class calcform : Form
    {
        sqldb _SQl = new sqldb();
        Source _SRC = new Source();
        public calcform()
        {
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(F6KeyWait);
            this.KeyUp += new KeyEventHandler(F8KeyWait);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtnal.Text == "")
            {
                return;
            }
            double num;
            if (double.TryParse(txtnal.Text, out num))
            {
                if (Convert.ToDouble(lblSummShek.Text) <= Convert.ToDouble(txtnal.Text))
                {
                    lblsdacha.Text = Convert.ToString(Convert.ToDouble(txtnal.Text) - Convert.ToDouble(lblSummShek.Text));
                }
                else
                {
                    lblsdacha.Text = "0";
                    return;
                }
            }
            else
            {
                txtnal.Text = "0";
                return;
            }



            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Tform Calcfrm = (Tform)this.Owner;

            int l = Calcfrm.dGV.RowCount;
            if (l == 0)
            {
                MessageBox.Show("Чек пустой!","Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtnal.Focus();
                return;
            }

            string type_pay = "";
            if (chkbBeznal.Checked == true)
            {
                type_pay = "Б";
            }
            else 
            {
                type_pay = "Н";
            }
            this.Cursor = Cursors.WaitCursor;
            int cheknow = _SRC.chek();
            
            string[] ArrMinus = new string[Calcfrm.dGV.Rows.Count];
            int iArr=0;
            for (int i = 0; i < Calcfrm.dGV.Rows.Count; i++)
            {
                string Kod = Calcfrm.dGV.Rows[i].Cells[0].Value.ToString();
                string Name = Calcfrm.dGV.Rows[i].Cells[1].Value.ToString();
                double Rcena = Convert.ToDouble(Calcfrm.dGV.Rows[i].Cells[3].Value.ToString());
                double Count = Convert.ToDouble(Calcfrm.dGV.Rows[i].Cells[4].Value.ToString());
                double Summ = Convert.ToDouble(Calcfrm.dGV.Rows[i].Cells[5].Value.ToString());
                double Zcena = Convert.ToDouble(Calcfrm.dGV.Rows[i].Cells[2].Value.ToString());
                string kod_osn=Calcfrm.dGV.Rows[i].Cells[6].Value.ToString();
                double obem_sps=Convert.ToDouble(Calcfrm.dGV.Rows[i].Cells[7].Value.ToString());
                DateTime date1 = DateTime.Now;
                string datechek = date1.ToString("u").Remove(19);
                int chek = Convert.ToInt32(cheknow);
                //метод списания FIFO

                Calcfrm.Fifo(Kod, Count, Zcena, Rcena, chek, datechek,type_pay,kod_osn,obem_sps,Name);
                if (Calcfrm.FlagSaleMinus == 1)
                {
                    Calcfrm.FlagSaleMinus = 0;
                    ArrMinus[iArr]= Kod + " - " + Name;
                    iArr++;
                }
            }
            if (ArrMinus[0] != null)
            {
                string messminus = "Внимание продажа в минус: " + Environment.NewLine;
                for (int k = 0; k < iArr; k++)
                {
                    messminus += ArrMinus[k] + Environment.NewLine;
                }
                MessageBox.Show(messminus, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (type_pay == "Н")
            {
                _SQl.SQL_Query("update source set cash=((Select cash from source)+" + Convert.ToInt32(lblSummShek.Text) + ")");

            }
            
            if (Calcfrm.ckbPrintchek.Checked == true)
            {
                Calcfrm.PrintChek(cheknow.ToString());
            }
            while (Calcfrm.dGV.Rows.Count != 0)
            {
                Calcfrm.dGV.Rows.Remove(Calcfrm.dGV.Rows[Calcfrm.dGV.Rows.Count - 1]);
            }
            Calcfrm.lblSumChekTform.Text = "0";
                 
            this.Cursor = Cursors.Default;
            
            this.Close();
            Calcfrm.txtShtovar.Focus();
        }

        private void calcform_Load(object sender, EventArgs e)
        {
            Tform Calcfrm = (Tform)this.Owner;
            lblSummShek.Text= Calcfrm.lblSumChekTform.Text;
        }
        private void F6KeyWait(object sender, KeyEventArgs e)
        {

                if (e.KeyCode == Keys.F6)
                {
                    btnprobitfinal.PerformClick();

                }
   
        }
        private void F8KeyWait(object sender, KeyEventArgs e)
        {
            // Если фокус в штрихкод то выполняе действия
           
                if (e.KeyCode == Keys.F8)
                {
                    
                    if (chkbBeznal.Checked == true)
                    {
                        chkbBeznal.Checked = false;
                        chkbBeznal.ForeColor = Color.Red;
                        return;
                    }
                    chkbBeznal.Checked = true;
                    chkbBeznal.ForeColor = Color.Green;
                }
   
        }

        private void calcform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void chkbBeznal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbBeznal.Checked == true)
            {
                    chkbBeznal.ForeColor = Color.Green;
            }
            else
            {
                chkbBeznal.ForeColor = Color.Red;
            }
        }
    }
}
