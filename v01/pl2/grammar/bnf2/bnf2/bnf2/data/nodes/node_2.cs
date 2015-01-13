using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grammar.bnf2.data.nodes
{
    /// <summary>
    /// узел с двумя подчиненными узлами
    /// </summary>
    class Node_2 : Node_1
    {
        /// <summary>
        /// заключительный узел
        /// </summary>
        Node_0 end;
    }
}
