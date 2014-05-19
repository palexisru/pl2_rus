using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace pl2.rainbow.description
{
    public class Cell_system
    {
        [Browsable( true ) , Description( "Уровень абстрактности" ) , Category( "Data" )]
        public Abstraction_level_enum abstraction { get; set; }

        [Browsable( true ) , Description( "Фаза цикла Деминга" ) , Category( "Data" )]
        public Phase_direction_enum phase { get; set; }

        [Browsable( true ) , Description( "Название в ASCII" ) , Category( "Data" )]
        public string tag { get; set; }

        [Browsable( true ) , Description( "Имя по умолчанию" ) , Category( "Data" )]
        public string default_name { get; set; }

        public Cell_system(string tag_new , string default_new , Abstraction_level_enum abstraction_new , Phase_direction_enum phase_new)
        {
            tag = tag_new;
            abstraction = abstraction_new;
            phase = phase_new;
            default_name = default_new;
        }
    }
}
