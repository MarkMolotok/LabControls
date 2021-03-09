namespace TestControlsApplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.filePathSelect1 = new WinFormsControlLab.FilePathSelect();
            this.numberBox1 = new WinFormsControlLab.NumberBox(this.components);
            this.colorControl1 = new WinFormsControlLab.ColorControl();
            this.SuspendLayout();
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "c:\\\\";
            this.filePathSelect1.Location = new System.Drawing.Point(12, 38);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(301, 27);
            this.filePathSelect1.TabIndex = 1;
            // 
            // numberBox1
            // 
            this.numberBox1.Location = new System.Drawing.Point(12, 12);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(100, 20);
            this.numberBox1.TabIndex = 0;
            // 
            // colorControl1
            // 
            this.colorControl1.Location = new System.Drawing.Point(12, 83);
            this.colorControl1.Name = "colorControl1";
            this.colorControl1.Size = new System.Drawing.Size(333, 123);
            this.colorControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorControl1);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsControlLab.NumberBox numberBox1;
        private WinFormsControlLab.FilePathSelect filePathSelect1;
        private WinFormsControlLab.ColorControl colorControl1;
    }
}

