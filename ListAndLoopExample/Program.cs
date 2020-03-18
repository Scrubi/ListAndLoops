using ListAndLoopExample;
using System;
using System.Collections.Generic;


namespace ListAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dh = new DataHandler();
            var brand = dh.CreateCoffee();
            dh.coffees.Add(brand);

            var paketti = new Coffee("pressa", 3.4, Coffee.Roast.light, "joku");
            
            
            
            
            
            //var pack1 = new Coffee("Presidentti");
            //var pack2 = new Coffee("Kulta Katriina");
            //var pack3 = new Coffee("Brazil");
            //var pack4 = new Coffee("Löfberg");

            //List<Coffee> coffees = new List<Coffee>();
            //coffees.Add(pack1);
            //coffees.Add(pack2);
            //coffees.Add(pack3);
            //coffees.Add(pack4);

            //foreach (Coffee item in coffees) 
            //{ 
            //    Console.WriteLine($"Merkki: {item.brand}");
            //}
        
            //for (int i = 0; i < coffees.Count; i++)
            //{
            //    Console.WriteLine($"Merkki: {coffees[i].brand}");
            //}

            //Company .luokka. nimi, yhteyshenkilö(luokkaa Person), maa
            //Person -luokka. etunimi, sukunimi, puhnro, email
            //DataHandler -luokka. list<coffee>, list<person>, list<company>
            //metodi joka kysyy kahvin merkin, hinnan, roast -> luo näistä instanssin Coffee -> lisää ko. instanssin listaan.
        }
    }

    
    //Kahvit
    //-merkki, hinta, paahtoaste,maahantuoja
    //constructor ilman parametrejä, pelkällä nimellä, kaikilla atribuuteilla
}
