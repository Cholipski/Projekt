using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroom_V._2
{
    public partial class Form1 : Form
    {
       internal List<Client> people; 
       internal List<Car> Cars;
       internal List<Order> orders;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            home1.BringToFront(); 
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnClientList.Height;
            SidePanel.Top = btnClientList.Top;
            clientList1.BringToFront();
            clientList1.ShowClient(people);
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCarList.Height;
            SidePanel.Top = btnCarList.Top;
            carList1.BringToFront();
            carList1.LoadCars(Cars);

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAddClient.Height;
            SidePanel.Top = btnAddClient.Top;
            addClient1.BringToFront();
            
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAddCar.Height;
            SidePanel.Top = btnAddCar.Top;
            addCar1.BringToFront();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAddOrder.Height;
            SidePanel.Top = btnAddOrder.Top;
            addOrder1.BringToFront();
            addOrder1.FillCombobox();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnOrders.Height;
            SidePanel.Top = btnOrders.Top;
            orders1.BringToFront();
            orders1.LoadOrders(orders);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addClient1.Frm1 = this;
            addCar1.Frm2 = this;
            addOrder1.Frm3 = this;
            this.orders = new List<Order>();

            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            home1.BringToFront();


            // Dodawanie przykładowych danych do programu
            #region data

            people = new List<Client>();
            DateTime c1_d = new DateTime(1977, 10, 05);
            Client c1 = new Client("Jan", "Kowalski", c1_d, 77100567296);
            c1.ClientID = 1;
            c1.Discount = 0;
            people.Add(c1);

            DateTime c2_d = new DateTime(1991, 11, 13);
            Client c2 = new Client("Aleksandra", "Wieczorek", c2_d, 91111391444);
            c2.Discount = 10;
            c2.ClientID = 2;

            people.Add(c2);

            DateTime c3_d = new DateTime(1982, 01, 11);
            Client c3 = new Client("Izabela", "Nowicka", c3_d, 82011381545);
            c3.ClientID = 3;
            c3.Discount = 0;


            people.Add(c3);

            DateTime c4_d = new DateTime(1982, 07, 05);
            Client c4 = new Client("Wiktor", "Zych", c4_d, 82070514791);
            c4.ClientID = 4;
            c4.Discount = 0;


            people.Add(c4);

            DateTime c5_d = new DateTime(1994, 04, 04);
            Client c5 = new Client("Martyna", "Nowak", c5_d, 94040474488);
            c5.ClientID = 5;
            c5.Discount = 15;

            people.Add(c5);

            Cars = new List<Car>();
            Bitmap orgianl = (Bitmap)Image.FromFile(@"..\..\Images\audiA4.jpg");
            Bitmap resized = new Bitmap(orgianl, new Size(148, 119));
            Audi s1 = new Audi(56799.90, "A4", 180, "1.8 T", 4, Fuel.Petrol, 11.6, 2017, 55, Transmisson.Manual,resized);
            s1.ID = 1; 
            Bitmap orgianl1 = (Bitmap)Image.FromFile(@"..\..\Images\audiA5.jpg");
            Bitmap resized1 = new Bitmap(orgianl1, new Size(148,119));
            Audi s2 = new Audi(156799.90, "A5", 210, "2.0 T", 4, Fuel.Diesel, 8.6, 2011, 65, Transmisson.Manual, resized1);
            s2.ID = 2;

            Bitmap orgianl2 = (Bitmap)Image.FromFile(@"..\..\Images\audiA1.png");
            Bitmap resized2 = new Bitmap(orgianl2, new Size(148, 119));
            Audi s4 = new Audi(14533.0, "A1", 140, "2.5 T", 4, Fuel.Diesel, 9.0, 2001, 55, Transmisson.Manual, resized2);
            s4.ID = 3;




            Cars.Add(s1);
            Cars.Add(s2);
            Cars.Add(s4);

            #endregion


        }

        private void addCar1_Load(object sender, EventArgs e)
        {
           addCar1.Picture = (Bitmap)Image.FromFile(@"..\..\Images\no-photo-car.jpg");
        }
    }
}
