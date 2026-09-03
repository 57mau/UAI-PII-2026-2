// =====================================================================
// TEMA: Listas simplemente enlazadas
// Clase 4 - Programación y Estructuras de Datos - UAI
//
// Cómo usarlo: crear un Proyecto de Consola en Visual Studio y reemplazar
// el contenido de Program.cs por este archivo.
//
// Basado y ampliado a partir del ejemplo del material de la Unidad 2
// (Listas.rar): se completan las 3 operaciones que en el original habían
// quedado sin implementar (IntercambiarDerecha, IntercambiarIzquierda,
// Intercambiar), para que quede como ejemplo funcional completo.
// =====================================================================
using System;

namespace Clase4.ListaSimplementeEnlazada
{
    // TDA Nodo: representa un elemento de la lista y una referencia al siguiente.
    public class NodoSimple
    {
        public int Numero;
        public string Nombre;
        public NodoSimple Siguiente;

        public override string ToString()
        {
            return string.Format("{0} - {1}", Numero, Nombre);
        }
    }

    // TDA Lista: mantiene una referencia al primer nodo (NodoInicial)
    // y expone las operaciones típicas sobre una lista simplemente enlazada.
    public class ListaEnlazadaSimple
    {
        public NodoSimple NodoInicial = null;

        // Agrega un nodo como nuevo primer elemento de la lista.
        public void AgregarAlPrincipio(string nombre)
        {
            NodoSimple nodo = new NodoSimple();
            nodo.Numero = ProximoNumero();
            nodo.Nombre = nombre;

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                NodoSimple aux = NodoInicial;
                NodoInicial = nodo;
                NodoInicial.Siguiente = aux;
            }
        }

        // Agrega un nodo al final de la lista.
        public void AgregarAlFinal(string nombre)
        {
            NodoSimple nodo = new NodoSimple();
            nodo.Numero = ProximoNumero();
            nodo.Nombre = nombre;

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
                return;
            }
            NodoSimple ultimo = BuscarUltimo(NodoInicial);
            ultimo.Siguiente = nodo;
        }

        // Recorrido RECURSIVO en busca del número más alto usado hasta el momento.
        private int BuscarMaximo(NodoSimple nodo, int numero)
        {
            int max = nodo.Numero > numero ? nodo.Numero : numero;
            if (nodo.Siguiente != null) // no es el último
            {
                return BuscarMaximo(nodo.Siguiente, max);
            }
            return max;
        }

        // Calcula el próximo número identificador disponible.
        private int ProximoNumero()
        {
            if (NodoInicial == null) return 1;
            int max = BuscarMaximo(NodoInicial, NodoInicial.Numero);
            return max + 1;
        }

        // Recorrido RECURSIVO hasta encontrar el último nodo (Siguiente == null).
        private NodoSimple BuscarUltimo(NodoSimple nodo)
        {
            if (nodo == null) return null;              // lista vacía
            if (nodo.Siguiente != null)                  // no es el último
                return BuscarUltimo(nodo.Siguiente);
            return nodo;                                  // es el último
        }

        // Quita el primer nodo de la lista.
        public void QuitarPrimero()
        {
            if (NodoInicial != null)
            {
                NodoInicial = NodoInicial.Siguiente;
            }
        }

        // Quita el último nodo de la lista.
        public void QuitarUltimo()
        {
            NodoSimple anteultimo = BuscarAnteultimo(NodoInicial);
            if (anteultimo != null)
                anteultimo.Siguiente = null;
            else
                NodoInicial = null; // había 0 o 1 elementos
        }

        // Recorrido RECURSIVO hasta el anteúltimo nodo.
        private NodoSimple BuscarAnteultimo(NodoSimple nodo)
        {
            if (nodo == null) return null;                       // lista vacía
            if (nodo.Siguiente == null) return null;              // un solo elemento
            if (nodo.Siguiente.Siguiente != null)
                return BuscarAnteultimo(nodo.Siguiente);
            return nodo;
        }

        // Recorrido RECURSIVO en busca del nodo anterior al que tiene "numero".
        private NodoSimple BuscarAnterior(NodoSimple nodo, int numero)
        {
            if (nodo.Siguiente != null && nodo.Siguiente.Numero == numero)
                return nodo;
            if (nodo.Siguiente != null)
                return BuscarAnterior(nodo.Siguiente, numero);
            return null; // no se encontró
        }

        // Quita el nodo identificado por "numero", sin importar la posición.
        public void QuitarPosicion(int numero)
        {
            if (NodoInicial == null) return;

            if (NodoInicial.Numero == numero)
            {
                QuitarPrimero();
                return;
            }

            NodoSimple ultimo = BuscarUltimo(NodoInicial);
            if (ultimo != null && ultimo.Numero == numero)
            {
                QuitarUltimo();
                return;
            }

            NodoSimple anterior = BuscarAnterior(NodoInicial, numero);
            if (anterior != null)
                anterior.Siguiente = anterior.Siguiente.Siguiente;
        }

        // Intercambia el VALOR de un nodo con el de su siguiente (a la derecha).
        public void IntercambiarDerecha(int numero)
        {
            NodoSimple nodo = BuscarNodo(NodoInicial, numero);
            if (nodo != null && nodo.Siguiente != null)
            {
                Intercambiar(nodo, nodo.Siguiente);
            }
        }

        // Intercambia el VALOR de un nodo con el de su anterior (a la izquierda).
        public void IntercambiarIzquierda(int numero)
        {
            NodoSimple anterior = BuscarAnterior(NodoInicial, numero);
            NodoSimple nodo = BuscarNodo(NodoInicial, numero);
            if (anterior != null && nodo != null)
            {
                Intercambiar(anterior, nodo);
            }
        }

        // Intercambia el VALOR de dos nodos a partir de los números que los identifican.
        public void Intercambiar(int numero1, int numero2)
        {
            NodoSimple nodo1 = BuscarNodo(NodoInicial, numero1);
            NodoSimple nodo2 = BuscarNodo(NodoInicial, numero2);
            if (nodo1 != null && nodo2 != null)
            {
                Intercambiar(nodo1, nodo2);
            }
        }

        // Sobrecarga interna: intercambia Numero y Nombre entre dos nodos ya ubicados.
        private void Intercambiar(NodoSimple a, NodoSimple b)
        {
            int numAux = a.Numero;
            string nomAux = a.Nombre;
            a.Numero = b.Numero;
            a.Nombre = b.Nombre;
            b.Numero = numAux;
            b.Nombre = nomAux;
        }

        // Recorrido RECURSIVO en busca del nodo con un número determinado.
        private NodoSimple BuscarNodo(NodoSimple nodo, int numero)
        {
            if (nodo == null) return null;
            if (nodo.Numero == numero) return nodo;
            return BuscarNodo(nodo.Siguiente, numero);
        }

        // Recorrido ITERATIVO: muestra todos los nodos por consola.
        public void MostrarListado()
        {
            NodoSimple actual = NodoInicial;
            if (actual == null)
            {
                Console.WriteLine("(la lista está vacía)");
                return;
            }
            while (actual != null)
            {
                Console.WriteLine(actual);
                actual = actual.Siguiente;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple lista = new ListaEnlazadaSimple();

            lista.AgregarAlFinal("Ana");
            lista.AgregarAlFinal("Bruno");
            lista.AgregarAlFinal("Carla");
            lista.AgregarAlPrincipio("Diego"); // queda primero

            Console.WriteLine("=== Listado inicial ===");
            lista.MostrarListado();

            Console.WriteLine("\n=== Intercambiar (2, 3) ===");
            lista.Intercambiar(2, 3);
            lista.MostrarListado();

            Console.WriteLine("\n=== Quitar posición 1 ===");
            lista.QuitarPosicion(1);
            lista.MostrarListado();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
