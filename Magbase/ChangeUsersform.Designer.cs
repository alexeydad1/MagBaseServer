namespace MagbaseServer
{
    partial class ChangeUsersform
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
            this.lbllog = new System.Windows.Forms.Label();
            this.btnaddUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbaccess = new System.Windows.Forms.ComboBox();
            this.lblcomp = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllog.ForeColor = System.Drawing.Color.Red;
            this.lbllog.Location = new System.Drawing.Point(240, 20);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(16, 24);
            this.lbllog.TabIndex = 21;
            this.lbllog.Text = "!";
            // 
            // btnaddUser
            // 
            this.btnaddUser.Location = new System.Drawing.Point(22, 180);
            this.btnaddUser.Name = "btnaddUser";
            this.btnaddUser.Size = new System.Drawing.Size(212, 23);
            this.btnaddUser.TabIndex = 20;
            this.btnaddUser.Text = "Сохранить изменения";
            this.btnaddUser.UseVisualStyleBackColor = true;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Уровень доступа";
            // 
            // cmbaccess
            // 
            this.cmbaccess.FormattingEnabled = true;
            this.cmbaccess.Location = new System.Drawing.Point(22, 142);
            this.cmbaccess.Name = "cmbaccess";
            this.cmbaccess.Size = new System.Drawing.Size(121, 21);
            this.cmbaccess.TabIndex = 18;
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcomp.ForeColor = System.Drawing.Color.Red;
            this.lblcomp.Location = new System.Drawing.Point(240, 98);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(16, 24);
            this.lblcomp.TabIndex = 17;
            this.lblcomp.Text = "!";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(22, 103);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(212, 20);
            this.txtPass2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Подтвердите пароль";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(22, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(212, 20);
            this.txtPass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(22, 25);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(212, 20);
            this.txtLogin.TabIndex = 12;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пользователь/Логин";
            // 
            // ChangeUsersform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 239);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.btnaddUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbaccess);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "ChangeUsersform";
            this.Text = "Изменение данных пользователя";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeUsersform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Button btnaddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbaccess;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
    }
}