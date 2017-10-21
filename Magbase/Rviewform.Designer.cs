namespace MagbaseServer
{
    partial class Rviewform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rviewform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.cmbRVSup = new System.Windows.Forms.ComboBox();
            this.lblNumdokmagRV = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPrintCennikRV = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSummPrihodRV = new System.Windows.Forms.Label();
            this.msktxtDateDokRV = new System.Windows.Forms.MaskedTextBox();
            this.txtDokSupRV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvRview = new System.Windows.Forms.DataGridView();
            this.lbllinedokRV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRview)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "№ Документа Поставщика";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Поставщик";
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.ShowHelp = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // cmbRVSup
            // 
            this.cmbRVSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRVSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRVSup.Enabled = false;
            this.cmbRVSup.FormattingEnabled = true;
            this.cmbRVSup.Location = new System.Drawing.Point(133, 27);
            this.cmbRVSup.Name = "cmbRVSup";
            this.cmbRVSup.Size = new System.Drawing.Size(191, 21);
            this.cmbRVSup.TabIndex = 52;
            // 
            // lblNumdokmagRV
            // 
            this.lblNumdokmagRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumdokmagRV.Location = new System.Drawing.Point(16, 27);
            this.lblNumdokmagRV.Name = "lblNumdokmagRV";
            this.lblNumdokmagRV.Size = new System.Drawing.Size(98, 20);
            this.lblNumdokmagRV.TabIndex = 50;
            this.lblNumdokmagRV.Text = "0";
            this.lblNumdokmagRV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(640, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 19);
            this.label13.TabIndex = 58;
            this.label13.Text = "Сумма Накладной";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Дата документа Поставщика";
            // 
            // btnPrintCennikRV
            // 
            this.btnPrintCennikRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintCennikRV.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrintCennikRV.Image = global::MagbaseServer.Properties.Resources.print_32_doc;
            this.btnPrintCennikRV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCennikRV.Location = new System.Drawing.Point(906, 466);
            this.btnPrintCennikRV.Name = "btnPrintCennikRV";
            this.btnPrintCennikRV.Size = new System.Drawing.Size(98, 49);
            this.btnPrintCennikRV.TabIndex = 59;
            this.btnPrintCennikRV.Text = "Печать ценников";
            this.btnPrintCennikRV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCennikRV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintCennikRV.UseVisualStyleBackColor = true;
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
            this.label12.TabIndex = 60;
            this.label12.Text = "Строк в документе: ";
            // 
            // lblSummPrihodRV
            // 
            this.lblSummPrihodRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummPrihodRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummPrihodRV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSummPrihodRV.Location = new System.Drawing.Point(643, 29);
            this.lblSummPrihodRV.Name = "lblSummPrihodRV";
            this.lblSummPrihodRV.Size = new System.Drawing.Size(138, 27);
            this.lblSummPrihodRV.TabIndex = 57;
            this.lblSummPrihodRV.Text = "0";
            this.lblSummPrihodRV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msktxtDateDokRV
            // 
            this.msktxtDateDokRV.Enabled = false;
            this.msktxtDateDokRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msktxtDateDokRV.Location = new System.Drawing.Point(480, 28);
            this.msktxtDateDokRV.Mask = "00/00/00";
            this.msktxtDateDokRV.Name = "msktxtDateDokRV";
            this.msktxtDateDokRV.Size = new System.Drawing.Size(63, 20);
            this.msktxtDateDokRV.TabIndex = 56;
            this.msktxtDateDokRV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDokSupRV
            // 
            this.txtDokSupRV.Enabled = false;
            this.txtDokSupRV.Location = new System.Drawing.Point(334, 28);
            this.txtDokSupRV.Name = "txtDokSupRV";
            this.txtDokSupRV.Size = new System.Drawing.Size(116, 20);
            this.txtDokSupRV.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Номер документа";
            // 
            // dgvRview
            // 
            this.dgvRview.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvRview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRview.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma",9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRview.Location = new System.Drawing.Point(15, 72);
            this.dgvRview.Name = "dgvRview";
            this.dgvRview.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvRview.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRview.RowTemplate.Height = 32;
            this.dgvRview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRview.Size = new System.Drawing.Size(992, 388);
            this.dgvRview.TabIndex = 48;
            // 
            // lbllinedokRV
            // 
            this.lbllinedokRV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbllinedokRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllinedokRV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbllinedokRV.Location = new System.Drawing.Point(549, 466);
            this.lbllinedokRV.Name = "lbllinedokRV";
            this.lbllinedokRV.Size = new System.Drawing.Size(254, 24);
            this.lbllinedokRV.TabIndex = 61;
            this.lbllinedokRV.Text = "0";
            // 
            // Rviewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbRVSup);
            this.Controls.Add(this.lblNumdokmagRV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPrintCennikRV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSummPrihodRV);
            this.Controls.Add(this.msktxtDateDokRV);
            this.Controls.Add(this.txtDokSupRV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvRview);
            this.Controls.Add(this.lbllinedokRV);
            this.KeyPreview = true;
            this.Name = "Rviewform";
            this.Text = "Расходная накладная-ПРОСМОТР";
            this.Load += new System.EventHandler(this.Rviewform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rviewform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox cmbRVSup;
        private System.Windows.Forms.Label lblNumdokmagRV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnPrintCennikRV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSummPrihodRV;
        private System.Windows.Forms.MaskedTextBox msktxtDateDokRV;
        private System.Windows.Forms.TextBox txtDokSupRV;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgvRview;
        private System.Windows.Forms.Label lbllinedokRV;
    }
}