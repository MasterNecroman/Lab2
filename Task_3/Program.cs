using System;
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Shuhart", "Red");
            employee.DisplayInfo();
            double salary = employee.CalculateSalary("Manager", 6);
            Console.WriteLine($"Wages: {salary} UAH");

            Console.ReadLine();
        }
    }
}