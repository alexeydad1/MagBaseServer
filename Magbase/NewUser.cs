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
    public partial class NewUser : Form
    {
        sqldb _SQl = new sqldb();
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text=="")
            {
                MessageBox.Show("Поле ''Пользователь/логин'' пустое","Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }
            if(txtPass.Text=="")
            {
                MessageBox.Show("Поле ''Пароль'' пустое", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            if(txtPass2.Text=="")
            {
                MessageBox.Show("Поле ''Подтвердите пароль'' пустое", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass2.Focus();
                return;
            }
            if (cmbaccess.Text == "")
            {
                MessageBox.Show("Поле ''Уровень доступа'' пустое", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbaccess.Focus();
                return;
            }
            if (lblcomp.Text == "!")
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            if (lbllog.Text == "!")
            {
                MessageBox.Show("Такой пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }

            if (this.Text == "Редактирование пользователя")
            {
                _SQl.SQL_Query("update users set login='" + txtLogin.Text + "',pass='" + txtPass.Text + "',id_access=" + cmbaccess.SelectedValue + " where id="+ Data.idUser +"");
            }
            else
            {

                _SQl.SQL_Query("insert into users (login,pass,id_access) values('" + txtLogin.Text + "','" + txtPass.Text + "'," + cmbaccess.SelectedValue + ") ");
            }
            Usersform Newuserfrm = (Usersform)this.Owner;
            Newuserfrm.load_users_form();
            this.Close();
            
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            cmb_load();
            if (this.Text == "Редактирование пользователя")
            {
                DataTable Userschange = _SQl.ExecuteSQL("select id,login,pass,id_access from users where id="+ Data.idUser +"");
                txtLogin.Text = Userschange.Rows[0][1].ToString();
                txtPass.Text = Userschange.Rows[0][2].ToString();
                txtPass2.Text = Userschange.Rows[0][2].ToString();
                cmbaccess.SelectedValue = Userschange.Rows[0][3].ToString();
          
            }
        }
        private void cmb_load()
        {
            DataTable UserAccessTBL = _SQl.ExecuteSQL("select * from access_bd");
            cmbaccess.DataSource = UserAccessTBL;

            cmbaccess.DisplayMember = "LevelUsers";
            cmbaccess.ValueMember = "id";
            cmbaccess.Text = "";
            
        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPass2.Text)
            {
                lblcomp.Text = "Ok";
                lblcomp.ForeColor = Color.Green;

            }
            else
            {
                lblcomp.Text = "!";
                lblcomp.ForeColor = Color.Red;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPass2.Text)
            {
                lblcomp.Text = "Ok";
                lblcomp.ForeColor = Color.Green;

            }
            else
            {
                lblcomp.Text = "!";
                lblcomp.ForeColor = Color.Red;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            string login;
            if (txtLogin.Text.Length > 3)
            {
                Usersform Newuserfrm = (Usersform)this.Owner;
                
                    for(int i=0;i<Newuserfrm.dgvUsers.Rows.Count;i++)
                    {
                        
                            login = Newuserfrm.dgvUsers.Rows[i].Cells["login"].Value.ToString();
                            if (txtLogin.Text != login)
                            {
                                lbllog.Text = "Ok";
                                lbllog.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (Data.RowidUser == i)
                                {
                                    lbllog.Text = "Ok";
                                    lbllog.ForeColor = Color.Green;
                                }
                                else
                                {
                                    lbllog.Text = "!";
                                    lbllog.ForeColor = Color.Red;
                                    return;
                                }
                               
                            }
                        
                    }
            }
        }

        private void NewUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
