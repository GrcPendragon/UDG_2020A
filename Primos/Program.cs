using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {

        public static Boolean primo(int numero, int acumulador)
        {
            bool band;
            if (numero == acumulador)
            {
                return true;
            }
            if (numero % acumulador != 0)
            {
              band = primo(numero, ++acumulador);
            }
            else
            {
                band = false;
            }
            return band;
        }

        static void Main(string[] args)
        {
            int numero;
            const int acumulador = 2;
            
            do
            {
                Console.WriteLine("Ingrese el numero que desea comprobar si es primo: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 1)
                {
                    Console.WriteLine("El numero {0} es primo", numero);
                }
                else
                {
                    if (primo(numero, acumulador))
                    {
                        Console.WriteLine("El numero {0} es primo", numero);
                    }
                    else
                    {
                        Console.WriteLine("El numero {0} no es primo", numero);
                    }
                }
                Console.WriteLine("Desea ingresar otro numero? si/no");
            } while (Console.ReadLine().Equals("si"));

            Console.WriteLine("Fin codigo...");
            Console.ReadKey();
        }
    }
}
