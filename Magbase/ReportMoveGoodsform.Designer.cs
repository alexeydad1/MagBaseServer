namespace MagbaseServer
{
    partial class ReportMoveGoodsform
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
            this.dgvRepMove = new System.Windows.Forms.DataGridView();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstGoods = new System.Windows.Forms.ListBox();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.btnRunRep = new System.Windows.Forms.Button();
            this.dtpin = new System.Windows.Forms.DateTimePicker();
            this.dtpout = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGroupT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepMove)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepMove
            // 
            this.dgvRepMove.AllowUserToAddRows = false;
            this.dgvRepMove.AllowUserToDeleteRows = false;
            this.dgvRepMove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRepMove.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepMove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRepMove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepMove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kod,
            this.name,
            this.qty,
            this.cena});
            this.dgvRepMove.Location = new System.Drawing.Point(12, 82);
            this.dgvRepMove.Name = "dgvRepMove";
            this.dgvRepMove.ReadOnly = true;
            this.dgvRepMove.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvRepMove.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRepMove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepMove.Size = new System.Drawing.Size(992, 408);
            this.dgvRepMove.TabIndex = 26;
            this.dgvRepMove.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRepMove_CellMouseDoubleClick);
            // 
            // kod
            // 
            this.kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kod.HeaderText = "Код";
            this.kod.Name = "kod";
            this.kod.ReadOnly = true;
            this.kod.Width = 58;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Наименование/Документ";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "Количество";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 111;
            // 
            // cena
            // 
            this.cena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cena.HeaderText = "Цена";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            this.cena.Width = 67;
            // 
            // lstGoods
            // 
            this.lstGoods.FormattingEnabled = true;
            this.lstGoods.Location = new System.Drawing.Point(12, 12);
            this.lstGoods.Name = "lstGoods";
            this.lstGoods.Size = new System.Drawing.Size(347, 56);
            this.lstGoods.TabIndex = 27;
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Location = new System.Drawing.Point(490, 12);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(75, 56);
            this.btnAddGoods.TabIndex = 28;
            this.btnAddGoods.Text = "Добавить товар";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnRunRep
            // 
            this.btnRunRep.Location = new System.Drawing.Point(855, 12);
            this.btnRunRep.Name = "btnRunRep";
            this.btnRunRep.Size = new System.Drawing.Size(75, 45);
            this.btnRunRep.TabIndex = 29;
            this.btnRunRep.Text = "Запустить отчет";
            this.btnRunRep.UseVisualStyleBackColor = true;
            this.btnRunRep.Click += new System.EventHandler(this.btnRunRep_Click);
            // 
            // dtpin
            // 
            this.dtpin.Location = new System.Drawing.Point(686, 12);
            this.dtpin.Name = "dtpin";
            this.dtpin.Size = new System.Drawing.Size(127, 20);
            this.dtpin.TabIndex = 30;
            // 
            // dtpout
            // 
            this.dtpout.Location = new System.Drawing.Point(686, 47);
            this.dtpout.Name = "dtpout";
            this.dtpout.Size = new System.Drawing.Size(127, 20);
            this.dtpout.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Начало периода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Конец периода";
            // 
            // cmbGroupT
            // 
            this.cmbGroupT.FormattingEnabled = true;
            this.cmbGroupT.Location = new System.Drawing.Point(363, 25);
            this.cmbGroupT.Name = "cmbGroupT";
            this.cmbGroupT.Size = new System.Drawing.Size(121, 21);
            this.cmbGroupT.TabIndex = 34;
            this.cmbGroupT.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Группы товаров";
            this.label3.Visible = false;
            // 
            // ReportMoveGoodsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGroupT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpout);
            this.Controls.Add(this.dtpin);
            this.Controls.Add(this.btnRunRep);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.lstGoods);
            this.Controls.Add(this.dgvRepMove);
            this.KeyPreview = true;
            this.Name = "ReportMoveGoodsform";
            this.Text = "Отчет по движению товаров";
            this.Load += new System.EventHandler(this.ReportMoveGoodsform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportMoveGoodsform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepMove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvRepMove;
        private System.Windows.Forms.ListBox lstGoods;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Button btnRunRep;
        private System.Windows.Forms.DateTimePicker dtpin;
        private System.Windows.Forms.DateTimePicker dtpout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.ComboBox cmbGroupT;
        private System.Windows.Forms.Label label3;
    }
}