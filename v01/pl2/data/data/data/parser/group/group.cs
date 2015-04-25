using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.parser.group
{
    class Group : pl2.data.parser.expression.Expression
    {
        pl2.data.parser.repetition.Repetition body;

        pl2.data.parser.literal.Literal start;
        pl2.data.parser.literal.Literal end;
    }
}
