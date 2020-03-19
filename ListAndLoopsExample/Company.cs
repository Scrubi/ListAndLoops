using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Company
    {
        public string name;
        public Person contactPerson;
        public string country;

        public Company(string name, string country)
        {
            this.name = name;
            this.country = country;
        }
    }
}
