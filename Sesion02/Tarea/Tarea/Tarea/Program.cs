using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int secreto = aleatorio.Next(1, 101);
            int numero= 0;
            int intento;

            Console.WriteLine("Adivina el numero entre 1 y 100.");
            Console.WriteLine("Tienes 7 intentos.");

            for (intento = 1; intento <= 7; intento++)
            {
                Console.Write("Intento " + intento + ": ");
                numero = int.Parse(Console.ReadLine());

                if (numero == secreto)
                {
                    Console.WriteLine("Adivinaste el numero");
                    Console.WriteLine("Intentos utilizados: " + intento);
                    break;
                }
                else if (numero < secreto)
                {
                    Console.WriteLine("El numero secreto es mayor.");
                }
                else
                {
                    Console.WriteLine("El numero secreto es menor.");
                }
            }

            if (numero != secreto)
            {
                Console.WriteLine("Perdiste, el numero era: " + secreto);
            }
            ;
        }
    }
}
