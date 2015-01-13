using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.identifier
{
    /// <summary>
    /// класс идентификатора языка pl2
    /// </summary>
    public class Identifier
    {
        public pl2.data.identifier.attribute.name.Name name;
        public pl2.data.identifier.context.Context context;
        public Identifier(
            pl2.data.identifier.context.Context new_context,
            pl2.data.identifier.attribute.name.Name new_name            
            ) 
        {
        }    
    }
}
