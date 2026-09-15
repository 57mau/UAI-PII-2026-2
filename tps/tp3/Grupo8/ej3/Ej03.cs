using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ej03 : Form
    {
        public Ej03()
        {
            InitializeComponent();
        }

        private void Ej3_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
             int cantidad = Convert.ToInt32(textBox1.Text);
            int suma = 0;
            string listanumeros = "";

            for (int i = 0; i < cantidad; i++)
            {
                string entrada = Interaction.InputBox("Ingrese el numero " + (i + 1) + ":", "Carga de numeros");
                int num = Convert.ToInt32(entrada);
                suma += num;
                listanumeros += num + "- ";
            }

            textBox1.Text = listanumeros;
            label2.Text= "Suma total: " + suma;
        }
    }
}
