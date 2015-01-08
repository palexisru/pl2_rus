using System;
using  System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pl2.data.generic.quick.interfaces;

namespace pl2.data.generic.quick
{
    class G_Array<T_key_type> where T_key_type : struct, I_Sortable<T_key_type>
    {
    }
}
