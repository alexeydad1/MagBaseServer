namespace MagbaseServer
{
    partial class calcform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSummShek = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblsdacha = new System.Windows.Forms.Label();
            this.btnprobitfinal = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbBeznal = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSummShek);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сумма";
            // 
            // lblSummShek
            // 
            this.lblSummShek.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummShek.ForeColor = System.Drawing.Color.Blue;
            this.lblSummShek.Location = new System.Drawing.Point(6, 16);
            this.lblSummShek.Name = "lblSummShek";
            this.lblSummShek.Size = new System.Drawing.Size(389, 43);
            this.lblSummShek.TabIndex = 3;
            this.lblSummShek.Text = "0";
            this.lblSummShek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnal);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Получено";
            // 
            // txtnal
            // 
            this.txtnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtnal.Location = new System.Drawing.Point(6, 19);
            this.txtnal.Name = "txtnal";
            this.txtnal.Size = new System.Drawing.Size(389, 35);
            this.txtnal.TabIndex = 3;
            this.txtnal.Text = "0";
            this.txtnal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblsdacha);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 67);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сдача";
            // 
            // lblsdacha
            // 
            this.lblsdacha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsdacha.ForeColor = System.Drawing.Color.Blue;
            this.lblsdacha.Location = new System.Drawing.Point(6, 15);
            this.lblsdacha.Name = "lblsdacha";
            this.lblsdacha.Size = new System.Drawing.Size(389, 43);
            this.lblsdacha.TabIndex = 4;
            this.lblsdacha.Text = "0";
            this.lblsdacha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnprobitfinal
            // 
            this.btnprobitfinal.Location = new System.Drawing.Point(119, 293);
            this.btnprobitfinal.Name = "btnprobitfinal";
            this.btnprobitfinal.Size = new System.Drawing.Size(182, 34);
            this.btnprobitfinal.TabIndex = 2;
            this.btnprobitfinal.Text = "Пробить чек    F6";
            this.btnprobitfinal.UseVisualStyleBackColor = true;
            this.btnprobitfinal.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.chkbBeznal);
            this.groupBox4.Location = new System.Drawing.Point(12, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 62);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тип Платежа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "F8";
            // 
            // chkbBeznal
            // 
            this.chkbBeznal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkbBeznal.ForeColor = System.Drawing.Color.Red;
            this.chkbBeznal.Location = new System.Drawing.Point(118, 16);
            this.chkbBeznal.Name = "chkbBeznal";
            this.chkbBeznal.Size = new System.Drawing.Size(153, 37);
            this.chkbBeznal.TabIndex = 5;
            this.chkbBeznal.Text = "БЕЗНАЛ";
            this.chkbBeznal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkbBeznal.UseVisualStyleBackColor = true;
            this.chkbBeznal.CheckedChanged += new System.EventHandler(this.chkbBeznal_CheckedChanged);
            // 
            // calcform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 348);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnprobitfinal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "calcform";
            this.Text = "Наличные/Сдача/Безнал";
            this.Load += new System.EventHandler(this.calcform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calcform_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSummShek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnprobitfinal;
        private System.Windows.Forms.TextBox txtnal;
        private System.Windows.Forms.Label lblsdacha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkbBeznal;
        private System.Windows.Forms.Label label1;
    }
}