using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Ej07 : Form
    {
        public Ej07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewPlazoFijo.Rows.Clear();
            dataGridViewPlazoFijo.Columns.Add("Monto", "Monto");
            dataGridViewPlazoFijo.Columns.Add("TNA", "TNA");
            dataGridViewPlazoFijo.Columns.Add("Plazo", "Plazo");
            dataGridViewPlazoFijo.Columns.Add("Plazo_Fijo", "Plazo_Fijo");

            int monto = Convert.ToInt32(txtbox_monto.Text);
            float TNA = Convert.ToSingle(txtbox_TNA.Text);
            int plazo = Convert.ToInt32(txtbox_plazo.Text);

            float plazo_fijo = (monto * TNA * plazo) / 36500;

            dataGridViewPlazoFijo.Rows.Add(monto, TNA, plazo, plazo_fijo);
        }
    }
}

