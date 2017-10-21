namespace MagbaseServer
{
    partial class ChangeSupform
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
            this.mskTXTSupphoneCH = new System.Windows.Forms.MaskedTextBox();
            this.txtSupAdressCH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupPersonCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameSupCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupSaveCH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskTXTSupphoneCH
            // 
            this.mskTXTSupphoneCH.Location = new System.Drawing.Point(15, 105);
            this.mskTXTSupphoneCH.Mask = "+7(999) 000-00-00";
            this.mskTXTSupphoneCH.Name = "mskTXTSupphoneCH";
            this.mskTXTSupphoneCH.Size = new System.Drawing.Size(237, 20);
            this.mskTXTSupphoneCH.TabIndex = 15;
            // 
            // txtSupAdressCH
            // 
            this.txtSupAdressCH.Location = new System.Drawing.Point(15, 142);
            this.txtSupAdressCH.Name = "txtSupAdressCH";
            this.txtSupAdressCH.Size = new System.Drawing.Size(238, 20);
            this.txtSupAdressCH.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Телефон";
            // 
            // txtSupPersonCH
            // 
            this.txtSupPersonCH.Location = new System.Drawing.Point(15, 64);
            this.txtSupPersonCH.Name = "txtSupPersonCH";
            this.txtSupPersonCH.Size = new System.Drawing.Size(238, 20);
            this.txtSupPersonCH.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Контактное лицо";
            // 
            // txtNameSupCH
            // 
            this.txtNameSupCH.Location = new System.Drawing.Point(15, 25);
            this.txtNameSupCH.Name = "txtNameSupCH";
            this.txtNameSupCH.Size = new System.Drawing.Size(238, 20);
            this.txtNameSupCH.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название";
            // 
            // btnSupSaveCH
            // 
            this.btnSupSaveCH.Location = new System.Drawing.Point(94, 184);
            this.btnSupSaveCH.Name = "btnSupSaveCH";
            this.btnSupSaveCH.Size = new System.Drawing.Size(75, 23);
            this.btnSupSaveCH.TabIndex = 9;
            this.btnSupSaveCH.Text = "Сохранить";
            this.btnSupSaveCH.UseVisualStyleBackColor = true;
            this.btnSupSaveCH.Click += new System.EventHandler(this.btnSupSaveCH_Click);
            // 
            // ChangeSupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 219);
            this.Controls.Add(this.mskTXTSupphoneCH);
            this.Controls.Add(this.txtSupAdressCH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupPersonCH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameSupCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupSaveCH);
            this.KeyPreview = true;
            this.Name = "ChangeSupform";
            this.Text = "Изменение данных поставщика";
            this.Load += new System.EventHandler(this.ChangeSupform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeSupform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTXTSupphoneCH;
        private System.Windows.Forms.TextBox txtSupAdressCH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupPersonCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameSupCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupSaveCH;
    }
}