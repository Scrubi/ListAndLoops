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

        public void FillPersonsWithTestData()
        {
            this.persons.Add(new Person("Teppo", "Testipersoona", "050-888 4444", "teppo@testaus.fi"));
            this.persons.Add(new Person("Tapio", "Tapaustesti", "030-448 2244", "tapsa@testaus.fi"));
        }

        public void FillCompaniesWithTestData()
        {
            Person kontakti = new Person("Teppo", "Testipersoona", "050-888 4444", "teppo@testaus.fi");
            Company testCompany = new Company("testiyritys-1", kontakti, "Finland");
            this.companies.Add(testCompany);
        }
            

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Syötä kahvin merkki.");
            var merkki = Console.ReadLine();
            Console.WriteLine("Syötä kahvin hinta.");
            double hinta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Syötä kahvin paahtoaste 1-5.");
            string paahto = Console.ReadLine();
            int paahtoaste = int.Parse(paahto);
            var roast = (Coffee.Roast)paahtoaste;
            Coffee toReturn = new Coffee(merkki, hinta);
            return toReturn;
           

        }
        
       public Person CreatePerson() 
        {
            Console.WriteLine("Syötä yhteyshenkilön etunimi.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Syötä yhteyshenkilön sukunimi.");
            var lastName = Console.ReadLine();
            Console.WriteLine("Syötä yhteyshenkilön puhnro.");
            var phone = Console.ReadLine();
            Console.WriteLine("Syötä yhteyshenkilön email.");
            var email = Console.ReadLine();

            Person person= new Person(firstName, lastName, phone, email);
            return person;
        }

        public void AddNewPersonToList()
        {
            Person person = CreatePerson();
            this.persons.Add(person);
            Console.WriteLine("Henkilö Lisätty listaan");
        }

        public void PrintPersonList()
        {
            for (int i = 0; i < this.persons.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {this.persons[i].firstName} {this.persons[i].lastName}");
            }
        }

        public Person SelectPersonFromList()
        {
            PrintPersonList();
            Console.WriteLine("Syötä valittavan henkilön numero:");
            //parse to int
            var selected = int.Parse(Console.ReadLine());
            //Get Person object from the list and return it. 
            //since the list starts with 1 but list index with 0, we need to -1 from selected.
            return this.persons[selected - 1];
        }


        public Company CreateCompany() 
        {
            Console.WriteLine("Anna yrityksen nimi:");
            string name = Console.ReadLine();
            Console.WriteLine("Anna yrityksen maa:");
            string country = Console.ReadLine();

            //later we add possibility to choose from list or add a new person.
            Console.WriteLine("Valitse yhteyshenkilö listasta");
            Person contactPerson = SelectPersonFromList();

            Company company = new Company(name, contactPerson, country);

            return company;
        }
        public void AddNewCompanyToList()
        {
            Company company = CreateCompany();
            this.companies.Add(company);
            Console.WriteLine("Yritys lisättiin listaan.");
        }

        public void PrintCompanyList()
        {
            int i = 1;
            foreach (Company company in this.companies)
            {

                Console.WriteLine($"{i}.\tNimi:{company.name}");
                Console.WriteLine($"\tYhteyshenkilö:{company.contactPerson.firstName} {company.contactPerson.lastName}");
                i++;
            }
        }

        public Company SelectCompanyFromList()
        {
            PrintCompanyList();
            Console.WriteLine("Syötä valittavan yrityksen numero:");
            //parse to int
            var selected = int.Parse(Console.ReadLine());
            //Get Person object from the list and return it. 
            //since the list starts with 1 but list index with 0, we need to -1 from selected.
            return this.companies[selected - 1];
        }


    }
}
