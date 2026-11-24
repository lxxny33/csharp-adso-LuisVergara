
using Inventario.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Datos;

public class RepositorioSqlite : IRepositorioProductos
{
    public RepositorioSqlite()
    {
        using var db = new InventarioDbContext();
        db.Database.EnsureCreated();
    }

    public List<Producto> ObtenerTodos()
    {
        using var db = new InventarioDbContext();

        return db.Productos
            .Include(p => p.Categoria)
            .ToList();
    }

    public Producto? BuscarPorCodigo(string codigo)
    {
        using var db = new InventarioDbContext();

        return db.Productos
            .FirstOrDefault(p => p.Codigo == codigo);
    }

    public void Agregar(Producto producto)
    {
        using var db = new InventarioDbContext();

        db.Productos.Add(producto);
        db.SaveChanges();
    }

    public void Actualizar(Producto producto)
    {
        using var db = new InventarioDbContext();

        Producto? productoGuardado = db.Productos
            .FirstOrDefault(p => p.Codigo == producto.Codigo);

        if (productoGuardado != null)
        {
            productoGuardado.Nombre = producto.Nombre;
            productoGuardado.Precio = producto.Precio;
            productoGuardado.AsignarCategoria(producto.CategoriaId);

            db.SaveChanges();
        }
    }

    public void Eliminar(string codigo)
    {
        using var db = new InventarioDbContext();

        Producto? producto = db.Productos
            .FirstOrDefault(p => p.Codigo == codigo);

        if (producto != null)
        {
            db.Productos.Remove(producto);
            db.SaveChanges();
        }
    }
}
