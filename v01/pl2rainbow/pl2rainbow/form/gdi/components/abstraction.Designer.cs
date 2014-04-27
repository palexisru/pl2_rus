namespace pl2.rainbow.form.gdi.components
    {
    partial class Abstraction
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
            this.level_image = new System.Windows.Forms.Panel();
            this.cell_check = new pl2.rainbow.form.gdi.components.Cell();
            this.cell_do = new pl2.rainbow.form.gdi.components.Cell();
            this.cell_plan = new pl2.rainbow.form.gdi.components.Cell();
            this.cell_act = new pl2.rainbow.form.gdi.components.Cell();
            this.SuspendLayout();
            // 
            // level_image
            // 
            this.level_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.level_image.Location = new System.Drawing.Point(0, 0);
            this.level_image.Name = "level_image";
            this.level_image.Size = new System.Drawing.Size(27, 36);
            this.level_image.TabIndex = 0;
            this.level_image.Click += new System.EventHandler(this.level_image_Click);
            this.level_image.Paint += new System.Windows.Forms.PaintEventHandler(this.level_Paint);
            // 
            // cell_check
            // 
            this.cell_check.AccessibleDescription = "Одна клетка радуги";
            this.cell_check.AccessibleName = "rainbow_cell";
            this.cell_check.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.cell_check.BackColor = System.Drawing.Color.Silver;
            this.cell_check.Dock = System.Windows.Forms.DockStyle.Left;
            this.cell_check.Location = new System.Drawing.Point(441, 0);
            this.cell_check.Name = "cell_check";
            this.cell_check.phase = pl2.rainbow.description.Phase_direction.after;
            this.cell_check.Size = new System.Drawing.Size(138, 36);
            this.cell_check.TabIndex = 4;
            // 
            // cell_do
            // 
            this.cell_do.AccessibleDescription = "Одна клетка радуги";
            this.cell_do.AccessibleName = "rainbow_cell";
            this.cell_do.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.cell_do.BackColor = System.Drawing.Color.Silver;
            this.cell_do.Dock = System.Windows.Forms.DockStyle.Left;
            this.cell_do.Location = new System.Drawing.Point(303, 0);
            this.cell_do.Name = "cell_do";
            this.cell_do.phase = pl2.rainbow.description.Phase_direction.action;
            this.cell_do.Size = new System.Drawing.Size(138, 36);
            this.cell_do.TabIndex = 3;
            // 
            // cell_plan
            // 
            this.cell_plan.AccessibleDescription = "Одна клетка радуги";
            this.cell_plan.AccessibleName = "rainbow_cell";
            this.cell_plan.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.cell_plan.BackColor = System.Drawing.Color.Silver;
            this.cell_plan.Dock = System.Windows.Forms.DockStyle.Left;
            this.cell_plan.Location = new System.Drawing.Point(165, 0);
            this.cell_plan.Name = "cell_plan";
            this.cell_plan.phase = pl2.rainbow.description.Phase_direction.before;
            this.cell_plan.Size = new System.Drawing.Size(138, 36);
            this.cell_plan.TabIndex = 2;
            // 
            // cell_act
            // 
            this.cell_act.AccessibleDescription = "Одна клетка радуги";
            this.cell_act.AccessibleName = "rainbow_cell";
            this.cell_act.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.cell_act.BackColor = System.Drawing.Color.Silver;
            this.cell_act.Dock = System.Windows.Forms.DockStyle.Left;
            this.cell_act.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell_act.Location = new System.Drawing.Point(27, 0);
            this.cell_act.Name = "cell_act";
            this.cell_act.phase = pl2.rainbow.description.Phase_direction.invariant;
            this.cell_act.Size = new System.Drawing.Size(138, 36);
            this.cell_act.TabIndex = 1;
            // 
            // Abstraction
            // 
            this.AccessibleDescription = "Панель уровня абстрактности";
            this.AccessibleName = "abstraction_panel";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cell_check);
            this.Controls.Add(this.cell_do);
            this.Controls.Add(this.cell_plan);
            this.Controls.Add(this.cell_act);
            this.Controls.Add(this.level_image);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Abstraction";
            this.Size = new System.Drawing.Size(580, 36);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel level_image;
        private Cell cell_act;
        private Cell cell_plan;
        private Cell cell_do;
        private Cell cell_check;

        }
    }
