// =====================================================================
// TEMA: Listas doblemente enlazadas
// Clase 4 - Programación y Estructuras de Datos - UAI
//
// Cómo usarlo: crear un Proyecto de Consola en Visual Studio y reemplazar
// el contenido de Program.cs por este archivo.
//
// A diferencia de la lista simple, cada nodo tiene DOS referencias:
// Anterior y Siguiente. Esto permite recorrer la lista en ambos sentidos
// y facilita insertar/eliminar sin tener que buscar el nodo anterior.
// =====================================================================
using System;

namespace Clase4.ListaDoblementeEnlazada
{
    public class NodoDoble
    {
        public int Dato;
        public NodoDoble Anterior;
        public NodoDoble Siguiente;

        public NodoDoble(int dato)
        {
            Dato = dato;
        }
    }

    public class ListaDoblementeEnlazada
    {
        private NodoDoble primero;
        private NodoDoble ultimo;
        private int cantidad;

        public int Cantidad => cantidad;

        // Agrega un nodo al final de la lista. O(1) porque mantenemos "ultimo".
        public void AgregarAlFinal(int dato)
        {
            NodoDoble nuevo = new NodoDoble(dato);

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                nuevo.Anterior = ultimo;
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            cantidad++;
        }

        // Agrega un nodo al principio de la lista. O(1) porque mantenemos "primero".
        public void AgregarAlPrincipio(int dato)
        {
            NodoDoble nuevo = new NodoDoble(dato);

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = primero;
                primero.Anterior = nuevo;
                primero = nuevo;
            }
            cantidad++;
        }

        // Elimina el primer nodo cuyo dato coincide con el buscado.
        public bool Eliminar(int dato)
        {
            NodoDoble actual = primero;
            while (actual != null)
            {
                if (actual.Dato == dato)
                {
                    // Reconectar el nodo anterior con el siguiente (y viceversa)
                    if (actual.Anterior != null)
                        actual.Anterior.Siguiente = actual.Siguiente;
                    else
                        primero = actual.Siguiente; // era el primero

                    if (actual.Siguiente != null)
                        actual.Siguiente.Anterior = actual.Anterior;
                    else
                        ultimo = actual.Anterior; // era el último

                    cantidad--;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false; // no se encontró
        }

        // Recorre la lista de adelante hacia atrás (Siguiente).
        public void MostrarAdelante()
        {
            NodoDoble actual = primero;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("NULL");
        }

        // Recorre la lista de atrás hacia adelante (Anterior).
        // Esta es la principal ventaja frente a la lista simple: se puede
        // recorrer en ambos sentidos sin tener que "reiniciar" desde el inicio.
        public void MostrarAtras()
        {
            NodoDoble actual = ultimo;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Anterior;
            }
            Console.WriteLine("NULL");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaDoblementeEnlazada lista = new ListaDoblementeEnlazada();
            lista.AgregarAlFinal(10);
            lista.AgregarAlFinal(20);
            lista.AgregarAlFinal(30);
            lista.AgregarAlPrincipio(5);

            Console.WriteLine("Cantidad de nodos: " + lista.Cantidad);

            Console.Write("Adelante: ");
            lista.MostrarAdelante();

            Console.Write("Atrás:    ");
            lista.MostrarAtras();

            lista.Eliminar(20);
            Console.WriteLine("\nDespués de eliminar el 20:");
            Console.Write("Adelante: ");
            lista.MostrarAdelante();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
