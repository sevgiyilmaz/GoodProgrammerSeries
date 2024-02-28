using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean.. value types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;// sayi2'nin değeri atanır

            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1);

            //arrays ,class, interface.. reference types
            //new dediğin zaman heap'te adres oluşturursun.
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2; // sayilar2 nin adresini atarız değerini değil

            sayilar2[0] = 1000;
            Console.WriteLine("sayilar1[0] = " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1; //referansı aldık, değer değil.
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            //customer = employee; farklı tiplerdir atayamazsın

            Person person3 = customer; //çünkü customer bir persondır.burada yine adres atamış olursun.
            customer.FirstName = "Ahmet";

            Console.WriteLine(((Customer)person3).CreditCardNumber); //böyle olunca person3'ten creditcart'a erişebilirsin. Burada neye Boxing yapacağını söylemiş oluyorsun


            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
        }
    }
    //Base class 
    //miras verdiği sınıfların adresini tutabilir
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmplooyeNumber { get; set; }
    }

    class PersonManager
    {
        //Aynı kodun farklı nesneler için kullanılabilmesine imkan sunuyor
        public void Add(Person person) //ne gönderirsen onu çalışır. Person yaparsam miras verdiği sınıfları da kullanırsın
        {

            Console.WriteLine(person.FirstName);
        }
    }
}
