namespace TP3
{
    partial class Ej09
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
            btnDados = new Button();
            dataGridViewResultados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).BeginInit();
            SuspendLayout();
            // 
            // btnDados
            // 
            btnDados.Location = new Point(210, 92);
            btnDados.Name = "btnDados";
            btnDados.Size = new Size(75, 23);
            btnDados.TabIndex = 0;
            btnDados.Text = "Tirar Dados";
            btnDados.UseVisualStyleBackColor = true;
            btnDados.Click += btnDados_Click;
            // 
            // dataGridViewResultados
            // 
            dataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultados.Location = new Point(445, 60);
            dataGridViewResultados.Name = "dataGridViewResultados";
            dataGridViewResultados.Size = new Size(240, 150);
            dataGridViewResultados.TabIndex = 1;
            // 
            // Ej9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewResultados);
            Controls.Add(btnDados);
            Name = "Ej9";
            Text = "Ej9";
            Load += Ej9_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDados;
        private DataGridView dataGridViewResultados;
    }
}