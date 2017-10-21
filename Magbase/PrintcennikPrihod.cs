using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PrintcennikPrihod : Form
    {
        
        public PrintcennikPrihod()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Pform PrintPrihodfrm = (Pform)this.Owner;

            int left_otstup = 0;
            int top_otstup = 0;
            int x = 0;
            int y = 3;

            for (int i = 0; i < PrintPrihodfrm.dgvP.Rows.Count; i++)
            {

                if (i > x & i < y)
                {
                    left_otstup = left_otstup + 235;
                }

                if (i % 3 == 0 & i > 0)
                {
                    left_otstup = 0;
                    top_otstup = top_otstup + 135;
                    x = x + 3;
                    y = y + 3;
                }
                Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
                e.Graphics.DrawRectangle(blackPen, 10 + left_otstup, 20 + top_otstup, 235, 135);
                e.Graphics.DrawRectangle(blackPen, 10 + left_otstup, 20 + top_otstup, 235, 15);
                e.Graphics.DrawRectangle(blackPen, 10 + left_otstup, 140 + top_otstup, 235, 15);

                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                //G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                Rectangle RectShapka = new Rectangle(12 + left_otstup, 20 + top_otstup, 233, 15);
                Rectangle RectName = new Rectangle(11 + left_otstup, 35 + top_otstup, 234, 55);
                Rectangle RectCena = new Rectangle(11 + left_otstup, 90 + top_otstup, 234, 50);
                Rectangle RectKod = new Rectangle(12 + left_otstup, 140 + top_otstup, 233, 15);

                StringFormat sfshapka = new StringFormat();
                sfshapka.Alignment = StringAlignment.Near;
                sfshapka.LineAlignment = StringAlignment.Near;

                StringFormat sfcena = new StringFormat();
                sfcena.Alignment = StringAlignment.Center;
                sfcena.LineAlignment = StringAlignment.Center;

                StringFormat sfdate = new StringFormat();
                sfdate.Alignment = StringAlignment.Far;
                sfdate.LineAlignment = StringAlignment.Far;

                e.Graphics.DrawString(Sform.urliconame, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, RectShapka, sfshapka);

                e.Graphics.DrawString(PrintPrihodfrm.dgvP.Rows[i].Cells[1].Value.ToString(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, RectName, sfshapka);
                e.Graphics.DrawString(PrintPrihodfrm.dgvP.Rows[i].Cells[5].Value.ToString() + "р.", new Font("Tahoma", 30, FontStyle.Bold), Brushes.Black, RectCena, sfcena);
                e.Graphics.DrawString(PrintPrihodfrm.dgvP.Rows[i].Cells[0].Value.ToString(), new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, RectKod, sfshapka);

                string datecennik = DateTime.Today.ToString();
                datecennik = datecennik.Remove(10, (datecennik.Length - 10));
                e.Graphics.DrawString(datecennik, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, RectKod, sfdate);
            }
        }

        private void PrintcennikPrihod_Load(object sender, EventArgs e)
        {

        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
