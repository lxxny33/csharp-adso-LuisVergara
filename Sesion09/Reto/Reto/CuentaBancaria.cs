using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{

    public class CuentaBancaria
    {
        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }

        public string UltimoError { get; private set; }

        public CuentaBancaria(string titular, string numero, decimal saldoInicial = 0)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldoInicial;
        }

        public bool Depositar(decimal monto)
        {
            UltimoError = "";

            if (monto <= 0 || monto % 10000 != 0)
            {
                UltimoError = "El monto debe ser múltiplo de $10.000.";
                return false;
            }

            Saldo += monto;
            return true;
        }

        public bool Retirar(decimal monto)
        {
            UltimoError = "";

            if (monto <= 0 || monto % 10000 != 0)
            {
                UltimoError = "El monto debe ser múltiplo de $10.000.";
                return false;
            }

            if (monto > Saldo)
            {
                UltimoError = "No tienes saldo suficiente.";
                return false;
            }

            Saldo -= monto;
            return true;
        }

        public bool Transferir(CuentaBancaria destino, decimal monto)
        {
            UltimoError = "";

            if (destino == null)
            {
                UltimoError = "La cuenta de destino no existe.";
                return false;
            }

            if (monto <= 0 || monto % 10000 != 0)
            {
                UltimoError = "El monto debe ser múltiplo de $10.000.";
                return false;
            }

            if (monto > Saldo)
            {
                UltimoError = "No tienes saldo suficiente.";
                return false;
            }

            Saldo -= monto;
            destino.Saldo += monto;

            return true;
        }
    }

}
