namespace WindowsFormsApplication1
{
    partial class ReportCashIncome
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
            this.sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sredrcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sredmargin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGruptCash = new System.Windows.Forms.ComboBox();
            this.btnRepCash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCashE = new System.Windows.Forms.DateTimePicker();
            this.sredzcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpCashN = new System.Windows.Forms.DateTimePicker();
            this.dgvRepCash = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepCash)).BeginInit();
            this.SuspendLayout();
            // 
            // sup
            // 
            this.sup.HeaderText = "Поставщик";
            this.sup.Name = "sup";
            this.sup.ReadOnly = true;
            // 
            // sredrcena
            // 
            this.sredrcena.HeaderText = "Ср.Розн.Цена";
            this.sredrcena.Name = "sredrcena";
            this.sredrcena.ReadOnly = true;
            this.sredrcena.Width = 80;
            // 
            // sredmargin
            // 
            this.sredmargin.HeaderText = "Ср.Наценка";
            this.sredmargin.Name = "sredmargin";
            this.sredmargin.ReadOnly = true;
            this.sredmargin.Width = 80;
            // 
            // cmbGruptCash
            // 
            this.cmbGruptCash.FormattingEnabled = true;
            this.cmbGruptCash.Location = new System.Drawing.Point(12, 25);
            this.cmbGruptCash.Name = "cmbGruptCash";
            this.cmbGruptCash.Size = new System.Drawing.Size(190, 21);
            this.cmbGruptCash.TabIndex = 32;
            // 
            // btnRepCash
            // 
            this.btnRepCash.Location = new System.Drawing.Point(527, 17);
            this.btnRepCash.Name = "btnRepCash";
            this.btnRepCash.Size = new System.Drawing.Size(130, 26);
            this.btnRepCash.TabIndex = 30;
            this.btnRepCash.TabStop = false;
            this.btnRepCash.Text = "Запустить Отчет";
            this.btnRepCash.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(378, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Конец периода";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(211, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Начало периода";
            // 
            // dtpCashE
            // 
            this.dtpCashE.Location = new System.Drawing.Point(381, 24);
            this.dtpCashE.Name = "dtpCashE";
            this.dtpCashE.Size = new System.Drawing.Size(129, 20);
            this.dtpCashE.TabIndex = 27;
            // 
            // sredzcena
            // 
            this.sredzcena.HeaderText = "Ср.Закуп.Цена";
            this.sredzcena.Name = "sredzcena";
            this.sredzcena.ReadOnly = true;
            this.sredzcena.Width = 80;
            // 
            // dtpCashN
            // 
            this.dtpCashN.Location = new System.Drawing.Point(214, 24);
            this.dtpCashN.Name = "dtpCashN";
            this.dtpCashN.Size = new System.Drawing.Size(147, 20);
            this.dtpCashN.TabIndex = 26;
            // 
            // dgvRepCash
            // 
            this.dgvRepCash.AllowUserToAddRows = false;
            this.dgvRepCash.AllowUserToDeleteRows = false;
            this.dgvRepCash.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRepCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvRepCash.Location = new System.Drawing.Point(12, 82);
            this.dgvRepCash.Name = "dgvRepCash";
            this.dgvRepCash.RowHeadersVisible = false;
            this.dgvRepCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepCash.Size = new System.Drawing.Size(992, 408);
            this.dgvRepCash.TabIndex = 25;
            // 
            // kod
            // 
            this.kod.HeaderText = "Код";
            this.kod.Name = "kod";
            this.kod.ReadOnly = true;
            this.kod.Width = 80;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 80;
            // 
            // zcena
            // 
            this.zcena.HeaderText = "Закуп. Цена";
            this.zcena.Name = "zcena";
            this.zcena.ReadOnly = true;
            this.zcena.Width = 80;
            // 
            // rcena
            // 
            this.rcena.HeaderText = "Цена";
            this.rcena.Name = "rcena";
            this.rcena.ReadOnly = true;
            this.rcena.Width = 80;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Продажи";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // Ostatok
            // 
            this.Ostatok.HeaderText = "Остаток";
            this.Ostatok.Name = "Ostatok";
            this.Ostatok.ReadOnly = true;
            // 
            // zsumm
            // 
            this.zsumm.HeaderText = "Сумма закуп.";
            this.zsumm.Name = "zsumm";
            this.zsumm.ReadOnly = true;
            // 
            // rsumm
            // 
            this.rsumm.HeaderText = "Сумма";
            this.rsumm.Name = "rsumm";
            this.rsumm.ReadOnly = true;
            this.rsumm.Width = 80;
            // 
            // margin
            // 
            this.margin.HeaderText = "Наценка";
            this.margin.Name = "margin";
            this.margin.ReadOnly = true;
            this.margin.Width = 80;
            // 
            // groupt
            // 
            this.groupt.HeaderText = "Группа товара";
            this.groupt.Name = "groupt";
            this.groupt.ReadOnly = true;
            this.groupt.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Группа товара";
            // 
            // ReportCashIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.cmbGruptCash);
            this.Controls.Add(this.btnRepCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCashE);
            this.Controls.Add(this.dtpCashN);
            this.Controls.Add(this.dgvRepCash);
            this.Controls.Add(this.label1);
            this.Name = "ReportCashIncome";
            this.Text = "Отчет по доходности";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn sredrcena;
        private System.Windows.Forms.DataGridViewTextBoxColumn sredmargin;
        private System.Windows.Forms.ComboBox cmbGruptCash;
        private System.Windows.Forms.Button btnRepCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCashE;
        private System.Windows.Forms.DataGridViewTextBoxColumn sredzcena;
        private System.Windows.Forms.DateTimePicker dtpCashN;
        public System.Windows.Forms.DataGridView dgvRepCash;
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
        private System.Windows.Forms.Label label1;
    }
}