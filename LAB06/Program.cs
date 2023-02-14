using Lab05;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static LAB04.Test;


namespace LAB04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите имя тестируемого.");
                
                string c = Console.ReadLine();
                if ( c.Length < 2 || c == null)
                {
                    throw new Exception("Введите корректное имя!");
                }
                else
                {
                    Console.WriteLine($"Ваше имя {c}");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Test test1 = new Test("Тест 1",  20, "Anton");
                Testing test2 = new Test("Тест 2", 100, "Filya");
                IGetQuestion test3 = new Test("Тест 3", 10, "OrGraph");
                Console.WriteLine(test1);
                Console.WriteLine(test2);
                Console.WriteLine(test3);

            }
            catch (TestException e)
            {
                Console.WriteLine(e.ErrorInClass);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("!Вот так вот!");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("-------------------------------------------------");
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                var test = new Test("Test", 10, "Amogus");
                var exam = new Exam("Экзамен", 15);
                var finalexam = new FinalExam("Выпускной экзамен", 10);
                var _testing = new Testing[4];
                _testing[0] = test;
                Debug.Assert(test != null, "test param is null");
                _testing[1] = exam;
                _testing[2] = finalexam;
                foreach (var item in _testing)
                {
                    Console.WriteLine(item);
                }
            }
            catch(QuetionException e)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(e.numberQuestion);
                Console.WriteLine(e.Message);
                Console.WriteLine("Неверные данные");

            }
            catch (ExamExcaption e)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(e.Exam);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
