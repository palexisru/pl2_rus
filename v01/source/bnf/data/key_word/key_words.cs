using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.source.bnf.data.key_word
{
    /// <summary>
    /// список ключевых слов
    /// </summary>
    public enum key_value
    {
        key_predicate,
        key_or,
        key_and,
        key_namespace_left_brecket,
        key_namespace_right_brecket,
        key_event_left_brecket,
        key_event_right_brecket,
        key_dot,
        key_namespace,
        key_empty,
        key_recursive,
        key_identifier

    }

    public class key_words 
    {
        public readonly key_word[] list =
        {
            new key_word( "::=", key_value.key_predicate ),
            new key_word( "|", key_value.key_or ),
            new key_word( "&", key_value.key_and ),
            new key_word( "{@", key_value.key_namespace_left_brecket ),
            new key_word( "@}", key_value.key_namespace_right_brecket ),
            new key_word( "{&", key_value.key_event_left_brecket ),
            new key_word( "&}", key_value.key_event_right_brecket ),
            new key_word( "namespace", key_value.key_namespace ),
            new key_word( ".", key_value.key_dot ),
            new key_word( "empty", key_value.key_empty ),
            new key_word( "recursive", key_value.key_recursive ),
            new key_word( "identifier", key_value.key_identifier )
        };
 
    }
}
