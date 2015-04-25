using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.source.mode.parsers
{
    /// <summary>
    /// анализатор секции файла исходного года
    /// </summary>
    public abstract class Parser
    {
        public String name;

        public abstract String read_line();
        
    }
}
