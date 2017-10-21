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
    public partial class FindTovarform : Form
    {
        sqldb _SQl = new sqldb();
        
        public string exitfrm = "";
        public FindTovarform()
        {
            InitializeComponent();
        }

        private void btnFindTovar_Click(object sender, EventArgs e)
        {
            
            dgvFindT.Rows.Clear();
            string QueryFind="";
            if (ckbOst.Checked == true)
            {
                QueryFind = "select kod,name,quantity,rcena,ean from dbase where quantity <> 0";
               
            }
            else
            {
                QueryFind = "select kod,name,quantity,rcena,ean from dbase";
                
            }

            DataTable Findtovartable = _SQl.ExecuteSQL(QueryFind);

            if (cmbFind.Text == "По Наименованию")
            {
                for (int i = 0; i < Findtovartable.Rows.Count; i++)
                {
                    int fstr = Findtovartable.Rows[i][1].ToString().ToLower().IndexOf(txtFindT.Text.ToLower());
                    if (fstr >= 0)
                    {
                        dgvFindT.Rows.Add(Findtovartable.Rows[i][0].ToString(), Findtovartable.Rows[i][1].ToString(), Findtovartable.Rows[i][2].ToString(), Findtovartable.Rows[i][3].ToString());
                       
                    }
                }

            }

            if (cmbFind.Text == "По Штрих коду")
            {
                for (int i = 0; i < Findtovartable.Rows.Count; i++)
                {
                    int fstr = Findtovartable.Rows[i][4].ToString().IndexOf(txtFindT.Text);
                    if (fstr >= 0)
                    {
                        dgvFindT.Rows.Add(Findtovartable.Rows[i][0].ToString(), Findtovartable.Rows[i][1].ToString(), Findtovartable.Rows[i][2].ToString(), Findtovartable.Rows[i][3].ToString());
                     
                    }
                }
                
            }

            if (cmbFind.Text == "По Цене")
            {
                for (int i = 0; i < Findtovartable.Rows.Count; i++)
                {
                    if (Findtovartable.Rows[i][3].ToString() == txtFindT.Text)
                    {
                        //int fstr = Findtovartable.Rows[i][3].ToString().IndexOf(txtFindT.Text, 0, txtFindT.Text.Length);
                       //
                            dgvFindT.Rows.Add(Findtovartable.Rows[i][0].ToString(), Findtovartable.Rows[i][1].ToString(), Findtovartable.Rows[i][2].ToString(), Findtovartable.Rows[i][3].ToString());
                        //}
                          
                    }
                }
    
            }

            if (cmbFind.Text == "По Коду")
            {
                for (int i = 0; i < Findtovartable.Rows.Count; i++)
                {
                    int fstr = Findtovartable.Rows[i][0].ToString().IndexOf(txtFindT.Text);
                    if (fstr >= 0)
                    {
                        dgvFindT.Rows.Add(Findtovartable.Rows[i][0].ToString(), Findtovartable.Rows[i][1].ToString(), Findtovartable.Rows[i][2].ToString(), Findtovartable.Rows[i][3].ToString());
                       
                    }
                }

            }

            if (dgvFindT.Rows.Count == 0)
            {
                MessageBox.Show("Соответствий не найдено!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            lblFindpos.Text = "Найдено " + dgvFindT.Rows.Count + " позиций";
            Findtovartable.Dispose();
        }

        private void dgvFindT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvFindT.RowCount > 0)
            {
                if (e.KeyChar == 32)
                {

                    int irow = dgvFindT.CurrentRow.Index;

                    switch (Sform.ownerFormName)
                    {
                        case "Pform":
                            CallBackMy.callbackEventHandlerPform(dgvFindT.Rows[irow].Cells[0].Value.ToString());
                            exitfrm = "func";
                            this.Close();
                            break;
                        case "Tform":
                            CallBackMy.callbackEventHandlerTform(dgvFindT.Rows[irow].Cells[0].Value.ToString());
                            this.Close();
                            break;
                        case "Pereocenkaform":
                            CallBackMy.callbackEventHandlerPereocenkaform(dgvFindT.Rows[irow].Cells[0].Value.ToString());
                            exitfrm = "func";
                            this.Close();
                            break;
                        case "Rform":
                            CallBackMy.callbackEventHandlerRform(dgvFindT.Rows[irow].Cells[0].Value.ToString());
                            this.Close();
                            break;
                        case "ReportMoveGoodsform":
                            CallBackMy.callbackEventHandlerReportMoveGoodsform(dgvFindT.Rows[irow].Cells[0].Value.ToString(), dgvFindT.Rows[irow].Cells[1].Value.ToString());
                            break;
                        default:
                            break;
                    }


                }
            }
        }

        private void FindTovarform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Owner;
            string namefrm= frm.Name;
            switch (namefrm)
            {
                case "Pform":
                    if (exitfrm == "func")
                    {
                        frm.Controls["groupBox2"].Controls["txtPkol"].Focus();
                        exitfrm = "";
                    }
                    else
                    {
                        frm.Controls["txtPshtovar"].Focus();
                    }
                    break;
                case "Tform":
                    frm.Controls["txtShtovar"].Focus();
                    break;
                case "Pereocenkaform":
                    if (exitfrm == "func")
                    {
                        frm.Controls["txtNewRcena"].Focus();
                        exitfrm = "";
                    }
                    else
                    {
                        frm.Controls["txtPereocshtovar"].Focus();
                    }
                    break;
                case "Rform":
                    frm.Controls["txtRshtovar"].Focus();
                    break;
                default:
                    break;
            }

            
        }

        private void FindTovarform_Load(object sender, EventArgs e)
        {
            this.Text = "Поиск товара - " + Owner.Text;
            cmbFind.Items.Add("По Наименованию");
            cmbFind.Items.Add("По Штрих коду");
            cmbFind.Items.Add("По Цене");
            cmbFind.Items.Add("По Коду");
            cmbFind.Text = "По Наименованию";
        }

        private void FindTovarform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
/// <summary>
/// Контекстное меню
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void tSMICopy_Click(object sender, EventArgs e)
        {
            DataObject dataObj = dgvFindT.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }

        private void tSMISelectALL_Click(object sender, EventArgs e)
        {
            dgvFindT.SelectAll();
        }

        private void tSMIRozn_Click(object sender, EventArgs e)
        {
            if (dgvFindT.Rows.Count > 0)
            {
                int ir = dgvFindT.CurrentRow.Index;
                if (ir != -1)
                {
                    string kod = dgvFindT.Rows[ir].Cells[0].Value.ToString();
                    string fullname = dgvFindT.Rows[ir].Cells[0].Value.ToString() + " -- " + dgvFindT.Rows[ir].Cells[1].Value.ToString();

                    for (int x = 0; x < this.OwnedForms.Length; x++)
                    {
                        if (this.OwnedForms[x].Name == "InfoPriceform")
                        {
                            this.OwnedForms[x].Close();
                            
                        }
                    }

                    // Запускаем форму если она не запущена
                    Sform.ownerFormName = "InfoPriceform";
                    Form InfoPriceform = new InfoPriceform(tSMIRozn.Text, kod, fullname);
                    InfoPriceform.StartPosition = FormStartPosition.CenterScreen;
                    //FindTovarform.WindowState = FormWindowState.Maximized;
                    //указываем владельца для формы
                    InfoPriceform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                    InfoPriceform.Show();
                }
            }
        }

        private void tSMIZakup_Click(object sender, EventArgs e)
        {
            if (dgvFindT.Rows.Count > 0)
            {
                int ir = dgvFindT.CurrentRow.Index;
                if (ir != -1)
                {
                    string kod = dgvFindT.Rows[ir].Cells[0].Value.ToString();
                    string fullname = dgvFindT.Rows[ir].Cells[0].Value.ToString() + " -- " + dgvFindT.Rows[ir].Cells[1].Value.ToString();

                    for (int x = 0; x < this.OwnedForms.Length; x++)
                    {
                        if (this.OwnedForms[x].Name == "InfoPriceform")
                        {
                            this.OwnedForms[x].Close();
                            
                        }
                    }

                    // Запускаем форму если она не запущена
                    Sform.ownerFormName = "InfoPriceform";
                    Form InfoPriceform = new InfoPriceform(tSMIZakup.Text, kod, fullname);
                    InfoPriceform.StartPosition = FormStartPosition.CenterScreen;
                    //FindTovarform.WindowState = FormWindowState.Maximized;
                    //указываем владельца для формы
                    InfoPriceform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                    InfoPriceform.Show();
                }
                
            }
        }

      


    }
}
