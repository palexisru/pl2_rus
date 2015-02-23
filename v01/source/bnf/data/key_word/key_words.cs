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
        key_predicate, // отделение имение правила от тела правила
        key_or, // выбор первого или второго правила тела
        key_and, // совокупность из первого и второго правила
        key_namespace_begin_brecket, // скобка, открывающая тело пространства имен
        key_namespace_end_brecket, // скобка, закрываюшая тело пространства имен
        key_event_begin_brecket, // скобка, открывающая тело кода, сопоставленного правилу
        key_event_end_brecket,  // скобка, закрывающая тело кода, сопоставленного правилу
        key_dot, // точка, отделяющая контексты идентификатора
        key_name_space, // ключевое слово для обозначения пространства имен
        key_empty, // ключевое слово для обозначения пустго правила
        key_recursively, // ключевое слово для повторного применения начального правила
        key_identifier, // признак распознанного идентификатора (буква с последующими буквами, цифрами, символом подчеркивания)
        key_rule // признак распознанного правила
    }


    public class key_words 
    {
        public readonly key_word[] list =
        {
            new key_word( "::=", key_value.key_predicate ),
            new key_word( "|", key_value.key_or ),
            new key_word( "&", key_value.key_and ),
            new key_word( "{@", key_value.key_namespace_begin_brecket ),
            new key_word( "@}", key_value.key_namespace_end_brecket ),
            new key_word( "{&", key_value.key_event_begin_brecket ),
            new key_word( "&}", key_value.key_event_end_brecket ),
            new key_word( "name_space", key_value.key_name_space ),
            new key_word( ".", key_value.key_dot ),
            new key_word( "empty", key_value.key_empty ),
            new key_word( "recursively", key_value.key_recursively ),
            new key_word( "identifier", key_value.key_identifier )
        };
 
    }
}
