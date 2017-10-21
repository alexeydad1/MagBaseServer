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
    public partial class Supform : Form
    {
        sqldb _SQl = new sqldb();
        public int idCH;

        public Supform()
        {
            InitializeComponent();
        }
        public void load_sup_form()
        {

            DataTable Suptable = _SQl.ExecuteSQL("select * from suppliers order by name");
            dgvSup.DataSource = Suptable;

            dgvSup.Columns[0].HeaderCell.Value = "ID";
            dgvSup.Columns[1].HeaderCell.Value = "Наименование";
            dgvSup.Columns[2].HeaderCell.Value = "Контактное лицо";
            dgvSup.Columns[3].HeaderCell.Value = "Телефон";
            dgvSup.Columns[4].HeaderCell.Value = "Адрес";

            dgvSup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSup.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSup.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSup.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSup.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSup.Columns[0].ReadOnly = true;
            dgvSup.Columns[1].ReadOnly = true;
            dgvSup.Columns[2].ReadOnly = true;
            dgvSup.Columns[3].ReadOnly = true;
            dgvSup.Columns[4].ReadOnly = true;
        }

        private void Supform_Load(object sender, EventArgs e)
        {
            load_sup_form();
            
        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "NewSupform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена

            Form NewSupform = new NewSupform();
            NewSupform.StartPosition = FormStartPosition.CenterScreen;
           //NewSupform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            NewSupform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            NewSupform.Show(); 

    
        }

        private void tsbtnchange_Click(object sender, EventArgs e)
        {
            if (dgvSup.Rows.Count > 0)
            {
                idCH =Convert.ToInt32(dgvSup.Rows[dgvSup.CurrentRow.Index].Cells["ID"].Value);
                 // проверяем не запущена ли форма 
                for (int x = 0; x < this.OwnedForms.Length; x++)
                {
                    if (this.OwnedForms[x].Name == "ChangeSupform")
                    {
                        this.OwnedForms[x].Focus();
                        return;
                    }
                }

                // Запускаем форму если она не запущена

                Form ChangeSupform = new ChangeSupform();
                ChangeSupform.StartPosition = FormStartPosition.CenterScreen;
                ChangeSupform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                ChangeSupform.Show();

            }
        }

        private void Supform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
