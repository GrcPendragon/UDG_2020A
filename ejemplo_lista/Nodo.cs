using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_lista
{
    class Nodo
    {
        private byte dato;
        private Nodo Siguiente;
        private Nodo Anterior;
        public Nodo()
        {

        }

        public Nodo(byte dato)
        {
            this.dato = dato;
        }

        public Nodo Sig
        {
            get
            {
                return Siguiente;
            }
            set
            {
                Siguiente = value;
            }
        }

        public Nodo Ant
        {
            get
            {
                return Anterior;
            }
            set
            {
                Anterior = value;
            }
        }
        public byte Dato
        {
            get
            {
                return dato;
            }
            set
            {
                dato = value;
            }
        }
    }
}
