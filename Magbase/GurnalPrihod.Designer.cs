namespace MagbaseServer
{
    partial class GurnalPrihod
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
            this.cmbsup = new System.Windows.Forms.ComboBox();
            this.dtpPrih1 = new System.Windows.Forms.DateTimePicker();
            this.dtpPrih2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvGurPrih = new System.Windows.Forms.DataGridView();
            this.tlsPrih = new System.Windows.Forms.ToolStrip();
            this.tsbtnadd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnview = new System.Windows.Forms.ToolStripButton();
            this.tsbtnchange = new System.Windows.Forms.ToolStripButton();
            this.btnprihod = new System.Windows.Forms.Button();
            this.lblSumtxtP = new System.Windows.Forms.Label();
            this.lblSummP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGurPrih)).BeginInit();
            this.tlsPrih.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbsup
            // 
            this.cmbsup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsup.FormattingEnabled = true;
            this.cmbsup.Location = new System.Drawing.Point(12, 56);
            this.cmbsup.Name = "cmbsup";
            this.cmbsup.Size = new System.Drawing.Size(195, 21);
            this.cmbsup.TabIndex = 0;
            // 
            // dtpPrih1
            // 
            this.dtpPrih1.Location = new System.Drawing.Point(228, 57);
            this.dtpPrih1.Name = "dtpPrih1";
            this.dtpPrih1.Size = new System.Drawing.Size(130, 20);
            this.dtpPrih1.TabIndex = 1;
            // 
            // dtpPrih2
            // 
            this.dtpPrih2.Location = new System.Drawing.Point(373, 57);
            this.dtpPrih2.Name = "dtpPrih2";
            this.dtpPrih2.Size = new System.Drawing.Size(129, 20);
            this.dtpPrih2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(225, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Начало периода";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(370, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Конец периода";
            // 
            // dgvGurPrih
            // 
            this.dgvGurPrih.AllowUserToAddRows = false;
            this.dgvGurPrih.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvGurPrih.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGurPrih.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGurPrih.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGurPrih.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma",9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGurPrih.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGurPrih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGurPrih.Location = new System.Drawing.Point(12, 94);
            this.dgvGurPrih.Name = "dgvGurPrih";
            this.dgvGurPrih.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvGurPrih.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGurPrih.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGurPrih.Size = new System.Drawing.Size(992, 408);
            this.dgvGurPrih.TabIndex = 6;
            this.dgvGurPrih.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGurPrih_CellMouseDoubleClick);
            // 
            // tlsPrih
            // 
            this.tlsPrih.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsPrih.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnadd,
            this.tsbtnview,
            this.tsbtnchange});
            this.tlsPrih.Location = new System.Drawing.Point(0, 0);
            this.tlsPrih.Name = "tlsPrih";
            this.tlsPrih.Size = new System.Drawing.Size(1016, 39);
            this.tlsPrih.TabIndex = 7;
            this.tlsPrih.Text = "toolStrip1";
            // 
            // tsbtnadd
            // 
            this.tsbtnadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnadd.Image = global::MagbaseServer.Properties.Resources.new_32_doc;
            this.tsbtnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnadd.Name = "tsbtnadd";
            this.tsbtnadd.Size = new System.Drawing.Size(36, 36);
            this.tsbtnadd.Text = "+";
            this.tsbtnadd.ToolTipText = "Создать накладную";
            this.tsbtnadd.Click += new System.EventHandler(this.tsbtnadd_Click);
            // 
            // tsbtnview
            // 
            this.tsbtnview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnview.Image = global::MagbaseServer.Properties.Resources.docpr_32;
            this.tsbtnview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnview.Name = "tsbtnview";
            this.tsbtnview.Size = new System.Drawing.Size(36, 36);
            this.tsbtnview.Text = "Просмотр накладной";
            this.tsbtnview.Click += new System.EventHandler(this.tsbtnview_Click);
            // 
            // tsbtnchange
            // 
            this.tsbtnchange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnchange.Image = global::MagbaseServer.Properties.Resources.edit_32_doc;
            this.tsbtnchange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnchange.Name = "tsbtnchange";
            this.tsbtnchange.Size = new System.Drawing.Size(36, 36);
            this.tsbtnchange.Text = "Изменить";
            // 
            // btnprihod
            // 
            this.btnprihod.Location = new System.Drawing.Point(519, 50);
            this.btnprihod.Name = "btnprihod";
            this.btnprihod.Size = new System.Drawing.Size(130, 26);
            this.btnprihod.TabIndex = 8;
            this.btnprihod.Text = "Показать накладные";
            this.btnprihod.UseVisualStyleBackColor = true;
            this.btnprihod.Click += new System.EventHandler(this.btnprihod_Click);
            // 
            // lblSumtxtP
            // 
            this.lblSumtxtP.Location = new System.Drawing.Point(774, 50);
            this.lblSumtxtP.Name = "lblSumtxtP";
            this.lblSumtxtP.Size = new System.Drawing.Size(100, 41);
            this.lblSumtxtP.TabIndex = 9;
            this.lblSumtxtP.Text = "Сумма Приходных накладных";
            this.lblSumtxtP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSummP
            // 
            this.lblSummP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummP.ForeColor = System.Drawing.Color.Blue;
            this.lblSummP.Location = new System.Drawing.Point(881, 42);
            this.lblSummP.Name = "lblSummP";
            this.lblSummP.Size = new System.Drawing.Size(120, 38);
            this.lblSummP.TabIndex = 10;
            this.lblSummP.Text = "0";
            this.lblSummP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GurnalPrihod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.lblSummP);
            this.Controls.Add(this.lblSumtxtP);
            this.Controls.Add(this.btnprihod);
            this.Controls.Add(this.tlsPrih);
            this.Controls.Add(this.dgvGurPrih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPrih2);
            this.Controls.Add(this.dtpPrih1);
            this.Controls.Add(this.cmbsup);
            this.KeyPreview = true;
            this.Name = "GurnalPrihod";
            this.Text = "Журнал Приходных накладных";
            this.Load += new System.EventHandler(this.GurnalPrihod_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GurnalPrihod_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGurPrih)).EndInit();
            this.tlsPrih.ResumeLayout(false);
            this.tlsPrih.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbsup;
        private System.Windows.Forms.DateTimePicker dtpPrih1;
        private System.Windows.Forms.DateTimePicker dtpPrih2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvGurPrih;
        private System.Windows.Forms.ToolStrip tlsPrih;
        private System.Windows.Forms.ToolStripButton tsbtnadd;
        private System.Windows.Forms.ToolStripButton tsbtnchange;
        private System.Windows.Forms.Button btnprihod;
        private System.Windows.Forms.ToolStripButton tsbtnview;
        private System.Windows.Forms.Label lblSumtxtP;
        private System.Windows.Forms.Label lblSummP;
    }
}