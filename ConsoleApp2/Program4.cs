using System;

namespace ConsoleApp2
{
    public class Program4
    {
        public static void Function1()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input != 88) continue;
                Console.WriteLine("Lucky you…");
                break;
            }
        }

        public static void Function2()
        {
            Console.WriteLine("Enter 2 numbers: ");
            var input01 = Convert.ToInt32(Console.ReadLine());
            var input02 = Convert.ToInt32(Console.ReadLine());
            var originInput01 = input01;
            var originInput02 = input02;

            while (input01 != input02)
            {
                if (input01 < input02)
                {
                    // swap numbers so we
                    // make sure input01 > input02
                    (input01, input02) = (input02, input01);
                }

                input01 -= input02;
            }

            var hcf = input01;
            var lcm = originInput01 * originInput02 / hcf;

            Console.WriteLine("A: {0}, B: {1}, HCF: {2}, LCM: {3}", originInput01, originInput02, hcf, lcm);
        }

        public static void Function3A()
        {
            Random random = new Random();
            var answer = random.Next(0, 9);
            var guessCount = 0;

            while (true)
            {
                Console.Write("Guess the number: ");
                var guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;
                if (guess != answer)
                {
                    continue;
                }
                break;
            }

            Console.WriteLine("Congrats! You took {0} guesses to find the answer.", guessCount);
        }

        public static void Function3B()
        {
            Random random = new Random();
            var answer = random.Next(0, 9);
            var guessCount = 0;

            while (true)
            {
                Console.Write("Guess the number: ");
                var guess = Convert.ToInt32(Console.ReadLine());
                guessCount ++;
                if (guess != answer)
                {
                    Console.WriteLine("Try again");
                    continue;
                }

                if (guessCount <= 2)
                {
                    Console.WriteLine("You are a Wizard!");
                }
                else if (guessCount <= 5)
                {
                    Console.WriteLine("You are a good guess.");
                }
                else
                {
                    Console.WriteLine("You are lousy!");
                }
                break;
            }

            Console.WriteLine("Congrats! You took {0} guesses to find the answer.", guessCount);
        }

        static void Main(string[] args)
        {
            Function2();
        }
    }
}