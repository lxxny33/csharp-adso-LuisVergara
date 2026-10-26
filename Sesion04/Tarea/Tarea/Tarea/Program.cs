
using System;
using System.Collections.Generic;
using System.Linq;

List<Venta> ventas =
[
    new("Portátil", "Medellín", 2, 2_800_000m),
    new("Mouse", "Bogotá", 10, 45_000m),
    new("Teclado", "Cali", 5, 120_000m),
    new("Monitor", "Medellín", 3, 750_000m),
    new("Mouse", "Medellín", 8, 45_000m),
    new("Portátil", "Bogotá", 1, 2_800_000m),
    new("Diadema", "Cali", 6, 180_000m),
    new("Monitor", "Bogotá", 2, 750_000m),
    new("Teclado", "Medellín", 4, 120_000m),
    new("Diadema", "Bogotá", 3, 180_000m),
    new("Portátil", "Cali", 2, 2_800_000m),
    new("Mouse", "Cali", 12, 45_000m)
];

decimal total = ventas.Sum(v => v.Cantidad * v.PrecioUnitario);
Console.WriteLine($"Total vendido: ${total:N0}");

decimal promedio = ventas.Average(v => v.Cantidad * v.PrecioUnitario);
Console.WriteLine($"Promedio por venta: ${promedio:N0}");

var ciudades = ventas
    .GroupBy(v => v.Ciudad)
    .Select(g => new
    {
        Ciudad = g.Key,
        Total = g.Sum(v => v.Cantidad * v.PrecioUnitario)
    })
    .OrderByDescending(v => v.Total);

Console.WriteLine("\nVENTAS POR CIUDAD");
foreach (var ciudad in ciudades)
{
    Console.WriteLine($"{ciudad.Ciudad,-12} ${ciudad.Total:N0}");
}

var top3 = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new
    {
        Producto = g.Key,
        Ingresos = g.Sum(v => v.Cantidad * v.PrecioUnitario)
    })
    .OrderByDescending(v => v.Ingresos)
    .Take(3);

Console.WriteLine("\n3 PRODUCTOS");
foreach (var producto in top3)
{
    Console.WriteLine($"{producto.Producto,-12} ${producto.Ingresos:N0}");
}

var masVendido = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new
    {
        Producto = g.Key,
        Unidades = g.Sum(v => v.Cantidad)
    })
    .OrderByDescending(v => v.Unidades)
    .First();
Console.WriteLine($"\nProducto mas vendido: {masVendido.Producto}");
Console.WriteLine($"Unidades vendidas: {masVendido.Unidades}");
record Venta(string Producto, string Ciudad, int Cantidad, decimal PrecioUnitario);

