using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grammar.bnf2
{
    /// <summary>
    /// Именованное правило
    /// </summary>
    public class pattern
    {
        /// <summary>
        /// имя правила
        /// </summary>
        public string name_draft;
        public string name_local {
            get {
                return name_draft;                
            }
        }
    }
}
