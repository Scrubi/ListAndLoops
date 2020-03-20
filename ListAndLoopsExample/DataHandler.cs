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

            Company importer = null;
            bool impoterSelected = false;
            while (!impoterSelected)
            {
                Console.Clear();

                Console.WriteLine("Mikä on maahantuova yritys?");
                Console.WriteLine("1. Valitse yritys listasta.");
                Console.WriteLine("2. Uusi yritys.");
                int selected = int.Parse(Console.ReadLine());
                switch (selected)
                {
                    case 1:
                        Console.Clear();
                        importer = SelectCompanyFromList();
                        impoterSelected = true;
                        break;
                    case 2:
                        Console.Clear();
                        importer = AddNewCompanyToList();
                        impoterSelected = true;
                        break;
                    case 3:
                        importer = null;
                        impoterSelected = true;
                        break;
                    default:
                        break;
                }
            }
            Coffee coffee = new Coffee(merkki, hinta, roast, importer);
            return coffee;
           

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

        public Person AddNewPersonToList()
        {
            Person person = CreatePerson();
            this.persons.Add(person);
            Console.WriteLine("Henkilö Lisätty listaan");
            return person;
        }

        public void AddNewCoffeeToList()
        {
            Coffee coffee = CreateCoffee();
            this.coffees.Add(coffee);
            Console.WriteLine("Kahvi lisätty listaan");
        }
        public void PrintCoffeeList()
        {
            for (int i = 0; i < this.coffees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Merkki: {this.coffees[i].brand} | Hinta: {this.coffees[i].price} | Paahtoaste: {this.coffees[i].roast}");
            }
        }
        public void PrintPersonList()
        {
            for (int i = 0; i < this.persons.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Etunimi: {this.persons[i].firstName} | Sukunimi: {this.persons[i].lastName} | Puhnro: {this.persons[i].phone} | Email: {this.persons[i].email}");
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
            bool personIsSelected = false;

            Person contactPerson = null;

            while (!personIsSelected)
            {
                Console.Clear();

                Console.WriteLine("1. Valiste yhteyshenkilö listasta.");
                Console.WriteLine("2. Lisää uusi yhteyshenkilö.");
                Console.WriteLine("3. Ei yhteyshenkilöä.");
                var selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        contactPerson = SelectPersonFromList();
                        personIsSelected = true;
                        break;
                    case 2:
                        //Note. At this point AddNewPersonToList is edited 
                        //so, that it also returns the Person added to the list.
                        contactPerson = AddNewPersonToList();
                        personIsSelected = true;
                        break;
                    case 3:
                        //contactPerson is already null, so just end this while loop.
                        personIsSelected = true;
                        break;
                    default:
                        personIsSelected = false;
                        break;
                }
            }

            Company company = new Company(name, contactPerson, country);

            return company;
        }
        public Company AddNewCompanyToList()
        {
            Company company = CreateCompany();
            this.companies.Add(company);
            Console.WriteLine("Yritys lisättiin listaan.");
            return company;
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

        //public Coffee DeleteCoffee()
        //{
        //    return coffee;
        //}
        public void DeleteCoffeeList()
        {
            
            this.coffees.Clear();
            Console.WriteLine("Kahvi Lista poistettiin.");
        }

        public void DeletePersonList()
        {

            this.persons.Clear();
            Console.WriteLine("Yhteyshenkilö Lista poistettiin.");
        }

        public void DeleteCompanyList()
        {

            this.companies.Clear();
            Console.WriteLine("Yritys Lista poistettiin.");
        }

    }
}
