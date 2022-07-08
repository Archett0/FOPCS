using System;

namespace ConsoleApp1
{
    public class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            const string pin = "123QAZ";
            var attempts = 0;
            var success = false;

            while (attempts < 3)
            {
                Console.Write("Enter your PIN: ");
                var input = Console.ReadLine();
                attempts++;
                if (input != null && input.Equals(pin))
                {
                    success = true;
                    break;
                }
                if (attempts != 3)
                    Console.WriteLine("\nIncorrect PIN. Please try again.");
            }

            Console.WriteLine(success
                ? "\nPIN accepted. You can access your account now."
                : "\nToo many wrong PIN entries. Your account is now locked.");
        }
    }
}
