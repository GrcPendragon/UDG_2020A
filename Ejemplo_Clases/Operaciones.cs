using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clases
{
    class Operaciones
    {
        //Atributos
        private int a, b;

        public Operaciones()
        {

        }

        public Operaciones(int a, int b)
        {
        }

        public int A
        {
            set
            {
                this.a = value < 0 ? -value : value;
            }
        }
    }
}
