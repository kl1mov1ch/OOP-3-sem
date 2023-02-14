using System;

namespace LAB2
{
    public partial class Home
    {
        private int ApartNumber;
        private int Square;
        private int yearOfOperationStart;
        public string HomeType;

        public readonly int HomeId;

        private const string Street = "Bobruiskaya";

        private static int count;

        public Home()
        {
            HomeType = "Broken";
            ApartNumber = 3;
            Square = 300;
            HomeId = 0;
            yearOfOperationStart = 1980;
            count++;
        }

        public Home(int yearOfOperationStart, int ApartNumber, int Square, string HomeType = "сломался")
        {
            this.yearOfOperationStart = yearOfOperationStart;
            this.ApartNumber = ApartNumber;
            this.Square = Square;
            this.HomeType = HomeType;
        }
        
        static Home()
        {
            count = 0;
        }

        public int Sqare
        {
            get
            {
                return Sqare;
            }
            set
            {
                Sqare = value;
            }
        }
        public int ApartNum
        {
            get 
            { 
                return ApartNumber;
            }
            private set
            {
                   ApartNumber = value; 
            }
        }
        public int HomeID
        {
            get
            {
                return HomeId;
            }
            set
            {
                HomeID = value;
            }
        }
        public int yearHome
        {
            get
            {
                return 1980;
            }
            set { yearOfOperationStart = value; }
        }
        }
    }


