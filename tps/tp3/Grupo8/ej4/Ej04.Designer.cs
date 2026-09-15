namespace TP3
{
    partial class Ej04
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
            textBox_N1 = new TextBox();
            textBox_N2 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnDivision = new Button();
            btnMultiplicar = new Button();
            btnPotencia = new Button();
            btnRaiz = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // textBox_N1
            // 
            textBox_N1.Location = new Point(234, 49);
            textBox_N1.Name = "textBox_N1";
            textBox_N1.Size = new Size(100, 23);
            textBox_N1.TabIndex = 0;
            // 
            // textBox_N2
            // 
            textBox_N2.Location = new Point(234, 92);
            textBox_N2.Name = "textBox_N2";
            textBox_N2.Size = new Size(100, 23);
            textBox_N2.TabIndex = 1;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(353, 48);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(90, 23);
            btnSuma.TabIndex = 2;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(353, 92);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(90, 23);
            btnResta.TabIndex = 3;
            btnResta.Text = "Restar";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(455, 92);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(90, 23);
            btnDivision.TabIndex = 4;
            btnDivision.Text = "Division";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(455, 48);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(90, 23);
            btnMultiplicar.TabIndex = 5;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.Location = new Point(558, 48);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(90, 23);
            btnPotencia.TabIndex = 6;
            btnPotencia.Text = "Potencia";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(558, 92);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(90, 23);
            btnRaiz.TabIndex = 7;
            btnRaiz.Text = "Raiz ";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 56);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 8;
            label1.Text = "Ingrese el primer numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 100);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 9;
            label2.Text = "Ingrese el segundo numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 150);
            label3.Name = "label3";
            label3.Size = new Size(166, 15);
            label3.TabIndex = 10;
            label3.Text = "El resultado de la operacion es";
            label3.Click += label3_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(234, 150);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 11;
            // 
            // Ej4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRaiz);
            Controls.Add(btnPotencia);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDivision);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(textBox_N2);
            Controls.Add(textBox_N1);
            Name = "Ej4";
            Text = "Ej4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_N1;
        private TextBox textBox_N2;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDivision;
        private Button btnMultiplicar;
        private Button btnPotencia;
        private Button btnRaiz;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultado;
    }
}