namespace MagbaseServer
{
    partial class InfoPriceform
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
            this.dgvInfoPrice = new System.Windows.Forms.DataGridView();
            this.docknum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameGodds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfoPrice
            // 
            this.dgvInfoPrice.AllowUserToAddRows = false;
            this.dgvInfoPrice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvInfoPrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfoPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoPrice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfoPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docknum,
            this.DateDock,
            this.price,
            this.users});
            this.dgvInfoPrice.Location = new System.Drawing.Point(3, 62);
            this.dgvInfoPrice.Name = "dgvInfoPrice";
            this.dgvInfoPrice.ReadOnly = true;
            this.dgvInfoPrice.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvInfoPrice.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfoPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoPrice.Size = new System.Drawing.Size(621, 165);
            this.dgvInfoPrice.StandardTab = true;
            this.dgvInfoPrice.TabIndex = 4;
            // 
            // docknum
            // 
            this.docknum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.docknum.HeaderText = "Документ";
            this.docknum.Name = "docknum";
            this.docknum.ReadOnly = true;
            // 
            // DateDock
            // 
            this.DateDock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateDock.HeaderText = "Дата";
            this.DateDock.Name = "DateDock";
            this.DateDock.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // users
            // 
            this.users.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.users.HeaderText = "Пользователь";
            this.users.Name = "users";
            this.users.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Товар:";
            // 
            // lblNameGodds
            // 
            this.lblNameGodds.AutoEllipsis = true;
            this.lblNameGodds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameGodds.ForeColor = System.Drawing.Color.Black;
            this.lblNameGodds.Location = new System.Drawing.Point(59, 4);
            this.lblNameGodds.Name = "lblNameGodds";
            this.lblNameGodds.Size = new System.Drawing.Size(565, 55);
            this.lblNameGodds.TabIndex = 6;
            // 
            // InfoPriceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 230);
            this.Controls.Add(this.lblNameGodds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInfoPrice);
            this.Name = "InfoPriceform";
            this.Text = "История цен";
            this.Load += new System.EventHandler(this.InfoPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameGodds;
        private System.Windows.Forms.DataGridViewTextBoxColumn docknum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn users;

    }
}