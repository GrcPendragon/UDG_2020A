using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_Ordenamiento
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public String Ordenamiento(String []arreglo)
        {
            String temp;
            String cadenas = "";
            for (int f = 0; f < arreglo.Length-1; f++)
            {
                    for (int piv = f + 1; piv < arreglo.Length; piv++)
                    {
                        if (arreglo[f].CompareTo(arreglo[piv]) > 0)
                        {
                            temp = arreglo[f];
                            arreglo[f] = arreglo[piv];
                            arreglo[piv] = temp;
                            
                        }
                    }
                
                cadenas += arreglo[f] + Environment.NewLine;
            }
            cadenas += arreglo[arreglo.Length - 1];
            return cadenas;
        }

        private void btnOrdena_Click(object sender, EventArgs e)
        {
            string cadenas = txtCadenas.Text.Replace(" ","");
            string[] palabras = cadenas.Split(',');

            txtResultado.Text = Ordenamiento(palabras);
        }
    }
}
