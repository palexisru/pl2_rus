using System;
using System.IO;
using System.IO.Pipes;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.source.mode
{
    /// <summary>
    /// класс, который получает поток строк 
    /// и возвращает строки с классификацией контекста
    /// </summary>    
    public class Mode_parser
    {
        /// <summary>
        /// начало сегмента кода внутри файла исходного текста
        /// </summary>
        /// 
        public const String mode_start_constant = "mode";

        /// <summary>
        /// окончание сегмента кода внутри файла исходного текста
        /// </summary>
        public const String mode_end_constant = "/mode";

        /// <summary>
        /// необходимые пробелы от начала строки внутри сегмента кода
        /// </summary>
        public const String space4_constant = "    ";

        /// <summary>
        /// сообщение об отсутствии четырех пробелов внутри сегмента кода
        /// </summary>
        public const String mode_fatal_no_spaces = "no four spaces";

        private Boolean mode_started = false;
        private string mode_private = "";
        private string name_private = "";

        public readonly StreamReader input;
        protected int line_number_protected;
        public int line_number 
        {
            get 
            {
                return line_number_protected; 
            }
        }

        public Mode_parser(String file_path_parameter)
        {
            input = new StreamReader(file_path_parameter);
        }

        public string mode
        {
            get
            {
                return mode_private;
            }
        }

        public string name
        {
            get
            {
                return name_private;
            }
        }

        public Mode_parser (System.IO.StreamReader stream_parameter) 
        {
            input = stream_parameter;
        }

        public string read_line()
        {
            string s_current_line = input.ReadLine();
            if (s_current_line != null){
                string left5 = s_current_line.PadLeft(5);
                string left4 = left5.PadLeft(4);
                Boolean end_of_mode_section = false;
                ++line_number_protected;

                if (mode_started)
                {
                    // проверка на окончание секции кода
                    if (left5 == mode_end_constant)
                    {
                        mode_started = false;
                        mode_private = "";
                        name_private = "";
                        end_of_mode_section = true;
                    }

                    // проверка на отсутствие четырех пробелов внутри секции кода
                    if (left4 != space4_constant)
                    {
                        s_current_line = mode_fatal_no_spaces;
                    }
                }
                else
                {
                    // начало секции кода
                    if (left4 == mode_start_constant )
                    {

                    }
                    else // текст вне сегмента кода
                    {
                        s_current_line = "";
                    }
                }
            }
            return s_current_line;
        }
    }
}
