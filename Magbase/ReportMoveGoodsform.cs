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
    public partial class ReportMoveGoodsform : Form
    {
        sqldb _SQl = new sqldb();
        Source _SRC = new Source();
        public string pref_dok_prihod;
        public string pref_dok_rashod;
                
        public ReportMoveGoodsform()
        {
            CallBackMy.callbackEventHandlerReportMoveGoodsform = new CallBackMy.callbackEventReportMoveGoodsform(this.add_goods);
            InitializeComponent();
        }

        public void add_goods(string Kod,string Name)
        {
            for (int i = 0; i < lstGoods.Items.Count; i++)
            {
                string Goods=lstGoods.Items[i].ToString();
                Goods=Goods.Remove(Goods.IndexOf(" --"));
                if (Kod == Goods)
                {
                    MessageBox.Show("Товар ''" + lstGoods.Items[i].ToString() + "'' уже есть в списке!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
            }
            lstGoods.Items.Add("" + Kod + " -- " + Name + "");
        }
        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            
              // проверяем не запущена ли форма 
            for (int x = 0; x < this.OwnedForms.Length; x++)
            {
                if (this.OwnedForms[x].Name == "FindTovarform")
                {
                    this.OwnedForms[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена

            // Запускаем форму если она не запущена
            Sform.ownerFormName = "ReportMoveGoodsform";
            Form FindTovarform = new FindTovarform();
            FindTovarform.StartPosition = FormStartPosition.CenterScreen;
            //FindTovarform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            FindTovarform.Owner = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            FindTovarform.Show();
       
            
            
        }

        private void btnRunRep_Click(object sender, EventArgs e)
        {
            dgvRepMove.Rows.Clear();
            string Kod = "";
            DataTable RepSales = new DataTable();
            DataTable RepIncom = new DataTable();
            DataTable RepOutgoin = new DataTable();
            DataTable AllinfoGoods = new DataTable();
            string numDoc = "";
            string doc = "";

            AllinfoGoods.Columns.Add("kod");
            AllinfoGoods.Columns.Add("name");
            AllinfoGoods.Columns.Add("count");
            AllinfoGoods.Columns.Add("cena");
            AllinfoGoods.Columns.Add("numdoc");
            AllinfoGoods.Columns.Add("date", typeof(DateTime));

            double countSales = 0;
            //double countIncom = 0;
            //double countOutgoin = 0;

            string PeriodN = func.replace_date_sql(Convert.ToString(dtpin.Value));
            string PeriodE = func.replace_date_sql(Convert.ToString(dtpout.Value.AddDays(1)));

            for (int i = 0; i < lstGoods.Items.Count; i++)
            {
                Kod = lstGoods.Items[i].ToString().Remove(lstGoods.Items[i].ToString().IndexOf(" --"));
                RepSales = _SQl.ExecuteSQL("select kod,(select name from dbase WHERE dbase.kod=sales.kod) as name,count,rcena,chek,date From sales where kod='" + Kod + "' and date>'" + PeriodN + "' and date<'" + PeriodE + "' ORDER BY date");
                RepIncom = _SQl.ExecuteSQL("select kod_dbase,(select name from dbase WHERE dbase.kod=Incoming.kod_dbase) as name,count,zcena,numberdock_mag,date From Incoming where kod_dbase='" + Kod + "' and date>'" + PeriodN + "' and date<'" + PeriodE + "' ORDER BY date");
                RepOutgoin = _SQl.ExecuteSQL("select kod_dbase,(select name from dbase WHERE dbase.kod=Outgoing.kod_dbase) as name,count,zcena,numberdock_mag,date From Outgoing where kod_dbase='" + Kod + "' and date>'" + PeriodN + "' and date<'" + PeriodE + "' ORDER BY date");

                for (int isales = 0; isales < RepSales.Rows.Count; isales++)
                {
                    AllinfoGoods.Rows.Add(RepSales.Rows[isales][0].ToString(), RepSales.Rows[isales][1].ToString(), RepSales.Rows[isales][2].ToString(), RepSales.Rows[isales][3].ToString(), RepSales.Rows[isales][4].ToString(), RepSales.Rows[isales][5].ToString());
                }

                for (int isales = 0; isales < RepIncom.Rows.Count; isales++)
                {
                    AllinfoGoods.Rows.Add(RepIncom.Rows[isales][0].ToString(), RepIncom.Rows[isales][1].ToString(), RepIncom.Rows[isales][2].ToString(), RepIncom.Rows[isales][3].ToString(), RepIncom.Rows[isales][4].ToString(), RepIncom.Rows[isales][5].ToString());
                }

                for (int isales = 0; isales < RepOutgoin.Rows.Count; isales++)
                {
                    AllinfoGoods.Rows.Add(RepOutgoin.Rows[isales][0].ToString(), RepOutgoin.Rows[isales][1].ToString(), RepOutgoin.Rows[isales][2].ToString(), RepOutgoin.Rows[isales][3].ToString(), RepOutgoin.Rows[isales][4].ToString(), RepOutgoin.Rows[isales][5].ToString());
                }

                DataView dVAllinfoGoods = new DataView(AllinfoGoods);
                dVAllinfoGoods.Sort = "date ASC";
                AllinfoGoods=dVAllinfoGoods.ToTable();


                if (AllinfoGoods.Rows.Count == 0)
                {
                    dgvRepMove.Rows.Add(Kod, lstGoods.Items[i].ToString());
                    dgvRepMove.Rows[dgvRepMove.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGray;
                    dgvRepMove.Rows.Add("", "Итого:", "0", "");
                }

                for (int irow = -1; irow < AllinfoGoods.Rows.Count; irow++)
                {
                    if (irow == -1)
                    {
                        dgvRepMove.Rows.Add(AllinfoGoods.Rows[0][0].ToString(), AllinfoGoods.Rows[0][1].ToString());
                        dgvRepMove.Rows[dgvRepMove.Rows.Count-1].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else
                    {


                        if (irow != AllinfoGoods.Rows.Count - 1 && irow !=-1)
                        {
                            numDoc=AllinfoGoods.Rows[irow ][4].ToString();

                            if (numDoc.IndexOf(pref_dok_prihod) != -1)
                            {
                                doc = "Приходная накладная № ";
                            }
                            if (numDoc.IndexOf(pref_dok_rashod) != -1)
                            {
                                doc = "Расходная накладная № ";
                            }
                            if (numDoc.IndexOf(pref_dok_rashod) == -1 && numDoc.IndexOf(pref_dok_prihod) == -1)
                            {
                                doc = "Чек № ";
                            }

                            countSales = countSales + Convert.ToDouble(AllinfoGoods.Rows[irow][2].ToString());
                            dgvRepMove.Rows.Add("", doc + AllinfoGoods.Rows[irow][4].ToString() + " -- " + AllinfoGoods.Rows[irow][5].ToString(), AllinfoGoods.Rows[irow][2].ToString(), AllinfoGoods.Rows[irow][3].ToString());
                        }
                        else
                        {
                            numDoc = AllinfoGoods.Rows[irow][4].ToString();

                            if (numDoc.IndexOf(pref_dok_prihod) != -1)
                            {
                                doc = "Приходная накладная № ";
                            }
                            if (numDoc.IndexOf(pref_dok_rashod) != -1)
                            {
                                doc = "Расходная накладная № ";
                            }
                            if (numDoc.IndexOf(pref_dok_rashod) == -1 && numDoc.IndexOf(pref_dok_prihod) == -1)
                            {
                                doc = "Чек № ";
                            }

                            countSales = countSales + Convert.ToDouble(AllinfoGoods.Rows[irow][2].ToString());
                            dgvRepMove.Rows.Add("", doc + AllinfoGoods.Rows[irow][4].ToString() + " -- " + AllinfoGoods.Rows[irow][5].ToString(), AllinfoGoods.Rows[irow][2].ToString(), AllinfoGoods.Rows[irow][3].ToString());
                            dgvRepMove.Rows.Add("", "Итого:", countSales,"");
                            countSales = 0;
                        }
                    }
                }
                AllinfoGoods.Clear();
            }
        }

        private void ReportMoveGoodsform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvRepMove_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int iRow= e.RowIndex;
            string numDoc= dgvRepMove.Rows[iRow].Cells[1].Value.ToString();

            if (numDoc.IndexOf("Приходная накладная № ") != -1)
            {
                numDoc = func.between(numDoc, "Приходная накладная № ", " --");
                Data.numDocPrihodRashod = numDoc;

                // проверяем не запущена ли форма 
                for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
                {
                    if (this.MdiParent.MdiChildren[x].Name == "Pviewform")
                    {
                        this.MdiParent.MdiChildren[x].Focus();
                        return;
                    }

                }
                // Запускаем форму если она не запущена
                Form Pviewform = new Pviewform();
                Pviewform.StartPosition = FormStartPosition.CenterScreen;
                Pviewform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                Pviewform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Pviewform.Show();


            }

            if (numDoc.IndexOf("Расходная накладная № ") != -1)
            {
                numDoc = func.between(numDoc, "Расходная накладная № ", " --");
                Data.numDocPrihodRashod = numDoc;

                // проверяем не запущена ли форма 
                for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
                {
                    if (this.MdiParent.MdiChildren[x].Name == "Rviewform")
                    {
                        this.MdiParent.MdiChildren[x].Focus();
                        return;
                    }

                }
                // Запускаем форму если она не запущена
                Form Rviewform = new Rviewform();
                Rviewform.StartPosition = FormStartPosition.CenterScreen;
                Rviewform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                Rviewform.MdiParent = this.MdiParent;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Rviewform.Show();
            }

            if (numDoc.IndexOf("Чек № ") != -1)
            {
                numDoc = func.between(numDoc, "Чек № ", " --");
            }

            
        }

        private void ReportMoveGoodsform_Load(object sender, EventArgs e)
        {
            pref_dok_prihod = _SRC.pref_dok_prihod();
            pref_dok_rashod = _SRC.pref_dok_rashod();
        }
    }
}
