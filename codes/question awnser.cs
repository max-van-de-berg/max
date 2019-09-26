using System;

namespace idk_prob_some_thing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;
            int y;

            x = 7;
            y = x + 3;
           
            

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("what is your name");
            Console.Write("type your first name: ");
            string MyFirstName;
            MyFirstName = Console.ReadLine();

            string MyLastName;
            Console.Write("Type your last name: ");
            MyLastName = Console.ReadLine();

            Console.WriteLine("hello " + MyFirstName + " " + MyLastName);

            Console.WriteLine("how are you" +
                " awnser with im good or im sad");

            string userValue = Console.ReadLine();
            
            string message = "";

            

            if (userValue == "im good")
            message = "Great! have a nice day";

            
           if (userValue == "im sad")
            message = "well thats bad have a good day annyway";

            Console.WriteLine(message);
        }
    }
}
