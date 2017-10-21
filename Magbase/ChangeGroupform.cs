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
    public partial class ChangeGroupform : Form
    {
        sqldb _SQl = new sqldb();
        public ChangeGroupform()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Groupform ChangeGRPfrm = (Groupform)this.Owner;
            string id = Convert.ToString(ChangeGRPfrm.dgvgroup.Rows[ChangeGRPfrm.dgvgroup.CurrentRow.Index].Cells["id"].Value);

            string txtQueryChangeClass = "UPDATE groupt SET name='" + txtnamegrp.Text + "' WHERE id='" + id + "'";

            _SQl.SQL_Query(txtQueryChangeClass);

            this.Close();

            ChangeGRPfrm.load_group();
        }

        private void ChangeGroupform_Load(object sender, EventArgs e)
        {
            Groupform ChangeGRPfrm = (Groupform)this.Owner;
            txtnamegrp.Text= Convert.ToString(ChangeGRPfrm.dgvgroup.Rows[ChangeGRPfrm.dgvgroup.CurrentRow.Index].Cells["name"].Value);
        }

        private void ChangeGroupform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
