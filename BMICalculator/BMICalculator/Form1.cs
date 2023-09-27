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

            string bmi_text = "";

            if (BMI >= 30)
            {
                bmi_text = "Extreamely Obese";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                bmi_text = "Obese";
            }
            else if (BMI >= 23 && BMI < 25)
            {
                bmi_text = "Overweight";
            }
            else if (BMI >= 18.5 && BMI < 23)
            {
                bmi_text = "Normal";
            }
            else if (BMI > 0 && BMI < 18.5)
            {
                bmi_text = "Underweight";
            }
            else
            {
                MessageBox.Show("Something wrong, Please try again!");
            }

            BMI_num.Text = BMI.ToString();
            BMI_text.Text = bmi_text;
        }
    }
}
