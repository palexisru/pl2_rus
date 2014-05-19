using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pl2.rainbow.description;

namespace pl2.rainbow.form.gdi.sdi.chield.list
{
    public partial class Cell : Form
    {
        private int childFormNumber = 0;

        public Cell()
        {
            InitializeComponent();
            StoryList();
        }

        private void StoryList()
        {
#if false
            Class_infinity = -12 , // абсолютная пустота

        Class_void = -11 , // пустой тип - void, empty, nil, null

        Class_domain = -10 , // элементарный класс среды исполнения (ValueType)

        Class_tuple = -9 , // связь между указанными объектами (аналогично предложениям Prolog, списку параметров функций), методы и свойства отсутствуют, доступ происходит только к открытым членам. По возможностям аналогично набору, возвращаемому из реляционной базы данных

        Class_structure = -8 , // структура с открытыми элементами. Для доступа к элементу текущего объекта используется слово this. Может содержать методы для обработки.

        Class_system = -7 , // система, которая может содержать закрытые и защищенные наследуемые элементы.

        Class_process = -6 , // процесс, которому можно передать инициализирующие значения и получить результирующие значения. Соответствует службе. Любой метод получает не только указатель на себя (this), но и указатель на вызвавший класс или объект (sender). Это позволяет проверить авторизацию объекта, осуществляющего доступ к методу. Для предотвращения низкоуровневой подмены sender, параметры обрабатываемого события запрашиваются у вызывающего объекта после получения идентификатора сообщения. Содержит стандартные методы.

        Class_specialist = -5 , // специализированный класс, который выполняет указанный соглашениями набор функций. Соответствует COM-модели. Поддерживает свойство possibility с интерфейсом control interface

        Class_parallel = -4 , // асинхронно работающий класс, передающий сообщения о выполнении задачи. Поддерживает свойство manager с интерфейсом exchange interface

        Class_stability = -3 , // устойчивый класс

        Class_responsibility = -2 , // класс ответственности

        Class_below_reality = -1 , // нижний приреал

        Class_reality = 0 , //экватор реальности

        Interface_above_reality = 1 , // верхний приреал

        Interface_technology = 2 , // технологическое

        Interface_alignment = 3 , // выравнивающее 

        Interface_exchange = 4 , // взаимодействие с окружающей средой

        Interface_control = 5 , // описание управления

        Interface_politic = 6 , // описание стратегии

        Interface_session = 7 , // интерфейсы для хранения текущего состояния

        Interface_functional = 8 , // функциональные связи, конечные автоматы

        Interface_target = 9 , //   логические элементы

        Interface_logical = 10 , //   логические элементы

        Interface_abstract = 11 , // универсальный интерфейс

        Interface_infinity = 12 // абсолютная идея
#endif
        }

        [Browsable( true ) , Description( "Фаза обработки" ) , Category( "Data" )]
        public Abstraction_level_enum abstraction_level { get; set; }

        [Browsable( true ) , Description( "Фаза обработки" ) , Category( "Data" )]
        public Phase_direction_enum phase { get; set; }

        private void ShowNewForm(object sender , EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
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

        private void cell_list_box_SelectedIndexChanged(object sender , EventArgs e)
        {

        }
    }
}
