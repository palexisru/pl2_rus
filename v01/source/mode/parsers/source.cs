using System;
using System.IO;
using System.IO.Pipes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace pl2.source.mode.parsers
{
    /// <summary>
    /// класс, который получает поток строк 
    /// и возвращает строки с классификацией контекста
    /// </summary>    
    public class Source
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
        public const String mode_fatal_no_four_stated_spaces = "no_four_spaces";

        /// <summary>
        /// признак того, что происходит распознавание исходного текста
        /// </summary>
        private Boolean mode_started = false;

        /// <summary>
        /// режим распознавания текущего фрагмента
        /// </summary>
        private string source_private = "";

        /// <summary>
        /// имя текущего фрагмента
        /// </summary>
        private string name_private = "";
        
        /// <summary>
        /// входной поток
        /// </summary>
        protected readonly StreamReader input;

        /// <summary>
        /// номер строки в потоке исходного кода
        /// </summary>
        protected int line_number_protected = 0;

        /// <summary>
        /// номер строки в потоке исходного кода
        /// </summary>
        public int line_number 
        {
            get 
            {
                return line_number_protected; 
            }
        }

        /// <summary>
        /// конструктор по именифайла
        /// </summary>
        /// <param name="file_path_parameter"></param>
        public Source(String file_path_parameter)
        {
            input = new StreamReader(file_path_parameter);
            line_number_protected = 0;
        }

        public Source(ref StreamReader text_stream_parameter)
        {
            input = text_stream_parameter;
            line_number_protected = 0;
        }

        public string source
        {
            get
            {
                return source_private;
            }
        }

        public string name
        {
            get
            {
                return name_private;
            }
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
                        source_private = "";
                        name_private = "";
                        end_of_mode_section = true;
                    }

                    // проверка на отсутствие четырех пробелов внутри секции кода
                    if (left4 != space4_constant)
                    {
                        s_current_line = mode_fatal_no_four_stated_spaces;
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
