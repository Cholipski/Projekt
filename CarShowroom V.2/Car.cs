using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom_V._2
{
    public abstract class Car
    {
        protected double _Price;
        public string _Model;
        public int _HorsePower;
        public Motor _Motor;
        public double _FuelUsage;
        public int _Year;
        public int _FuelTank;
        public List<string> _Equipment;
        public Transmisson _Transmisson;
        public Bitmap _Icon;

        protected Car(
            double price, string model, int horsePower, double fuelUsage, int year, int fuelTank,
             Transmisson transmisson,Bitmap picture
            )
        {
            _Price = price;
            _Model = model;
            _HorsePower = horsePower;
            _FuelUsage = fuelUsage;
            _Year = year;
            _FuelTank = fuelTank;
            _Transmisson = transmisson;
            _Icon = picture;
        }
        public double Price
        {
            get { return _Price; }
        }
        public override string ToString()
        {
            return (this as ICar).ID.ToString() +
                " " +
                this.GetType().Name.ToString() +
                " " +
                this._Model.ToString() +
                " " + this._Year.ToString() +
                " " +
                this._Price.ToString() + " zł";
        }
    }
}
