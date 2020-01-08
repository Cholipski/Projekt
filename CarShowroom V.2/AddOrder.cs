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
    public partial class AddOrder : UserControl
    {

        public Form1 Frm3 { get; set; } // Przypisanie formualrza do zmiennej (potrzebne aby odwołać się do List<T> które znajdują się w Form1

        public AddOrder()
        {
            InitializeComponent();
        }
        public void FillCombobox()
        {
            FillClient();
            FillCars();
        }
        private void FillClient() // Fukcja wypełni ComboBox danymi z listy klientów
        {
            cbClient.Items.Clear();
            foreach (var obj in Frm3.people)
            {
                cbClient.Items.Add(obj);
            }
        }
        private void FillCars() //Funckaj wypełni ComboBox danymi z listy samochodów 
        {
            cbCar.Items.Clear();
            foreach (var obj in Frm3.Cars)
            {
                cbCar.Items.Add(obj);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client tmp = cbClient.SelectedItem as Client;
            FillClient(tmp);
            cbCar.Enabled = true;
        }

        private void FillCar(Car c1, double dicount) // Wypełnienie TextBox-ów danymi z obiektu który został wybrany z listy ComboBox 
                                                     //(TextBox-y mają zaznaczoną opcję 'Tylko do odczytu')
        {
            pictureCar.Image = c1._Icon;
            tbMark.Text = c1.GetType().Name.ToString().ToUpper();
            tbModel.Text = c1._Model.ToString().ToUpper();
            tbHorsePower.Text = c1._HorsePower.ToString();
            tbFuel.Text = c1._Motor.Fuel.ToString().ToUpper();
            tbFuelTank.Text = c1._FuelTank.ToString();
            tbFuelConsumption.Text = c1._FuelUsage.ToString();
            tbMotorName.Text = c1._Motor.MotorName.ToUpper().ToString();
            tbPriceOrginal.Text = c1.Price.ToString();
            tbPriceDiscount.Text = (c1.Price * (1 - (dicount / 100))).ToString();
            tbTransmission.Text = c1._Transmisson.ToString().ToUpper();
            tbYear.Text = c1._Year.ToString();
            tbNumCyl.Text = c1._Motor.NumCyl.ToString();
            

        }
        private void FillClient(Client c1)
        {
            tbFirstName.Text = c1.FirstName.ToString().ToUpper();
            tbLastName.Text = c1.LastName.ToString().ToUpper();
            tbPesel.Text = c1.Pesel.ToString();
            tbDateBirth.Text = c1.DateBirth.ToString("dd/mm/yyyy");
            tbGender.Text = c1.Gender().ToUpper();
            tbDiscount.Text = c1.Discount.ToString() + " %";
        }

        private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car tmp = cbCar.SelectedItem as Car;
            FillCar(tmp,(cbClient.SelectedItem as Client).Discount);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Frm3.orders.Count + 1;
            Order order = new Order(id, cbCar.SelectedItem as Car,
                cbClient.SelectedItem as Client,
                DateTime.Now,
                (cbCar.SelectedItem as Car).Price * (1 - ((cbClient.SelectedItem as Client).Discount / 100)));
            Frm3.orders.Add(order);
            CustomMessage.Show("Zamówienie dodane");
        }
    }
}
