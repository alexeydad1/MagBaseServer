namespace MagbaseServer
{
    partial class ReportCashIncomeform
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
            this.btnRepCash = new System.Windows.Forms.Button();
            this.dgvRepCash = new System.Windows.Forms.DataGridView();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beznal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozvrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marginofday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepCash)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRepCash
            // 
            this.btnRepCash.Location = new System.Drawing.Point(172, 17);
            this.btnRepCash.Name = "btnRepCash";
            this.btnRepCash.Size = new System.Drawing.Size(130, 26);
            this.btnRepCash.TabIndex = 30;
            this.btnRepCash.TabStop = false;
            this.btnRepCash.Text = "Запустить Отчет";
            this.btnRepCash.UseVisualStyleBackColor = true;
            this.btnRepCash.Click += new System.EventHandler(this.btnRepCash_Click);
            // 
            // dgvRepCash
            // 
            this.dgvRepCash.AllowUserToAddRows = false;
            this.dgvRepCash.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvRepCash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRepCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRepCash.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRepCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.sales,
            this.nal,
            this.beznal,
            this.purchase,
            this.income,
            this.purchased,
            this.vozvrat,
            this.salvage,
            this.marginofday});
            this.dgvRepCash.Location = new System.Drawing.Point(12, 82);
            this.dgvRepCash.Name = "dgvRepCash";
            this.dgvRepCash.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvRepCash.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRepCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepCash.Size = new System.Drawing.Size(992, 408);
            this.dgvRepCash.TabIndex = 25;
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MMMM - yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(12, 23);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(126, 20);
            this.dtpMonth.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Месяц и Год";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 66;
            // 
            // sales
            // 
            this.sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sales.HeaderText = "Продажи";
            this.sales.Name = "sales";
            this.sales.ReadOnly = true;
            this.sales.Width = 96;
            // 
            // nal
            // 
            this.nal.HeaderText = "Наличные";
            this.nal.Name = "nal";
            // 
            // beznal
            // 
            this.beznal.HeaderText = "Безналичные";
            this.beznal.Name = "beznal";
            // 
            // purchase
            // 
            this.purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.purchase.HeaderText = "Закупка";
            this.purchase.Name = "purchase";
            this.purchase.ReadOnly = true;
            this.purchase.Width = 89;
            // 
            // income
            // 
            this.income.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.income.HeaderText = "Доход";
            this.income.Name = "income";
            this.income.ReadOnly = true;
            this.income.Width = 75;
            // 
            // purchased
            // 
            this.purchased.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.purchased.HeaderText = "Закуплено";
            this.purchased.Name = "purchased";
            this.purchased.ReadOnly = true;
            this.purchased.Width = 106;
            // 
            // vozvrat
            // 
            this.vozvrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vozvrat.HeaderText = "Возврат";
            this.vozvrat.Name = "vozvrat";
            this.vozvrat.ReadOnly = true;
            this.vozvrat.Width = 87;
            // 
            // salvage
            // 
            this.salvage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salvage.HeaderText = "Списано";
            this.salvage.Name = "salvage";
            this.salvage.ReadOnly = true;
            this.salvage.Width = 87;
            // 
            // marginofday
            // 
            this.marginofday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marginofday.HeaderText = "Наценка за день %";
            this.marginofday.Name = "marginofday";
            this.marginofday.ReadOnly = true;
            this.marginofday.Width = 105;
            // 
            // ReportCashIncomeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.btnRepCash);
            this.Controls.Add(this.dgvRepCash);
            this.KeyPreview = true;
            this.Name = "ReportCashIncomeform";
            this.Text = "Отчет по доходности";
            this.Load += new System.EventHandler(this.ReportCashIncomeform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportCashIncomeform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRepCash;
        public System.Windows.Forms.DataGridView dgvRepCash;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn nal;
        private System.Windows.Forms.DataGridViewTextBoxColumn beznal;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozvrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn salvage;
        private System.Windows.Forms.DataGridViewTextBoxColumn marginofday;
    }
}