using System;
using System.Collections.Generic;

public class BinarySearchExample
{
    /// <summary>
    /// Realiza una búsqueda binaria en una lista ordenada.
    /// </summary>
    /// <typeparam name="T">El tipo de elementos en la lista (debe ser comparable).</typeparam>
    /// <param name="list">La lista ordenada donde buscar.</param>
    /// <param name="target">El elemento a buscar.</param>
    /// <returns>El índice del elemento si se encuentra; de lo contrario, -1.</returns>
    public static int BinarySearch<T>(List<T> list, T target) where T : IComparable<T>
    {
        int left = 0;                    // Índice inicial de la porción de búsqueda
        int right = list.Count - 1;      // Índice final de la porción de búsqueda

        while (left <= right)
        {
            int mid = left + (right - left) / 2;  // Calcula el índice del medio para evitar desbordamiento

            // Compara el elemento del medio con el objetivo
            int comparisonResult = list[mid].CompareTo(target);

            if (comparisonResult == 0)
            {
                // El elemento del medio es el objetivo, lo encontramos.
                return mid;
            }
            else if (comparisonResult < 0)
            {
                // El elemento del medio es menor que el objetivo.
                // Descarta la mitad izquierda y busca en la mitad derecha.
                left = mid + 1;
            }
            else
            {
                // El elemento del medio es mayor que el objetivo.
                // Descarta la mitad derecha y busca en la mitad izquierda.
                right = mid - 1;
            }
        }

        // El elemento no se encontró en la lista.
        return -1;
    }

    public static void Main(string[] args)
    {
        // 1. Crear una lista de números ORDENADA
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        Console.WriteLine("Lista de números: " + string.Join(", ", numbers));

        // --- Ejemplos de búsqueda ---
        int target1 = 50;   // Elemento que sí está en la lista
        int index1 = BinarySearch(numbers, target1);
        if (index1 != -1)
        {
            Console.WriteLine($"\nEl número {target1} se encontró en el índice: {index1}");
        }
        else
        {
            Console.WriteLine($"\nEl número {target1} no se encontró en la lista.");
        }

        int target2 = 35;   // Elemento que no está en la lista
        int index2 = BinarySearch(numbers, target2);
        if (index2 != -1)
        {
            Console.WriteLine($"El número {target2} se encontró en el índice: {index2}");
        }
        else
        {
            Console.WriteLine($"El número {target2} no se encontró en la lista.");
        }

        int target3 = 10;   // Elemento en el primer índice
        int index3 = BinarySearch(numbers, target3);
        if (index3 != -1)
        {
            Console.WriteLine($"El número {target3} se encontró en el índice: {index3}");
        }
        else
        {
            Console.WriteLine($"El número {target3} no se encontró en la lista.");
        }

        int target4 = 100;  // Elemento en el último índice
        int index4 = BinarySearch(numbers, target4);
        if (index4 != -1)
        {
            Console.WriteLine($"El número {target4} se encontró en el índice: {index4}");
        }
        else
        {
            Console.WriteLine($"El número {target4} no se encontró en la lista.");
        }

        // --- Ejemplo con otra lista (de strings) ---
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Grape", "Lemon" };
        fruits.Sort();  // Asegurarse de que esté ordenada si no lo estaba al inicio

        Console.WriteLine("\nLista de frutas: " + string.Join(", ", fruits));

        string targetFruit = "Cherry";
        int fruitIndex = BinarySearch(fruits, targetFruit);
        if (fruitIndex != -1)
        {
            Console.WriteLine($"La fruta '{targetFruit}' se encontró en el índice: {fruitIndex}");
        }
        else
        {
            Console.WriteLine($"La fruta '{targetFruit}' no se encontró en la lista.");
        }
    }
}