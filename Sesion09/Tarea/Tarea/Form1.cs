
using System;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        ConversorTemperatura conversor = new ConversorTemperatura();

        public Form1()
        {
            InitializeComponent();

            cmbOrigen.Items.Add("Celsius");
            cmbOrigen.Items.Add("Fahrenheit");
            cmbOrigen.Items.Add("Kelvin");

            cmbDestino.Items.Add("Celsius");
            cmbDestino.Items.Add("Fahrenheit");
            cmbDestino.Items.Add("Kelvin");
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            double valor;

            bool valido = true;

            if (!double.TryParse(txtValor.Text, out valor))
            {
                errorProvider1.SetError(txtValor, "Ingresa un número válido.");
                valido = false;
            }

            if (cmbOrigen.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbOrigen, "Selecciona la unidad de origen.");
                valido = false;
            }

            if (cmbDestino.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDestino, "Selecciona la unidad de destino.");
                valido = false;
            }

            if (valido)
            {
                double resultado = conversor.Convertir(
                    valor,
                    cmbOrigen.SelectedItem.ToString(),
                    cmbDestino.SelectedItem.ToString()
                );

                lblResultado.Text = "Resultado: " +
                    resultado.ToString("0.##") +
                    " " + cmbDestino.SelectedItem.ToString();
            }
        }
    }
}
