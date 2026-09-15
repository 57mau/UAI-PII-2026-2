namespace TP3
{
    partial class Ej07
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
            txtbox_monto = new TextBox();
            txtbox_TNA = new TextBox();
            txtbox_plazo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewPlazoFijo = new DataGridView();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlazoFijo).BeginInit();
            SuspendLayout();
            // 
            // txtbox_monto
            // 
            txtbox_monto.Location = new Point(181, 51);
            txtbox_monto.Name = "txtbox_monto";
            txtbox_monto.Size = new Size(100, 23);
            txtbox_monto.TabIndex = 0;
            // 
            // txtbox_TNA
            // 
            txtbox_TNA.Location = new Point(181, 116);
            txtbox_TNA.Name = "txtbox_TNA";
            txtbox_TNA.Size = new Size(100, 23);
            txtbox_TNA.TabIndex = 1;
            // 
            // txtbox_plazo
            // 
            txtbox_plazo.Location = new Point(181, 184);
            txtbox_plazo.Name = "txtbox_plazo";
            txtbox_plazo.Size = new Size(100, 23);
            txtbox_plazo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Monto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 124);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "TNA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 192);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Plazo";
            // 
            // dataGridViewPlazoFijo
            // 
            dataGridViewPlazoFijo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlazoFijo.Location = new Point(400, 51);
            dataGridViewPlazoFijo.Name = "dataGridViewPlazoFijo";
            dataGridViewPlazoFijo.Size = new Size(237, 156);
            dataGridViewPlazoFijo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(181, 261);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(132, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular Plazo Fijo";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // Ej7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(dataGridViewPlazoFijo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbox_plazo);
            Controls.Add(txtbox_TNA);
            Controls.Add(txtbox_monto);
            Name = "Ej7";
            Text = "Ej7";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlazoFijo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_monto;
        private TextBox txtbox_TNA;
        private TextBox txtbox_plazo;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewPlazoFijo;
        private Button btnCalcular;
    }
}