using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroom_V._2
{
    public partial class CarList : UserControl
    {
        
        public CarList()
        {
            InitializeComponent();
        }

        public void LoadCars(List<Car> cars)
        {
            CarLayout[] listCar = new CarLayout[cars.Count];
            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < listCar.Length; i++)
            {
                listCar[i] = new CarLayout();
                listCar[i].Price = cars[i].Price.ToString() + " ZŁ";
                listCar[i].Model = cars[i]._Model.ToString();
                listCar[i].MotorName = cars[i]._Motor.MotorName.ToString();
                listCar[i].NumCyl = "( " + cars[i]._Motor.NumCyl.ToString() + " Cylindry)";
                listCar[i].Fuel = cars[i]._Motor.Fuel.ToString();
                listCar[i].HorsePower = cars[i]._HorsePower.ToString() + " KM";
                listCar[i].Transmission = cars[i]._Transmisson.ToString();
                listCar[i].Year = cars[i]._Year.ToString();
                listCar[i].FuelUsage = cars[i]._FuelUsage.ToString() + "l/100 km";
                listCar[i].MaxDistance_FuelTank = "~"+((cars[i] as ICar).MaxDistance()* 100).ToString() + " km (" + cars[i]._FuelTank.ToString() + " l )";

                listCar[i].Mark = cars[i].GetType().Name.ToString();
                listCar[i].Icon = cars[i]._Icon;
                listCar[i].Equipment = cars[i]._Equipment;
                listCar[i].Age = "("+(cars[i] as ICar).CarAge().ToString()+" Lat)";
                listCar[i].ID = "#" + (cars[i] as ICar).ID.ToString();
                flowLayoutPanel1.Controls.Add(listCar[i]);

            }
        }
    }
}
