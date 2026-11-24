
using Inventario.Modelos;
using Inventario.Datos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{
    private readonly RepositorioCategorias _repositorioCategorias =
        new RepositorioCategorias();

    public Producto? ProductoCreado { get; private set; }

    public string NombreIngresado => txtNombre.Text.Trim();

    public decimal PrecioIngresado => nudPrecio.Value;

    public int? CategoriaIdSeleccionada =>
        (cboCategoria.SelectedItem as Categoria)?.Id;

    public FormProducto()
    {
        InitializeComponent();

        ConfigurarFormulario();
        CargarCategorias();
    }

    public FormProducto(Producto producto)
    {
        InitializeComponent();

        ConfigurarFormulario();

        txtCodigo.Text = producto.Codigo;
        txtNombre.Text = producto.Nombre;
        nudPrecio.Value = producto.Precio;
        nudStock.Value = producto.Stock;

        txtCodigo.Enabled = false;
        nudStock.Enabled = false;

        CargarCategorias(producto.CategoriaId);
    }

    private void ConfigurarFormulario()
    {
        nudPrecio.DecimalPlaces = 2;
        nudPrecio.Minimum = 0.01m;
        nudPrecio.Maximum = 100000000;

        nudStock.Minimum = 0;
        nudStock.Maximum = 100000;

        AcceptButton = btnGuardar;
        CancelButton = btnCancelar;
    }

    private void CargarCategorias(int? categoriaId = null)
    {
        List<Categoria> categorias =
            _repositorioCategorias.ObtenerTodas();

        cboCategoria.DataSource = categorias;
        cboCategoria.DisplayMember = "Nombre";
        cboCategoria.ValueMember = "Id";

        if (categoriaId.HasValue)
        {
            cboCategoria.SelectedValue = categoriaId.Value;
        }
        else if (categorias.Count > 0)
        {
            cboCategoria.SelectedIndex = 0;
        }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider1.SetError(
                txtNombre,
                "El nombre es obligatorio."
            );
            return;
        }

        if (nudPrecio.Value <= 0)
        {
            errorProvider1.SetError(
                nudPrecio,
                "El precio debe ser mayor que cero."
            );
            return;
        }

        try
        {
            if (txtCodigo.Enabled)
            {
                ProductoCreado = new Producto(
                    txtCodigo.Text.Trim(),
                    txtNombre.Text.Trim(),
                    nudPrecio.Value,
                    (int)nudStock.Value
                );

                ProductoCreado.AsignarCategoria(
                    CategoriaIdSeleccionada
                );
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (ArgumentException ex)
        {
            errorProvider1.SetError(btnGuardar, ex.Message);
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        ProductoCreado = null;
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
