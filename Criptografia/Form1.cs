using System;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtLlave.Text != "" && txtLlave.Text.Length == 9)
            {
                double[,] llave = new double[3, 3];
                asignarLlave(ref llave);
                lblVerificación.Visible = true;
                lblVerificación.Text = (validaLlave(llave)) ? "Matriz valida" : "Matriz erronea";
                if (lblVerificación.Text.Equals("Matriz valida"))
                {
                    txtEncriptar.Enabled = true;
                    btnEncriptar.Enabled = true;
                    txtDesencriptar.Enabled = true;
                    btnDesencriptar.Enabled = true;
                }
                else //Cambiar con evento changeText
                {
                    txtEncriptar.Enabled = false;
                    btnEncriptar.Enabled = false;
                    txtDesencriptar.Enabled = false;
                    btnDesencriptar.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Palabra no valida");
            }
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            int cont = 0,f=0, c = txtEncriptar.Text.Length;
            string cadena = txtEncriptar.Text.ToLower();
            string linea;
            char[] textoEncriptar = new char[c];
            double[,] textoCodificado = new double[c/3,3];
            double[,] resultado = new double[c / 3, 3];
            double valor = 0;
            f = txtLlave.Lines.Length;
            c = txtLlave.Lines[0].Split(',').Length;
            double[,] llave = new double[f, c];
            for (int i = 0; i < f; i++)
            {
                linea = txtLlave.Lines[i].ToLower();

                for (int j = 0; j < c; j++)
                {
                    llave[i, j] = Convert.ToDouble(linea.Split(',')[j]);
                }
            }
            textoEncriptar = cadena.ToCharArray();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textoCodificado[i,j] = diccionario(textoEncriptar[cont]);
                   
                    cont++;
                }
            }

            cadena = "";
            for (int w = 0; w < 6; w++)
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        valor += textoCodificado[w,y] *  llave[y, x];
                        
                    }
                    cadena += resultado[w, x] + " ";
                    valor = 0;
                    
                }
            }

            txtResultado.Text = cadena;

        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            
        }

        //Metodo de validación de llave
        public bool validaLlave(double[,] llave)
        {
            double determinante = 0;

            determinante = (llave[0,0]* llave[1, 1]* llave[2, 2] + llave[0, 1]* llave[1, 2] * llave[2, 0] + llave[0, 2]* llave[1, 0] * llave[2, 1]) -
                (llave[2, 0]* llave[1, 1]* llave[0, 2]+ llave[2, 1]* llave[1, 2]* llave[0, 0]+ llave[2, 2]* llave[1, 0]* llave[0, 1]);
            if (determinante == 0)
            {
                return false;
            }
            return true;
        }
        public void asignarLlave(ref double[,] llave)
        {
            int cont = 0;
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    llave[f, c] = diccionario(txtLlave.Text.ToLower()[cont]);
                    cont++;
                }
            }
        }
        //Función diccionario
        public double diccionario(char caracter)
        {
            switch (caracter)
            {
                case 'a':
                    return 1;
                case 'b':
                    return 2;
                case 'c':
                    return 3;
                case 'd':
                    return 4;
               case 'e':
                    return 5;
                case 'f':
                    return 6;
                case 'g':
                    return 7;
                case 'h':
                    return 8;
                case 'i':
                    return 9;
                case 'j':
                    return 10;
                case 'k':
                    return 11;
                case 'l':
                    return 12;
                case 'm':
                    return 13;
                case 'n':
                    return 14;
                case 'ñ':
                    return 15;
                case 'o':
                    return 16;
                case 'p':
                    return 17;
                case 'q':
                    return 18;
                case 'r':
                    return 19;
                case 's':
                    return 20;
                case 't':
                    return 21;
                case 'u':
                    return 22;
                case 'v':
                    return 23;
                case 'w':
                    return 24;
                case 'x':
                    return 25;
                case 'y':
                    return 26;
                case 'z':
                    return 27;
                case ' ':
                    return 0;
                case '.':
                    return 28;
                default:
                    return -1;
            }
        }

        //Funcion diccionario N-L
        public string diccionario(double valor)
        {
            switch (valor)
            {
                case 1:
                    return "a";
                case 2:
                    return "b";
                case 3:
                    return "c";
                case 4:
                    return "d";
                case 5:
                    return "e";
                case 6:
                    return "f";
                case 7:
                    return "g";
                case 8:
                    return "h";
                case 9:
                    return "i";
                case 10:
                    return "j";
                case 11:
                    return "k";
                case 12:
                    return "l";
                case 13:
                    return "m";
                case 14:
                    return "n";
                case 15:
                    return "ñ";
                case 16:
                    return "o";
                case 17:
                    return "p";
                case 18:
                    return "q";
                case 19:
                    return "r";
                case 20:
                    return "s";
                case 21:
                    return "t";
                case 22:
                    return "u";
                case 23:
                    return "v";
                case 24:
                    return "w";
                case 25:
                    return "x";
                case 26:
                    return "y";
                case 27:
                    return "z";
                case 0:
                    return " ";
                case 28:
                    return ".";
                default:
                    return "@";
            }

        }
    }
}
