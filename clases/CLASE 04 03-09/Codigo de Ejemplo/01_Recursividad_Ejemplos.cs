// =====================================================================
// TEMA: Recursividad
// Clase 4 - Programación y Estructuras de Datos - UAI
//
// Cómo usarlo: crear un Proyecto de Consola en Visual Studio y reemplazar
// el contenido de Program.cs por este archivo (o pegar la clase Program
// dentro de un proyecto existente).
//
// Contiene 4 ejemplos clásicos de métodos recursivos, cada uno con:
//   - Caso base: la condición que DETIENE la recursividad.
//   - Caso recursivo: la llamada al mismo método con un problema más chico.
// =====================================================================
using System;

namespace Clase4.Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1) Cuenta regresiva ===");
            CuentaRegresiva(10);
            Console.WriteLine();

            Console.WriteLine("=== 2) Factorial ===");
            for (int n = 0; n <= 5; n++)
                Console.WriteLine($"{n}! = {Factorial(n)}");
            Console.WriteLine();

            Console.WriteLine("=== 3) Fibonacci ===");
            for (int n = 0; n <= 10; n++)
                Console.Write(Fibonacci(n) + " ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=== 4) Suma de los elementos de un vector (recursiva) ===");
            int[] numeros = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("Suma total = " + SumaVector(numeros, 0));

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        // ---------------------------------------------------------------
        // 1) Cuenta regresiva: 10 9 8 7 6 5 4 3 2 1
        //    Caso base: cuando n llega a 0, no se llama más a sí mismo.
        //    Caso recursivo: imprime n y se llama con n-1.
        // ---------------------------------------------------------------
        static void CuentaRegresiva(int n)
        {
            if (n == 0)
            {
                return; // caso base: corta la recursividad
            }
            Console.Write(n + " ");
            CuentaRegresiva(n - 1); // caso recursivo: problema más chico
        }

        // ---------------------------------------------------------------
        // 2) Factorial: n! = n * (n-1) * (n-2) * ... * 1
        //    Factorial(4) = 4 * Factorial(3) = 4 * 3 * Factorial(2) = ...
        //    Caso base: Factorial(0) = 1 (por definición matemática).
        // ---------------------------------------------------------------
        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1; // caso base
            }
            return n * Factorial(n - 1); // caso recursivo
        }

        // ---------------------------------------------------------------
        // 3) Fibonacci: cada número es la suma de los dos anteriores.
        //    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 ...
        //    Caso base: Fibonacci(0) = 0 y Fibonacci(1) = 1.
        //    OJO: esta versión es simple e ilustrativa, no la más eficiente
        //    (recalcula muchas veces los mismos valores). Sirve para
        //    mostrar en clase cómo se "ramifica" el árbol de llamadas.
        // ---------------------------------------------------------------
        static int Fibonacci(int n)
        {
            if (n == 0) return 0;   // caso base 1
            if (n == 1) return 1;   // caso base 2
            return Fibonacci(n - 1) + Fibonacci(n - 2); // caso recursivo
        }

        // ---------------------------------------------------------------
        // 4) Suma recursiva de los elementos de un vector.
        //    Caso base: si "posicion" llegó al final del vector, sumar 0.
        //    Caso recursivo: el elemento actual + la suma del resto.
        // ---------------------------------------------------------------
        static int SumaVector(int[] vector, int posicion)
        {
            if (posicion == vector.Length)
            {
                return 0; // caso base: no quedan elementos
            }
            return vector[posicion] + SumaVector(vector, posicion + 1);
        }
    }
}
