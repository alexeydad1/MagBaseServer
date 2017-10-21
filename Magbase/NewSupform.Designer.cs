namespace MagbaseServer
{
    partial class NewSupform
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
            this.btnSupSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSup = new System.Windows.Forms.TextBox();
            this.txtSupPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTXTSupphone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSupSave
            // 
            this.btnSupSave.Location = new System.Drawing.Point(94, 184);
            this.btnSupSave.Name = "btnSupSave";
            this.btnSupSave.Size = new System.Drawing.Size(75, 23);
            this.btnSupSave.TabIndex = 0;
            this.btnSupSave.Text = "Сохранить";
            this.btnSupSave.UseVisualStyleBackColor = true;
            this.btnSupSave.Click += new System.EventHandler(this.btnSupSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // txtNameSup
            // 
            this.txtNameSup.Location = new System.Drawing.Point(15, 25);
            this.txtNameSup.Name = "txtNameSup";
            this.txtNameSup.Size = new System.Drawing.Size(238, 20);
            this.txtNameSup.TabIndex = 2;
            // 
            // txtSupPerson
            // 
            this.txtSupPerson.Location = new System.Drawing.Point(15, 64);
            this.txtSupPerson.Name = "txtSupPerson";
            this.txtSupPerson.Size = new System.Drawing.Size(238, 20);
            this.txtSupPerson.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Контактное лицо";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефон";
            // 
            // txtSupAdress
            // 
            this.txtSupAdress.Location = new System.Drawing.Point(15, 142);
            this.txtSupAdress.Name = "txtSupAdress";
            this.txtSupAdress.Size = new System.Drawing.Size(238, 20);
            this.txtSupAdress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Адрес";
            // 
            // mskTXTSupphone
            // 
            this.mskTXTSupphone.Location = new System.Drawing.Point(15, 105);
            this.mskTXTSupphone.Mask = "+7(999) 000-00-00";
            this.mskTXTSupphone.Name = "mskTXTSupphone";
            this.mskTXTSupphone.Size = new System.Drawing.Size(237, 20);
            this.mskTXTSupphone.TabIndex = 6;
            // 
            // NewSupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 219);
            this.Controls.Add(this.mskTXTSupphone);
            this.Controls.Add(this.txtSupAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameSup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupSave);
            this.KeyPreview = true;
            this.Name = "NewSupform";
            this.Text = "Добавление нового поставщика";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewSupform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSup;
        private System.Windows.Forms.TextBox txtSupPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTXTSupphone;
    }
}