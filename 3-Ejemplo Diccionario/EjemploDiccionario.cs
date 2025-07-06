using System;

namespace EjemploDiccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un diccionario de nombres y edades
            Dictionary<string, int> edades = new Dictionary<string, int>();

            // Añadir elementos al diccionario
            edades.Add("Alice", 30);
            edades.Add("Bob", 24);
            edades.Add("Charlie", 35);

            // Buscar la edad de Bob
            if (edades.TryGetValue("Bob", out int edadBob))
            {
                Console.WriteLine($"La edad de Bob es: {edadBob}");
            }
            else
            {
                Console.WriteLine("Bob no se encontró en el diccionario.");
            }

            // Intentar buscar a David (no existe)
            if (edades.TryGetValue("David", out int edadDavid))
            {
                Console.WriteLine($"La edad de David es: {edadDavid}");
            }
            else
            {
                Console.WriteLine("David no se encontró en el diccionario.");
            }
        }
    }
}
