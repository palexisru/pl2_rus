namespace pl2ide.project.rainbow.form.simple.input.string_value.gdi
    {
    partial class input_box
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
            base.Dispose( disposing );
            }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
            {
            this.message_text = new System.Windows.Forms.Label();
            this.input_text_box = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_text
            // 
            this.message_text.AutoSize = true;
            this.message_text.Location = new System.Drawing.Point(15, 14);
            this.message_text.Name = "message_text";
            this.message_text.Size = new System.Drawing.Size(211, 13);
            this.message_text.TabIndex = 0;
            this.message_text.Text = "Сообщение о назначении нового текста";
            // 
            // input_text_box
            // 
            this.input_text_box.Location = new System.Drawing.Point(15, 53);
            this.input_text_box.Name = "input_text_box";
            this.input_text_box.Size = new System.Drawing.Size(257, 20);
            this.input_text_box.TabIndex = 1;
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(113, 96);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "O\'K";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(195, 96);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Отказ";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // input_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.input_text_box);
            this.Controls.Add(this.message_text);
            this.Name = "input_box";
            this.Text = "Введите новое значение";
            this.Activated += new System.EventHandler(this.input_box_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label message_text;
        private System.Windows.Forms.TextBox input_text_box;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        }
    }