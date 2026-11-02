
using System;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesadorPagos procesador = new ProcesadorPagos();

            PagoEfectivo efectivo = new PagoEfectivo();

            PagoTarjeta tarjeta = new PagoTarjeta("1234567890123456");

            PagoBilletera billetera = new PagoBilletera();

            Console.WriteLine("===== SISTEMA DE PAGOS =====");
            Console.WriteLine("\n--- PAGO EN EFECTIVO ---");
            procesador.Cobrar(efectivo, 100000);
            Console.WriteLine("\n--- PAGO CON TARJETA ---");
            procesador.Cobrar(tarjeta, 500000);
            Console.WriteLine("\n--- PAGO CON BILLETERA ---");
            procesador.Cobrar(billetera, 1500000);
            Console.WriteLine("\n--- PAGO RECHAZADO ---");
            procesador.Cobrar(billetera, 2500000);

            Console.WriteLine("\n===== REEMBOLSOS =====");

            procesador.Devolver(efectivo, 50000);

            procesador.Devolver(tarjeta, 100000);

            procesador.Devolver(billetera, 200000);
        }
    }
}
