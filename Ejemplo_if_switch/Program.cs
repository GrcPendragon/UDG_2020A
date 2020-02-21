using System;

namespace Ejemplo_if_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero;
            byte edad;
            String mensaje;

            Console.WriteLine("Ingrese su genero: ");
            genero = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            if (genero == 'm')
            {
                mensaje = edad < 12 ? "es niño" : (edad < 18 ? "es un joven" : (edad < 65 ? "es un adulto" : "es un adulto mayor"));
            }
            else
            {
                mensaje = edad < 12 ? "es niña" : (edad < 18 ? "es una joven" : (edad < 65 ? "es una adulto" : "es una adulto mayor"));
            }

            Console.WriteLine("Usted "+mensaje);

            Console.WriteLine("Para finalizar precione cualquier tecla...");
            Console.ReadKey();
        }
    }
}
