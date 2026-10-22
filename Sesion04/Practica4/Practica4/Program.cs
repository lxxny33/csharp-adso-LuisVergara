Console.WriteLine("Hello, World!");

//Crear una lista
List<string> compras = ["Arroz", "Leche"];
Console.WriteLine($"Tienes antes de agregar {compras.Count}");
compras.Add("Café"); //Permite agregar a una lista
Console.WriteLine($"Tienes despus de agregar {compras.Count}");
//compras.Remove("Leche"); // permite eliminar un elemento


Console.WriteLine(string.Join(", ", compras));
compras.Sort();//ordena la lista
Console.WriteLine(string.Join(", ", compras));
Console.WriteLine(" ===================");

Dictionary<String, string> agenda = new(StringComparer.OrdinalIgnoreCase);
agenda["Ana"] = "3005555555";
agenda["Luis"] = "3154444444";

if(agenda.TryGetValue("ana", out string? telefono))
{
    Console.WriteLine($"Ana : {telefono}");
}
foreach (var (nombre, tel) in agenda)
{
    Console.WriteLine($"{nombre}: {tel}");
}
// Diccionario con listas adentro

Dictionary<string, List<double>> notas = new(StringComparer.OrdinalIgnoreCase);
notas["Miguel"] = [];
notas["Miguel"].Add(4.5);
notas["Miguel"].Add(3.8);
notas["Miguel"].Add(1);

foreach(var (nombre, nota) in notas)
{
    Console.WriteLine($"{nombre}:{string.Join(" - ", notas)}");
}
// Sacar numeros pares
List<int> numeros = [10, 75, 45, 23, 61, 93, 72, 69, 37, 40, 84, 96];
Console.WriteLine(string.Join(", ", numeros));
var pares = numeros.Where(n => n % 2 == 0).ToList();
Console.WriteLine(string.Join(", ", pares));

//Ordenar numero mayores
List<int> ordenadosDesc = numeros.OrderByDescending(n => n).Take(3).ToList();
foreach (var num in ordenadosDesc)
{
    Console.WriteLine(string.Join(", ", num)); ;
}

//Sacar el promedio(La suma no es necesaria hacerla ya que esta el Average)
Console.WriteLine($"Suma: {numeros.Sum()}, Promedio: {numeros.Average()}");

Console.WriteLine($"Algun numero es mayor a 80? {numeros.Any(n=>n>80)}");

Console.WriteLine("===============");

//Record 

List<Producto> productos = [

    new("Cuadernos", "Papeleria", 6500m, 40),
    new("Mouse", "Tecnologia", 4500m, 3),
    new("USB 64 Gb", "Tecnolofia", 3800m, 15),

    ];
var baratos = productos.Where(p => p.Precio < 1000m);
var masCaro = productos.MaxBy(p => p.Precio);
var masCaro1 = productos.Max(p => p.Precio);
decimal valorInventario = productos.Sum(p => p.Precio * p.Stock);

Console.WriteLine($"Ma caro {masCaro}");
Console.WriteLine($"Ma caro {masCaro1}");
Console.WriteLine($"Valor inventario {valorInventario}");
Console.WriteLine($"Menosres a 10000 \n{string.Join("\n", baratos)}");



var porCategoria = productos
    .GroupBy(p => p.Categoria)
    .Select(g => new { Categoria = g.Key, Unidades = g.Sum(p => p.Stock) });

foreach (var c in porCategoria)
{
    Console.WriteLine($"{c.Categoria,-12}{c.Unidades} unidades");
}

record Producto(String Nombre, string Categoria, decimal Precio, int Stock);