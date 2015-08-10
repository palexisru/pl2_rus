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

    /// <summary>
    /// логические переменные пространства понятий
    /// </summary>
    public enum Logical_type
    {
        axiome = 'A',             // аксиома в заданном пространстве
        theoreme = 'T',           // доказанная теорема в заданном пространстве
        theoreme_first_10 = 'Y',  // правдоподобная гипотеза в заданном пространстве с вероятностью 90-100%
        theoreme_learn = 'S',     // обучаемое знание
        theoreme_last_10 = 'N',   // улучшаемая гипотеза в заданном пространстве с вероятностью 0-10%
        un_theoreme = 'F',        // опровергнутая гипотеза в заданном пространстве
        inverse = 'I'             // отрицание аксиомы в заданном пространстве
    }
}
