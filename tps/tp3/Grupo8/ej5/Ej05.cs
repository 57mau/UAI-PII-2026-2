using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ej05 : Form
    {
        public Ej05()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num_minimo = Convert.ToInt32(textBoxMinimo.Text);
            int num_maximo = Convert.ToInt32(textBoxMaximo.Text);

            

            for (int num = num_minimo; num <= num_maximo; num++)
            {

                bool esPrimo = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    listBox_Numeros.Items.Add(num);
                }

            }
        }
    }
}
