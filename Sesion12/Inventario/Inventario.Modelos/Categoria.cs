
namespace Inventario.Modelos;

public class Categoria
{
    public int Id { get; private set; }

    public string Nombre { get; private set; }

    public string Descripcion { get; private set; }

    public ICollection<Producto> Productos { get; private set; }

    private Categoria()
    {
        Nombre = "";
        Descripcion = "";
        Productos = new List<Producto>();
    }

    public Categoria(string nombre, string descripcion)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre es obligatorio");

        Nombre = nombre;
        Descripcion = descripcion;
        Productos = new List<Producto>();
    }
}
