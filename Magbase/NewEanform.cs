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
    public partial class NewEanform : Form
    {
        Source _SRC = new Source();
        public NewEanform()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Tovarform NewEanfrm = (Tovarform)this.Owner;
            NewEanfrm.lstboxean.Items.Add (txtean.Text);
            this.Close();
        }

        private void NewEanform_Load(object sender, EventArgs e)
        {
            DialogResult ean_mag_yes = MessageBox.Show("Товар имеет штрихкод?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ean_mag_yes == DialogResult.No)
            {
                string ean_mag = _SRC.ean_mag();
                txtean.Text = ean_mag;
            }
            else
            {
                txtean.Text = "";
            }
        }

        private void NewEanform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
