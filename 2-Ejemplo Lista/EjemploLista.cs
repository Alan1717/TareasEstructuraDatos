using System;

namespace EjemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de enteros
            List<int> numeros = new List<int>();

            // Añadir elementos a la lista
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);

            Console.WriteLine("Elementos en la lista:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
