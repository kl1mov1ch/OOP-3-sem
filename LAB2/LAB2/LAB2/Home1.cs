using System;

namespace LAB2
{
    public partial class Home
    {
        public void HomeAge(out int yearHome)
        {
            int Year = 2022;
            yearHome = Year - yearOfOperationStart;
        }


        public void SquareNum()
        {
            Square++;
        }

        public string TypeHome(ref string HomeType, out string newHomeType)
        {
            newHomeType = HomeType;
            return newHomeType;
        }

        //Создайте статический метод вывода информации о классе.
        
        public static void showInfo()
        {
            Console.WriteLine($"\n--Поля класса--\n" +
                $"HomeId\n" +
                $"HomeTypen\n" +
                $"ApartNumbern\n" +
                $"Square\n" +
                $"yearOfOperationStart\n" +
                $"--Методы класса--\n" +
                $"showInfo\n" +
                $"SqareNum\n" +
                $"TypeHome\n");
        }
        public override bool Equals(object obj)
        {
            Home home = obj as Home;
            return home.ApartNum == ApartNum;
        }

        public override int GetHashCode()
        {
            return (int)(32871490/ 5367);
        }

        public override string ToString()
        {
            return $"{this.Square}, " +
                   $"{this.ApartNum}, " +
                   $"{this.HomeType}, " +
                   $"{this.yearOfOperationStart}, " +
                   $"{Home.Street};" ;
        }
    }

}
