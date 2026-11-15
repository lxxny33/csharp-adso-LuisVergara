
using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

var servicio = new ServicioInventario(
    new RepositorioJson("inventario.json"));

int opcion = 0;

while (opcion != 8)
{
    Console.WriteLine("\n===== INVENTARIO =====");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender producto");
    Console.WriteLine("4. Ver inventario");
    Console.WriteLine("5. Ver stock bajo");
    Console.WriteLine("6. Buscar producto");
    Console.WriteLine("7. Eliminar producto");
    Console.WriteLine("8. Salir");

    opcion = LeerEntero("Seleccione una opcion: ", 1, 8);

    try
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("\n--- REGISTRAR PRODUCTO ---");

                string codigo = LeerTexto("Codigo: ");
                string nombre = LeerTexto("Nombre: ");
                decimal precio = LeerDecimal("Precio: ");
                int stock = LeerEntero("Stock inicial: ", 0, int.MaxValue);

                Producto producto = new Producto(
                    codigo, nombre, precio, stock);

                servicio.Agregar(producto);

                Console.WriteLine("Producto registrado correctamente.");
                break;

            case 2:
                Console.WriteLine("\n--- AGREGAR STOCK ---");

                codigo = LeerTexto("Codigo del producto: ");
                int cantidad = LeerEntero(
                    "Cantidad a agregar: ", 1, int.MaxValue);

                servicio.AgregarStock(codigo, cantidad);

                Console.WriteLine("Stock actualizado correctamente.");
                break;

            case 3:
                Console.WriteLine("\n--- VENDER PRODUCTO ---");

                codigo = LeerTexto("Codigo del producto: ");
                cantidad = LeerEntero(
                    "Cantidad a vender: ", 1, int.MaxValue);

                servicio.Vender(codigo, cantidad);

                Console.WriteLine("Venta realizada correctamente.");
                break;

            case 4:
                Console.WriteLine("\n--- INVENTARIO COMPLETO ---");

                List<Producto> productos = servicio.Listar();

                if (productos.Count == 0)
                {
                    Console.WriteLine("No hay productos registrados.");
                }

                foreach (Producto p in productos)
                {
                    Console.WriteLine(
                        $"{p.Codigo} | {p.Nombre} | ${p.Precio:N0} | Stock: {p.Stock}");
                }
                break;

            case 5:
                Console.WriteLine("\n--- PRODUCTOS CON STOCK BAJO ---");

                List<Producto> bajos = servicio.StockBajo();

                if (bajos.Count == 0)
                {
                    Console.WriteLine("No hay productos con stock bajo.");
                }

                foreach (Producto p in bajos)
                {
                    Console.WriteLine(
                        $"{p.Codigo} | {p.Nombre} | Stock: {p.Stock}");
                }
                break;

            case 6:
                Console.WriteLine("\n--- BUSCAR PRODUCTO ---");

                string texto = LeerTexto("Ingrese nombre o codigo: ");
                List<Producto> encontrados = servicio.BuscarPorTexto(texto);

                if (encontrados.Count == 0)
                {
                    Console.WriteLine("No se encontraron productos.");
                }
                else
                {
                    foreach (Producto p in encontrados)
                    {
                        Console.WriteLine(
                            $"{p.Codigo} | {p.Nombre} | ${p.Precio:N0} | Stock: {p.Stock}");
                    }
                }
                break;

            case 7:
                Console.WriteLine("\n--- ELIMINAR PRODUCTO ---");

                codigo = LeerTexto("Codigo del producto: ");

                string respuestaEliminar = "";

                while (respuestaEliminar != "s" && respuestaEliminar != "n")
                {
                    Console.Write("¿Esta seguro de eliminarlo? (s/n): ");
                    respuestaEliminar = (Console.ReadLine() ?? "").Trim().ToLower();

                    if (respuestaEliminar != "s" && respuestaEliminar != "n")
                    {
                        Console.WriteLine("Ingrese solamente s o n.");
                    }
                }

                if (respuestaEliminar == "s")
                {
                    servicio.Eliminar(codigo);
                    Console.WriteLine("Producto eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("Eliminacion cancelada.");
                }
                break;

            case 8:
                Console.WriteLine("Hasta pronto.");
                break;
        }
    }
    catch (StockInsuficienteException ex)
    {
        Console.WriteLine($"Error de venta: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

static string LeerTexto(string mensaje)
{
    string texto = "";

    while (string.IsNullOrWhiteSpace(texto))
    {
        Console.Write(mensaje);
        texto = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(texto))
        {
            Console.WriteLine("Este campo no puede estar vacio.");
        }
    }

    return texto.Trim();
}

static int LeerEntero(string mensaje, int minimo, int maximo)
{
    int numero = 0;
    bool valido = false;

    while (!valido)
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine() ?? "";

        if (int.TryParse(entrada, out numero)
            && numero >= minimo && numero <= maximo)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Ingrese un numero entero valido.");
        }
    }

    return numero;
}

static decimal LeerDecimal(string mensaje)
{
    decimal numero = 0;
    bool valido = false;

    while (!valido)
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine() ?? "";

        if (decimal.TryParse(entrada, out numero) && numero > 0)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Ingrese un precio valido mayor que cero.");
        }
    }

    return numero;
}
