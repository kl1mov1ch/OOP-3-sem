using LAB04;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab05
{ 
    public class TEstingContainer
    {
        private readonly int _budget;

        public List<Test> TestingList { get; private set; }
        public int NumberOfTest { get; private set; }
        public int Question { get; private set; }

        public TEstingContainer()
        {
            _budget = 40;
            NumberOfTest = 3;
            Question = 15;
            TestingList = new List<Test>();
        }
        public TEstingContainer(int budget, int Question)
        {
            _budget = budget;
            this.Question = Question;
            NumberOfTest = 0;
            TestingList = new List<Test>();
        }
        public TEstingContainer(int budget, List<Test> list)
        {
            _budget = budget;
            Question = _budget - list.Sum(item => item.Count);
            NumberOfTest = list.Count;
            TestingList = list;
            SortInventoryList();
        }

        public void AddItem(Test item)
        {
            TestingList.Add(item);
            Question -= item.Count;
            NumberOfTest++;
            SortInventoryList();
        }

        public void DeleteItem(Test item)
        {
            if (!TestingList.Contains(item))
                throw new ArgumentException();

            TestingList.Remove(item);

            Question += item.Count;
            NumberOfTest--;
            SortInventoryList();
        }

        public void PrintList()
        {
            Console.WriteLine(
               $"----------------------\nСессия:\n" +
               $"Количество тестов: {NumberOfTest}\n" +
               $"Кол вопросов: {_budget}\n" +
               $"Текущий вопрос: {Question}\n");

            foreach (var item in TestingList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("----------------------");
        }
        private void SortInventoryList()
        {
            TestingList = TestingList.OrderBy(x => x.Count).ToList();
        }

    }
}