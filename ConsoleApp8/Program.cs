using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> frutas = new List<string>();
        int opcion;

        do
        {
            Console.Clear(); 

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
                    Console.Write("Ingrese el nombre de la fruta a agregar: ");
                    string frutaAgregar = Console.ReadLine();
                    frutas.Add(frutaAgregar);
                    Console.WriteLine($"{frutaAgregar} ha sido agregada a la lista.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey(); 
                    break;
                case 2:
                    Console.Write("Ingrese el nombre de la fruta a eliminar: ");
                    string frutaEliminar = Console.ReadLine();
                    bool frutaEliminada = false;

                    for (int i = 0; i < frutas.Count; i++)
                    {
                        if (frutas[i].Equals(frutaEliminar, StringComparison.OrdinalIgnoreCase))
                        {
                            frutas.RemoveAt(i);
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
                    Console.WriteLine("Lista de frutas:");
                    foreach (string fruta in frutas)
                    {
                        Console.WriteLine(fruta);
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey(); 
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey(); 
                    break;
            }
        } while (opcion != 4);
    }
}
