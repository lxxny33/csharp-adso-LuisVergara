
using System;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria(
                "Luis", "1", 500000
            );

            CuentaBancaria cuenta2 = new CuentaBancaria(
                "Carlos", "2", 200000
            );

            Console.WriteLine("===== CUENTAS BANCARIAS =====");

            Console.WriteLine("\nCuenta 1:");
            Console.WriteLine("Titular: " + cuenta1.Titular);
            Console.WriteLine("Numero: " + cuenta1.Numero);
            Console.WriteLine("Saldo: $" + cuenta1.Saldo);

            Console.WriteLine("\nCuenta 2:");
            Console.WriteLine("Titular: " + cuenta2.Titular);
            Console.WriteLine("Numero: " + cuenta2.Numero);
            Console.WriteLine("Saldo: $" + cuenta2.Saldo);

            Console.WriteLine("\n===== OPERACIONES =====");

            if (cuenta1.Depositar(100000))
            {
                Console.WriteLine("Deposito realizado correctamente");
            }
            else
            {
                Console.WriteLine("Deposito rechazado");
            }

            if (cuenta1.Retirar(1000000))
            {
                Console.WriteLine("Retiro realizado correctamente");
            }
            else
            {
                Console.WriteLine("Retiro rechazado: saldo insuficiente");
            }
            if (cuenta1.Transferir(cuenta2, 150000))
            {
                Console.WriteLine("Transferencia realizada correctamente");
            }
            else
            {
                Console.WriteLine("Transferencia rechazada");
            }

            Console.WriteLine("\n===== SALDOS FINALES =====");

            Console.WriteLine("Saldo de Luis: $" + cuenta1.Saldo);
            Console.WriteLine("Saldo de Carlos: $" + cuenta2.Saldo);
        }
    }
}
