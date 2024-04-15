using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace pr5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTax();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateTax();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTax();
        }

        private void CalculateTax()
        {
            if (double.TryParse(textBox1.Text, out double income))
            {
                double taxPercentage = 0;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        taxPercentage = 0.10;
                        break;
                    case 1:
                        taxPercentage = 0.20;
                        break;
                    case 2:
                        taxPercentage = 0.15;
                        break;
                    default:
                        break;
                }

                double tax = income * taxPercentage + 1760;

                label1.Text = $"Сума податку: {tax.ToString("C")}";
            }
            else
            {
                label1.Text = "Введіть коректну суму доходу";
            }
        }
    }
}
