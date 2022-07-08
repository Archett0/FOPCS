using System;

namespace ConsoleApp2
{
    public class Program7
    {
        public static void Function1()
        {
            var sales = new int[12];

            Console.WriteLine("Enter the sales for the 12 months.");
            var max = int.MinValue;
            var min = int.MaxValue;
            var maxMonth = -1;
            var minMonth = -1;
            var totalSales = 0;

            for (var i = 0; i < 12; i++)
            {
                var sale = Convert.ToInt32(Console.ReadLine());
                sales[i] = sale;
                if (sale > max)
                {
                    max = sale;
                    maxMonth = i;
                }
                if (sale < min)
                {
                    min = sale;
                    minMonth = i;
                }
                totalSales += sale;
            }

            Console.WriteLine("Maximum Sales Month: {0}", maxMonth + 1);
            Console.WriteLine("Minimum Sales Month: {0}", minMonth + 1);
            Console.WriteLine("Average monthly sales: {0:F3}", totalSales / 12.0);
        }

        public static void Function2()
        {
            var target = new[] { 1, 4, 2, 5, 6, 1, 3, 13, 15515, 0 };
            foreach (var i in target)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();

            SelectionSort(target);
            foreach (var i in target)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();
        }

        private static void SelectionSort(int[] array)
        {
            Console.WriteLine("Sorting in progress:");
            for (var i = 0; i < array.Length - 1; i++)
            {
                var maxIndex = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    (array[i], array[maxIndex]) = (array[maxIndex], array[i]);
                }

                foreach (var element in array)
                {
                    Console.Write(element + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nSorting completed");
        }

        public static void Function3()
        {
            var marks = new[,]
            {
                { 56, 84, 68, 29 }, { 94, 73, 31, 96 },
                { 41, 63, 36, 90 }, { 99, 9, 18, 17 },
                { 62, 3, 65, 75 }, { 40, 96, 53, 23 },
                { 81, 15, 27, 30 }, { 21, 70, 100, 22 },
                { 88, 50, 13, 12 }, { 48, 54, 52, 78 },
                { 64, 71, 67, 25 }, { 16, 93, 46, 72 }
            };

            Console.WriteLine("Total Marks By Student:");
            var res01 = CalculateTotalMarksByStudent(marks);
            foreach (var i in res01)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            Console.WriteLine("Avg Marks By Subject:");
            var res02 = CalculateAvgMarksBySubject(marks);
            foreach (var i in res02)
            {
                Console.Write("{0:F3}\t", i);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Variance By Subject:");
            var res03 = CalculateStandardDeviationBySubject(marks);
            foreach (var i in res03)
            {
                Console.Write("{0:F3}\t", i);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Overall Average:{0:F3}", CalculateOverallAverage(marks));
            Console.WriteLine("");
        }

        private static int[] CalculateTotalMarksByStudent(int[,] marks)
        {
            // Calculate each student's total marks
            var res = new int[marks.GetLength(0)];
            for (var i = 0; i < marks.GetLength(0); i++)
            {
                var sum = 0;
                for (var j = 0; j < marks.GetLength(1); j++)
                {
                    sum += marks[i, j];
                }
                res[i] = sum;
            }

            return res;
        }

        private static double[] CalculateAvgMarksBySubject(int[,] marks)
        {
            var res = new double[marks.GetLength(1)];
            for (var i = 0; i < marks.GetLength(1); i++)
            {
                var sum = 0;
                for (var j = 0; j < marks.GetLength(0); j++)
                {
                    sum += marks[j, i];
                }

                res[i] = sum * 1.0 / marks.GetLength(0);
            }

            return res;
        }

        private static double[] CalculateStandardDeviationBySubject(int[,] marks)
        {
            var amountOfSubjects = marks.GetLength(1);
            var amountOfStudents = marks.GetLength(0);
            var res = new double[amountOfSubjects];

            // Get averages
            var avg = CalculateAvgMarksBySubject(marks);

            // Get variance for each subject
            for (var i = 0; i < amountOfSubjects; i++)
            {
                var sum = 0.0;
                for (var j = 0; j < amountOfStudents; j++)
                {
                    sum += Math.Pow(marks[j, i] - avg[i], 2);
                }
                var variance = sum / amountOfStudents;
                res[i] = Math.Sqrt(variance);
            }

            return res;
        }

        private static double CalculateOverallAverage(int[,] marks)
        {
            var sum = 0;
            foreach (var mark in marks)
            {
                sum += mark;
            }

            return sum * 1.0 / (marks.GetLength(0) * marks.GetLength(1));
        }

        static void Main(string[] args)
        {
            Function3();
        }
    }
}