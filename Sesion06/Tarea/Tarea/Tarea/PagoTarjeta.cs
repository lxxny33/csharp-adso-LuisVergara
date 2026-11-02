
namespace Tarea
{
    class PagoTarjeta : IMetodoPago, IReembolsable
    {
        private string numeroTarjeta;

        public string Nombre { get; } = "Tarjeta";

        public PagoTarjeta(string numero)
        {
            numeroTarjeta = numero;
        }

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.03m;
        }

        public bool Validar(decimal monto)
        {
            if (monto <= 0)
            {
                return false;
            }

            if (numeroTarjeta.Length != 16)
            {
                return false;
            }

            foreach (char digito in numeroTarjeta)
            {
                if (!char.IsDigit(digito))
                {
                    return false;
                }
            }

            return true;
        }

        public void Reembolsar(decimal monto)
        {
            Console.WriteLine("Reembolso de tarjeta realizado: $" + monto);
        }
    }
}
