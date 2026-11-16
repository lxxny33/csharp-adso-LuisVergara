using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{

    public class ConversorTemperatura
    {
        public double Convertir(double valor, string origen, string destino)
        {
            double celsius = valor;

            // Convertir el valor de origen a Celsius
            if (origen == "Fahrenheit")
            {
                celsius = (valor - 32) * 5 / 9;
            }
            else if (origen == "Kelvin")
            {
                celsius = valor - 273.15;
            }

            // Convertir de Celsius a la unidad destino
            if (destino == "Fahrenheit")
            {
                return (celsius * 9 / 5) + 32;
            }
            else if (destino == "Kelvin")
            {
                return celsius + 273.15;
            }

            return celsius;
        }
    }

}
