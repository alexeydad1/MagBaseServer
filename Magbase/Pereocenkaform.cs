using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MagbaseServer
{
    public partial class Pereocenkaform : Form
    {
        sqldb _SQl = new sqldb();
        Source _SRC = new Source();
        public DataTable FindshkTablePereoc = new DataTable();
        public DataTable FindKodTablePereoc = new DataTable();
        public string exitfrm = "";
        

        public Pereocenkaform()
        {
            CallBackMy.callbackEventHandlerPereocenkaform = new CallBackMy.callbackEventPereocenkaform(this.LoadPrihodkod);
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(EnterKeyWait);
        }

        private void EnterKeyWait(object sender, KeyEventArgs e)
        {
            // Если фокус в штрихкод то выполняе действия
            if (txtPereocshtovar.Focused == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPereocshtovar.Text == "")
                    {
                        txtPereocshtovar.Focus();
                        return;
                    }
                    Findshk();
                    txtPereocshtovar.Text = "";
                    
                }
            }
        }

        private void Findshk()
        {

            string SqlShkfindPer = "select Kod,Name,Rcena,Quantity from Dbase where EAN like'%" + txtPereocshtovar.Text + "%'";
            FindshkTablePereoc = _SQl.ExecuteSQL(SqlShkfindPer);

            if (FindshkTablePereoc.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPereocshtovar.Focus();
                return;
            }
            if (FindshkTablePereoc.Rows.Count > 1)
            {
                // проверяем не запущена ли форма 
                for (int x = 0; x < this.OwnedForms.Length; x++)
                {
                    if (this.OwnedForms[x].Name == "Viborform")
                    {
                        this.OwnedForms[x].Focus();
                        return;
                    }
                }

                // Запускаем форму если она не запущена

                Data.Tovartbl = FindshkTablePereoc;
                // сделать форму с выводом позиций на одном штрихкоде
                Sform.ownerFormName = "Pereocenkaform";
                Form Viborform = new Viborform();
                Viborform.StartPosition = FormStartPosition.CenterScreen;
                //указываем владельца для формы
                // Viborform.MdiParent = this.MdiParent; // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Viborform.Owner = this;
                Viborform.Show();
                txtPereocshtovar.Text = "";

                return;
            }

            lblKodtovara.Text = FindshkTablePereoc.Rows[0][0].ToString();
            lblnametovar.Text = FindshkTablePereoc.Rows[0][1].ToString();
            lblOldRcena.Text = FindshkTablePereoc.Rows[0][2].ToString();
            txtNewRcena.Focus();

        }

        private void LoadPrihodkod(string kodtovara)
        {
            string SqlKodfind = "select Kod,Name,Rcena,Quantity from Dbase where kod='" + kodtovara + "'";
            FindKodTablePereoc = _SQl.ExecuteSQL(SqlKodfind);

            if (FindKodTablePereoc.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPereocshtovar.Focus();
                return;
            }
            if (FindKodTablePereoc.Rows.Count > 1)
            {
                // сделать форму с выводом позиций на одном штрихкоде
                for (int i = 0; i < FindKodTablePereoc.Rows.Count; i++)
                {
                    MessageBox.Show(FindKodTablePereoc.Rows[i][0].ToString() + " " + FindKodTablePereoc.Rows[i][1].ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return;
            }
            lblKodtovara.Text = FindKodTablePereoc.Rows[0][0].ToString();
            lblnametovar.Text = FindKodTablePereoc.Rows[0][1].ToString();
            lblOldRcena.Text = FindKodTablePereoc.Rows[0][2].ToString();
            txtNewRcena.Focus();

        }

        private void txtPereockodtovar_TextChanged(object sender, EventArgs e)
        {
            txtPereockodtovar.Text = Regex.Replace(txtPereockodtovar.Text, "[^0-9]", string.Empty);
            if (txtPereockodtovar.TextLength == 6)
            {
                string kodtovara = _SRC.pref_kod()+txtPereockodtovar.Text;
                LoadPrihodkod(kodtovara);
                txtPereockodtovar.Text = "";
                txtNewRcena.Focus();
            }
        }

        private void btnAddTovar_Click(object sender, EventArgs e)
        {
            if (lblKodtovara.Text == "")
            {
                MessageBox.Show("Поле код товара Пустое!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPereocshtovar.Focus();
                return;
            }
            if (lblnametovar.Text == "")
            {
                MessageBox.Show("Поле Наименование товара Пустое!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPereocshtovar.Focus();
                return;
            }
            if (lblOldRcena.Text == "")
            {
                MessageBox.Show("Поле Старая цена Пустое!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPereocshtovar.Focus();
                return;
            }
            if (txtNewRcena.Text == "")
            {
                MessageBox.Show("Поле Новоя цена Пустое!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewRcena.Focus();
                return;
            }
            dgvPereoc.Rows.Add(lblKodtovara.Text, lblnametovar.Text, lblOldRcena.Text, txtNewRcena.Text);
            lbllinedok.Text = dgvPereoc.Rows.Count.ToString();

            lblKodtovara.Text="";
            lblnametovar.Text="";
            lblOldRcena.Text="";
            txtNewRcena.Text = "";
            txtPereocshtovar.Focus();
        }

        private void Pereocenkaform_Load(object sender, EventArgs e)
        {
            dgvPereoc.Columns.Add("kodT", "Код");
            dgvPereoc.Columns.Add("nameT", "Наименование");
            dgvPereoc.Columns.Add("oldRcena", "Старая цена");
            dgvPereoc.Columns.Add("newRcena", "Новая цена");

            dgvPereoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPereoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPereoc.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPereoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvPereoc.Columns[0].ReadOnly = true;
            dgvPereoc.Columns[1].ReadOnly = true;
            dgvPereoc.Columns[2].ReadOnly = true;
            dgvPereoc.Columns[3].ReadOnly = true;

        }

        private void btnDelPereoc_Click(object sender, EventArgs e)
        {
            int l = dgvPereoc.RowCount;
            if (l == 0)
            {
                MessageBox.Show("Переоценка пустая!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPereocshtovar.Focus();
                return;
            }
            int i = dgvPereoc.CurrentRow.Index;
            dgvPereoc.Rows.RemoveAt(i);
            lbllinedok.Text =dgvPereoc.Rows.Count.ToString();
            
        }

        private void bntSavePereocenka_Click(object sender, EventArgs e)
        {
            int l = dgvPereoc.RowCount;
            if (l == 0)
            {
                MessageBox.Show("Переоценка пустая!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPereocshtovar.Focus();
                return;
            }

            DialogResult savePereoc= MessageBox.Show("Сохранить Переоценку?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (savePereoc == DialogResult.No)
            {
                return;
            }
            else
            {
                string SQLqueryUpdateRcena = "";
                string SQLqueryPereocenka = "";
                for (int irow = 0; irow < dgvPereoc.Rows.Count; irow++)
                {
                    SQLqueryUpdateRcena = "Update dbase set rcena=" + dgvPereoc.Rows[irow].Cells["newRcena"].Value.ToString().Replace(',', '.') + " where kod='" + dgvPereoc.Rows[irow].Cells["kodT"].Value.ToString() + "'";
                    SQLqueryPereocenka = "insert into pereocenka (kod_dbase,oldrcena,newrcena,users_bd,date) values('" + dgvPereoc.Rows[irow].Cells["kodT"].Value.ToString() + "'," + dgvPereoc.Rows[irow].Cells["oldRcena"].Value.ToString().Replace(',', '.') + "," + dgvPereoc.Rows[irow].Cells["newRcena"].Value.ToString().Replace(',', '.') + "," + Sform.id_users + ",'" + DateTime.Now.ToString("u").Remove(19) + "')";
                    _SQl.SQL_Query(SQLqueryUpdateRcena);
                    _SQl.SQL_Query(SQLqueryPereocenka);
                }
                exitfrm = "func";
                this.Close();
            }
        }

        private void Pereocenkaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            


            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (exitfrm != "func")
                {
                    if (dgvPereoc.RowCount > 0)
                    {
                        MessageBox.Show("В документе Переоценка, есть не сохраненные позиции, сохраните Переоценку!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                        this.Focus();
                        Sform.frmNotNull = 1;
                        return;
                    }

                    DialogResult Close_form = MessageBox.Show("Вы действительно хотите закрыть окно ''Переоценка'' ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Close_form == DialogResult.No)
                    {
                        e.Cancel = true;

                        return;
                    }
                }
            }
        }

        private void Pereocenkaform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "FindTovarform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена

            // Запускаем форму если она не запущена
            Sform.ownerFormName = "Pereocenkaform";
            Form FindTovarform = new FindTovarform();
            FindTovarform.StartPosition = FormStartPosition.CenterScreen;
            //FindTovarform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            FindTovarform.Text = "Поиск товара - " + this.Text;
            FindTovarform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            FindTovarform.Show();
        }

        private void txtPereocshtovar_TextChanged(object sender, EventArgs e)
        {
            txtPereocshtovar.Text = Regex.Replace(txtPereocshtovar.Text, "[^0-9]", string.Empty);
        }

    

 



    }
}
