// =====================================================================
// TEMA: Listas simplemente enlazadas circulares
// Clase 4 - Programación y Estructuras de Datos - UAI
//
// Cómo usarlo: crear un Proyecto de Consola en Visual Studio y reemplazar
// el contenido de Program.cs por este archivo.
//
// La diferencia con la lista simple "normal" es una sola: el Siguiente
// del ÚLTIMO nodo no apunta a NULL, sino que apunta de nuevo al PRIMERO.
// Esto arma un anillo (no tiene ni principio ni fin real). Por eso, para
// no recorrerla infinitamente, siempre hay que cortar el recorrido
// comparando contra el nodo de referencia con el que arrancamos.
//
// Aplicación clásica: el problema de Josephus (turnos en ronda, como el
// juego "el pato ñato" que aparece en el TP de la unidad).
// =====================================================================
using System;

namespace Clase4.ListaCircularSimple
{
    public class NodoCircular
    {
        public string Nombre;
        public NodoCircular Siguiente;

        public NodoCircular(string nombre)
        {
            Nombre = nombre;
        }
    }

    public class ListaCircularSimple
    {
        // Por convención, en las listas circulares simples conviene guardar
        // una referencia al ÚLTIMO nodo: así se puede insertar al principio
        // y al final en O(1) (el primero es siempre ultimo.Siguiente).
        private NodoCircular ultimo;
        private int cantidad;

        public int Cantidad => cantidad;

        // Agrega un nodo al final del anillo.
        public void Agregar(string nombre)
        {
            NodoCircular nuevo = new NodoCircular(nombre);

            if (ultimo == null)
            {
                ultimo = nuevo;
                ultimo.Siguiente = ultimo; // se apunta a sí mismo: único nodo
            }
            else
            {
                nuevo.Siguiente = ultimo.Siguiente; // apunta al primero
                ultimo.Siguiente = nuevo;
                ultimo = nuevo; // el nuevo pasa a ser el último
            }
            cantidad++;
        }

        // Recorre el anillo UNA vuelta completa a partir del primero.
        public void RecorrerUnaVuelta()
        {
            if (ultimo == null)
            {
                Console.WriteLine("(la lista está vacía)");
                return;
            }

            NodoCircular primero = ultimo.Siguiente;
            NodoCircular actual = primero;
            do
            {
                Console.Write(actual.Nombre + " -> ");
                actual = actual.Siguiente;
            } while (actual != primero); // corta al volver al punto de partida
            Console.WriteLine("(vuelve a " + primero.Nombre + ")");
        }

        // Ejemplo de uso típico de una lista circular: "el juego de la papa
        // caliente" / problema de Josephus. Cada "salto" cuenta n nodos y
        // saca al que cae; se repite hasta que queda uno solo.
        public string JuegoDeEliminacion(int salto)
        {
            if (ultimo == null) return null;

            NodoCircular actual = ultimo.Siguiente; // arranca en el primero
            NodoCircular anterior = ultimo;

            while (cantidad > 1)
            {
                // avanzar "salto" posiciones (salto-1 saltos desde el actual)
                for (int i = 1; i < salto; i++)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }

                Console.WriteLine("Sale del juego: " + actual.Nombre);

                // quitar "actual" del anillo
                anterior.Siguiente = actual.Siguiente;
                if (actual == ultimo) ultimo = anterior; // actualizar último si hace falta
                actual = anterior.Siguiente;
                cantidad--;
            }

            return actual.Nombre; // el ganador
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaCircularSimple ronda = new ListaCircularSimple();
            ronda.Agregar("Juan");
            ronda.Agregar("María");
            ronda.Agregar("Pedro");
            ronda.Agregar("Lucía");
            ronda.Agregar("Sofía");

            Console.WriteLine("=== Una vuelta completa ===");
            ronda.RecorrerUnaVuelta();

            Console.WriteLine("\n=== Juego de eliminación (salto = 3) ===");
            string ganador = ronda.JuegoDeEliminacion(3);
            Console.WriteLine("Ganador: " + ganador);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
