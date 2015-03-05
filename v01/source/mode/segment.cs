using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.source.mode
{
    /// <summary>
    /// Сегмент кода в файле исходного текста с указанным именем и способом трансляции
    /// </summary>
    class Segment
    {
        public readonly Mode_parser source;
        public Segment(Mode_parser source_parameter)
        {
            source = source_parameter;
        }

        public String read_line()
        {
            String s;
            s = source.read_line();
            if (s != null){
                if (s.PadRight(Mode_parser.mode_end_constant.Length) == Mode_parser.mode_end_constant)
                {
                    s = null;
                }
            }
            return s;
        }

    }
}
