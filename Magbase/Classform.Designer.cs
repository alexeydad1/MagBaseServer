namespace MagbaseServer
{
    partial class Classform
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnadd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnchange = new System.Windows.Forms.ToolStripButton();
            this.dgvclass = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclass)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnadd,
            this.tsbtnchange});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnadd
            // 
            this.tsbtnadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnadd.Image = global::MagbaseServer.Properties.Resources.new_32_doc;
            this.tsbtnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnadd.Name = "tsbtnadd";
            this.tsbtnadd.Size = new System.Drawing.Size(36, 36);
            this.tsbtnadd.Text = "+";
            this.tsbtnadd.ToolTipText = "Добавить";
            this.tsbtnadd.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnchange
            // 
            this.tsbtnchange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnchange.Image = global::MagbaseServer.Properties.Resources.edit_32_doc;
            this.tsbtnchange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnchange.Name = "tsbtnchange";
            this.tsbtnchange.Size = new System.Drawing.Size(36, 36);
            this.tsbtnchange.Text = "Изменить";
            this.tsbtnchange.Click += new System.EventHandler(this.tsbtnchange_Click);
            // 
            // dgvclass
            // 
            this.dgvclass.AllowUserToAddRows = false;
            this.dgvclass.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvclass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvclass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvclass.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclass.Location = new System.Drawing.Point(12, 40);
            this.dgvclass.Name = "dgvclass";
            this.dgvclass.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvclass.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvclass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclass.Size = new System.Drawing.Size(768, 450);
            this.dgvclass.TabIndex = 3;
            // 
            // Classform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.dgvclass);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "Classform";
            this.Text = "Классификатор товаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Classform_FormClosing);
            this.Load += new System.EventHandler(this.Classform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Classform_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnadd;
        private System.Windows.Forms.ToolStripButton tsbtnchange;
        public System.Windows.Forms.DataGridView dgvclass;

    }
}