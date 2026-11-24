
using Inventario.Modelos;

namespace Inventario.Datos;

public class RepositorioCategorias
{
    public List<Categoria> ObtenerTodas()
    {
        using var db = new InventarioDbContext();

        return db.Categorias.ToList();
    }

    public void Agregar(Categoria categoria)
    {
        using var db = new InventarioDbContext();

        db.Categorias.Add(categoria);
        db.SaveChanges();
    }

    public void Eliminar(int id)
    {
        using var db = new InventarioDbContext();

        Categoria? categoria = db.Categorias
            .FirstOrDefault(c => c.Id == id);

        if (categoria != null)
        {
            db.Categorias.Remove(categoria);
            db.SaveChanges();
        }
    }
}
