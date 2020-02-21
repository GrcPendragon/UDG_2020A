namespace Ejemplo_Ciclos
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnInversa = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.SystemColors.Window;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(12, 65);
            this.txtN.Margin = new System.Windows.Forms.Padding(5);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(270, 170);
            this.txtN.TabIndex = 0;
            this.txtN.Text = "3,1,0\r\n1,-2,1\r\n4,1,2";
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInversa
            // 
            this.btnInversa.Location = new System.Drawing.Point(317, 65);
            this.btnInversa.Name = "btnInversa";
            this.btnInversa.Size = new System.Drawing.Size(75, 23);
            this.btnInversa.TabIndex = 1;
            this.btnInversa.Text = "Inversa";
            this.btnInversa.UseVisualStyleBackColor = true;
            this.btnInversa.Click += new System.EventHandler(this.btnInversa_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(317, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInversa);
            this.Controls.Add(this.txtN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnInversa;
        private System.Windows.Forms.Button btnSalir;
    }
}

