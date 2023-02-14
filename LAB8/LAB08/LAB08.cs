using System;

namespace LAB08
{
    internal class LAB08
    {

        public delegate void BossDelegat(int turn);
        static void Main()
        {
            Boss conditionFirst = new Boss(1,0);
            Boss conditionSecond = new Boss(0,1);
            Boss conditionThird = new Boss(0, 0);
            
            Console.WriteLine($"{conditionFirst.turn_off}, {conditionFirst.upgrade}");
            conditionFirst.Condition();
            Console.WriteLine("======================");
            Console.WriteLine($"{conditionSecond.turn_off}, {conditionSecond.upgrade}");
            conditionSecond.Condition();
            Console.WriteLine("======================");
            Console.WriteLine($"{conditionThird.turn_off}, {conditionThird.upgrade}");
            conditionThird.Condition();

            Console.WriteLine("-------------------------------------------------");

            EditString.str = "П!ор[а]    с[п!ат,ь..?";
            Action strEdit = () => EditString.Remove();
            strEdit += () => EditString.RemoveSpaces();
            strEdit += () => EditString.ToLowerCase();
            strEdit += () => EditString.ToUpperCase();
            strEdit += () => EditString.Add();
            strEdit?.Invoke();
        }
    }
}
