using System;
using System.IO;

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
                string str = "Qwerty";
                set1.Add(i + 1);
                set1.Add(i + 10);
                set2.Add(i + 4);
                set3.Add(i + 15);
                set4.Add(i + str);
            }
            Console.Write("Множество один: ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\nМножество два: ");
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
            Console.Write("\nМножество четыре: ");
            foreach (var item in set4)
            {
                Console.Write(item + " ");
            }

            Set<int>.Developer developer = new Set<int>.Developer();
            Set<int>.Production production = new Set<int>.Production();
            Console.WriteLine();
            Console.WriteLine(developer.ToString());
            Console.WriteLine(production.ToString());
            try
            {
            IUser<int> user1 = new User<int>(1337);
            Console.WriteLine(user1.GetUserID());

            IUser<string> user2 = new User<string>("Hi");
            Console.WriteLine(user2.GetUserID());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Bomj");
            }
            try
            {
                string line = set1.ToString();
                
                StreamReader sr = new StreamReader(@"C:\\Sample.txt");
                
                line = sr.ReadLine();
                
                while (line != null)
                {
                   
                    Console.WriteLine(line);
                   
                    line = sr.ReadLine();
                }
               
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

       
        interface IUser<T>
        {
            T GetUserID();
        }

        class User<T> : IUser<T>
        {
            protected T UserID;

            public User(T userID) => UserID = userID;

            public virtual T GetUserID()
            {
                return UserID;
            }
        }

        interface IMessage
        {
            string Text { get; }
        }
        interface IPrintable
        {
            void Print();
        }
        class Message : IMessage, IPrintable
        {
            public string Text { get; }
            public Message(string text) => Text = text;

            public void Print() => Console.WriteLine(Text);
        }

        class Messenger<T> where T : IMessage, IPrintable
        {
            public void Send(T message)
            {
                Console.WriteLine("Отправка сообщения:");
                message.Print();
            }
        }
    }

}
