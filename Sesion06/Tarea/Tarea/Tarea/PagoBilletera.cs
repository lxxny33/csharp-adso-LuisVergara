
namespace Tarea
{
    class PagoBilletera : IMetodoPago, IReembolsable
    {
        public string Nombre { get; } = "Billetera digital";

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.01m;
        }

        public bool Validar(decimal monto)
        {
            return monto > 0 && monto <= 2000000;
        }

        public void Reembolsar(decimal monto)
        {
            Console.WriteLine("Reembolso de billetera realizado: $" + monto);
        }
    }
}