using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagbaseServer
{
    class logger
    {
        public void logwrite(string message, Exception exp)
        {
            if (!(Directory.Exists(Application.StartupPath + "\\Log")))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Log");
                if ((Directory.Exists(Application.StartupPath + "\\Log")))
                {
                    using (StreamWriter file = new StreamWriter(Application.StartupPath + "\\Log\\log-" + DateTime.Now.ToShortDateString(), true))
                    {
                        file.WriteLine(DateTime.Now);
                        file.WriteLine(message);
                        file.WriteLine("Метод: " + exp.TargetSite);
                        file.WriteLine("Приложение/Объект: " + exp.Source);
                        file.WriteLine("Экземпляр класса: " + exp.InnerException);
                        file.WriteLine("Стек вызова: " + exp.StackTrace);
                        file.WriteLine("?: " + exp.Data);
                        file.WriteLine("--------------------------------------------------------------------------------------");
                    }
                }
            }
            else
            {
                using (StreamWriter file = new StreamWriter(Application.StartupPath + "\\Log\\log-"+DateTime.Now.ToShortDateString() , true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(message);
                    file.WriteLine("Метод: "+exp.TargetSite);
                    file.WriteLine("Приложение/Объект: " + exp.Source);
                    file.WriteLine("Экземпляр класса: " + exp.InnerException);
                    file.WriteLine("Стек вызова: " + exp.StackTrace);
                    file.WriteLine("?: " + exp.Data);
                    file.WriteLine("--------------------------------------------------------------------------------------");
                }
            }
        }
    }
}
