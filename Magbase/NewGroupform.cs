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
    public partial class NewGroupform : Form
    {
        sqldb _SQl = new sqldb();
        public NewGroupform()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Groupform NewGRPsfrm = (Groupform)this.Owner;

            DataTable DTngrp = _SQl.ExecuteSQL("SELECT max(id) FROM Groupt");
            
            if (DTngrp.Rows[0][0].ToString() == "")
            {
                int id_grpn = 1;
                string txtQueryNewClassAdd = "INSERT INTO groupt VALUES('" + id_grpn + "','" + txtnamegrp.Text + "')";
                _SQl.SQL_Query(txtQueryNewClassAdd);

            }
            else
            {
                int id_grpn = Convert.ToInt32(DTngrp.Rows[0][0].ToString()) + 1;
                string txtQueryNewClassAdd = "INSERT INTO groupt VALUES('" + id_grpn + "','" + txtnamegrp.Text + "')";
                _SQl.SQL_Query(txtQueryNewClassAdd);
            }
            

            this.Close();

            NewGRPsfrm.load_group();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewGroupform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
