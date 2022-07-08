using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Function1()
        {
            Console.WriteLine("John Smith");
            Console.WriteLine("e0011223@u.nus.edu");
        }

        private static void Function2()
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Good morning " + name);
        }

        private static void Function3()
        {
            Console.WriteLine("Please enter a number");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("original number :" + number + " square of that number :" + number * number);
        }

        private static void Function4()
        {
            Console.WriteLine("Please enter a number");
            var number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("original number :" + number + " square of that number :" + number * number);
        }

        private static void Function5()
        {
            Console.WriteLine("Please enter a number");
            var number = Convert.ToDouble(Console.ReadLine()).ToString("0.00");
            Console.WriteLine(number);

            // The below method DOES NOT work
            // var number = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(Math.Round(number,2));
        }

        static void Main(string[] args)
        {
            Function1();
            Function2();
            Function3();
            Function4();
            Function5();
        }
    }

}