using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace pl2.rainbow.description
{
    /// <summary>
    /// уровни направления дискретные
    /// </summary>
    public enum Phase_direction_enum
    {
        wide = 0 ,
        invariant = 1 ,
        before = 2 ,
        action = 3 ,
        after = 4
    }

    /// <summary>
    /// значение фазы
    /// </summary>
    public class Phase_system
    {
        [Browsable( true ) , Description( "Номер фазы" ) , Category( "Data" )]
        Phase_direction_enum phase_direction;

        [Browsable( true ) , Description( "Важность фазы" ) , Category( "Data" )]
        public Importance_enum importance { get; set; }

        [Browsable( true ) , Description( "Значение фазы" ) , Category( "Data" )]
        public Single percent { get; set; } 

    }
}
