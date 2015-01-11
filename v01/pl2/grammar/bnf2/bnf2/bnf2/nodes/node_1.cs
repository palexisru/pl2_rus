using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grammar.bnf2.nodes
{
    /// <summary>
    /// узел с одним подправилом
    /// </summary>
    class Node_1 : Node_0
    {
        /// <summary>
        /// первый подчиненный узел
        /// </summary>
        Node_0 begin;
    }
}
