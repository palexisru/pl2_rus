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
    public partial class main_sdi_form : Form
    {
        [Browsable( true ) , Description( "Главная форма среды разработки" ) , Category( "Behavior" )]
        public Form ide { get; set; }

        private int childFormNumber = 0;

        public main_sdi_form()
        {
            InitializeComponent();
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

        private void параметрыToolStripMenuItem_Click(object sender , EventArgs e)
        {
            sdi.property.Options f = new sdi.property.Options( project_rainbow.options );
            f.ShowDialog();
            project_rainbow.PerformLayout();
            statusStrip.Text = project_rainbow.selected_level.ToString();
        }

        private void project_rainbow_Layout(object sender , LayoutEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender , EventArgs e)
        {
            Form f = new pl2.rainbow.form.gdi.sdi.property.About();
            f.ShowDialog();
        }

        private void источникToolStripMenuItem_Click(object sender , EventArgs e)
        {
            Form f = new pl2.rainbow.description.xml.project.visual.Rainbow();
            f.Show();
        }
    }
}
