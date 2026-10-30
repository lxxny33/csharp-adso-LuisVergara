
using Reto;

List<Producto> inventario = new List<Producto>
{
    new Producto("1", "Portatil", 2800000, 5),
    new Producto("2", "Mouse", 45000, 10),
    new Producto("3", "Teclado", 120000, 8)
};

List<LineaVenta> carrito = new List<LineaVenta>();

int opcion = 0;

while (opcion != 6)
{
    Console.WriteLine("\n===== TIENDA =====");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender producto");
    Console.WriteLine("4. Ver carrito");
    Console.WriteLine("5. Ver inventario");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opcion: ");

    int.TryParse(Console.ReadLine(), out opcion);

    try
    {
        if (opcion == 1)
        {
            Console.Write("Codigo: ");
            string codigo = Console.ReadLine();

            if (inventario.Any(p => p.Codigo == codigo.ToUpper()))
            {
                Console.WriteLine("Ese codigo ya existe");
            }
            else
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Console.Write("Stock: ");
                int stock = int.Parse(Console.ReadLine());

                Producto nuevo = new Producto(codigo, nombre, precio, stock);

                inventario.Add(nuevo);

                Console.WriteLine("Producto registrado correctamente");
            }
        }
        else if (opcion == 2)
        {
            Console.Write("Codigo del producto: ");
            string codigo = Console.ReadLine().ToUpper();

            Producto producto = inventario.FirstOrDefault(p => p.Codigo == codigo);

            if (producto == null)
            {
                Console.WriteLine("El producto no existe");
            }
            else
            {
                Console.Write("Cantidad para agregar: ");
                int cantidad = int.Parse(Console.ReadLine());

                producto.AgregarStock(cantidad);

                Console.WriteLine("Stock actualizado.");
            }
        }
        else if (opcion == 3)
        {
            Console.Write("Codigo del producto: ");
            string codigo = Console.ReadLine().ToUpper();

            Producto producto = inventario.FirstOrDefault(p => p.Codigo == codigo);

            if (producto == null)
            {
                Console.WriteLine("El producto no existe");
            }
            else
            {
                Console.Write("Cantidad a vender: ");
                int cantidad = int.Parse(Console.ReadLine());

                if (producto.Vender(cantidad))
                {
                    decimal subtotal = producto.Precio * cantidad;

                    carrito.Add(new LineaVenta(
                        producto.Codigo,
                        producto.Nombre,
                        cantidad,
                        subtotal
                    ));

                    Console.WriteLine("Venta realizada correctamente");
                }
                else
                {
                    Console.WriteLine("Cantidad invalida o stock insuficiente");
                }
            }
        }
        else if (opcion == 4)
        {
            Console.WriteLine("\n===== CARRITO =====");

            foreach (LineaVenta linea in carrito)
            {
                Console.WriteLine(
                    $"{linea.Nombre} | Cantidad: {linea.Cantidad} | Subtotal: ${linea.Subtotal:N0}"
                );
            }

            decimal total = carrito.Sum(l => l.Subtotal);

            Console.WriteLine("----------------------");
            Console.WriteLine($"TOTAL: ${total:N0}");
        }
        else if (opcion == 5)
        {
            Console.WriteLine("\n===== INVENTARIO =====");

            foreach (Producto producto in inventario)
            {
                Console.WriteLine(
                    $"{producto.Codigo} | {producto.Nombre} | Precio: ${producto.Precio:N0} | Stock: {producto.Stock}"
                );
            }
        }
        else if (opcion == 6)
        {
            Console.WriteLine("Gracias por utilizar la tienda");
        }
        else
        {
            Console.WriteLine("Opcion invalida");
        }
    }
    catch (Exception error)
    {
        Console.WriteLine("Error: " + error.Message);
    }
}
