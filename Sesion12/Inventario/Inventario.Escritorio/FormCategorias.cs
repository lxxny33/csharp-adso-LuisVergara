
using Inventario.Datos;
using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormCategorias : Form
{
    private readonly RepositorioCategorias _repositorio =
        new RepositorioCategorias();

    public FormCategorias()
    {
        InitializeComponent();
        CargarCategorias();
    }

    private void CargarCategorias()
    {
        dgvCategorias.DataSource = null;
        dgvCategorias.DataSource = _repositorio.ObtenerTodas();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("Escribe el nombre de la categoría");
            return;
        }

        try
        {
            Categoria categoria = new Categoria(
                txtNombre.Text.Trim(),
                txtDescripcion.Text.Trim()
            );

            _repositorio.Agregar(categoria);

            MessageBox.Show("Categoría guardada correctamente");

            txtNombre.Clear();
            txtDescripcion.Clear();

            CargarCategorias();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvCategorias.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecciona una categoría");
            return;
        }

        Categoria categoria = (Categoria)
            dgvCategorias.SelectedRows[0].DataBoundItem;

        DialogResult respuesta = MessageBox.Show(
            "¿Deseas eliminar esta categoría?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo
        );

        if (respuesta == DialogResult.Yes)
        {
            _repositorio.Eliminar(categoria.Id);

            MessageBox.Show("Categoría eliminada");

            CargarCategorias();
        }
    }
}

