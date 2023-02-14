using Lab05;
using System;
using static LAB04.Test;

namespace LAB04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test1 = new Test("Тест 1", 20);
            Testing test2 = new Test("Тест 2", 20);
            IGetQuestion test3 = new Test("Тест 3", 20);

            

            if (test1 is Test)
            {
                Console.WriteLine("Test");
            }
            if (test2 is Test)
            {
                Console.WriteLine("Test");
            }
            if (test3 is Test)
            {
                Console.WriteLine("Test");
            }
            if ((test1 as Testing) != null)
            {
                Console.WriteLine("Testing");
            }

            test2.GetQuestionType();
            test3.GetQuestionType();
            test1.AskQestion();
            test1.AskQest();

            Console.WriteLine("_------------------------------------_");

            var test = new Test("Тест", 20);
            var exam = new Exam("Экзамен",15);
            var finalexam = new FinalExam("Выпускной экзамен",10);
            var qestion = new Question("Вопрос");

            var _testing = new Testing[4];
            _testing[0] = test;
            _testing[1] = exam;
            _testing[2] = finalexam;
            _testing[3] = qestion;
            foreach (var item in _testing)
            {
                Console.WriteLine(item);
            }

            TEstingContainer container = new TEstingContainer();

            container.PrintList();
            container.AddItem(test);
        }
    }
}
