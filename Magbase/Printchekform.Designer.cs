namespace WindowsFormsApplication1
{
    partial class Printchekform
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printCennikPrihod = new System.Drawing.Printing.PrintDocument();
            this.printCennikTovar = new System.Drawing.Printing.PrintDocument();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.tspbtnprint = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbtnprint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // printCennikPrihod
            // 
            this.printCennikPrihod.DocumentName = "1";
            this.printCennikPrihod.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printCennikTovar
            // 
            this.printCennikTovar.DocumentName = "1";
            this.printCennikTovar.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage_1);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Document = this.printCennikTovar;
            this.printPreviewControl1.Location = new System.Drawing.Point(0, 25);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(792, 548);
            this.printPreviewControl1.TabIndex = 1;
            this.printPreviewControl1.Zoom = 0.9D;
            this.printPreviewControl1.Click += new System.EventHandler(this.printPreviewControl1_Click_1);
            // 
            // tspbtnprint
            // 
            this.tspbtnprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspbtnprint.Image = global::WindowsFormsApplication1.Properties.Resources.print_16_doc;
            this.tspbtnprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnprint.Name = "tspbtnprint";
            this.tspbtnprint.Size = new System.Drawing.Size(23, 22);
            this.tspbtnprint.Text = "Печать";
            this.tspbtnprint.Click += new System.EventHandler(this.tspbtnprint_Click);
            // 
            // Printchekform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Printchekform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Печать ценников";
            this.Load += new System.EventHandler(this.Printchekform_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Printchekform_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspbtnprint;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Drawing.Printing.PrintDocument printCennikTovar;
        private System.Drawing.Printing.PrintDocument printCennikPrihod;

    }
}