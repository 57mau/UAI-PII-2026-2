namespace TP3
{
    partial class Ej01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_iniciar = new Button();
            SuspendLayout();
            // 
            // btn_iniciar
            // 
            btn_iniciar.Location = new Point(325, 200);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(125, 23);
            btn_iniciar.TabIndex = 0;
            btn_iniciar.Text = "Ingresar Numeros";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // Ej1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_iniciar);
            Name = "Ej1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion


        private Button btn_iniciar;
    }
}
