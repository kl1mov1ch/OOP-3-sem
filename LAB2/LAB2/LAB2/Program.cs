using System;

namespace LAB2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Home home1 = new Home();
            string c = home1.HomeType;

            Home.showInfo();

            Console.WriteLine($"Состояние: {home1.TypeHome(ref c, out var newHomeType)}");

            Console.WriteLine($"сколько лет: {home1.yearHome}");

            Console.WriteLine($"ToString: {home1}");

            

            Console.WriteLine($"GetHashCode: {home1.GetHashCode()}\n");
        
            var homes = new Home[3];
            homes[0] = new Home(2000, 3, 250);
            homes[1] = new Home(2020, 9, 25);
            homes[2] = new Home(200, 4, 256);

            int i = 0;

            foreach (var home in homes)
            {
                i++;
                Console.WriteLine($"{i}){home}");
            }

            // проверка на возраст

                if (home1.yearHome <= 30)
                Console.WriteLine("\nдом норм ");
                else
                Console.WriteLine("дом старый");
            var home2 = new { TypeH = "сломанный", _age = 22};
            Console.WriteLine("\n---анонимный тип--- ");
            Console.WriteLine($"Тип: {home2.TypeH}, сколько лет в экусплуатации: {home2._age}\n");
        }
    }
}
