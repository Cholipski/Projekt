using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom_V._2
{
    public class Order
    {
        public DateTime datatime;
        public double PriceDiscount;
        public Order(int iD, Car car, Client client, DateTime datatime, double PriceDiscount)
        {
            ID = iD;
            this.Car = car;
            this.client = client;
            this.datatime = datatime;
            this.PriceDiscount = PriceDiscount;
        }
        public int ID { get; }
        public Car Car { get; }
        public Client client { get; }
    }
}
