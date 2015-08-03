using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.table
{
    public class Table
    {
        public string field_name;
        public UInt32 field_size;

        public bool write(pl2.data.stream.Stream output, UInt32 position)
        {
            return true;
        }


    }
}
