
namespace Tarea
{
    class PagoEfectivo : IMetodoPago
    {
        public string Nombre { get; } = "Efectivo";

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0m;
        }
        public bool Validar(decimal monto)
        {
            return monto > 0;
        }
    }
}
