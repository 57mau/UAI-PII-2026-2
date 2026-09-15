using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ej10 : Form
    {
        public Ej10()
        {
            InitializeComponent();
        }

        private void Ej10_Load(object sender, EventArgs e)
        {
            dataGridViewTemperaturas.Columns.Add("Temperatura Inicial", "Temperatura Inicial");
            dataGridViewTemperaturas.Columns.Add("Escala Inicial", "Escala Inicial");
            dataGridViewTemperaturas.Columns.Add("Escala Final", "Escala Final");
            dataGridViewTemperaturas.Columns.Add("Temperatura Final", "Temperatura Final");


            comboBoxOrigen.Items.Add("Celsius");
            comboBoxOrigen.Items.Add("Fahrenheit");
            comboBoxOrigen.Items.Add("Kelvin");
            comboBoxOrigen.Items.Add("Rankine");

            comboBoxDestino.Items.Add("Celsius");
            comboBoxDestino.Items.Add("Fahrenheit");
            comboBoxDestino.Items.Add("Kelvin");
            comboBoxDestino.Items.Add("Rankine");
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            float valor = Convert.ToSingle(textBox1.Text);

            string escala_inicial = comboBoxOrigen.SelectedItem.ToString();
            string escala_final = comboBoxDestino.SelectedItem.ToString();
            double celsius = 0.0;


            switch (escala_inicial)
            {
                case "Celsius":
                    celsius = valor;
                    break;

                case "Fahrenheit":
                    celsius = (valor - 32) * 5 / 9;
                    break;

                case "Kelvin":
                    celsius = valor - 273.15;
                    break;

                case "Rankine":
                    celsius = (valor - 491.67) * 5 / 9;
                    break;
            }

            double resultado = 0.0;

            switch (escala_final)
            {
                case "Celsius":
                    resultado = celsius;
                    break;
                case "Fahrenheit":
                    resultado = (celsius * 9 / 5) + 32;
                    break;
                case "Kelvin":
                    resultado = celsius + 273.15;
                    break;
                case "Rankine":
                    resultado = (celsius + 273.15) * 9 / 5;
                    break;

            }

            dataGridViewTemperaturas.Rows.Add(valor.ToString("0.##"), escala_inicial, escala_final, resultado.ToString("0.##"));

        }

    }
}





