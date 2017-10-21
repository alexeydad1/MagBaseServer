namespace MagbaseServer
{
    partial class GurnalPereocenkiform
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
            this.txtKodGurPereocen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbtnadd = new System.Windows.Forms.ToolStripButton();
            this.btnPereocenki = new System.Windows.Forms.Button();
            this.tlsPrih = new System.Windows.Forms.ToolStrip();
            this.dgvGurPereocenka = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPereocenka2 = new System.Windows.Forms.DateTimePicker();
            this.dtpPereocenka1 = new System.Windows.Forms.DateTimePicker();
            this.tlsPrih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGurPereocenka)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKodGurPereocen
            // 
            this.txtKodGurPereocen.Location = new System.Drawing.Point(13, 56);
            this.txtKodGurPereocen.Name = "txtKodGurPereocen";
            this.txtKodGurPereocen.Size = new System.Drawing.Size(100, 20);
            this.txtKodGurPereocen.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Код товара";
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrint.Image = global::MagbaseServer.Properties.Resources.print_32_doc;
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(36, 36);
            this.tsbtnPrint.Text = "Просмотр накладной";
            this.tsbtnPrint.Click += new System.EventHandler(this.tsbtnPrint_Click);
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
            // btnPereocenki
            // 
            this.btnPereocenki.Location = new System.Drawing.Point(414, 50);
            this.btnPereocenki.Name = "btnPereocenki";
            this.btnPereocenki.Size = new System.Drawing.Size(130, 26);
            this.btnPereocenki.TabIndex = 21;
            this.btnPereocenki.Text = "Показать Переоценки";
            this.btnPereocenki.UseVisualStyleBackColor = true;
            this.btnPereocenki.Click += new System.EventHandler(this.btnPereocenki_Click);
            // 
            // tlsPrih
            // 
            this.tlsPrih.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsPrih.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnadd,
            this.tsbtnPrint});
            this.tlsPrih.Location = new System.Drawing.Point(0, 0);
            this.tlsPrih.Name = "tlsPrih";
            this.tlsPrih.Size = new System.Drawing.Size(1016, 39);
            this.tlsPrih.TabIndex = 20;
            this.tlsPrih.Text = "toolStrip1";
            // 
            // dgvGurPereocenka
            // 
            this.dgvGurPereocenka.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvGurPereocenka.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGurPereocenka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGurPereocenka.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma",9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGurPereocenka.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGurPereocenka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGurPereocenka.Location = new System.Drawing.Point(12, 94);
            this.dgvGurPereocenka.Name = "dgvGurPereocenka";
            this.dgvGurPereocenka.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvGurPereocenka.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGurPereocenka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGurPereocenka.Size = new System.Drawing.Size(992, 408);
            this.dgvGurPereocenka.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(265, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Конец периода";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(120, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Начало периода";
            // 
            // dtpPereocenka2
            // 
            this.dtpPereocenka2.Location = new System.Drawing.Point(268, 56);
            this.dtpPereocenka2.Name = "dtpPereocenka2";
            this.dtpPereocenka2.Size = new System.Drawing.Size(129, 20);
            this.dtpPereocenka2.TabIndex = 15;
            // 
            // dtpPereocenka1
            // 
            this.dtpPereocenka1.Location = new System.Drawing.Point(123, 56);
            this.dtpPereocenka1.Name = "dtpPereocenka1";
            this.dtpPereocenka1.Size = new System.Drawing.Size(130, 20);
            this.dtpPereocenka1.TabIndex = 14;
            // 
            // GurnalPereocenkiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.txtKodGurPereocen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPereocenki);
            this.Controls.Add(this.tlsPrih);
            this.Controls.Add(this.dgvGurPereocenka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPereocenka2);
            this.Controls.Add(this.dtpPereocenka1);
            this.KeyPreview = true;
            this.Name = "GurnalPereocenkiform";
            this.Text = "Журнал Переоценки";
            this.Load += new System.EventHandler(this.GurnalPereocenkiform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GurnalPereocenkiform_KeyDown);
            this.tlsPrih.ResumeLayout(false);
            this.tlsPrih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGurPereocenka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKodGurPereocen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton tsbtnPrint;
        private System.Windows.Forms.ToolStripButton tsbtnadd;
        private System.Windows.Forms.Button btnPereocenki;
        private System.Windows.Forms.ToolStrip tlsPrih;
        public System.Windows.Forms.DataGridView dgvGurPereocenka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPereocenka2;
        private System.Windows.Forms.DateTimePicker dtpPereocenka1;
    }
}