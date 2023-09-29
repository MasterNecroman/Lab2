using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = "564234",
                Country = "Ukraine",
                City = "Chernobyl",
                Street = "Monolitova Street",
                House = "7",
                Apartment = "30"
            };

            Console.WriteLine("Postcode:");
            Console.WriteLine($"Index: {address.Index}");
            Console.WriteLine($"Country: {address.Country}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"Street: {address.Street}");
            Console.WriteLine($"Home: {address.House}");
            Console.WriteLine($"Apartment: {address.Apartment}");

            Console.ReadLine();
        }
    }
}