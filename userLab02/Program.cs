using System;

namespace userLab02
{
    public class User
    {
        private string name;
        private string surname;
        private int age;
        private string login;
        private readonly DateTime joinDate = DateTime.Today;

        public User(string name, string surname, int age, string login)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Login = login;
        }

        public DateTime JoinDate => joinDate;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public string Login { get => login; set => login = value; }

        public override string ToString()
        {
            return $"Name: {Name,-5} \nSurname: {Surname,-10} \nLogin: {Login,-15} \nAge: {Age,-5} \nRegistration Date: {JoinDate.ToShortDateString()}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Maxym", "Bakumenko", 19, "MBakumenko");
            Console.WriteLine(user.ToString());
        }
    }
}