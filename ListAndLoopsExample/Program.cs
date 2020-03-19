using System;
using System.Collections.Generic;
using System.Drawing;


namespace ListAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            bool showMenu = true;
            while (showMenu)
            {
                
                showMenu = MainMenu();
                
            }

           
            


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

        

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Lisää Kahvi");
            Console.WriteLine("2) Lisää Yhteyshenkilö");
            Console.WriteLine("3) Lisää Valmistaja");
            Console.WriteLine("4) Poistu Ohjelmasta");
            Console.Write("\r\nSelect an option: ");

            var dh = new DataHandler();
            //var kahvi = dh.CreateCoffee();
            //var henkilö = dh.CreatePerson();
            //var valmistaja = dh.CreateCompany();
            //dh.coffees.Add(kahvi);
            //dh.persons.Add(henkilö);
            //dh.companies.Add(valmistaja);
            
            switch (Console.ReadLine())
            {
                case "1":
                    var kahvi = dh.CreateCoffee();
                    dh.coffees.Add(kahvi);
                    return true;
                case "2":
                    var henkilö = dh.CreatePerson();
                    dh.persons.Add(henkilö);
                    return true;
                case "3":
                    var valmistaja = dh.CreateCompany();
                    dh.companies.Add(valmistaja);
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }

        }
    }


    //kahvit
    //-merkki, hinta, paahto,maahantuoja
    //constructorit ilman parametreja, pelkällä nimellä, kaikilla atribuuteilla



}
            
            
            




