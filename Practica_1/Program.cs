using System;


namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, op, x1, x2;
            try
            {
                Console.WriteLine("Teniendo en cuenta la siguient ecuacion\n ax² + bx + c = 0");

                Console.WriteLine("Ingrese el valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de c: ");
                c = Convert.ToDouble(Console.ReadLine());

                op = Math.Pow(b, 2) - 4 * a * c;
                
                
                if (op >= 0)
                {
                    x1 = (-b + Math.Sqrt(op)) / 2 * a;
                    x2 = (-b - Math.Sqrt(op)) / 2 * a;

                    Console.WriteLine("El valor de x1 es: " + x1.ToString("0.000"));
                    Console.WriteLine("El valor de x2 es: " + x2.ToString("0.000"));
                    
                }
                else
                {
                    Console.WriteLine("La parabola no intersecta al eje x");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ingresar solo numeros.");
            }
            


            Console.WriteLine("Presione cualquier tecla...");
            Console.ReadKey();
        }
    }
}
