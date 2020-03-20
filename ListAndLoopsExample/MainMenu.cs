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
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Lisää Kahvi");
            Console.WriteLine("2) Lisää Yhteyshenkilö");
            Console.WriteLine("3) Lisää Valmistaja");
            Console.WriteLine("4) Hae Lista Kahveista, Yhteyshenkilöista tai Valmistajista (ei toimi vielä täysin)");
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
                    Console.WriteLine("Choose an option:");
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
                    return false;
                case "6":
                    Console.WriteLine("Poistuit Ohjelmasta!");
                    return false;
               
            }
            return true;
        }
    }
}