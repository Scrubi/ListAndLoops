using System;
using System.Collections.Generic;
using System.Text;


namespace ListAndLoopsExample
{
    class DataHandler
    {
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();
        public List<Company> companies = new List<Company>();

        

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Syötä kahvin merkki.");
            var merkki = Console.ReadLine();
            Console.WriteLine("Syötä kahvin hinta.");
            double hinta = Console.Read();
            Console.WriteLine("Syötä kahvin paahtoaste 1-5.");
            int paahtoaste = int.Parse(Console.ReadLine());
            var roast = (Coffee.Roast)paahtoaste;
            Coffee toReturn = new Coffee(merkki, hinta, roast);
            return toReturn;

        }
        
       public Person CreatePerson() 
        {
            Console.WriteLine("Syötä yhteyshenkilön etunimi.");
            var etunimi = Console.ReadLine();
            Console.WriteLine("Syötä yhteyshenkilön sukunimi.");
            var sukunimi = Console.ReadLine();
            Console.WriteLine("Syötä yhteyshenkilön puhnro.");
            var puhnro = Console.ReadLine();
            Console.WriteLine("Syötä yhteyshenkilön email.");
            var email = Console.ReadLine();

            var henkilö1 = new Person("Janne", "Pesonen", "0412221111", "jp@gmail.com");
            var henkilö2 = new Person("Pekka", "Lehtinen", "0412231111", "pl@gmail.com");
            var henkilö3 = new Person("Sari", "Seming", "0412224111", "ss@gmail.com");
            var henkilö4 = new Person("Kiira", "Ingman", "0412225111", "ki@gmail.com");

            persons.Add(henkilö1);
            persons.Add(henkilö2);
            persons.Add(henkilö3);
            persons.Add(henkilö4);

            Person toReturn = new Person(etunimi, sukunimi, puhnro, email);
            return toReturn;
        }

        public Company CreateCompany() 
        {
            Console.WriteLine("Syötä kahvin valmistajan nimi.");
            var name = Console.ReadLine();
            Console.WriteLine("Syötä kahvin valmistusmaa.");
            var country = Console.ReadLine();

            Company toReturn = new Company(name, country);
            return toReturn;
        }


    }
}
