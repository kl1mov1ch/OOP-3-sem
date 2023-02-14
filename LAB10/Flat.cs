using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10
{
    public class Flat
    {
        public int roomsCount { get; set; }
        public string homeAddress { get; set; }
        public int homeNumber { get; set; }
        public int apartmentNumber { get; set; }
        public int Floor { get; set; }

        public Flat(int Rooms, int Home,string Address, int Num, int Floo) 
        { 
            roomsCount = Rooms;
            homeAddress = Address;
            homeNumber = Home;
            apartmentNumber = Num;
            Floor = Floo;
        }

        public override string ToString()
        {
            return $"Адрес {homeAddress}, кол. комнат {roomsCount}, номер дома {homeNumber}, номер квартиры {apartmentNumber}, этаж {Floor}";
        }
    }
}
