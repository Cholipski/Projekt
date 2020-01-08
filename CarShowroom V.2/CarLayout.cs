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
    public partial class CarLayout : UserControl
    {
        public CarLayout()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private string _Model;
        private string _MotorName;
        private string _NumCyl;
        private string _Fuel;
        private string _HorsePower;
        private string _Transmission;
        private string _Year;
        private string _FuelUsage;
        private string _MaxDistance_FuelTank;
        private string _ID;
        private string _Price;
        private Image _Icon;
        private string _Mark;
        private string _Age;

        public string Model
        {
            get { return _Model; }
            set { _Model = value; lbModel.Text = value; }
        }
        public string Mark
        {
            get { return _Mark; }
            set { _Mark = value; lbMark.Text = value; }
        }

        public string MotorName
        {
            get { return _MotorName; }
            set { _MotorName = value; lbMotorName.Text = value; }
        }

        public string NumCyl
        {
            get { return _NumCyl; }
            set { _NumCyl = value; lbNumCyl.Text = value; }
        }

        public string Fuel
        {
            get { return _Fuel; }
            set { _Fuel = value; lbFuel.Text = value; }
        }

        public string HorsePower
        {
            get { return _HorsePower; }
            set { _HorsePower = value; lbHorsePower.Text = value; }
        }

        public string Transmission
        {
            get { return _Transmission; }
            set { _Transmission = value; lbTransmission.Text = value; }
        }

        public string Year
        {
            get { return _Year; }
            set { _Year = value; lbYear.Text = value; }
        }
        public string Age
        {
            get { return _Age; }
            set { _Age = value; lbAge2.Text = value; }
        }

        public string FuelUsage
        {
            get { return _FuelUsage; }
            set { _FuelUsage = value; lbFuelUsage.Text = value; }
        }

        public string MaxDistance_FuelTank
        {
            get { return _MaxDistance_FuelTank; }
            set { _MaxDistance_FuelTank = value; lbMaxDistance_FuelTank.Text = value; }
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; lbID.Text = value; }
        }

        public string Price
        {
            get { return _Price; }
            set { _Price = value; lbPrice.Text = value; }
        }

        public List<string> Equipment { get; set; }

        public Image Icon
        {
            get { return _Icon; }
            set { _Icon = value; pictureBox1.Image = new Bitmap(value, new Size(148, 119)); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipmentList equipmentList = new EquipmentList(Equipment);
            equipmentList.Show();
        }
    }
}
