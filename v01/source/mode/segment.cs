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
        public readonly source.mode.parsers.Source source;

        public Segment(source.mode.parsers.Source source_parameter)
        {
            source = source_parameter;
        }

        public String read_line()
        {
            String s;
            s = source.read_line();
            if (s != null){
                if (s.PadRight(parsers.Source.mode_end_constant.Length) == parsers.Source.mode_end_constant)
                {
                    s = null;
                }
            }
            return s;
        }

    }
}
