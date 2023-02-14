using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LAB10
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            var lengthQuery =
            from month in months
            where month.Length == 4
            select month;
            foreach (var month in lengthQuery)
            {
                Console.Write($"{month} ");
            }

            Console.Write("\nЗимние и летние месяцы:");
            var summerAndWinterMonths =
                from month in months
                where Array.IndexOf(months, month) < 2 ||
                      (Array.IndexOf(months, month) > 4 && Array.IndexOf(months, month) < 8) ||
                      Array.IndexOf(months, month) == 11
                select month;
            foreach (var month in summerAndWinterMonths)
            {
                Console.Write($"{month} ");
            }

            Console.Write("\nМесяцы в алфавитном порядке:");
            var sortedMonths =
                from month in months
                orderby month
                select month;
            foreach (var month in sortedMonths)
            {
                Console.Write($"{month} ");
            }

            Console.WriteLine("");
            Console.Write("Месяцы, содержащие |u| и длиной не менее 4-х символов: ");
            var monthsWithUWord =
                from month in months
                where month.Contains('u') && month.Length >= 4
                select month;
            foreach (var month in monthsWithUWord)
            {
                Console.Write($"{month} ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            List<Flat> listApartment = new List<Flat>();
            Flat firstApartment = new Flat(3, 21,"Бобруйская", 321, 3);
            Flat secondApartment = new Flat(4, 21,"Свердлова", 310, 3);
            Flat thirdApartment = new Flat(3, 17,"Маяковского", 204, 2);
            Flat fourthApartment = new Flat(5, 24,"Бобруйская", 201, 2);
            Flat fifthApartment = new Flat(3, 11,"Мояковского", 200, 2);

            listApartment.Add(firstApartment);
            listApartment.Add(secondApartment);
            listApartment.Add(thirdApartment);
            listApartment.Add(fourthApartment);
            listApartment.Add(fifthApartment);
            listApartment.Add(fifthApartment);

            //список квартир, имеющих заданное число комнат;
            var firstSort =
                from apartment in listApartment
                where apartment.roomsCount == 3 
                select apartment;
            Console.WriteLine("Список квартир, имеющих заданное число комнат: ");
            foreach (var room in firstSort) 
            {
                Console.WriteLine(room);
            }
            Console.WriteLine("------------------------------------------------------------");
            //пять первых квартир на заданной улице заданного дома
            var secondSort =
                from home in listApartment
                where home.homeNumber <= 24 && home.homeAddress.Length > 3
                select home;
            Console.WriteLine("Пять первых квартир на заданной улице заданного дома:");
            foreach (var home in secondSort)
            {
                Console.WriteLine(home);
            }
            Console.WriteLine("------------------------------------------------------------");
           //количество квартир на определенной улице
            var thirdSort =
                from numApartment in listApartment
                where numApartment.roomsCount >= 3 && numApartment.homeAddress == "Бобруйская"
                select numApartment;
            Console.WriteLine("Количество квартир на определенной улице:");
            foreach (var numApartment in thirdSort)
            {
                Console.WriteLine(numApartment);
            }
            Console.WriteLine("------------------------------------------------------------");
            //список квартир, имеющих заданное число комнат и
            //расположенных на этаже, который находится в заданном промежутке;

            var fourthSort =
                from apartmentNum in listApartment
                where apartmentNum.Floor == 3 && apartmentNum.roomsCount == 3 && apartmentNum.apartmentNumber >= 200 && apartmentNum.apartmentNumber > 300
                select apartmentNum;
            Console.WriteLine("Cписок квартир, имеющих заданное число комнат и расположенных на этаже, который находится в заданном промежутке: ");
            foreach (var apartmentNum in fourthSort)
            {
                Console.WriteLine(apartmentNum);
            }

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Уникальный запрос");
            //МОЙ ЗАПРОС                                                                                                                               ///          
            var Sort = listApartment.OrderBy(roomsCount => roomsCount.roomsCount).Where(ApartmentNumber => ApartmentNumber.apartmentNumber > 200).Take(2).Skip(0).Sum(ApartmentNumber => ApartmentNumber.apartmentNumber);
            Console.WriteLine(Sort);

            Console.WriteLine("------------------------------------------------------------");

            List<Flat> listApartment1 = new List<Flat>();
            Flat firstApartment1 = new Flat(3, 21, "Бобруйская", 0, 3);
            Flat secondApartment1 = new Flat(4, 21, "Свердлова", 0, 3);
            Flat thirdApartment1 = new Flat(3, 17, "Маяковского", 0, 2);
            Flat fourthApartment1 = new Flat(5, 24, "Бобруйская", 0, 2);
            Flat fifthApartment1 = new Flat(3, 11, "Мояковского", 0, 2);
            listApartment1.Add(firstApartment1);
            listApartment1.Add(secondApartment1);
            listApartment1.Add(thirdApartment1);
            listApartment1.Add(fourthApartment1);
            listApartment1.Add(fifthApartment1);
            listApartment1.Add(fifthApartment1);

            var join = from floor2 in listApartment1
                       join floor1 in listApartment
                       on floor2.Floor equals floor1.Floor

                       select new
                       {
                           roomsCount = floor1.roomsCount,
                           homeAdress = floor1.homeAddress,
                           homeNumber = floor1.homeNumber,
                           apartmentNumber = floor2.apartmentNumber,
                           Floor = floor1.Floor
                       };

            var join1 = join.Distinct();

            foreach (var item in join1)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
