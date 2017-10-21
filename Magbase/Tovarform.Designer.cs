namespace MagbaseServer
{
    partial class Tovarform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tovarform));
            this.trvgroup = new System.Windows.Forms.TreeView();
            this.cMSTovarfrm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIcopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMIprice = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIzakup = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblname = new System.Windows.Forms.Label();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.cmbbrand = new System.Windows.Forms.ComboBox();
            this.cmbgroup = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cmbsuppliers = new System.Windows.Forms.ComboBox();
            this.txtzcena = new System.Windows.Forms.TextBox();
            this.txtrcena = new System.Windows.Forms.TextBox();
            this.lblquanity = new System.Windows.Forms.Label();
            this.lblkod = new System.Windows.Forms.Label();
            this.lstboxean = new System.Windows.Forms.ListBox();
            this.btnaddean = new System.Windows.Forms.Button();
            this.btndelean = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnadd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnchange = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tspTxtFind = new System.Windows.Forms.ToolStripTextBox();
            this.tspBtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefrashCMB = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObemSpisania = new System.Windows.Forms.TextBox();
            this.txtKodOsnova = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLifeGoods = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddPlu = new System.Windows.Forms.Button();
            this.txtPLUkod = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsavetovar = new System.Windows.Forms.Button();
            this.cMSTovarfrm.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvgroup
            // 
            this.trvgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trvgroup.CheckBoxes = true;
            this.trvgroup.ContextMenuStrip = this.cMSTovarfrm;
            this.trvgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trvgroup.ImageIndex = 0;
            this.trvgroup.ImageList = this.imageList1;
            this.trvgroup.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.trvgroup.Location = new System.Drawing.Point(12, 55);
            this.trvgroup.Name = "trvgroup";
            this.trvgroup.SelectedImageIndex = 1;
            this.trvgroup.Size = new System.Drawing.Size(386, 393);
            this.trvgroup.TabIndex = 0;
            this.trvgroup.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvgroup_NodeMouseDoubleClick);
            // 
            // cMSTovarfrm
            // 
            this.cMSTovarfrm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIcopy,
            this.toolStripSeparator4,
            this.tSMIprice,
            this.tSMIzakup});
            this.cMSTovarfrm.Name = "cMSTovarfrm";
            this.cMSTovarfrm.Size = new System.Drawing.Size(203, 76);
            // 
            // tSMIcopy
            // 
            this.tSMIcopy.Name = "tSMIcopy";
            this.tSMIcopy.Size = new System.Drawing.Size(202, 22);
            this.tSMIcopy.Text = "Копировать       Ctrl+C";
            this.tSMIcopy.Click += new System.EventHandler(this.tSMIcopy_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // tSMIprice
            // 
            this.tSMIprice.Name = "tSMIprice";
            this.tSMIprice.Size = new System.Drawing.Size(202, 22);
            this.tSMIprice.Text = "История Розничных цен";
            this.tSMIprice.Click += new System.EventHandler(this.tSMIprice_Click);
            // 
            // tSMIzakup
            // 
            this.tSMIzakup.Name = "tSMIzakup";
            this.tSMIzakup.Size = new System.Drawing.Size(202, 22);
            this.tSMIzakup.Text = "История Закупочных цен";
            this.tSMIzakup.Click += new System.EventHandler(this.tSMIzakup_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_16x16.png");
            this.imageList1.Images.SetKeyName(1, "folder_open_16x16.png");
            this.imageList1.Images.SetKeyName(2, "file_16x16.png");
            this.imageList1.Images.SetKeyName(3, "file_16x16.png");
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblname.Location = new System.Drawing.Point(500, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(280, 68);
            this.lblname.TabIndex = 2;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbclass
            // 
            this.cmbclass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbclass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbclass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Location = new System.Drawing.Point(409, 141);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(371, 24);
            this.cmbclass.TabIndex = 3;
            this.cmbclass.Tag = "Классификатор товара";
            this.cmbclass.SelectedIndexChanged += new System.EventHandler(this.cmbclass_SelectedIndexChanged);
            // 
            // cmbbrand
            // 
            this.cmbbrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbbrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbbrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbbrand.FormattingEnabled = true;
            this.cmbbrand.Location = new System.Drawing.Point(409, 182);
            this.cmbbrand.Name = "cmbbrand";
            this.cmbbrand.Size = new System.Drawing.Size(371, 24);
            this.cmbbrand.TabIndex = 4;
            this.cmbbrand.Tag = "Торговая марка";
            this.cmbbrand.SelectedIndexChanged += new System.EventHandler(this.cmbbrand_SelectedIndexChanged);
            // 
            // cmbgroup
            // 
            this.cmbgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbgroup.FormattingEnabled = true;
            this.cmbgroup.Location = new System.Drawing.Point(409, 261);
            this.cmbgroup.Name = "cmbgroup";
            this.cmbgroup.Size = new System.Drawing.Size(371, 24);
            this.cmbgroup.TabIndex = 6;
            this.cmbgroup.Tag = "Группа товара";
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtname.Location = new System.Drawing.Point(409, 223);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(371, 22);
            this.txtname.TabIndex = 5;
            this.txtname.Tag = "Название (доп. параметры)";
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // cmbsuppliers
            // 
            this.cmbsuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbsuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbsuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbsuppliers.FormattingEnabled = true;
            this.cmbsuppliers.Location = new System.Drawing.Point(409, 299);
            this.cmbsuppliers.Name = "cmbsuppliers";
            this.cmbsuppliers.Size = new System.Drawing.Size(371, 24);
            this.cmbsuppliers.TabIndex = 7;
            this.cmbsuppliers.Tag = "Поставщик";
            // 
            // txtzcena
            // 
            this.txtzcena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtzcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtzcena.Location = new System.Drawing.Point(409, 339);
            this.txtzcena.Name = "txtzcena";
            this.txtzcena.Size = new System.Drawing.Size(68, 22);
            this.txtzcena.TabIndex = 8;
            this.txtzcena.Tag = "Закупочная цена";
            this.txtzcena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtzcena.TextChanged += new System.EventHandler(this.txtzcena_TextChanged);
            // 
            // txtrcena
            // 
            this.txtrcena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtrcena.Location = new System.Drawing.Point(533, 339);
            this.txtrcena.Name = "txtrcena";
            this.txtrcena.Size = new System.Drawing.Size(68, 22);
            this.txtrcena.TabIndex = 9;
            this.txtrcena.Tag = "Розничная цена";
            this.txtrcena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrcena.TextChanged += new System.EventHandler(this.txtrcena_TextChanged);
            // 
            // lblquanity
            // 
            this.lblquanity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblquanity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblquanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblquanity.Location = new System.Drawing.Point(643, 339);
            this.lblquanity.Name = "lblquanity";
            this.lblquanity.Size = new System.Drawing.Size(68, 22);
            this.lblquanity.TabIndex = 10;
            this.lblquanity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblkod
            // 
            this.lblkod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblkod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblkod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblkod.Location = new System.Drawing.Point(409, 57);
            this.lblkod.Name = "lblkod";
            this.lblkod.Size = new System.Drawing.Size(85, 68);
            this.lblkod.TabIndex = 11;
            this.lblkod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstboxean
            // 
            this.lstboxean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstboxean.Enabled = false;
            this.lstboxean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstboxean.FormattingEnabled = true;
            this.lstboxean.ItemHeight = 16;
            this.lstboxean.Location = new System.Drawing.Point(409, 380);
            this.lstboxean.Name = "lstboxean";
            this.lstboxean.Size = new System.Drawing.Size(215, 68);
            this.lstboxean.TabIndex = 12;
            this.lstboxean.Tag = "Штрихкод";
            // 
            // btnaddean
            // 
            this.btnaddean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddean.Enabled = false;
            this.btnaddean.Location = new System.Drawing.Point(643, 380);
            this.btnaddean.Name = "btnaddean";
            this.btnaddean.Size = new System.Drawing.Size(76, 29);
            this.btnaddean.TabIndex = 13;
            this.btnaddean.Text = "Добавить";
            this.btnaddean.UseVisualStyleBackColor = true;
            this.btnaddean.Click += new System.EventHandler(this.btnaddean_Click);
            // 
            // btndelean
            // 
            this.btndelean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelean.Enabled = false;
            this.btndelean.Location = new System.Drawing.Point(643, 420);
            this.btndelean.Name = "btndelean";
            this.btndelean.Size = new System.Drawing.Size(76, 29);
            this.btndelean.TabIndex = 14;
            this.btndelean.Text = "Удалить";
            this.btndelean.UseVisualStyleBackColor = true;
            this.btndelean.Click += new System.EventHandler(this.btndelean_Click);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Enabled = false;
            this.btncancel.Location = new System.Drawing.Point(545, 471);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(76, 29);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Отмена";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Код товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дерево товаров";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Наименование товара";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Классификатор товара";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Торговая марка";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Название (доп. параметры)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Группа товара";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Поставщик";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Закупочная цена";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Розничная цена";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Остаток";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Штрихкод";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnadd,
            this.tsbtnchange,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tspTxtFind,
            this.tspBtnFind,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.tsbRefrashCMB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 39);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnadd
            // 
            this.tsbtnadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnadd.Image = global::MagbaseServer.Properties.Resources.new_32_doc;
            this.tsbtnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnadd.Name = "tsbtnadd";
            this.tsbtnadd.Size = new System.Drawing.Size(36, 36);
            this.tsbtnadd.Text = "+";
            this.tsbtnadd.ToolTipText = "Добавить";
            this.tsbtnadd.Click += new System.EventHandler(this.tsbtnadd_Click);
            // 
            // tsbtnchange
            // 
            this.tsbtnchange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnchange.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnchange.Image")));
            this.tsbtnchange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnchange.Name = "tsbtnchange";
            this.tsbtnchange.Size = new System.Drawing.Size(36, 36);
            this.tsbtnchange.Text = "Изменить";
            this.tsbtnchange.Click += new System.EventHandler(this.tsbtnchange_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 36);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // tspTxtFind
            // 
            this.tspTxtFind.AcceptsReturn = true;
            this.tspTxtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tspTxtFind.Name = "tspTxtFind";
            this.tspTxtFind.Size = new System.Drawing.Size(100, 39);
            // 
            // tspBtnFind
            // 
            this.tspBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBtnFind.Image = global::MagbaseServer.Properties.Resources.search32x32;
            this.tspBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBtnFind.Name = "tspBtnFind";
            this.tspBtnFind.Size = new System.Drawing.Size(36, 36);
            this.tspBtnFind.Text = "Найти товары";
            this.tspBtnFind.Click += new System.EventHandler(this.tspBtnFind_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::MagbaseServer.Properties.Resources.view_tree_32x32;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Изменить группу";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MagbaseServer.Properties.Resources.print_32_doc;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Печать ценников";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::MagbaseServer.Properties.Resources.barcode;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Напечатать штрих код";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbRefrashCMB
            // 
            this.tsbRefrashCMB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefrashCMB.Image = global::MagbaseServer.Properties.Resources.arrow_refresh_2810;
            this.tsbRefrashCMB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrashCMB.Name = "tsbRefrashCMB";
            this.tsbRefrashCMB.Size = new System.Drawing.Size(36, 36);
            this.tsbRefrashCMB.Text = "Обновить комбобоксы справочников";
            this.tsbRefrashCMB.Click += new System.EventHandler(this.tsbRefrashCMB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtObemSpisania);
            this.groupBox1.Controls.Add(this.txtKodOsnova);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(790, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 109);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки для виртуальных кодов";
            // 
            // txtObemSpisania
            // 
            this.txtObemSpisania.Location = new System.Drawing.Point(9, 78);
            this.txtObemSpisania.Name = "txtObemSpisania";
            this.txtObemSpisania.Size = new System.Drawing.Size(117, 20);
            this.txtObemSpisania.TabIndex = 3;
            this.txtObemSpisania.TextChanged += new System.EventHandler(this.txtObemSpisania_TextChanged);
            // 
            // txtKodOsnova
            // 
            this.txtKodOsnova.Location = new System.Drawing.Point(9, 39);
            this.txtKodOsnova.Name = "txtKodOsnova";
            this.txtKodOsnova.Size = new System.Drawing.Size(117, 20);
            this.txtKodOsnova.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Объем списания";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Код основного товара";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtLifeGoods);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnAddPlu);
            this.groupBox2.Controls.Add(this.txtPLUkod);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(790, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 103);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Весовой товар";
            // 
            // txtLifeGoods
            // 
            this.txtLifeGoods.Location = new System.Drawing.Point(9, 71);
            this.txtLifeGoods.Name = "txtLifeGoods";
            this.txtLifeGoods.Size = new System.Drawing.Size(75, 20);
            this.txtLifeGoods.TabIndex = 4;
            this.txtLifeGoods.Tag = "PLU код";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Срок годности в минутах";
            // 
            // btnAddPlu
            // 
            this.btnAddPlu.Enabled = false;
            this.btnAddPlu.Location = new System.Drawing.Point(113, 19);
            this.btnAddPlu.Name = "btnAddPlu";
            this.btnAddPlu.Size = new System.Drawing.Size(90, 34);
            this.btnAddPlu.TabIndex = 2;
            this.btnAddPlu.Text = "Присвоить PLU код";
            this.btnAddPlu.UseVisualStyleBackColor = true;
            this.btnAddPlu.Click += new System.EventHandler(this.btnAddPlu_Click);
            // 
            // txtPLUkod
            // 
            this.txtPLUkod.Location = new System.Drawing.Point(9, 32);
            this.txtPLUkod.Name = "txtPLUkod";
            this.txtPLUkod.Size = new System.Drawing.Size(75, 20);
            this.txtPLUkod.TabIndex = 1;
            this.txtPLUkod.Tag = "PLU код";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "PLU код";
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnprint.Image = global::MagbaseServer.Properties.Resources.print_32_doc;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(410, 471);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(109, 49);
            this.btnprint.TabIndex = 30;
            this.btnprint.Text = "Напечатать ценник";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnsavetovar
            // 
            this.btnsavetovar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsavetovar.Enabled = false;
            this.btnsavetovar.Image = global::MagbaseServer.Properties.Resources.save_16_doc;
            this.btnsavetovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsavetovar.Location = new System.Drawing.Point(643, 471);
            this.btnsavetovar.Name = "btnsavetovar";
            this.btnsavetovar.Size = new System.Drawing.Size(90, 29);
            this.btnsavetovar.TabIndex = 16;
            this.btnsavetovar.Text = "Сохранить";
            this.btnsavetovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsavetovar.UseVisualStyleBackColor = true;
            this.btnsavetovar.Click += new System.EventHandler(this.btnsavetovar_Click);
            // 
            // Tovarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsavetovar);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelean);
            this.Controls.Add(this.btnaddean);
            this.Controls.Add(this.lstboxean);
            this.Controls.Add(this.lblkod);
            this.Controls.Add(this.lblquanity);
            this.Controls.Add(this.txtrcena);
            this.Controls.Add(this.txtzcena);
            this.Controls.Add(this.cmbsuppliers);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cmbgroup);
            this.Controls.Add(this.cmbbrand);
            this.Controls.Add(this.cmbclass);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.trvgroup);
            this.KeyPreview = true;
            this.Name = "Tovarform";
            this.Text = "Справочник Товары";
            this.Load += new System.EventHandler(this.Tovarform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tovarform_KeyDown);
            this.cMSTovarfrm.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.ComboBox cmbbrand;
        private System.Windows.Forms.ComboBox cmbgroup;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cmbsuppliers;
        private System.Windows.Forms.TextBox txtzcena;
        public System.Windows.Forms.TextBox txtrcena;
        private System.Windows.Forms.Label lblquanity;
        public System.Windows.Forms.Label lblkod;
        public System.Windows.Forms.ListBox lstboxean;
        private System.Windows.Forms.Button btnaddean;
        private System.Windows.Forms.Button btndelean;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsavetovar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnadd;
        private System.Windows.Forms.ToolStripButton tsbtnchange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObemSpisania;
        private System.Windows.Forms.TextBox txtKodOsnova;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tspTxtFind;
        private System.Windows.Forms.ToolStripButton tspBtnFind;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.TreeView trvgroup;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPLUkod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddPlu;
        private System.Windows.Forms.TextBox txtLifeGoods;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRefrashCMB;
        private System.Windows.Forms.ContextMenuStrip cMSTovarfrm;
        private System.Windows.Forms.ToolStripMenuItem tSMIprice;
        private System.Windows.Forms.ToolStripMenuItem tSMIcopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tSMIzakup;
    }
}