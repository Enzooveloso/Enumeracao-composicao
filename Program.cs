using System;
using Course.Entities.Enums;
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/Midlevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary; ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);


            Console.Write("How many contracts  to this  worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter #{i + 1} contract data: ");
                Console.Write("Data (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value por hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and yeato to calculate income (MM/YYYY) ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.Write($"Name: {worker.Name}");
            Console.Write($"Department: {worker.Department.Name}");
            Console.Write($"Income for {monthAndYear}: {worker.Income(year,month)}");
        }
    }
}