using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ej08 : Form
    {
        public Ej08()
        {
            InitializeComponent();
        }

        private void btnDado_Click(object sender, EventArgs e)
        {
            int resultado = new Random().Next(1, 7);
            lblResultado.Text = ("Salio: " + resultado.ToString());
        }
    }
}
