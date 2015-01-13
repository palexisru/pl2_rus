using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.identifier.attribute.name
{
    /// <summary>
    /// атрибут - имя идентификатора
    /// </summary>
    public class Name
    {
        /// <summary>
        /// имя идентификатора в пространстве draft
        /// </summary>
        public string draft;

        /// <summary>
        /// имя иденификатора в выбранном языке файла/проекта
        /// </summary>
        public string local
        {
            get
            {
                return draft;
            }
        }

    }
}
