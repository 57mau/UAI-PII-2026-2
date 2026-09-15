using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ej04 : Form
    {
        public Ej04()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            int num1 = Convert.ToInt32(textBox_N1.Text);
            int num2 = Convert.ToInt32(textBox_N2.Text);

            lblResultado.Text = (num1 + num2).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            int num1 = Convert.ToInt32(textBox_N1.Text);
            int num2 = Convert.ToInt32(textBox_N2.Text);

            lblResultado.Text = (num1 * num2).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            int num1 = Convert.ToInt32(textBox_N1.Text);
            int num2 = Convert.ToInt32(textBox_N2.Text);

            lblResultado.Text = (num1 - num2).ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            int num1 = Convert.ToInt32(textBox_N1.Text);
            int num2 = Convert.ToInt32(textBox_N2.Text);

            lblResultado.Text = (num1 / num2).ToString();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            int num1 = Convert.ToInt32(textBox_N1.Text);
            int num2 = Convert.ToInt32(textBox_N2.Text);

            int resultado = 1;

            for (int i = 0; i < num2; i++)
            {
                resultado *= num1;
            }

            lblResultado.Text = resultado.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            int num1 = Convert.ToInt32(textBox_N1.Text);
            int num2 = Convert.ToInt32(textBox_N2.Text);

            double resultado = Math.Pow(num1, 1.0 / num2);
            lblResultado.Text = resultado.ToString();
        }
    }
}
