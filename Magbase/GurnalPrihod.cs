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
    public partial class GurnalPrihod : Form
    {
        sqldb _SQl = new sqldb();
        static public string numbdokmag = "";       
        private void load_cmb()
        {
            cmbsup.DisplayMember = "name";
            cmbsup.ValueMember = "id";
            cmbsup.DataSource = _SQl.ExecuteSQL("SELECT * FROM Suppliers order by name");
            cmbsup.SelectedValue=0;
        }


        public GurnalPrihod()
        {
            InitializeComponent();
        }

        private void GurnalPrihod_Load(object sender, EventArgs e)
        {
            dgvGurPrih.Columns.Add("NumDockMag", "Номер документа");
            dgvGurPrih.Columns.Add("Sup", "Поставщик");
            dgvGurPrih.Columns.Add("DatePrihod", "Дата прихода");
            dgvGurPrih.Columns.Add("DateDock", "Дата документа");
            dgvGurPrih.Columns.Add("Zsumm", "Сумма документа");
            dgvGurPrih.Columns.Add("NumDockSup", "Номер документа поставщика");
            dgvGurPrih.Columns.Add("User_id", "Пользователь");
            
            dgvGurPrih.Columns[0].ReadOnly = true;
            dgvGurPrih.Columns[1].ReadOnly = true;
            dgvGurPrih.Columns[2].ReadOnly = true;
            dgvGurPrih.Columns[3].ReadOnly = true;
            dgvGurPrih.Columns[4].ReadOnly = true;
            dgvGurPrih.Columns[5].ReadOnly = true;
            dgvGurPrih.Columns[6].ReadOnly = true;
            dtpPrih1.Value = dtpPrih1.Value.AddDays(-10);
            dtpPrih2.Value = dtpPrih2.Value.AddDays(10);

            load_cmb();

        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == "Pform")
                {
                    this.MdiParent.MdiChildren[x].Focus();
                    return;
                }

            }
            // Запускаем форму если она не запущена
            Form Pform = new Pform();
            Pform.StartPosition = FormStartPosition.CenterScreen;
            Pform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Pform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Pform.Show();
            CallBackMy.callbackEventHandlerFormOpen(Pform);
           
            
        }

        private void btnprihod_Click(object sender, EventArgs e)
        {

            string periodN =  func.replace_date_sql(Convert.ToString(dtpPrih1.Value));
            string periodE = func.replace_date_sql(Convert.ToString(dtpPrih2.Value.AddDays(1)));

            
            dgvGurPrih.Rows.Clear();
            lblSummP.Text = "0";
            string QueryPrihodLoad="";
            if (cmbsup.Text != "")
            {
                QueryPrihodLoad = "SELECT numberdock_mag,(Select suppliers.name from suppliers where suppliers.id=id_suppliers) as suppliers,date,datedok,count,zcena,numberdock_sup,(Select users.login from users where users.id=users_bd) as users FROM incoming where date >'" + periodN + "' and date<'" + periodE + "' and id_suppliers=" + cmbsup.SelectedValue + " order by numberdock_mag";
            }
            else 
            {
                QueryPrihodLoad = "SELECT numberdock_mag,(Select suppliers.name from suppliers where suppliers.id=id_suppliers) as suppliers,date,datedok,count,zcena,numberdock_sup,(Select users.login from users where users.id=users_bd) as users FROM incoming where date >'" + periodN + "' and date <'" + periodE + "' order by numberdock_mag";
            }
          
            DataTable GurnalPrihod = _SQl.ExecuteSQL(QueryPrihodLoad);
            int flag = 0;
            double sum_prih_all = 0;
            for (int i = 0; i < GurnalPrihod.Rows.Count; i++)
            {
                for (int l = 0; l < GurnalPrihod.Rows.Count; l++)
                {
                    
                    for (int gur = 0; gur < dgvGurPrih.Rows.Count; gur++)
                    {
                        if (GurnalPrihod.Rows[i][0].ToString() == dgvGurPrih.Rows[gur].Cells["NumDockMag"].Value.ToString())
                        {
                            flag = 1;
                            break;
                        }
                    }
                        if (flag == 1)
                        {
                            flag = 0;
                            break;
                        }

                        if(GurnalPrihod.Rows[i][0].ToString() == GurnalPrihod.Rows[l][0].ToString())
                        {
                            sum_prih_all = sum_prih_all + (Math.Round(Convert.ToDouble(GurnalPrihod.Rows[l][4].ToString()) * Convert.ToDouble(GurnalPrihod.Rows[l][5].ToString()),2));
                        }
                        if (l == GurnalPrihod.Rows.Count-1)
                        {
                            
                            dgvGurPrih.Rows.Add(GurnalPrihod.Rows[i][0].ToString(), GurnalPrihod.Rows[i][1].ToString(), GurnalPrihod.Rows[i][2].ToString(), GurnalPrihod.Rows[i][3].ToString(), sum_prih_all, GurnalPrihod.Rows[i][6].ToString(), GurnalPrihod.Rows[i][7].ToString());
                           
                            sum_prih_all = 0;
                        }
                    

                }

            }
            for (int sumnak = 0; sumnak < dgvGurPrih.Rows.Count; sumnak++)
            {
                lblSummP.Text = Convert.ToString(Math.Round((Convert.ToDouble(lblSummP.Text) + Convert.ToDouble(dgvGurPrih.Rows[sumnak].Cells[4].Value)),2));
            }
            
        }

        private void tsbtnview_Click(object sender, EventArgs e)
        {
            if (dgvGurPrih.Rows.Count > 0)
            {
                int idrow = dgvGurPrih.CurrentRow.Index;
                Data.numDocPrihodRashod = dgvGurPrih.Rows[idrow].Cells[0].Value.ToString();
            }
            else 
            {
                return;
            }
           
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == "Pviewform")
                {
                    this.MdiParent.MdiChildren[x].Focus();
                    return;
                }

            }
            // Запускаем форму если она не запущена
            Form Pviewform = new Pviewform();
            Pviewform.StartPosition = FormStartPosition.CenterScreen;
            Pviewform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Pviewform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Pviewform.Show();
            
        }

        private void GurnalPrihod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvGurPrih_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvGurPrih.Rows.Count > 0)
            {
                int idrow = e.RowIndex;
                if (idrow != -1)
                {
                    Data.numDocPrihodRashod = dgvGurPrih.Rows[idrow].Cells[0].Value.ToString();
                }
            }
            else
            {
                return;
            }

            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == "Pviewform")
                {
                    this.MdiParent.MdiChildren[x].Focus();
                    return;
                }

            }
            // Запускаем форму если она не запущена
            Form Pviewform = new Pviewform();
            Pviewform.StartPosition = FormStartPosition.CenterScreen;
            Pviewform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Pviewform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Pviewform.Show();

        }


    }
}

 