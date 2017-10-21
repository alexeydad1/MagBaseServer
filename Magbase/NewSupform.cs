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
    public partial class NewSupform : Form
    {
        sqldb _SQl = new sqldb();
        public NewSupform()
        {
            InitializeComponent();
        }

        private void btnSupSave_Click(object sender, EventArgs e)
        {
            Supform SupFrm = (Supform)this.Owner;
            string QueryNewSuppliers = "insert into suppliers(name,person,phone,adress) values('"+txtNameSup.Text+"','"+txtSupPerson.Text+"','"+mskTXTSupphone.Text+"','"+txtSupAdress.Text+"')";
            _SQl.SQL_Query(QueryNewSuppliers);
            this.Close();
            SupFrm.load_sup_form();
        }

        private void NewSupform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
