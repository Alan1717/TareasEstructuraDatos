using System;

namespace EjemploCola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una cola de cadenas
            Queue<string> pedidos = new Queue<string>();

            // Añadir elementos a la cola
            pedidos.Enqueue("Pizza");
            pedidos.Enqueue("Hamburguesa");
            pedidos.Enqueue("Ensalada");

            Console.WriteLine("Pedidos actuales:");
            foreach (string pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }

            // Atender el primer pedido (eliminar de la cola)
            string primerPedido = pedidos.Dequeue();
            Console.WriteLine($"\nAtendiendo: {primerPedido}");

            Console.WriteLine("Pedidos restantes:");
            foreach (string pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }
        }
    }
}