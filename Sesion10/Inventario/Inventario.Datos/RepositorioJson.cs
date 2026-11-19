
using System.Text.Json;
using Inventario.Modelos;

namespace Inventario.Datos;

public class RepositorioJson : IRepositorioProductos
{
    private readonly string _ruta;

    public RepositorioJson(string ruta)
    {
        _ruta = ruta;
    }

    public List<Producto> ObtenerTodos()
    {
        if (!File.Exists(_ruta))
        {
            return [];
        }

        try
        {
            return JsonSerializer.Deserialize<List<Producto>>(
                File.ReadAllText(_ruta)) ?? [];
        }
        catch (JsonException)
        {
            File.Copy(_ruta, _ruta + ".danado", overwrite: true);
            return [];
        }
    }

    private void Guardar(List<Producto> lista)
    {
        File.WriteAllText(
            _ruta,
            JsonSerializer.Serialize(lista,
                new JsonSerializerOptions { WriteIndented = true })
        );
    }

    public Producto? BuscarPorCodigo(string codigo)
    {
        return ObtenerTodos().FirstOrDefault(
            p => p.Codigo.Equals(codigo,
                StringComparison.OrdinalIgnoreCase));
    }

    public void Agregar(Producto producto)
    {
        List<Producto> lista = ObtenerTodos();

        lista.Add(producto);

        Guardar(lista);
    }

    public void Actualizar(Producto producto)
    {
        List<Producto> lista = ObtenerTodos();

        int posicion = lista.FindIndex(
            p => p.Codigo == producto.Codigo);

        if (posicion >= 0)
        {
            lista[posicion] = producto;
            Guardar(lista);
        }
    }

    public void Eliminar(string codigo)
    {
        List<Producto> lista = ObtenerTodos();

        lista.RemoveAll(
            p => p.Codigo.Equals(codigo,
                StringComparison.OrdinalIgnoreCase));

        Guardar(lista);
    }
}
