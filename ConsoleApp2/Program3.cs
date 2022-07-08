using System;

namespace ConsoleApp2
{
    public class Program3
    {
        public static void Function1()
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            var gender = Console.ReadLine();

            var title = "";
            if (gender != null)
                switch (gender.ToUpper())
                {
                    case "F":
                        title = "Ms.";
                        break;
                    case "M":
                        title = "Mr.";
                        break;
                    default:
                        title = "ERROR";
                        break;
                }
            Console.WriteLine("Good Morning {0} {1}", title, name);
        }

        public static void Function2()
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            var gender = Console.ReadLine();
            Console.Write("Please enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            var title = "";
            switch (gender)
            {
                case "F":
                    title = age >= 40 ? "Aunty" : "Ms.";
                    break;
                case "M":
                    title = age >= 40 ? "Uncle" : "Mr.";
                    break;
                default:
                    title = "ERROR";
                    break;
            }

            Console.WriteLine("Good Morning {0} {1}", title, name);

        }

        public static string Function3()
        {
            Console.Write("Enter your mark(0-100): ");
            var mark = Convert.ToInt32(Console.ReadLine());

            var res = "";
            if (mark < 0 || mark > 100)
            {
                Console.WriteLine("You have an input error!");
                return "ERROR";
            }
            if (mark < 40)
            {
                res = "F";
            }
            else if (mark < 60)
            {
                res = "C";
            }
            else if (mark < 80)
            {
                res = "B";
            }
            else
            {
                res = "A";
            }

            Console.WriteLine("You scored {0} marks which is {1} grade", mark, res);
            return res;
        }

        public static double Function4()
        {
            Console.Write("Enter the kilometers traveled: ");
            var distance = Convert.ToDouble(Console.ReadLine()) * 10.0;
            var cost = 0.00;

            var fixedDistance = Math.Ceiling(distance);
            if (fixedDistance <= 5)
            {
                cost = 2.4;
            }
            else if (fixedDistance <= 90)
            {
                cost = 2.4;
                cost += (fixedDistance - 5) * 0.04;
            }
            else
            {
                cost = 2.4;
                cost += 85 * 0.04;
                cost += (fixedDistance - 90) * 0.05;
            }
            Console.WriteLine("Cost: {0}", cost);
            return cost;
        }

        public static bool Function5()
        {
            Console.Write("Please enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var left = input;
            if (input < 100 | input > 999)
            {
                Console.WriteLine("ERROR");
                return false;
            }

            var hundreds = input / 100;
            input %= 100;
            var tens = input / 10;
            input %= 10;
            var ones = input;

            var right = Math.Pow(hundreds, 3) + Math.Pow(tens, 3) + Math.Pow(ones, 3);
            if (Math.Abs(left * 1.0 - right) < 1e-6)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        static void Main(string[] args)
        {
            Function5();
        }
    }
}