using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.source.bnf.data.key_word
{
    /// <summary>
    /// ключевое слово
    /// </summary>
    public struct key_word
    {
        public readonly string sequence;
        public readonly key_value value;
        public key_word(string sequence_p, key_value value_p)
        {
            sequence = sequence_p;
            value = value_p;
        }
    }
}
