using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.parser.repetition
{
    class Repetition : pl2.data.parser.expression.Expression
    {
        pl2.data.parser.expression.Expression first;
        pl2.data.parser.repetition.Repetition tail;

        pl2.data.parser.literal.Literal delimiter;
    }
}
