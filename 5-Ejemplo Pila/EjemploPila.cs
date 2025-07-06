using System;

namespace EjemploPila
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una pila de enteros
            Stack<int> libros = new Stack<int>();

            // Añadir elementos a la pila (simulando apilar libros)
            libros.Push(101); // Libro 101
            libros.Push(102); // Libro 102
            libros.Push(103); // Libro 103

            Console.WriteLine("Libros en la pila (de arriba a abajo):");
            foreach (int libro in libros)
            {
                Console.WriteLine(libro);
            }

            // Sacar el último libro añadido (simulando desapilar)
            int ultimoLibro = libros.Pop();
            Console.WriteLine($"\nSe ha sacado el libro: {ultimoLibro}");

            Console.WriteLine("Libros restantes en la pila:");
            foreach (int libro in libros)
            {
                Console.WriteLine(libro);
            }
        }
    }
}