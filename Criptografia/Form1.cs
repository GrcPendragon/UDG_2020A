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
            string cadena = txtLlave.Text;
            if (cadena != "")
            {
                
                double[,] llave = new double[3, 3];
                
                if (cadena.Length < 9)
                {
                    cadena = ponerVacios(cadena);
                }
                asignarLlave(ref llave, cadena);
                lblVerificación.Visible = true;
                lblVerificación.Text = (validaLlave(llave)) ? "Palabra valida" : "Palabra erronea";
                if (lblVerificación.Text.Equals("Palabra valida"))
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
            int filas = txtEncriptar.Text.Length, cont = 0;
            string cadena = "";
            double valor = 0;
            double[,] llave = new double[3, 3];
            filas = filas % 3 > 0 ? filas / 3 + 1 : filas / 3;
            double[,] textoCod = new double[filas, 3];
            //Completar la cadena llave con ceros si su longitud es menor a 9
            if (cadena.Length < 9)
            {
                cadena = ponerVacios(txtLlave.Text);
            }
            asignarLlave(ref llave, cadena);

            cadena = txtEncriptar.Text;
            //Completar la cadena de encriptación en ceros si su longitud es mayor a 0
            if (cadena.Length % 3 > 0)
            {
                cadena = ponerVacios(txtEncriptar);
            }
            //Asignacion de los caractes a encriptar a un arreglo numerico
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    textoCod[f, c] = diccionario(cadena[cont++]);
                }
            } 
            //Fragmento de codigo que encriptador
            cadena = "";
            for (int f = 0; f < filas; f++)
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        valor += textoCod[f, y] * llave[y, x];

                    }
                    cadena += valor + " ";
                    valor = 0;
                }
            }

            txtResultado.Text = cadena.Trim();

        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesencriptar.Text.Split(' ').Length % 3 > 0)
                {
                    MessageBox.Show("Lo sentimos le faltan datos a su mensaje.");
                    return;
                }                
                int filas = txtDesencriptar.Text.Split(' ').Length, cont = 0;
                filas = filas % 3 > 0 ? filas / 3 + 1 : filas / 3;
                string cadena = "";
                string[] cadenDesencriptar = txtDesencriptar.Text.Split(' ');
                double valor = 0;
                double[,] llave = new double[3, 3];
                double[,] textoDes = new double[filas, 3];
                double[,] identidad = { {1,0,0}, {0,1,0}, {0,0,1} };

                //Completar la cadena llave con ceros si su longitud es menor a 9
                if (cadena.Length < 9)
                {
                    cadena = ponerVacios(txtLlave.Text);
                }
                asignarLlave(ref llave, cadena);

                for (int p = 0; p < 3; p++)   //pivote
                {
                    double piv = 1 / llave[p, p];
                    for (int i = 0; i < 3; i++)
                    {
                        llave[p, i] *= piv;
                        identidad[p, i] *= piv;
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        if (p != i)
                        {
                            double v = llave[i, p];
                            for (int j = 0; j < 3; j++)
                            {
                                llave[i, j] = -v * llave[p, j] + llave[i, j];
                                identidad[i, j] = -v * identidad[p, j] + identidad[i, j];
                            }

                        }
                    }
                }

                //Asignacion del mensaje encriptado en arreglo de numeros
                for (int f = 0; f < filas; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        textoDes[f, c] = Convert.ToDouble(cadenDesencriptar[cont++]);
                    }
                }

                //Fragmento de codigo que encriptador
                cadena = "";
                for (int f = 0; f < filas; f++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            valor += textoDes[f, y] * identidad[y, x];

                        }
                        cadena += diccionario(Math.Round(valor,0) ) + " ";
                        valor = 0;
                    }
                }

                txtResultado.Text = cadena;

            }
            catch (Exception)
            {
                throw;
            }
            
        }

        //Metodo de validación de llave por determinante
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

        //Este metodo se encargara de agregarle espacios a nuestra cadena llave
        // para poder completar nuestra matriz para encriptación
        public string ponerVacios(string llave)
        {
            for (int i = llave.Length-1; i < 9; i++)
            {
                llave += " ";
            }
            return llave;
        }
        public string ponerVacios(TextBox txt)
        {
            string cadena = txt.Text;
            cadena += cadena.Length % 3 == 1 ? "  " : " ";
            return cadena;
        }

        //Tomar los datos de entrada del usuario que se usaran como llave para encriptar
        // y asignarlos a memoria en un arreglo llave
        public void asignarLlave(ref double[,] llave,string cadena)
        {
            int cont = 0;
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    llave[f, c] = diccionario(cadena[cont++]);
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
