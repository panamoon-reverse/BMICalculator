using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cal_Button_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(w_textBox.Text);
            double height = double.Parse(h_textBox.Text);
            double BMI = Math.Round(weight / Math.Pow((height/100.0),2),2);

            BMI_num.Text = BMI.ToString();
        }
    }
}
