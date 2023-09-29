using System;

namespace Task_4
{
    public class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrationDate = DateTime.Now;
        }

        public string GetLogin()
        {
            return login;
        }

        public void SetLogin(string value)
        {
            login = value;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            firstName = value;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public DateTime GetRegistrationDate()
        {
            return registrationDate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Login: {login}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Registration Date: {registrationDate}");
        }
    }
}