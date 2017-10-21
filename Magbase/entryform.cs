using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;

namespace MagbaseServer
{
    public partial class entryform : Form
    {
        sqldb _SQl = new sqldb();
        public entryform()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void entryform_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string login=txtLog.Text;
            string pass=txtPass.Text;

            DataTable AccessTable = _SQl.ExecuteSQL("select pass,id_access,id from users where login='" + login + "'");
            if (AccessTable.Rows.Count != 0)
            {

                Sform.id_access = Convert.ToInt32(AccessTable.Rows[0][1].ToString());
                string pass_base = AccessTable.Rows[0][0].ToString();
                Sform entryfrm = (Sform)this.MdiParent;
                if (pass == pass_base)
                {
                    entryfrm.access_users(Sform.id_access);
                    entryfrm.Text = entryfrm.Text + " - " + login+ " - " +Sform.fullAdress;
                    Sform.user_bd = login;
                    Sform.id_users = Convert.ToInt32(AccessTable.Rows[0][2].ToString());
                    //entryfrm.timerChekConnect.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("Пароль введен не верно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Логин или пароль введен не верно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            
        }
      

    }
}
