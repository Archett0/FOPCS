using System;

namespace ConsoleApp1
{
    public class Program5
    {
        //these arrays is visible in all the static method, 
        //so you can use them in your method implementation

        static int[] minIncomeArray = new int[]
        { 20000, 30000, 40000, 80000,
            120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
        { 0.02, 0.035, 0.07, 0.115,
            0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
        { 0, 200, 550, 3350,
            7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
                CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        //YOUR CODE HERE
        private static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int GetTaxBracket(int annualIncome)
        {
            for (var i = 0; i < minIncomeArray.Length; i++)
            {
                if (annualIncome <= minIncomeArray[i]) return i - 1;
                if (i == minIncomeArray.Length - 1) return i;
            }
            return -1;
        }

        private static double CalculateIncomeTax(int annualIncome, int taxBracket)
        {
            if(taxBracket == -1) return 0;
            var tax = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] +
                      basePayableAmountArray[taxBracket];
            return tax;
        }

        private static void PrintResult(int annualIncome, double taxPayable)
        {
            Console.WriteLine(
                    "For taxable annual income of {0:C2}," +
                    " the tax payable amount is {1:C2}",
                    annualIncome,
                    taxPayable);
        }

    }
}