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
    public partial class AddClient : UserControl
    {
        public Form1 Frm1 { get; set; } // Przypisanie formualrza do zmiennej (potrzebne aby odwołać się do List<T> które znajdują się w Form1
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Client tmp = new Client(tbFirstName.Text, tbLastName.Text, dateTimePicker1.Value, Convert.ToDouble(tbPesel.Text))
                {
                    ClientID = Frm1.people.Count + 1

                };

                tmp.Discount = Convert.ToInt32(tbDiscount.Text);
                Frm1.people.Add(tmp);
                CustomMessage.Show("Nowy Klient Dodany"); //Wyświetlenie okna dialogowego z informacją.
            }

        }


        public bool IsNumeric(string s)
        {
            return float.TryParse(s, out _);
        }

        // Sprawdzenie poprawności pola Imię 
        #region ValidateFirstName
        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbFirstName, "");
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if(!ValidFirstName(tbFirstName.Text, out errorMsg))
            {
                e.Cancel = true;
                tbFirstName.Select(0, tbFirstName.Text.Length);
                this.errorProvider1.SetError(tbFirstName, errorMsg);
            }
        }

        public bool ValidFirstName(string FirstName, out string errorMessage)
        {
            if(FirstName.Length < 3)
            {
                errorMessage = "Pole imię powinno zawierać conajmniej 3 znaki!";
                return false;
            }

            errorMessage = "";
            return true;
        }
        #endregion

        // Sprawdzenie poprawności pola Nazwisko 
        #region ValidateLastName

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbLastName, "");
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidateLastName(tbLastName.Text, out errorMsg))
            {
                e.Cancel = true;
                tbLastName.Select(0, tbLastName.Text.Length);
                this.errorProvider1.SetError(tbLastName, errorMsg);
            }
        }

        public bool ValidateLastName(string LastName, out string errorMessage)
        {
            if (LastName.Length < 3)
            {
                errorMessage = "Pole nazwisko powinno zawierać conajmniej 3 znaki!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        #endregion
        // Sprawdzenie poprawności pola Pesel 
        #region ValidatePesel

        private void tbPesel_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPesel, "");
        }

        private void tbPesel_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidatePesel(tbPesel.Text, out errorMsg))
            {
                e.Cancel = true;
                tbPesel.Select(0, tbPesel.Text.Length);
                this.errorProvider1.SetError(tbPesel, errorMsg);
            }
        }

        public bool ValidatePesel(string Pesel, out string errorMessage)
        {
            if (Pesel == "")
            {
                errorMessage = "Pole pesel nie może być puste";
                return false;
            }
            if (!IsNumeric(Pesel))
            {
                errorMessage = "Pole pesel może zawierać jedynie cyfry!";
                return false;
            }
            if(Pesel.Length != 11)
            {
                errorMessage = "Pole pesel musi zawierać 11 cyfr";
                return false;
            }
            
            errorMessage = "";
            return true;
        }

        #endregion
        // Sprawdzenie poprawności pola Zniżka 
        #region VlidateDiscount


        private void tbDiscount_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbDiscount, "");
        }

        private void tbDiscount_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidateDiscount(tbDiscount.Text, out errorMsg))
            {
                e.Cancel = true;
                tbDiscount.Select(0, tbDiscount.Text.Length);
                this.errorProvider1.SetError(tbDiscount, errorMsg);
            }
        }

        public bool ValidateDiscount(string discount, out string errorMessage)
        {
            if (!IsNumeric(discount))
            {
                errorMessage = "Pole zniżka może zawierać jedynie cyfry!";
                return false;
            }
            if(Convert.ToInt32(discount) < 0 || Convert.ToInt32(discount) > 100)
            {
                errorMessage = "Zniżka nie może być mniejsza niż 0 i większa niż 100";
                return false;
            }
            errorMessage = "";
            return true;

        }
        #endregion
    }
}
