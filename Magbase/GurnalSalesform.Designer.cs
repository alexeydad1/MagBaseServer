namespace MagbaseServer
{
    partial class GurnalSalesform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGurSalesRep = new System.Windows.Forms.Button();
            this.dgvCheki = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSostavChek = new System.Windows.Forms.DataGridView();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnalvir = new System.Windows.Forms.Label();
            this.lblallvir = new System.Windows.Forms.Label();
            this.lblbeznalvir = new System.Windows.Forms.Label();
            this.btnNB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheki)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSostavChek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGurSalesRep
            // 
            this.btnGurSalesRep.Location = new System.Drawing.Point(187, 12);
            this.btnGurSalesRep.Name = "btnGurSalesRep";
            this.btnGurSalesRep.Size = new System.Drawing.Size(92, 34);
            this.btnGurSalesRep.TabIndex = 26;
            this.btnGurSalesRep.Text = "Показать";
            this.btnGurSalesRep.UseVisualStyleBackColor = true;
            this.btnGurSalesRep.Click += new System.EventHandler(this.btnGurSalesRep_Click);
            // 
            // dgvCheki
            // 
            this.dgvCheki.AllowUserToAddRows = false;
            this.dgvCheki.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvCheki.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheki.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheki.Location = new System.Drawing.Point(4, 19);
            this.dgvCheki.Name = "dgvCheki";
            this.dgvCheki.ReadOnly = true;
            this.dgvCheki.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvCheki.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheki.Size = new System.Drawing.Size(503, 133);
            this.dgvCheki.TabIndex = 27;
            this.dgvCheki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCheki_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvCheki);
            this.groupBox1.Location = new System.Drawing.Point(300, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 163);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Чеки";
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(6, 12);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSostavChek);
            this.groupBox2.Location = new System.Drawing.Point(6, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 228);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Содержимое чека";
            // 
            // dgvSostavChek
            // 
            this.dgvSostavChek.AllowUserToAddRows = false;
            this.dgvSostavChek.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvSostavChek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSostavChek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSostavChek.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSostavChek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSostavChek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSostavChek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kod,
            this.namet,
            this.rcena,
            this.quantity,
            this.rsumm});
            this.dgvSostavChek.Location = new System.Drawing.Point(6, 19);
            this.dgvSostavChek.Name = "dgvSostavChek";
            this.dgvSostavChek.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvSostavChek.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSostavChek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSostavChek.Size = new System.Drawing.Size(795, 199);
            this.dgvSostavChek.TabIndex = 28;
            // 
            // kod
            // 
            this.kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kod.HeaderText = "Код";
            this.kod.Name = "kod";
            this.kod.ReadOnly = true;
            this.kod.Width = 60;
            // 
            // namet
            // 
            this.namet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namet.HeaderText = "Наименование";
            this.namet.Name = "namet";
            this.namet.ReadOnly = true;
            // 
            // rcena
            // 
            this.rcena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rcena.HeaderText = "Цена";
            this.rcena.Name = "rcena";
            this.rcena.ReadOnly = true;
            this.rcena.Width = 70;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.HeaderText = "Кол-во";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 83;
            // 
            // rsumm
            // 
            this.rsumm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rsumm.HeaderText = "Сумма";
            this.rsumm.Name = "rsumm";
            this.rsumm.ReadOnly = true;
            this.rsumm.Width = 81;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(8, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Общая выручка за день";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(285, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "Наличная выручка за день";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(557, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "По карте за день";
            // 
            // lblnalvir
            // 
            this.lblnalvir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblnalvir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnalvir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnalvir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblnalvir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnalvir.Location = new System.Drawing.Point(289, 463);
            this.lblnalvir.Name = "lblnalvir";
            this.lblnalvir.Size = new System.Drawing.Size(135, 39);
            this.lblnalvir.TabIndex = 35;
            this.lblnalvir.Text = "0";
            this.lblnalvir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblallvir
            // 
            this.lblallvir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblallvir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblallvir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblallvir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblallvir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblallvir.Location = new System.Drawing.Point(12, 463);
            this.lblallvir.Name = "lblallvir";
            this.lblallvir.Size = new System.Drawing.Size(135, 39);
            this.lblallvir.TabIndex = 34;
            this.lblallvir.Text = "0";
            this.lblallvir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbeznalvir
            // 
            this.lblbeznalvir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblbeznalvir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbeznalvir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbeznalvir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblbeznalvir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblbeznalvir.Location = new System.Drawing.Point(561, 463);
            this.lblbeznalvir.Name = "lblbeznalvir";
            this.lblbeznalvir.Size = new System.Drawing.Size(135, 39);
            this.lblbeznalvir.TabIndex = 36;
            this.lblbeznalvir.Text = "0";
            this.lblbeznalvir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNB
            // 
            this.btnNB.Location = new System.Drawing.Point(187, 69);
            this.btnNB.Name = "btnNB";
            this.btnNB.Size = new System.Drawing.Size(92, 34);
            this.btnNB.TabIndex = 37;
            this.btnNB.Text = "Н/Б";
            this.btnNB.UseVisualStyleBackColor = true;
            this.btnNB.Click += new System.EventHandler(this.btnNB_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(8, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(690, 37);
            this.label4.TabIndex = 38;
            this.label4.Text = "Чтобы посмотреть состав чека, выделите нужный вам \"Чек\" и нажмите клавишу \"Пробел" +
                "\"";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GurnalSalesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNB);
            this.Controls.Add(this.lblbeznalvir);
            this.Controls.Add(this.lblnalvir);
            this.Controls.Add(this.lblallvir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mCalendar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGurSalesRep);
            this.KeyPreview = true;
            this.Name = "GurnalSalesform";
            this.Text = "Журнал продаж";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GurnalSalesform_FormClosed);
            this.Load += new System.EventHandler(this.GurnalSalesform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GurnalSalesform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheki)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSostavChek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGurSalesRep;
        public System.Windows.Forms.DataGridView dgvCheki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvSostavChek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnalvir;
        private System.Windows.Forms.Label lblallvir;
        private System.Windows.Forms.Label lblbeznalvir;
        private System.Windows.Forms.Button btnNB;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn namet;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcena;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsumm;
        private System.Windows.Forms.Label label4;
    }
}