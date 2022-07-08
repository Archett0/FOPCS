using System;

namespace ConsoleApp1
{
    public class Program6
    {
        static void Main(string[] args)
        {
            string upperPlainText = ReturnUpperInputSentence();

            string encryptedText = EncryptSentence(upperPlainText);

            PrintEncryptedSentence(encryptedText);

            string decryptedText = DecryptSentence(encryptedText);

            PrintDecryptedSentence(decryptedText);

            Console.WriteLine("\nType any key to exit.");
            Console.ReadLine();
        }

        //YOUR CODE HERE
        private static string ReturnUpperInputSentence()
        {
            Console.Write("Please enter the sentence: ");
            return Console.ReadLine()?.ToUpper();
        }

        private static string EncryptSentence(string upperPlainText)
        {
            var res = "";
            foreach (var chr in upperPlainText)
            {
                if (!char.IsLetter(chr))
                {
                    res += chr;
                    continue;
                }

                switch (chr)
                {
                    case 'X':
                        res += 'A';
                        break;
                    case 'Y':
                        res += 'B';
                        break;
                    case 'Z':
                        res += 'C';
                        break;
                    default:
                        res += (char)(chr + 3);
                        break;
                }
            }
            return res;
        }

        private static void PrintEncryptedSentence(string encryptedText)
        {
            Console.WriteLine("The encrypted sentence is : " + encryptedText);
        }

        private static string DecryptSentence(string encryptedText)
        {
            var res = "";
            foreach (var chr in encryptedText)
            {
                if (!char.IsLetter(chr))
                {
                    res += chr;
                    continue;
                }

                switch (chr)
                {
                    case 'A':
                        res += 'X';
                        break;
                    case 'B':
                        res += 'Y';
                        break;
                    case 'C':
                        res += 'Z';
                        break;
                    default:
                        res += (char)(chr - 3);
                        break;
                }
            }
            return res;
        }

        private static void PrintDecryptedSentence(string decryptedText)
        {
            Console.WriteLine("The decrypted sentence is : " + decryptedText);
        }
    }
}