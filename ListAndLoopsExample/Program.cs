using System;
using System.Collections.Generic;
using System.Drawing;


namespace ListAndLoopsExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            bool showMenu = true;
            while (showMenu)
            {
                
                showMenu = MainMenu();
                
            }

        }

        

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Lisää Kahvi");
            Console.WriteLine("2) Lisää Yhteyshenkilö");
            Console.WriteLine("3) Lisää Valmistaja");
            Console.WriteLine("4) Hae Lista Kahveista, Yhteyshenkilöista tai Valmistajista (ei toimi vielä täysin)");
            Console.WriteLine("5) Poista Lista tai Yksittäinen merkintä Kahveista, Yhteyshenkilöistä tai Valmistajista (ei toimi vielä)");
            Console.WriteLine("6) Poistu Ohjelmasta");
            Console.Write("\r\nChoose an option: ");

            var dh = new DataHandler();
            dh.FillPersonsWithTestData();
            dh.FillCompaniesWithTestData();
          
         
            
            switch (Console.ReadLine())
            {
                case "1":
                    var kahvi = dh.CreateCoffee();
                    dh.coffees.Add(kahvi);
                    return true;
                case "2":
                    return true;
                case "3":
                    var valmistaja = dh.CreateCompany();
                    dh.companies.Add(valmistaja);
                    return true;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1) Hae Lista Kahveista");
                    Console.WriteLine("2) Hae Lista Yhteyshenkilöistä");
                    Console.WriteLine("3) Hae Lista Valmistajista");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            foreach (var Coffee in dh.coffees)
                            {
                                Console.WriteLine($"{Coffee.brand}");
                            }
                            Console.ReadKey();
                            return true;
                        case "2":
                            foreach (var Person in dh.persons)
                            {
                                Console.WriteLine($"{Person.firstName} {Person.lastName} {Person.phone} {Person.email}");
                            }
                            Console.ReadKey();
                            return true;
                        case "3":
                            foreach (var Company in dh.companies)
                            {
                                Console.WriteLine($"{Company.name} {Company.contactPerson} {Company.country}");
                            }
                            Console.ReadKey();
                            return true;
                    }
                    return true;
                case "5":   
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }

        }
             
   
    }

    //Vannhemmat DataHandler veriot:
    //var kahvi = dh.CreateCoffee();
    //var henkilö = dh.CreatePerson();
    //var valmistaja = dh.CreateCompany();
    //dh.coffees.Add(kahvi);
    //dh.persons.Add(henkilö);
    //dh.companies.Add(valmistaja);


    //for (int i = 0; i < coffees.Count; i++)
    //  Console.WriteLine($"{i}. Merkki : {coffees[i].brand}");


    //kahvit
    //-merkki, hinta, paahto,maahantuoja
    //constructorit ilman parametreja, pelkällä nimellä, kaikilla atribuuteilla


    //var paketti = new Coffee("pressa", 4.50 , Coffee.Roast.light, "joku");
    //Console.WriteLine($"enum:{(int)paketti.roast}");

    // var paketti1 = new Coffee("Presidentti");
    // var paketti2 = new Coffee("Kulta Katriina");
    // var paketti3 = new Coffee("Brazil");
    // var paketti4 = new Coffee("Löfberg");

    // List<Coffee> coffees = new List<Coffee>();
    // coffees.Add(paketti1);
    // coffees.Add(paketti2);
    // coffees.Add(paketti3);
    // coffees.Add(paketti4);

    //// Console.WriteLine(coffees[2].brand);

    // foreach (var paketti in coffees)
    // {
    //     Console.WriteLine($"Merkki {paketti.brand}");
    // }

    // for (int i = 0; i < coffees.Count; i++)
    // {
    //     Console.WriteLine($"{i}. Merkki : {coffees[i].brand}");
    // }

    //Company -luokka. nimi, yhteyshenkilö(luokkaa person), maa
    //person -luokka etunimi, sukunimi, puhelinnumero, email
    //DataHandler -luokka. list<cofee>, list<person>
    //metodi joka kysyy kahvin merkin, hinnan,roast -> luo näistä instanssin Coffee -> lisää ko. instanssin listaan.

}







