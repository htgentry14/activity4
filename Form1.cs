using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6activity4timeconverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 0;
            Int32.TryParse(textBox1.Text, out value);
            if (value < 60)
            {
                label1.Text = value.ToString();
            }
            if (value >= 60)
            {
                label1.Text = (value / 60).ToString();
            }
            if (seconds >= 86400)
            {
                int days = seconds / 86400;
                textBoxResult.Text = days + " days")
                    }
            else if (seconds >= 3600)
            {
                int hours = seconds / 3600;
                textBoxResult.Text = hours + " hours";
            }

        }
    }
}
