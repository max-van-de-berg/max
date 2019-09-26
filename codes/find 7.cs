using System;

namespace foritteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; 1 < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("found seven!");
                    break;
                }
            }
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();
        }
    }
}
