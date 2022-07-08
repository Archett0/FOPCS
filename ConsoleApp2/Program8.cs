using System;

namespace ConsoleApp2
{
    public class Program8
    {
        public static int ReadInteger(string message)
        {
            while (true)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                if (int.TryParse(input, out var res))
                {
                    return res;
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }
        }

        public static string Substitute(string s, char c1, char c2)
        {
            return s.Replace(c1, c2);
        }

        public static void SetArray(int[] arr, int value)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }

        public static int[] ResizeArray(int[] arr, int newSize)
        {
            if (newSize < arr.Length)
            {
                Console.WriteLine("ERROR");
                return arr;
            }

            var res = new int[newSize];
            for (var i = 0; i < arr.Length; i++)
            {
                res[i] = arr[i];
            }

            return res;
        }

        public static bool IsPrime(int input)
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

        public static int[,] MatrixMultiply(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                Console.WriteLine("ERROR");
                return null;
            }

            var newX = a.GetLength(0);
            var newY = b.GetLength(1);
            var newZ = a.GetLength(1);
            var res = new int[newX, newY];

            for (var i = 0; i < newX; i++)
            {
                for (var j = 0; j < newY; j++)
                {
                    for (var k = 0; k < newZ; k++)
                    {
                        res[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return res;
        }

        public delegate double DoubleOps(double x);

        public static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            var res = new double[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                res[i] = ops(arr[i]);
            }

            return res;
        }

        private static double GetSquare(double x)
        {
            return Math.Pow(x, 2);
        }

        static void Main(string[] args)
        {
            // Question1
            // Console.WriteLine("Your input is: " + ReadInteger("Input an integer: "));
            
            // Question3
            // Console.WriteLine(Substitute("Hello",'l','?'));
            
            // Question6
            // for (var i = 5; i < 1001; i++)
            // {
            //     if (IsPrime(i)) Console.WriteLine(i);
            // }

            // Question7
            // var a = new int[,] { { 3, 4 }, { 2, 5 }, { 1, 6 } };
            // var b = new int[,] { { 1, 3 }, { 2, 4 } };
            // var c = MatrixMultiply(a, b);
            // for (int i = 0; i < c.GetLength(0); i++)
            // {
            //     for (int j = 0; j < c.GetLength(1); j++)
            //     {
            //         Console.Write(c[i, j] + "\t");
            //     }
            //
            //     Console.WriteLine();
            // }

            // Question8
            var original = new double[] { 4, 8, 2 };
            var res = ProcessArray(original, Math.Sqrt);
            var res2 = ProcessArray(original, GetSquare);
            foreach (var re in res)
            {
                Console.WriteLine(re + "\t");
            }
            
            Console.WriteLine();
            foreach (var re2 in res2)
            {
                Console.WriteLine(re2 + "\t");
            }
        }
    }
}