using System;

namespace Task_2
{
    public class Converter
    {
        private const double USDExchangeRate = 36.96;
        private const double EURExchangeRate = 38.95;
        private const double PLNExchangeRate = 8.43;
        private double v1;
        private double v2;
        private double v3;

        public Converter(double v1, double v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public double Convert(double amount, Currency sourceCurrency, Currency targetCurrency)
        {
            double sourceRate = GetExchangeRate(sourceCurrency);
            double targetRate = GetExchangeRate(targetCurrency);

            double uahAmount = amount / sourceRate;
            double targetAmount = uahAmount * targetRate;

            return targetAmount;
        }

        public double ConvertFromCurrency(double amount, Currency sourceCurrency)
        {
            double sourceRate = GetExchangeRate(sourceCurrency);

            double uahAmount = amount * sourceRate;

            return uahAmount;
        }

        private double GetExchangeRate(Currency currency)
        {
            switch (currency)
            {
                case Currency.USD:
                    return USDExchangeRate;
                case Currency.EUR:
                    return EURExchangeRate;
                case Currency.PLN:
                    return PLNExchangeRate;
                default:
                    throw new ArgumentException("Invalid currency.");
            }
        }
    }

    public enum Currency
    {
        USD,
        EUR,
        PLN
    }
}