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
    public partial class AddCar : UserControl
    {
        private Bitmap _Picture;
        public Form1 Frm2 { get; set; } // Przypisanie formualrza do zmiennej (potrzebne aby odwołać się do List<T> które znajdują się w Form1
        public AddCar()
        {
            InitializeComponent();
           

        }

        public Bitmap Picture
        {
            set { this._Picture = value; }
            get { return _Picture; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Załącza zdjęcie ze wskazanego pliku
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
"All files (*.*)|*.*",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               Bitmap picture = new Bitmap(openFileDialog1.FileName);
               Bitmap resized = new Bitmap(picture, new Size(200, 144));
               pictureBox1.Image = resized;
                _Picture = picture;
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var checked_boxes = groupBox1.Controls.OfType<CheckBox>().Where(c => c.Checked).Select(c => c.Text).ToList(); // LINQ tworzący listę nazw checkbox które są zaznaczone

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (cbMark.Text == "Audi")
                {
                    Audi car = new Audi(
                        Convert.ToDouble(tbPrice.Text),
                        tbModel.Text,
                        Convert.ToInt32(tbHorsePower.Text),
                        tbMotorName.Text,
                        Convert.ToInt32(tbNumCyl.Text),
                        (Fuel)Enum.Parse(typeof(Fuel),
                        cbFuel.Text),
                        Convert.ToDouble(tbFuelU.Text),
                        Convert.ToInt32(numericYear.Value),
                        Convert.ToInt32(tbFuelTank.Text),
                        (Transmisson)Enum.Parse(typeof(Transmisson),
                        cbTransmisson.Text),
                        _Picture
                        );
                    car.ID = Frm2.Cars.Count + 1;
                    car._Equipment = checked_boxes;
                    Frm2.Cars.Add(car);
                }
                if (cbMark.Text == "Volkswagen")
                {
                    Volkswagen car = new Volkswagen(
                        Convert.ToDouble(tbPrice.Text),
                        tbModel.Text,
                        Convert.ToInt32(tbHorsePower.Text),
                        tbMotorName.Text,
                        Convert.ToInt32(tbNumCyl.Text),
                        (Fuel)Enum.Parse(typeof(Fuel),
                        cbFuel.Text),
                        Convert.ToDouble(tbFuelU.Text),
                        Convert.ToInt32(numericYear.Value),
                        Convert.ToInt32(tbFuelTank.Text),
                        (Transmisson)Enum.Parse(typeof(Transmisson),
                        cbTransmisson.Text),
                        _Picture
                        );
                    car.ID = Frm2.Cars.Count + 1;
                    car._Equipment = checked_boxes;
                    Frm2.Cars.Add(car);
                }
                CustomMessage.Show("Pojazd dodany"); // Wyświetlenie okna dialogowego z informacją
            }

            


        }

        public bool IsNumeric(string s)
        {
            return float.TryParse(s, out _);
        }

        public bool IsEmpty(string s)
        {
            return s == null | s == "" ? true : false;
        }

        public bool IsEmpty_Validate(string x, out string errorMessage)
        {
            if (IsEmpty(x))
            {
                errorMessage = "Pole nie może być puste";
                return false;
            }

            errorMessage = "";
            return true;
        }

        public bool IsEmpty_IsNumeric_Validate(string v1, out string errorMessage)
        {
            if (IsEmpty(v1))
            {
                errorMessage = "Pole nie może być puste";
                return false;
            }
            else if (!IsNumeric(v1))
            {
                errorMessage = "Pole moze zawierać jedynie liczby";
                return false;
            }

            errorMessage = "";
            return true;

        }

        #region cbMarkValidate

        private void cbMark_Validated(object sender, EventArgs e)
        {
            errorProvider_cbMark.SetError(cbMark, "");
        }

        private void cbMark_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_Validate(cbMark.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_cbMark.SetError(cbMark, errorMsg);
            }
        }
        #endregion


        #region tbModelValidate

        private void tbModel_Validated(object sender, EventArgs e)
        {
            errorProvider_tbModel.SetError(tbModel, "");
        }

        private void tbModel_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_Validate(tbModel.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_tbModel.SetError(tbModel, errorMsg);
            }
        }

        #endregion

        #region tbPricValidate

        private void tbPrice_Validated(object sender, EventArgs e)
        {
            errorProvider_tbPrice.SetError(tbPrice, "");

        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_IsNumeric_Validate(tbPrice.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_tbPrice.SetError(tbPrice, errorMsg);
            }
        }

        
        #endregion


        #region tbHorsePowerValidate
        private void tbHorsePower_Validated(object sender, EventArgs e)
        {
            errorProvider_tbHP.SetError(tbHorsePower, "");
        }

        private void tbHorsePower_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_IsNumeric_Validate(tbHorsePower.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_tbHP.SetError(tbHorsePower, errorMsg);
            }
        }
        #endregion

        #region cbFuelValidate

        private void cbFuel_Validated(object sender, EventArgs e)
        {
            errorProvider_cbFuel.SetError(cbFuel, "");
        }

        private void cbFuel_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_Validate(cbFuel.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_cbFuel.SetError(cbFuel, errorMsg);
            }
        }

        #endregion

        #region tbFuelTankValidate
        private void tbFuelTank_Validated(object sender, EventArgs e)
        {
            errorProvider_tbFuelTank.SetError(tbFuelTank, "");
        }

        private void tbFuelTank_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_IsNumeric_Validate(tbFuelTank.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_tbFuelTank.SetError(tbFuelTank, errorMsg);
            }
        }
        #endregion

        #region tbFuelconsumptionValidate

        private void tbFuelU_Validated(object sender, EventArgs e)
        {
            errorProvider_tbFuelU.SetError(tbFuelU, "");
        }

        private void tbFuelU_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_IsNumeric_Validate(tbFuelU.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_tbFuelU.SetError(tbFuelU, errorMsg);
            }
        }
        #endregion

        #region tbMotorNameValidate

        private void tbMotorName_Validated(object sender, EventArgs e)
        {
            errorProvider2_tbMotorName.SetError(tbMotorName, "");
        }

        private void tbMotorName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_Validate(tbMotorName.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider2_tbMotorName.SetError(tbMotorName, errorMsg);
            }
        }
        #endregion

        #region tbNumCylValidate

        private void tbNumCyl_Validated(object sender, EventArgs e)
        {
            errorProvider_tbNumCyl.SetError(tbNumCyl, "");

        }

        private void tbNumCyl_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_IsNumeric_Validate(tbNumCyl.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_tbNumCyl.SetError(tbNumCyl, errorMsg);
            }
        }
        #endregion

        #region cbtransmissionValidate
        private void cbTransmisson_Validated(object sender, EventArgs e)
        {
            errorProvider_cbTransmission.SetError(cbTransmisson, "");

        }

        private void cbTransmisson_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!IsEmpty_Validate(cbTransmisson.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider_cbTransmission.SetError(cbTransmisson, errorMsg);
            }
        }
        #endregion
    }
}
