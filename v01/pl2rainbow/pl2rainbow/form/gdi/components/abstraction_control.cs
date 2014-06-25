using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pl2.rainbow.description;
using Ab_lv = pl2.rainbow.description.Abstraction_level_enum;

namespace pl2.rainbow.form.gdi.components
{
    public partial class Abstraction_control : UserControl
    {
        private Abstraction_level_enum abstraction_level_private;

        public Abstraction_control()
        {
            InitializeComponent();
        }

        [Browsable( true ) , Description( "Уровень абстрактности" ) , Category( "Data" )]
        public pl2.rainbow.description.Abstraction_level_enum level
        {
            get { return abstraction_level_private; }
            set
            {
                abstraction_level_private = value;
                cell_act.abstraction_level = value;
                cell_plan.abstraction_level = value;
                cell_do.abstraction_level = value;
                cell_check.abstraction_level = value;
                store_button_names();

                // cell_act.single_button.Text = level.ToString();
            }
        }

        [Browsable( true ) , Description( "Признак дополнительного уровня" ) , Category( "Data" )]
        public bool extention_level { get; set;}

        private void store_button_names()
        {
            switch(abstraction_level_private){
                case Ab_lv.Class_C_infinity:
                    {
                        cell_act.single_button.Text = "-";
                        cell_plan.single_button.Text = "-";
                        cell_do.single_button.Text = "Пустота";
                        cell_check.single_button.Text = "-";
                    }
                    break;
                case Ab_lv.Class_B_void:
                    {
                        cell_act.single_button.Text = "act " + abstraction_level_private.ToString();
                        cell_plan.single_button.Text = "plan " + abstraction_level_private.ToString();
                        cell_do.single_button.Text = "do " + abstraction_level_private.ToString();
                        cell_check.single_button.Text = "check " + abstraction_level_private.ToString();
                    }
                    break;
                case Ab_lv.Class_A_domain:
                    {
                        cell_act.single_button.Text = "Существование";
                        cell_plan.single_button.Text = "Связь";
                        cell_do.single_button.Text = "Способность";
                        cell_check.single_button.Text = "Случайность";
                    }
                    break;
                case Ab_lv.Class_9_tuple:
                    {
                        cell_act.single_button.Text = "Сущность";
                        cell_plan.single_button.Text = "Объект";
                        cell_do.single_button.Text = "Сообщение";
                        cell_check.single_button.Text = "Сигнал";
                    }
                    break;
                case Ab_lv.Class_8_structure:
                    {
                        cell_act.single_button.Text = "Правило";
                        cell_plan.single_button.Text = "Структура";
                        cell_do.single_button.Text = "Субъект";
                        cell_check.single_button.Text = "Ресурс";
                    }
                    break;
                case Ab_lv.Class_7_system:
                    {
                        cell_act.single_button.Text = "Знание";
                        cell_plan.single_button.Text = "Система";
                        cell_do.single_button.Text = "Альтернатива";
                        cell_check.single_button.Text = "Использование";
                    }
                    break;
                case Ab_lv.Class_6_process:
                    {
                        cell_act.single_button.Text = "Состав";
                        cell_plan.single_button.Text = "Вход";
                        cell_do.single_button.Text = "Процесс";
                        cell_check.single_button.Text = "Выход";
                    }
                    break;
                case Ab_lv.Class_5_specialist:
                    {
                        cell_act.single_button.Text = "Требование";
                        cell_plan.single_button.Text = "Поставщик";
                        cell_do.single_button.Text = "Продукция";
                        cell_check.single_button.Text = "Потребитель";
                    }
                    break;
                case Ab_lv.Class_4_parallel:
                    {
                        cell_act.single_button.Text = "Процедура";
                        cell_plan.single_button.Text = "Взаимодействие";
                        cell_do.single_button.Text = "Экземпляр";
                        cell_check.single_button.Text = "Завершение";
                    }
                    break;
                case Ab_lv.Class_3_stability:
                    {
                        cell_act.single_button.Text = "Ответственность";
                        cell_plan.single_button.Text = "Регламент";
                        cell_do.single_button.Text = "Граница";
                        cell_check.single_button.Text = "Устойчивость";
                    }
                    break;
                case Ab_lv.Class_2_technology:
                    {
                        cell_act.single_button.Text = "act " + abstraction_level_private.ToString();
                        cell_plan.single_button.Text = "plan " + abstraction_level_private.ToString();
                        cell_do.single_button.Text = "do " + abstraction_level_private.ToString();
                        cell_check.single_button.Text = "check " + abstraction_level_private.ToString();
                    }
                    break;
                case Ab_lv.Class_1_below_reality:
                    {
                        cell_act.single_button.Text = "act " + abstraction_level_private.ToString();
                        cell_plan.single_button.Text = "plan " + abstraction_level_private.ToString();
                        cell_do.single_button.Text = "do " + abstraction_level_private.ToString();
                        cell_check.single_button.Text = "check " + abstraction_level_private.ToString();
                    }
                    break;
                case Ab_lv.Class_0_reality:
                    {
                        cell_act.single_button.Text = "Компетентность";
                        cell_plan.single_button.Text = "Согласование";
                        cell_do.single_button.Text = "Реализация";
                        cell_check.single_button.Text = "Результат";
                    }
                    break;
                case Ab_lv.Interface_1_above_reality:
                    {
                        cell_act.single_button.Text = "act " + abstraction_level_private.ToString();
                        cell_plan.single_button.Text = "plan " + abstraction_level_private.ToString();
                        cell_do.single_button.Text = "do " + abstraction_level_private.ToString();
                        cell_check.single_button.Text = "check " + abstraction_level_private.ToString();
                    }
                    break;
                case Ab_lv.Interface_2_responsibility:
                    {
                        cell_act.single_button.Text = "act " + abstraction_level_private.ToString();
                        cell_plan.single_button.Text = "plan " + abstraction_level_private.ToString();
                        cell_do.single_button.Text = "do " + abstraction_level_private.ToString();
                        cell_check.single_button.Text = "check " + abstraction_level_private.ToString();
                    }
                    break;
                case Ab_lv.Interface_3_exchange:
                    {
                        cell_act.single_button.Text = "Роль";
                        cell_plan.single_button.Text = "Организация";
                        cell_do.single_button.Text = "Соревнование";
                        cell_check.single_button.Text = "Контроль";
                    }
                    break;
                case Ab_lv.Interface_5_algorithm:
                    {
                        cell_act.single_button.Text = "Отношение";
                        cell_plan.single_button.Text = "Помощь";
                        cell_do.single_button.Text = "Управление";
                        cell_check.single_button.Text = "Учет";
                    }
                    break;
                case Ab_lv.Interface_4_control:
                    {
                        cell_act.single_button.Text = "Сценарий";
                        cell_plan.single_button.Text = "Обеспечение";
                        cell_do.single_button.Text = "Проект";
                        cell_check.single_button.Text = "Аудит";
                    }
                    break;
                case Ab_lv.Interface_6_politic:
                    {
                        cell_act.single_button.Text = "Стратегия";
                        cell_plan.single_button.Text = "Планирование";
                        cell_do.single_button.Text = "Обучение";
                        cell_check.single_button.Text = "Познание";
                    }
                    break;
                case Ab_lv.Interface_7_session:
                    {
                        cell_act.single_button.Text = "Критерий";
                        cell_plan.single_button.Text = "Прогноз";
                        cell_do.single_button.Text = "Культура";
                        cell_check.single_button.Text = "История";
                    }
                    break;
                case Ab_lv.Interface_8_functional:
                    {
                        cell_act.single_button.Text = "Точка зрения";
                        cell_plan.single_button.Text = "Обобщение";
                        cell_do.single_button.Text = "Интерфейс";
                        cell_check.single_button.Text = "Оценка";
                    }
                    break;
                case Ab_lv.Interface_9_target:
                    {
                        cell_act.single_button.Text = "Цель";
                        cell_plan.single_button.Text = "Респондент";
                        cell_do.single_button.Text = "Функция";
                        cell_check.single_button.Text = "Состояние";
                    }
                    break;
                case Ab_lv.Interface_A_logical:
                    {
                        cell_act.single_button.Text = "Необходимость";
                        cell_plan.single_button.Text = "Направленность";
                        cell_do.single_button.Text = "Несуществование";
                        cell_check.single_button.Text = "Отрицание";
                    }
                    break;
                case Ab_lv.Interface_B_abstract:
                    {
                        cell_act.single_button.Text = "act " + abstraction_level_private.ToString();
                        cell_plan.single_button.Text = "plan " + abstraction_level_private.ToString();
                        cell_do.single_button.Text = "do " + abstraction_level_private.ToString();
                        cell_check.single_button.Text = "check " + abstraction_level_private.ToString();
                    }
                    break;
                case Ab_lv.Interface_C_infinity:
                    {
                        cell_act.single_button.Text = "Идея";
                        cell_plan.single_button.Text = "-";
                        cell_do.single_button.Text = "-";
                        cell_check.single_button.Text = "-";
                    }
                    break;
            }

        }

        [Browsable( true ) , Description( "Уровень абстрактности" ) , Category( "Data" )]
        public int level_number
        {
            get { return (int)level; }
        }

        public int Layout_Rainbow_element(int Tab_stop , int pos)
        {
            this.TabIndex = Tab_stop;
            if (this.Visible)
            {
                this.Top = pos;
                pos += this.Height;
            }
            return pos;
        }

        private void button1_Click(object sender , EventArgs e)
        {

        }

        private void level_Paint(object sender , PaintEventArgs e)
        {
            draw_elements( e );
        }

        private void draw_elements(PaintEventArgs e)
        {
            Point[] pt;
            int h = level_image.ClientSize.Height;
            int dt = h / 10;
            int hh = h / 2;
            int w = ClientSize.Width;
            Abstraction_level_enum abstraction_level = this.level;
            int direction_phase = 1;
            Color drawing_color = color_from_level( abstraction_level );
            Color inverce_color = System.Drawing.Color.FromArgb( (255 - drawing_color.R) >> 3 , (255 - drawing_color.G) >> 3 , (255 - drawing_color.B) >> 3 );
            System.Drawing.Brush b = new SolidBrush( inverce_color );
            System.Drawing.Pen p = new Pen( inverce_color , 1 );

            bool fill_phase = false;
            if (dt > w / 10)
                dt = w / 10;
            if (dt < 5)
                dt = 5;
            int dt2 = dt + dt;

            // level_image.Width = dt2+dt;
            level_image.BackColor = drawing_color;
            cell_act.BackColor = drawing_color;
            cell_plan.BackColor = drawing_color;
            cell_do.BackColor = drawing_color;
            cell_check.BackColor = drawing_color;

            //PanelFigure.Padding.All = dt;


            #region up_left_2_down
            if (abstraction_level >= Ab_lv.Interface_A_logical && abstraction_level <= Ab_lv.Interface_C_infinity)
            {
                pt = new Point[] { 
                    new Point( dt2, 0),
                    new Point( dt2, dt),
                    new Point( dt, dt )};
                if (abstraction_level == Ab_lv.Interface_B_abstract)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region up_left_2_up
            if (abstraction_level >= Ab_lv.Interface_8_functional && abstraction_level <= Ab_lv.Interface_C_infinity)
            {
                pt = new Point[] { 
                    new Point( dt, 0 ),
                    new Point( dt2, 0 ),
                    new Point( dt, dt )};
                if (abstraction_level == Ab_lv.Interface_9_target || abstraction_level == Ab_lv.Interface_A_logical)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region up_left_1_up
            if (abstraction_level >= Ab_lv.Interface_6_politic && abstraction_level <= Ab_lv.Interface_9_target)
            {
                pt = new Point[] { 
                    new Point( 0, 0 ),
                    new Point( dt, 0 ),
                    new Point( dt, dt )};
                if (abstraction_level >= Ab_lv.Interface_7_session && abstraction_level <= Ab_lv.Interface_8_functional)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region up_left_1_down
            if (abstraction_level >= Ab_lv.Interface_4_control && abstraction_level <= Ab_lv.Interface_7_session)
            {
                pt = new Point[] { 
                    new Point( 0, 0 ),
                    new Point( 0, dt ),
                    new Point( dt, dt )};
                if (abstraction_level >= Ab_lv.Interface_5_algorithm && abstraction_level <= Ab_lv.Interface_6_politic)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region up_2_up
            if (abstraction_level >= Ab_lv.Interface_4_control && abstraction_level <= Ab_lv.Interface_5_algorithm)
            {
                pt = new Point[] { 
                    new Point( 0, dt ),
                    new Point( dt, dt),
                    new Point( 0, dt2 )};
                if (abstraction_level == Ab_lv.Interface_4_control || abstraction_level == Ab_lv.Interface_4_control)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region up_2_down
            #if false
            if (abstraction_level >= Ab_lv.Interface_control && abstraction_level <= Ab_lv.Interface_algorithm)
            {
                pt = new Point[] { 
                    new Point( dt, dt2 ),
                    new Point( dt, dt ),
                    new Point( 0, dt2 )};
                if (abstraction_level == Ab_lv.Interface_control)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endif
            #endregion
#if false
                if (abstraction_level >= Ab_lv.Interface_control && abstraction_level <= Ab_lv.Interface_politic)
                {
                pt = new Point[] { 
                    new Point( -1, hh - dt*3),
                    new Point( dt - 1, hh - dt *3 ),
                    new Point( dt - 1, hh - dt *3/2)};
                if (abstraction_level == Ab_lv.Interface_infinity)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endif

            #region up_middle
            if (abstraction_level >= Ab_lv.Interface_2_responsibility && abstraction_level <= Ab_lv.Interface_3_exchange)
            {
                pt = new Point[] { 
                    new Point( 0, hh - dt*3),
                    new Point( dt, hh - dt*3/2 ),
                    new Point( 0, hh - dt2)};
                if (abstraction_level == Ab_lv.Interface_3_exchange)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }

            if (abstraction_level >= Ab_lv.Interface_2_responsibility && abstraction_level <= Ab_lv.Interface_3_exchange)
            {
                pt = new Point[] { 
                    new Point( 0, hh - dt2),
                    new Point( dt, hh - dt*3/2),
                    new Point( 0, hh - dt)};
                if (abstraction_level == Ab_lv.Interface_2_responsibility)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

#if false
                if (abstraction_level >= Ab_lv.Interface_alignment && abstraction_level <= Ab_lv.Interface_exchange)
                {
                pt = new Point[] { 
                    new Point( -1, hh - dt),
                    new Point( dt - 1, hh - dt*3/2),
                    new Point( dt * 2 / 3, hh - dt / 3 )};
                if (abstraction_level == Ab_lv.Interface_alignment || abstraction_level == Ab_lv.Interface_alignment)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endif

            #region center
            if (abstraction_level >= Ab_lv.Class_1_below_reality && abstraction_level <= Ab_lv.Interface_1_above_reality)
            {
                pt = new Point[] { 
                    new Point( 0, hh - dt ),
                    new Point( dt*2/3 + 1, hh-dt/3 ),
                    new Point( 0, hh - dt/4 )};
                if (abstraction_level == Ab_lv.Interface_1_above_reality)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }

            if (abstraction_level >= Ab_lv.Class_1_below_reality && abstraction_level <= Ab_lv.Interface_1_above_reality)
            {
                pt = new Point[] { 
                    new Point( 0, hh - dt/4 ),
                    new Point( dt*2/3 + 1, hh-dt/3 ),
                    new Point( dt, hh),
                    new Point( dt*2/3 + 1, hh+dt/3 ),
                    new Point( 0, hh + dt/4  )};
                if (abstraction_level == Ab_lv.Class_0_reality)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }

            if (abstraction_level >= Ab_lv.Class_1_below_reality && abstraction_level <= Ab_lv.Interface_1_above_reality)
            {
                pt = new Point[] { 
                    new Point( 0, hh + dt ),
                    new Point( dt*2/3 + 1, hh + dt/3 ),
                    new Point( 0, hh + dt/4 )};
                if (abstraction_level == Ab_lv.Class_1_below_reality)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

#if false
            if (abstraction_level >= Ab_lv.Class_executive && abstraction_level <= Ab_lv.Class_executive)
                {
                pt = new Point[] { 
                    new Point( -1, hh + dt),
                    new Point( dt*2/3, hh + dt/3),
                    new Point( dt-1, hh + dt*3/2)};
                if (false)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endif

            #region down_middle
            if (abstraction_level >= Ab_lv.Class_3_stability && abstraction_level <= Ab_lv.Class_2_technology)
            {
                pt = new Point[] { 
                    new Point( 0, hh + dt),
                    new Point( dt, hh + dt*3/2),
                    new Point( 0, hh + dt2)};
                if (abstraction_level == Ab_lv.Class_2_technology)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }

            if (abstraction_level >= Ab_lv.Class_3_stability && abstraction_level <= Ab_lv.Class_2_technology)
            {
                pt = new Point[] { 
                    new Point( 0, hh+dt2 ),
                    new Point( dt, hh+dt*3/2 ),
                    new Point( 0, hh+dt*3 )};
                if (abstraction_level == Ab_lv.Class_3_stability)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

#if false
            if (abstraction_level >= Ab_lv.Class_executive && abstraction_level <= Ab_lv.Class_executive)
                {
                pt = new Point[] { 
                    new Point( -1, hh+dt*3),
                    new Point( dt-1, hh+dt*3/2),
                    new Point( dt-1, hh+dt*3)};
                if (abstraction_level == Ab_lv.Class_executive)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endif

            #region down_2_up
            #if false
            if (abstraction_level >= Ab_lv.Class_3_stability && abstraction_level <= Ab_lv.Class_4_parallel)
                {
                pt = new Point[] { 
                    new Point( 0, h-dt2-1),
                    new Point( dt, h-dt2-1),
                    new Point( dt, h-dt-1)};
                if (abstraction_level == Ab_lv.Class_3_stability)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
            #endif
            #endregion

            #region down_2_down
            if (abstraction_level >= Ab_lv.Class_5_specialist && abstraction_level <= Ab_lv.Class_4_parallel)
            {
                pt = new Point[] { 
                    new Point( 0, h-dt2-1 ),
                    new Point( 0, h-dt-1 ),
                    new Point( dt, h-dt-1 )};
                if (abstraction_level == Ab_lv.Class_4_parallel || abstraction_level == Ab_lv.Class_4_parallel)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region down_1_up
            if (abstraction_level >= Ab_lv.Class_7_system && abstraction_level <= Ab_lv.Class_4_parallel)
            {
                pt = new Point[] { 
                    new Point( 0, h-dt-1 ),
                    new Point( dt, h-dt-1 ),
                    new Point( 0, h-1 )};
                if (abstraction_level >= Ab_lv.Class_6_process && abstraction_level <= Ab_lv.Class_5_specialist)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region down_1_down
            if (abstraction_level >= Ab_lv.Class_9_tuple && abstraction_level <= Ab_lv.Class_6_process)
            {
                pt = new Point[] { 
                    new Point( 0, h-1 ),
                    new Point( dt, h-dt-1 ),
                    new Point( dt, h-1 )};
                if (abstraction_level >= Ab_lv.Class_8_structure && abstraction_level <= Ab_lv.Class_7_system)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region down_left_2_down
            if (abstraction_level >= Ab_lv.Class_C_infinity && abstraction_level <= Ab_lv.Class_8_structure)
            {
                pt = new Point[] { 
                    new Point( dt, h-dt-1),
                    new Point( dt, h-1 ),
                    new Point( dt2, h-1 )};
                if (abstraction_level >= Ab_lv.Class_A_domain && abstraction_level <= Ab_lv.Class_9_tuple)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

            #region down_left_2_up
            if (abstraction_level >= Ab_lv.Class_C_infinity && abstraction_level <= Ab_lv.Class_A_domain)
            {
                pt = new Point[] { 
                    new Point( dt, h-dt-1),
                    new Point( dt2, h-dt-1),
                    new Point( dt2, h-1)};
                if (abstraction_level >= Ab_lv.Class_B_void && abstraction_level <= Ab_lv.Class_B_void)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
            }
            #endregion

#if false
            if (abstraction_level >= 1 && abstraction_level <= 2)
                {
                pt = new Point[] { 
                    new Point( dt*2-1, h-dt),
                    new Point( dt*3-1, h),
                    new Point( dt*2-1, h)};
                if (abstraction_level == 1)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            if (direction_phase == 1)
                {
                pt = new Point[] { 
                    new Point( w+1-dt, -1),
                    new Point( w+1-dt, h),
                    new Point( w+1, h),
                    new Point( w+1, -1)};
                if (fill_phase)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            if (direction_phase == 2)
                {
                pt = new Point[] { 
                    new Point( w-dt+1, -1),
                    new Point( w-dt+1, hh-dt+2),
                    new Point( w-1, hh),
                    new Point( w+1, hh),
                    new Point( w+1, -1)};
                if (fill_phase)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );

                pt = new Point[] { 
                    new Point( w-dt+1, hh+dt),
                    new Point( w-dt+1, h),
                    new Point( w-1, h),
                    new Point( w+1, h),
                    new Point( w+1, hh)};
                if (fill_phase)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            if (direction_phase == 3)
                {
                pt = new Point[] { 
                    new Point( w-dt-1, -1),
                    new Point( w-1, hh),
                    new Point( w+1, hh),
                    new Point( w+1, -1)};
                if (fill_phase)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );

                pt = new Point[] { 
                    new Point( w - dt - 1, h),
                    new Point( w+1, h),
                    new Point( w+1, hh-1),
                    new Point( w-1, hh-1)};
                if (fill_phase)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            if (direction_phase == 4)
                {
                pt = new Point[] { 
                    new Point( w - dt - 1, -1),
                    new Point( w - 1, dt - 1),
                    new Point( w + 1, dt - 1),
                    new Point( w + 1, -1)};
                if (fill_phase)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );

                pt = new Point[] { 
                    new Point( w - dt - 1, h),
                    new Point( w + 1, h),
                    new Point( w + 1, h - dt + 0),
                    new Point( w - 1, h - dt + 0)};
                if (fill_phase)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            string s = Текст_прямоугольника.Text;
            SizeF text_size = e.Graphics.MeasureString( s , PanelFigure.Font );
            e.Graphics.DrawString( s , PanelFigure.Font , new SolidBrush( System.Drawing.Color.Black )
                , (w + dt - text_size.Width) / 2
                , hh - text_size.Height / 2 );
#endif
            if (Parent is Rainbow_control)
            {
                p = new Pen( inverce_color , 2 );
                Rainbow_control parent_rainbow = Parent as Rainbow_control;
                if (this.level > Ab_lv.Class_0_reality)
                {
                    e.Graphics.DrawRectangle( p , dt + 2 , hh - dt / 2 - 1 , dt + 2 , dt + 2 );
                    if (parent_rainbow.selected_level == this.level)
                    {
                        e.Graphics.FillRectangle( b , dt + 2 , hh - dt / 2 - 1 , dt + 2 , dt + 2 );
                    }

                }
                else
                {
                    e.Graphics.DrawEllipse( p , dt + 2 , hh - dt / 2 - 1 , dt + 2 , dt + 2 );
                    if (parent_rainbow.selected_level == this.level)
                    {
                        e.Graphics.FillEllipse( b , dt + 2 , hh - dt / 2 - 1 , dt + 2 , dt + 2 );
                    }
                }
            }


        }

        public static Color color_from_level(Abstraction_level_enum abstraction_level)
        {
            Color return_value = Color.FromArgb( 127 , 127 , 127 , 127 );
            switch (abstraction_level)
            {
                case Ab_lv.Class_C_infinity: // 1 пустой тип - void, empty, nil, null
                    return_value = Color.FromArgb( 96 , 0 , 160 ); // (143, 0, 143);
                    break;

                case Ab_lv.Class_B_void: // 1 пустой тип - void, empty, nil, null
                    return_value = Color.FromArgb( 80 , 0 , 176 ); // (143, 0, 143);
                    break;

                case Ab_lv.Class_A_domain:  // 2 элементарный класс среды исполнения (ValueType)
                    return_value = Color.FromArgb( 64 , 0 , 192 ); // ( 103, 0, 151);
                    break;

                case Ab_lv.Class_9_tuple: // 3 связь между указанными объектами (аналогично предложениям Prolog, списку параметров функций), методы и свойства отсутствуют, доступ происходит только к открытым членам. По возможностям аналогично набору, возвращаемому из реляционной базы данных
                    return_value = Color.FromArgb( 32 , 32 , 255 ); // ( 55, 0, 143);
                    break;

                case Ab_lv.Class_8_structure: // 4 структура с открытыми элементами. Для доступа к элементу текущего объекта используется слово this. Может содержать методы для обработки.
                    return_value = Color.FromArgb( 0 , 96 , 160 ); // ( 0, 55, 135);
                    break;

                case Ab_lv.Class_7_system: // 5 система, которая может содержать закрытые и защищенные наследуемые элементы.
                    return_value = Color.FromArgb( 0 , 112 , 144 );  // ( 1, 58, 135);
                    break;

                case Ab_lv.Class_6_process: // 6 процесс, которому можно передать инициализирующие значения и получить результирующие значения. Соответствует службе. Любой метод получает не только указатель на себя (this), но и указатель на вызвавший класс или объект (sender). Это позволяет проверить авторизацию объекта, осуществляющего доступ к методу. Для предотвращения низкоуровневой подмены sender, параметры обрабатываемого события запрашиваются у вызывающего объекта после получения идентификатора сообщения. Содержит стандартные методы.
                    return_value = Color.FromArgb( 0 , 128 , 128 ); // ( 1, 88, 116);
                    break;

                case Ab_lv.Class_5_specialist: // 7 специализированный класс, который выполняет указанный соглашениями набор функций. Соответствует COM-модели. Поддерживает свойство possibility с интерфейсом control interface
                    return_value = Color.FromArgb( 0 , 144 , 112 ); // ( 0, 96, 84);
                    break;

                case Ab_lv.Class_4_parallel: // 8 асинхронно работающий класс, передающий сообщения о выполнении задачи. Поддерживает свойство manager с интерфейсом exchange interface
                    return_value = Color.FromArgb( 0 , 160 , 96 ); // ( 0, 117, 0);
                    break;

                case Ab_lv.Class_3_stability: // 9 таможня, обеспечивающее ответственность за выполнение задачи. Поддерживает свойство environment с интерфейсом concurent interface
                    return_value = Color.FromArgb( 0 , 176 , 80 ); // ( 65, 137, 3);
                    break;

                case Ab_lv.Class_2_technology: // 10 исполняемый класс
                    return_value = Color.FromArgb( 0 , 192 , 64 ); // ( 110, 141, 3);
                    break;

                case Ab_lv.Class_1_below_reality:    // 11 среда исполнения
                    return_value = Color.FromArgb( 0 , 208 , 32 ); // ( 138, 157, 3);
                    break;

                case Ab_lv.Class_0_reality:    // 11 среда исполнения
                    return_value = Color.FromArgb( 32, 255 , 32 ); // ( 138, 157, 3);
                    break;

                case Ab_lv.Interface_1_above_reality:    // 11 среда исполнения
                    return_value = Color.FromArgb( 32 , 208 , 0 ); // ( 138, 157, 3);
                    break;

                case Ab_lv.Interface_2_responsibility: // 12 технологические элементы
                    return_value = Color.FromArgb( 64 , 192 , 0 ); // ( 178, 158, 0);
                    break;

                case Ab_lv.Interface_3_exchange: // 13 оценка соответствия с внешними аналогами
                    return_value = Color.FromArgb( 80 , 176 , 0 ); // ( 244, 226, 6);
                    break;

                case Ab_lv.Interface_4_control: // 14 взаимодействие с окружающей средой
                    return_value = Color.FromArgb( 96 , 160 , 0 ); // ( 253, 174, 11);
                    break;

                case Ab_lv.Interface_5_algorithm: // 15 описание управления
                    return_value = Color.FromArgb( 128 , 128 , 0 ); // ( 251, 137, 4);
                    break;

                case Ab_lv.Interface_6_politic: // 16 описание стратегии
                    return_value = Color.FromArgb( 160 , 96 , 0 ); // ( 230, 90, 15);
                    break;

                case Ab_lv.Interface_7_session: // 17 интерфейсы для хранения текущего состояния
                    return_value = Color.FromArgb( 176 , 80 , 0 ); // ( 225, 66, 1);
                    break;

                case Ab_lv.Interface_8_functional: // 18 функциональные связи, конечные автоматы
                    return_value = Color.FromArgb( 192 , 64 , 0 ); // ( 226, 38, 1);
                    break;

                case Ab_lv.Interface_9_target: // 19 описание целевых функций
                    return_value = Color.FromArgb( 255 , 32 , 32 ); // ( 247, 47, 0);
                    break;

                case Ab_lv.Interface_A_logical: // 20 логические элементы
                    return_value = Color.FromArgb( 224 , 0 , 32 ); // ( 248, 26, 3);
                    break;

                case Ab_lv.Interface_B_abstract: // 21 универсальный интерфейс
                    return_value = Color.FromArgb( 192 , 0 , 64 ); // ( 255, 0, 0);
                    break;

                case Ab_lv.Interface_C_infinity: // 21 универсальный интерфейс
                    return_value = Color.FromArgb( 176 , 0 , 80 ); // ( 255, 0, 0);
                    break;

            }
            return return_value;

        }

        public static string abstraction_name(Abstraction_level_enum abstraction_level)
        {
            string return_value = "не определено";
            switch (abstraction_level)
            {
                case Ab_lv.Class_C_infinity: // 1 пустой тип - void, empty, nil, null
                    return_value = "Пустой";
                    break;

                case Ab_lv.Class_B_void: // 1 пустой тип - void, empty, nil, null
                    return_value = "Не заполненный";
                    break;

                case Ab_lv.Class_A_domain:  // 2 элементарный класс среды исполнения (ValueType)
                    return_value = "Хаотический";
                    break;

                case Ab_lv.Class_9_tuple: // 3 связь между указанными объектами (аналогично предложениям Prolog, списку параметров функций), методы и свойства отсутствуют, доступ происходит только к открытым членам. По возможностям аналогично набору, возвращаемому из реляционной базы данных
                    return_value = "Физический";
                    break;

                case Ab_lv.Class_8_structure: // 4 структура с открытыми элементами. Для доступа к элементу текущего объекта используется слово this. Может содержать методы для обработки.
                    return_value = "Канальный";
                    break;

                case Ab_lv.Class_7_system: // 5 система, которая может содержать закрытые и защищенные наследуемые элементы.
                    return_value = "Системный";
                    break;

                case Ab_lv.Class_6_process: // 6 процесс, которому можно передать инициализирующие значения и получить результирующие значения. Соответствует службе. Любой метод получает не только указатель на себя (this), но и указатель на вызвавший класс или объект (sender). Это позволяет проверить авторизацию объекта, осуществляющего доступ к методу. Для предотвращения низкоуровневой подмены sender, параметры обрабатываемого события запрашиваются у вызывающего объекта после получения идентификатора сообщения. Содержит стандартные методы.
                    return_value = "Межсетевой";
                    break;

                case Ab_lv.Class_5_specialist: // 7 специализированный класс, который выполняет указанный соглашениями набор функций. Соответствует COM-модели. Поддерживает свойство possibility с интерфейсом control interface
                    return_value = "Специальный";
                    break;

                case Ab_lv.Class_4_parallel: // 8 асинхронно работающий класс, передающий сообщения о выполнении задачи. Поддерживает свойство manager с интерфейсом exchange interface
                    return_value = "Параллельный";
                    break;

                case Ab_lv.Class_3_stability: // 9 таможня, обеспечивающее ответственность за выполнение задачи. Поддерживает свойство environment с интерфейсом concurent interface
                    return_value = "Устойчивый";
                    break;

                case Ab_lv.Class_2_technology: // 10 исполняемый класс
                    return_value = "Ответственный";
                    break;

                case Ab_lv.Class_1_below_reality:    // 11 среда исполнения
                    return_value = "Нижний приреал";
                    break;

                case Ab_lv.Class_0_reality:    // 11 среда исполнения
                    return_value = "Преобразующий";
                    break;

                case Ab_lv.Interface_1_above_reality:    // 11 среда исполнения
                    return_value = "Верхний приреал";
                    break;

                case Ab_lv.Interface_2_responsibility: // 12 технологические элементы
                    return_value = "Технологический";
                    break;

                case Ab_lv.Interface_3_exchange: // 13 оценка соответствия с внешними аналогами
                    return_value = "Выравнивающий";
                    break;

                case Ab_lv.Interface_4_control: // 14 взаимодействие с окружающей средой
                    return_value = "Оценивающий";
                    break;

                case Ab_lv.Interface_5_algorithm: // 15 описание управления
                    return_value = "Управляющий";
                    break;

                case Ab_lv.Interface_6_politic: // 16 описание стратегии
                    return_value = "Транспортный";
                    break;

                case Ab_lv.Interface_7_session: // 17 интерфейсы для хранения текущего состояния
                    return_value = "Сеансовый";
                    break;

                case Ab_lv.Interface_8_functional: // 18 функциональные связи, конечные автоматы
                    return_value = "Представительский";
                    break;

                case Ab_lv.Interface_9_target: // 19 описание целевых функций
                    return_value = "Прикладной";
                    break;

                case Ab_lv.Interface_A_logical: // 20 логические элементы
                    return_value = "Логический";
                    break;

                case Ab_lv.Interface_B_abstract: // 21 универсальный интерфейс
                    return_value = "Абстрактный";
                    break;

                case Ab_lv.Interface_C_infinity: // 21 универсальный интерфейс
                    return_value = "Идейный";
                    break;

            }
            return return_value;
        }

        private void level_image_Click(object sender , EventArgs e)
        {
            OnClick( e );
        }
    }
}
