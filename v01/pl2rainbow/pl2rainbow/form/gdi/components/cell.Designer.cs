namespace pl2.rainbow.form.gdi.components
    {
    partial class Cell
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            this.single_button = new System.Windows.Forms.Button();
            this.context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rename_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.context_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // single_button
            // 
            this.single_button.AccessibleDescription = "Кнопка для реакции на действия пользователя";
            this.single_button.AccessibleName = "cell_button";
            this.single_button.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.single_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.single_button.ContextMenuStrip = this.context_menu;
            this.single_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.single_button.Location = new System.Drawing.Point(1, 4);
            this.single_button.Name = "single_button";
            this.single_button.Size = new System.Drawing.Size(117, 26);
            this.single_button.TabIndex = 0;
            this.single_button.Text = "single cell button";
            this.single_button.UseVisualStyleBackColor = true;
            // 
            // context_menu
            // 
            this.context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rename_menu_item});
            this.context_menu.Name = "context_menu";
            this.context_menu.Size = new System.Drawing.Size(162, 26);
            // 
            // rename_menu_item
            // 
            this.rename_menu_item.Name = "rename_menu_item";
            this.rename_menu_item.Size = new System.Drawing.Size(161, 22);
            this.rename_menu_item.Text = "Переименовать";
            this.rename_menu_item.Click += new System.EventHandler(this.rename_menu_item_Click);
            // 
            // Cell
            // 
            this.AccessibleDescription = "Одна клетка радуги";
            this.AccessibleName = "rainbow_cell";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.single_button);
            this.Name = "Cell";
            this.Size = new System.Drawing.Size(122, 34);
            this.context_menu.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.ContextMenuStrip context_menu;
        private System.Windows.Forms.ToolStripMenuItem rename_menu_item;
        public System.Windows.Forms.Button single_button;
        }
    }
