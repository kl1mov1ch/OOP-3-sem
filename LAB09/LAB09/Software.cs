using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace LAB09
{
        public class Software
        {
        public string value;
            public Software(string name)
            {
                value = name;
            }

            public override string ToString()
            {
                return $"Название {value}";
            }
        }
}
