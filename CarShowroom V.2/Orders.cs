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
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
        }
        public void LoadOrders(List<Order> _orders)
        {
            OrderLayout[] orders = new OrderLayout[_orders.Count];
            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < orders.Length; i++)
            {
                orders[i] = new OrderLayout();
                orders[i].IDclient = _orders[i].client.ClientID.ToString();
                orders[i].IDOrder = "#"+_orders[i].ID.ToString();
                orders[i].IDCar = (_orders[i].Car as ICar).ID.ToString();
                orders[i].FirstName = _orders[i].client.FirstName.ToString();
                orders[i].LastName = _orders[i].client.LastName.ToString();
                orders[i].Pesel = _orders[i].client.Pesel.ToString();
                orders[i].Model_Mark = _orders[i].Car.GetType().Name.ToString() + " " + _orders[i].Car._Model.ToString();
                orders[i].Engine = _orders[i].Car._Motor.MotorName.ToString() + " " + _orders[i].Car._HorsePower.ToString();
                orders[i].Price = _orders[i].PriceDiscount.ToString();
                orders[i].Date = _orders[i].datatime.ToString("dd / MM / yyyy");

                flowLayoutPanel1.Controls.Add(orders[i]);

            }
        }
    }
}
