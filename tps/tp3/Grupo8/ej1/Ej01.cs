using Microsoft.VisualBasic;

namespace TP3
{
    public partial class Ej01 : Form
    {
        public Ej01()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            string numero1 = Interaction.InputBox("Ingrese el primer numero:");
            string numero2 = Interaction.InputBox("Ingrese el segundo numero:");

            int resultado = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);

            Interaction.MsgBox($"El resultado es: {resultado}");
        }
    }


}
