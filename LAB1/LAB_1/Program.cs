using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool BoolFalse = false;
            bool BoolTrue = true;
            byte ByteOne = 0;
            byte ByteTwo = 255;
            sbyte SByteOne = -128;
            sbyte SbyteTwo = 127;
            char CharOne = 'a';
            decimal DecimalOne = 223134;
            double DoubleOne = 12.12312;
            float FloatOne = 12;
            int IneOne = 4214;
            uint UintOne = 1124;
            long LOngOne = 3456;
            ulong UlongOne = 57689;
            short ShrotOne = 1233;
            ushort UshortOne = 6262;


            //явное преобразование 

            byte a1 = 123;

            short a2 = (short)a1;
            Console.WriteLine(a2);

            int a3 = (int)a1;
            Console.WriteLine(a3);

            uint a4 = (uint)a1;
            Console.WriteLine(a1);

            ulong a5 = (ulong)a1;
            Console.WriteLine(a5);

            decimal a6 = (decimal)a1;
            Console.WriteLine(a6);

            //неявное преобразование

            decimal b1 = 2145325;

            //byte b2 = (byte) b1;
            //Console.WriteLine(b2);

            int b3 = (int)b1;
            Console.WriteLine(b3);

            //char b4 = (char) b1;
            //Console.WriteLine(b4);

            //short b5 = (short) b1;
            //Console.WriteLine(b5);

            //Продемонстрируйте работу с неявно типизированной переменной.

            var VarOne = "hi";
            //var VarOne = 1324547;
            var VarInt = 12347;
            Console.WriteLine(VarOne);

            //конвертация

            Console.WriteLine("Циферку: ");
            string Str_Int = Console.ReadLine();
            int second = int.Parse(Str_Int);
            //int second = Convert.ToInt32(str);
            Console.WriteLine(second);

            string string1 = "Hello World";
            string string2 = "Hello World";
            Console.WriteLine(String.Equals(string1, string2));//сравнение строк на идэнтичность2
            string string3 = "Hello World!";
            string string4 = "Hello World";
            Console.WriteLine(String.Equals(string3, string4));

            //сторки

            Console.WriteLine("Символ и тд: ");
            string str_first = Console.ReadLine();
            Console.WriteLine(str_first);

            //Объединение строк
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "!!!";
            string str4 = str1 + " " + str2 + str3;
            Console.WriteLine(str4);
            string str5 = string.Concat(str1, " ", str2, str3);
            Console.WriteLine(str5);

            //копирование строк
            string strcopy1 = "Hi";
            string strcopy2 = String.Copy(string1);
            Console.WriteLine(strcopy2);

            //выделение подстроки 
            string strsub1 = "Hi world";
            string strsub2 = strsub1.Substring(3, 5);
            Console.WriteLine(strsub2);

            //разделение строки на слова
            string text = "Привет Андрей !!!";
            string[] words = text.Split(new char[] { ' ' });
            foreach (string str11 in words)
            {
                Console.WriteLine(str11);
            }

            //удаление заданной подстроки
            string StrRemove = "Хороший день";
            int endstr = StrRemove.Length - 5;
            StrRemove = StrRemove.Remove(endstr);
            Console.WriteLine(StrRemove);
            StrRemove = StrRemove.Remove(0, 3);
            Console.WriteLine(StrRemove);

            //интерполяция строк

            var data = DateTime.Now;
            Console.WriteLine($"Сегодня {data.DayOfWeek}");

            //Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty

            string strnull = null;
            Console.WriteLine(String.IsNullOrEmpty(strnull));

            //Создайте строку на основе StringBuilder

            StringBuilder strBuilder = new StringBuilder("Привет покa hi.by");
            strBuilder = strBuilder.Replace("World", "Мир");
            Console.WriteLine(strBuilder);
            strBuilder.Remove(0, 3);
            Console.WriteLine(strBuilder);

            //массивы
            int n = 3;
            int m = 3;
            int[,] mass = new int[n, m];

            Random random = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = random.Next(1, 200);
                    Console.Write("{0}\t", mass[i, j]);
                }
                Console.WriteLine();
            }

            //строковый массив

            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }
            Console.WriteLine($"длинна строкового массива: {weekDays.Length}");

            // замена строк местами string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            string firstStrNumber = Console.ReadLine();
            int firstnum = int.Parse(firstStrNumber);

            string secondStr = Console.ReadLine();

            weekDays[firstnum] = secondStr;

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }

            //ступенчатый массив

            double[][] steparray = new double[3][];
            steparray[0] = new double[2];
            steparray[1] = new double[3];
            steparray[2] = new double[4];

            for (int i = 0; i < steparray.Length; i++)
            {
                for (int j = 0; j < steparray[i].Length; j++)
                {
                    Console.WriteLine($"[{i}][{j}]");
                    string xui = Console.ReadLine();
                    double xuy = double.Parse(xui);
                    steparray[i][j] = xuy;
                }
            }

            for (int i = 0; i < steparray.Length; i++)
            {
                for (int j = 0; j < steparray[i].Length; j++)
                {
                    Console.Write(steparray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            //Создайте неявно типизированные переменные для хранения массива и строки.

            var arrayy = new object[0];
            var arraystrone = "";

            //кортежи
            int qqq = 123;
            char ccc = 'c';
            string sss = "Hi";
            string ssss = "World";
            ulong lll = 214374554;
            var kort = (qqq, ccc, sss, ssss, lll);
            var kort1 = (qqq, ccc, sss, ssss, lll);
            Console.WriteLine(kort);
            Console.WriteLine(kort.Item1);
            Console.WriteLine(kort.Item3);
            Console.WriteLine(kort.Item4);

            int int_cor = (int)kort.Item5;

            Console.WriteLine(int_cor);

            if (kort1 == kort)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            {
                void func1()
                {
                    checked
                    {
                        int maxi1 = int.MaxValue;
                        maxi1++;
                        Console.WriteLine(maxi1);
                    }
                }
                void func2()
                {
                    unchecked
                    {
                        int maxi2 = int.MaxValue;
                        maxi2++;
                        Console.WriteLine(maxi2);
                    }
                }
                Console.WriteLine("-----------------------");
                try
                {
                    func1();
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                func2();
            }

        }
    }
}
