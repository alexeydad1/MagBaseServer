namespace MagbaseServer
{
    partial class ReplaceGroupform
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
            this.cmbgrouprep = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберети группу в которую хотите переместить товар";
            // 
            // cmbgrouprep
            // 
            this.cmbgrouprep.FormattingEnabled = true;
            this.cmbgrouprep.Location = new System.Drawing.Point(15, 43);
            this.cmbgrouprep.Name = "cmbgrouprep";
            this.cmbgrouprep.Size = new System.Drawing.Size(218, 21);
            this.cmbgrouprep.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(77, 70);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ReplaceGroupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 109);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbgrouprep);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "ReplaceGroupform";
            this.Text = "Изменение группы товаров";
            this.Load += new System.EventHandler(this.ReplaceGroupform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReplaceGroupform_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbgrouprep;
        private System.Windows.Forms.Button btnOk;
    }
}