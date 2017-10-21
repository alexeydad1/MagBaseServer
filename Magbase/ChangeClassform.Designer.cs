namespace MagbaseServer
{
    partial class ChangeClassform
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
            this.txtnameclass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinMargin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(343, 61);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(74, 28);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Отмена";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(247, 61);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 28);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "Ок";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtnameclass
            // 
            this.txtnameclass.Location = new System.Drawing.Point(12, 31);
            this.txtnameclass.Name = "txtnameclass";
            this.txtnameclass.Size = new System.Drawing.Size(310, 20);
            this.txtnameclass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // txtMinMargin
            // 
            this.txtMinMargin.Location = new System.Drawing.Point(344, 30);
            this.txtMinMargin.Name = "txtMinMargin";
            this.txtMinMargin.Size = new System.Drawing.Size(42, 20);
            this.txtMinMargin.TabIndex = 9;
            this.txtMinMargin.TextChanged += new System.EventHandler(this.txtMinMargin_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(340, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Минимальная наценка";
            // 
            // ChangeClassform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 105);
            this.Controls.Add(this.txtMinMargin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtnameclass);
            this.KeyPreview = true;
            this.Name = "ChangeClassform";
            this.Text = "Изменить классификатор";
            this.Load += new System.EventHandler(this.ChangeClassform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeClassform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtnameclass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinMargin;
        private System.Windows.Forms.Label label2;
    }
}