namespace TP3
{
    partial class Ej10
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
            dataGridViewTemperaturas = new DataGridView();
            btnTransformar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBoxOrigen = new ComboBox();
            comboBoxDestino = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTemperaturas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTemperaturas
            // 
            dataGridViewTemperaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTemperaturas.Location = new Point(450, 67);
            dataGridViewTemperaturas.Name = "dataGridViewTemperaturas";
            dataGridViewTemperaturas.Size = new Size(240, 162);
            dataGridViewTemperaturas.TabIndex = 0;
            // 
            // btnTransformar
            // 
            btnTransformar.Location = new Point(341, 206);
            btnTransformar.Name = "btnTransformar";
            btnTransformar.Size = new Size(88, 23);
            btnTransformar.TabIndex = 1;
            btnTransformar.Text = "Transformar";
            btnTransformar.UseVisualStyleBackColor = true;
            btnTransformar.Click += btnCelsius_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 114);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese la temperatura a transformar";
            // 
            // comboBoxOrigen
            // 
            comboBoxOrigen.FormattingEnabled = true;
            comboBoxOrigen.Location = new Point(49, 206);
            comboBoxOrigen.Name = "comboBoxOrigen";
            comboBoxOrigen.Size = new Size(121, 23);
            comboBoxOrigen.TabIndex = 7;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(194, 206);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(121, 23);
            comboBoxDestino.TabIndex = 8;
            // 
            // Ej10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxOrigen);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnTransformar);
            Controls.Add(dataGridViewTemperaturas);
            Name = "Ej10";
            Text = "Ej10";
            Load += Ej10_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTemperaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTemperaturas;
        private Button btnTransformar;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBoxOrigen;
        private ComboBox comboBoxDestino;
    }
}