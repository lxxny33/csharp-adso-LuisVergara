
using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{
    public Producto? ProductoCreado { get; private set; }

    public FormProducto()
    {
        InitializeComponent();

        nudPrecio.DecimalPlaces = 2;
        nudPrecio.Minimum = 0.01m;
        nudPrecio.Maximum = 100000000;

        nudStock.Minimum = 0;
        nudStock.Maximum = 100000;

        AcceptButton = btnGuardar;
        CancelButton = btnCancelar;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
            return;
        }

        if (nudPrecio.Value <= 0)
        {
            errorProvider1.SetError(nudPrecio, "El precio debe ser mayor que cero.");
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
    public string NombreIngresado => txtNombre.Text.Trim();

    public decimal PrecioIngresado => nudPrecio.Value;
    public FormProducto(Producto producto)
    {
        InitializeComponent();

        txtCodigo.Text = producto.Codigo;
        txtNombre.Text = producto.Nombre;
        nudPrecio.DecimalPlaces = 2;
        nudPrecio.Minimum = 0.01m;
        nudPrecio.Maximum = 100000000;
        nudPrecio.Value = producto.Precio;

        nudStock.Value = producto.Stock;

        txtCodigo.Enabled = false;
        nudStock.Enabled = false;

        AcceptButton = btnGuardar;
        CancelButton = btnCancelar;
    }
}
