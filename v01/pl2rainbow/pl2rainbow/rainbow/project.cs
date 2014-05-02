using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.rainbow.description;

namespace pl2.rainbow
{
    public class Project
    {
        [Browsable( true ) , Description( "URL проекта" ) , Category( "Data" )]
        public string URL { get; set; }

        [Browsable( true ) , Description( "Имя файла проекта" ) , Category( "Data" )]
        public string filename { get; set; }

        [Browsable( true ) , Description( "Количество видимых колонок" ) , Category( "Data" )]
        public int number_of_colors { get; set; }

        [Browsable( true ) , Description( "Количество видимых направлений" ) , Category( "Data" )]
        public int number_of_directions { get; set; }

        [Browsable( true ) , Description( "Всегда выводить центральный элемент" ) , Category( "Data" )]
        public bool center_allwase_visible { get; set; }

        [Browsable( true ) , Description( "Текущий центр уровней" ) , Category( "Data" )]
        public pl2.rainbow.description.Abstraction_level current_abstraction_center { get; set; }

        [Browsable( true ) , Description( "Текущий центр фаз" ) , Category( "Data" )]
        public pl2.rainbow.description.Phase_direction current_phase_center { get; set; }

        [Browsable( true ) , Description( "Выводить резервные строки" ) , Category( "Data" )]
        public bool visible_specials { get; set; }

        [Browsable( true ) , Description( "Отражать уровни симметрично" ) , Category( "Data" )]
        public bool visible_symmetric { get; set; }

        public Project()
        {
            current_abstraction_center = Abstraction_level.Interface_target;
            current_phase_center = Phase_direction.action;
            center_allwase_visible = true;
            visible_specials = false;
            visible_symmetric = true;
            number_of_colors = 3;
            number_of_directions = 4;

            filename = "project_default.xml";
        }

    }
}
