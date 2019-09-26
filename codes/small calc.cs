using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 0; int num2 = 0;

           
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            
            Console.WriteLine("Type the first number to calculate with, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Type another number to calculate with, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\tx - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.Write("Your option? ");

          
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "x":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
           
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
