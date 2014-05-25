using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pl2.rainbow.form.gdi.components
{
    public partial class Rainbow_control : UserControl
    {
        [Browsable( true ) , Description( "Настройки проекта" ) , Category( "Data" )]
        public pl2.rainbow.Project options = new pl2.rainbow.Project();

        [Browsable( true ) , Description( "Предыдущий уровень абстрактности" ) , Category( "Data" )]
        public pl2.rainbow.description.Abstraction_level_enum selected_level_previous { get; set; }

        [Browsable( true ) , Description( "Предыдущее выбранное направление" ) , Category( "Data" )]
        public pl2.rainbow.description.Phase_direction_enum selected_phase_previous { get; set; }

        [Browsable( true ) , Description( "Видимость неопознанных уровней абстрактности" ) , Category( "Behavior" )]
        public bool extended_visible { get { return options.visible_specials; } }

        [Browsable( true ) , Description( "Выбранный уровень абстрактности" ) , Category( "Data" )]
        public pl2.rainbow.description.Abstraction_level_enum selected_level
        {
            get
            {
                return options.current_abstraction_center;
            }
            set
            {
                if (selected_level_previous != value)
                {
                    selected_level_previous = selected_level;
                    options.current_abstraction_center = value;
                }
                PerformLayout();
            }
        }

        [Browsable( true ) , Description( "Выбранное направление" ) , Category( "Data" )]
        public pl2.rainbow.description.Phase_direction_enum selected_phase
        {
            get { return options.current_phase_center; }
            set
            {
                if (selected_phase_previous != value)
                {
                    selected_phase_previous = selected_phase;
                    options.current_phase_center = value;
                }
                PerformLayout();
            }
        }

        public Rainbow_control()
        {
            InitializeComponent();
        }

        private void level_Click(object sender , EventArgs e)
        {
            pl2.rainbow.form.gdi.components.Abstraction_control a = sender as pl2.rainbow.form.gdi.components.Abstraction_control;
            selected_level = a.level;
            PerformLayout( this , this.Name );
        }

        private void Rainbow_Layout(object sender , LayoutEventArgs e)
        {
            int current_active_level =  (int)options.current_abstraction_center;
            if (options.visible_symmetric) 
                current_active_level = Math.Abs(current_active_level);

            PerformLayout();
            SuspendLayout();
            // сброс всех уровней
            foreach (Control c in Controls)
            {
                if (c is pl2.rainbow.form.gdi.components.Abstraction_control)
                {
                    pl2.rainbow.form.gdi.components.Abstraction_control a = c as pl2.rainbow.form.gdi.components.Abstraction_control;
                    a.Visible = false;
                    a.Left = 0;
                    a.Top = 0;
                }
            }
            // определение видимости уровней абстрактности
            foreach (Control c in Controls)
            {
                if (c is pl2.rainbow.form.gdi.components.Abstraction_control)
                {
                    pl2.rainbow.form.gdi.components.Abstraction_control a = c as pl2.rainbow.form.gdi.components.Abstraction_control;
                    if (options.visible_specials || ! a.extention_level)
                    {
                        if (options.visible_symmetric)
                        {
                            a.Visible = Math.Abs( Math.Abs( a.level_number ) - current_active_level ) < options.number_of_colors;
                        }
                        else
                        {
                            a.Visible = Math.Abs( a.level_number - current_active_level ) < options.number_of_colors;
                        }
                    }
                }
            }
            if (current_active_level == 0)
            {
                level_p2.Visible = true;
                level_p1.Visible = true;
                level_n1.Visible = true;
                level_n2.Visible = true;
            }
            if (options.center_allwase_visible)
                level_0.Visible = true;

            if (current_active_level <= options.number_of_colors)
                level_0.Visible = true;

            if (!options.visible_specials)
            {
                if (level_n1.Visible || level_n2.Visible)
                    level_n3.Visible = true;
                if ( level_p1.Visible || level_p2.Visible)
                    level_p3.Visible = true;
                if (level_pB.Visible){
                    level_pA.Visible = true;
                    level_pC.Visible = true;
                }
                if (level_nB.Visible)
                {
                    level_nA.Visible = true;
                    level_nC.Visible = true;
                }
                level_pB.Visible = false;
                level_p2.Visible = false;
                level_p1.Visible = false;
                level_n1.Visible = false;
                level_n2.Visible = false;
                level_nB.Visible = false;
            }
            resort_tabs();
            ResumeLayout();

        }


        private void resort_tabs()
        {
            int next_pos = 0;
            next_pos = level_pC.Layout_Rainbow_element( 0 , next_pos );
            next_pos = level_pB.Layout_Rainbow_element( 1 , next_pos );
            next_pos = level_pA.Layout_Rainbow_element( 2 , next_pos );
            next_pos = level_p9.Layout_Rainbow_element( 3 , next_pos );
            next_pos = level_p8.Layout_Rainbow_element( 4 , next_pos );
            next_pos = level_p7.Layout_Rainbow_element( 5 , next_pos );
            next_pos = level_p6.Layout_Rainbow_element( 6 , next_pos );
            next_pos = level_p5.Layout_Rainbow_element( 7 , next_pos );
            next_pos = level_p4.Layout_Rainbow_element( 8 , next_pos );
            next_pos = level_p3.Layout_Rainbow_element( 9 , next_pos );
            next_pos = level_p2.Layout_Rainbow_element( 10 , next_pos );
            next_pos = level_p1.Layout_Rainbow_element( 11 , next_pos );
            next_pos = level_0.Layout_Rainbow_element( 12 , next_pos );
            next_pos = level_n1.Layout_Rainbow_element( 13 , next_pos );
            next_pos = level_n2.Layout_Rainbow_element( 14 , next_pos );
            next_pos = level_n3.Layout_Rainbow_element( 15 , next_pos );
            next_pos = level_n4.Layout_Rainbow_element( 16 , next_pos );
            next_pos = level_n5.Layout_Rainbow_element( 17 , next_pos );
            next_pos = level_n6.Layout_Rainbow_element( 18 , next_pos );
            next_pos = level_n7.Layout_Rainbow_element( 19 , next_pos );
            next_pos = level_n8.Layout_Rainbow_element( 20 , next_pos );
            next_pos = level_n9.Layout_Rainbow_element( 21 , next_pos );
            next_pos = level_nA.Layout_Rainbow_element( 22 , next_pos );
            next_pos = level_nB.Layout_Rainbow_element( 23 , next_pos );
            next_pos = level_nC.Layout_Rainbow_element( 24 , next_pos );
        }

        private void level_nB_Load(object sender , EventArgs e)
        {

        }

        private void level_pB_Load(object sender , EventArgs e)
        {

        }

        private void level_pC_Load(object sender , EventArgs e)
        {

        }

        private void level_pA_Load(object sender , EventArgs e)
        {

        }

        private void Rainbow_Load(object sender , EventArgs e)
        {

        }

        private void level_p6_Load(object sender , EventArgs e)
        {

        }
    }
}
