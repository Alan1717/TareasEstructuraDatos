using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingrese 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros.Add(int.Parse(Console.ReadLine()));
        }

        // Ascendente
        List<int> asc = new List<int>(numeros);
        asc.Sort();

        // Descendente
        List<int> desc = new List<int>(numeros);
        desc.Sort();
        desc.Reverse();

        Console.WriteLine("\nOrden ascendente:");
        foreach (int n in asc)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine("\n\nOrden descendente:");
        foreach (int n in desc)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
    }
}