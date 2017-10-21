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
    public partial class Cash : Form
    {
        sqldb _SQl = new sqldb();

        public Cash()
        {
            InitializeComponent();
        }

        private void btnInsertCash_Click(object sender, EventArgs e)
        {
            if (txtCash.Text != "" && rtxtcoment.Text != "")
            {
                DateTime date = DateTime.Now;
                string datecash = date.ToString("u").Remove(19);
                string SQLQueryCashInsert = "insert into Cash(type,cashsum,date,comment,users_bd) values('Внесение'," + Convert.ToInt32(txtCash.Text) + ",'" + datecash + "','" + rtxtcoment.Text + "'," + Sform.id_users + ")";
                _SQl.SQL_Query(SQLQueryCashInsert);
                _SQl.SQL_Query("update source set cash=((Select cash from source)+" + Convert.ToInt32(txtCash.Text) + ")");
                load_cash();
            }
            else
            {
                MessageBox.Show("Заполните поля ''Сумма'' и ''Комментарий'' !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                        e.Handled = true;  

        }

        private void Cash_Load(object sender, EventArgs e)
        {
            load_cash();
        }
        private void load_cash()
        {
            string SQLQueryCash = "select cash from source";
            DataTable cash = _SQl.ExecuteSQL(SQLQueryCash);
            lblCash.Text = cash.Rows[0][0].ToString();

            string SQLQueryCashTable = "select type,cashsum,date,comment,(select login from users where id=users_bd) from cash order by date DESC";
            DataTable cashtable = _SQl.ExecuteSQL(SQLQueryCashTable);
            dgvCash.Rows.Clear();
            for (int i = 0; i < cashtable.Rows.Count; i++)
            {
                dgvCash.Rows.Add(cashtable.Rows[i][0].ToString(),Convert.ToInt32( cashtable.Rows[i][1].ToString()),cashtable.Rows[i][2].ToString(),cashtable.Rows[i][3].ToString(),cashtable.Rows[i][4].ToString());
            }
                
        }

        private void btnEncashment_Click(object sender, EventArgs e)
        {
            if (txtCash.Text != "" && rtxtcoment.Text != "")
            {
                DateTime date = DateTime.Now;
                string datecash = date.ToString("u").Remove(19);
                string SQLQueryCashInsert = "insert into Cash(type,cashsum,date,comment,users_bd) values('Инкассация'," + Convert.ToInt32(txtCash.Text) + ",'" + datecash + "','" + rtxtcoment.Text + "'," + Sform.id_users + ")";
                _SQl.SQL_Query(SQLQueryCashInsert);
                _SQl.SQL_Query("update source set cash=((Select cash from source)-" + Convert.ToInt32(txtCash.Text) + ")");
                load_cash();
            }
            else
            {
                MessageBox.Show("Заполните поля ''Сумма'' и ''Комментарий'' !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void Cash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            }
        }
        
    }
}
