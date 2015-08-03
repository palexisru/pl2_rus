using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.schema
{
    public class Schema
    {
        public string field_name;
        public UInt32 field_size;

        public bool write(pl2.data.stream.Stream output, UInt32 position)
        {
            return true;
        }


    }
}
