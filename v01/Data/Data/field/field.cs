using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.data.field
{
    public class Field
    {
        public string field_name;
        public Field_types field_type;
        public UInt32 field_size;

        public bool write(pl2.data.stream.Stream output, UInt32 position)
        {
            return true;
        }
    }
}
