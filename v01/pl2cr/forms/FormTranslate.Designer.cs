namespace pl2cr
{
    partial class FormTranslate
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
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.rtbDiagnostics = new System.Windows.Forms.RichTextBox();
            this.bTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSource
            // 
            this.rtbSource.Location = new System.Drawing.Point(13, 40);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(775, 222);
            this.rtbSource.TabIndex = 0;
            this.rtbSource.Text = "";
            // 
            // rtbDiagnostics
            // 
            this.rtbDiagnostics.Location = new System.Drawing.Point(13, 284);
            this.rtbDiagnostics.Name = "rtbDiagnostics";
            this.rtbDiagnostics.Size = new System.Drawing.Size(775, 154);
            this.rtbDiagnostics.TabIndex = 1;
            this.rtbDiagnostics.Text = "";
            // 
            // bTranslate
            // 
            this.bTranslate.Location = new System.Drawing.Point(13, 4);
            this.bTranslate.Name = "bTranslate";
            this.bTranslate.Size = new System.Drawing.Size(309, 32);
            this.bTranslate.TabIndex = 2;
            this.bTranslate.Text = "сохранить, транслировать и выполнить";
            this.bTranslate.UseVisualStyleBackColor = true;
            this.bTranslate.Click += new System.EventHandler(this.bTranslate_Click);
            // 
            // FormTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTranslate);
            this.Controls.Add(this.rtbDiagnostics);
            this.Controls.Add(this.rtbSource);
            this.Name = "FormTranslate";
            this.Text = "Транслятор PL/2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSource;
        private System.Windows.Forms.RichTextBox rtbDiagnostics;
        private System.Windows.Forms.Button bTranslate;
    }
}

