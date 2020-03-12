using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_lista
{
    class Program
    {

        public static void insertarNodo(ref Nodo  Inicio, ref Nodo Fin, byte dato)
        {
            if (Fin == null) //Lista vacia
            {
                Fin = new Nodo(dato);
                Inicio = Fin;
            }else // Lista con uno mas nodos
            {
                Fin.Sig = new Nodo(dato);
                Fin.Sig.Ant = Fin;
                Fin = Fin.Sig;
            }
        }

        public static String mostrarLista(Nodo actual)
        {
            if (actual.Sig == null)
            {
                return actual.Dato.ToString();
            }
            else
            {
                return actual.Dato.ToString() + "|" + mostrarLista(actual.Sig);
            }
        }
        public static String mostrarListaReversa(Nodo actual)
        {
            if (actual.Ant == null)
            {
                return actual.Dato.ToString();
            }
            else
            {
                return actual.Dato.ToString() + "|" + mostrarListaReversa(actual.Ant);
            }
        }

        public static Nodo buscarElemento(Nodo actual, byte dato)
        {
            if (actual.Dato == dato)
            {
                return actual;
            }
            else
            {
                if (actual.Sig == null)
                {
                    return null;
                }
                else
                {
                    return buscarElemento(actual.Sig, dato);
                }
            }
        }

        public static bool modificarDato(Nodo actual, byte datoActual, byte nuevoDato)
        {
            Nodo aux = buscarElemento(actual, datoActual);
            if (aux != null)
            {
                aux.Dato = nuevoDato;
                return true;
            }
            return false;
        }

        public static bool eliminarNodo(ref Nodo Inicio, ref Nodo Fin, byte dato)
        {
            Nodo aux = buscarElemento(Inicio, dato);
            if (aux != null)
            {
                if (aux.Sig == null)
                {
                    Fin = aux.Ant;
                    Fin.Sig = null;
                }
                else
                {
                    if (aux.Ant == null)
                    {
                        Inicio = aux.Sig;
                        Inicio.Ant = null;
                    }
                    else
                    {
                        aux.Ant.Sig = aux.Sig;
                        aux.Sig.Ant = aux.Ant;
                        
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Nodo inicio = null, fin = null;
            insertarNodo(ref inicio, ref fin, (byte)5);
            insertarNodo(ref inicio, ref fin, (byte)7);
            insertarNodo(ref inicio, ref fin, (byte)8);
            insertarNodo(ref inicio, ref fin, (byte)2);
            insertarNodo(ref inicio, ref fin, (byte)3);

            Console.WriteLine(mostrarLista(inicio));
            Console.WriteLine(mostrarListaReversa(fin));

            //if (modificarDato(inicio, (byte)13, (byte) 12))
            //{
            //    Console.WriteLine(mostrarLista(inicio));
            //}
            //else
            //{
            //    Console.WriteLine("Dato no encontrado");
            //}
            if (eliminarNodo(ref inicio,ref fin, (byte)5))
            {
                Console.WriteLine(mostrarLista(inicio));
            }
            else
            {
                Console.WriteLine("Nodo no encontrado");
            }
            
            //if (buscarElemento(inicio,(byte) 8) != null)
            //{
            //    Console.WriteLine("Encontrado");
            //}
            //else
            //{
            //    Console.WriteLine("No encontrado");
            //}


            Console.WriteLine("Fin codigo...");
            Console.ReadKey();
        }
    }
}
