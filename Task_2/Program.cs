using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.96, 33.2, 7.5);
            MainLoop(converter);
            Console.WriteLine("Exiting the program.");
        }

        static void MainLoop(Converter converter)
        {
            double amount = GetAmount();
            Currency sourceCurrency = GetCurrency("Enter the currency to convert (USD, EUR, PLN):");
            Currency targetCurrency = GetCurrency("Enter the target currency (USD, EUR, PLN):");

            double result = converter.Convert(amount, sourceCurrency, targetCurrency);
            Console.WriteLine($"Conversion result: {result} {targetCurrency}");

            Console.WriteLine("Do you want to convert another amount? (yes/no)");
            string continueStr = Console.ReadLine()?.ToLower();

            if (continueStr == "yes")
            {
                MainLoop(converter);
            }
            else
            {
                Console.WriteLine("Exiting the program.");
            }
        }

        static double GetAmount()
        {
            Console.WriteLine("Enter the amount:");
            string amountStr = Console.ReadLine();

            if (double.TryParse(amountStr, out double amount))
            {
                return amount;
            }
            Console.WriteLine("Invalid amount. Please try again.");
            return GetAmount();
        }

        static Currency GetCurrency(string prompt)
        {
            Console.WriteLine(prompt);
            string currencyStr = Console.ReadLine();

            if (Enum.TryParse(currencyStr, out Currency currency) && Enum.IsDefined(typeof(Currency), currency))
            {
                return currency;
            }
            Console.WriteLine("Invalid currency. Please try again.");
            return GetCurrency(prompt);
        }
    }
}
