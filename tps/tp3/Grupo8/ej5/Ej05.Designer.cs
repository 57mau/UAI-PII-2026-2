namespace TP3
{
    partial class Ej05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMinimo = new TextBox();
            textBoxMaximo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalcular = new Button();
            listBox_Numeros = new ListBox();
            SuspendLayout();
            // 
            // textBoxMinimo
            // 
            textBoxMinimo.Location = new Point(219, 69);
            textBoxMinimo.Name = "textBoxMinimo";
            textBoxMinimo.Size = new Size(100, 23);
            textBoxMinimo.TabIndex = 0;
            // 
            // textBoxMaximo
            // 
            textBoxMaximo.Location = new Point(219, 138);
            textBoxMaximo.Name = "textBoxMaximo";
            textBoxMaximo.Size = new Size(100, 23);
            textBoxMaximo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 77);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Numero minimo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 141);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero maximo";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(378, 94);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(124, 50);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Mostrar Numeros Primos";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // listBox_Numeros
            // 
            listBox_Numeros.FormattingEnabled = true;
            listBox_Numeros.Location = new Point(575, 77);
            listBox_Numeros.Name = "listBox_Numeros";
            listBox_Numeros.Size = new Size(120, 94);
            listBox_Numeros.TabIndex = 5;
            // 
            // Ej5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox_Numeros);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMaximo);
            Controls.Add(textBoxMinimo);
            Name = "Ej5";
            Text = "Ej5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMinimo;
        private TextBox textBoxMaximo;
        private Label label1;
        private Label label2;
        private Button btnCalcular;
        private ListBox listBox_Numeros;
    }
}