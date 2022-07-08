using System;

namespace ConsoleApp2
{
    public class Program5
    {
        public static void Function1A()
        {
            Console.Write("Input a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var res = 1;
            for (var i = 2; i <= number; i++)
            {
                res *= i;
            }

            Console.WriteLine("Factorial is " + res);
        }

        public static void Function1B()
        {
            Console.Write("Input a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var res = 1;
            for (var i = number; i >= 2; i--)
            {
                res *= i;
            }

            Console.WriteLine("Factorial is " + res);
        }

        public static void Function2()
        {
            Console.WriteLine("NO \t INVERSE \t SQUARE ROOT \t SQUARE");
            Console.WriteLine("----------------------------------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                var no = i;
                var inverse = 1.0 / i;
                var squareRoot = Math.Sqrt(i);
                var square = Math.Pow(i, 2);
                Console.WriteLine("{0:F1} \t {1:F3} \t\t {2:F3} \t\t {3:F1}", no, inverse, squareRoot, square);
            }
        }

        public static void Function3()
        {
            Console.Write("Please input a integer: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var res = IsPrimeNumber(input);
            Console.WriteLine(res ? "Prime" : "Not Prime");
        }

        private static bool IsPrimeNumber(int input)
        {
            // First we check if input is 2 or 3
            if (input <= 3)
            {
                return input >= 2;
            }

            for (var i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Function4()
        {
            Console.Write("Please input a integer: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var res = IsPerfectNumber(input);
            Console.WriteLine(res ? "Perfect Number" : "Not Perfect Number");
        }

        private static bool IsPerfectNumber(int input)
        {
            if (input < 2) return false;
            var sumOfAllDividers = 0;
            for (var i = 1; i < input; i++)
            {
                if (input % i == 0) sumOfAllDividers += i;
            }

            return sumOfAllDividers == input;
        }

        public static void Function5()
        {
            for (var i = 5; i < 10001; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Function6()
        {
            for (var i = 1; i < 1001; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            Function6();
        }
    }
}