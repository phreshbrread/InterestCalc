using System;

namespace InterestCalc
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Are you looking to find out interest or time?");
            Console.WriteLine("1. Interest");
            Console.WriteLine("2. Time");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (number == 1)
            {
                Interest();
            }
            else if (number == 2)
            {
                Time();
            }
            else
            {
                Console.WriteLine("Please input a valid number");
                Console.ReadLine();
                Main();
            }
        }

        static void Interest()
        {
            
        }

        static void Time()
        {

        }
    }
}
