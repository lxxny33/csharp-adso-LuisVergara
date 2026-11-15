namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Escribe el nombre.");
                valido = false;
            }
            if (cmbPrograma.SelectedItem is null)
            {
                errorProvider1.SetError(cmbPrograma, "Elige un programa.");
                valido = false;
            }
            if (!chkTerminos.Checked)
            {
                errorProvider1.SetError(chkTerminos, "Debes aceptar los términos.");
                valido = false;
            }
            if (!valido) return;

            string jornada = rdbManana.Checked ? "Mañana" : "Tarde";
            lstInscritos.Items.Add($"{txtNombre.Text} · {nudEdad.Value} años · {cmbPrograma.SelectedItem} · {jornada}");

            txtNombre.Clear();
            nudEdad.Value = nudEdad.Minimum;
            cmbPrograma.Text = "Seleccione programa";
            rdbManana.Checked = false;
            rdbTarde.Checked = false;
            chkTerminos.Checked = false;
        }
    }
}
