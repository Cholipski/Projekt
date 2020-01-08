using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom_V._2
{
    class Volkswagen : Car, ICar
    {
        public Volkswagen(
            double price, string model, int horsePower, string MotorName, int NumCyl, Fuel _Fuel,
            double fuelUsage, int year, int fuelTank,
            Transmisson transmisson, Bitmap picture)
            : base(
                price, model, horsePower, fuelUsage, year,
                fuelTank, transmisson, picture
                )
        {
            base._Motor = new Motor(MotorName, NumCyl, _Fuel);
        }

        public int ID
        {
            get;
            set;
        }

        public int CarAge()
        {
            return DateTime.Now.Year - this._Year;
        }


        public int MaxDistance()
        {
            return Convert.ToInt32(_FuelTank / _FuelUsage);
        }

    }
}
