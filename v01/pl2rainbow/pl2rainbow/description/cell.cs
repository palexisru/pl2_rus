using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace pl2.rainbow.description
{
    public class Cell
    {
        [Browsable( true ) , Description( "Уровень абстрактности" ) , Category( "Data" )]
        public Abstraction_level abstraction;

        [Browsable( true ) , Description( "Фаза цикла Деминга" ) , Category( "Data" )]
        public Phase_direction phase;

        [Browsable( true ) , Description( "Название в ASCII" ) , Category( "Data" )]
        public string tag;

        [Browsable( true ) , Description( "Имя по умолчанию" ) , Category( "Data" )]
        public string default_name;

        public Cell(string tag_new, string default_new, Abstraction_level abstraction_new, Phase_direction phase_new)
        {
            abstraction = abstraction_new;
            phase = phase_new;
            tag = tag_new;
            default_name = default_new;
        }
    }
}
