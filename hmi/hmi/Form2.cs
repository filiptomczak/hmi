using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmi
{
    public partial class Form2 : Form
    {
        public delegate void ValueCallback(string data);
        public ValueCallback valueCallback;
        public Form2()
        {
            InitializeComponent();
        }
        private void Button_apply_Click(object sender, EventArgs e)
        {
            int min = Int16.Parse(textBox_min.Text);
            int max = Int16.Parse(textBox_max.Text);
            int d = Int16.Parse(textBox_d.Text);
            int skala = Int16.Parse(textBox_skala.Text);
            string unit = textBox_unit.Text;
            string com = textBox_com.Text;
            int baud = Int16.Parse(textBox_baud.Text);
            string text = min + ", " + max + ", " + d + ", " + skala + ", " + unit + ", " + com + ", " + baud;
            if(valueCallback != null)
                valueCallback(text);
            this.Close();
        }
    }
}
