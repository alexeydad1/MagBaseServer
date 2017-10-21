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
    public partial class Classform : Form
    {
        sqldb _SQl = new sqldb();

        public void load_class()
        {
            
            DataTable DTclass = _SQl.ExecuteSQL("select id,Name,margin_class from Classt order by name");
            dgvclass.DataSource = DTclass;

            dgvclass.Columns[0].HeaderCell.Value = "ID";
            dgvclass.Columns[1].HeaderCell.Value = "Название";
            dgvclass.Columns[2].HeaderCell.Value = "Наценка";
            dgvclass.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvclass.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvclass.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvclass.Columns[0].ReadOnly = true;
            dgvclass.Columns[1].ReadOnly = true;
            dgvclass.Columns[2].ReadOnly = true;

        }


        public Classform()
        {
            InitializeComponent();
            load_class();
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "NewClassform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form NewClassform = new NewClassform();
            NewClassform.StartPosition = FormStartPosition.CenterScreen;
            //указываем владельца для формы
            NewClassform.Owner = this;// где containerInstance - это экземпляр контейнера или указатель на MainForm
            NewClassform.Show();
        }

        private void tsbtnchange_Click(object sender, EventArgs e)
        {
           //int posclass = dgvclass.CurrentRow.Index;

            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "ChangeClassform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
               
            Form ChangeClassform = new ChangeClassform();
            ChangeClassform.StartPosition = FormStartPosition.CenterScreen;
            //указываем владельца для формы
            ChangeClassform.Owner = this;// где containerInstance - это экземпляр контейнера или указатель на MainForm
            ChangeClassform.Show();
        }

        private void Classform_Load(object sender, EventArgs e)
        {

        }

        private void Classform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Classform_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


    }
}
