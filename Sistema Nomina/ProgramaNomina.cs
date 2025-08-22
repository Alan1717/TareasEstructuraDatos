// ==============================
// Sistema de Nómina con Lista Enlazada Simple
// ==============================

using System;

public class Empleado
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public double Salario { get; set; }
}

public class Nodo
{
    public Empleado Datos { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(Empleado empleado)
    {
        Datos = empleado;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    private Nodo cabeza;

    public void AgregarEmpleado(Empleado empleado)
    {
        Nodo nuevo = new Nodo(empleado);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
        Console.WriteLine("Empleado registrado correctamente.\n");
    }

    public void MostrarEmpleados()
    {
        if (cabeza == null)
        {
            Console.WriteLine("No hay empleados registrados.\n");
            return;
        }

        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.WriteLine($"ID: {actual.Datos.ID}, Nombre: {actual.Datos.Nombre}, Salario: {actual.Datos.Salario}");
            actual = actual.Siguiente;
        }
    }

    public void BuscarEmpleado(int id)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Datos.ID == id)
            {
                Console.WriteLine($"Empleado encontrado: {actual.Datos.Nombre} - Salario: {actual.Datos.Salario}");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine("Empleado no encontrado.\n");
    }

    public void EliminarEmpleado(int id)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza.Datos.ID == id)
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine("Empleado eliminado.\n");
            return;
        }

        Nodo anterior = cabeza;
        Nodo actual = cabeza.Siguiente;

        while (actual != null)
        {
            if (actual.Datos.ID == id)
            {
                anterior.Siguiente = actual.Siguiente;
                Console.WriteLine("Empleado eliminado.\n");
                return;
            }
            anterior = actual;
            actual = actual.Siguiente;
        }

        Console.WriteLine("Empleado no encontrado.\n");
    }

    public double CalcularTotalSalarios()
    {
        double total = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            total += actual.Datos.Salario;
            actual = actual.Siguiente;
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada nomina = new ListaEnlazada();
        int opcion;

        do
        {
            Console.WriteLine("----- Menú de Nómina -----");
            Console.WriteLine("1. Registrar nuevo empleado");
            Console.WriteLine("2. Mostrar todos los empleados");
            Console.WriteLine("3. Buscar empleado por ID");
            Console.WriteLine("4. Eliminar empleado");
            Console.WriteLine("5. Calcular total de salarios");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Empleado emp = new Empleado();
                    Console.Write("Ingrese ID: ");
                    emp.ID = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese nombre: ");
                    emp.Nombre = Console.ReadLine();
                    Console.Write("Ingrese salario: ");
                    emp.Salario = double.Parse(Console.ReadLine());
                    nomina.AgregarEmpleado(emp);
                    break;

                case 2:
                    nomina.MostrarEmpleados();
                    break;

                case 3:
                    Console.Write("Ingrese el ID a buscar: ");
                    int idBuscar = int.Parse(Console.ReadLine());
                    nomina.BuscarEmpleado(idBuscar);
                    break;

                case 4:
                    Console.Write("Ingrese el ID a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine());
                    nomina.EliminarEmpleado(idEliminar);
                    break;

                case 5:
                    double total = nomina.CalcularTotalSalarios();
                    Console.WriteLine($"Total de salarios: {total}\n");
                    break;

                case 6:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 6);
    }
}
