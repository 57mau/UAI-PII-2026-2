using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ej09 : Form
    {
        int[] conteo = new int[7];
        Random random = new Random();
        int totalNumerosTirados = 0;
        public Ej09()
        {
            InitializeComponent();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
           
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);
            conteo[dado1]++;
            conteo[dado2]++;
            totalNumerosTirados += 2;

            for (int i = 1; i <= 6; i++)
            {
                int indice_fila = i - 1; 
                int cantidad = conteo[i];
                double porcentaje = ((double)cantidad / totalNumerosTirados) * 100.0;

                dataGridViewResultados.Rows[indice_fila].Cells[1].Value = cantidad;
                dataGridViewResultados.Rows[indice_fila].Cells[2].Value = porcentaje.ToString("0.00") + " %";
            }

        }


        private void Ej9_Load(object sender, EventArgs e)
        {
            dataGridViewResultados.Columns.Add("colNumero", "Número");
            dataGridViewResultados.Columns.Add("colCantidad", "Cantidad");
            dataGridViewResultados.Columns.Add("colPorcentaje", "Porcentaje (%)");

            for (int i = 1; i <= 6; i++)
            {
                dataGridViewResultados.Rows.Add(i, 0, "0.00 %");
            }
        }
    }

}
