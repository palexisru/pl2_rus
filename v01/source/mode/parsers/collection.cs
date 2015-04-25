using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.source.mode.parsers
{
    /// <summary>
    /// Collection - список зарегистрированных анализаторов
    /// </summary>
    class Collection
    {
        public Parser[] parser_list = new Parser[0];

        public Boolean add(Parser parser_parameter)
        {
            Boolean parser_not_registered = true;

            foreach (Parser parser_enumerated in parser_list) 
            {
                if (parser_enumerated.name == parser_parameter.name) 
                {
                    parser_not_registered = false;
                    break;
                }
            }

            if (parser_not_registered)
            {
                Parser[] new_parser = new Parser[1];
                new_parser[0] = parser_parameter;
                parser_list = (Parser[])parser_list.Concat(new_parser);
            }
            else 
            {
                throw new Exception("Анализатор языка уже зарегистрирован: " + parser_parameter.name + " !");
            }
            
            return parser_not_registered;
        }
    }
}
