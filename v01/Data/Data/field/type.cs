using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.field
{
    public enum Field_types : byte
    {
        natural = 'H',
        numeric ='N',
        char8 = 'C',
        char16 = 'S',
        char32 = 'U',
        date = 'D',
        time = 'T',
        logical = 'L',
        binary = 'B',
        random = 'R'
    }

    public class Type
    {
    }
}
