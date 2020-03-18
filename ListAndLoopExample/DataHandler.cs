using System;
using System.Collections.Generic;
using System.Text;
using ListAndLoopExample;

namespace ListAndLoopExample
{
    class DataHandler
    {
        
        public List<Coffee> coffees = new List<Coffee>();
        public List<Company> companies = new List<Company>();
        public List<Person> persons = new List<Person>();
            
            public Coffee CreateCoffee() 
            {
                Console.WriteLine("Anna kahvin merkki:");
                var brand = Console.ReadLine();
                Coffee toReturn = new Coffee(brand);
                return toReturn;

            }
    }
}
