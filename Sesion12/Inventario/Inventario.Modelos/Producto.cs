using System;
using System.Collections.Generic;
using System.Text;


namespace Inventario.Modelos;

public class Producto
{
    public string Codigo { get; private set; }

    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre no puede estar vacio");
            }

            nombre = value;
        }
    }

    private decimal precio;

    public decimal Precio
    {
        get { return precio; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor que cero");
            }

            precio = value;
        }
    }

    public int Stock { get; private set; }
    public int? CategoriaId { get; private set; }

    public Categoria? Categoria { get; private set; }
    private Producto()
    {
        Codigo = "";
        nombre = "";
    }

    public Producto(string codigo, string nombre, decimal precio, int stock)
    {
        if (string.IsNullOrWhiteSpace(codigo))
        {
            throw new ArgumentException("El codigo es obligatorio");
        }

        if (stock < 0)
        {
            throw new ArgumentException("El stock no puede ser negativo");
        }

        Codigo = codigo.ToUpper();
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    public void AgregarStock(int cantidad)
    {
        if (cantidad <= 0)
        {
            throw new ArgumentException("La cantidad debe ser mayor que cero");
        }

        Stock += cantidad;
    }

    public void Vender(int cantidad)
    {
        if (cantidad <= 0)
        {
            throw new ArgumentException("La cantidad debe ser mayor que cero");
        }

        if (cantidad > Stock)
        {
            throw new StockInsuficienteException(
                $"Stock insuficiente. Disponibles: {Stock}, solicitadas: {cantidad}");
        }

        Stock -= cantidad;
    }
    public void AsignarCategoria(int? categoriaId)
    {
        CategoriaId = categoriaId;
    }
}
