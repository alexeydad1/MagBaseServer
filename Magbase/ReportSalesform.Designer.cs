namespace MagbaseServer
{
    partial class ReportSalesform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRepSales = new System.Windows.Forms.DataGridView();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ostatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zsumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sredzcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sredrcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sredmargin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRepSales = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSalesE = new System.Windows.Forms.DateTimePicker();
            this.dtpSalesN = new System.Windows.Forms.DateTimePicker();
            this.cmbGruptSales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepSales
            // 
            this.dgvRepSales.AllowUserToAddRows = false;
            this.dgvRepSales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvRepSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRepSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRepSales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRepSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kod,
            this.name,
            this.zcena,
            this.rcena,
            this.quantity,
            this.Ostatok,
            this.zsumm,
            this.rsumm,
            this.margin,
            this.groupt,
            this.sredzcena,
            this.sredrcena,
            this.sredmargin,
            this.sup});
            this.dgvRepSales.Location = new System.Drawing.Point(12, 82);
            this.dgvRepSales.Name = "dgvRepSales";
            this.dgvRepSales.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvRepSales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRepSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepSales.Size = new System.Drawing.Size(992, 408);
            this.dgvRepSales.TabIndex = 8;
            // 
            // kod
            // 
            this.kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kod.HeaderText = "Код";
            this.kod.Name = "kod";
            this.kod.ReadOnly = true;
            this.kod.Width = 55;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 116;
            // 
            // zcena
            // 
            this.zcena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zcena.HeaderText = "Закуп. Цена";
            this.zcena.Name = "zcena";
            this.zcena.ReadOnly = true;
            this.zcena.Width = 95;
            // 
            // rcena
            // 
            this.rcena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rcena.HeaderText = "Цена";
            this.rcena.Name = "rcena";
            this.rcena.ReadOnly = true;
            this.rcena.Width = 62;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.HeaderText = "Продажи";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 87;
            // 
            // Ostatok
            // 
            this.Ostatok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ostatok.HeaderText = "Остаток";
            this.Ostatok.Name = "Ostatok";
            this.Ostatok.ReadOnly = true;
            this.Ostatok.Width = 81;
            // 
            // zsumm
            // 
            this.zsumm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zsumm.HeaderText = "Сумма закуп.";
            this.zsumm.Name = "zsumm";
            this.zsumm.ReadOnly = true;
            // 
            // rsumm
            // 
            this.rsumm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rsumm.HeaderText = "Сумма";
            this.rsumm.Name = "rsumm";
            this.rsumm.ReadOnly = true;
            this.rsumm.Width = 69;
            // 
            // margin
            // 
            this.margin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.margin.HeaderText = "Наценка";
            this.margin.Name = "margin";
            this.margin.ReadOnly = true;
            this.margin.Width = 83;
            // 
            // groupt
            // 
            this.groupt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.groupt.HeaderText = "Группа товара";
            this.groupt.Name = "groupt";
            this.groupt.ReadOnly = true;
            this.groupt.Width = 108;
            // 
            // sredzcena
            // 
            this.sredzcena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sredzcena.HeaderText = "Ср.Закуп.Цена";
            this.sredzcena.Name = "sredzcena";
            this.sredzcena.ReadOnly = true;
            this.sredzcena.Width = 117;
            // 
            // sredrcena
            // 
            this.sredrcena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sredrcena.HeaderText = "Ср.Розн.Цена";
            this.sredrcena.Name = "sredrcena";
            this.sredrcena.ReadOnly = true;
            this.sredrcena.Width = 109;
            // 
            // sredmargin
            // 
            this.sredmargin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sredmargin.HeaderText = "Ср.Наценка";
            this.sredmargin.Name = "sredmargin";
            this.sredmargin.ReadOnly = true;
            // 
            // sup
            // 
            this.sup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sup.HeaderText = "Поставщик";
            this.sup.Name = "sup";
            this.sup.ReadOnly = true;
            this.sup.Width = 97;
            // 
            // btnRepSales
            // 
            this.btnRepSales.Location = new System.Drawing.Point(527, 17);
            this.btnRepSales.Name = "btnRepSales";
            this.btnRepSales.Size = new System.Drawing.Size(130, 26);
            this.btnRepSales.TabIndex = 22;
            this.btnRepSales.TabStop = false;
            this.btnRepSales.Text = "Запустить Отчет";
            this.btnRepSales.UseVisualStyleBackColor = true;
            this.btnRepSales.Click += new System.EventHandler(this.btnRepSales_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(378, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Конец периода";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(211, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Начало периода";
            // 
            // dtpSalesE
            // 
            this.dtpSalesE.Location = new System.Drawing.Point(381, 24);
            this.dtpSalesE.Name = "dtpSalesE";
            this.dtpSalesE.Size = new System.Drawing.Size(129, 20);
            this.dtpSalesE.TabIndex = 19;
            // 
            // dtpSalesN
            // 
            this.dtpSalesN.Location = new System.Drawing.Point(214, 24);
            this.dtpSalesN.Name = "dtpSalesN";
            this.dtpSalesN.Size = new System.Drawing.Size(147, 20);
            this.dtpSalesN.TabIndex = 18;
            // 
            // cmbGruptSales
            // 
            this.cmbGruptSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGruptSales.FormattingEnabled = true;
            this.cmbGruptSales.Location = new System.Drawing.Point(12, 25);
            this.cmbGruptSales.Name = "cmbGruptSales";
            this.cmbGruptSales.Size = new System.Drawing.Size(190, 21);
            this.cmbGruptSales.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Группа товара";
            // 
            // ReportSalesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.cmbGruptSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRepSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpSalesE);
            this.Controls.Add(this.dtpSalesN);
            this.Controls.Add(this.dgvRepSales);
            this.KeyPreview = true;
            this.Name = "ReportSalesform";
            this.Text = "Отчет по продажам";
            this.Load += new System.EventHandler(this.ReportSalesform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportSalesform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvRepSales;
        private System.Windows.Forms.Button btnRepSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSalesE;
        private System.Windows.Forms.DateTimePicker dtpSalesN;
        private System.Windows.Forms.ComboBox cmbGruptSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn zcena;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcena;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ostatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn zsumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sredzcena;
        private System.Windows.Forms.DataGridViewTextBoxColumn sredrcena;
        private System.Windows.Forms.DataGridViewTextBoxColumn sredmargin;
        private System.Windows.Forms.DataGridViewTextBoxColumn sup;
    }
}