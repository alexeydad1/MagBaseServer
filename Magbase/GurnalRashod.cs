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
    public partial class GurnalRashod : Form
    {
        sqldb _SQl = new sqldb();
        private void load_cmb()
        {
            cmbsup.DisplayMember = "name";
            cmbsup.ValueMember = "id";
            cmbsup.DataSource = _SQl.ExecuteSQL("SELECT * FROM Suppliers order by name");
            cmbsup.SelectedValue=0;
        }

        public GurnalRashod()
        {
            InitializeComponent();
        }

        private void GurnalRashod_Load(object sender, EventArgs e)
        {
            dgvGurRash.Columns.Add("NumDockMag", "Номер документа");
            dgvGurRash.Columns.Add("Sup", "Поставщик");
            dgvGurRash.Columns.Add("DateRashod", "Дата расхода");
            dgvGurRash.Columns.Add("Zsumm", "Сумма документа");
            dgvGurRash.Columns.Add("NumDockMagSup", "№ документа поставщика");
            dgvGurRash.Columns.Add("Users_id", "Пользователь");

            dgvGurRash.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurRash.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurRash.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurRash.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurRash.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurRash.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

            dgvGurRash.Columns[0].ReadOnly = true;
            dgvGurRash.Columns[1].ReadOnly = true;
            dgvGurRash.Columns[2].ReadOnly = true;
            dgvGurRash.Columns[3].ReadOnly = true;
            dgvGurRash.Columns[4].ReadOnly = true;
            dgvGurRash.Columns[5].ReadOnly = true;
          

            dtpRash1.Value = dtpRash1.Value.AddDays(-10);
            dtpRash2.Value = dtpRash2.Value.AddDays(10);

            load_cmb();
        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == "Rform")
                {
                    this.MdiParent.MdiChildren[x].Focus();
                    return;
                }

            }
            // Запускаем форму если она не запущена
            Form Rform = new Rform();
            Rform.StartPosition = FormStartPosition.CenterScreen;
            Rform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Rform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Rform.Show();
            CallBackMy.callbackEventHandlerFormOpen(Rform);
        }

        private void btnprihod_Click(object sender, EventArgs e)
        {
            string periodN = func.replace_date_sql(Convert.ToString(dtpRash1.Value));
            string periodE = func.replace_date_sql(Convert.ToString(dtpRash2.Value.AddDays(1)));


            dgvGurRash.Rows.Clear();
            lblSummR.Text = "0";
            string QueryRashodLoad = "";
            if (cmbsup.Text != "")
            {
                QueryRashodLoad = "SELECT numberdock_mag,(Select suppliers.name from suppliers where suppliers.id=id_suppliers) as suppliers,date,count,zcena,numberdock_sup,(Select users.login from users where users.id=users_bd) as users FROM outgoing where date >'" + periodN + "' and date<'" + periodE + "' and id_suppliers=" + cmbsup.SelectedValue + " order by numberdock_mag";
            }
            else
            {
                QueryRashodLoad = "SELECT numberdock_mag,(Select suppliers.name from suppliers where suppliers.id=id_suppliers) as suppliers,date,count,zcena,numberdock_sup,(Select users.login from users where users.id=users_bd) as users FROM outgoing where date >'" + periodN + "' and date <'" + periodE + "' order by numberdock_mag";
            }

            DataTable GurnalRashodtable = _SQl.ExecuteSQL(QueryRashodLoad);
            int flag = 0;
            double sum_prih_all = 0;
            for (int i = 0; i < GurnalRashodtable.Rows.Count; i++)
            {
                for (int l = 0; l < GurnalRashodtable.Rows.Count; l++)
                {

                    for (int gur = 0; gur < dgvGurRash.Rows.Count; gur++)
                    {
                        if (GurnalRashodtable.Rows[i][0].ToString() == dgvGurRash.Rows[gur].Cells["NumDockMag"].Value.ToString())
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

                    if (GurnalRashodtable.Rows[i][0].ToString() == GurnalRashodtable.Rows[l][0].ToString())
                    {
                        sum_prih_all = sum_prih_all + (Math.Round(Convert.ToDouble(GurnalRashodtable.Rows[l][3].ToString()) * Convert.ToDouble(GurnalRashodtable.Rows[l][4].ToString()),2));
                    }
                    if (l == GurnalRashodtable.Rows.Count - 1)
                    {
                        dgvGurRash.Rows.Add(GurnalRashodtable.Rows[i][0].ToString(), GurnalRashodtable.Rows[i][1].ToString(), GurnalRashodtable.Rows[i][2].ToString(), sum_prih_all, GurnalRashodtable.Rows[i][5].ToString(),GurnalRashodtable.Rows[i][6].ToString());
                        sum_prih_all = 0;
                    }


                }

            }
            for (int sumnak = 0; sumnak < dgvGurRash.Rows.Count; sumnak++)
            {
                lblSummR.Text= Convert.ToString(Math.Round((Convert.ToDouble(lblSummR.Text) + Convert.ToDouble(dgvGurRash.Rows[sumnak].Cells[3].Value)),2));
            }

        }

        private void tsbVievRV_Click(object sender, EventArgs e)
        {
            if (dgvGurRash.Rows.Count > 0)
            {
                int idrow = dgvGurRash.CurrentRow.Index;
                Data.numDocPrihodRashod = dgvGurRash.Rows[idrow].Cells[0].Value.ToString();
            }
            else
            {
                return;
            }

            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == "Rviewform")
                {
                    this.MdiParent.MdiChildren[x].Focus();
                    return;
                }

            }
            // Запускаем форму если она не запущена
            Form Rviewform = new Rviewform();
            Rviewform.StartPosition = FormStartPosition.CenterScreen;
            Rviewform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Rviewform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Rviewform.Show();
        }

        private void GurnalRashod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvGurRash_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvGurRash.Rows.Count > 0)
            {
                int idrow = e.RowIndex;
                Data.numDocPrihodRashod = dgvGurRash.Rows[idrow].Cells[0].Value.ToString();
            }
            else
            {
                return;
            }

            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == "Rviewform")
                {
                    this.MdiParent.MdiChildren[x].Focus();
                    return;
                }

            }
            // Запускаем форму если она не запущена
            Form Rviewform = new Rviewform();
            Rviewform.StartPosition = FormStartPosition.CenterScreen;
            Rviewform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Rviewform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Rviewform.Show();
        }
    }
}
