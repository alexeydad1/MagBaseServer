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
    public partial class InfoPriceform : Form
    {
        sqldb _SQl = new sqldb();
        public string _kod;
        public string _fullname;

        public InfoPriceform(string Price,string kod,string fullname)
        {
            
            InitializeComponent();
            this.Text = Price;
            _kod = kod;
            _fullname = fullname;
        }

        private void InfoPrice_Load(object sender, EventArgs e)
        {
            if (this.Text.IndexOf("История Закупочных цен") >= 0)
            {
                GoodsHistoryPriceZakup(_kod, _fullname);
            }
            if (this.Text.IndexOf("История Розничных цен") >= 0)
            {
                GoodsHistoryPriceRoznAndPereozen(_kod, _fullname);
            }

        }
        public void GoodsHistoryPriceRoznAndPereozen(string kod, string FullName)
        {
            DataTable dtGHP = _SQl.ExecuteSQL("Select numberdock_mag,date,rcena,(Select login From Users WHERE id=users_bd) as NameUsers From incoming WHERE kod_dbase='" + kod + "' ORDER BY date DESC");
            lblNameGodds.Text = FullName;
            for (int i = 0; i < dtGHP.Rows.Count; i++)
            {
                dgvInfoPrice.Rows.Add(dtGHP.Rows[i][0].ToString(),dtGHP.Rows[i][1].ToString(),dtGHP.Rows[i][2].ToString(),dtGHP.Rows[i][3].ToString());
            }
            DataTable dtGHPpereocenka = _SQl.ExecuteSQL("Select id,date,newRcena,(Select login From Users WHERE id=users_bd) as NameUsers From Pereocenka WHERE kod_dbase='" + kod + "' ORDER BY date DESC");

            //Данные по Переоценке товара

            for (int l = 0; l < dtGHPpereocenka.Rows.Count; l++)
            {
                dgvInfoPrice.Rows.Add(dtGHPpereocenka.Rows[l][0].ToString(),dtGHPpereocenka.Rows[l][1].ToString(),dtGHPpereocenka.Rows[l][2].ToString(),dtGHPpereocenka.Rows[l][3].ToString());
            }
            
        }
        public void GoodsHistoryPriceZakup(string kod, string FullName)
        {
            DataTable dtGHZ = _SQl.ExecuteSQL("Select numberdock_mag,date,zcena,(Select login From Users WHERE id=users_bd) as NameUsers From incoming WHERE kod_dbase='" + kod + "' ORDER BY date DESC");
            lblNameGodds.Text = FullName;
            for (int l = 0; l < dtGHZ.Rows.Count; l++)
            {
                dgvInfoPrice.Rows.Add(dtGHZ.Rows[l][0].ToString(),dtGHZ.Rows[l][1].ToString(),dtGHZ.Rows[l][2].ToString(),dtGHZ.Rows[l][3].ToString());
            }
          
        }
    }
}
