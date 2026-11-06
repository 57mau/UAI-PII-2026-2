namespace Ej_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TvArbol = new System.Windows.Forms.TreeView();
            this.TbDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddRaiz = new System.Windows.Forms.Button();
            this.BtnAddIzq = new System.Windows.Forms.Button();
            this.BtnAddDerecha = new System.Windows.Forms.Button();
            this.CmbRecorridos = new System.Windows.Forms.ComboBox();
            this.BtnRecorrer = new System.Windows.Forms.Button();
            this.LbResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TvArbol
            // 
            this.TvArbol.Location = new System.Drawing.Point(72, 213);
            this.TvArbol.Name = "TvArbol";
            this.TvArbol.Size = new System.Drawing.Size(245, 180);
            this.TvArbol.TabIndex = 0;
            // 
            // TbDato
            // 
            this.TbDato.Location = new System.Drawing.Point(72, 36);
            this.TbDato.Name = "TbDato";
            this.TbDato.Size = new System.Drawing.Size(100, 20);
            this.TbDato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // BtnAddRaiz
            // 
            this.BtnAddRaiz.Location = new System.Drawing.Point(72, 62);
            this.BtnAddRaiz.Name = "BtnAddRaiz";
            this.BtnAddRaiz.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRaiz.TabIndex = 3;
            this.BtnAddRaiz.Text = "Agregar raiz";
            this.BtnAddRaiz.UseVisualStyleBackColor = true;
            this.BtnAddRaiz.Click += new System.EventHandler(this.BtnAddRaiz_Click);
            // 
            // BtnAddIzq
            // 
            this.BtnAddIzq.Location = new System.Drawing.Point(72, 91);
            this.BtnAddIzq.Name = "BtnAddIzq";
            this.BtnAddIzq.Size = new System.Drawing.Size(75, 23);
            this.BtnAddIzq.TabIndex = 4;
            this.BtnAddIzq.Text = "Agregar izq";
            this.BtnAddIzq.UseVisualStyleBackColor = true;
            this.BtnAddIzq.Click += new System.EventHandler(this.BtnAddIzq_Click);
            // 
            // BtnAddDerecha
            // 
            this.BtnAddDerecha.Location = new System.Drawing.Point(72, 120);
            this.BtnAddDerecha.Name = "BtnAddDerecha";
            this.BtnAddDerecha.Size = new System.Drawing.Size(75, 23);
            this.BtnAddDerecha.TabIndex = 5;
            this.BtnAddDerecha.Text = "Agregar der";
            this.BtnAddDerecha.UseVisualStyleBackColor = true;
            this.BtnAddDerecha.Click += new System.EventHandler(this.BtnAddDerecha_Click);
            // 
            // CmbRecorridos
            // 
            this.CmbRecorridos.FormattingEnabled = true;
            this.CmbRecorridos.Items.AddRange(new object[] {
            "Preorden",
            "Inorden",
            "Postorden"});
            this.CmbRecorridos.Location = new System.Drawing.Point(483, 36);
            this.CmbRecorridos.Name = "CmbRecorridos";
            this.CmbRecorridos.Size = new System.Drawing.Size(121, 21);
            this.CmbRecorridos.TabIndex = 6;
            // 
            // BtnRecorrer
            // 
            this.BtnRecorrer.Location = new System.Drawing.Point(72, 149);
            this.BtnRecorrer.Name = "BtnRecorrer";
            this.BtnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.BtnRecorrer.TabIndex = 7;
            this.BtnRecorrer.Text = "Recorrer";
            this.BtnRecorrer.UseVisualStyleBackColor = true;
            this.BtnRecorrer.Click += new System.EventHandler(this.BtnRecorrer_Click);
            // 
            // LbResultado
            // 
            this.LbResultado.FormattingEnabled = true;
            this.LbResultado.Location = new System.Drawing.Point(483, 164);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(217, 238);
            this.LbResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.BtnRecorrer);
            this.Controls.Add(this.CmbRecorridos);
            this.Controls.Add(this.BtnAddDerecha);
            this.Controls.Add(this.BtnAddIzq);
            this.Controls.Add(this.BtnAddRaiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbDato);
            this.Controls.Add(this.TvArbol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TvArbol;
        private System.Windows.Forms.TextBox TbDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddRaiz;
        private System.Windows.Forms.Button BtnAddIzq;
        private System.Windows.Forms.Button BtnAddDerecha;
        private System.Windows.Forms.ComboBox CmbRecorridos;
        private System.Windows.Forms.Button BtnRecorrer;
        private System.Windows.Forms.ListBox LbResultado;
    }
}

