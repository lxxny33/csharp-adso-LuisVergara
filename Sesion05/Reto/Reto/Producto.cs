using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    internal class Producto
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
                        throw new Exception("El nombre no puede estar vacio");
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
                        throw new Exception("El precio debe ser mayor que cero");
                    }

                    precio = value;
                }
            }

            public int Stock { get; private set; }

            public Producto(string codigo, string nombre, decimal precio, int stock)
            {
                if (string.IsNullOrWhiteSpace(codigo))
                {
                    throw new Exception("El codigo es obligatorio");
                }

                if (stock < 0)
                {
                    throw new Exception("El stock no puede ser negativo");
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
                    throw new Exception("La cantidad debe ser mayor que cero");
                }

                Stock += cantidad;
            }

            public bool Vender(int cantidad)
            {
                if (cantidad <= 0 || cantidad > Stock)
                {
                    return false;
                }

                Stock -= cantidad;
                return true;
            }

    }
}
