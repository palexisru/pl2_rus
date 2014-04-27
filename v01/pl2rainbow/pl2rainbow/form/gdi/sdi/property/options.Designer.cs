namespace pl2.rainbow.form.gdi.sdi.property
    {
    partial class Options
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
            this.tabulation_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.maximal_colors = new System.Windows.Forms.NumericUpDown();
            this.central_visible_check_box = new System.Windows.Forms.CheckBox();
            this.special_check_box = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.symmetric_check_box = new System.Windows.Forms.CheckBox();
            this.tabulation_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximal_colors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabulation_control
            // 
            this.tabulation_control.Controls.Add(this.tabPage1);
            this.tabulation_control.Controls.Add(this.tabPage2);
            this.tabulation_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabulation_control.Location = new System.Drawing.Point(0, 0);
            this.tabulation_control.Name = "tabulation_control";
            this.tabulation_control.SelectedIndex = 0;
            this.tabulation_control.Size = new System.Drawing.Size(453, 262);
            this.tabulation_control.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Радуга";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.maximal_colors);
            this.flowLayoutPanel1.Controls.Add(this.central_visible_check_box);
            this.flowLayoutPanel1.Controls.Add(this.special_check_box);
            this.flowLayoutPanel1.Controls.Add(this.symmetric_check_box);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 230);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество отображаемых групп";
            // 
            // maximal_colors
            // 
            this.maximal_colors.Location = new System.Drawing.Point(185, 3);
            this.maximal_colors.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maximal_colors.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maximal_colors.Name = "maximal_colors";
            this.maximal_colors.Size = new System.Drawing.Size(120, 20);
            this.maximal_colors.TabIndex = 1;
            this.maximal_colors.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // central_visible_check_box
            // 
            this.central_visible_check_box.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.central_visible_check_box, true);
            this.central_visible_check_box.Location = new System.Drawing.Point(3, 29);
            this.central_visible_check_box.Name = "central_visible_check_box";
            this.central_visible_check_box.Size = new System.Drawing.Size(219, 17);
            this.central_visible_check_box.TabIndex = 3;
            this.central_visible_check_box.Text = "Всегда выводить центральную группу";
            this.central_visible_check_box.UseVisualStyleBackColor = true;
            // 
            // special_check_box
            // 
            this.special_check_box.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.special_check_box, true);
            this.special_check_box.Location = new System.Drawing.Point(3, 52);
            this.special_check_box.Name = "special_check_box";
            this.special_check_box.Size = new System.Drawing.Size(202, 17);
            this.special_check_box.TabIndex = 4;
            this.special_check_box.Text = "Выводить дополнительные уровни";
            this.special_check_box.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(445, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 56);
            this.panel1.TabIndex = 1;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(321, 14);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Отказ";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(239, 14);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // symmetric_check_box
            // 
            this.symmetric_check_box.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.symmetric_check_box, true);
            this.symmetric_check_box.Location = new System.Drawing.Point(3, 75);
            this.symmetric_check_box.Name = "symmetric_check_box";
            this.symmetric_check_box.Size = new System.Drawing.Size(185, 17);
            this.symmetric_check_box.TabIndex = 5;
            this.symmetric_check_box.Text = "Выводить уровни симметрично";
            this.symmetric_check_box.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabulation_control);
            this.Name = "Options";
            this.Text = "options";
            this.tabulation_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximal_colors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TabControl tabulation_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maximal_colors;
        private System.Windows.Forms.CheckBox central_visible_check_box;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.CheckBox special_check_box;
        private System.Windows.Forms.CheckBox symmetric_check_box;
        }
    }