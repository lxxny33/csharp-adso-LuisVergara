
using Microsoft.EntityFrameworkCore;

namespace Reto;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        using (var db = new AgendaContext())
        {
            db.Database.EnsureCreated();
        }

        CargarContactos();
    }

    private void CargarContactos(string filtro = "")
    {
        using var db = new AgendaContext();

        dgvContactos.DataSource = db.Contactos
            .Where(c => EF.Functions.Like(c.Nombre, $"%{filtro}%"))
            .OrderBy(c => c.Nombre)
            .ToList();

        lblTotal.Text = $"{dgvContactos.Rows.Count} contactos";
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {
        CargarContactos(txtBuscar.Text);
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        bool valido = true;

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider1.SetError(txtNombre, "Escribe el nombre.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
            !txtCorreo.Text.Contains("@"))
        {
            errorProvider1.SetError(txtCorreo, "Escribe un correo válido.");
            valido = false;
        }

        if (!valido)
        {
            return;
        }

        using var db = new AgendaContext();

        Contacto contacto = new Contacto
        {
            Nombre = txtNombre.Text.Trim(),
            Telefono = txtTelefono.Text.Trim(),
            Correo = txtCorreo.Text.Trim()
        };

        db.Contactos.Add(contacto);
        db.SaveChanges();

        MessageBox.Show("Contacto agregado correctamente.");

        txtNombre.Clear();
        txtTelefono.Clear();
        txtCorreo.Clear();

        CargarContactos(txtBuscar.Text);
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvContactos.CurrentRow?.DataBoundItem is not Contacto contacto)
        {
            MessageBox.Show("Selecciona un contacto.");
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            $"¿Eliminar a {contacto.Nombre}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (respuesta != DialogResult.Yes)
        {
            return;
        }

        using var db = new AgendaContext();

        db.Contactos.Remove(contacto);
        db.SaveChanges();

        MessageBox.Show("Contacto eliminado.");

        CargarContactos(txtBuscar.Text);
    }

    private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }
}
