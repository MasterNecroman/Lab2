namespace Task_3
{
    public class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public double CalculateSalary(string position, int experience)
        {
            double baseSalary = 0;

            switch (position)
            {
                case "Manager":
                    baseSalary = 50000;
                    break;
                case "Developer":
                    baseSalary = 70000;
                    break;
            }

            double experienceBonus = 0;

            if (experience >= 5)
            {
                experienceBonus = 7000;
            }

            double salary = baseSalary + experienceBonus;
            double tax = 0.5 * salary;
            return salary - tax;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"First Name: {lastName}");
            Console.WriteLine($"last name: {firstName}");
        }
    }
}