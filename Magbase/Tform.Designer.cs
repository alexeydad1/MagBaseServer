namespace MagbaseServer
{
    partial class Tform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtShtovar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProbit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.btnFindT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSumChekTform = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.ckbVozvrat = new System.Windows.Forms.CheckBox();
            this.btnGurnalSales = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbPrintchek = new System.Windows.Forms.CheckBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.conMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtShtovar
            // 
            this.txtShtovar.Location = new System.Drawing.Point(12, 25);
            this.txtShtovar.MaxLength = 0;
            this.txtShtovar.Name = "txtShtovar";
            this.txtShtovar.Size = new System.Drawing.Size(101, 20);
            this.txtShtovar.TabIndex = 0;
            this.txtShtovar.TextChanged += new System.EventHandler(this.txtShtovar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Штрихкод";
            // 
            // dGV
            // 
            this.dGV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.ContextMenuStrip = this.conMenu;
            this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dGV.Location = new System.Drawing.Point(12, 86);
            this.dGV.Name = "dGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV.RowTemplate.Height = 32;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(992, 423);
            this.dGV.StandardTab = true;
            this.dGV.TabIndex = 5;
            this.dGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGV_RowsRemoved);
            // 
            // conMenu
            // 
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMenuSelectAll,
            this.toolStripSeparator1,
            this.tSMenuCopy});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(181, 54);
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
            // btnProbit
            // 
            this.btnProbit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProbit.Location = new System.Drawing.Point(886, 515);
            this.btnProbit.Name = "btnProbit";
            this.btnProbit.Size = new System.Drawing.Size(118, 29);
            this.btnProbit.TabIndex = 7;
            this.btnProbit.Text = "Пробить Чек       F5";
            this.btnProbit.UseVisualStyleBackColor = true;
            this.btnProbit.Click += new System.EventHandler(this.btnProbit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код товара";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(122, 25);
            this.txtKod.MaxLength = 0;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(101, 20);
            this.txtKod.TabIndex = 1;
            this.txtKod.TextChanged += new System.EventHandler(this.txtKod_TextChanged);
            // 
            // btnFindT
            // 
            this.btnFindT.Location = new System.Drawing.Point(239, 17);
            this.btnFindT.Name = "btnFindT";
            this.btnFindT.Size = new System.Drawing.Size(101, 35);
            this.btnFindT.TabIndex = 2;
            this.btnFindT.Text = "Поиск товара";
            this.btnFindT.UseVisualStyleBackColor = true;
            this.btnFindT.Click += new System.EventHandler(this.btnFindT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSumChekTform);
            this.groupBox2.Location = new System.Drawing.Point(620, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 71);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сумма чека";
            // 
            // lblSumChekTform
            // 
            this.lblSumChekTform.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumChekTform.ForeColor = System.Drawing.Color.Blue;
            this.lblSumChekTform.Location = new System.Drawing.Point(9, 21);
            this.lblSumChekTform.Name = "lblSumChekTform";
            this.lblSumChekTform.Size = new System.Drawing.Size(163, 35);
            this.lblSumChekTform.TabIndex = 0;
            this.lblSumChekTform.Text = "0";
            this.lblSumChekTform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDel.Location = new System.Drawing.Point(12, 515);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(124, 29);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Удалить строку  Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // ckbVozvrat
            // 
            this.ckbVozvrat.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbVozvrat.BackColor = System.Drawing.SystemColors.Control;
            this.ckbVozvrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbVozvrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbVozvrat.ForeColor = System.Drawing.Color.Black;
            this.ckbVozvrat.Location = new System.Drawing.Point(817, 12);
            this.ckbVozvrat.Name = "ckbVozvrat";
            this.ckbVozvrat.Size = new System.Drawing.Size(117, 68);
            this.ckbVozvrat.TabIndex = 4;
            this.ckbVozvrat.Text = "Возврат продажи";
            this.ckbVozvrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbVozvrat.UseVisualStyleBackColor = false;
            this.ckbVozvrat.CheckedChanged += new System.EventHandler(this.ckbVozvrat_CheckedChanged);
            // 
            // btnGurnalSales
            // 
            this.btnGurnalSales.Location = new System.Drawing.Point(358, 17);
            this.btnGurnalSales.Name = "btnGurnalSales";
            this.btnGurnalSales.Size = new System.Drawing.Size(101, 35);
            this.btnGurnalSales.TabIndex = 3;
            this.btnGurnalSales.Text = "Журнал продаж";
            this.btnGurnalSales.UseVisualStyleBackColor = true;
            this.btnGurnalSales.Click += new System.EventHandler(this.btnGurnalSales_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Изменить количество или перевести фокус на табличную часть    F2";
            // 
            // ckbPrintchek
            // 
            this.ckbPrintchek.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ckbPrintchek.AutoSize = true;
            this.ckbPrintchek.Location = new System.Drawing.Point(420, 527);
            this.ckbPrintchek.Name = "ckbPrintchek";
            this.ckbPrintchek.Size = new System.Drawing.Size(93, 17);
            this.ckbPrintchek.TabIndex = 14;
            this.ckbPrintchek.Text = "Печатать чек";
            this.ckbPrintchek.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(478, 17);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(101, 35);
            this.btnCash.TabIndex = 15;
            this.btnCash.Text = "Наличные";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.ckbPrintchek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGurnalSales);
            this.Controls.Add(this.ckbVozvrat);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFindT);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProbit);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShtovar);
            this.KeyPreview = true;
            this.Name = "Tform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Торговля";
            this.Activated += new System.EventHandler(this.Tform_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tform_FormClosing);
            this.Load += new System.EventHandler(this.Tform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.conMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtShtovar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btnProbit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button btnFindT;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblSumChekTform;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.CheckBox ckbVozvrat;
        private System.Windows.Forms.Button btnGurnalSales;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox ckbPrintchek;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem tSMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem tSMenuSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button button1;

    }
}