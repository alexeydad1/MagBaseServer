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
    public partial class GurnalPereocenkiform : Form
    {
        sqldb _SQl = new sqldb();
        public GurnalPereocenkiform()
        {
            InitializeComponent();
        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == "Pereocenkaform")
                {
                    this.MdiParent.MdiChildren[x].Focus();
                    return;
                }

            }
            // Запускаем форму если она не запущена
            Form Pereocenkaform = new Pereocenkaform();
            Pereocenkaform.StartPosition = FormStartPosition.CenterScreen;
            Pereocenkaform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Pereocenkaform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Pereocenkaform.Show();
            CallBackMy.callbackEventHandlerFormOpen(Pereocenkaform);
        }

        private void GurnalPereocenkiform_Load(object sender, EventArgs e)
        {
           
            dgvGurPereocenka.Columns.Add("kodT", "Код");
            dgvGurPereocenka.Columns.Add("nameT", "Наименование");
            dgvGurPereocenka.Columns.Add("oldRcena", "Старая цена");
            dgvGurPereocenka.Columns.Add("newRcena", "Новая цена");
            dgvGurPereocenka.Columns.Add("DatePrihod", "Дата Переоценки");
            dgvGurPereocenka.Columns.Add("User_id", "Пользователь");
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvGurPereocenka.Columns.Add(chk);
            chk.HeaderText = "Выбор";
            chk.Name = "Chek";


            dgvGurPereocenka.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurPereocenka.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurPereocenka.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurPereocenka.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurPereocenka.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurPereocenka.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGurPereocenka.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGurPereocenka.Columns[0].ReadOnly = true;
            dgvGurPereocenka.Columns[1].ReadOnly = true;
            dgvGurPereocenka.Columns[2].ReadOnly = true;
            dgvGurPereocenka.Columns[3].ReadOnly = true;
            dgvGurPereocenka.Columns[4].ReadOnly = true;
            dgvGurPereocenka.Columns[5].ReadOnly = true;
            
            dtpPereocenka1.Value = dtpPereocenka1.Value.AddDays(-10);
            dtpPereocenka2.Value = dtpPereocenka2.Value.AddDays(10);
            string CreatTblPereocenka = "CREATE TABLE IF NOT EXISTS Pereocenka(id INTEGER PRIMARY KEY AUTOINCREMENT,kod_dbase TEXT,oldRcena REAL,newRcena REAL,date DATETIME,users_bd int)";
            _SQl.SQL_Query(CreatTblPereocenka);
        }

        private void btnPereocenki_Click(object sender, EventArgs e)
        {
            string SQLquerySelectPereocenki = "";
            DataTable PereocenkiTBL=new DataTable();
            string periodN = func.replace_date_sql(Convert.ToString(dtpPereocenka1.Value));
            string periodE = func.replace_date_sql(Convert.ToString(dtpPereocenka2.Value.AddDays(1)));

            dgvGurPereocenka.Rows.Clear();


            SQLquerySelectPereocenki = "select kod_dbase,(select name from dbase where kod=kod_dbase) as nameT,oldrcena,newrcena,date,(select login from users where id=users_bd) as users_bd from pereocenka where date >'" + periodN + "' and date <'" + periodE + "' order by date";
            PereocenkiTBL=_SQl.ExecuteSQL(SQLquerySelectPereocenki);
            for (int i = 0; i < PereocenkiTBL.Rows.Count; i++)
            {
                dgvGurPereocenka.Rows.Add(PereocenkiTBL.Rows[i][0].ToString(), PereocenkiTBL.Rows[i][1].ToString(), PereocenkiTBL.Rows[i][2].ToString(), PereocenkiTBL.Rows[i][3].ToString(), PereocenkiTBL.Rows[i][4].ToString(), PereocenkiTBL.Rows[i][5].ToString());
            }
        
        }

        private void GurnalPereocenkiform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            DataTable PereocenkaPrint = new DataTable();
            PereocenkaPrint.Columns.Add("0");
            PereocenkaPrint.Columns.Add("1");
            PereocenkaPrint.Columns.Add("2");
           
            
            for (int i = 0; i < dgvGurPereocenka.RowCount; i++)
            {
                object sss = dgvGurPereocenka.Rows[i].Cells[6].Value;
                if ((bool)dgvGurPereocenka.Rows[i].Cells["Chek"].EditedFormattedValue)
                {
                    PereocenkaPrint.Rows.Add(dgvGurPereocenka.Rows[i].Cells["kodT"].Value.ToString(), dgvGurPereocenka.Rows[i].Cells["nameT"].Value.ToString(), dgvGurPereocenka.Rows[i].Cells["newRcena"].Value.ToString());
                }
            }
            if (PereocenkaPrint != null)
            {
                var pHelper = new PrintHelper(PereocenkaPrint);
                 pHelper.Print(this.Text);
               
            }
        }



 

    }
}
