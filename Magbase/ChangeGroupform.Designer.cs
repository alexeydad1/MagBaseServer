namespace MagbaseServer
{
    partial class ChangeGroupform
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtnamegrp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(343, 55);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(74, 28);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Отмена";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(247, 55);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 28);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "Ок";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtnamegrp
            // 
            this.txtnamegrp.Location = new System.Drawing.Point(12, 25);
            this.txtnamegrp.Name = "txtnamegrp";
            this.txtnamegrp.Size = new System.Drawing.Size(405, 20);
            this.txtnamegrp.TabIndex = 8;
            // 
            // ChangeGroupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 92);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtnamegrp);
            this.KeyPreview = true;
            this.Name = "ChangeGroupform";
            this.Text = "Изменить Группу товаров";
            this.Load += new System.EventHandler(this.ChangeGroupform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeGroupform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtnamegrp;
    }
}