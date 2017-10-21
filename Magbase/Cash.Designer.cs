namespace MagbaseServer
{
    partial class Cash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCash = new System.Windows.Forms.DataGridView();
            this.typeOPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCash = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertCash = new System.Windows.Forms.Button();
            this.btnEncashment = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtcoment = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCash
            // 
            this.dgvCash.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvCash.AllowUserToAddRows = false;
            this.dgvCash.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvCash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCash.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma",9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeOPR,
            this.summCash,
            this.date,
            this.comment,
            this.user});
            this.dgvCash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvCash.Location = new System.Drawing.Point(12, 83);
            this.dgvCash.Name = "dgvCash";
            this.dgvCash.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCash.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCash.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvCash.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCash.RowTemplate.Height = 32;
            this.dgvCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCash.Size = new System.Drawing.Size(992, 415);
            this.dgvCash.StandardTab = true;
            this.dgvCash.TabIndex = 6;
            // 
            // typeOPR
            // 
            this.typeOPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typeOPR.HeaderText = "Тип Операции";
            this.typeOPR.Name = "typeOPR";
            this.typeOPR.ReadOnly = true;
            this.typeOPR.Width = 140;
            // 
            // summCash
            // 
            this.summCash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.summCash.HeaderText = "Сумма";
            this.summCash.Name = "summCash";
            this.summCash.ReadOnly = true;
            this.summCash.Width = 88;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 75;
            // 
            // comment
            // 
            this.comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // user
            // 
            this.user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.user.HeaderText = "Пользователь";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 151;
            // 
            // lblCash
            // 
            this.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCash.Location = new System.Drawing.Point(12, 23);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(163, 39);
            this.lblCash.TabIndex = 7;
            this.lblCash.Text = "0";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Наличные";
            // 
            // btnInsertCash
            // 
            this.btnInsertCash.Location = new System.Drawing.Point(213, 23);
            this.btnInsertCash.Name = "btnInsertCash";
            this.btnInsertCash.Size = new System.Drawing.Size(75, 39);
            this.btnInsertCash.TabIndex = 9;
            this.btnInsertCash.Text = "Внесение";
            this.btnInsertCash.UseVisualStyleBackColor = true;
            this.btnInsertCash.Click += new System.EventHandler(this.btnInsertCash_Click);
            // 
            // btnEncashment
            // 
            this.btnEncashment.Location = new System.Drawing.Point(306, 23);
            this.btnEncashment.Name = "btnEncashment";
            this.btnEncashment.Size = new System.Drawing.Size(82, 39);
            this.btnEncashment.TabIndex = 10;
            this.btnEncashment.Text = "Инкассация";
            this.btnEncashment.UseVisualStyleBackColor = true;
            this.btnEncashment.Click += new System.EventHandler(this.btnEncashment_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCash.Location = new System.Drawing.Point(413, 25);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(141, 38);
            this.txtCash.TabIndex = 11;
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сумма";
            // 
            // rtxtcoment
            // 
            this.rtxtcoment.Location = new System.Drawing.Point(560, 25);
            this.rtxtcoment.Name = "rtxtcoment";
            this.rtxtcoment.Size = new System.Drawing.Size(289, 38);
            this.rtxtcoment.TabIndex = 13;
            this.rtxtcoment.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Комментарий";
            // 
            // Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtcoment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.btnEncashment);
            this.Controls.Add(this.btnInsertCash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.dgvCash);
            this.KeyPreview = true;
            this.Name = "Cash";
            this.Text = "Наличные";
            this.Load += new System.EventHandler(this.Cash_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cash_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertCash;
        private System.Windows.Forms.Button btnEncashment;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtcoment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn summCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
    }
}