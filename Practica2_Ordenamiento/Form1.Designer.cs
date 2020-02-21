namespace Practica2_Ordenamiento
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnOrdena = new System.Windows.Forms.Button();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadenas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(43, 223);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(368, 139);
            this.txtResultado.TabIndex = 0;
            // 
            // btnOrdena
            // 
            this.btnOrdena.Location = new System.Drawing.Point(336, 135);
            this.btnOrdena.Name = "btnOrdena";
            this.btnOrdena.Size = new System.Drawing.Size(75, 23);
            this.btnOrdena.TabIndex = 1;
            this.btnOrdena.Text = "Ordenar palabras";
            this.btnOrdena.UseVisualStyleBackColor = true;
            this.btnOrdena.Click += new System.EventHandler(this.btnOrdena_Click);
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Location = new System.Drawing.Point(40, 41);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(258, 13);
            this.lblIndicaciones.TabIndex = 2;
            this.lblIndicaciones.Text = "Separando por comas, ingresa las palabras a ordenar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // txtCadenas
            // 
            this.txtCadenas.Location = new System.Drawing.Point(43, 82);
            this.txtCadenas.Multiline = true;
            this.txtCadenas.Name = "txtCadenas";
            this.txtCadenas.Size = new System.Drawing.Size(368, 47);
            this.txtCadenas.TabIndex = 4;
            this.txtCadenas.Text = "casa, arbol, zapato, escuela, mochila, bosque, dado, ventana, horno, camion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.txtCadenas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.btnOrdena);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Ordenador de palabras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnOrdena;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadenas;
    }
}

