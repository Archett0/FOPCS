using System;

namespace ConsoleApp1
{
    public class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.Write("Number of items to purchase: ");
            var amount = Convert.ToInt32(Console.ReadLine());
            var originalPrice = amount * 500;
            var finalPrice = originalPrice * 1.0;
            if (originalPrice > 2000 && originalPrice <= 3000)
            {
                finalPrice = 0.97 * originalPrice;
            }
            else if (originalPrice > 3000 && originalPrice <= 6000)
            {
                finalPrice = 0.95 * originalPrice;
            }
            else if (originalPrice > 6000)
            {
                finalPrice = 0.92 * originalPrice;
            }

            Console.WriteLine("Please pay {0:C2}", finalPrice);
        }
    }
}