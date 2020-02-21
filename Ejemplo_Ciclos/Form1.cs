using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInversa_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[3, 3];
            double[,] matrizIdent = { 
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 } 
            };

            for (int i = 0; i < 3; i++)
            {
                String cadena = txtN.Lines[i];
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = Convert.ToDouble(cadena.Split(',')[j]);
                }
            }

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (f == c)
                    {
                        double piv = 1 / matriz[f, c];
                        for (int i = 0; i < 3; i++)
                        {
                            matriz[f, i] *= piv;
                            matrizIdent[f, i] *= piv;
                        }

                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
