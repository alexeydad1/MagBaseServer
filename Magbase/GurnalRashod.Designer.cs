namespace MagbaseServer
{
    partial class GurnalRashod
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
            this.btnrashod = new System.Windows.Forms.Button();
            this.tlsrash = new System.Windows.Forms.ToolStrip();
            this.tsbtnadd = new System.Windows.Forms.ToolStripButton();
            this.tsbVievRV = new System.Windows.Forms.ToolStripButton();
            this.tsbtnchange = new System.Windows.Forms.ToolStripButton();
            this.dgvGurRash = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRash2 = new System.Windows.Forms.DateTimePicker();
            this.dtpRash1 = new System.Windows.Forms.DateTimePicker();
            this.cmbsup = new System.Windows.Forms.ComboBox();
            this.lblSummR = new System.Windows.Forms.Label();
            this.lblSumtxtR = new System.Windows.Forms.Label();
            this.tlsrash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGurRash)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrashod
            // 
            this.btnrashod.Location = new System.Drawing.Point(539, 50);
            this.btnrashod.Name = "btnrashod";
            this.btnrashod.Size = new System.Drawing.Size(130, 26);
            this.btnrashod.TabIndex = 17;
            this.btnrashod.Text = "Показать накладные";
            this.btnrashod.UseVisualStyleBackColor = true;
            this.btnrashod.Click += new System.EventHandler(this.btnprihod_Click);
            // 
            // tlsrash
            // 
            this.tlsrash.BackColor = System.Drawing.SystemColors.Control;
            this.tlsrash.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsrash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnadd,
            this.tsbVievRV,
            this.tsbtnchange});
            this.tlsrash.Location = new System.Drawing.Point(0, 0);
            this.tlsrash.Name = "tlsrash";
            this.tlsrash.Size = new System.Drawing.Size(1016, 39);
            this.tlsrash.TabIndex = 16;
            this.tlsrash.Text = "toolStrip1";
            // 
            // tsbtnadd
            // 
            this.tsbtnadd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsbtnadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnadd.Image = global::MagbaseServer.Properties.Resources.new_32_doc;
            this.tsbtnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnadd.Name = "tsbtnadd";
            this.tsbtnadd.Size = new System.Drawing.Size(36, 36);
            this.tsbtnadd.Text = "+";
            this.tsbtnadd.ToolTipText = "Созадть накладную";
            this.tsbtnadd.Click += new System.EventHandler(this.tsbtnadd_Click);
            // 
            // tsbVievRV
            // 
            this.tsbVievRV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsbVievRV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVievRV.Image = global::MagbaseServer.Properties.Resources.docpr_32;
            this.tsbVievRV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVievRV.Name = "tsbVievRV";
            this.tsbVievRV.Size = new System.Drawing.Size(36, 36);
            this.tsbVievRV.Text = "Просмотр накладной";
            this.tsbVievRV.Click += new System.EventHandler(this.tsbVievRV_Click);
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
            // dgvGurRash
            // 
            this.dgvGurRash.AllowUserToAddRows = false;
            this.dgvGurRash.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvGurRash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGurRash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGurRash.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma",9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGurRash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGurRash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGurRash.Location = new System.Drawing.Point(12, 94);
            this.dgvGurRash.Name = "dgvGurRash";
            this.dgvGurRash.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvGurRash.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGurRash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGurRash.Size = new System.Drawing.Size(992, 408);
            this.dgvGurRash.TabIndex = 15;
            this.dgvGurRash.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGurRash_CellMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(390, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Конец периода";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(223, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Начало периода";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Поставщик";
            // 
            // dtpRash2
            // 
            this.dtpRash2.Location = new System.Drawing.Point(393, 57);
            this.dtpRash2.Name = "dtpRash2";
            this.dtpRash2.Size = new System.Drawing.Size(129, 20);
            this.dtpRash2.TabIndex = 11;
            // 
            // dtpRash1
            // 
            this.dtpRash1.Location = new System.Drawing.Point(226, 57);
            this.dtpRash1.Name = "dtpRash1";
            this.dtpRash1.Size = new System.Drawing.Size(147, 20);
            this.dtpRash1.TabIndex = 10;
            // 
            // cmbsup
            // 
            this.cmbsup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsup.FormattingEnabled = true;
            this.cmbsup.Location = new System.Drawing.Point(12, 56);
            this.cmbsup.Name = "cmbsup";
            this.cmbsup.Size = new System.Drawing.Size(195, 21);
            this.cmbsup.TabIndex = 9;
            // 
            // lblSummR
            // 
            this.lblSummR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummR.ForeColor = System.Drawing.Color.Blue;
            this.lblSummR.Location = new System.Drawing.Point(800, 42);
            this.lblSummR.Name = "lblSummR";
            this.lblSummR.Size = new System.Drawing.Size(120, 38);
            this.lblSummR.TabIndex = 19;
            this.lblSummR.Text = "0";
            this.lblSummR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumtxtR
            // 
            this.lblSumtxtR.Location = new System.Drawing.Point(695, 50);
            this.lblSumtxtR.Name = "lblSumtxtR";
            this.lblSumtxtR.Size = new System.Drawing.Size(99, 30);
            this.lblSumtxtR.TabIndex = 18;
            this.lblSumtxtR.Text = "Сумма Расходных накладных";
            this.lblSumtxtR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GurnalRashod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.lblSummR);
            this.Controls.Add(this.lblSumtxtR);
            this.Controls.Add(this.btnrashod);
            this.Controls.Add(this.tlsrash);
            this.Controls.Add(this.dgvGurRash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpRash2);
            this.Controls.Add(this.dtpRash1);
            this.Controls.Add(this.cmbsup);
            this.KeyPreview = true;
            this.Name = "GurnalRashod";
            this.Text = "Журнал Расходных накладных";
            this.Load += new System.EventHandler(this.GurnalRashod_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GurnalRashod_KeyDown);
            this.tlsrash.ResumeLayout(false);
            this.tlsrash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGurRash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrashod;
        private System.Windows.Forms.ToolStrip tlsrash;
        private System.Windows.Forms.ToolStripButton tsbtnadd;
        private System.Windows.Forms.ToolStripButton tsbtnchange;
        public System.Windows.Forms.DataGridView dgvGurRash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRash2;
        private System.Windows.Forms.DateTimePicker dtpRash1;
        private System.Windows.Forms.ComboBox cmbsup;
        private System.Windows.Forms.ToolStripButton tsbVievRV;
        private System.Windows.Forms.Label lblSummR;
        private System.Windows.Forms.Label lblSumtxtR;
    }
}