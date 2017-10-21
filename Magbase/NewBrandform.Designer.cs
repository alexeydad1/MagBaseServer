namespace MagbaseServer
{
    partial class NewBrandform
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtnamebrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(343, 55);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(74, 28);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Отмена";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(247, 55);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 28);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "Ок";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtnamebrand
            // 
            this.txtnamebrand.Location = new System.Drawing.Point(12, 25);
            this.txtnamebrand.Name = "txtnamebrand";
            this.txtnamebrand.Size = new System.Drawing.Size(405, 20);
            this.txtnamebrand.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // NewBrandform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 92);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtnamebrand);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "NewBrandform";
            this.Text = "Новая Торговая марка";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewBrandform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtnamebrand;
        private System.Windows.Forms.Label label1;
    }
}