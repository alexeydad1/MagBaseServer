using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MagbaseServer
{
    public partial class Pluexpform : Form
    {
        sqldb _SQl = new sqldb();
        public string plup_ref_ves;
        public Pluexpform()
        {
            InitializeComponent();
        }

        private void Pluexpform_Load(object sender, EventArgs e)
        {
            DataTable Plugoodstbl = _SQl.ExecuteSQL("select kod,name,rcena,plukod,life_goods from dbase where plukod>0 ");
            dgvplu.DataSource = Plugoodstbl;
            dgvplu.Columns["kod"].ReadOnly = true;
            dgvplu.Columns["name"].ReadOnly = true;
            dgvplu.Columns["rcena"].ReadOnly = true;
            dgvplu.Columns["plukod"].ReadOnly = true;
            dgvplu.Columns["life_goods"].ReadOnly = true;

            dgvplu.Columns["kod"].HeaderText = "Код";
            dgvplu.Columns["name"].HeaderText = "Наименование";
            dgvplu.Columns["rcena"].HeaderText = "Цена";
            dgvplu.Columns["plukod"].HeaderText = "PLU код";
            dgvplu.Columns["life_goods"].HeaderText = "Срок годности";

            dgvplu.Columns["kod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvplu.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvplu.Columns["rcena"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvplu.Columns["plukod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvplu.Columns["life_goods"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataTable PLUPREF = _SQl.ExecuteSQL("select PrefVesEan from Source");
            plup_ref_ves = PLUPREF.Rows[0][0].ToString();
        }

        private void tsbtnexport_Click(object sender, EventArgs e)
        {
            saveFD.Filter = "Файлы баз данных (*.dbf)|*.dbf|Все файлы (*.*)|*.*";
            saveFD.AddExtension = true;
            saveFD.DefaultExt = "*.dbf";
            saveFD.CheckPathExists = true;
            saveFD.InitialDirectory = Environment.CurrentDirectory;
            saveFD.FileName = "expPLU";
            //saveFD.CheckFileExists = true;


            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFD.FileName.Remove(0, saveFD.FileName.LastIndexOf('\\') + 1);
                filename = filename.Substring(0, filename.IndexOf("."));
                string PathFile = saveFD.FileName.Remove(saveFD.FileName.LastIndexOf('\\') + 1);

                if (File.Exists(PathFile + filename + ".dbf"))
                {
                    File.Delete(PathFile + filename + ".dbf");
                    DBF.create_db(PathFile, filename);
                }
                else
                {
                    DBF.create_db(PathFile, filename);
                }

                for (int i = 0; i < dgvplu.Rows.Count; i++)
                {
                    string kod = dgvplu.Rows[i].Cells["kod"].Value.ToString();
                    string plu = dgvplu.Rows[i].Cells["plukod"].Value.ToString();
                    string name = dgvplu.Rows[i].Cells["name"].Value.ToString();
                    string pref_ean_ves = plup_ref_ves;
                    string rcena = dgvplu.Rows[i].Cells["rcena"].Value.ToString();
                    string life_goods = dgvplu.Rows[i].Cells["life_goods"].Value.ToString();

                    DBF.export_dbf(kod, plu, name, pref_ean_ves, rcena, life_goods, PathFile, filename);
                }
                MessageBox.Show("Данные выгружены в файл: " + Environment.NewLine + PathFile + filename + ".dbf", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Pluexpform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
