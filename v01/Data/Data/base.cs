using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data
{
    /// <summary>
    /// база данных
    /// </summary>
    public class Base
    {
        /// <summary>
        /// имя файла с данными
        /// </summary>
        private string file_name;

        private pl2.data.stream.Header header;

        /// <summary>
        /// обертка потока для хранилища данных
        /// </summary>
        private pl2.data.stream.Stream house;

        /// <summary>
        /// число - последний испоьзованный идентификатор
        /// </summary>
        private UInt32 last_used_identifier;

        /// <summary>
        /// запись базы данных в поток
        /// </summary>
        /// <param name="output">выходноой поток</param>
        /// <param name="position">позиция в потоке для начала вывода</param>
        /// <returns></returns>
        public bool write(pl2.data.stream.Stream output, UInt32 position)
        {
            return true;
        }

        /// <summary>
        /// обновление данных в указанной позиции
        /// </summary>
        /// <param name="output"></param>
        /// <param name="position"></param>
        /// <returns>признак успешности вы</returns>
        public bool update(pl2.data.stream.Stream output, UInt32 position)
        {
            return true;
        }
        
        /// <summary>
        /// получить новый идентификатор для базы данных
        /// полученный идентификатор сохраняется в качестве последнего испоьзованного в
        /// </summary>
        /// <returns>новый идентификатор</returns>
        public long get_new_identifier()
        {
            return

        }

    }
}
