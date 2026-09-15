namespace TP3
{
    partial class Form2
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
            textBox_numero1 = new TextBox();
            textBox_numero2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label_resultado = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox_numero1
            // 
            textBox_numero1.Location = new Point(190, 119);
            textBox_numero1.Name = "textBox_numero1";
            textBox_numero1.Size = new Size(100, 23);
            textBox_numero1.TabIndex = 0;
            // 
            // textBox_numero2
            // 
            textBox_numero2.Location = new Point(450, 119);
            textBox_numero2.Name = "textBox_numero2";
            textBox_numero2.Size = new Size(100, 23);
            textBox_numero2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 101);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingresar el primer numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 101);
            label2.Name = "label2";
            label2.Size = new Size(155, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingresar el segundo numero";
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Location = new Point(335, 236);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(0, 15);
            label_resultado.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(190, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label_resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_numero2);
            Controls.Add(textBox_numero1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_numero1;
        private TextBox textBox_numero2;
        private Label label1;
        private Label label2;
        private Label label_resultado;
        private Button button1;
    }
}