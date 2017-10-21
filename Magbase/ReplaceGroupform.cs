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
    public partial class ReplaceGroupform : Form
    {
        sqldb _SQl = new sqldb();
        public ReplaceGroupform()
        {
            InitializeComponent();
        }

        private void ReplaceGroupform_Load(object sender, EventArgs e)
        {
            DataTable cmbGroupRepTBL = _SQl.ExecuteSQL("select * from groupt");
            cmbgrouprep.DataSource = cmbGroupRepTBL;
            cmbgrouprep.ValueMember = "id";
            cmbgrouprep.DisplayMember = "name";
            cmbgrouprep.SelectedValue = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Tovarform RGroupfrm = (Tovarform)this.Owner;
            int id_group=Convert.ToInt32(cmbgrouprep.SelectedValue);
            RGroupfrm.chekedfind(RGroupfrm.trvgroup.Nodes,id_group);
            RGroupfrm.load_spravochnik_tovaarov();
            MessageBox.Show("Перемещено ( " + RGroupfrm.countRepl.ToString() + " ) элементов в группу ''" + cmbgrouprep.Text + "''", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RGroupfrm.countRepl = 0;
            this.Close();
            
        }

        private void ReplaceGroupform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
