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
    public partial class ChangeBrandform : Form
    {
        sqldb _SQl = new sqldb();
        public ChangeBrandform()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Brandform ChangeBrandfrm = (Brandform)this.Owner;
            string id = Convert.ToString(ChangeBrandfrm.dgvbrand.Rows[ChangeBrandfrm.dgvbrand.CurrentRow.Index].Cells["id"].Value);

            string txtQueryChangeClass = "UPDATE Brand SET name='" + txtnamebrand.Text + "' WHERE id='" + id + "'";

            _SQl.SQL_Query(txtQueryChangeClass);

            this.Close();

            ChangeBrandfrm.load_brand();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeBrandform_Load(object sender, EventArgs e)
        {
            Brandform ChangeBrandfrm = (Brandform)this.Owner;
            txtnamebrand.Text = Convert.ToString(ChangeBrandfrm.dgvbrand.Rows[ChangeBrandfrm.dgvbrand.CurrentRow.Index].Cells["name"].Value);
        }

        private void ChangeBrandform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
