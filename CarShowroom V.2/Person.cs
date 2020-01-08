using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom_V._2
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DateBirth;

        public Person(string firstName, string lastName, DateTime dateBirth, double pesel)
        {
            FirstName = firstName;
            LastName = lastName;
            DateBirth = dateBirth;
            Pesel = pesel;
        }

        public double Pesel
        {
            get;
        }
    }
}
