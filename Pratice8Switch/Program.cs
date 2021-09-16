using System;

namespace Pratice8Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("===================Switch================");

            int day;
            Console.WriteLine("Enter any day in number");
            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("The day is Monday");
                    break;

                case 2:
                    Console.WriteLine("The day is Tuesday");
                    break;

                default:
                    Console.WriteLine("Incorrect day");
                    break;




            }

        }
    }
}
