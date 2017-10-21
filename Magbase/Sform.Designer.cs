namespace MagbaseServer
{
    partial class Sform
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.торговляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приходныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переоценкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переучетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоПродажамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоДоходностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоВесовымТоварамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоДвижениюТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.торговаяМаркаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реквизитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мозайкойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расположитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFDBasepathS = new System.Windows.Forms.OpenFileDialog();
            this.TimerSentMail = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusNet = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSwindows = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSSep = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSPbar = new System.Windows.Forms.ToolStripProgressBar();
            this.tSSlblIfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSlblCAPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSlblNUM = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSSCRL = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.торговляToolStripMenuItem,
            this.накладныеToolStripMenuItem,
            this.переучетToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.окнаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ImportToolStripMenuItem.Text = "Импорт";
            this.ImportToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // торговляToolStripMenuItem
            // 
            this.торговляToolStripMenuItem.Name = "торговляToolStripMenuItem";
            this.торговляToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.торговляToolStripMenuItem.Text = "Торговля";
            this.торговляToolStripMenuItem.Click += new System.EventHandler(this.торговляToolStripMenuItem_Click);
            // 
            // накладныеToolStripMenuItem
            // 
            this.накладныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приходныеToolStripMenuItem,
            this.расходныеToolStripMenuItem,
            this.переоценкаToolStripMenuItem});
            this.накладныеToolStripMenuItem.Name = "накладныеToolStripMenuItem";
            this.накладныеToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.накладныеToolStripMenuItem.Text = "Накладные";
            // 
            // приходныеToolStripMenuItem
            // 
            this.приходныеToolStripMenuItem.Name = "приходныеToolStripMenuItem";
            this.приходныеToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.приходныеToolStripMenuItem.Text = "Приходные";
            this.приходныеToolStripMenuItem.Click += new System.EventHandler(this.приходныеToolStripMenuItem_Click);
            // 
            // расходныеToolStripMenuItem
            // 
            this.расходныеToolStripMenuItem.Name = "расходныеToolStripMenuItem";
            this.расходныеToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.расходныеToolStripMenuItem.Text = "Расходные";
            this.расходныеToolStripMenuItem.Click += new System.EventHandler(this.расходныеToolStripMenuItem_Click);
            // 
            // переоценкаToolStripMenuItem
            // 
            this.переоценкаToolStripMenuItem.Name = "переоценкаToolStripMenuItem";
            this.переоценкаToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.переоценкаToolStripMenuItem.Text = "Переоценка";
            this.переоценкаToolStripMenuItem.Click += new System.EventHandler(this.переоценкаToolStripMenuItem_Click);
            // 
            // переучетToolStripMenuItem
            // 
            this.переучетToolStripMenuItem.Name = "переучетToolStripMenuItem";
            this.переучетToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.переучетToolStripMenuItem.Text = "Переучет";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетПоПродажамToolStripMenuItem,
            this.отчетПоДоходностиToolStripMenuItem,
            this.отчетПоВесовымТоварамToolStripMenuItem,
            this.отчетПоДвижениюТовараToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетПоПродажамToolStripMenuItem
            // 
            this.отчетПоПродажамToolStripMenuItem.Name = "отчетПоПродажамToolStripMenuItem";
            this.отчетПоПродажамToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.отчетПоПродажамToolStripMenuItem.Text = "Отчет по продажам";
            this.отчетПоПродажамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоПродажамToolStripMenuItem_Click);
            // 
            // отчетПоДоходностиToolStripMenuItem
            // 
            this.отчетПоДоходностиToolStripMenuItem.Name = "отчетПоДоходностиToolStripMenuItem";
            this.отчетПоДоходностиToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.отчетПоДоходностиToolStripMenuItem.Text = "Отчет по доходности";
            this.отчетПоДоходностиToolStripMenuItem.Click += new System.EventHandler(this.отчетПоДоходностиToolStripMenuItem_Click);
            // 
            // отчетПоВесовымТоварамToolStripMenuItem
            // 
            this.отчетПоВесовымТоварамToolStripMenuItem.Name = "отчетПоВесовымТоварамToolStripMenuItem";
            this.отчетПоВесовымТоварамToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.отчетПоВесовымТоварамToolStripMenuItem.Text = "Отчет по весовым товарам";
            this.отчетПоВесовымТоварамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоВесовымТоварамToolStripMenuItem_Click);
            // 
            // отчетПоДвижениюТовараToolStripMenuItem
            // 
            this.отчетПоДвижениюТовараToolStripMenuItem.Name = "отчетПоДвижениюТовараToolStripMenuItem";
            this.отчетПоДвижениюТовараToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.отчетПоДвижениюТовараToolStripMenuItem.Text = "Отчет по движению товара";
            this.отчетПоДвижениюТовараToolStripMenuItem.Click += new System.EventHandler(this.отчетПоДвижениюТовараToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.классификаторToolStripMenuItem,
            this.группыТоваровToolStripMenuItem,
            this.торговаяМаркаToolStripMenuItem,
            this.поставщикиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // классификаторToolStripMenuItem
            // 
            this.классификаторToolStripMenuItem.Name = "классификаторToolStripMenuItem";
            this.классификаторToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.классификаторToolStripMenuItem.Text = "Классификатор";
            this.классификаторToolStripMenuItem.Click += new System.EventHandler(this.классификаторToolStripMenuItem_Click);
            // 
            // группыТоваровToolStripMenuItem
            // 
            this.группыТоваровToolStripMenuItem.Name = "группыТоваровToolStripMenuItem";
            this.группыТоваровToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.группыТоваровToolStripMenuItem.Text = "Группы товаров";
            this.группыТоваровToolStripMenuItem.Click += new System.EventHandler(this.группыТоваровToolStripMenuItem_Click);
            // 
            // торговаяМаркаToolStripMenuItem
            // 
            this.торговаяМаркаToolStripMenuItem.Name = "торговаяМаркаToolStripMenuItem";
            this.торговаяМаркаToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.торговаяМаркаToolStripMenuItem.Text = "Торговая марка";
            this.торговаяМаркаToolStripMenuItem.Click += new System.EventHandler(this.торговаяМаркаToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реквизитыToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // реквизитыToolStripMenuItem
            // 
            this.реквизитыToolStripMenuItem.Name = "реквизитыToolStripMenuItem";
            this.реквизитыToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.реквизитыToolStripMenuItem.Text = "Основные";
            this.реквизитыToolStripMenuItem.Click += new System.EventHandler(this.реквизитыToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.мозайкойToolStripMenuItem,
            this.расположитьToolStripMenuItem,
            this.toolStripSeparator1});
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.окнаToolStripMenuItem.Text = "Окна";
            this.окнаToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.окнаToolStripMenuItem_DropDownItemClicked);
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // мозайкойToolStripMenuItem
            // 
            this.мозайкойToolStripMenuItem.Name = "мозайкойToolStripMenuItem";
            this.мозайкойToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.мозайкойToolStripMenuItem.Text = "Мозайкой";
            this.мозайкойToolStripMenuItem.Click += new System.EventHandler(this.мозайкойToolStripMenuItem_Click);
            // 
            // расположитьToolStripMenuItem
            // 
            this.расположитьToolStripMenuItem.Name = "расположитьToolStripMenuItem";
            this.расположитьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.расположитьToolStripMenuItem.Text = "Расположить";
            this.расположитьToolStripMenuItem.Click += new System.EventHandler(this.расположитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // TimerSentMail
            // 
            this.TimerSentMail.Tick += new System.EventHandler(this.TimerSentMail_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusNet,
            this.toolStripStatusLabel1,
            this.tSSDate,
            this.tSSTime,
            this.toolStripStatusLabel2,
            this.tSSwindows,
            this.tSSSep,
            this.tSSPbar,
            this.tSSlblIfo,
            this.tSSlblCAPS,
            this.tSSlblNUM,
            this.tSSSCRL});
            this.statusStrip.Location = new System.Drawing.Point(0, 551);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(892, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusNet
            // 
            this.statusNet.Image = global::MagbaseServer.Properties.Resources.stock_disconnect_5843;
            this.statusNet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusNet.Name = "statusNet";
            this.statusNet.Size = new System.Drawing.Size(55, 17);
            this.statusNet.Text = "Offline";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(4, 17);
            // 
            // tSSDate
            // 
            this.tSSDate.Name = "tSSDate";
            this.tSSDate.Size = new System.Drawing.Size(37, 17);
            this.tSSDate.Text = "Дата:";
            // 
            // tSSTime
            // 
            this.tSSTime.Name = "tSSTime";
            this.tSSTime.Size = new System.Drawing.Size(41, 17);
            this.tSSTime.Text = "Время:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 17);
            // 
            // tSSwindows
            // 
            this.tSSwindows.Name = "tSSwindows";
            this.tSSwindows.Size = new System.Drawing.Size(81, 17);
            this.tSSwindows.Text = "Открыто окн: ";
            // 
            // tSSSep
            // 
            this.tSSSep.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tSSSep.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tSSSep.Name = "tSSSep";
            this.tSSSep.Size = new System.Drawing.Size(4, 17);
            // 
            // tSSPbar
            // 
            this.tSSPbar.Name = "tSSPbar";
            this.tSSPbar.Size = new System.Drawing.Size(100, 16);
            this.tSSPbar.Step = 1;
            // 
            // tSSlblIfo
            // 
            this.tSSlblIfo.AutoSize = false;
            this.tSSlblIfo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSlblIfo.Name = "tSSlblIfo";
            this.tSSlblIfo.Size = new System.Drawing.Size(250, 17);
            this.tSSlblIfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tSSlblCAPS
            // 
            this.tSSlblCAPS.AutoSize = false;
            this.tSSlblCAPS.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSlblCAPS.Name = "tSSlblCAPS";
            this.tSSlblCAPS.Size = new System.Drawing.Size(40, 17);
            // 
            // tSSlblNUM
            // 
            this.tSSlblNUM.AutoSize = false;
            this.tSSlblNUM.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSlblNUM.Name = "tSSlblNUM";
            this.tSSlblNUM.Size = new System.Drawing.Size(40, 17);
            // 
            // tSSSCRL
            // 
            this.tSSSCRL.AutoSize = false;
            this.tSSSCRL.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSSCRL.Name = "tSSSCRL";
            this.tSSSCRL.Size = new System.Drawing.Size(40, 17);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // Sform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 573);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sform";
            this.Text = "MagBase - Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sform_FormClosing);
            this.Load += new System.EventHandler(this.Sform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem торговляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переучетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классификаторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоПродажамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem торговаяМаркаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мозайкойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расположитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реквизитыToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog OFDBasepathS;
        private System.Windows.Forms.ToolStripMenuItem отчетПоДоходностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переоценкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоВесовымТоварамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоДвижениюТовараToolStripMenuItem;
        public System.Windows.Forms.Timer TimerSentMail;
        public System.Windows.Forms.Timer timerDateTime;
        public System.Windows.Forms.ToolStripStatusLabel statusNet;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tSSDate;
        private System.Windows.Forms.ToolStripStatusLabel tSSTime;
        private System.Windows.Forms.ToolStripStatusLabel tSSSep;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tSSwindows;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar tSSPbar;
        private System.Windows.Forms.ToolStripStatusLabel tSSlblIfo;
        private System.Windows.Forms.ToolStripStatusLabel tSSlblCAPS;
        private System.Windows.Forms.ToolStripStatusLabel tSSlblNUM;
        private System.Windows.Forms.ToolStripStatusLabel tSSSCRL;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
    }
}

