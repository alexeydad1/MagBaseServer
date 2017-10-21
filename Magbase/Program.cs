using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace MagbaseServer
{
    
    public static class CallBackMy
    {
        public delegate void callbackEventPform(string what);
        public static callbackEventPform callbackEventHandlerPform;

        public delegate void callbackEventTform(string what);
        public static callbackEventTform callbackEventHandlerTform;

        public delegate void callbackEventRform(string what);
        public static callbackEventRform callbackEventHandlerRform;

        public delegate void callbackEventRformImport(string kod,double what);
        public static callbackEventRformImport callbackEventHandlerRformImport;

        public delegate void callbackEventPereocenkaform(string what);
        public static callbackEventPereocenkaform callbackEventHandlerPereocenkaform;

        public delegate void callbackEventReportMoveGoodsform(string what,string name);
        public static callbackEventReportMoveGoodsform callbackEventHandlerReportMoveGoodsform;

        public delegate void callbackEventFormOpen(Form mdiChild);
        public static callbackEventFormOpen callbackEventHandlerFormOpen;

        public delegate void callbackEventProgressBar(int Max,int Now,string info);
        public static callbackEventProgressBar callbackEventHandlerProgressBar;

          
    }
    static class Program
    {
        
       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sform());
        }
    }
}
