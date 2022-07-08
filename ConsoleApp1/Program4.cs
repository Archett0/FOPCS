using System;

namespace ConsoleApp1
{
    public class Program4
    {
        private static void Main()
        {
            var theArray = new[,]
            {
                {5,3},{2,9},{2,9},
                {5,1},{7,1},{8,3},
                {0,3},{2,2},{9,7}
            };

            var count = 0;

            Console.Write("Please enter a number (0-9): ");
            var input = Convert.ToInt32(Console.ReadLine());

            //Your code here
            for (var i = 0; i < theArray.GetLength(0); i++)
            {
                for (var j = 0; j < theArray.GetLength(1); j++)
                {
                    if (theArray[i, j] == input) count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There is no {0} in the array.", input);
            }
            else
            {
                Console.WriteLine("The number of {0} is {1}", input, count);
            }
        }
    }
}