using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Lamborgini";
            myCar.Model = "Zentorno";
            myCar.Year = 2016;
            myCar.color = "Black";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.color);

            decimal value = DeterminMarketValue(myCar);
            Console.WriteLine("{o:C}", value);
            Console.ReadLine();


        }

        private static decimal DeterminMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            return carValue;
        }

    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string color { get; set; }

        public decimal DeterminMarketValue()
        {

            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }

        

    }
}
