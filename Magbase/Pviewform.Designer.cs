namespace MagbaseServer
{
    partial class Pviewform
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
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumdokmag = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSummPrihod = new System.Windows.Forms.Label();
            this.msktxtDateDok = new System.Windows.Forms.MaskedTextBox();
            this.txtDokSup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPview = new System.Windows.Forms.DataGridView();
            this.lbllinedok = new System.Windows.Forms.Label();
            this.btnPrintCennik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPview)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "№ Документа Поставщика";
            // 
            // cmbSup
            // 
            this.cmbSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSup.Enabled = false;
            this.cmbSup.FormattingEnabled = true;
            this.cmbSup.Location = new System.Drawing.Point(133, 27);
            this.cmbSup.Name = "cmbSup";
            this.cmbSup.Size = new System.Drawing.Size(191, 21);
            this.cmbSup.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Поставщик";
            // 
            // lblNumdokmag
            // 
            this.lblNumdokmag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumdokmag.Location = new System.Drawing.Point(16, 27);
            this.lblNumdokmag.Name = "lblNumdokmag";
            this.lblNumdokmag.Size = new System.Drawing.Size(98, 20);
            this.lblNumdokmag.TabIndex = 36;
            this.lblNumdokmag.Text = "0";
            this.lblNumdokmag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(640, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 19);
            this.label13.TabIndex = 44;
            this.label13.Text = "Сумма Накладной";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Дата документа Поставщика";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(351, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 24);
            this.label12.TabIndex = 46;
            this.label12.Text = "Строк в документе: ";
            // 
            // lblSummPrihod
            // 
            this.lblSummPrihod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummPrihod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummPrihod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSummPrihod.Location = new System.Drawing.Point(643, 29);
            this.lblSummPrihod.Name = "lblSummPrihod";
            this.lblSummPrihod.Size = new System.Drawing.Size(138, 27);
            this.lblSummPrihod.TabIndex = 43;
            this.lblSummPrihod.Text = "0";
            this.lblSummPrihod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msktxtDateDok
            // 
            this.msktxtDateDok.Enabled = false;
            this.msktxtDateDok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msktxtDateDok.Location = new System.Drawing.Point(480, 28);
            this.msktxtDateDok.Mask = "00/00/00";
            this.msktxtDateDok.Name = "msktxtDateDok";
            this.msktxtDateDok.Size = new System.Drawing.Size(63, 20);
            this.msktxtDateDok.TabIndex = 42;
            this.msktxtDateDok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDokSup
            // 
            this.txtDokSup.Enabled = false;
            this.txtDokSup.Location = new System.Drawing.Point(334, 28);
            this.txtDokSup.Name = "txtDokSup";
            this.txtDokSup.Size = new System.Drawing.Size(116, 20);
            this.txtDokSup.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Номер документа";
            // 
            // dgvPview
            // 
            this.dgvPview.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvPview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma",9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPview.Location = new System.Drawing.Point(15, 72);
            this.dgvPview.Name = "dgvPview";
            this.dgvPview.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvPview.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPview.RowTemplate.Height = 32;
            this.dgvPview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPview.Size = new System.Drawing.Size(992, 388);
            this.dgvPview.TabIndex = 32;
            this.dgvPview.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPview_ColumnHeaderMouseClick);
            // 
            // lbllinedok
            // 
            this.lbllinedok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbllinedok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllinedok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbllinedok.Location = new System.Drawing.Point(549, 466);
            this.lbllinedok.Name = "lbllinedok";
            this.lbllinedok.Size = new System.Drawing.Size(153, 24);
            this.lbllinedok.TabIndex = 47;
            this.lbllinedok.Text = "0";
            // 
            // btnPrintCennik
            // 
            this.btnPrintCennik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintCennik.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrintCennik.Image = global::MagbaseServer.Properties.Resources.print_32_doc;
            this.btnPrintCennik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCennik.Location = new System.Drawing.Point(906, 466);
            this.btnPrintCennik.Name = "btnPrintCennik";
            this.btnPrintCennik.Size = new System.Drawing.Size(98, 49);
            this.btnPrintCennik.TabIndex = 45;
            this.btnPrintCennik.Text = "Печать ценников";
            this.btnPrintCennik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCennik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintCennik.UseVisualStyleBackColor = true;
            this.btnPrintCennik.Click += new System.EventHandler(this.btnPrintCennik_Click);
            // 
            // Pviewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbSup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNumdokmag);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPrintCennik);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSummPrihod);
            this.Controls.Add(this.msktxtDateDok);
            this.Controls.Add(this.txtDokSup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvPview);
            this.Controls.Add(this.lbllinedok);
            this.KeyPreview = true;
            this.Name = "Pviewform";
            this.Text = "Приходная накладная-ПРОСМОТР";
            this.Load += new System.EventHandler(this.Pviewform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pviewform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumdokmag;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnPrintCennik;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSummPrihod;
        private System.Windows.Forms.MaskedTextBox msktxtDateDok;
        private System.Windows.Forms.TextBox txtDokSup;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgvPview;
        private System.Windows.Forms.Label lbllinedok;
    }
}