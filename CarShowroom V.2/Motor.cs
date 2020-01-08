using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom_V._2
{
    public class Motor
    {
        public string MotorName;
        public int NumCyl;
        public Fuel Fuel;

        public Motor(string motorName, int numCyl, Fuel fuel)
        {
            MotorName = motorName;
            NumCyl = numCyl;
            Fuel = fuel;
        }
    }
}
