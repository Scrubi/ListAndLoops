using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopExample
{
    class Person
    {
        public string forename;
        public string surname;
        public string email;
        public int phonenumber;

        public Person()
        {

        }

        public Person(string forename, string surname, string email, int phonenumber)
        {
            this.forename = forename;
            this.surname = surname;
            this.email = email;
            this.phonenumber = phonenumber;
        }
    }
}
