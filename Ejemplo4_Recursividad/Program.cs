using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4_Recursividad
{
    class Program
    {
        public static long factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        public static int sumatoria(int inferior, int superior)
        {
            if (inferior == superior)
            {
                return superior;
            }
            else
            {
                return inferior + sumatoria(inferior + 1, superior);
            }
        }

        public static string vocales(string palabra)
        {
            if (palabra.Length == 0)
            {
                return "";
            }
            else
            {
                if (palabra[0] == 'a' || palabra[0] == 'e' || palabra[0] == 'i' || palabra[0] == 'o' || palabra[0] == 'u')
                {
                    return palabra[0] + vocales(palabra.Substring(1));
                }
                else
                {
                    return vocales(palabra.Substring(1));
                }
            }
        }

        public static string palabraInvertida(string palabra)
        {
            if (palabra.Length == 0)
            {
                return "";
            }
            else
            {
                return palabraInvertida(palabra.Substring(1)) + palabra[0];
            }
        }

        static void Main(string[] args)
        {
            int n, inferior, superior;
            long resultado;

            //Console.WriteLine("Ingresa un numero: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //resultado = factorial(n);
            //Console.WriteLine("El factorial de {0} es {1}", n, resultado);

            Console.WriteLine(palabraInvertida("hola mundo"));
            Console.WriteLine("Fin de codigo...");
            Console.ReadKey();
        }
    }
}
