using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using XMLFileSettings;
using AESEncryption;
using System.Net.NetworkInformation;
using System.Threading;
using MagbaseServer.Properties;
using System.Runtime.InteropServices;
using System.Net;
using System.Data.SQLite;


namespace MagbaseServer
{
    public partial class Sform : Form
    {
        logger _Log = new logger();
        sqldb _SQl = new sqldb();
        #region Settings action
        XMLFileSettings.Props props = new XMLFileSettings.Props(); //экземпляр класса с настройками 
        //Запись настроек
       

        //Чтение настроек
        private void readSetting()
        {
                props.ReadXml();

                basename = props.Fields.basename;
                Sform.pathDB = AESEncryption.XSecurityAES.Decrypt(props.Fields.basepath, "Magbase", "Alexey", "SHA1", 2, "123456789Qwerty", 256);
                //if (!(File.Exists(_SQl.ExecuteSQLpathDB)))
                //{
                //    MessageBox.Show("База данных не найдена, укажите путь к базе данной", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    OFDBasepathS.ShowDialog();
                //    return;
                //}
                Sform.passwordDB = AESEncryption.XSecurityAES.Decrypt(props.Fields.password, "Magbase", "Alexey", "SHA1", 2, "123456789Qwerty", 256);
            
        }
        private void writeSetting()
        {
            props.Fields.basename = Sform.basename;
            props.Fields.basepath = AESEncryption.XSecurityAES.Encrypt(Sform.pathDB, "Magbase", "Alexey", "SHA1", 2, "123456789Qwerty", 256); 
            props.WriteXml();

        }
        #endregion
        static public int flagServerStart = 0;
        static public int frmNotNull = 0;
        static public string ownerFormName = "";// Кто открыл форму
        // Уровень доступа
        static public int id_access = 0;
        static public string user_bd = "";
        static public int id_users = 0;
        // переменные данные для БД
        static public string basename = "";
        //Минимальная наценка
        //static public double min_margin=0;
        // переменные номер чека,префикс кода,документов расход приход, еан магазинный,юр лицо
        //static public int chek_load = 0;
        //static public string pref_kod = "";
        //static public string pref_dok_prihod = "";
        //static public string pref_dok_rashod = "";
        //static public string ean_mag = "";
        //static public int kod_mag = 0;
        //static public int number_dok_rashod = 0;
        //static public int number_dok_prihod = 0;
        //Адрес и реквизиты
        static public string urliconame = "";
        static public string ogrn = "";
        static public string inn = "";
        static public string city = "";
        static public string indexcity = "";
        static public string street = "";
        static public string dom = "";
        static public string stroenie = "";
        static public string litera = "";
        static public string fullAdress = "";
        // Принтеры
        static public string NamePrinterChek = "";
        static public string NamePrinterDok = "";
        //Отправка базы по email
        static public string SMTPMail = "";
        static public string LoginMail = "";
        static public string PassMail = "";
        static public string ToMail = "";
        static public string SubMail = "";
        static public string BodyMail = "";
        static public string Attach = "";
        static public int TimerMail = 0;
        // IP и Port Server Client
        static public string ServerIP = "";
        static public string ServerPort = "";
        static public string ClientIP = "";
        static public string ClientPort = "";
        //База данных
        static public string passwordDB = "";
        static public string pathDB = "";

        public delegate void ChangeStatusDelegate(string message);
       
        //-------------------------------------------
        private const byte VK_SCROLL = 0x91;
        private const byte VK_NUMLOCK = 0x90;
        private const byte VK_CAPITAL = 0x14;
        private const uint KEYEVENTF_KEYUP = 0x2;
 

        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
 
        [DllImport("user32.dll", EntryPoint = "GetKeyState", SetLastError = true)]
        static extern short GetKeyState(uint nVirtKey);
        //Scroll-------------------------------------------------------
        public static void SetScrollLockKey(bool newState)
        {
            bool scrollLockSet = GetKeyState(VK_SCROLL) != 0;
            if (scrollLockSet != newState)
            {
                keybd_event(VK_SCROLL, 0, 0, 0);
                keybd_event(VK_SCROLL, 0, KEYEVENTF_KEYUP, 0);
            }
        }
        public static bool GetScrollLockState()
        {
            return GetKeyState(VK_SCROLL) != 0;
        }
        //NUM-------------------------------------------------------
        public static void SetNumLockKey(bool newState)
        {
            bool scrollLockSet = GetKeyState(VK_NUMLOCK) != 0;
            if (scrollLockSet != newState)
            {
                keybd_event(VK_NUMLOCK, 0, 0, 0);
                keybd_event(VK_NUMLOCK, 0, KEYEVENTF_KEYUP, 0);
            }
        }
 
        public static bool GetNumLockState()
        {
            return GetKeyState(VK_NUMLOCK) != 0;
        }
        //Caps-------------------------------------------------------
        public static void SetCapsLockKey(bool newState)
        {
            bool scrollLockSet = GetKeyState(VK_NUMLOCK) != 0;
            if (scrollLockSet != newState)
            {
                keybd_event(VK_CAPITAL, 0, 0, 0);
                keybd_event(VK_CAPITAL, 0, KEYEVENTF_KEYUP, 0);
            }
        }
 
        public static bool GetCapsLockState()
        {
            return GetKeyState(VK_CAPITAL) != 0;
        }

       
        private void statusNetsON(string message)
        {
            statusNet.Text = message;
            statusNet.Image = Properties.Resources.connect_creating_7660;
            this.statusStrip.Refresh();
        }
        private void statusNetsOFF(string message)
        {
            statusNet.Text = message;
            statusNet.Image = Properties.Resources.stock_disconnect_5843;
            this.statusStrip.Refresh();
          
        }
     
        private void load_source()
        {
            
            string Sqlload_source = "select * from Source";
            DataTable load_sourceTable = _SQl.ExecuteSQL(Sqlload_source);

            if (load_sourceTable.Rows.Count == 0)
            {
                MessageBox.Show("Заполните первичные данные, в меню ''Основные настройки''!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //chek_load = Convert.ToInt32(load_sourceTable.Rows[0][0].ToString());
            //pref_kod = load_sourceTable.Rows[0][1].ToString();
            //pref_dok_prihod = load_sourceTable.Rows[0][2].ToString();
            //pref_dok_rashod = load_sourceTable.Rows[0][3].ToString();
            //ean_mag = load_sourceTable.Rows[0][4].ToString();
            //kod_mag = Convert.ToInt32(load_sourceTable.Rows[0][6].ToString());
            //number_dok_rashod = Convert.ToInt32(load_sourceTable.Rows[0][7].ToString());
            //number_dok_prihod = Convert.ToInt32(load_sourceTable.Rows[0][8].ToString());
            //min_margin = Convert.ToDouble(load_sourceTable.Rows[0][9].ToString());

            urliconame = load_sourceTable.Rows[0][5].ToString();
            ogrn = load_sourceTable.Rows[0][10].ToString();
            inn = load_sourceTable.Rows[0][11].ToString();
            city = load_sourceTable.Rows[0][23].ToString();
            indexcity = load_sourceTable.Rows[0][12].ToString();
            street = load_sourceTable.Rows[0][13].ToString();
            dom = load_sourceTable.Rows[0][14].ToString();
            stroenie = load_sourceTable.Rows[0][15].ToString();
            litera = load_sourceTable.Rows[0][16].ToString();


            NamePrinterChek = load_sourceTable.Rows[0][21].ToString();
            NamePrinterDok = load_sourceTable.Rows[0][22].ToString();

            if (indexcity != "")
            {
                fullAdress = indexcity;
            }
            if (city != "")
            {
                fullAdress += ",г. " + city;
            }
            if (street != "")
            {
                fullAdress += "," + street;
            }
            if (dom != "")
            {
                fullAdress += "," + dom;
            }
            if (stroenie != "")
            {
                fullAdress += "," + stroenie;
            }
            if (litera != "")
            {
                fullAdress += "," + litera;
            }

            

            SMTPMail = load_sourceTable.Rows[0][24].ToString();
            LoginMail = load_sourceTable.Rows[0][25].ToString();
            PassMail = load_sourceTable.Rows[0][26].ToString();
            ToMail = load_sourceTable.Rows[0][27].ToString();
            SubMail = load_sourceTable.Rows[0][28].ToString();
            BodyMail = load_sourceTable.Rows[0][29].ToString();
            Attach = load_sourceTable.Rows[0][30].ToString();
            
            ServerIP = load_sourceTable.Rows[0][32].ToString();
            ServerPort = load_sourceTable.Rows[0][33].ToString();
            ClientIP = load_sourceTable.Rows[0][34].ToString();
            ClientPort = load_sourceTable.Rows[0][35].ToString();


            if (load_sourceTable.Rows[0][31].ToString() == "")
            {
                TimerMail = 0;
            }
            else
            {
                TimerMail = Convert.ToInt16(load_sourceTable.Rows[0][31].ToString());
            }
            if (TimerMail != 0)
            {
                TimerSentMail.Interval = (TimerMail * 60) * 1000;
                TimerSentMail.Enabled = true;
            }
        }
        public void access_users(int id_access)
        {
            if (id_access == 0)
            {
             
                menuStrip1.Enabled = true;

            }
            if (id_access == 1)
            {
                menuStrip1.Enabled = true;
                menuStrip1.Items[3].Enabled = false;
                menuStrip1.Items[4].Enabled = false;
                menuStrip1.Items[6].Enabled = false;
            }
        }
        public Sform()
        {
            CallBackMy.callbackEventHandlerFormOpen = new CallBackMy.callbackEventFormOpen(this.AttachAsMDIChild);
            CallBackMy.callbackEventHandlerProgressBar = new CallBackMy.callbackEventProgressBar(this.ProgressBarStStrip);
            
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(Numlock);
            this.KeyUp += new KeyEventHandler(CAPS);
            this.KeyUp += new KeyEventHandler(SCRL);
        }
        private void Numlock(object sender, KeyEventArgs e)
        {
            // Если фокус в штрихкод то выполняе действия
            if (GetNumLockState())
            {
                tSSlblNUM.Text = "NUM";
                this.statusStrip.Refresh();
            }
            else
            {
                tSSlblNUM.Text = "";
                this.statusStrip.Refresh();
            }
            
        }

        private void CAPS(object sender, KeyEventArgs e)
        {
            // Если фокус в штрихкод то выполняе действия
            if (GetCapsLockState())
            {
                tSSlblCAPS.Text = "CAPS";
                this.statusStrip.Refresh();
            }
            else
            {
                tSSlblCAPS.Text = "";
                this.statusStrip.Refresh();
            }

        }

        private void SCRL(object sender, KeyEventArgs e)
        {
            // Если фокус в штрихкод то выполняе действия
            if (GetScrollLockState())
            {
                tSSSCRL.Text = "SCRL";
                this.statusStrip.Refresh();
            }
            else
            {
                tSSSCRL.Text = "";
                this.statusStrip.Refresh();
            }

        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void торговляToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name== "Tform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }
            
        // Запускаем форму если она не запущена
             
                Form Tform = new Tform();
                //скрываем форму из панели задач
                //secondForm.ShowInTaskbar = false;
                //устанавливаем форму по центру экрана
                Tform.StartPosition = FormStartPosition.CenterScreen;
                Tform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                Tform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Tform.Show();
                AttachAsMDIChild(Tform);
               
         
        }

    
   

        //private void приемкаToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void классификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
                                
            
            // проверяем не запущена ли форма 
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "Classform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }

            }

            // Запускаем форму если она не запущена
                Form Classform = new Classform();
                Classform.StartPosition = FormStartPosition.CenterScreen;
                //указываем владельца для формы
                Classform.WindowState = FormWindowState.Maximized;
                Classform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Classform.Show();
                AttachAsMDIChild(Classform);
            

        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // проверяем не запущена ли форма                  
           
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "Tovarform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }
            
        // Запускаем форму если она не запущена
             Form Tovarform = new Tovarform();
                Tovarform.StartPosition = FormStartPosition.CenterScreen;
                Tovarform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                Tovarform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Tovarform.Show();
                AttachAsMDIChild(Tovarform);
        
        }

        private void группыТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "Groupform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }
            
        // Запускаем форму если она не запущена
                Form Groupform = new Groupform();
                Groupform.StartPosition = FormStartPosition.CenterScreen;
                Groupform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                Groupform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Groupform.Show();
                AttachAsMDIChild(Groupform);
        }

        private void торговаяМаркаToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "Brandform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }
            
        // Запускаем форму если она не запущена
                Form Brandform = new Brandform();
                Brandform.StartPosition = FormStartPosition.CenterScreen;
                Brandform.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                Brandform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                Brandform.Show();
                AttachAsMDIChild(Brandform);
        }

        private void Sform_Load(object sender, EventArgs e)
        {

            ChekBase chbd = new ChekBase();

            DirectoryInfo dirapp = new DirectoryInfo(Application.StartupPath);
            FileInfo[] fapp = dirapp.GetFiles("*.db");
            if (fapp.Length == 0)
            {
               DialogResult result=MessageBox.Show("Файл базы данных отсутствует!"+Environment.NewLine+" Вы хотите создать новую базу данных?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
               {
                   try
                   {
                       Sform.basename = "magbase.db";
                       Sform.pathDB = Application.StartupPath + "\\" + Sform.basename;
                       writeSetting();
                       
                       chbd.chek_fields();
                       _SQl.SQL_Query("INSERT INTO Access_bd VALUES(0,'Администратор')");
                       _SQl.SQL_Query("INSERT INTO Access_bd VALUES(1,'Пользователь')");
                       _SQl.SQL_Query("INSERT INTO Users VALUES(1,'Админ','12345',0)");
                       _SQl.SQL_Query("INSERT INTO Source (chek,"+
                                                           "pref_kod,"+
                                                           "pref_dok_prihod,"+
                                                            "pref_dok_rashod,"+
                                                            "ean_mag,"+
                                                            "urliconame,"+
                                                            "kod_mag,"+
                                                            "number_dok_rashod,"+
                                                            "number_dok_prihod,"+
                                                            "min_margin,"+
                                                            "ogrn,"+
                                                            "inn,"+
                                                            "index_city,"+
                                                            "street,"+
                                                            "dom,"+
                                                            "stroenie,"+
                                                            "litera,"+
                                                            "PrefVesEan,"+
                                                            "PLUcount,"+
                                                            "EAnCount,"+
                                                            "PLUkodnum,"+
                                                            "PrinterChek,"+
                                                            "PrinterDok,"+
                                                            "City,"+
                                                            "SMTP,"+
                                                            "LoginMail,"+
                                                            "PassMail,"+
                                                            "ToMail,"+
                                                            "SubMail,"+
                                                            "BodyMail,"+
                                                            "AttachMail,"+
                                                            "TimerTime,"+
                                                            "ServerIP,"+
                                                            "ServerPort,"+
                                                            "ClientIP,"+
                                                            "ClientPort,"+
                                                            "Cash)"+
                                                   "VALUES(1,"+
                                                          "'pi',"+
                                                          "'ПР',"+
                                                          "'РХ',"+
                                                          "'1234567890001',"+
                                                          "'ИП Иванов И.И.',"+
                                                          "1,"+
                                                          "1,"+
                                                          "1,"+
                                                          "100,"+
                                                          "123456789012345,"+
                                                          "123456789012,"+
                                                          "198000,"+
                                                          "'ул.Ивановская',"+
                                                          "33,"+
                                                          "'корп.1',"+
                                                          "'а',"+
                                                          "'22',"+
                                                          "'5',"+
                                                          "'13',"+
                                                          "1,"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "'Санкт-Петербург',"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "'127.0.0.1',"+
                                                          "'8060',"+
                                                          "'0',"+
                                                          "'0',"+
                                                          "0)");
                                        
                       Application.Exit();
                       return;
                   }
                   catch (Exception ex)
                   {
                      
                       //Program.log.Error("Ошибка выполнения запроса: " + ex.Message);
                       _Log.logwrite("Ошибка создания базы данных" + Environment.NewLine
                                       + ex.Message, ex);
                       MessageBox.Show("Ошибка создания базы данных" + Environment.NewLine + ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       Application.Exit();
                       return;
                   }
                   
               }
               else
               {
                   Application.Exit();
                   return;
               }

            }

            if (!(File.Exists(props.Fields.XMLFileName)))
            {
                MessageBox.Show("Файл настроек отсутствует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                return;

            }

            readSetting();
            
            chbd.chek_fields();

            load_source();


            if (GetNumLockState())
            {
                tSSlblNUM.Text = "NUM";
                this.statusStrip.Refresh();
            }
            if (GetScrollLockState())
            {
                tSSSCRL.Text = "SCRL";
                this.statusStrip.Refresh();
            }
            if (GetCapsLockState())
            {
                tSSlblCAPS.Text = "CAPS";
                this.statusStrip.Refresh();
            }

            
            Thread netchek = new Thread(cheknet);
            netchek.IsBackground = true;
            netchek.Start();

            timerDateTime.Interval = 1000;
            timerDateTime.Enabled = true;
            
            
           

            Form entryform = new entryform();
            //скрываем форму из панели задач
            //secondForm.ShowInTaskbar = false;
            //устанавливаем форму по центру экрана
            entryform.StartPosition = FormStartPosition.CenterScreen;
            //entryform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            entryform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            entryform.Show();

            //for (int x = 0; x < this.MdiChildren.Length; x++)
            //{
            //    if (this.MdiChildren[x].Name == "entryform")
            //    {
            //        this.MdiChildren[x].Focus();
            //        return;
            //    }
            //}
            
       
        }

        private void приходныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
             // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "GurnalPrihod")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }
            
        // Запускаем форму если она не запущена
                Form GurnalPrihod = new GurnalPrihod();
                GurnalPrihod.StartPosition = FormStartPosition.CenterScreen;
                GurnalPrihod.WindowState = FormWindowState.Maximized;
                //указываем владельца для формы
                GurnalPrihod.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
                GurnalPrihod.Show();
                AttachAsMDIChild(GurnalPrihod);
            
        }

    
        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void мозайкойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void расположитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void реквизитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "Osnovasetform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form Osnovasetform = new Osnovasetform();
            Osnovasetform.StartPosition = FormStartPosition.CenterScreen;
            Osnovasetform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Osnovasetform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Osnovasetform.Show();
            AttachAsMDIChild(Osnovasetform);
        }

        private void расходныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "GurnalRashod")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form GurnalRashod = new GurnalRashod();
            GurnalRashod.StartPosition = FormStartPosition.CenterScreen;
            GurnalRashod.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            GurnalRashod.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            GurnalRashod.Show();
            AttachAsMDIChild(GurnalRashod);
            
        }

       

        private void отчетПоПродажамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "ReportSalesform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form ReportSalesform = new ReportSalesform();
            ReportSalesform.StartPosition = FormStartPosition.CenterScreen;
            ReportSalesform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            ReportSalesform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            ReportSalesform.Show();
            AttachAsMDIChild(ReportSalesform);
            
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "Supform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form Supform = new Supform();
            Supform.StartPosition = FormStartPosition.CenterScreen;
            Supform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Supform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Supform.Show();
            AttachAsMDIChild(Supform);
            
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "Usersform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form Usersform = new Usersform();
            Usersform.StartPosition = FormStartPosition.CenterScreen;
            Usersform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Usersform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Usersform.Show();
            AttachAsMDIChild(Usersform);
            
        }

        private void Sform_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if ( frmNotNull== 1)
            //{
            //    frmNotNull = 0;
            //    e.Cancel = true;
            //    return;
            //}
            if (e.CloseReason.ToString() == "UserClosing")
            {

                DialogResult Close_form = MessageBox.Show("Вы действительно хотите закрыть Программу ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Close_form == DialogResult.No)
                {
                    e.Cancel = true;
                    return;

                }
                else
                {
                    Application.Exit();
                }
            }

        }

        private void отчетПоДоходностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "ReportCashIncomeform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form ReportCashIncomeform = new ReportCashIncomeform();
            ReportCashIncomeform.StartPosition = FormStartPosition.CenterScreen;
            ReportCashIncomeform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            ReportCashIncomeform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            ReportCashIncomeform.Show();
            AttachAsMDIChild(ReportCashIncomeform);
            
        }

   

        private void переоценкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "GurnalPereocenkiform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form GurnalPereocenkiform = new GurnalPereocenkiform();
            GurnalPereocenkiform.StartPosition = FormStartPosition.CenterScreen;
            GurnalPereocenkiform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            GurnalPereocenkiform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            GurnalPereocenkiform.Show();
            AttachAsMDIChild(GurnalPereocenkiform);
           
        }

        private void отчетПоВесовымТоварамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "Pluexpform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form Pluexpform = new Pluexpform();
            Pluexpform.StartPosition = FormStartPosition.CenterScreen;
            Pluexpform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            Pluexpform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            Pluexpform.Show();
            AttachAsMDIChild(Pluexpform);
        }

        private void отчетПоДвижениюТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // проверяем не запущена ли форма                  
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (this.MdiChildren[x].Name == "ReportMoveGoodsform")
                {
                    this.MdiChildren[x].Focus();
                    return;
                }
            }

            // Запускаем форму если она не запущена
            Form ReportMoveGoodsform = new ReportMoveGoodsform();
            ReportMoveGoodsform.StartPosition = FormStartPosition.CenterScreen;
            ReportMoveGoodsform.WindowState = FormWindowState.Maximized;
            //указываем владельца для формы
            ReportMoveGoodsform.MdiParent = this;  // где containerInstance - это экземпляр контейнера или указатель на MainForm
            ReportMoveGoodsform.Show();
            AttachAsMDIChild(ReportMoveGoodsform);
            
        }

        private void TimerSentMail_Tick(object sender, EventArgs e)
        {
            Zip.sentzip(basename);
        }
        
        public void AttachAsMDIChild(Form mdiChild)
        {
            mdiChild.MdiParent = this;
            mdiChild.Closing += new CancelEventHandler(mdiChild_Closed);

            int countItem = окнаToolStripMenuItem.DropDownItems.Count;

            if (countItem > 4)
            {
                while (окнаToolStripMenuItem.DropDownItems.Count != 4)
                {
                    окнаToolStripMenuItem.DropDownItems.RemoveAt(окнаToolStripMenuItem.DropDownItems.Count - 1);
                }

            }

            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (x == this.MdiChildren.Length - 1)
                {
                    окнаToolStripMenuItem.DropDownItems.Add(this.MdiChildren[x].Text, Properties.Resources.cheked_ico);
                }

                else
                {
                    окнаToolStripMenuItem.DropDownItems.Add(this.MdiChildren[x].Text);
                }

            }

        }
        public void mdiChild_Closed(object sender, CancelEventArgs e)
        {
            Form mdiChild = (Form)sender;
            string namef = mdiChild.Text;
            int countItem = окнаToolStripMenuItem.DropDownItems.Count;



            if (countItem > 4)
            {
                while (окнаToolStripMenuItem.DropDownItems.Count != 4)
                {
                    окнаToolStripMenuItem.DropDownItems.RemoveAt(окнаToolStripMenuItem.DropDownItems.Count - 1);
                }

            }

            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                if (namef != this.MdiChildren[x].Text)
                {
                    окнаToolStripMenuItem.DropDownItems.Add(this.MdiChildren[x].Text);
                    if (x == this.MdiChildren.Length - 1)
                    {
                        окнаToolStripMenuItem.DropDownItems[MdiChildren.Length + 2].Image = Properties.Resources.cheked_ico;
                        this.MdiChildren[MdiChildren.Length-1].Focus();
                    }
                }
                else
                {
                    if (x == this.MdiChildren.Length - 1)
                    {
                        окнаToolStripMenuItem.DropDownItems[MdiChildren.Length + 2].Image = Properties.Resources.cheked_ico;
                        this.MdiChildren[MdiChildren.Length-1].Focus();
                    }
                }

            }
            
        }


        private void окнаToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string WindowName=e.ClickedItem.Text;
            for (int i = 0; i < окнаToolStripMenuItem.DropDownItems.Count; i++)
            {
                окнаToolStripMenuItem.DropDownItems[i].Image = null;
            }

               
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                
                if (this.MdiChildren[x].Text == WindowName)
                {
                    this.MdiChildren[x].Focus();
                    e.ClickedItem.Image = Properties.Resources.cheked_ico;
                   
                }
            }
        }

        private void ProgressBarStStrip(int Max,int Now,string info)
        {
           
            tSSPbar.Minimum = 0;
            tSSPbar.Maximum = Max;
            tSSPbar.Value = Now;

            if (tSSPbar.Value == tSSPbar.Maximum - 1)
            {
                tSSlblIfo.Text = "Готово";
                tSSPbar.Value = 0;
            }
            else
            {
                tSSlblIfo.Text = info;
               
                this.statusStrip.Refresh();
            }

           
           
        }

      
        private void cheknet()
        {
            if (flagServerStart == 0)
            {
                if (ServerIP == "")
                {
                    ServerIP = "127.0.0.1";
                    ServerPort = "3285";
                }
                Server serv = new Server();
                Thread serverTH = new Thread(serv.run_server);
                serverTH.IsBackground = true;
                serverTH.Start();
                flagServerStart = 1;
                Invoke(new ChangeStatusDelegate(statusNetsON), new object[] { "Online" });
            }
            
            //int con=1;
            //while (con == 1)
            //{
            //    Thread.Sleep(60000);

                //IPStatus status = IPStatus.Unknown;
                //try
                //{
                //    status = new Ping().Send("ya.ru").Status;
                //    if (status == IPStatus.Success)
                //    {
                //        Invoke(new ChangeStatusDelegate(statusNetsON), new object[] { "Online" });
                //    }
                //    else
                //    {
                //      Invoke(new ChangeStatusDelegate(statusNetsOFF), new object[] { "Offline" });
                //    }
                //}
                //catch (Exception e)
                //{
                //   // _Log.logwrite("Ошибка проверки соединения интернета: " + Environment.NewLine + e.Message, e);
                //    Invoke(new ChangeStatusDelegate(statusNetsOFF), new object[] { "Offline" });
                //}

                //if (flagServerStart == 0)
                //{
                //    if (ServerIP == "")
                //    {
                //        ServerIP = "127.0.0.1";
                //        ServerPort = "3285";
                //    }
                //    Server serv = new Server();
                //    Thread serverTH = new Thread(serv.run_server);
                //    serverTH.IsBackground = true;
                //    serverTH.Start();
                //    flagServerStart = 1;
                //}
            //}
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            tSSwindows.Text = "Открыто Окон: " + this.MdiChildren.Length.ToString();
            tSSDate.Text = "Дата: " + DateTime.Now.ToLongDateString();
            tSSTime.Text = "Время: " + DateTime.Now.ToLongTimeString();
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string formactive=ActiveForm.Text;
            if (formactive.IndexOf("Расходная накладная") >= 0)
            {
               //Создаем новый экземпляр
                List<ImportExport> CSV_Struct = new List<ImportExport>();
                CSV_Struct = ImportExport.ImportToCsv();

                string message="Загружено: "+ CSV_Struct.Count +" позиций";
                int countmess = 5;
                if (CSV_Struct.Count <= 5)
                {
                    countmess = CSV_Struct.Count;
                }
                for (int i = 0; i <= countmess-1; i++)
                {
                    message += Environment.NewLine + CSV_Struct[i].kod + " -- " + CSV_Struct[i].qty;
                }

                DialogResult result=MessageBox.Show(message,"Загрузить данные?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Заполняем listView из нашей структуры
                    for (int i = 0; i <= CSV_Struct.Count - 1; i++)
                    {
                        CallBackMy.callbackEventHandlerRform(CSV_Struct[i].kod);
                        CallBackMy.callbackEventHandlerRformImport(CSV_Struct[i].kod, Convert.ToDouble(CSV_Struct[i].qty));
                    }
                }
                 
            }

        }

      
      
           
    }
}
