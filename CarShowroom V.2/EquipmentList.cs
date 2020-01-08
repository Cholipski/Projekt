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
    public partial class EquipmentList : Form
    {
        private List<string> equipment;
        public EquipmentList(object p)
        {
            InitializeComponent();
            equipment = p as List<string>;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Funkcja wyświetlająca listę wyposażenie (używając kontrolki listview)
        private void show()
        {
            int i = 1;
            foreach (var obj in equipment)
            {
                var row = new string[] { i.ToString(),obj.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = obj;
                i++;
                listView1.Items.Add(lvi);
            }
        }

        private void EquipmentList_Load(object sender, EventArgs e)
        {
            try
            {
                show();
            }
            catch (System.NullReferenceException)
            {
                listView1.Visible = false;
                label1.Visible = true;
            }
        }
    }
}
