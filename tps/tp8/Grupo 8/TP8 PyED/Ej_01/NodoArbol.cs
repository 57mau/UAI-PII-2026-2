using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    internal class NodoArbol
    {
        public int Dato;
        public NodoArbol Izquierdo;
        public NodoArbol Derecho;

        public NodoArbol(int dato)
        {
            this.Dato = dato;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
