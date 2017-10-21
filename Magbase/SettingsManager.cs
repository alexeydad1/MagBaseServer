using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class SettingsBase
    {
        // Свойство название базы
        public String bdname { get; set; }
        // Свойство путь базы
        public String bdpath { get; set; }
        // Свойство пароль к базе
        public String password { get; set; }

        // Конструктор класса
        public SettingsBase(string bdname, string bdpath, string password)
        {
            this.bdname = bdname; this.bdpath = bdpath; this.password = password;
        }

    }

    public class SettingsManager
    {
        // Путь к файлу, в котором будут наши настройки
        private string fileName = "settings.conf";

        // Конструктор
        public SettingsManager() { }

        // Метод сохранения настроек в файл
        public void Save(SettingsBase settings)
        {
            try
            {
                // Создаем объект класса, который будет производить запись в файл
                using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create)))
                {
                    // Записываем строку (наш емейл)
                    sw.WriteLine(Crypt(settings.bdname));
                    // Записываем строку (наш пароль)
                    sw.WriteLine(Crypt(settings.bdpath));
                    // Закрываем писатель
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Метод загрузки настроек из файла
        public SettingsBase Load()
        {
            try
            {
                // Проверка на существование файла
                if (File.Exists(fileName))
                {
                    // Создадим объект класса пустой, который мы потом заполним данными при загрузке
                    SettingsBase rtnSetting = new SettingsBase("", "","");
                    // Создаем объект класса, который будет читать наш файл настроек
                    using (StreamReader sr = new StreamReader(File.Open(fileName, FileMode.Open)))
                    {
                        // Читаем 1ую строку, а именно емейл
                        rtnSetting.bdname = Crypt(sr.ReadLine());
                        // Читаем 2ую строку, а именно пароль
                        rtnSetting.bdpath = Crypt(sr.ReadLine());
                        // Закрываем читатель
                        sr.Close();
                    }
                    // Возваращаем объект класса настроек после удачного прочтения
                    return rtnSetting;
                }
                // Возвращаем ничего, если файла не существует
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Возвращаем ничего, если произошла ошибка
                return null;
            }
        }
        // Метод шифрующий входящую строку
        private string Crypt(string text)
        {
            // Создаем строку, которую будет возвращать
            string rtnStr = string.Empty;
            // В цикле перебираем каждый символ входящей строки
            foreach (char c in text)
            {
                // Добавляем в возвращаемую строку наш переработанный символ
                // (int)c - переводи символ в его код
                // ((int) c ^ 52) - применение XOR к номеру символа
                // (char)((int) c ^ 52) - получаем символ из измененного номера
                // Число, которым мы XORим можете поставить любое. Эксперементируйте.
                rtnStr += (char)((int)c ^ 52);
            }
            return rtnStr;
        }
    }

}
