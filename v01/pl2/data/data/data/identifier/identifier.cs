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
        /// <summary>
        /// имя идентификатора
        /// </summary>
        public pl2.data.identifier.name.Name name;

        /// <summary>
        /// контекст иденификатора
        /// </summary>
        public pl2.data.identifier.context.Context context;

        /// <summary>
        /// конструктор идентификатора
        /// </summary>
        /// <param name="new_context">контекст идентификатора</param>
        /// <param name="new_name">имя идентификатора</param>
        public Identifier(
            pl2.data.identifier.context.Context new_context,
            pl2.data.identifier.name.Name new_name            
            ) 
        {
            name = new_name;
            context = new_context;
        }    
    }
}
