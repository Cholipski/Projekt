using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom_V._2
{
    public class Client : Person, IClient
    {
        public Client(string firstName, string lastName, DateTime dateBirth, double pesel) : base(firstName, lastName, dateBirth, pesel)
        {
        }

        public int ClientID { get; set; }
        public int Discount { get; set; }


        public override string ToString()
        {
            return FirstName.ToString()+ " " + LastName.ToString() + " " + Pesel.ToString();
        }

        public string Gender()
        {
            string _Pesel = Convert.ToString(Pesel);
            if (Convert.ToInt32(_Pesel[9]) % 2 == 0){
                return "Kobieta";
            }
            return "Mężczyzna";
        }

    }
}
