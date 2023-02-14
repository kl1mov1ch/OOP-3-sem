using System;
using System.Collections.Generic;

namespace LAB13
{
    [Serializable]
    public class Flat<T>
    {
        public T year { get; set; }
        public T name { get; set; }

        public Flat() { }
        public Flat(T Year, T Name) 
        { 
            year = Year;
            name = Name;
        }  
    }

}
