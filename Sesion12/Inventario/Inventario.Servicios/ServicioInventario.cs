
using Inventario.Datos;
using Inventario.Modelos;

namespace Inventario.Servicios;

public class ServicioInventario
{
    private readonly IRepositorioProductos _repositorio;

    public ServicioInventario(IRepositorioProductos repositorio)
    {
        _repositorio = repositorio;
    }

    public List<Producto> Listar()
    {
        return _repositorio.ObtenerTodos()
            .OrderBy(p => p.Nombre)
            .ToList();
    }

    public void Agregar(Producto producto)
    {
        if (_repositorio.BuscarPorCodigo(producto.Codigo) != null)
        {
            throw new ArgumentException(
                $"Ya existe un producto con el codigo {producto.Codigo}.");
        }

        _repositorio.Agregar(producto);
    }

    public void AgregarStock(string codigo, int cantidad)
    {
        Producto producto = _repositorio.BuscarPorCodigo(codigo)
            ?? throw new ArgumentException(
                $"No existe el producto {codigo}.");

        producto.AgregarStock(cantidad);

        _repositorio.Actualizar(producto);
    }

    public void Vender(string codigo, int cantidad)
    {
        Producto producto = _repositorio.BuscarPorCodigo(codigo)
            ?? throw new ArgumentException(
                $"No existe el producto {codigo}.");

        producto.Vender(cantidad);

        _repositorio.Actualizar(producto);
    }

    public List<Producto> StockBajo()
    {
        return _repositorio.ObtenerTodos()
            .Where(p => p.Stock < 5)
            .OrderBy(p => p.Stock)
            .ToList();
    }
    public List<Producto> BuscarPorTexto(string texto)
    {
        return _repositorio.ObtenerTodos()
            .Where(p =>
                p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase))
            .OrderBy(p => p.Nombre)
            .ToList();
    }
    public void Eliminar(string codigo)
    {
        Producto producto = _repositorio.BuscarPorCodigo(codigo)
            ?? throw new ArgumentException($"No existe el producto {codigo}.");

        _repositorio.Eliminar(codigo);
    }
    public decimal ValorInventario()
    {
        decimal total = 0;

        foreach (Producto producto in Listar())
        {
            total += producto.Precio * producto.Stock;
        }

        return total;
    }
    public void Actualizar(
    string codigo,
    string nombre,
    decimal precio,
    int? categoriaId)
    {
        Producto producto = _repositorio.BuscarPorCodigo(codigo)
            ?? throw new ArgumentException(
                $"No existe el producto {codigo}.");

        producto.Nombre = nombre;
        producto.Precio = precio;
        producto.AsignarCategoria(categoriaId);

        _repositorio.Actualizar(producto);
    }
    public List<Producto> MasValiosos(int cantidad = 5)
    {
        return _repositorio.ObtenerTodos()
            .OrderByDescending(p => p.Precio * p.Stock)
            .Take(cantidad)
            .ToList();
    }
}
