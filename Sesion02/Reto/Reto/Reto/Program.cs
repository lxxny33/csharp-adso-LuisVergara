using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 500000;
            string contraseña = "1234";
            bool acceso = false;

            for (int i= 1; i <= 3; i++)
            {
                Console.WriteLine("Ingrese el pin");
                string pin = Console.ReadLine() ?? "";
                if (pin == contraseña)
                {
                    acceso = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Pin incorrecto");
                    Console.WriteLine("Intentos restantes: " + (3 - i));

                }
            }
            if (!acceso)
            {
                Console.WriteLine("Tarjeta bloqueada");
                return;

            }
            int opcion;

            do
            {
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion");

                string entrada = Console.ReadLine() ?? "";

                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Opcion no valida");
                    opcion = 0;
                    continue;
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Saldo actual " + saldo);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el valor que va a depositar: ");
                        string depositotexto = Console.ReadLine() ?? "";

                        if (decimal.TryParse(depositotexto, out decimal deposito)
                        && deposito > 0)
                        {
                            saldo += deposito;
                            Console.WriteLine("Deposito exitoso");
                            Console.WriteLine("Nuevo saldo: " + saldo);
                        }
                        else
                        {
                            Console.WriteLine("Error: ingrese un numero positivo");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el valor que va a retirar: ");
                        string retirotexto = Console.ReadLine() ?? "";

                        if (decimal.TryParse(retirotexto, out decimal retiro) && retiro > 0)
                        {
                            if (retiro % 10000 == 0)
                            {
                                if (retiro <= saldo)
                                {
                                    saldo -= retiro;
                                    Console.WriteLine("Retiro exitoso");
                                    Console.WriteLine("Nuevo saldo: " + saldo);
                                }
                                else
                                {
                                    Console.WriteLine("Saldo insuficiente");
                                }
                            }
                            else
                            {
                                Console.WriteLine("El retiro tiene que ser multiplo de 10000");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un numero positivo");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Gracias por utilizar nuestro cajero");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
            } while (opcion != 4);



        }
    }
}
