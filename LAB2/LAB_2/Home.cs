using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public partial class Home
    {
        private int ApartNumber;
        private int Square;
        public int NumberOfRooms;
        public string TypeOfBuilding { get; set; }
        public int YearOfOperationStart { get; set; }

        /*поле - только для чтения(например, для каждого экземпляра сделайте
        поле только для чтения ID - равно некоторому уникальному номеру
        (хэшу) вычисляемому автоматически на основе инициализаторов объекта);*/

        private readonly int HomeId;

        //поле - константа;
        private const string Street = "Bobruiskaya";

        /*создайте в классе статическое поле, хранящее количество созданных
        объектов(инкрементируется в конструкторе)*/
        private static int count;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //КОНСТРУКТОРЫ
        /*Не менее трех конструкторов (с параметрами и без, а также с 
        параметрами по умолчанию )*/

        public Home()
        {
            ApartNumber = 3;
            Square = 300;
            NumberOfRooms = 3;
            HomeId = GetHashCode();
            YearOfOperationStart = 1980;
            count++;
        }

        public Home(int apartNumber, int square, int numberOfRooms, string typeOfBuilding, int yearOfOpetationStart, int homeId)
        {
            if (apartNumber < 0 && yearOfOpetationStart >= 1980)
            {
                this.ApartNumber = apartNumber;
                this.Square = square;
                this.NumberOfRooms = numberOfRooms;
                this.TypeOfBuilding = typeOfBuilding;
                this.YearOfOperationStart = YearOfOperationStart;
                this.HomeId = homeId;
                count++;
            }
            else throw new ArgumentException();
        }

        static Home()
        {
            count = 0;
        }
        //определите закрытый конструктор; предложите варианты его вызова;
        //private Home() { }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        //СВОЙСТВА
        //свойства (get, set) – для всех поле класса (поля класса должны быть закрытыми)

        public int ApartNum
        {
            get { return this.ApartNumber; }
            private set 
            {
                if (ApartNum > 0)
                {
                    this.ApartNumber = value;
                }
                else
                    this.ApartNum = 1;
            }
        }
        public int SquareNum
        {
            get { return this.SquareNum; }

            set
            {
                if (this.Square >= 1980)
                    this.Square = value;
                else
                    this.Square = 1980;
            }
        }

    }

}
