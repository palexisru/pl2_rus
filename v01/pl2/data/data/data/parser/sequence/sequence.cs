using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.parser.sequence
{
    class Sequence : pl2.data.parser.Parser
    {
        pl2.data.parser.literal.Literal suffix;
        pl2.data.parser.expression.Expression first;
        pl2.data.parser.expression.Expression second;
    }
}
