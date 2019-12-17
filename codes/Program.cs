using System;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displaymenu = true;
            while (displaymenu)
            {
               displaymenu = mainmenu();
            }
            
        }

        private static bool mainmenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("choose an option");
            Console.WriteLine("1) Print numbers");
            Console.WriteLine("2) Guessing game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void PrintNumbers()
        {
           Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int result = int.Parse(Console.ReadLine());
            int Counter = 1;
            while (Counter < result + 1)
            {
                Console.Write(Counter);
                Console.Write("-");
                Counter++;
            }

            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("GuessingGame!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0; 
            bool incorrect = true;

            do
            {
                Console.WriteLine("guess a number between 1 and 10");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("wrong!");

            } while (incorrect);
            Console.WriteLine("correct it took you {0} guesses", guesses);

            Console.ReadLine();
        }
    }
}
