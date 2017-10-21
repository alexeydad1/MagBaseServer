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
    public partial class Usersform : Form
    {
        sqldb _SQl = new sqldb();
        public Usersform()
        {
            InitializeComponent();
        }
        public void load_users_form()
        {

            DataTable Userstable = _SQl.ExecuteSQL("select id,login,(select LevelUsers from Access_bd where id=id_access) from users order by login");
            dgvUsers.DataSource = Userstable;

            dgvUsers.Columns[0].HeaderCell.Value = "Id";
            dgvUsers.Columns[1].HeaderCell.Value = "Пользователь";
            dgvUsers.Columns[2].HeaderCell.Value = "Уровень доступа";

            dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           
           
            dgvUsers.Columns[0].ReadOnly = true;
            dgvUsers.Columns[1].ReadOnly = true;
            dgvUsers.Columns[2].ReadOnly = true;
        
          
        }

        private void Usersform_Load(object sender, EventArgs e)
        {
            load_users_form();
        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "NewUser")
                {
                    this.OwnedForms[x].Text = "Новый пользователь";
                    this.OwnedForms[x].ShowDialog();
                    return;
                }
            }

            // Запускаем форму если она не запущена

            Form NewUser = new NewUser();
            NewUser.StartPosition = FormStartPosition.CenterScreen;
            //NewSupform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            NewUser.Text = "Новый пользователь";
            NewUser.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            NewUser.ShowDialog(); 
        }

        private void Usersform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tsbtnchange_Click(object sender, EventArgs e)
        {
            if (dgvUsers.RowCount > 0)
            {
                int iduser = dgvUsers.CurrentRow.Index;
                if (iduser != -1)
                {
                    //// проверяем не запущена ли форма 
                    for (int x = 0; x < this.OwnedForms.Length; x++)
                    {
                        if (this.OwnedForms[x].Name == "NewUser")
                        {
                            this.OwnedForms[x].Text = "Редактирование пользователя";
                            Data.idUser = Convert.ToInt32(dgvUsers.Rows[iduser].Cells[0].Value.ToString());
                            Data.RowidUser = iduser;
                            this.OwnedForms[x].ShowDialog();
                            return;
                        }
                    }

                    // Запускаем форму если она не запущена

                    Data.idUser = Convert.ToInt32(dgvUsers.Rows[iduser].Cells[0].Value.ToString());
                    Data.RowidUser = iduser;
                    Form NewUser = new NewUser();
                    NewUser.StartPosition = FormStartPosition.CenterScreen;
                    //NewSupform.WindowState = FormWindowState.Maximized;
                    //указываем владельца для формы
                    NewUser.Text = "Редактирование пользователя";
                    NewUser.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                    NewUser.ShowDialog(); 
                    
                }
            }
        }
    }
}
