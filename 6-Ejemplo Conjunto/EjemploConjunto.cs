using System;

namespace EjemploConjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un conjunto de cadenas
            HashSet<string> frutas = new HashSet<string>();

            // Añadir elementos al conjunto
            frutas.Add("Manzana");
            frutas.Add("Banana");
            frutas.Add("Naranja");
            frutas.Add("Manzana"); // Intentar añadir "Manzana" de nuevo, no se agregará

            Console.WriteLine("Frutas en el conjunto:");
            // Recorrer los elementos del conjunto
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            // Verificar si una fruta existe
            if (frutas.Contains("Banana"))
            {
                Console.WriteLine("\nEl conjunto contiene Banana.");
            }

            if (frutas.Contains("Uva"))
            {
                Console.WriteLine("El conjunto contiene Uva.");
            }
            else
            {
                Console.WriteLine("El conjunto NO contiene Uva.");
            }
        }
    }
}