using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopExample
{
    class Coffee
    {
        public enum Roast
        {
            light =1,
            mediumlight,
            medium,
            mediumdark,
            dark
        }

        public string brand;
        public double price;
        public Roast roast;
        public string importer;

        public Coffee()
        {

        }

        public Coffee(string brand)
        {
            this.brand = brand;
        }

        public Coffee(string brand, double price, Roast roast, string importer)
        {
            this.brand = brand;
            this.price = price;
            this.roast = roast;
            this.importer = importer;
        }
    }
}
