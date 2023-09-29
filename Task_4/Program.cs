using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("MasterNecroman", "Red", "Shuhart", 20);
            user.DisplayInfo();

            Console.ReadLine();
        }
    }
}