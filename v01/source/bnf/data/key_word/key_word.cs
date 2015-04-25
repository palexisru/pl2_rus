using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pl2.data.parser.literal;

namespace pl2.source.bnf.data.key_word
{
    /// <summary>
    /// ключевое слово
    /// </summary>
    public struct key_word
    {
        /// <summary>
        /// строчное значение пе
        /// </summary>
        public string[] sequence;
        public readonly key_value value;

        public key_word(string sequence_p, key_value value_p)
        {
            sequence = (System.String[]) Array.CreateInstance(typeof( System.String), 1);
            sequence[0] = sequence_p;

            // pl2.data.parser.literal.Literal delimiter;

            value = value_p;
        }
    }
}
