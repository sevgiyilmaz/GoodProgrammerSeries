using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Sevgi",
                LastName = "Yılmaz",
                City = "İst",
            };

            Customer customer2 = new Customer(2, "Tuba", "Yılmaz", "İstanbul");
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    class Customer
    {
        // Default constructor : Parametresi olmayan constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı !");
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
