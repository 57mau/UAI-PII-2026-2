using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ej06 : Form
    {
        public Ej06()
        {
            InitializeComponent();
        }

        private void btnCalcularSerie_Click(object sender, EventArgs e)
        {

            listBoxSerie.Items.Clear();
            int num = Convert.ToInt32(textBox1.Text);

            long a = 0, b = 1;

            for (int i = 0; i < num; i++)
            {
                listBoxSerie.Items.Add(a);
                long siguiente = a + b;
                a = b;
                b = siguiente;

            }
        }
    }
}
