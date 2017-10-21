using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace MagbaseServer

{
    /// <summary>
    /// Класс - помошник печати, выводит на принтер данные из таблицы _dataTable
    /// </summary>
   class PrintHelper
    {
        private int shapkachek = 0;
        int x = 0;
        int y = 3;
        private readonly DataTable _dataTable;
        private int iterPrintRow;
        private int skucount;
        double summacheka;
        public string numchek = string.Empty;
        public string _numdoc = string.Empty;
        public string _datedoc = string.Empty;
        /// <summary>
        /// Конструктор класса требует передачи данных для последующей печати
        /// </summary>
        /// <param name="dataTable"></param>
        public PrintHelper(DataTable dataTable)
        {
            iterPrintRow = 0;
            _dataTable = dataTable;

        }

        /// <summary>
        /// Метод печати
        /// </summary>
        public void Print(string nameDoc)
        {   
            //string nameDoc=Form.ActiveForm.Text;
            //nameDoc = nameDoc.Substring(nameDoc.IndexOf('[')+1,nameDoc.IndexOf(']')-nameDoc.IndexOf('[')-1);
            PrintDocument printDocument = new PrintDocument();
            printDocument.DocumentName = nameDoc;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printDocument.PrinterSettings.PrinterName = Sform.NamePrinterDok;
            printDocument.PrinterSettings.MaximumPage = 3;
            // формируем диалоговое окно для выбора принтера 
            PrintPreviewDialog prevD = new PrintPreviewDialog();
            prevD.Document = printDocument;
            if (prevD.ShowDialog() == DialogResult.OK)
            {
                iterPrintRow = 0;
                x = 0;
                y = 3;
                printDocument.Print();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            }
            PrintDialog pDialog = new PrintDialog();
            pDialog.Document = printDocument;
            // если в окне нажали отмену, то печать логично отменить
            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                iterPrintRow = 0;
                x = 0;
                y = 3;
                printDocument.Print();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            }
            
            
            
            
            
            //prevD.ShowDialog();

            //PrintDialog pDialog = new PrintDialog();
            //pDialog.Document = printDocument;
            //// если в окне нажали отмену, то печать логично отменить
            //if (pDialog.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument.Print();
            //}
        }

        private static string GetDefaultPrinterName()
        {/// определение принтера по умолчанию
            String[] printers = PrinterSettings.InstalledPrinters.Cast<string>().ToArray();
            for (int i = 0; i < printers.Length; i++)
                if (new PrinterSettings() { PrinterName = printers[i] }.IsDefaultPrinter)
                    return printers[i];
            return null;
        }

        public void PrintChek(string nameDoc,double summchek,int skucountchek,string numchekTform)
        {
            numchek = numchekTform; 
            skucount = skucountchek;
            summacheka = summchek;
            PrintDocument printChek = new PrintDocument();
            printChek.DocumentName = nameDoc;
            printChek.PrintPage += new PrintPageEventHandler(printChek_PrintPage);
            printChek.PrinterSettings.PrinterName = Sform.NamePrinterChek;//GetDefaultPrinterName();
            Margins margins = new Margins(0,0,5,5);
            printChek.DefaultPageSettings.Margins = margins;
            // формируем диалоговое окно для выбора принтера 
            iterPrintRow = 0;
            printChek.PrintPage += new PrintPageEventHandler(printChek_PrintPage);
            printChek.Print();

         
        }

        public void PrintVN(string numdoc,string datedoc)
        {
            _numdoc = numdoc;
            _datedoc = datedoc;
            PrintDocument printVN = new PrintDocument();
            printVN.DefaultPageSettings.Landscape=true;//Ориентация бумаги альбомная
            
            printVN.PrinterSettings.PrinterName = Sform.NamePrinterDok;//GetDefaultPrinterName();
            Margins margins = new Margins(0, 0, 5, 5);
            printVN.DefaultPageSettings.Margins = margins;
            printVN.PrintPage += new PrintPageEventHandler(VozvratnayaNakladaya);
            PrintPreviewDialog prevD = new PrintPreviewDialog();
            prevD.Document = printVN;
            if (prevD.ShowDialog() == DialogResult.OK)
            {
                iterPrintRow = 0;

                printVN.Print();
                printVN.PrintPage += new PrintPageEventHandler(VozvratnayaNakladaya);
            }
           
           


        }
        public void PrintEan(string nameDoc)
        {

            PrintDocument PrintEan = new PrintDocument();
            PrintEan.DocumentName = nameDoc;
            PrintEan.PrintPage += new PrintPageEventHandler(PrintEan_PrintPage);
            PrintEan.PrinterSettings.PrinterName =Sform.NamePrinterDok;
            Margins margins = new Margins(0, 0, 5, 5);
            PrintEan.DefaultPageSettings.Margins = margins;
            // формируем диалоговое окно для выбора принтера 

            PrintPreviewDialog prevD = new PrintPreviewDialog();
            prevD.Document = PrintEan;
            if (prevD.ShowDialog() == DialogResult.OK)
            {
                iterPrintRow = 0;

                PrintEan.Print();
                PrintEan.PrintPage += new PrintPageEventHandler(PrintEan_PrintPage);
            }

            PrintDialog pDialog = new PrintDialog();
            pDialog.Document = PrintEan;
            // если в окне нажали отмену, то печать логично отменить
            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                iterPrintRow = 0;
                PrintEan.Print();
                PrintEan.PrintPage += new PrintPageEventHandler(PrintEan_PrintPage);
            }
            


        }
        /// <summary>
        /// методы вызывается каждый раз, когда printDocument соберется создавать новую страницу
        /// </summary>
        /// 

        private void PrintEan_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int count = 0;
            float yPos = -57;
            float iLine = 0;
            
            Font printFontEAN = new Font("C39HrP36DlTt", 36);
            Font printFont = new Font("Arial", 12);
            float Margtop = ev.MarginBounds.Top;
            float Margleft = ev.MarginBounds.Left;

            float fontsizeEan = printFontEAN.GetHeight(ev.Graphics);
            float fontsize = printFont.GetHeight(ev.Graphics);
            float fontsizeW = printFont.Size;

            float linesPerPage = ev.MarginBounds.Height / printFontEAN.GetHeight(ev.Graphics);
            float linesPerPageW = ev.MarginBounds.Width / fontsizeW;
            string Ean = "";
            foreach (string row in GetNextRowEan())
            {
                Ean = row.Trim();
                if (count > linesPerPage)
                    break;

                if (Ean.IndexOf('!') != -1)
                {
                    if (Ean.Length > 15)
                    {
                        string[] split = Ean.Split(new Char[] { ' ', '!' });
                        int countEan = 0;
                        foreach (string s in split)
                        {

                            if (s.Trim() != "")
                            {
                                if (countEan == 0)
                                {
                                    yPos = yPos + fontsize + 5;
                                }
                                else
                                {
                                    yPos = yPos + fontsizeEan + 10;
                                }
                                ev.Graphics.DrawString("!" + s + "!", printFontEAN, Brushes.Black, Margleft, yPos, new StringFormat());

                                
                                    iLine = yPos + fontsizeEan + 5;
                                    Pen p = new Pen(Color.Black, 1);// цвет линии и ширина
                                    PointF p1 = new PointF(0, iLine);// первая точка
                                    PointF p2 = new PointF(450, iLine);// вторая точка

                                    ev.Graphics.DrawLine(p, p1, p2);
                                
                                countEan++;
                                count++;
                            }
                        }

                    }
                    else
                    {

                        yPos = yPos + fontsize + 5;
                        ev.Graphics.DrawString(Ean, printFontEAN, Brushes.Black, Margleft, yPos, new StringFormat());
                        count++;
                        iLine = yPos + fontsizeEan + 5;
                        Pen p = new Pen(Color.Black, 1);// цвет линии и ширина
                        PointF p1 = new PointF(0, iLine);// первая точка
                        PointF p2 = new PointF(450, iLine);// вторая точка

                        ev.Graphics.DrawLine(p, p1, p2);
                    }
                    
                }
                else
                {

                    yPos = yPos + fontsizeEan+10;
                    ev.Graphics.DrawString(Ean, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                    count++;
                }
            }
            ev.HasMorePages = iterPrintRow < _dataTable.Rows.Count;
        }
        private void printChek_PrintPage(object sender, PrintPageEventArgs ev)
        {
                int summ=0;
                int finalchek = 0; 
                string namet1 = "";
                string nameT = "";
                int count = 0;
                float yPos = 0;

                int skuchek = 0;
                // шрифта печатываемого текста, его можно даже в отдельном контроле задавать из окна проги
                Font printFont = new Font("Arial", 8);
                float Margtop = ev.MarginBounds.Top;
                float Margleft = ev.MarginBounds.Left;
            
                float fontsize = printFont.GetHeight(ev.Graphics);
                float fontsizeW = printFont.Size;

                // Высчитываем количество строк на листе по размеру шрифта
                float linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
                

                // Итерациями по строкам таблицы, выводим каждую из них на новую строку листа
                foreach (string row in GetNextRowChek())
                {
                    if (skuchek == (skucount*3)-3)
                    {
                        finalchek = 1;
                    }
                    if (count > linesPerPage)
                        break;
                    // позиция текста по Y координате
                    
                    
                    if (shapkachek == 0)
                    {
                       
                        //StringFormat infomag = new StringFormat();
                        //infomag.Alignment = StringAlignment.Center;

                        yPos = Margtop + (count * fontsize);
                        ev.Graphics.DrawString(Sform.urliconame, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                        count++;
                        yPos = Margtop + (count * fontsize);
                        ev.Graphics.DrawString(Sform.fullAdress, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                        count++;
                        yPos = Margtop + (count * fontsize);
                        ev.Graphics.DrawString("Кассир:", printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                        count++;
                        yPos = Margtop + (count * fontsize);
                        ev.Graphics.DrawString(Sform.user_bd, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                        count++;
                        yPos = Margtop + (count * fontsize);
                        ev.Graphics.DrawString("Чек № " + numchek, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                        count++;
                        yPos = Margtop + (count * fontsize);
                        ev.Graphics.DrawString("".PadLeft(28, '='), printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                        count++;
                        shapkachek = 1;
                    }


                    namet1 = row;
                    while (namet1.Length != 0)
                    {
                        if (namet1.Length > 31)
                        {
                            nameT = namet1.Substring(0, 31);
                            yPos = Margtop + (count * fontsize);
                            ev.Graphics.DrawString(nameT, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                            namet1 = namet1.Remove(0, 31);
                            count++;
                        }
                        else
                        {
                            
                                if (namet1.IndexOf(" X ") != -1)
                                {
                                   
                                    yPos = Margtop + (count * fontsize);
                                    ev.Graphics.DrawString(namet1, printFont, Brushes.Black,Margleft , yPos, new StringFormat());
                                    summ=1;
                                    namet1 = "";

                                    
                                    
                                }
                                else
                                {
                                    if (summ == 1)
                                    {

                                        float xPos = 120; //(fontsizeW * 31) - (namet1.Length * 31);
                                        yPos = Margtop + (count * fontsize);
                                        ev.Graphics.DrawString("= "+namet1, printFont, Brushes.Black, xPos, yPos, new StringFormat());
                                        namet1 = "";
                                        summ = 0;
                                        count++;

                                        if (finalchek == 1)
                                        {
                                            yPos = Margtop + (count * fontsize);
                                            ev.Graphics.DrawString("".PadLeft(28, '='), printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                                            count++;
                                            yPos = Margtop + (count * fontsize);
                                            ev.Graphics.DrawString("Всего: ".PadRight(20,' ') + summacheka, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                                            count++;
                                            yPos = Margtop + (count * fontsize);
                                            ev.Graphics.DrawString(DateTime.Now.ToString()+Sform.user_bd.PadLeft(10,' '), printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                                            count++;
                                            yPos = Margtop + (count * fontsize);
                                            ev.Graphics.DrawString("Продажа", printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                                            count++;
                                            yPos = Margtop + (count * fontsize);
                                            ev.Graphics.DrawString("Итог: ".PadRight(20, ' ') + summacheka, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                                            count++;
                                            yPos = Margtop + (count * fontsize);
                                            ev.Graphics.DrawString("Спасибо за покупку", printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                                            count++;

                                        }
                                    }
                                    else
                                    {
                                        yPos = Margtop + (count * fontsize);
                                        ev.Graphics.DrawString(namet1, printFont, Brushes.Black, Margleft, yPos, new StringFormat());
                                        namet1 = "";
                                        count++;
                                    }
                                }
                            
                        }
                    }
                    skuchek++;
                }
                
                // если не все ещё строки распечатаны - будем создавать новую страницу
                ev.HasMorePages = iterPrintRow < _dataTable.Rows.Count;
           

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int left_otstup = 0;
            int top_otstup = 0;
            string kod = "";
            string rcena = "";
            string namet = "";

            int count = 0;
            foreach (string row in GetNextRow())
            {

                if (count > 23)
                {

                    break;
                }


                if (iterPrintRow > x & iterPrintRow < y)
                {
                    left_otstup = left_otstup + 235;
                }


                Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
                ev.Graphics.DrawRectangle(blackPen, 10 + left_otstup, 20 + top_otstup, 235, 135);
                ev.Graphics.DrawRectangle(blackPen, 10 + left_otstup, 20 + top_otstup, 235, 15);
                ev.Graphics.DrawRectangle(blackPen, 10 + left_otstup, 140 + top_otstup, 235, 15);
                
                ev.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                //G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                RectangleF RectShapka = new RectangleF(12 + left_otstup, 20 + top_otstup, 233, 15);
                RectangleF RectName = new RectangleF(11 + left_otstup, 35 + top_otstup, 234, 55);
                RectangleF RectCena = new RectangleF(11 + left_otstup, 90 + top_otstup, 234, 50);
                RectangleF RectKod = new RectangleF(12 + left_otstup, 140 + top_otstup, 233, 15);

                StringFormat sfshapka = new StringFormat();
                sfshapka.Alignment = StringAlignment.Near;
                sfshapka.LineAlignment = StringAlignment.Near;

                StringFormat sfcena = new StringFormat();
                sfcena.Alignment = StringAlignment.Center;
                sfcena.LineAlignment = StringAlignment.Center;

                StringFormat sfdate = new StringFormat();
                sfdate.Alignment = StringAlignment.Far;
                sfdate.LineAlignment = StringAlignment.Far;

                ev.Graphics.DrawString(Sform.urliconame, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, RectShapka, sfshapka);

                kod = _dataTable.Rows[iterPrintRow][0].ToString();
                rcena = _dataTable.Rows[iterPrintRow][2].ToString();
                namet = _dataTable.Rows[iterPrintRow][1].ToString();

                ev.Graphics.DrawString(namet, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, RectName, sfshapka);
                ev.Graphics.DrawString(rcena + "р.", new Font("Tahoma", 30, FontStyle.Bold), Brushes.Black, RectCena, sfcena);
                ev.Graphics.DrawString(kod, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, RectKod, sfshapka);

                string datecennik = DateTime.Today.ToString();
                datecennik = datecennik.Remove(10, (datecennik.Length - 10));
                ev.Graphics.DrawString(datecennik, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, RectKod, sfdate);
                count++;
                if (left_otstup == 470 & iterPrintRow > 0)
                {
                    left_otstup = 0;
                    top_otstup = top_otstup + 135;
                    x = x + 3;
                    y = y + 3;
                }
            }

            ev.HasMorePages = iterPrintRow < _dataTable.Rows.Count;



            //int count = 0;
            //// шрифта печатываемого текста, его можно даже в отдельном контроле задавать из окна проги
            //Font printFont = new Font("Arial", 9);

            //// Высчитываем количество строк на листе по размеру шрифта
            //float linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            //// Итерациями по строкам таблицы, выводим каждую из них на новую строку листа
            //foreach (string row in GetNextRow())
            //{
            //    if (count > linesPerPage)
            //        break;
            //    // позиция текста по Y координате
            //    float yPos = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics));
            //    ev.Graphics.DrawString(row, printFont, Brushes.Black, ev.MarginBounds.Left, yPos, new StringFormat());
            //    count++;
            //}

            //// если не все ещё строки распечатаны - будем создавать новую страницу
            //ev.HasMorePages = iterPrintRow < _dataTable.Rows.Count;
        }
        private void VozvratnayaNakladaya(object sender, PrintPageEventArgs ev)
        {
            float yPos = 0;

            // шрифта печатываемого текста, его можно даже в отдельном контроле задавать из окна проги
            Font printFont = new Font("Arial", 7);
            float Margtop = ev.MarginBounds.Top;
            float Margleft = ev.MarginBounds.Left;

            float fontsize = printFont.GetHeight(ev.Graphics);
            float fontsizeW = printFont.Size;

            // Высчитываем количество строк на листе по размеру шрифта
            float linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            float boundsPerPage = ev.MarginBounds.Width / fontsizeW;

            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);

            StringFormat praviyKray = new StringFormat();
            praviyKray.Alignment = StringAlignment.Far;
            praviyKray.LineAlignment = StringAlignment.Near;

            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;
            center.LineAlignment = StringAlignment.Center;
            

            string test="Унифицированная форма № ТОРГ- 12 Утверждена постановлением Госкомстата России от 25.12.98 № 132";
            
            ev.Graphics.DrawString(test, printFont, Brushes.Black,635, yPos, new StringFormat());
                yPos = yPos + fontsize;

                RectangleF rect = new RectangleF( 990, yPos, 145, 15);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 15);
                ev.Graphics.DrawString("Код", new Font("Arial", 8), Brushes.Black, rect, center);
                yPos = yPos + 15;

                rect = new RectangleF(990, yPos, 145, 15);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 15);
                ev.Graphics.DrawString("0330212", new Font("Arial", 8), Brushes.Black, rect, center);
                ev.Graphics.DrawString("Форма по ОКУД", new Font("Arial", 8), Brushes.Black, 901, yPos, new StringFormat());
                yPos = yPos + 15;

                rect = new RectangleF(990, yPos, 145, 29);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 29);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
                //Грузооправитель
                ev.Graphics.DrawLine(blackPen,new PointF(10,yPos+29),new PointF(930,yPos+29));
                ev.Graphics.DrawString("организация – грузоотправитель, адрес, номер телефона, факса, банковские реквизиты", new Font("Arial", 6), Brushes.Black, 300, yPos+29, new StringFormat());
                ev.Graphics.DrawString("по ОКПО", new Font("Arial", 8), Brushes.Black, 939, yPos+18, new StringFormat());
                yPos = yPos + 29;

                rect = new RectangleF(990, yPos, 145, 40);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 40);
                //структурное подразделение
                ev.Graphics.DrawLine(blackPen, new PointF(10, yPos + 29), new PointF(990, yPos + 29));
                ev.Graphics.DrawString("структурное подразделение", new Font("Arial", 6), Brushes.Black, 300, yPos + 29, new StringFormat());
                ev.Graphics.DrawString("Вид деятельности по ОКДП", new Font("Arial", 8), Brushes.Black, 844, yPos + 29, new StringFormat());
                yPos = yPos + 40;

                rect = new RectangleF(990, yPos, 145, 40);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 40);
                ev.Graphics.DrawString("Грузополучатель", new Font("Arial", 8), Brushes.Black, 10, yPos + 19, new StringFormat());
                //Грузополучатель
                ev.Graphics.DrawLine(blackPen, new PointF(110, yPos + 29), new PointF(930, yPos + 29));
                ev.Graphics.DrawString("наименование организации, адрес, номер телефона, банковские реквизиты", new Font("Arial", 6), Brushes.Black, 300, yPos + 29, new StringFormat());
                ev.Graphics.DrawString("по ОКПО", new Font("Arial", 8), Brushes.Black, 939, yPos + 19, new StringFormat());
                yPos = yPos + 40;

                rect = new RectangleF(990, yPos, 145, 40);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 40);
                ev.Graphics.DrawString("Поставщик", new Font("Arial", 8), Brushes.Black, 10, yPos + 19, new StringFormat());
                //Поставщик
                ev.Graphics.DrawLine(blackPen, new PointF(110, yPos + 29), new PointF(930, yPos + 29));
                ev.Graphics.DrawString("наименование организации, адрес, номер телефона, банковские реквизиты", new Font("Arial", 6), Brushes.Black, 300, yPos + 29, new StringFormat());
                ev.Graphics.DrawString("по ОКПО", new Font("Arial", 8), Brushes.Black, 939, yPos + 19, new StringFormat());
                yPos = yPos + 40;

                rect = new RectangleF(990, yPos, 145, 40);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 40);
                ev.Graphics.DrawString("Плательщик", new Font("Arial", 8), Brushes.Black, 10, yPos + 19, new StringFormat());
                //Плательщик
                ev.Graphics.DrawLine(blackPen, new PointF(110, yPos + 29), new PointF(930, yPos + 29));
                ev.Graphics.DrawString("наименование организации, адрес, номер телефона, банковские реквизиты", new Font("Arial", 6), Brushes.Black, 300, yPos + 29, new StringFormat());
                ev.Graphics.DrawString("по ОКПО", new Font("Arial", 8), Brushes.Black, 939, yPos + 19, new StringFormat());
                yPos = yPos + 40;

                rect = new RectangleF(990, yPos, 145, 15);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 15);
           // Номер накладной
                ev.Graphics.DrawString(_numdoc, new Font("Arial", 8), Brushes.Black, rect, center);
                rect = new RectangleF(921, yPos, 69, 15);
                ev.Graphics.DrawRectangle(blackPen, 921, Convert.ToInt32(yPos), 69, 15);
                ev.Graphics.DrawString("номер", new Font("Arial", 8), Brushes.Black, rect, center);
                ev.Graphics.DrawString("Основание", new Font("Arial", 8), Brushes.Black, 10, yPos + 5, new StringFormat());
                //Основание
                ev.Graphics.DrawLine(blackPen, new PointF(110, yPos + 15), new PointF(930, yPos + 15));
                ev.Graphics.DrawString("наименование документа (договор, контракт, заказ-наряд)", new Font("Arial", 6), Brushes.Black, 300, yPos + 15, new StringFormat());
                yPos = yPos + 15;

                rect = new RectangleF(990, yPos, 145, 15);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 15);
           // Дата накладной
                ev.Graphics.DrawString(_datedoc, new Font("Arial", 8), Brushes.Black, rect, center);
                rect = new RectangleF(921, yPos, 69, 15);
                ev.Graphics.DrawRectangle(blackPen, 921, Convert.ToInt32(yPos), 69, 15);
                ev.Graphics.DrawString("дата", new Font("Arial", 8), Brushes.Black, rect, center);
                yPos = yPos + 15;


                rect = new RectangleF(990, yPos, 145, 15);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 15);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
                rect = new RectangleF(921, yPos, 69, 15);
                ev.Graphics.DrawRectangle(blackPen, 921, Convert.ToInt32(yPos), 69, 15);
                ev.Graphics.DrawString("номер", new Font("Arial", 8), Brushes.Black, rect, center);
                yPos = yPos + 15;

                rect = new RectangleF(990, yPos, 145, 15);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 15);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
                rect = new RectangleF(921, yPos, 69, 15);
                ev.Graphics.DrawRectangle(blackPen, 921, Convert.ToInt32(yPos), 69, 15);
                ev.Graphics.DrawString("дата", new Font("Arial", 8), Brushes.Black, rect, center);
                ev.Graphics.DrawString("Транспортная накладная", new Font("Arial", 8), Brushes.Black, 780, yPos+2, new StringFormat());
                yPos = yPos + 15;

                rect = new RectangleF(990, yPos, 145, 15);
                ev.Graphics.DrawRectangle(blackPen, 990, Convert.ToInt32(yPos), 145, 15);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
                ev.Graphics.DrawString("Вид операции", new Font("Arial", 8), Brushes.Black, 915, yPos + 2, new StringFormat());
                yPos = yPos + 15;

                rect = new RectangleF(650, yPos, 100, 30);
                ev.Graphics.DrawRectangle(blackPen, 650, Convert.ToInt32(yPos), 100, 30);
                ev.Graphics.DrawString("Номер \r\n документа", new Font("Arial", 8), Brushes.Black, rect, center);
                rect = new RectangleF(750, yPos, 116, 30);
                ev.Graphics.DrawRectangle(blackPen, 750, Convert.ToInt32(yPos), 116, 30);
                ev.Graphics.DrawString("Дата составления", new Font("Arial", 8), Brushes.Black, rect, center);
                yPos = yPos + 30;

                rect = new RectangleF(650, yPos, 100, 30);
                ev.Graphics.DrawRectangle(blackPen, 650, Convert.ToInt32(yPos), 100, 30);
                //Номер накладной  
                ev.Graphics.DrawString(_numdoc, new Font("Arial", 8), Brushes.Black, rect, center);
                rect = new RectangleF(750, yPos, 116, 30);
                ev.Graphics.DrawRectangle(blackPen, 750, Convert.ToInt32(yPos), 116, 30);
                //Дата накладной    
                ev.Graphics.DrawString(_datedoc, new Font("Arial", 8), Brushes.Black, rect, center);
                ev.Graphics.DrawString("ТОВАРНАЯ НАКЛАДНАЯ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 430,yPos+10,new StringFormat());
                yPos = yPos + 34;

                // ШАПКА НАЛАДНОЙ
                rect = new RectangleF(10, yPos, 46, 60);
                ev.Graphics.DrawRectangle(blackPen, 10, Convert.ToInt32(yPos), 46, 60);
                ev.Graphics.DrawString("Номер по порядку", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(56, yPos, 392, 30);
                ev.Graphics.DrawRectangle(blackPen, 56, Convert.ToInt32(yPos), 392, 30);
                ev.Graphics.DrawString("Товар", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(56, yPos+30, 344, 30);
                ev.Graphics.DrawRectangle(blackPen, 56, Convert.ToInt32(yPos+30), 344, 30);
                ev.Graphics.DrawString("наименование, характеристика, сорт, артикул товара", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(400, yPos + 30, 48, 30);
                ev.Graphics.DrawRectangle(blackPen, 400, Convert.ToInt32(yPos + 30), 48, 30);
                ev.Graphics.DrawString("код", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(448, yPos, 96, 30);
                ev.Graphics.DrawRectangle(blackPen, 448, Convert.ToInt32(yPos), 96, 30);
                ev.Graphics.DrawString("Единица измерения", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(448, yPos + 30, 48, 30);
                ev.Graphics.DrawRectangle(blackPen, 448, Convert.ToInt32(yPos + 30), 48, 30);
                ev.Graphics.DrawString("наиме-нование", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(496, yPos + 30, 48, 30);
                ev.Graphics.DrawRectangle(blackPen, 496, Convert.ToInt32(yPos + 30), 48, 30);
                ev.Graphics.DrawString("Код по ОКЕИ", new Font("Arial", 8), Brushes.Black, rect, center);
                
                rect = new RectangleF(544, yPos, 53, 60);
                ev.Graphics.DrawRectangle(blackPen, 544, Convert.ToInt32(yPos), 53, 60);
                ev.Graphics.DrawString("Вид упаковки", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(597, yPos, 100, 30);
                ev.Graphics.DrawRectangle(blackPen, 597, Convert.ToInt32(yPos), 100, 30);
                ev.Graphics.DrawString("Количество (масса)", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(597, yPos + 30, 56, 30);
                ev.Graphics.DrawRectangle(blackPen, 597, Convert.ToInt32(yPos + 30), 56, 30);
                ev.Graphics.DrawString("в одном месте", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(653, yPos + 30, 44, 30);
                ev.Graphics.DrawRectangle(blackPen, 653, Convert.ToInt32(yPos + 30), 44, 30);
                ev.Graphics.DrawString("мест, штук ", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(697, yPos, 57, 60);
                ev.Graphics.DrawRectangle(blackPen, 697, Convert.ToInt32(yPos), 57, 60);
                ev.Graphics.DrawString("Масса брутто", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(754, yPos, 48, 60);
                ev.Graphics.DrawRectangle(blackPen, 754, Convert.ToInt32(yPos), 48, 60);
                ev.Graphics.DrawString("Коли-чество (масса нетто)", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(802, yPos, 68, 60);
                ev.Graphics.DrawRectangle(blackPen, 802, Convert.ToInt32(yPos), 68, 60);
                ev.Graphics.DrawString("Цена руб. коп", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(870, yPos, 72, 60);
                ev.Graphics.DrawRectangle(blackPen, 870, Convert.ToInt32(yPos), 72, 60);
                ev.Graphics.DrawString("Сумма без учета НДС, руб. коп", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(942, yPos, 121, 30);
                ev.Graphics.DrawRectangle(blackPen, 942, Convert.ToInt32(yPos), 121, 30);
                ev.Graphics.DrawString("НДС ", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(942, yPos + 30, 46, 30);
                ev.Graphics.DrawRectangle(blackPen, 942, Convert.ToInt32(yPos + 30), 46, 30);
                ev.Graphics.DrawString("ставка,% ", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(988, yPos + 30, 75, 30);
                ev.Graphics.DrawRectangle(blackPen, 988, Convert.ToInt32(yPos + 30), 75, 30);
                ev.Graphics.DrawString("сумма, руб. коп ", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(1063, yPos, 70, 60);
                ev.Graphics.DrawRectangle(blackPen, 1063, Convert.ToInt32(yPos), 70, 60);
                ev.Graphics.DrawString("Сумма с учетом НДС, руб. коп ", new Font("Arial", 8), Brushes.Black, rect, center);
                yPos = yPos + 60;

                rect = new RectangleF(10, yPos, 46,15);
                ev.Graphics.DrawRectangle(blackPen, 10, Convert.ToInt32(yPos), 46,15);
                ev.Graphics.DrawString("1", new Font("Arial", 8), Brushes.Black, rect, center);

                
                rect = new RectangleF(56, yPos , 344, 15);
                ev.Graphics.DrawRectangle(blackPen, 56, Convert.ToInt32(yPos ), 344, 15);
                ev.Graphics.DrawString("2", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(400, yPos , 48, 15);
                ev.Graphics.DrawRectangle(blackPen, 400, Convert.ToInt32(yPos ), 48, 15);
                ev.Graphics.DrawString("3", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(448, yPos , 48, 15);
                ev.Graphics.DrawRectangle(blackPen, 448, Convert.ToInt32(yPos ), 48, 15);
                ev.Graphics.DrawString("4", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(496, yPos , 48, 15);
                ev.Graphics.DrawRectangle(blackPen, 496, Convert.ToInt32(yPos ), 48, 15);
                ev.Graphics.DrawString("5", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(544, yPos, 53,15);
                ev.Graphics.DrawRectangle(blackPen, 544, Convert.ToInt32(yPos), 53,15);
                ev.Graphics.DrawString("6", new Font("Arial", 8), Brushes.Black, rect, center);
            
                rect = new RectangleF(597, yPos , 56, 15);
                ev.Graphics.DrawRectangle(blackPen, 597, Convert.ToInt32(yPos ), 56,15);
                ev.Graphics.DrawString("7", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(653, yPos , 44, 15);
                ev.Graphics.DrawRectangle(blackPen, 653, Convert.ToInt32(yPos ), 44, 15);
                ev.Graphics.DrawString("8", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(697, yPos, 57,15);
                ev.Graphics.DrawRectangle(blackPen, 697, Convert.ToInt32(yPos), 57,15);
                ev.Graphics.DrawString("9", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(754, yPos, 48,15);
                ev.Graphics.DrawRectangle(blackPen, 754, Convert.ToInt32(yPos), 48,15);
                ev.Graphics.DrawString("10", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(802, yPos, 68,15);
                ev.Graphics.DrawRectangle(blackPen, 802, Convert.ToInt32(yPos), 68,15);
                ev.Graphics.DrawString("11", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(870, yPos, 72,15);
                ev.Graphics.DrawRectangle(blackPen, 870, Convert.ToInt32(yPos), 72,15);
                ev.Graphics.DrawString("12", new Font("Arial", 8), Brushes.Black, rect, center);

                
                rect = new RectangleF(942, yPos , 46, 15);
                ev.Graphics.DrawRectangle(blackPen, 942, Convert.ToInt32(yPos ), 46, 15);
                ev.Graphics.DrawString("13", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(988, yPos , 75, 15);
                ev.Graphics.DrawRectangle(blackPen, 988, Convert.ToInt32(yPos ), 75, 15);
                ev.Graphics.DrawString("14", new Font("Arial", 8), Brushes.Black, rect, center);

                rect = new RectangleF(1063, yPos, 70,15);
                ev.Graphics.DrawRectangle(blackPen, 1063, Convert.ToInt32(yPos), 70,15);
                ev.Graphics.DrawString("15", new Font("Arial", 8), Brushes.Black, rect, center);
                yPos = yPos + 15;
                int countTovar = 1;
                double summALL = 0;
           foreach (string row in GetNextRowVN())
            {
            //Товары, количество, цены , места
                string tovar = row;
                string kodt = tovar.Substring(0, tovar.IndexOf("\r\n"));
                tovar = tovar.Remove(0, kodt.Length+2);
                kodt = Regex.Replace(kodt, "[^0-9]", string.Empty);
                string namet = tovar.Substring(0, tovar.IndexOf("\r\n"));
                tovar = tovar.Remove(0, namet.Length+2);
                string zcena = tovar.Substring(0, tovar.IndexOf("\r\n"));
                tovar = tovar.Remove(0, zcena.Length+2);
                string qty = tovar;

                double zsumm = Convert.ToDouble(qty) * Convert.ToDouble(zcena);
                summALL = summALL + zsumm;
                rect = new RectangleF(10, yPos, 46, 28);
                ev.Graphics.DrawRectangle(blackPen, 10, Convert.ToInt32(yPos), 46, 28);
                ev.Graphics.DrawString(countTovar.ToString(), new Font("Arial", 8), Brushes.Black, rect, center);
            //наименование товара
            
                rect = new RectangleF(56, yPos, 344, 28);
                ev.Graphics.DrawRectangle(blackPen, 56, Convert.ToInt32(yPos), 344, 28);
                ev.Graphics.DrawString(namet, new Font("Arial", 8), Brushes.Black, rect, center);
            //Код товара
                rect = new RectangleF(400, yPos, 48, 28);
                ev.Graphics.DrawRectangle(blackPen, 400, Convert.ToInt32(yPos), 48, 28);
                ev.Graphics.DrawString(kodt, new Font("Arial", 8), Brushes.Black, rect, center);
            //Еденица измерения
                rect = new RectangleF(448, yPos, 48, 28);
                ev.Graphics.DrawRectangle(blackPen, 448, Convert.ToInt32(yPos), 48, 28);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
            //Код по ОКЕИ
                rect = new RectangleF(496, yPos, 48, 28);
                ev.Graphics.DrawRectangle(blackPen, 496, Convert.ToInt32(yPos), 48, 28);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
           // Вид упаковки		
		
	            rect = new RectangleF(544, yPos, 53, 28);
                ev.Graphics.DrawRectangle(blackPen, 544, Convert.ToInt32(yPos), 53, 28);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
           // Количество (масса)
                //в одном месте		
		        rect = new RectangleF(597, yPos, 56, 28);
                ev.Graphics.DrawRectangle(blackPen, 597, Convert.ToInt32(yPos), 56, 28);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
           //мест, штук
                rect = new RectangleF(653, yPos, 44, 28);
                ev.Graphics.DrawRectangle(blackPen, 653, Convert.ToInt32(yPos), 44, 28);
                ev.Graphics.DrawString(qty, new Font("Arial", 8), Brushes.Black, rect, center);
           //Масса брутто
                rect = new RectangleF(697, yPos, 57, 28);
                ev.Graphics.DrawRectangle(blackPen, 697, Convert.ToInt32(yPos), 57, 28);
                ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
           //Коли-чество (масса нетто
                rect = new RectangleF(754, yPos, 48, 28);
                ev.Graphics.DrawRectangle(blackPen, 754, Convert.ToInt32(yPos), 48, 28);
                ev.Graphics.DrawString(qty, new Font("Arial", 8), Brushes.Black, rect, center);
           //Цена руб. коп
                rect = new RectangleF(802, yPos, 68, 28);
                ev.Graphics.DrawRectangle(blackPen, 802, Convert.ToInt32(yPos), 68, 28);
                ev.Graphics.DrawString(zcena, new Font("Arial", 8), Brushes.Black, rect, center);
          //Сумма без учета НДС, руб. коп
                rect = new RectangleF(870, yPos, 72, 28);
                ev.Graphics.DrawRectangle(blackPen, 870, Convert.ToInt32(yPos), 72, 28);
                ev.Graphics.DrawString(zsumm.ToString(), new Font("Arial", 8), Brushes.Black, rect, center);
          //НДС 
             //ставка,% 

                rect = new RectangleF(942, yPos, 46, 28);
                ev.Graphics.DrawRectangle(blackPen, 942, Convert.ToInt32(yPos), 46, 28);
                ev.Graphics.DrawString("Без НДС", new Font("Arial", 8), Brushes.Black, rect, center);
             //сумма, руб. коп 
                rect = new RectangleF(988, yPos, 75, 28);
                ev.Graphics.DrawRectangle(blackPen, 988, Convert.ToInt32(yPos), 75, 28);
                ev.Graphics.DrawString("-", new Font("Arial", 8), Brushes.Black, rect, center);
             //Сумма с учетом НДС, руб. коп 
                rect = new RectangleF(1063, yPos, 70, 28);
                ev.Graphics.DrawRectangle(blackPen, 1063, Convert.ToInt32(yPos), 70, 28);
                ev.Graphics.DrawString(zsumm.ToString(), new Font("Arial", 8), Brushes.Black, rect, center);

                yPos = yPos + 28;
                countTovar++;
           }

   //Конец табличной части
          
            ev.Graphics.DrawString("Всего по накладной:", new Font("Arial", 8), Brushes.Black, 530,yPos, new StringFormat());

            //мест, штук
            rect = new RectangleF(653, yPos, 44, 20);
            ev.Graphics.DrawRectangle(blackPen, 653, Convert.ToInt32(yPos), 44, 20);
            ev.Graphics.DrawString((countTovar-1).ToString(), new Font("Arial", 8), Brushes.Black, rect, center);
            //Масса брутто
            rect = new RectangleF(697, yPos, 57, 20);
            ev.Graphics.DrawRectangle(blackPen, 697, Convert.ToInt32(yPos), 57, 20);
            ev.Graphics.DrawString("", new Font("Arial", 8), Brushes.Black, rect, center);
            //Коли-чество (масса нетто
            rect = new RectangleF(754, yPos, 48, 20);
            ev.Graphics.DrawRectangle(blackPen, 754, Convert.ToInt32(yPos), 48, 20);
            ev.Graphics.DrawString((countTovar-1).ToString(), new Font("Arial", 8), Brushes.Black, rect, center);
            //Цена руб. коп
            rect = new RectangleF(802, yPos, 68, 20);
            ev.Graphics.DrawRectangle(blackPen, 802, Convert.ToInt32(yPos), 68, 20);
            ev.Graphics.DrawString("X", new Font("Arial", 8), Brushes.Black, rect, center);
            //Сумма без учета НДС, руб. коп
            rect = new RectangleF(870, yPos, 72, 20);
            ev.Graphics.DrawRectangle(blackPen, 870, Convert.ToInt32(yPos), 72, 20);
            ev.Graphics.DrawString(summALL.ToString(), new Font("Arial", 8), Brushes.Black, rect, center);
            //НДС 
            //ставка,% 

            rect = new RectangleF(942, yPos, 46, 20);
            ev.Graphics.DrawRectangle(blackPen, 942, Convert.ToInt32(yPos), 46, 20);
            ev.Graphics.DrawString("X", new Font("Arial", 8), Brushes.Black, rect, center);
            //сумма, руб. коп 
            rect = new RectangleF(988, yPos, 75, 20);
            ev.Graphics.DrawRectangle(blackPen, 988, Convert.ToInt32(yPos), 75, 20);
            ev.Graphics.DrawString("X", new Font("Arial", 8), Brushes.Black, rect, center);
            //Сумма с учетом НДС, руб. коп 
            rect = new RectangleF(1063, yPos, 70, 20);
            ev.Graphics.DrawRectangle(blackPen, 1063, Convert.ToInt32(yPos), 70, 20);
            ev.Graphics.DrawString(summALL.ToString(), new Font("Arial", 8), Brushes.Black, rect, center);

            yPos = yPos + 25;

            ev.Graphics.DrawString("Товарная накладная имеет приложение на", new Font("Arial", 8), Brushes.Black, 10, yPos, new StringFormat());
            ev.Graphics.DrawLine(blackPen, new PointF(250, yPos + 10), new PointF(750, yPos + 10));
            ev.Graphics.DrawString("листах", new Font("Arial", 8), Brushes.Black, 760, yPos, new StringFormat());
            
            yPos = yPos + 15;

            ev.Graphics.DrawString("и содержит", new Font("Arial", 8), Brushes.Black, 10, yPos, new StringFormat());
            ev.Graphics.DrawLine(blackPen, new PointF(100, yPos + 10), new PointF(750, yPos + 10));
            ev.Graphics.DrawString("порядковых номеров записей", new Font("Arial", 8), Brushes.Black, 760, yPos, new StringFormat());
            ev.Graphics.DrawString("прописью", new Font("Arial", 7), Brushes.Black, 400, yPos + 10, new StringFormat());

            yPos = yPos + 26;

            ev.Graphics.DrawString("Масса груза (нетто) ", new Font("Arial", 8), Brushes.Black,400, yPos, new StringFormat());
            ev.Graphics.DrawLine(blackPen, new PointF(520, yPos + 10), new PointF(815, yPos + 10));
            ev.Graphics.DrawString("прописью", new Font("Arial", 7), Brushes.Black, 600, yPos + 10, new StringFormat());

            yPos = yPos + 26;

            ev.Graphics.DrawString("Всего мест ", new Font("Arial", 8), Brushes.Black, 20, yPos, new StringFormat());
            ev.Graphics.DrawLine(blackPen, new PointF(90, yPos + 10), new PointF(380, yPos + 10));
            ev.Graphics.DrawString("прописью", new Font("Arial", 7), Brushes.Black, 200, yPos + 10, new StringFormat());

            ev.Graphics.DrawString("Масса груза (брутто) ", new Font("Arial", 8), Brushes.Black, 400, yPos, new StringFormat());
            ev.Graphics.DrawLine(blackPen, new PointF(520, yPos + 10), new PointF(815, yPos + 10));
            ev.Graphics.DrawString("прописью", new Font("Arial", 7), Brushes.Black, 600, yPos + 10, new StringFormat());

            rect = new RectangleF(830, yPos-24, 290, 46);
            ev.Graphics.DrawRectangle(new Pen(Color.Black, 2), 830, yPos - 24, 290, 46);
            ev.Graphics.DrawLine(blackPen, new PointF(830, yPos), new PointF(830+290, yPos));
            


        }

        /// <summary>
        /// Этот простой на вид метод немного непривычен
        /// он запускается каждый раз, когда его вызывают и каждый раз возвращает следующую строку из таблицы
        /// </summary>
        /// <returns>строковое представление строки таблицы</returns>
        private IEnumerable <string> GetNextRow() 
        {
            for (; iterPrintRow < _dataTable.Rows.Count; iterPrintRow++)
            {
                DataRow row = _dataTable.Rows[iterPrintRow];
                // здесь мы DataRow превращаем в строку, как хочешь, так и форматируй
                //yield return row[0] + "    " + row[1] + "    " + row[2] + "    " + row[3] + "    " + row[4];
                yield return row[0] + " " + row[1] + " " + row[2];
            }
        }
        private IEnumerable<string> GetNextRowVN()
        {
            for (; iterPrintRow < _dataTable.Rows.Count; iterPrintRow++)
            {
                DataRow row = _dataTable.Rows[iterPrintRow];
                // здесь мы DataRow превращаем в строку, как хочешь, так и форматируй
                //yield return row[0] + "    " + row[1] + "    " + row[2] + "    " + row[3] + "    " + row[4];
                yield return row[0] + "\r\n" + row[1] + "\r\n" + row[2] + "\r\n" + row[3];
            }
        }

        private IEnumerable<string> GetNextRowChek()
        {
            
            for (; iterPrintRow < _dataTable.Rows.Count; iterPrintRow++)
            {
                DataRow rowNameT = _dataTable.Rows[iterPrintRow];
                DataRow rowCountT = _dataTable.Rows[iterPrintRow];
                DataRow rowCenaT = _dataTable.Rows[iterPrintRow];
                DataRow rowSummT = _dataTable.Rows[iterPrintRow];
                
                
                //// здесь мы DataRow превращаем в строку, как хочешь, так и форматируй
                ////yield return row[0] + "    " + row[1] + "    " + row[2] + "    " + row[3] + "    " + row[4];
                yield return rowNameT[0] + "";//row[0] + " " + 
                yield return rowCenaT[2] + " X " + rowCountT[1];
                yield return rowSummT[3]+"";//"Сумма: "+
                //yield return String.Format("{0, -25} {1}", "Стоимость", rowSummT[3].ToString());//.ToString().PadLeft(19,'.');
            }
        }
        private IEnumerable<string> GetNextRowEan()
        {
            for (; iterPrintRow < _dataTable.Rows.Count; iterPrintRow++)
            {
                DataRow row = _dataTable.Rows[iterPrintRow];
                DataRow rowEan = _dataTable.Rows[iterPrintRow];
                // здесь мы DataRow превращаем в строку, как хочешь, так и форматируй
                //yield return row[0] + "    " + row[1] + "    " + row[2] + "    " + row[3] + "    " + row[4];
                yield return row[0] + " -- " + row[1] + " -- " + row[2]+" р.";
                yield return " !" + row[3] + "!";
            }
        }
    }
}