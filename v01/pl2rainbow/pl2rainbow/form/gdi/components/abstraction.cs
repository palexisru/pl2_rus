﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pl2.rainbow.description;

namespace pl2.rainbow.form.gdi.components
    {
    public partial class Abstraction : UserControl
        {
        private Abstraction_level abstraction_level_private;
        public Abstraction()
            {
            InitializeComponent();
            }

        [Browsable( true ) , Description( "Уровень абстрактности" ) , Category( "Data" )]
        public pl2.rainbow.description.Abstraction_level level 
        {
            get {return abstraction_level_private;} 
            set {
                abstraction_level_private = value;
                cell_act.single_button.Text = level.ToString();
            }
        }

        [Browsable( true ) , Description( "Уровень абстрактности" ) , Category( "Data" )]
        public int level_number{
            get{ return (int) level;  }
        }

        private void button1_Click(object sender , EventArgs e)
            {

            }

        private void level_Paint(object sender , PaintEventArgs e)
            {
                draw_elements(e);
            }

        private void draw_elements(PaintEventArgs e)
            {
            Point[] pt;
            int h = level_image.ClientSize.Height;
            int dt = h / 10;
            int hh = h / 2;
            int w = ClientSize.Width;
            Abstraction_level abstraction_level = this.level;
            int direction_phase = 1;
            Color drawing_color = color_from_level(abstraction_level);
            Color inverce_color = System.Drawing.Color.FromArgb((255-drawing_color.R)>>3, (255-drawing_color.G)>>3, (255-drawing_color.B)>>3) ;
            System.Drawing.Brush b = new SolidBrush( inverce_color );
            System.Drawing.Pen p = new Pen( inverce_color , 1 );
            
            bool fill_phase = false;
            if (dt > w / 10)
                dt = w / 10;
            if (dt < 5)
                dt = 5;
            int dt2 = dt + dt;

            level_image.Width = dt2+dt;
            level_image.BackColor = drawing_color;
            cell_act.BackColor = drawing_color;
            cell_plan.BackColor = drawing_color;
            cell_do.BackColor = drawing_color;
            cell_check.BackColor = drawing_color;

            //PanelFigure.Padding.All = dt;


#region up_left_2_down
                if (abstraction_level >= Abstraction_level.Interface_logical && abstraction_level <= Abstraction_level.Interface_infinity)
                {
                pt = new Point[] { 
                    new Point( dt + dt - 1, -1),
                    new Point( dt + dt - 1, dt -1),
                    new Point( dt - 1, dt - 1)};
                if (abstraction_level == Abstraction_level.Interface_infinity)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion
                
#region up_left_2_up
                if (abstraction_level >= Abstraction_level.Interface_functional && abstraction_level <= Abstraction_level.Interface_infinity)
                {
                pt = new Point[] { 
                    new Point( dt - 1, -1),
                    new Point( dt + dt - 1, -1),
                    new Point( dt - 1, dt - 1)};
                if (abstraction_level == Abstraction_level.Interface_target || abstraction_level == Abstraction_level.Interface_logical)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#region up_left_1_up
                if (abstraction_level >= Abstraction_level.Interface_politic && abstraction_level <= Abstraction_level.Interface_target)
                {
                pt = new Point[] { 
                    new Point( -1, -1),
                    new Point( dt - 1, -1),
                    new Point( dt - 1, dt - 1)};
                if (abstraction_level >= Abstraction_level.Interface_session && abstraction_level <= Abstraction_level.Interface_functional)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#region up_left_1_down
                if (abstraction_level >= Abstraction_level.Interface_exchange && abstraction_level <= Abstraction_level.Interface_session)
                {
                pt = new Point[] { 
                    new Point( -1, -1),
                    new Point( -1, dt - 1),
                    new Point( dt - 1, dt - 1)};
                if (abstraction_level >= Abstraction_level.Interface_control && abstraction_level <= Abstraction_level.Interface_politic)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#region up_2_up
                if (abstraction_level >= Abstraction_level.Interface_exchange && abstraction_level <= Abstraction_level.Interface_control)
                {
                pt = new Point[] { 
                    new Point( -1, dt - 1),
                    new Point( dt - 1, dt-1),
                    new Point( -1, dt + dt - 1)};
                if (abstraction_level == Abstraction_level.Interface_exchange)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#region up_2_down
                if (abstraction_level >= Abstraction_level.Interface_control && abstraction_level <= Abstraction_level.Interface_exchange)
                {
                pt = new Point[] { 
                    new Point( dt - 1, dt * 2 - 1),
                    new Point( dt - 1, dt - 1),
                    new Point( -1, dt * 2 - 1)};
                if (abstraction_level == Abstraction_level.Interface_control || abstraction_level == Abstraction_level.Interface_exchange)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#if false
                if (abstraction_level >= Abstraction_level.Interface_technology && abstraction_level <= Abstraction_level.Interface_concurent)
                {
                pt = new Point[] { 
                    new Point( -1, hh - dt*3),
                    new Point( dt - 1, hh - dt *3 ),
                    new Point( dt - 1, hh - dt *3/2)};
                if (abstraction_level == Abstraction_level.Interface_technology)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endif

#region up_middle
                if (abstraction_level >= Abstraction_level.Interface_technology && abstraction_level <= Abstraction_level.Interface_concurent)
                {
                pt = new Point[] { 
                    new Point( -1, hh - dt*3),
                    new Point( dt - 1, hh - dt*3/2 ),
                    new Point( -1, hh - dt*2)};
                if (abstraction_level == Abstraction_level.Interface_concurent)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

                if (abstraction_level >= Abstraction_level.Interface_technology && abstraction_level <= Abstraction_level.Interface_concurent)
                    {
                pt = new Point[] { 
                    new Point( -1, hh - dt*2),
                    new Point( dt - 1, hh - dt*3/2),
                    new Point( -1, hh - dt + 1)};
                if (abstraction_level == Abstraction_level.Interface_technology)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#if false
                if (abstraction_level >= Abstraction_level.Interface_concurent && abstraction_level <= Abstraction_level.Interface_exchange)
                {
                pt = new Point[] { 
                    new Point( -1, hh - dt),
                    new Point( dt - 1, hh - dt*3/2),
                    new Point( dt * 2 / 3, hh - dt / 3 )};
                if (abstraction_level == Abstraction_level.Interface_concurent || abstraction_level == Abstraction_level.Interface_concurent)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endif

            #region center
            if (abstraction_level >= Abstraction_level.Class_below_reality && abstraction_level <= Abstraction_level.Interface_above_reality)
                {
                pt = new Point[] { 
                    new Point( -1, hh - dt),
                    new Point( dt*2/3, hh-dt/3),
                    new Point( -1, hh - dt/4)};
                if (abstraction_level == Abstraction_level.Interface_above_reality)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            if (abstraction_level >= Abstraction_level.Class_below_reality && abstraction_level <= Abstraction_level.Interface_above_reality)
                {
                pt = new Point[] { 
                    new Point( -1, hh - dt/4),
                    new Point( dt*2/3, hh-dt/3),
                    new Point( dt - 1, hh),
                    new Point( dt*2/3, hh+dt/3),
                    new Point( -1, hh + dt/4)};
                if (abstraction_level == Abstraction_level.Class_reality)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            if (abstraction_level >= Abstraction_level.Class_below_reality && abstraction_level <= Abstraction_level.Interface_above_reality)
                {
                pt = new Point[] { 
                    new Point( -1, hh + dt),
                    new Point( dt*2/3, hh + dt/3),
                    new Point( -1, hh + dt/4)};
                if (abstraction_level == Abstraction_level.Class_below_reality)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#if false
            if (abstraction_level >= Abstraction_level.Class_executive && abstraction_level <= Abstraction_level.Class_executive)
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
            if (abstraction_level >= Abstraction_level.Class_responsibility && abstraction_level <= Abstraction_level.Class_executive)
                {
                pt = new Point[] { 
                    new Point( -1, hh + dt),
                    new Point( dt-1, hh + dt*3/2),
                    new Point( -1, hh + dt*2)};
                if (abstraction_level == Abstraction_level.Class_executive)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            if (abstraction_level >= Abstraction_level.Class_responsibility && abstraction_level <= Abstraction_level.Class_executive)
                {
                pt = new Point[] { 
                    new Point( -1, hh+dt*2),
                    new Point( dt-1, hh+dt*3/2),
                    new Point( -1, hh+dt*3)};
                if (abstraction_level == Abstraction_level.Class_responsibility)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#if false
            if (abstraction_level >= Abstraction_level.Class_executive && abstraction_level <= Abstraction_level.Class_executive)
                {
                pt = new Point[] { 
                    new Point( -1, hh+dt*3),
                    new Point( dt-1, hh+dt*3/2),
                    new Point( dt-1, hh+dt*3)};
                if (abstraction_level == Abstraction_level.Class_executive)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }

            if (abstraction_level >= 11 && abstraction_level <= 14)
                {
                pt = new Point[] { 
                    new Point( -1, h-dt2),
                    new Point( dt-1, h-dt2),
                    new Point( dt-1, h-dt)};
                if (abstraction_level == 12 || abstraction_level == 13)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endif

#region down_2_down
            if (abstraction_level >= Abstraction_level.Class_specialist && abstraction_level <= Abstraction_level.Class_parallel)
                {
                pt = new Point[] { 
                    new Point( -1, h-dt*2),
                    new Point( -1, h-dt),
                    new Point( dt-1, h-dt)};
                if (abstraction_level == Abstraction_level.Class_parallel || abstraction_level == Abstraction_level.Class_parallel)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#region down_1_up
            if (abstraction_level >= Abstraction_level.Class_system && abstraction_level <= Abstraction_level.Class_parallel)
                {
                pt = new Point[] { 
                    new Point( -1, h-dt),
                    new Point( dt-1, h-dt),
                    new Point( -1, h)};
                if (abstraction_level >= Abstraction_level.Class_process && abstraction_level <= Abstraction_level.Class_specialist)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#region down_1_down
            if (abstraction_level >= Abstraction_level.Class_tuple && abstraction_level <= Abstraction_level.Class_process)
                {
                pt = new Point[] { 
                    new Point( -1, h),
                    new Point( dt-1, h-dt),
                    new Point( dt-1, h)};
                if (abstraction_level >= Abstraction_level.Class_structure && abstraction_level <= Abstraction_level.Class_system)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#region down_left_2_down
            if (abstraction_level >= Abstraction_level.Class_infinity && abstraction_level <= Abstraction_level.Class_structure)
                {
                pt = new Point[] { 
                    new Point( dt-1, h-dt),
                    new Point( dt-1, h),
                    new Point( dt*2-1, h)};
                if (abstraction_level >= Abstraction_level.Class_domain && abstraction_level <= Abstraction_level.Class_tuple)
                    e.Graphics.FillPolygon( b , pt , System.Drawing.Drawing2D.FillMode.Alternate );
                e.Graphics.DrawPolygon( p , pt );
                }
#endregion

#region down_left_2_up
            if (abstraction_level >= Abstraction_level.Class_infinity && abstraction_level <= Abstraction_level.Class_domain)
                {
                pt = new Point[] { 
                    new Point( dt-1, h-dt),
                    new Point( dt*2-1, h-dt),
                    new Point( dt*2-1, h)};
                if (abstraction_level >= Abstraction_level.Class_infinity && abstraction_level <= Abstraction_level.Class_infinity)
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
                if (ParentForm is sdi.main.main_sdi_form)
                {
                    p = new Pen( inverce_color , 2 );
                    sdi.main.main_sdi_form pf = ParentForm as sdi.main.main_sdi_form;
                    if (this.level > Abstraction_level.Class_reality){ 
                        e.Graphics.DrawRectangle(p, dt+2, hh-dt/2 - 1, dt+2, dt+2);
                    }
                    else{
                        e.Graphics.DrawEllipse(p, dt+2, hh-dt/2 - 1, dt+2, dt+2);
                    }
                    if (pf.selected_level == this.level){
                        e.Graphics.FillEllipse(b, dt+3, hh - dt/2 , dt, dt);
                    }
                }
            
            
            
            
            }

        public static Color color_from_level(Abstraction_level abstraction_level)
            {
                Color return_value = Color.FromArgb(127, 127, 127, 127);
                switch(abstraction_level)
                {
                case Abstraction_level.Class_infinity: // 1 пустой тип - void, empty, nil, null
                        return_value = Color.FromArgb( 80, 0, 176); // (143, 0, 143);
                        break;

                    case Abstraction_level.Class_domain:  // 2 элементарный класс среды исполнения (ValueType)
                        return_value = Color.FromArgb( 64, 0, 192); // ( 103, 0, 151);
                        break;

                    case Abstraction_level.Class_tuple: // 3 связь между указанными объектами (аналогично предложениям Prolog, списку параметров функций), методы и свойства отсутствуют, доступ происходит только к открытым членам. По возможностям аналогично набору, возвращаемому из реляционной базы данных
                        return_value = Color.FromArgb( 32, 32, 255); // ( 55, 0, 143);
                        break;

                    case Abstraction_level.Class_structure: // 4 структура с открытыми элементами. Для доступа к элементу текущего объекта используется слово this. Может содержать методы для обработки.
                        return_value = Color.FromArgb( 0, 96, 160); // ( 0, 55, 135);
                        break;

                    case Abstraction_level.Class_system: // 5 система, которая может содержать закрытые и защищенные наследуемые элементы.
                        return_value = Color.FromArgb( 0, 128, 128);  // ( 1, 58, 135);
                        break;

                    case Abstraction_level.Class_process: // 6 процесс, которому можно передать инициализирующие значения и получить результирующие значения. Соответствует службе. Любой метод получает не только указатель на себя (this), но и указатель на вызвавший класс или объект (sender). Это позволяет проверить авторизацию объекта, осуществляющего доступ к методу. Для предотвращения низкоуровневой подмены sender, параметры обрабатываемого события запрашиваются у вызывающего объекта после получения идентификатора сообщения. Содержит стандартные методы.
                        return_value = Color.FromArgb( 0, 144, 112); // ( 1, 88, 116);
                        break;

                    case Abstraction_level.Class_specialist: // 7 специализированный класс, который выполняет указанный соглашениями набор функций. Соответствует COM-модели. Поддерживает свойство possibility с интерфейсом control interface
                        return_value =Color.FromArgb( 0, 160, 96); // ( 0, 96, 84);
                        break;

                    case Abstraction_level.Class_parallel: // 8 асинхронно работающий класс, передающий сообщения о выполнении задачи. Поддерживает свойство manager с интерфейсом exchange interface
                        return_value =Color.FromArgb( 0, 176, 80); // ( 0, 117, 0);
                        break;

                    case Abstraction_level.Class_responsibility: // 9 таможня, обеспечивающее ответственность за выполнение задачи. Поддерживает свойство environment с интерфейсом concurent interface
                        return_value =Color.FromArgb( 0, 192, 64); // ( 65, 137, 3);
                        break;

                    case Abstraction_level.Class_executive: // 10 исполняемый класс
                        return_value =Color.FromArgb( 0, 208, 48); // ( 110, 141, 3);
                        break;

                    case Abstraction_level.Class_reality:    // 11 среда исполнения
                        return_value = Color.FromArgb( 0, 208, 0); // ( 138, 157, 3);
                        break;

                    case Abstraction_level.Interface_technology: // 12 технологические элементы
                        return_value =Color.FromArgb( 64, 192, 0); // ( 178, 158, 0);
                        break;

                    case Abstraction_level.Interface_concurent: // 13 оценка соответствия с внешними аналогами
                        return_value =Color.FromArgb( 80, 176, 0); // ( 244, 226, 6);
                        break;

                    case Abstraction_level.Interface_exchange: // 14 взаимодействие с окружающей средой
                        return_value =Color.FromArgb( 96, 160, 0); // ( 253, 174, 11);
                        break;

                    case Abstraction_level.Interface_control: // 15 описание управления
                        return_value = Color.FromArgb( 128, 128, 0); // ( 251, 137, 4);
                        break;

                    case Abstraction_level.Interface_politic: // 16 описание стратегии
                        return_value = Color.FromArgb( 160, 96, 0); // ( 230, 90, 15);
                        break;

                    case Abstraction_level.Interface_session: // 17 интерфейсы для хранения текущего состояния
                        return_value =Color.FromArgb( 176, 80, 0); // ( 225, 66, 1);
                        break;

                    case Abstraction_level.Interface_functional: // 18 функциональные связи, конечные автоматы
                        return_value =Color.FromArgb( 192, 64, 0); // ( 226, 38, 1);
                        break;

                    case Abstraction_level.Interface_target: // 19 описание целевых функций
                        return_value = Color.FromArgb( 255, 32, 32); // ( 247, 47, 0);
                        break;

                    case Abstraction_level.Interface_logical: // 20 логические элементы
                        return_value = Color.FromArgb( 224, 0, 32); // ( 248, 26, 3);
                        break;

                    case Abstraction_level.Interface_infinity: // 21 универсальный интерфейс
                        return_value = Color.FromArgb( 192, 0, 64); // ( 255, 0, 0);
                        break;

                }
                return return_value;
            
            }

        private void level_image_Click(object sender , EventArgs e)
            {
                // if (Parent is Abstraction){
                    // Abstraction a = Parent as Abstraction;
                    OnClick(e);
                //}
            }
        }
    }
