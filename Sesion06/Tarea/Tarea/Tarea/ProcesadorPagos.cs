
namespace Tarea
{
    class ProcesadorPagos
    {
        public void Cobrar(IMetodoPago metodo, decimal monto)
        {
            if (metodo.Validar(monto))
            {
                decimal comision = metodo.CalcularComision(monto);
                decimal total = monto + comision;

                Console.WriteLine("\nPago realizado correctamente");
                Console.WriteLine("Metodo: " + metodo.Nombre);
                Console.WriteLine("Monto: $" + monto);
                Console.WriteLine("Comision: $" + comision);
                Console.WriteLine("Total: $" + total);
            }
            else
            {
                Console.WriteLine("\nPago rechazado. Datos invalidos");
            }
        }

        public void Devolver(IMetodoPago metodo, decimal monto)
        {
            if (metodo is IReembolsable)
            {
                if (monto > 0)
                {
                    IReembolsable reembolsable =
                        (IReembolsable)metodo;

                    reembolsable.Reembolsar(monto);
                }
                else
                {
                    Console.WriteLine("Monto de reembolso invalido");
                }
            }
            else
            {
                Console.WriteLine("Este metodo de pago no permite reembolsos");
            }
        }
    }
}

