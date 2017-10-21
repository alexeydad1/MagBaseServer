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
    public partial class ChangeSupform : Form
    {
        sqldb _SQl = new sqldb();
        public ChangeSupform()
        {
            InitializeComponent();
        }

        private void btnSupSaveCH_Click(object sender, EventArgs e)
        {
            Supform SupFrm=(Supform)this.Owner;
            string QueryNewSuppliersCH = "update suppliers set name='" + txtNameSupCH.Text + "',person='" + txtSupPersonCH.Text + "',phone='" + mskTXTSupphoneCH.Text + "',adress='" + txtSupAdressCH.Text + "' where id=" + (SupFrm.idCH) + "";
            _SQl.SQL_Query(QueryNewSuppliersCH);
            this.Close();
            SupFrm.load_sup_form();
           
        }

        private void ChangeSupform_Load(object sender, EventArgs e)
        {
            Supform SupFrm=(Supform)this.Owner;
            txtNameSupCH.Text=SupFrm.dgvSup.Rows[SupFrm.dgvSup.CurrentRow.Index].Cells[1].Value.ToString();
            txtSupPersonCH.Text = SupFrm.dgvSup.Rows[SupFrm.dgvSup.CurrentRow.Index].Cells[2].Value.ToString();
            mskTXTSupphoneCH.Text = SupFrm.dgvSup.Rows[SupFrm.dgvSup.CurrentRow.Index].Cells[3].Value.ToString();
            txtSupAdressCH.Text = SupFrm.dgvSup.Rows[SupFrm.dgvSup.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void ChangeSupform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
