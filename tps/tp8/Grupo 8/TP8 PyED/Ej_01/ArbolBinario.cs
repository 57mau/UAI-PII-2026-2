using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    internal class ArbolBinario
    {
        public NodoArbol Raiz;

        public bool EstaVacio()
        {
            return Raiz == null;
        }

        public void Preorden(NodoArbol nodo, Action<NodoArbol> Visitar)
        {
            if (nodo == null) return;       
            Visitar(nodo);
            Preorden(nodo.Izquierdo, Visitar);
            Preorden(nodo.Derecho, Visitar);
        }

        public void Inorden(NodoArbol nodo, Action<NodoArbol> Visitar)
        {
            if (nodo == null) return;
            Preorden(nodo.Izquierdo, Visitar);
            Visitar(nodo);
            Preorden(nodo.Derecho, Visitar);
        }

        public void Postorden(NodoArbol nodo, Action<NodoArbol> Visitar)
        {
            if (nodo == null) return;
            Preorden(nodo.Izquierdo, Visitar);
            Preorden(nodo.Derecho, Visitar);
            Visitar(nodo);
        }

    }
}
