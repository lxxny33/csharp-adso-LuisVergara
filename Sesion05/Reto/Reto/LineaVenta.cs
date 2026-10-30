using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public record LineaVenta(
        string Codigo,
        string Nombre,
        int Cantidad,
        decimal Subtotal
    );
}
