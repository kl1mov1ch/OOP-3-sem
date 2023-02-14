using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LAB09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------------------------------");
            SoftwareCollection collection = new SoftwareCollection
            {
                new Software("Матлаб"),
                new Software("Вижла"),
                new Software("Вижла для фронта"),
                new Software("Мультисим"),
                new Software("Фиксик")
            };
            collection.Show();
            Console.WriteLine("--------------------------------------------------"); 

            collection.RemoveAt(3);
            collection.Show();
            Console.WriteLine("--------------------------------------------------");
            collection.Insert(2, new Software("Фигня"));
            collection.Show();
  
            Console.WriteLine("--------------------------------------------------");
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(5, "H");
            sortedList.Add(4, "C");
            sortedList.Add(2, "D");
            sortedList.Add(3, "E");
            
            ICollection<int> keys = sortedList.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(sortedList[item]);
            }

            Console.WriteLine("--------------------------------------------------");
            ObservableCollection<Software> software= new ObservableCollection<Software>()
            {
                new Software("B"),
                new Software("A"),
                new Software("L"),
                new Software("K")
            };

            foreach (var i in software)
                Console.WriteLine(i.ToString());
            Console.WriteLine("--------------------------------------------------");

            software.Add(new Software("Boba"));
            software[0] = new Software("Biba");
            software.RemoveAt(1);

            foreach (var i in software)
                Console.WriteLine(i.ToString());
        }
    }
        
}

