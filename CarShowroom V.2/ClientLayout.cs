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
    public partial class ClientLayout : UserControl
    {

        public ClientLayout()
        {
            InitializeComponent();
        }

        private string _id;
        private string _Name;
        private string _Pesel;
        private string _Birthday;
        private string _Discount; 
        private Image _Icon;

        public string id
        {
            get { return _id; }
            set { _id = value; lbID.Text = value; }
        }
        public new string Name
        {
            get { return _Name; }
            set { _Name = value; lbName.Text = value; }
        }

        public string Pesel
        {
            get { return _Pesel; }
            set { _Pesel = value; lbPesel.Text = value; }
        }
        public string Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; lbbirthday.Text = value; }
        }
        public string Discount
        {
            get { return _Discount; }
            set { _Discount = value; lbDiscount.Text = value; }
        }
        public Image Icon
        {
            get { return _Icon; }
            set { _Icon = value; pictureBox1.Image = value; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClientLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
