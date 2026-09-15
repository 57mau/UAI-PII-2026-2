namespace TP3
{
    partial class Ej06
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
            btnCalcularSerie = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBoxSerie = new ListBox();
            SuspendLayout();
            // 
            // btnCalcularSerie
            // 
            btnCalcularSerie.Location = new Point(410, 77);
            btnCalcularSerie.Name = "btnCalcularSerie";
            btnCalcularSerie.Size = new Size(140, 23);
            btnCalcularSerie.TabIndex = 0;
            btnCalcularSerie.Text = "Serie de Fibonacci";
            btnCalcularSerie.UseVisualStyleBackColor = true;
            btnCalcularSerie.Click += btnCalcularSerie_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 81);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 2;
            label1.Text = "Cuantos numeros desea calcular";
            // 
            // listBoxSerie
            // 
            listBoxSerie.FormattingEnabled = true;
            listBoxSerie.Location = new Point(410, 127);
            listBoxSerie.Name = "listBoxSerie";
            listBoxSerie.Size = new Size(120, 94);
            listBoxSerie.TabIndex = 3;
            // 
            // Ej6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxSerie);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnCalcularSerie);
            Name = "Ej6";
            Text = "Ej6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularSerie;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBoxSerie;
    }
}