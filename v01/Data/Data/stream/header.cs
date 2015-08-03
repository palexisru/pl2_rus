using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.stream
{
    public struct Header
    {
        /// <summary>
        /// мнемоника иденификатора базы PL2 "PLDATA  "
        /// </summary>
        byte[] mnemonic_string;

        /// <summary>
        /// мнемоника идентификатора версии формата "01"
        /// </summary>
        byte[] version_string;

        byte index_flag;

        /// <summary>
        /// пустое пространство, заполненное пробеами
        /// </summary>
        byte[] reserved;

        const long index_flag_offset = 30;
        const long data_offset = 30;
        
    }
}
