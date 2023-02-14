using System;
using System.Text.RegularExpressions;

namespace LAB08
{
    internal class EditString
    {
        public static string str { get; set; }
        
        public static void Remove()
        {
            str = Regex.Replace(str, @"[,.:;!?-|/]", "");
            Console.WriteLine(str);
        }

        public static void ToUpperCase()
        {
            str = str.ToUpper();
            Console.WriteLine(str);
        }

        public static void ToLowerCase()
        {
            str = str.ToLower();
            Console.WriteLine(str);
        }
        public static void RemoveSpaces()
        {
            str = Regex.Replace(str, @"(\s)+", " ");
            Console.WriteLine(str);
        }

        public static void Add()
        {
            str = str.Insert(str.Length, "?");
            Console.WriteLine(str);
        }
    }
}
