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
    public partial class CustomMessage : Form
    {
        public CustomMessage()
        {
            InitializeComponent();
        }

        static CustomMessage Msg;
        static DialogResult result = DialogResult.No;


        public static DialogResult Show(string text)
        {
            Msg = new CustomMessage();
            Msg.label1.Text = text;
            Msg.ShowDialog();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            Msg.Close();
        }
    }
}
