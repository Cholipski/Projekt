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
    public partial class ClientList : UserControl
    {
        public ClientList()
        {
            InitializeComponent();
        }

        public bool Female(string pesel)
        {
            if(Convert.ToInt32(pesel[9]) % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public void ShowClient(object _people)
        {
            var people = _people as List<Client>;
            ClientLayout[] clients = new ClientLayout[people.Count];
            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < clients.Length; i++)
            {
                clients[i] = new ClientLayout();
                clients[i].id = (people[i] as IClient).ClientID.ToString();
                clients[i].Name = people[i].FirstName.ToString() +" "+  people[i].LastName.ToString();
                clients[i].Pesel = people[i].Pesel.ToString();
                clients[i].Birthday = people[i].DateBirth.ToString("dd / MM / yyyy");
                clients[i].Discount = (people[i] as IClient).Discount.ToString();
                if (Female(clients[i].Pesel))
                {
                    Bitmap orginal = (Bitmap)Image.FromFile(@"..\..\Images\female_user_100px.png");
                    Bitmap resized = new Bitmap(orginal, new Size(150, 140));
                    clients[i].Icon = resized;
                }
                else
                {
                    Bitmap orginal = (Bitmap)Image.FromFile(@"..\..\Images\user_male_100px.png");
                    Bitmap resized = new Bitmap(orginal, new Size(150, 140));
                    clients[i].Icon = resized;
                }

                flowLayoutPanel1.Controls.Add(clients[i]);

            }

        }
    }
}
