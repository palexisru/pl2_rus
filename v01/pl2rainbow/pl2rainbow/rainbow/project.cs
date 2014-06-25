using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.rainbow.description;
using pl2.rainbow.description.xml.project;

namespace pl2.rainbow
{
    public class Project
    {
        [Browsable( true ) , Description( "URL проекта для считывания" ) , Category( "Data" )]
        public string URL { get; set; }

        [Browsable( true ) , Description( "Имя файла проекта для сохранения" ) , Category( "Data" )]
        public string filename { get; set; }

        [Browsable( true ) , Description( "Количество одновременно видимых строк" ) , Category( "Data" )]
        public int number_of_colors { get; set; }

        [Browsable( true ) , Description( "Количество одновременно видимых направлений, 4" ) , Category( "Data" )]
        public int number_of_directions { get; set; }

        [Browsable( true ) , Description( "Всегда выводить центральный элемент модели" ) , Category( "Data" )]
        public bool center_allwase_visible { get; set; }

        [Browsable( true ) , Description( "Текущий центральный выводимый уровень" ) , Category( "Data" )]
        public pl2.rainbow.description.Abstraction_level_enum current_abstraction_center { get; set; }

        [Browsable( true ) , Description( "Текущий центр фаз" ) , Category( "Data" )]
        public pl2.rainbow.description.Phase_direction_enum current_phase_center { get; set; }

        [Browsable( true ) , Description( "Выводить строки с указанными уровнями важности" ) , Category( "Data" )]
        public Importance_enum visible_importance { get; set; }

        [Browsable( true ) , Description( "Отображать резервные уровни" ) , Category( "Data" )]
        public bool visible_reserved { get; set; }

        [Browsable( true ) , Description( "Отражать уровни симметрично" ) , Category( "Data" )]
        public bool visible_symmetric { get; set; }

        public Project()
        {
            current_abstraction_center = Abstraction_level_enum.Interface_9_target;
            current_phase_center = Phase_direction_enum.action;
            center_allwase_visible = true;
            visible_importance = Importance_enum.probably;
            visible_symmetric = true;
            number_of_colors = 3;
            number_of_directions = 4;
            // назначаем имя файла по умолчанию
            filename = "project_default.xml";
        }

    }
}
