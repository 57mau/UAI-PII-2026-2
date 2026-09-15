namespace TP3
{
    partial class Ej08
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
            btnDado = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnDado
            // 
            btnDado.AllowDrop = true;
            btnDado.Location = new Point(287, 102);
            btnDado.Name = "btnDado";
            btnDado.Size = new Size(87, 23);
            btnDado.TabIndex = 0;
            btnDado.Text = "Tirar Dado";
            btnDado.UseVisualStyleBackColor = true;
            btnDado.Click += btnDado_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(287, 164);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 1;
            // 
            // Ej8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnDado);
            Name = "Ej8";
            Text = "Ej8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDado;
        private Label lblResultado;
    }
}