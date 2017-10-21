namespace MagbaseServer
{
    partial class Rform
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSummRashod = new System.Windows.Forms.Label();
            this.cmbSupR = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRNumdokmag = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvR = new System.Windows.Forms.DataGridView();
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRkodtovar = new System.Windows.Forms.TextBox();
            this.txtRshtovar = new System.Windows.Forms.TextBox();
            this.bntSaveR = new System.Windows.Forms.Button();
            this.btnDelP = new System.Windows.Forms.Button();
            this.msktxtDateDok = new System.Windows.Forms.MaskedTextBox();
            this.txtDokSup = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbllinedokR = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrintCennik = new System.Windows.Forms.Button();
            this.btnRefreshSup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).BeginInit();
            this.conMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(7, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 19);
            this.label13.TabIndex = 32;
            this.label13.Text = "Сумма Накладной";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSummRashod
            // 
            this.lblSummRashod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummRashod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummRashod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSummRashod.Location = new System.Drawing.Point(10, 81);
            this.lblSummRashod.Name = "lblSummRashod";
            this.lblSummRashod.Size = new System.Drawing.Size(138, 27);
            this.lblSummRashod.TabIndex = 31;
            this.lblSummRashod.Text = "0";
            this.lblSummRashod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSupR
            // 
            this.cmbSupR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSupR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupR.FormattingEnabled = true;
            this.cmbSupR.Location = new System.Drawing.Point(482, 26);
            this.cmbSupR.Name = "cmbSupR";
            this.cmbSupR.Size = new System.Drawing.Size(191, 21);
            this.cmbSupR.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Поставщик";
            // 
            // lblRNumdokmag
            // 
            this.lblRNumdokmag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRNumdokmag.Location = new System.Drawing.Point(357, 26);
            this.lblRNumdokmag.Name = "lblRNumdokmag";
            this.lblRNumdokmag.Size = new System.Drawing.Size(98, 20);
            this.lblRNumdokmag.TabIndex = 5;
            this.lblRNumdokmag.Text = "0";
            this.lblRNumdokmag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Номер документа";
            // 
            // dgvR
            // 
            this.dgvR.AllowUserToAddRows = false;
            this.dgvR.AllowUserToDeleteRows = false;
            this.dgvR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvR.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvR.ContextMenuStrip = this.conMenu;
            this.dgvR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvR.Location = new System.Drawing.Point(12, 132);
            this.dgvR.Name = "dgvR";
            this.dgvR.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvR.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvR.RowTemplate.Height = 32;
            this.dgvR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvR.Size = new System.Drawing.Size(992, 310);
            this.dgvR.StandardTab = true;
            this.dgvR.TabIndex = 7;
            this.dgvR.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvR_CellBeginEdit);
            this.dgvR.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvR_CellEndEdit);
            // 
            // conMenu
            // 
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMenuSelectAll,
            this.toolStripSeparator1,
            this.tSMenuCopy});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(181, 76);
            // 
            // tSMenuSelectAll
            // 
            this.tSMenuSelectAll.Name = "tSMenuSelectAll";
            this.tSMenuSelectAll.Size = new System.Drawing.Size(180, 22);
            this.tSMenuSelectAll.Text = "Выделить все Ctrl+A";
            this.tSMenuSelectAll.Click += new System.EventHandler(this.tSMenuSelectAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tSMenuCopy
            // 
            this.tSMenuCopy.Name = "tSMenuCopy";
            this.tSMenuCopy.Size = new System.Drawing.Size(180, 22);
            this.tSMenuCopy.Text = "Копировать Ctrl+C";
            this.tSMenuCopy.Click += new System.EventHandler(this.tSMenuCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Штрихкод";
            // 
            // txtRkodtovar
            // 
            this.txtRkodtovar.Location = new System.Drawing.Point(130, 27);
            this.txtRkodtovar.Name = "txtRkodtovar";
            this.txtRkodtovar.Size = new System.Drawing.Size(101, 20);
            this.txtRkodtovar.TabIndex = 1;
            this.txtRkodtovar.TextChanged += new System.EventHandler(this.txtRkodtovar_TextChanged);
            // 
            // txtRshtovar
            // 
            this.txtRshtovar.Location = new System.Drawing.Point(10, 27);
            this.txtRshtovar.Name = "txtRshtovar";
            this.txtRshtovar.Size = new System.Drawing.Size(101, 20);
            this.txtRshtovar.TabIndex = 0;
            this.txtRshtovar.TextChanged += new System.EventHandler(this.txtRshtovar_TextChanged);
            // 
            // bntSaveR
            // 
            this.bntSaveR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSaveR.Location = new System.Drawing.Point(892, 465);
            this.bntSaveR.Name = "bntSaveR";
            this.bntSaveR.Size = new System.Drawing.Size(116, 29);
            this.bntSaveR.TabIndex = 10;
            this.bntSaveR.Text = "Сохранить";
            this.bntSaveR.UseVisualStyleBackColor = true;
            this.bntSaveR.Click += new System.EventHandler(this.bntSaveP_Click);
            // 
            // btnDelP
            // 
            this.btnDelP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelP.Location = new System.Drawing.Point(16, 465);
            this.btnDelP.Name = "btnDelP";
            this.btnDelP.Size = new System.Drawing.Size(116, 29);
            this.btnDelP.TabIndex = 8;
            this.btnDelP.Text = "Удалить строку";
            this.btnDelP.UseVisualStyleBackColor = true;
            this.btnDelP.Click += new System.EventHandler(this.btnDelP_Click);
            // 
            // msktxtDateDok
            // 
            this.msktxtDateDok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msktxtDateDok.Location = new System.Drawing.Point(628, 69);
            this.msktxtDateDok.Mask = "00/00/00";
            this.msktxtDateDok.Name = "msktxtDateDok";
            this.msktxtDateDok.Size = new System.Drawing.Size(63, 20);
            this.msktxtDateDok.TabIndex = 6;
            this.msktxtDateDok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDokSup
            // 
            this.txtDokSup.Location = new System.Drawing.Point(482, 69);
            this.txtDokSup.Name = "txtDokSup";
            this.txtDokSup.Size = new System.Drawing.Size(116, 20);
            this.txtDokSup.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(625, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Дата документа Поставщика";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "№ Документа Поставщика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип накладной";
            this.label3.Visible = false;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(720, 25);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(159, 21);
            this.cmbType.TabIndex = 4;
            this.cmbType.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(302, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 24);
            this.label12.TabIndex = 62;
            this.label12.Text = "Строк в документе: ";
            // 
            // lbllinedokR
            // 
            this.lbllinedokR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbllinedokR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllinedokR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbllinedokR.Location = new System.Drawing.Point(500, 465);
            this.lbllinedokR.Name = "lbllinedokR";
            this.lbllinedokR.Size = new System.Drawing.Size(124, 24);
            this.lbllinedokR.TabIndex = 63;
            this.lbllinedokR.Text = "0";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(250, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 34);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Поиск товара";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(9, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Изменить количество или перевести фокус на табличную часть    F2";
            // 
            // btnPrintCennik
            // 
            this.btnPrintCennik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintCennik.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrintCennik.Image = global::MagbaseServer.Properties.Resources.print_32_doc;
            this.btnPrintCennik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCennik.Location = new System.Drawing.Point(737, 465);
            this.btnPrintCennik.Name = "btnPrintCennik";
            this.btnPrintCennik.Size = new System.Drawing.Size(142, 39);
            this.btnPrintCennik.TabIndex = 9;
            this.btnPrintCennik.Text = "Печать накладной";
            this.btnPrintCennik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCennik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintCennik.UseVisualStyleBackColor = true;
            this.btnPrintCennik.Click += new System.EventHandler(this.btnPrintCennik_Click);
            // 
            // btnRefreshSup
            // 
            this.btnRefreshSup.Image = global::MagbaseServer.Properties.Resources.arrow_refresh_3839;
            this.btnRefreshSup.Location = new System.Drawing.Point(678, 25);
            this.btnRefreshSup.Name = "btnRefreshSup";
            this.btnRefreshSup.Size = new System.Drawing.Size(31, 23);
            this.btnRefreshSup.TabIndex = 65;
            this.btnRefreshSup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRefreshSup.UseVisualStyleBackColor = true;
            this.btnRefreshSup.Click += new System.EventHandler(this.btnRefreshSup_Click);
            // 
            // Rform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.btnRefreshSup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbllinedokR);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msktxtDateDok);
            this.Controls.Add(this.txtDokSup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bntSaveR);
            this.Controls.Add(this.btnDelP);
            this.Controls.Add(this.btnPrintCennik);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSummRashod);
            this.Controls.Add(this.cmbSupR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRNumdokmag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRkodtovar);
            this.Controls.Add(this.txtRshtovar);
            this.KeyPreview = true;
            this.Name = "Rform";
            this.Text = "Расходная накладная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rform_FormClosing);
            this.Load += new System.EventHandler(this.Rform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).EndInit();
            this.conMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSummRashod;
        private System.Windows.Forms.ComboBox cmbSupR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRNumdokmag;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgvR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRkodtovar;
        private System.Windows.Forms.TextBox txtRshtovar;
        public System.Windows.Forms.Button btnPrintCennik;
        private System.Windows.Forms.Button bntSaveR;
        private System.Windows.Forms.Button btnDelP;
        private System.Windows.Forms.MaskedTextBox msktxtDateDok;
        private System.Windows.Forms.TextBox txtDokSup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbllinedokR;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefreshSup;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem tSMenuSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tSMenuCopy;
    }
}