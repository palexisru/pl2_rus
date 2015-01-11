using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grammar.bnf2.nodes
{
    /// <summary>
    /// Именованное правило без подправил - 
    /// основа для описания доугих правил
    /// </summary>
    class Node_0
    {
        /// <summary>
        /// имя правила
        /// </summary>
        public string name_draft;
        public string name_local
        {
            get
            {
                return name_draft;
            }
        }
    }
}
