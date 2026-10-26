
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<string, List<double>> notas =
        new(StringComparer.OrdinalIgnoreCase);

    static void Main()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n1. Registrar\n2. Agregar nota\n3. Listar");
            Console.WriteLine("4. Ranking\n5. Mejor y aprobados");
            Console.WriteLine("6. Eliminar\n7. Salir");
            Console.Write("Opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1: Registrar(); break;
                    case 2: AgregarNota(); break;
                    case 3: Listar(); break;
                    case 4: Ranking(); break;
                    case 5: MejorYAprobados(); break;
                    case 6: Eliminar(); break;
                    case 7: Console.WriteLine("Hasta luego"); break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }
            }
        } while (opcion != 7);
    }
    static void Registrar()
    {
        Console.Write("Nombre: ");
        string nombre = (Console.ReadLine() ?? "").Trim();

        if (nombre == "")
            Console.WriteLine("Nombre vacio");
        else if (notas.ContainsKey(nombre))
            Console.WriteLine("Ya existe");
        else
        {
            notas[nombre] = [];
            Console.WriteLine("Registrado");
        }
    }
    static void AgregarNota()
    {
        Console.Write("Nombre: ");
        string nombre = (Console.ReadLine() ?? "").Trim();

        if (notas.TryGetValue(nombre, out List<double>? lista))
        {
            Console.Write("Nota (0 a 5): ");

            if (double.TryParse(Console.ReadLine(), out double nota)
                && nota >= 0 && nota <= 5)
                lista.Add(nota);
            else
                Console.WriteLine("Nota invalida");
        }
        else
            Console.WriteLine("No existe");
    }
    static void Listar()
    {
        foreach (var (nombre, lista) in notas)
        {
            double promedio = lista.Count > 0 ? lista.Average() : 0;
            string juicio = lista.Count == 0 ? "N/A" :
                            promedio >= 3 ? "A" : "D";
            Console.WriteLine(
                $"{nombre,-15} {lista.Count,-10} {promedio,-10:F2} {juicio}");
        }
    }
    static void Ranking()
    {
        var ranking = notas.Where(a => a.Value.Count > 0)
            .OrderByDescending(a => a.Value.Average());

        foreach (var (nombre, lista) in ranking)
            Console.WriteLine($"{nombre,-15} {lista.Average():F2}");
    }
    static void MejorYAprobados()
    {
        var lista = notas.Where(a => a.Value.Count > 0);

        if (lista.Any())
        {
            var mejor = lista.OrderByDescending(a => a.Value.Average()).First();
            Console.WriteLine($"Mejor: {mejor.Key} - {mejor.Value.Average():F2}");
            Console.WriteLine($"Aprobados: {lista.Count(a => a.Value.Average() >= 3)}");
        }
        else
            Console.WriteLine("No hay notas registradas");
    }
    static void Eliminar()
    {
        Console.Write("Nombre: ");
        string nombre = (Console.ReadLine() ?? "").Trim();

        if (notas.Remove(nombre))
            Console.WriteLine("Eliminado");
        else
            Console.WriteLine("No existe");
    }
}
