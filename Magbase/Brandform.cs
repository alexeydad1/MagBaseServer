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
    public partial class Brandform : Form
    {
        sqldb _SQl = new sqldb();
        public void load_brand()
        {

            DataTable DTbrand = _SQl.ExecuteSQL("select id,Name from brand order by name");
            dgvbrand.DataSource = DTbrand;
           
            dgvbrand.Columns[0].HeaderCell.Value = "ID";
            dgvbrand.Columns[1].HeaderCell.Value = "Название";
            dgvbrand.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvbrand.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvbrand.Columns[0].ReadOnly = true;
            dgvbrand.Columns[1].ReadOnly = true;
            
        }
        public Brandform()
        {
            InitializeComponent();
        }

        private void Brandform_Load(object sender, EventArgs e)
        {
            load_brand();
        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "NewBrandform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена

            Form NewBrandform = new NewBrandform();
            NewBrandform.StartPosition = FormStartPosition.CenterScreen;
            //указываем владельца для формы
            NewBrandform.Owner = this;// где containerInstance - это экземпляр контейнера или указатель на MainForm
            NewBrandform.Show();
        }

        private void tsbtnchange_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "ChangeBrandform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена

            Form ChangeBrandform = new ChangeBrandform();
            ChangeBrandform.StartPosition = FormStartPosition.CenterScreen;
            //указываем владельца для формы
            ChangeBrandform.Owner = this;// где containerInstance - это экземпляр контейнера или указатель на MainForm
            ChangeBrandform.Show();
        }

        private void Brandform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
