using System;

namespace dates_and_times
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
           // Console.WriteLine(myValue.ToString());
           // Console.WriteLine(myValue.ToShortDateString());
           // Console.WriteLine(myValue.ToShortTimeString());
           // Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

           // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
           Console.WriteLine(myValue.AddMinutes(93).ToLongTimeString());

           //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(2003, 7, 8);
            //Console.WriteLine(myBirthday.ToShortDateString());

           //DateTime myBirthday = DateTime.Parse("7/8/2003");
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
          //Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
            
        }
    }
}
