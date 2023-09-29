using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.96,38.95 , 8.43 );

            while (true)
            {
                Console.WriteLine("Enter the amount:");
                string amountStr = Console.ReadLine();

                if (string.IsNullOrEmpty(amountStr) || !double.TryParse(amountStr, out double amount))
                {
                    Console.WriteLine("Invalid amount. Please try again.");
                    continue;   
                }

                string sourceCurrencyStr;
                Currency sourceCurrency;

                do
                {
                    Console.WriteLine("Enter the currency to convert (USD, EUR, PLN):");
                    sourceCurrencyStr = Console.ReadLine();

                    if (!IsValidCurrency(sourceCurrencyStr))
                    {
                        Console.WriteLine("Invalid source currency. Please try again.");
                    }
                    else
                    {
                        sourceCurrency = (Currency)Enum.Parse(typeof(Currency), sourceCurrencyStr);
                        break;
                    }
                } while (true);

                string targetCurrencyStr;
                Currency targetCurrency;

                do
                {
                    Console.WriteLine("Enter the target currency (USD, EUR, PLN):");
                    targetCurrencyStr = Console.ReadLine();

                    if (!IsValidCurrency(targetCurrencyStr))
                    {
                        Console.WriteLine("Invalid target currency. Please try again.");
                    }
                    else
                    {
                        targetCurrency = (Currency)Enum.Parse(typeof(Currency), targetCurrencyStr);
                        break;
                    }
                } while (true);

                double result = converter.Convert(amount, sourceCurrency, targetCurrency);
                Console.WriteLine($"Conversion result: {result} {targetCurrency}");

                Console.WriteLine("Do you want to convert another amount? (yes/no)");
                string continueStr = Console.ReadLine()?.ToLower();

                if (continueStr != "yes")
                {
                    Console.WriteLine("Exiting the program.");
                    return; 
                }
            }
        }

        static bool IsValidCurrency(string currency)
        {
            string[] validCurrencies = { "USD", "EUR", "PLN" };
            return Array.Exists(validCurrencies, c => c.Equals(currency, StringComparison.OrdinalIgnoreCase));
        }
    }
}