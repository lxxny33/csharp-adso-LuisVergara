
using System;
using System.Windows.Forms;

namespace Reto
{
    public partial class Form1 : Form
    {
        private readonly CuentaBancaria _cuenta =
            new("Luis", "001-123", 500000m);

        // Cuenta de destino para probar las transferencias.
        private readonly CuentaBancaria _cuentaDestino =
            new("Cuenta destino", "002-456", 0m);

        public Form1()
        {
            InitializeComponent();

            ActualizarSaldo();
        }

        private void ActualizarSaldo()
        {
            lblTitular.Text = "Titular: " + _cuenta.Titular;

            lblSaldo.Text = "Saldo: " +
                _cuenta.Saldo.ToString("C0");
        }


        private void btnDepositar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            if (_cuenta.Depositar(monto))
            {
                string texto = DateTime.Now.ToString("HH:mm:ss") +
                    " | Depósito | " + monto.ToString("C0");

                lstMovimientos.Items.Insert(0, texto);

                MessageBox.Show(
                            "Deposito realizado correctamente.",
                            "Deposito exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(_cuenta.UltimoError,
                    "Error al depositar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            ActualizarSaldo();
        }



        private void btnRetirar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            if (_cuenta.Retirar(monto))
            {
                string texto = DateTime.Now.ToString("HH:mm:ss") +
                    " | Retiro | " + monto.ToString("C0");

                lstMovimientos.Items.Insert(0, texto);

                MessageBox.Show(
                        "Retiro realizado correctamente.",
                        "Retiro exitoso",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(_cuenta.UltimoError,
                    "Error al retirar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            ActualizarSaldo();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            if (_cuenta.Transferir(_cuentaDestino, monto))
            {
                string texto = DateTime.Now.ToString("HH:mm:ss") +
                    " | Transferencia | " + monto.ToString("C0");

                lstMovimientos.Items.Insert(0, texto);

                MessageBox.Show(
                        "Transferencia realizada correctamente.",
                        "Transferencia exitosa",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(_cuenta.UltimoError,
                    "Error al transferir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            ActualizarSaldo();
        }
    }
}
