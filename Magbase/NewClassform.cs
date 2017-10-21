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
    public partial class NewClassform : Form
    {
        sqldb _SQl = new sqldb();
        public NewClassform()
        {
            InitializeComponent();
        }

        private void NewClassform_Load(object sender, EventArgs e)
        {
            txtMinMargin.Text = "0";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
                Classform NewClassfrm = (Classform)this.Owner;

                DataTable DTnclass = _SQl.ExecuteSQL("SELECT max(id) FROM Classt");

           if (txtMinMargin.Text != "" && txtnameclass.Text != "")
           {
                if (DTnclass.Rows[0][0].ToString() == "")
                {
                    int id_classn = 1;
                    string txtQueryNewClassAdd = "INSERT INTO Classt VALUES('" + id_classn + "','" + txtnameclass.Text + "'," + txtMinMargin.Text.Replace(',', '.') + ")";
                    _SQl.SQL_Query(txtQueryNewClassAdd);

                }
                else
                {
                    int id_classn = Convert.ToInt32(DTnclass.Rows[0][0].ToString()) + 1;
                    string txtQueryNewClassAdd = "INSERT INTO Classt VALUES('" + id_classn + "','" + txtnameclass.Text + "'," + txtMinMargin.Text.Replace(',', '.') + ")";
                    _SQl.SQL_Query(txtQueryNewClassAdd);
                }
            }
            else
            {

                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
            
            NewClassfrm.load_class();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnameclass_TextChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Вы ввели неверный формат числа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMinMargin.Text = "0";
            }
        }

        private void NewClassform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
