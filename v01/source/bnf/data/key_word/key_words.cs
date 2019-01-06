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
        key_predicate, // отделение имени правила от тела правила
        key_or, // выбор первого или второго правила тела
        key_and, // совокупность из первого и второго правила
        key_concatenate, // последовательность из сообщений

        key_context_begin_brecket, // скобка, открывающая тело пространства имен
        key_context_end_brecket, // скобка, закрываюшая тело пространства имен

        key_class_begin_brecket, // скобка, открывающая тело кода, сопоставленного правилу
        key_class_end_brecket,  // скобка, закрывающая тело кода, сопоставленного правилу

        key_property_begin_brecket, // скобка, открывающая свойства, сопоставленного правилу
        key_property_end_brecket,  // скобка, закрывающая свойства, сопоставленного правилу

        key_event_begin_brecket, // скобка, открывающая тело кода, сопоставленного правилу
        key_event_end_brecket,  // скобка, закрывающая тело кода, сопоставленного правилу

        key_dot,       // точка, отделяющая контексты идентификатора
        key_comma,       // точка, отделяющая контексты идентификатора
        key_semicolon,       // точка, отделяющая контексты идентификатора
        key_context,   // ключевое слово для обозначения пространства имен
        key_interface, // ключевое слово для обозначения пространства имен
        key_unit,      // ключевое слово для обозначения пространства имен
        key_class,      // ключевое слово для обозначения пространства име
        key_empty,     // ключевое слово для обозначения пустого правила
        key_recursively, // ключевое слово для повторного применения начального правила
        key_identifier, // признак распознанного идентификатора (буква с последующими буквами, цифрами, символом подчеркивания)
        key_rule       // признак распознанного правила
    }


    public class key_words 
    {
        public readonly key_word[] list =
        {
            new key_word( ".", key_value.key_dot ),
            new key_word( ",", key_value.key_comma ),
            new key_word( ";", key_value.key_semicolon ),

            new key_word( "::=", key_value.key_predicate ),

            new key_word( "||", key_value.key_or ),
            new key_word( "&&", key_value.key_and ),
            new key_word( "..", key_value.key_concatenate),

            new key_word( "{@", key_value.key_context_begin_brecket ),
            new key_word( "@}", key_value.key_context_end_brecket ),

            new key_word( "{*", key_value.key_class_begin_brecket ),
            new key_word( "*}", key_value.key_class_end_brecket ),

            new key_word( "{&", key_value.key_event_begin_brecket ),
            new key_word( "&}", key_value.key_event_end_brecket ),

            new key_word( "context", key_value.key_context ),
            new key_word( "class", key_value.key_class ),
            new key_word( "interface", key_value.key_interface ),
            new key_word( "unit", key_value.key_unit ),
            new key_word( "EMPTY", key_value.key_empty ),
            new key_word( "RECURSIVELY", key_value.key_recursively ),
            new key_word( "IDENTIFIER", key_value.key_identifier )
        };
    }
}
