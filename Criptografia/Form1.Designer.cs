namespace Criptografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblVerificación = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncriptar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesencriptar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(27, 54);
            this.txtLlave.MaxLength = 9;
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(162, 20);
            this.txtLlave.TabIndex = 0;
            this.txtLlave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la palabra clave de 9 caracteres";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(195, 51);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(94, 23);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Confirmar matriz";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblVerificación
            // 
            this.lblVerificación.AutoSize = true;
            this.lblVerificación.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificación.Location = new System.Drawing.Point(192, 85);
            this.lblVerificación.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblVerificación.Name = "lblVerificación";
            this.lblVerificación.Size = new System.Drawing.Size(44, 17);
            this.lblVerificación.TabIndex = 3;
            this.lblVerificación.Text = "Valida";
            this.lblVerificación.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVerificación.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncriptar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEncriptar);
            this.groupBox1.Location = new System.Drawing.Point(27, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encriptar";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Enabled = false;
            this.btnEncriptar.Location = new System.Drawing.Point(9, 152);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(134, 23);
            this.btnEncriptar.TabIndex = 5;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Texto a encriptar";
            // 
            // txtEncriptar
            // 
            this.txtEncriptar.Enabled = false;
            this.txtEncriptar.Location = new System.Drawing.Point(9, 46);
            this.txtEncriptar.Multiline = true;
            this.txtEncriptar.Name = "txtEncriptar";
            this.txtEncriptar.Size = new System.Drawing.Size(134, 100);
            this.txtEncriptar.TabIndex = 5;
            this.txtEncriptar.Text = "Flipped Classroom.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDesencriptar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDesencriptar);
            this.groupBox2.Location = new System.Drawing.Point(254, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 189);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desencriptar";
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Enabled = false;
            this.btnDesencriptar.Location = new System.Drawing.Point(9, 152);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(134, 23);
            this.btnDesencriptar.TabIndex = 5;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Texto a desencriptar";
            // 
            // txtDesencriptar
            // 
            this.txtDesencriptar.Enabled = false;
            this.txtDesencriptar.Location = new System.Drawing.Point(9, 46);
            this.txtDesencriptar.Multiline = true;
            this.txtDesencriptar.Name = "txtDesencriptar";
            this.txtDesencriptar.Size = new System.Drawing.Size(134, 100);
            this.txtDesencriptar.TabIndex = 5;
            this.txtDesencriptar.Text = "24 9 42 27 22 68 10 11 4 52 43 15 52 37 77 72 47 55";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Texto resultante";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(27, 382);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(379, 55);
            this.txtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVerificación);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLlave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codificador de textos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblVerificación;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncriptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesencriptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

