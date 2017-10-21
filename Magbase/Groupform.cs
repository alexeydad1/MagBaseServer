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
    public partial class Groupform : Form
    {
        sqldb _SQl = new sqldb();

        public void load_group()
        {
            
            DataTable DTgroup = _SQl.ExecuteSQL("select id,Name from groupt order by name");
            dgvgroup.DataSource = DTgroup;

            dgvgroup.Columns[0].HeaderCell.Value = "ID";
            dgvgroup.Columns[1].HeaderCell.Value = "Название";
            dgvgroup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvgroup.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvgroup.Columns[0].ReadOnly = true;
            dgvgroup.Columns[1].ReadOnly = true;

        }

        public Groupform()
        {
            InitializeComponent();
            load_group();
        }

        private void Groupform_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "NewGroupform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form NewGroupform = new NewGroupform();
            NewGroupform.StartPosition = FormStartPosition.CenterScreen;
            //указываем владельца для формы
            NewGroupform.Owner = this;// где containerInstance - это экземпляр контейнера или указатель на MainForm
            NewGroupform.Show();
        }

        private void tsbtnchange_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "ChangeGroupform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form ChangeGroupform = new ChangeGroupform();
            ChangeGroupform.StartPosition = FormStartPosition.CenterScreen;
            //указываем владельца для формы
            ChangeGroupform.Owner = this;// где containerInstance - это экземпляр контейнера или указатель на MainForm
            ChangeGroupform.Show();
        }

        private void Groupform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
