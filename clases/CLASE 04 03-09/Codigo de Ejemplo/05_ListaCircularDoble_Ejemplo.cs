// =====================================================================
// TEMA: Listas doblemente enlazadas circulares
// Clase 4 - Programación y Estructuras de Datos - UAI
//
// Cómo usarlo: crear un Proyecto de Consola en Visual Studio y reemplazar
// el contenido de Program.cs por este archivo.
//
// Combina las dos ideas anteriores: cada nodo tiene Anterior y Siguiente
// (como la lista doble) y el último se conecta con el primero, y el
// primero con el último (como la lista circular). El resultado es un
// anillo que se puede recorrer en los dos sentidos.
// =====================================================================
using System;

namespace Clase4.ListaCircularDoble
{
    public class NodoCircularDoble
    {
        public string Dato;
        public NodoCircularDoble Anterior;
        public NodoCircularDoble Siguiente;

        public NodoCircularDoble(string dato)
        {
            Dato = dato;
        }
    }

    public class ListaCircularDoble
    {
        private NodoCircularDoble referencia; // apunta a un nodo "cabecera"
        private int cantidad;

        public int Cantidad => cantidad;

        public void Agregar(string dato)
        {
            NodoCircularDoble nuevo = new NodoCircularDoble(dato);

            if (referencia == null)
            {
                // único nodo: se apunta a sí mismo en ambos sentidos
                nuevo.Siguiente = nuevo;
                nuevo.Anterior = nuevo;
                referencia = nuevo;
            }
            else
            {
                NodoCircularDoble ultimo = referencia.Anterior; // el anterior a la cabecera ES el último

                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                nuevo.Siguiente = referencia;
                referencia.Anterior = nuevo;
            }
            cantidad++;
        }

        // Recorre el anillo hacia adelante (Siguiente), una vuelta completa.
        public void MostrarAdelante()
        {
            if (referencia == null)
            {
                Console.WriteLine("(la lista está vacía)");
                return;
            }
            NodoCircularDoble actual = referencia;
            do
            {
                Console.Write(actual.Dato + " <-> ");
                actual = actual.Siguiente;
            } while (actual != referencia);
            Console.WriteLine("(vuelve a " + referencia.Dato + ")");
        }

        // Recorre el anillo hacia atrás (Anterior), una vuelta completa.
        // Ventaja frente a la circular simple: no hace falta "reiniciar" para
        // ir en el otro sentido, ni recordar el nodo anterior al recorrer.
        public void MostrarAtras()
        {
            if (referencia == null)
            {
                Console.WriteLine("(la lista está vacía)");
                return;
            }
            NodoCircularDoble ultimo = referencia.Anterior;
            NodoCircularDoble actual = ultimo;
            do
            {
                Console.Write(actual.Dato + " <-> ");
                actual = actual.Anterior;
            } while (actual != ultimo);
            Console.WriteLine("(vuelve a " + ultimo.Dato + ")");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaCircularDoble lista = new ListaCircularDoble();
            lista.Agregar("Lunes");
            lista.Agregar("Martes");
            lista.Agregar("Miércoles");
            lista.Agregar("Jueves");
            lista.Agregar("Viernes");

            Console.WriteLine("Cantidad de nodos: " + lista.Cantidad);

            Console.Write("Adelante: ");
            lista.MostrarAdelante();

            Console.Write("Atrás:    ");
            lista.MostrarAtras();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
