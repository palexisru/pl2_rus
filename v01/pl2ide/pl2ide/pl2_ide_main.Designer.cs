namespace pl2ide
    {
    partial class Form_PL2_IDE
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
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.new_file_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.open_file_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.close_file_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.save_file_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_IDE_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(284, 24);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "main_menu";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_file_menu_item,
            this.open_file_menu_item,
            this.close_file_menu_item,
            this.save_file_menu_item,
            this.exit_IDE_menu_item});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(73, 20);
            this.file_menu.Text = "File_menu";
            // 
            // new_file_menu_item
            // 
            this.new_file_menu_item.Name = "new_file_menu_item";
            this.new_file_menu_item.Size = new System.Drawing.Size(152, 22);
            this.new_file_menu_item.Text = "New_file";
            // 
            // open_file_menu_item
            // 
            this.open_file_menu_item.Name = "open_file_menu_item";
            this.open_file_menu_item.Size = new System.Drawing.Size(152, 22);
            this.open_file_menu_item.Text = "Open_file";
            // 
            // close_file_menu_item
            // 
            this.close_file_menu_item.Name = "close_file_menu_item";
            this.close_file_menu_item.Size = new System.Drawing.Size(152, 22);
            this.close_file_menu_item.Text = "Close_file";
            // 
            // save_file_menu_item
            // 
            this.save_file_menu_item.Name = "save_file_menu_item";
            this.save_file_menu_item.Size = new System.Drawing.Size(152, 22);
            this.save_file_menu_item.Text = "Save_file";
            // 
            // exit_IDE_menu_item
            // 
            this.exit_IDE_menu_item.Name = "exit_IDE_menu_item";
            this.exit_IDE_menu_item.Size = new System.Drawing.Size(152, 22);
            this.exit_IDE_menu_item.Text = "Exit_IDE";
            this.exit_IDE_menu_item.Click += new System.EventHandler(this.exit_IDE_menu_item_Click);
            // 
            // Form_PL2_IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.main_menu);
            this.MainMenuStrip = this.main_menu;
            this.Name = "Form_PL2_IDE";
            this.Text = "PL2_IDE";
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem new_file_menu_item;
        private System.Windows.Forms.ToolStripMenuItem open_file_menu_item;
        private System.Windows.Forms.ToolStripMenuItem close_file_menu_item;
        private System.Windows.Forms.ToolStripMenuItem save_file_menu_item;
        private System.Windows.Forms.ToolStripMenuItem exit_IDE_menu_item;
        }
    }

