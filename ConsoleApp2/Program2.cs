using System;

namespace ConsoleApp2
{
    public class Program2
    {
        public static void Function1()
        {
            var input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(input));
        }

        public static void Function2()
        {
            var input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:F3}", Math.Sqrt(input));
        }
        public static void Function3()
        {
            var input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:C2}", input * 1.13);
        }

        public static void Function4()
        {
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{input * 1.8 + 32}");
        }

        public static void Function5()
        {
            var input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{5 * Math.Pow(input, 2) - 4 * input + 3}");
        }

        public static void Function6()
        {
            Console.WriteLine("Input coordinates of two points one by one in this form: (x, y)");
            var coordinateA = Console.ReadLine();
            var coordinateB = Console.ReadLine();

            var x1 = 0.0;
            var y1 = 0.0;
            var x2 = 0.0;
            var y2 = 0.0;

            if (coordinateA != null)
            {
                coordinateA = coordinateA.Trim();
                var indexOfComma = coordinateA.IndexOf(',');
                var xOfCoordinateA = coordinateA.Substring(1, indexOfComma - 1);
                var yOfCoordinateA = coordinateA.Substring(indexOfComma + 1, coordinateA.Length - indexOfComma - 2);
                x1 = Convert.ToDouble(xOfCoordinateA);
                y1 = Convert.ToDouble(yOfCoordinateA);
            }

            if (coordinateB != null)
            {
                coordinateB = coordinateB.Trim();
                var indexOfComma = coordinateB.IndexOf(',');
                var xOfCoordinateB = coordinateB.Substring(1, indexOfComma - 1);
                var yOfCoordinateB = coordinateB.Substring(indexOfComma + 1, coordinateB.Length - indexOfComma - 2);
                x2 = Convert.ToDouble(xOfCoordinateB);
                y2 = Convert.ToDouble(yOfCoordinateB);
            }

            var res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Distance = " + res);
        }

        public static void Function7()
        {
            var input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{input * 0.4 + 2.4}");
        }

        public static void Function8()
        {
            var input = Convert.ToDouble(Console.ReadLine());
            var rawRes = input * 0.4 + 2.4;
            var res = Math.Round(rawRes, 1);
            Console.WriteLine("{0:0.00}", res);
        }

        public static void Function9()
        {
            var input = Convert.ToDouble(Console.ReadLine());
            var rawRes = (input * 0.4 + 2.4) * 10.0;
            var res = Math.Ceiling(rawRes) / 10.0;
            Console.WriteLine(res);
        }

        public static int Function10()
        {
            var inputA = Convert.ToDouble(Console.ReadLine());
            var inputB = Convert.ToDouble(Console.ReadLine());
            var inputC = Convert.ToDouble(Console.ReadLine());

            if (inputA >= 0 && inputB >= 0 && inputC >= 0
                && inputA + inputB > inputC
                && inputA + inputC > inputB
                && inputB + inputC > inputA)
            {
                var s = (inputA + inputB + inputC) / 2.0;
                var res = Math.Sqrt(s * (s - inputA) * (s - inputB) * (s - inputC));
                Console.WriteLine(res);
                return 1;
            }

            Console.WriteLine("NaN");
            return 0;
        }


        static void Main(string[] args)
        {
            Function6();
        }
    }
}