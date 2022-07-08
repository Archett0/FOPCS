using System;
using System.Linq;

namespace ConsoleApp2
{
    public class Program6
    {
        public static void Function1A()
        {
            Console.Write("Enter a phrase: ");
            var phrase = Console.ReadLine();

            if (phrase == null) return;

            phrase = phrase.Trim().ToLower();
            var vowelsCount = phrase.Count(t => IsVowel(t) != 0);

            Console.WriteLine("Total number of towels: " + vowelsCount);
        }

        private static int IsVowel(char c)
        {
            switch (c)
            {
                case 'a':
                    return 1;
                case 'e':
                    return 2;
                case 'i':
                    return 3;
                case 'o':
                    return 4;
                case 'u':
                    return 5;
                default:
                    return 0;
            }
        }

        public static void Function1B()
        {
            Console.Write("Enter a phrase: ");
            var phrase = Console.ReadLine();

            if (phrase == null) return;

            phrase = phrase.Trim().ToLower();
            var numberOfA = 0;
            var numberOfE = 0;
            var numberOfI = 0;
            var numberOfO = 0;
            var numberOfU = 0;

            foreach (var ret in phrase.Select(IsVowel))
            {
                switch (ret)
                {
                    case 1:
                        numberOfA++;
                        break;
                    case 2:
                        numberOfE++;
                        break;
                    case 3:
                        numberOfI++;
                        break;
                    case 4:
                        numberOfO++;
                        break;
                    case 5:
                        numberOfU++;
                        break;
                }
            }

            Console.WriteLine("\nnumberOfA: " + numberOfA);
            Console.WriteLine("numberOfE: " + numberOfE);
            Console.WriteLine("numberOfI: " + numberOfI);
            Console.WriteLine("numberOfO: " + numberOfO);
            Console.WriteLine("numberOfU: " + numberOfU + '\n');
        }

        public static void Function2()
        {
            Console.Write("Enter a string: ");
            var input = Console.ReadLine();
            if (input == null) return;

            var inputArray = input.ToCharArray();
            var reverseArray = input.ToCharArray();
            Array.Reverse(reverseArray);

            // First approach: by for
            /*
            var checkFlag = true;
            for (var i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == reverseArray[i]) continue;
                checkFlag = false;
                break;
            }
            */
            // Second approach: LINQ
            var checkFlag = !inputArray.Where((t, i) => t != reverseArray[i]).Any();
            Console.WriteLine(checkFlag ? "Palindrome\n" : "Not a palindrome\n");
        }

        public static void Function3()
        {
            Console.Write("Enter a string: ");
            var input = Console.ReadLine();
            if (input == null) return;

            // Fix the input
            input = input.ToLower().Replace(" ", "");
            var originalCharArray = input.ToCharArray();
            var fixedCharArray = originalCharArray.Where(c => !char.IsPunctuation(c)).ToArray();

            // Clone and reverse
            var reverseCharArray = (char[])fixedCharArray.Clone();
            Array.Reverse(reverseCharArray);

            // Final check and give answer
            var checkFlag = !fixedCharArray.Where((c, i) => c != reverseCharArray[i]).Any();
            Console.WriteLine(checkFlag ? "Palindrome\n" : "Not a palindrome\n");
        }

        public static void Function4()
        {
            Console.Write("Enter a string: ");
            var input = Console.ReadLine();
            if (input == null) return;

            var inputArray = input.Split(' ');
            var res = "";
            foreach (var s in inputArray)
            {
                var firstLetter = s.Substring(0, 1).ToUpper();
                var secondLetter = s.Substring(1, s.Length - 1);
                res += (firstLetter + secondLetter + " ");
            }

            Console.WriteLine("Result: " + res.TrimEnd());
        }

        public static void Function5()
        {
            var names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            var marks = new int[] { 63, 29, 75, 82, 55 };

            Array.Sort(marks);
            Array.Reverse(marks);
            Array.Sort(names);
            foreach (var mark in marks)
            {
                Console.Write(mark + "\t");
            }
            Console.WriteLine();

            foreach (var name in names)
            {
                Console.Write(name + "\t");
            }
            Console.WriteLine();

        }

        public static void Function6()
        {
            Console.Write("Enter your matriculation number: ");
            var input = Console.ReadLine();
            if (input == null) return;

            if (input.Length != 7)
            {
                Console.WriteLine("Invalid");
                return;
            }
            var number = Convert.ToInt32(input.ToUpper().Substring(1, 5));
            var num1 = number / 10000;
            number %= 10000;
            var num2 = number / 1000;
            number %= 1000;
            var num3 = number / 100;
            number %= 100;
            var num4 = number / 10;
            number %= 10;
            var num5 = number;

            var sum = num1 + num2 + num3 + num4 + num5;
            var remainder = sum % 5;
            var checksum = "";
            switch (remainder)
            {
                case 0:
                    checksum = "O";
                    break;
                case 1:
                    checksum = "P";
                    break;
                case 2:
                    checksum = "Q";
                    break;
                case 3:
                    checksum = "R";
                    break;
                case 4:
                    checksum = "S";
                    break;
                default:
                    checksum = "ERROR";
                    break;
            }

            Console.WriteLine(
                checksum == input.Substring(input.Length - 1, 1)
                    ? "Valid"
                    : "Invalid");
        }

        static void Main(string[] args)
        {
            Function6();
        }

    }
}