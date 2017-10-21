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
    public partial class NewBrandform : Form
    {
        sqldb _SQl = new sqldb();

        public NewBrandform()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Brandform NewBrandfrm = (Brandform)this.Owner;

            DataTable DTnbrand = _SQl.ExecuteSQL("SELECT max(id) FROM Brand");
            if (DTnbrand.Rows[0][0].ToString() == "")
            {
                int id_brandn = 1;
                string txtQueryNewBrandAdd = "INSERT INTO Brand VALUES('" + id_brandn + "','" + txtnamebrand.Text + "')";
                _SQl.SQL_Query(txtQueryNewBrandAdd);

            }
            else
            {
                int id_brandn = Convert.ToInt32(DTnbrand.Rows[0][0].ToString()) + 1;
                string txtQueryNewBrandAdd = "INSERT INTO Brand VALUES('" + id_brandn + "','" + txtnamebrand.Text + "')";
                _SQl.SQL_Query(txtQueryNewBrandAdd);
            }
          

            this.Close();

            NewBrandfrm.load_brand();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewBrandform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
