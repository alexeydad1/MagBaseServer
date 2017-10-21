namespace MagbaseServer
{
    partial class FindTovarform
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindT = new System.Windows.Forms.TextBox();
            this.btnFindTovar = new System.Windows.Forms.Button();
            this.dgvFindT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSFindfrm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMISelectALL = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMICopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMIRozn = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIZakup = new System.Windows.Forms.ToolStripMenuItem();
            this.ckbOst = new System.Windows.Forms.CheckBox();
            this.lblFindpos = new System.Windows.Forms.Label();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindT)).BeginInit();
            this.cMSFindfrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поиск";
            // 
            // txtFindT
            // 
            this.txtFindT.Location = new System.Drawing.Point(143, 25);
            this.txtFindT.Name = "txtFindT";
            this.txtFindT.Size = new System.Drawing.Size(145, 20);
            this.txtFindT.TabIndex = 0;
            // 
            // btnFindTovar
            // 
            this.btnFindTovar.Location = new System.Drawing.Point(407, 21);
            this.btnFindTovar.Name = "btnFindTovar";
            this.btnFindTovar.Size = new System.Drawing.Size(78, 27);
            this.btnFindTovar.TabIndex = 2;
            this.btnFindTovar.Text = "Найти";
            this.btnFindTovar.UseVisualStyleBackColor = true;
            this.btnFindTovar.Click += new System.EventHandler(this.btnFindTovar_Click);
            // 
            // dgvFindT
            // 
            this.dgvFindT.AllowUserToAddRows = false;
            this.dgvFindT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvFindT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFindT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFindT.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFindT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvFindT.ContextMenuStrip = this.cMSFindfrm;
            this.dgvFindT.Location = new System.Drawing.Point(15, 61);
            this.dgvFindT.Name = "dgvFindT";
            this.dgvFindT.ReadOnly = true;
            this.dgvFindT.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvFindT.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFindT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindT.Size = new System.Drawing.Size(815, 275);
            this.dgvFindT.StandardTab = true;
            this.dgvFindT.TabIndex = 3;
            this.dgvFindT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvFindT_KeyPress);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 58;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Кол-во";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Цена";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 67;
            // 
            // cMSFindfrm
            // 
            this.cMSFindfrm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMISelectALL,
            this.tSMICopy,
            this.toolStripSeparator1,
            this.tSMIRozn,
            this.tSMIZakup});
            this.cMSFindfrm.Name = "cMSFindfrm";
            this.cMSFindfrm.Size = new System.Drawing.Size(203, 98);
            // 
            // tSMISelectALL
            // 
            this.tSMISelectALL.Name = "tSMISelectALL";
            this.tSMISelectALL.Size = new System.Drawing.Size(202, 22);
            this.tSMISelectALL.Text = "Выделить все    Ctrl+A";
            this.tSMISelectALL.Click += new System.EventHandler(this.tSMISelectALL_Click);
            // 
            // tSMICopy
            // 
            this.tSMICopy.Name = "tSMICopy";
            this.tSMICopy.Size = new System.Drawing.Size(202, 22);
            this.tSMICopy.Text = "Копировать     Ctrl+C";
            this.tSMICopy.Click += new System.EventHandler(this.tSMICopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // tSMIRozn
            // 
            this.tSMIRozn.Name = "tSMIRozn";
            this.tSMIRozn.Size = new System.Drawing.Size(202, 22);
            this.tSMIRozn.Text = "История Розничных цен";
            this.tSMIRozn.Click += new System.EventHandler(this.tSMIRozn_Click);
            // 
            // tSMIZakup
            // 
            this.tSMIZakup.Name = "tSMIZakup";
            this.tSMIZakup.Size = new System.Drawing.Size(202, 22);
            this.tSMIZakup.Text = "История Закупочных цен";
            this.tSMIZakup.Click += new System.EventHandler(this.tSMIZakup_Click);
            // 
            // ckbOst
            // 
            this.ckbOst.AutoSize = true;
            this.ckbOst.Location = new System.Drawing.Point(294, 24);
            this.ckbOst.Name = "ckbOst";
            this.ckbOst.Size = new System.Drawing.Size(107, 17);
            this.ckbOst.TabIndex = 1;
            this.ckbOst.Text = "Только наличие";
            this.ckbOst.UseVisualStyleBackColor = true;
            // 
            // lblFindpos
            // 
            this.lblFindpos.AutoSize = true;
            this.lblFindpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFindpos.ForeColor = System.Drawing.Color.Blue;
            this.lblFindpos.Location = new System.Drawing.Point(491, 24);
            this.lblFindpos.Name = "lblFindpos";
            this.lblFindpos.Size = new System.Drawing.Size(173, 20);
            this.lblFindpos.TabIndex = 5;
            this.lblFindpos.Text = "Найдено 0 позиций";
            // 
            // cmbFind
            // 
            this.cmbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(16, 24);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(121, 21);
            this.cmbFind.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вид поиска";
            // 
            // FindTovarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.lblFindpos);
            this.Controls.Add(this.ckbOst);
            this.Controls.Add(this.btnFindTovar);
            this.Controls.Add(this.dgvFindT);
            this.Controls.Add(this.txtFindT);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FindTovarform";
            this.Text = "Поиск товара";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindTovarform_FormClosed);
            this.Load += new System.EventHandler(this.FindTovarform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindTovarform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindT)).EndInit();
            this.cMSFindfrm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindT;
        private System.Windows.Forms.Button btnFindTovar;
        private System.Windows.Forms.DataGridView dgvFindT;
        private System.Windows.Forms.CheckBox ckbOst;
        private System.Windows.Forms.Label lblFindpos;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ContextMenuStrip cMSFindfrm;
        private System.Windows.Forms.ToolStripMenuItem tSMICopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tSMIRozn;
        private System.Windows.Forms.ToolStripMenuItem tSMIZakup;
        private System.Windows.Forms.ToolStripMenuItem tSMISelectALL;
    }
}