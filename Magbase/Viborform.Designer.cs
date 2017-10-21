namespace MagbaseServer
{
    partial class Viborform
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
            this.dgvvibor = new System.Windows.Forms.DataGridView();
            this.lblFindpos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvibor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvibor
            // 
            this.dgvvibor.AllowUserToAddRows = false;
            this.dgvvibor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvvibor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvvibor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvvibor.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvibor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvvibor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvibor.Location = new System.Drawing.Point(12, 42);
            this.dgvvibor.Name = "dgvvibor";
            this.dgvvibor.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvvibor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvvibor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvibor.Size = new System.Drawing.Size(768, 186);
            this.dgvvibor.TabIndex = 0;
            this.dgvvibor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvvibor_KeyPress);
            // 
            // lblFindpos
            // 
            this.lblFindpos.AutoSize = true;
            this.lblFindpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFindpos.ForeColor = System.Drawing.Color.Blue;
            this.lblFindpos.Location = new System.Drawing.Point(292, 2);
            this.lblFindpos.Name = "lblFindpos";
            this.lblFindpos.Size = new System.Drawing.Size(173, 20);
            this.lblFindpos.TabIndex = 6;
            this.lblFindpos.Text = "Найдено 0 позиций";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выделите необходимую позицию и нажмите клавишу \"Пробел\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Viborform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFindpos);
            this.Controls.Add(this.dgvvibor);
            this.KeyPreview = true;
            this.Name = "Viborform";
            this.Text = "Выбор товара";
            this.Load += new System.EventHandler(this.Viborform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Viborform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvibor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvvibor;
        private System.Windows.Forms.Label lblFindpos;
        private System.Windows.Forms.Label label1;
    }
}