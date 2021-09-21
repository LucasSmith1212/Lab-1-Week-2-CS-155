using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your coupon count: ");
            int userInput = Int32.Parse(Console.ReadLine());

            double candybars = userInput / 10;
            candybars = Math.Round(candybars, 0);
            userInput = userInput % 10;

            double gumballs = userInput / 3;
            gumballs = Math.Round(gumballs, 0);
            int remainder = userInput % 3;

            Console.WriteLine("Candy Bars: " + candybars);
            Console.WriteLine("Gumballs: " + gumballs);
            Console.WriteLine("Remaining Coupons: " + remainder);
        }
    }
}
