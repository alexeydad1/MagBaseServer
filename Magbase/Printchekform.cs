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
    public partial class Printchekform : Form
    {

        
       
        public Printchekform()
        {
            InitializeComponent();
        }

        private void Printchekform_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void Printchekform_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void tspbtnprint_Click(object sender, EventArgs e)
        {
             printCennikTovar.Print();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
        


        private void printDocument2_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blackPen, 10, 20, 235, 135);
            e.Graphics.DrawRectangle(blackPen, 10, 20, 235, 15);
            e.Graphics.DrawRectangle(blackPen, 10, 140, 235, 15);
            
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            //G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Rectangle RectShapka = new Rectangle(12, 20, 233, 15);
            Rectangle RectName = new Rectangle(11, 35, 234, 55);
            Rectangle RectCena = new Rectangle(11, 90, 234, 50);
            Rectangle RectKod = new Rectangle(12, 140, 233, 15);

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
            Tovarform PrintTovarfrm = (Tovarform)this.Owner;
            e.Graphics.DrawString(PrintTovarfrm.lblname.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, RectName, sfshapka);
            e.Graphics.DrawString(PrintTovarfrm.txtrcena.Text + "р.", new Font("Tahoma", 30, FontStyle.Bold), Brushes.Black, RectCena, sfcena);
            e.Graphics.DrawString(PrintTovarfrm.lblkod.Text, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, RectKod, sfshapka);

            string datecennik = DateTime.Today.ToString();
            datecennik = datecennik.Remove(10, (datecennik.Length - 10));
            e.Graphics.DrawString(datecennik, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, RectKod, sfdate);
            
                    
        }

        private void printPreviewControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
