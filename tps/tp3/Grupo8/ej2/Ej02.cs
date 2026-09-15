using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // This method is called when the form loads. You can add any initialization code here if needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_resultado.Text= "El resultado de la suma es " + (Convert.ToInt32(textBox_numero1.Text) + Convert.ToInt32(textBox_numero2.Text));
        }
    }


}
