using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.96, 33.2, 8.43);
            MainLoop(converter);
            Console.WriteLine("Exiting the program.");
        }

        static void MainLoop(Converter converter)
        {
            while (true)
            {
                double amount = GetAmount();
                Currency sourceCurrency = GetCurrency("Enter the currency to convert (USD, EUR, PLN):");
                Currency targetCurrency = GetCurrency("Enter the target currency (USD, EUR, PLN):");

                double result = converter.Convert(amount, sourceCurrency, targetCurrency);
                Console.WriteLine($"Conversion result: {result} {targetCurrency}");

                Console.WriteLine("Do you want to convert another amount? (yes/no)");
                string continueStr = Console.ReadLine()?.ToLower();

                if (continueStr != "yes")
                {
                    break;
                }
            }
        }

        static double GetAmount()
        {
            double amount;

            while (true)
            {
                Console.WriteLine("Enter the amount:");
                string amountStr = Console.ReadLine();

                if (string.IsNullOrEmpty(amountStr) || !double.TryParse(amountStr, out amount))
                {
                    Console.WriteLine("Invalid amount. Please try again.");
                }
                else
                {
                    break;
                }
            }

            return amount;
        }

        static Currency GetCurrency(string message)
        {
            Currency currency;

            while (true)
            {
                Console.WriteLine(message);
                string currencyStr = Console.ReadLine();

                if (Enum.TryParse(currencyStr, out currency) && Enum.IsDefined(typeof(Currency), currency))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid currency. Please try again.");
                }
            }

            return currency;
        }
    }
}
