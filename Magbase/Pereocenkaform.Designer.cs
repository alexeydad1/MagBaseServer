namespace MagbaseServer
{
    partial class Pereocenkaform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKodtovara = new System.Windows.Forms.Label();
            this.lblnametovar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPereockodtovar = new System.Windows.Forms.TextBox();
            this.txtPereocshtovar = new System.Windows.Forms.TextBox();
            this.lbllinedok = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bntSavePereocenka = new System.Windows.Forms.Button();
            this.btnDelPereoc = new System.Windows.Forms.Button();
            this.dgvPereoc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOldRcena = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewRcena = new System.Windows.Forms.TextBox();
            this.btnAddTovar = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPereoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKodtovara);
            this.groupBox1.Controls.Add(this.lblnametovar);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 131);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Код и Наименование товара";
            // 
            // lblKodtovara
            // 
            this.lblKodtovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKodtovara.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKodtovara.Location = new System.Drawing.Point(6, 20);
            this.lblKodtovara.Name = "lblKodtovara";
            this.lblKodtovara.Size = new System.Drawing.Size(106, 102);
            this.lblKodtovara.TabIndex = 1;
            this.lblKodtovara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnametovar
            // 
            this.lblnametovar.AutoEllipsis = true;
            this.lblnametovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblnametovar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnametovar.Location = new System.Drawing.Point(120, 20);
            this.lblnametovar.Name = "lblnametovar";
            this.lblnametovar.Size = new System.Drawing.Size(311, 102);
            this.lblnametovar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Код товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Штрихкод";
            // 
            // txtPereockodtovar
            // 
            this.txtPereockodtovar.Location = new System.Drawing.Point(132, 25);
            this.txtPereockodtovar.Name = "txtPereockodtovar";
            this.txtPereockodtovar.Size = new System.Drawing.Size(101, 20);
            this.txtPereockodtovar.TabIndex = 1;
            this.txtPereockodtovar.TextChanged += new System.EventHandler(this.txtPereockodtovar_TextChanged);
            // 
            // txtPereocshtovar
            // 
            this.txtPereocshtovar.Location = new System.Drawing.Point(12, 25);
            this.txtPereocshtovar.Name = "txtPereocshtovar";
            this.txtPereocshtovar.Size = new System.Drawing.Size(101, 20);
            this.txtPereocshtovar.TabIndex = 0;
            this.txtPereocshtovar.TextChanged += new System.EventHandler(this.txtPereocshtovar_TextChanged);
            // 
            // lbllinedok
            // 
            this.lbllinedok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbllinedok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllinedok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbllinedok.Location = new System.Drawing.Point(534, 470);
            this.lbllinedok.Name = "lbllinedok";
            this.lbllinedok.Size = new System.Drawing.Size(216, 24);
            this.lbllinedok.TabIndex = 31;
            this.lbllinedok.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(336, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Строк в документе: ";
            // 
            // bntSavePereocenka
            // 
            this.bntSavePereocenka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSavePereocenka.Location = new System.Drawing.Point(888, 465);
            this.bntSavePereocenka.Name = "bntSavePereocenka";
            this.bntSavePereocenka.Size = new System.Drawing.Size(116, 29);
            this.bntSavePereocenka.TabIndex = 7;
            this.bntSavePereocenka.Text = "Сохранить";
            this.bntSavePereocenka.UseVisualStyleBackColor = true;
            this.bntSavePereocenka.Click += new System.EventHandler(this.bntSavePereocenka_Click);
            // 
            // btnDelPereoc
            // 
            this.btnDelPereoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelPereoc.Location = new System.Drawing.Point(12, 465);
            this.btnDelPereoc.Name = "btnDelPereoc";
            this.btnDelPereoc.Size = new System.Drawing.Size(116, 29);
            this.btnDelPereoc.TabIndex = 6;
            this.btnDelPereoc.Text = "Удалить строку";
            this.btnDelPereoc.UseVisualStyleBackColor = true;
            this.btnDelPereoc.Click += new System.EventHandler(this.btnDelPereoc_Click);
            // 
            // dgvPereoc
            // 
            this.dgvPereoc.AllowUserToAddRows = false;
            this.dgvPereoc.AllowUserToDeleteRows = false;
            this.dgvPereoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPereoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPereoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPereoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPereoc.Location = new System.Drawing.Point(12, 195);
            this.dgvPereoc.Name = "dgvPereoc";
            this.dgvPereoc.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvPereoc.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPereoc.RowTemplate.Height = 32;
            this.dgvPereoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPereoc.Size = new System.Drawing.Size(992, 255);
            this.dgvPereoc.StandardTab = true;
            this.dgvPereoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Старая цена";
            // 
            // lblOldRcena
            // 
            this.lblOldRcena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOldRcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOldRcena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOldRcena.Location = new System.Drawing.Point(469, 64);
            this.lblOldRcena.Name = "lblOldRcena";
            this.lblOldRcena.Size = new System.Drawing.Size(70, 33);
            this.lblOldRcena.TabIndex = 33;
            this.lblOldRcena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Новая цена";
            // 
            // txtNewRcena
            // 
            this.txtNewRcena.Location = new System.Drawing.Point(472, 120);
            this.txtNewRcena.Name = "txtNewRcena";
            this.txtNewRcena.Size = new System.Drawing.Size(67, 20);
            this.txtNewRcena.TabIndex = 3;
            // 
            // btnAddTovar
            // 
            this.btnAddTovar.Location = new System.Drawing.Point(472, 150);
            this.btnAddTovar.Name = "btnAddTovar";
            this.btnAddTovar.Size = new System.Drawing.Size(75, 23);
            this.btnAddTovar.TabIndex = 4;
            this.btnAddTovar.Text = "Добавить";
            this.btnAddTovar.UseVisualStyleBackColor = true;
            this.btnAddTovar.Click += new System.EventHandler(this.btnAddTovar_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(250, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 34);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Поиск товара";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Pereocenkaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAddTovar);
            this.Controls.Add(this.txtNewRcena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOldRcena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbllinedok);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bntSavePereocenka);
            this.Controls.Add(this.btnDelPereoc);
            this.Controls.Add(this.dgvPereoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPereockodtovar);
            this.Controls.Add(this.txtPereocshtovar);
            this.KeyPreview = true;
            this.Name = "Pereocenkaform";
            this.Text = "Переоценка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pereocenkaform_FormClosing);
            this.Load += new System.EventHandler(this.Pereocenkaform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pereocenkaform_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPereoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKodtovara;
        private System.Windows.Forms.Label lblnametovar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPereockodtovar;
        private System.Windows.Forms.TextBox txtPereocshtovar;
        private System.Windows.Forms.Label lbllinedok;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bntSavePereocenka;
        private System.Windows.Forms.Button btnDelPereoc;
        public System.Windows.Forms.DataGridView dgvPereoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOldRcena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTovar;
        private System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.TextBox txtNewRcena;
    }
}