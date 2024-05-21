using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl2.pl2lex
{
    public enum Operation_Enum
    {
        None = 0,

        UnaryPlus_Op,
        UnaryMinus_Op,
        UnaryPreffixIncrement,
        UnaryPreffixDecrement,

        Assign_Op /* := */,
        Add_Op,
        Sub_Op,
        Mul_Op,
        Div_Op,
        Mod_Op,

        EQ_Op,
        NE_Op,
        GT_Op,
        GE_Op,
        LT_Op,
        LE_Op,

        BoolAnd_Op,
        BoolOr_Op,
        BoolNot_Op,

        String_Concat_Op
    }
}
