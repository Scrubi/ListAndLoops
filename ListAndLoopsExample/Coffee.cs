﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{

    //kahvit
    //-merkki, hinta, paahto,maahantuoja
    //constructorit ilman parametreja, pelkällä nimellä, kaikilla atribuuteilla

    class Coffee
    {
        public enum Roast {light=1,lightmedium,medium,darkmedium,dark}

        public string brand;        
        public double price;        
        public Roast roast;
        public Company importer;
        public Coffee(string merkki)
        {

        }

        public Coffee(string brand, double price)
        {
            this.brand = brand;
        }

        public Coffee(string brand, double price, Roast roast, Company importer)
        {
            this.brand = brand;
            this.price = price;
            this.roast = roast;
            this.importer = importer;
        }
    }
}
