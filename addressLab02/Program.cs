using System;

namespace addressLab02
{
    public class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private int appartment;

        public string Index { get => index; set => index = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string House { get => house; set => house = value; }
        public int Appartment { get => appartment; set => appartment = value; }

        public override string ToString()
        {
            return $"{Index}, {Country}: {City}; {Street} {House}, {Appartment}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = "02099",
                Country = "Ukraine",
                City = "Kyiv",
                Street = "Veresneva St.",
                House = "9",
                Appartment = 171
            };

            Console.WriteLine(address.ToString());
        }
    }
}
