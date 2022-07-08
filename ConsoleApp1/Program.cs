using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Please enter the length in cm:");
            var length = Convert.ToDouble(Console.ReadLine());
            var resInInch = length / 2.54;
            Console.WriteLine("{0:0.000}", resInInch);
        }
    }
}
