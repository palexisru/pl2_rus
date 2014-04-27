using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pl2.rainbow.form.gdi.sdi.main
    {
    public partial class main_sdi_form_copy : Form
        {
        private pl2.rainbow.Project options = new pl2.rainbow.Project();
        private int childFormNumber = 0;

        [Browsable( true ) , Description( "Выбранный уровень абстрактности" ) , Category( "Data" )]
        public pl2.rainbow.description.Abstraction_level selected_level { 
            get{
                return options.current_abstraction_center;
            } 
            set{
                if (selected_level_previous != value){
                    selected_level_previous = selected_level;
                    options.current_abstraction_center = value;
                }
                flow_layout_panel.PerformLayout();
            } 
        }

        [Browsable( true ) , Description( "Предыдущий уровень абстрактности" ) , Category( "Data" )]
        public pl2.rainbow.description.Abstraction_level selected_level_previous { get; set; }

        [Browsable( true ) , Description( "Выбранное направление" ) , Category( "Data" )]
        public pl2.rainbow.description.Phase_direction selected_phase 
        { 
            get{ return options.current_phase_center; }
            set{
                if (selected_phase_previous != value){
                    selected_phase_previous = selected_phase;
                    options.current_phase_center = value;
                }
                flow_layout_panel.PerformLayout();
            }
        }

        [Browsable( true ) , Description( "Предыдущее выбранное направление" ) , Category( "Data" )]
        public pl2.rainbow.description.Phase_direction selected_phase_previous { get; set; } 

        [Browsable( true ) , Description( "Главная форма среды разработки" ) , Category( "Behavior" )]
        public Form ide { get; set; }

        [Browsable( true ) , Description( "Главная форма среды разработки" ) , Category( "Behavior" )]
        public bool extended_visible { get; set; }

        public main_sdi_form_copy()
            {
            InitializeComponent();
            selected_level = options.current_abstraction_center;
            }

        private void ShowNewForm(object sender , EventArgs e)
            {
            Form childForm = new Form();
            // childForm.MdiParent = this;
            childForm.Text = "Окно " + childFormNumber++;
            childForm.Show();
            }

        private void OpenFile(object sender , EventArgs e)
            {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.Personal );
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog( this ) == DialogResult.OK)
                {
                string FileName = openFileDialog.FileName;
                }
            }

        private void SaveAsToolStripMenuItem_Click(object sender , EventArgs e)
            {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.Personal );
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog( this ) == DialogResult.OK)
                {
                string FileName = saveFileDialog.FileName;
                }
            }

        private void ExitToolsStripMenuItem_Click(object sender , EventArgs e)
            {
            this.Close();
            }

        private void CutToolStripMenuItem_Click(object sender , EventArgs e)
            {
            }

        private void CopyToolStripMenuItem_Click(object sender , EventArgs e)
            {
            }

        private void PasteToolStripMenuItem_Click(object sender , EventArgs e)
            {
            }

        private void ToolBarToolStripMenuItem_Click(object sender , EventArgs e)
            {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
            }

        private void StatusBarToolStripMenuItem_Click(object sender , EventArgs e)
            {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
            }

        private void CascadeToolStripMenuItem_Click(object sender , EventArgs e)
            {
            LayoutMdi( MdiLayout.Cascade );
            }

        private void TileVerticalToolStripMenuItem_Click(object sender , EventArgs e)
            {
            LayoutMdi( MdiLayout.TileVertical );
            }

        private void TileHorizontalToolStripMenuItem_Click(object sender , EventArgs e)
            {
            LayoutMdi( MdiLayout.TileHorizontal );
            }

        private void ArrangeIconsToolStripMenuItem_Click(object sender , EventArgs e)
            {
            LayoutMdi( MdiLayout.ArrangeIcons );
            }

        private void CloseAllToolStripMenuItem_Click(object sender , EventArgs e)
            {
            foreach (Form childForm in MdiChildren)
                {
                childForm.Close();
                }
            }

        private void main_Load(object sender , EventArgs e)
            {
            }

        private void level_n8_Load(object sender , EventArgs e)
            {

            }

        private void flow_layout_panel_Layout(object sender , LayoutEventArgs e)
            {
                int current_active_level = Math.Abs((int)options.current_abstraction_center);
                flow_layout_panel.SuspendLayout();
                foreach (Control c in flow_layout_panel.Controls)
                    {
                    if (c is pl2.rainbow.form.gdi.components.Abstraction)
                    {
                        pl2.rainbow.form.gdi.components.Abstraction a = c as pl2.rainbow.form.gdi.components.Abstraction;
                        a.Visible = false;
                    }
                }
                flow_layout_panel.ResumeLayout();
                flow_layout_panel.PerformLayout();
                flow_layout_panel.Invalidate();
                flow_layout_panel.SuspendLayout();
                foreach (Control c in flow_layout_panel.Controls)
                {
                    if (c is pl2.rainbow.form.gdi.components.Abstraction)
                    {
                        pl2.rainbow.form.gdi.components.Abstraction a = c as pl2.rainbow.form.gdi.components.Abstraction;
                        a.Visible = Math.Abs(Math.Abs(a.level_number)- current_active_level) <= options.number_of_colors/2;
                    }
                }
                if (options.center_allwase_visible)
                    level_0.Visible = true;
                if  (! options.visible_specials){
                    level_n1.Visible = false;
                    level_p1.Visible = false;
                }
                flow_layout_panel.ResumeLayout();
            }

        private void level_Click(object sender , EventArgs e)
            {
                pl2.rainbow.form.gdi.components.Abstraction a = sender as pl2.rainbow.form.gdi.components.Abstraction;
                selected_level = a.level;
                flow_layout_panel.PerformLayout();

            }

        private void level_pB_Load(object sender , EventArgs e)
            {

            }

        private void level_pA_Load(object sender , EventArgs e)
            {

            }

        private void level_p9_Load(object sender , EventArgs e)
            {

            }

        private void level_p8_Load(object sender , EventArgs e)
            {

            }

        private void level_p7_Load(object sender , EventArgs e)
            {

            }

        private void level_p6_Load(object sender , EventArgs e)
            {

            }
        }
    }
