using System;

namespace Klasser_Vecka_4_Campus
{
    class Car
    {
        public string type;
        public string brand;
        public int amountOfWheels;
        public int year;
        public string hornSound;
        public string color;

        public string Describe()
        {
            string description = "The car is of type " + brand + "and from the year " + year + "Hopp och lek";
            return description;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car MyFirstCar = new Car();
            MyFirstCar.type = "CRX";
            MyFirstCar.color = "Silver";
            MyFirstCar.brand = "Honda";
            MyFirstCar.year = 1996;
            MyFirstCar.hornSound = "toooot toooooot";
            MyFirstCar.amountOfWheels = 4;
            Console.WriteLine(MyFirstCar.type);

            Car MySecondCar = new Car();
            MySecondCar.type = "TL1000R";
            MySecondCar.brand = "Suzuki";
            MySecondCar.year = 2001;

        }
    }  
}
