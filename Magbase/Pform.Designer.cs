namespace MagbaseServer
{
    partial class Pform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPshtovar = new System.Windows.Forms.TextBox();
            this.txtPkodtovar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKodtovara = new System.Windows.Forms.Label();
            this.lblnametovar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblmargin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnaddtovar = new System.Windows.Forms.Button();
            this.lblPNewzakup = new System.Windows.Forms.Label();
            this.lblPoldzakup = new System.Windows.Forms.Label();
            this.txtProzn = new System.Windows.Forms.TextBox();
            this.txtPsumm = new System.Windows.Forms.TextBox();
            this.txtPkol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelP = new System.Windows.Forms.Button();
            this.bntSaveP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNumdokmag = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDokSup = new System.Windows.Forms.TextBox();
            this.msktxtDateDok = new System.Windows.Forms.MaskedTextBox();
            this.lblSummPrihod = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbllinedok = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRefreshSup = new System.Windows.Forms.Button();
            this.timerZakup = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            this.conMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPshtovar
            // 
            this.txtPshtovar.Location = new System.Drawing.Point(12, 25);
            this.txtPshtovar.Name = "txtPshtovar";
            this.txtPshtovar.Size = new System.Drawing.Size(101, 20);
            this.txtPshtovar.TabIndex = 0;
            this.txtPshtovar.TextChanged += new System.EventHandler(this.txtPshtovar_TextChanged);
            // 
            // txtPkodtovar
            // 
            this.txtPkodtovar.Location = new System.Drawing.Point(132, 25);
            this.txtPkodtovar.Name = "txtPkodtovar";
            this.txtPkodtovar.Size = new System.Drawing.Size(101, 20);
            this.txtPkodtovar.TabIndex = 1;
            this.txtPkodtovar.TextChanged += new System.EventHandler(this.txtPkodtovar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Штрихкод";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKodtovara);
            this.groupBox1.Controls.Add(this.lblnametovar);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 131);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Код и Наименование товара";
            // 
            // lblKodtovara
            // 
            this.lblKodtovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKodtovara.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKodtovara.Location = new System.Drawing.Point(6, 20);
            this.lblKodtovara.Name = "lblKodtovara";
            this.lblKodtovara.Size = new System.Drawing.Size(106, 102);
            this.lblKodtovara.TabIndex = 1;
            this.lblKodtovara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnametovar
            // 
            this.lblnametovar.AutoEllipsis = true;
            this.lblnametovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblnametovar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnametovar.Location = new System.Drawing.Point(120, 20);
            this.lblnametovar.Name = "lblnametovar";
            this.lblnametovar.Size = new System.Drawing.Size(311, 102);
            this.lblnametovar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblmargin);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnaddtovar);
            this.groupBox2.Controls.Add(this.lblPNewzakup);
            this.groupBox2.Controls.Add(this.lblPoldzakup);
            this.groupBox2.Controls.Add(this.txtProzn);
            this.groupBox2.Controls.Add(this.txtPsumm);
            this.groupBox2.Controls.Add(this.txtPkol);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(459, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 131);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цены";
            // 
            // lblmargin
            // 
            this.lblmargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblmargin.ForeColor = System.Drawing.Color.Green;
            this.lblmargin.Location = new System.Drawing.Point(300, 32);
            this.lblmargin.Name = "lblmargin";
            this.lblmargin.Size = new System.Drawing.Size(81, 29);
            this.lblmargin.TabIndex = 20;
            this.lblmargin.Text = "0";
            this.lblmargin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(297, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Наценка";
            // 
            // btnaddtovar
            // 
            this.btnaddtovar.Location = new System.Drawing.Point(206, 80);
            this.btnaddtovar.Name = "btnaddtovar";
            this.btnaddtovar.Size = new System.Drawing.Size(141, 42);
            this.btnaddtovar.TabIndex = 9;
            this.btnaddtovar.Text = "Добавить товар";
            this.btnaddtovar.UseVisualStyleBackColor = true;
            this.btnaddtovar.Click += new System.EventHandler(this.btnaddtovar_Click);
            // 
            // lblPNewzakup
            // 
            this.lblPNewzakup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPNewzakup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPNewzakup.ForeColor = System.Drawing.Color.Green;
            this.lblPNewzakup.Location = new System.Drawing.Point(118, 32);
            this.lblPNewzakup.Name = "lblPNewzakup";
            this.lblPNewzakup.Size = new System.Drawing.Size(80, 29);
            this.lblPNewzakup.TabIndex = 17;
            this.lblPNewzakup.Text = "0";
            this.lblPNewzakup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPNewzakup.TextChanged += new System.EventHandler(this.lblPNewzakup_TextChanged);
            // 
            // lblPoldzakup
            // 
            this.lblPoldzakup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoldzakup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoldzakup.Location = new System.Drawing.Point(118, 89);
            this.lblPoldzakup.Name = "lblPoldzakup";
            this.lblPoldzakup.Size = new System.Drawing.Size(80, 29);
            this.lblPoldzakup.TabIndex = 16;
            this.lblPoldzakup.Text = "0";
            this.lblPoldzakup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProzn
            // 
            this.txtProzn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProzn.Location = new System.Drawing.Point(206, 32);
            this.txtProzn.Name = "txtProzn";
            this.txtProzn.Size = new System.Drawing.Size(85, 29);
            this.txtProzn.TabIndex = 8;
            this.txtProzn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProzn.TextChanged += new System.EventHandler(this.txtProzn_TextChanged);
            // 
            // txtPsumm
            // 
            this.txtPsumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPsumm.Location = new System.Drawing.Point(7, 89);
            this.txtPsumm.Name = "txtPsumm";
            this.txtPsumm.Size = new System.Drawing.Size(95, 29);
            this.txtPsumm.TabIndex = 7;
            this.txtPsumm.TextChanged += new System.EventHandler(this.txtPsumm_TextChanged);
            // 
            // txtPkol
            // 
            this.txtPkol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPkol.Location = new System.Drawing.Point(7, 32);
            this.txtPkol.Name = "txtPkol";
            this.txtPkol.Size = new System.Drawing.Size(95, 29);
            this.txtPkol.TabIndex = 6;
            this.txtPkol.TextChanged += new System.EventHandler(this.txtPkol_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Старая закупка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Розничная цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Новая закупка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество";
            // 
            // dgvP
            // 
            this.dgvP.AllowUserToAddRows = false;
            this.dgvP.AllowUserToDeleteRows = false;
            this.dgvP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvP.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.ContextMenuStrip = this.conMenu;
            this.dgvP.Location = new System.Drawing.Point(12, 195);
            this.dgvP.Name = "dgvP";
            this.dgvP.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvP.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvP.RowTemplate.Height = 32;
            this.dgvP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvP.Size = new System.Drawing.Size(992, 255);
            this.dgvP.StandardTab = true;
            this.dgvP.TabIndex = 10;
            // 
            // conMenu
            // 
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMenuSelectAll,
            this.toolStripSeparator1,
            this.tSMenuCopy});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(192, 54);
            // 
            // tSMenuSelectAll
            // 
            this.tSMenuSelectAll.Name = "tSMenuSelectAll";
            this.tSMenuSelectAll.Size = new System.Drawing.Size(191, 22);
            this.tSMenuSelectAll.Text = "Выделить все Ctrl+A";
            this.tSMenuSelectAll.Click += new System.EventHandler(this.tSMenuSelectAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // tSMenuCopy
            // 
            this.tSMenuCopy.Name = "tSMenuCopy";
            this.tSMenuCopy.Size = new System.Drawing.Size(191, 22);
            this.tSMenuCopy.Text = "Копировать Ctrl+C";
            this.tSMenuCopy.Click += new System.EventHandler(this.tSMenuCopy_Click);
            // 
            // btnDelP
            // 
            this.btnDelP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelP.Location = new System.Drawing.Point(12, 465);
            this.btnDelP.Name = "btnDelP";
            this.btnDelP.Size = new System.Drawing.Size(116, 29);
            this.btnDelP.TabIndex = 11;
            this.btnDelP.Text = "Удалить строку";
            this.btnDelP.UseVisualStyleBackColor = true;
            this.btnDelP.Click += new System.EventHandler(this.btnDelP_Click);
            // 
            // bntSaveP
            // 
            this.bntSaveP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSaveP.Location = new System.Drawing.Point(888, 465);
            this.bntSaveP.Name = "bntSaveP";
            this.bntSaveP.Size = new System.Drawing.Size(116, 29);
            this.bntSaveP.TabIndex = 12;
            this.bntSaveP.Text = "Сохранить";
            this.bntSaveP.UseVisualStyleBackColor = true;
            this.bntSaveP.Click += new System.EventHandler(this.bntSaveP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Номер документа";
            // 
            // lblNumdokmag
            // 
            this.lblNumdokmag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumdokmag.Location = new System.Drawing.Point(354, 24);
            this.lblNumdokmag.Name = "lblNumdokmag";
            this.lblNumdokmag.Size = new System.Drawing.Size(98, 20);
            this.lblNumdokmag.TabIndex = 13;
            this.lblNumdokmag.Text = "0";
            this.lblNumdokmag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Поставщик";
            // 
            // cmbSup
            // 
            this.cmbSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSup.FormattingEnabled = true;
            this.cmbSup.Location = new System.Drawing.Point(479, 24);
            this.cmbSup.Name = "cmbSup";
            this.cmbSup.Size = new System.Drawing.Size(191, 21);
            this.cmbSup.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(710, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "№ Документа Поставщика";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(856, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Дата документа Поставщика";
            // 
            // txtDokSup
            // 
            this.txtDokSup.Location = new System.Drawing.Point(713, 25);
            this.txtDokSup.Name = "txtDokSup";
            this.txtDokSup.Size = new System.Drawing.Size(116, 20);
            this.txtDokSup.TabIndex = 4;
            // 
            // msktxtDateDok
            // 
            this.msktxtDateDok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msktxtDateDok.Location = new System.Drawing.Point(859, 25);
            this.msktxtDateDok.Mask = "00/00/00";
            this.msktxtDateDok.Name = "msktxtDateDok";
            this.msktxtDateDok.Size = new System.Drawing.Size(63, 20);
            this.msktxtDateDok.TabIndex = 5;
            this.msktxtDateDok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSummPrihod
            // 
            this.lblSummPrihod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummPrihod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummPrihod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSummPrihod.Location = new System.Drawing.Point(855, 71);
            this.lblSummPrihod.Name = "lblSummPrihod";
            this.lblSummPrihod.Size = new System.Drawing.Size(138, 27);
            this.lblSummPrihod.TabIndex = 20;
            this.lblSummPrihod.Text = "0";
            this.lblSummPrihod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(852, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "Сумма Накладной";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(336, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Строк в документе: ";
            // 
            // lbllinedok
            // 
            this.lbllinedok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbllinedok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllinedok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbllinedok.Location = new System.Drawing.Point(534, 470);
            this.lbllinedok.Name = "lbllinedok";
            this.lbllinedok.Size = new System.Drawing.Size(245, 24);
            this.lbllinedok.TabIndex = 25;
            this.lbllinedok.Text = "0";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(249, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 34);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Поиск товара";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRefreshSup
            // 
            this.btnRefreshSup.Image = global::MagbaseServer.Properties.Resources.arrow_refresh_3839;
            this.btnRefreshSup.Location = new System.Drawing.Point(676, 24);
            this.btnRefreshSup.Name = "btnRefreshSup";
            this.btnRefreshSup.Size = new System.Drawing.Size(31, 22);
            this.btnRefreshSup.TabIndex = 26;
            this.btnRefreshSup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRefreshSup.UseVisualStyleBackColor = true;
            this.btnRefreshSup.Click += new System.EventHandler(this.btnRefreshSup_Click);
            // 
            // timerZakup
            // 
            this.timerZakup.Tick += new System.EventHandler(this.timerZakup_Tick);
            // 
            // Pform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.btnRefreshSup);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbllinedok);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSummPrihod);
            this.Controls.Add(this.msktxtDateDok);
            this.Controls.Add(this.txtDokSup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbSup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNumdokmag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bntSaveP);
            this.Controls.Add(this.btnDelP);
            this.Controls.Add(this.dgvP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPkodtovar);
            this.Controls.Add(this.txtPshtovar);
            this.KeyPreview = true;
            this.Name = "Pform";
            this.Text = "Приходная накладная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pform_FormClosing);
            this.Load += new System.EventHandler(this.Pform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pform_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            this.conMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPshtovar;
        private System.Windows.Forms.TextBox txtPkodtovar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnametovar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPNewzakup;
        private System.Windows.Forms.Label lblPoldzakup;
        private System.Windows.Forms.TextBox txtProzn;
        private System.Windows.Forms.TextBox txtPsumm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.Button btnDelP;
        private System.Windows.Forms.Button bntSaveP;
        private System.Windows.Forms.Button btnaddtovar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNumdokmag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDokSup;
        private System.Windows.Forms.MaskedTextBox msktxtDateDok;
        private System.Windows.Forms.Label lblSummPrihod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblKodtovara;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbllinedok;
        private System.Windows.Forms.Label lblmargin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.TextBox txtPkol;
        private System.Windows.Forms.Button btnRefreshSup;
        private System.Windows.Forms.Timer timerZakup;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem tSMenuSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tSMenuCopy;
    }
}