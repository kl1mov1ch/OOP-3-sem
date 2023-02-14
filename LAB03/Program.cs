using System;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<int> set1 = new Set<int>(),
            set2 = new Set<int>(),
            set3 = new Set<int>();
            Set<string> set4 = new Set<string>();

            for (int i = 0; i < 10; i++)
            {
                string str = i + "Q,";
                set1.Add(i);
                set2.Add(i + 7);
                set3.Add(i - 7);
                set4.Add(str);
            }
            Console.Write("Первое множество: ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ") ;
            }
            Console.Write("\nвторое множество: ");
            foreach (var item in set2)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\nМножество три: ");
            foreach (var item in set3)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\nМножество четыре: ");
            foreach (var item in set4)
            {
                Console.Write($"{item} ");
            }

            var remove = set1 - 1;
            var intersection = set1 * set2;
            var comparison = set1 < set2;
            var subset = set1 > set2;

            Console.Write("\nУдаление элемента 1 из первого множества: ");
            foreach (var item in remove)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nПересечение множеств 1 и 2: ");
            foreach (var item in intersection)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nСравнение множеств 1 и 2: ");
            Console.Write(comparison);
            Console.Write("\nПроверка подмножеств 1 и 2 ");
            Console.Write(subset);


            Console.Write("\nМножество четыре: ");
            foreach (var item in set4)
            {
                Console.Write(item + " ");
            }
            Set<int>.StaticOperation.DeleteNullElements(ref set4);
            Console.Write("\nМножество четыре без нулевых элементов: ");
            foreach (var item in set4)
            {
                Console.Write(item + " ");
            }
            Set<int>.StaticOperation.Point(ref set4);
            Console.Write("\nМножество четыре с точками: ");
            foreach (var item in set4)
            {
                Console.Write(item + " ");
            }

            Set<int>.Developer developer = new Set<int>.Developer();
            Set<int>.Production production = new Set<int>.Production();
            Console.WriteLine();
            Console.WriteLine(developer.ToString());
            Console.WriteLine(production.ToString());

        }
    }
}