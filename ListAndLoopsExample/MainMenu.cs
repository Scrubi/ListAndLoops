using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class MainMenu
    {
        public DataHandler dataHandler;
        public MainMenu()
        {

        }

        public MainMenu(DataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }


        public void InitializeMainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }

        private bool ShowMainMenu()
        {

            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1) Lisää Kahvi");
            Console.WriteLine("2) Lisää Yhteyshenkilö");
            Console.WriteLine("3) Lisää Valmistaja");
            Console.WriteLine("4) Hae Lista Kahveista, Yhteyshenkilöista tai Valmistajista");
            Console.WriteLine("5) Poista Lista tai Yksittäinen merkintä Kahveista, Yhteyshenkilöistä tai Valmistajista (ei toimi vielä)");
            Console.WriteLine("6) Poistu Ohjelmasta");
            Console.Write("\r\nChoose an option: ");

            var dh = new DataHandler();




            switch (Console.ReadLine())
            {
                case "1":
                    dataHandler.AddNewCoffeeToList();
                    Console.ReadKey();
                    break;
                case "2":
                    dataHandler.AddNewPersonToList();
                    Console.ReadKey();
                    break;
                case "3":
                    dataHandler.AddNewCompanyToList();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Valitse:");
                    Console.WriteLine("1) Hae Lista Kahveista");
                    Console.WriteLine("2) Hae Lista Yhteyshenkilöistä");
                    Console.WriteLine("3) Hae Lista Valmistajista");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            dataHandler.PrintCoffeeList();
                            Console.ReadKey();
                            break;
                        case "2":
                            dataHandler.PrintPersonList();
                            Console.ReadKey();
                            break;
                        case "3":
                            dataHandler.PrintCompanyList();
                            Console.ReadKey();
                            break;
                    }
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Valitse:");
                    Console.WriteLine("1) Poista Koko Lista Kahveista");
                    Console.WriteLine("2) Poista Koko Lista Yhteyshenkilöistä");
                    Console.WriteLine("3) Poista Koko Lista Valmistajista");
                    Console.WriteLine("4) Poista Yksittäinen Kahvi, Yhteyshenkilö tai Valmistaja");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            dataHandler.DeleteCoffeeList();
                            Console.ReadKey();
                            break;
                        case "2":
                            dataHandler.DeletePersonList();
                            Console.ReadKey();
                            break;
                        case "3":
                            dataHandler.DeleteCompanyList();
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Valitse:");
                            Console.WriteLine("1) Poista Yksittäinen Kahvi Listasta");
                            Console.WriteLine("2) Poista Yksittäinen Yhteyshenkilö Listasta");
                            Console.WriteLine("3) Poista Yksittäinen Valmistaja Listasta");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.WriteLine("Valitse Kahvi joka poistetaan listasta (rivinumero):");
                                    dataHandler.PrintCoffeeList();
                                    var coffeeremove = int.Parse(Console.ReadLine());
                                    dataHandler.coffees.RemoveAt(coffeeremove - 1);
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.WriteLine("Valitse Yhteyshenkilö joka poistetaan listasta (rivinumero):");
                                    dataHandler.PrintPersonList();
                                    var personremove = int.Parse(Console.ReadLine());
                                    dataHandler.persons.RemoveAt(personremove - 1);
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.WriteLine("Valitse Valmistaja joka poistetaan listasta (rivinumero):");
                                    dataHandler.PrintCompanyList();
                                    var companyremove = int.Parse(Console.ReadLine());
                                    dataHandler.companies.RemoveAt(companyremove - 1);
                                    Console.ReadKey();
                                    break;
                            }
                                    break;
                    }
                    break;
                case "6":
                    Console.WriteLine("Poistuit Ohjelmasta!");
                    return false;
               
            }
            return true;
        }
    }
}