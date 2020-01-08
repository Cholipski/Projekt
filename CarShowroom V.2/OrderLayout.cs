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
    public partial class OrderLayout : UserControl
    {
        public OrderLayout()
        {
            InitializeComponent();
        }

        private string _IDClient;
        private string _FirstName;
        private string _LastName;
        private string _Pesel;
        private string _IDCar;
        private string _Model_Mark;
        private string _Engine;
        private string _Price;
        private string _IDOrder;
        private string _Date;

        public string IDclient
        {
            get { return _IDClient; }
            set { _IDClient = value; lbIDclient.Text = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; lbFirstName.Text = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; lbLastName.Text = value; }
        }
        public string Pesel
        {
            get { return _Pesel; }
            set { _Pesel = value; lbPesel.Text = value; }
        }
        public string IDCar
        {
            get { return _IDCar; }
            set { _IDCar = value; lbIDcar.Text = value; }
        }
        public string Model_Mark
        {
            get { return _Model_Mark; }
            set { _Model_Mark = value; lbMark_Model.Text = value; }
        }
        public string Engine
        {
            get { return _Engine; }
            set { _Engine = value; lbEngine.Text = value; }
        }
        public string Price
        {
            get { return _Price; }
            set { _Price = value; lbPrice.Text = value; }
        }
        public string IDOrder
        {
            get { return _IDOrder; }
            set { _IDOrder = value; lbIDorder.Text = value; }
        }
        public string Date
        {
            get { return _Date; }
            set { _Date = value; lbDate.Text = value; }
        }
    }
}
