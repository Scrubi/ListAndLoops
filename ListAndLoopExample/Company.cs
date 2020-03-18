using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopExample
{
    class Company
    {
        public string companyname;
        public string contactname;
        public string country;
        

        public Company()
        {

        }

        
        public Company(string companyname, string contactname, string country)
        {
            this.companyname = companyname;
            this.contactname = contactname;
            this.country = country;
        }
    }
}
