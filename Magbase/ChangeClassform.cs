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
    public partial class ChangeClassform : Form
    {
        sqldb _SQl = new sqldb();
       
        public ChangeClassform()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Classform ChangeClassfrm = (Classform)this.Owner;
            string id = Convert.ToString(ChangeClassfrm.dgvclass.Rows[ChangeClassfrm.dgvclass.CurrentRow.Index].Cells["id"].Value);

            if (txtMinMargin.Text != "" && txtnameclass.Text != "")
            {
                string txtQueryChangeClass = "UPDATE ClassT SET name='" + txtnameclass.Text + "',margin_class=" + txtMinMargin.Text.Replace(',', '.') + " WHERE id='" + id + "'";
                _SQl.SQL_Query(txtQueryChangeClass);
            }
            else
            {
                MessageBox.Show("Заполните все поля!","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();

            ChangeClassfrm.load_class();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeClassform_Load(object sender, EventArgs e)
        {
            Classform ChangeClassfrm = (Classform)this.Owner;
            txtnameclass.Text = Convert.ToString(ChangeClassfrm.dgvclass.Rows[ChangeClassfrm.dgvclass.CurrentRow.Index].Cells["name"].Value);
            txtMinMargin.Text = Convert.ToString(ChangeClassfrm.dgvclass.Rows[ChangeClassfrm.dgvclass.CurrentRow.Index].Cells["margin_class"].Value);
        }

        private void txtMinMargin_TextChanged(object sender, EventArgs e)
        {
            if (txtMinMargin.Text == "")
            {
                return;
            }

            double num;
            if (double.TryParse(txtMinMargin.Text, out num))
            {
            }
            else
            {
                MessageBox.Show("Вы ввели неверный формат числа!","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinMargin.Text = "0";
            }
        }

        private void ChangeClassform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
