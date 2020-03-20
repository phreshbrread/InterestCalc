using System;

namespace InterestCalc
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("What would you like to calculate?");
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
            int principal;
            int rate;
            int time;
            int interest;

            Console.WriteLine("What is the original amount/investment? (Rounded to nearest whole)");
            principal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the rate? (Percentage per time period, rounded to nearest whole)");
            Console.Write("%");
            rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many years will the investment be held?");
            time = Convert.ToInt32(Console.ReadLine());

            interest = (principal * rate * time) / 100;

            Console.WriteLine("Interest will be $" + interest);
            Console.Write("Press any key to restart");
            Console.ReadLine();
            Main();
        }

        static void Time()
        {
            int amount;
            int rate;
            int time;
            int interest;

            Console.WriteLine("What is the amount? (Rounded to nearest whole)");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the rate? (Percentage per time period, rounded to nearest whole)");
            Console.Write("%");
            rate = Convert.ToInt32(Console.ReadLine());

            interest = amount * rate / 100;

            Console.WriteLine("Investment is in for " + interest + " years");
            Console.Write("Press any key to restart");
            Console.ReadLine();
            Main();
        }
    }
}