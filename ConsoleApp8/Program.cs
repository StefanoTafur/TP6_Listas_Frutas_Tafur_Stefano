using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Se declara una lista de strings para almacenar frutas
        List<string> frutas = new List<string>();
        int opcion;

        do
        {
            Console.Clear(); // Limpia la consola antes de mostrar el menú

            // Menú de opciones
            Console.WriteLine("Menu de Frutas");
            Console.WriteLine("1. Agregar fruta");
            Console.WriteLine("2. Eliminar fruta");
            Console.WriteLine("3. Mostrar todas las frutas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Agregar fruta
                    Console.Write("Ingrese el nombre de la fruta a agregar: ");
                    string frutaAgregar = Console.ReadLine();
                    frutas.Add(frutaAgregar); // Agrega la fruta a la lista
                    Console.WriteLine($"{frutaAgregar} ha sido agregada a la lista.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 2:
                    // Eliminar fruta
                    Console.Write("Ingrese el nombre de la fruta a eliminar: ");
                    string frutaEliminar = Console.ReadLine();
                    bool frutaEliminada = false;

                    for (int i = 0; i < frutas.Count; i++)
                    {
                        if (frutas[i].Equals(frutaEliminar, StringComparison.OrdinalIgnoreCase))
                        {
                            frutas.RemoveAt(i); // Elimina la fruta de la lista
                            frutaEliminada = true;
                            break;
                        }
                    }

                    if (frutaEliminada)
                    {
                        Console.WriteLine($"{frutaEliminar} ha sido eliminada de la lista.");
                    }
                    else
                    {
                        Console.WriteLine($"{frutaEliminar} no se encontró en la lista.");
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 3:
                    // Mostrar todas las frutas
                    Console.WriteLine("Lista de frutas:");
                    foreach (string fruta in frutas)
                    {
                        Console.WriteLine(fruta);
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 4:
                    // Salir del programa
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    // Opción no válida
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 4); // Continuar hasta que se seleccione la opción de salir
    }
}
