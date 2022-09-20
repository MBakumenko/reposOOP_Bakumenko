using System;

namespace employeeLab02
{
    public enum Position
    {
        Cleaner = 1,
        Trainee,
        Junior,
        Middle,
        Senior,
        TeamLead,
        Manager
    }

    public class Employee
    {
        private string name;
        private string surname;
        private double workPeriod;
        private Position position;
        private const int baseSalary = 1000;

        public Employee(string name, string surname, double workPeriod, Position position)
        {
            Name = name;
            Surname = surname;
            this.workPeriod = workPeriod;
            this.position = position;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public double Salary => baseSalary * (int)position * (workPeriod / 1.5 + 1);
        public double Tax => baseSalary * (int)position * 0.2;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Maxym", "Bakumenko", 1.5, Position.Junior);
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Surname: {employee.Surname}");
            Console.WriteLine($"Position: {Position.Junior}");
            Console.WriteLine($"Salary: {employee.Salary,0:0.00}");
            Console.WriteLine($"Tax: {employee.Tax}");
        }
    }
}