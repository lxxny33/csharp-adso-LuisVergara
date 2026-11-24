
using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormPrincipal : Form
{
    private readonly ServicioInventario _servicio =
     new(new RepositorioSqlite());

    public FormPrincipal()
    {
        InitializeComponent();
        CargarProductos();
    }
    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {
        CargarProductos(_servicio.BuscarPorTexto(txtBuscar.Text));
    }
    private void dgvProductos_DataBindingComplete(
    object sender,
    DataGridViewBindingCompleteEventArgs e)
    {
        if (dgvProductos.Columns["Precio"] is DataGridViewColumn precio)
        {
            precio.DefaultCellStyle.Format = "C0";
        }

        foreach (DataGridViewRow fila in dgvProductos.Rows)
        {
            if (fila.DataBoundItem is Producto { Stock: < 5 })
            {
                fila.DefaultCellStyle.BackColor = Color.MistyRose;
            }
            else
            {
                fila.DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
    private void CargarProductos(List<Producto>? productos = null)
    {
        dgvProductos.DataSource = null;
        dgvProductos.DataSource = productos ?? _servicio.Listar();

        lblValor.Text = $"Valor del inventario: {_servicio.ValorInventario():C0}";
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        using var form = new FormProducto();

        if (form.ShowDialog() != DialogResult.OK ||
            form.ProductoCreado is null)
        {
            return;
        }

        try
        {
            _servicio.Agregar(form.ProductoCreado);
            CargarProductos();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(
                ex.Message,
                "No se pudo agregar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
    private void btnVender_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto.");
            return;
        }

        try
        {
            _servicio.Vender(
                producto.Codigo,
                (int)nudCantidad.Value
            );

            CargarProductos();
        }
        catch (StockInsuficienteException ex)
        {
            MessageBox.Show(
                ex.Message,
                "Stock insuficiente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
    private Producto? Seleccionado()
    {
        return dgvProductos.CurrentRow?.DataBoundItem as Producto;
    }
    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto.");
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            $"¿Deseas eliminar el producto {producto.Nombre}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (respuesta == DialogResult.Yes)
        {
            _servicio.Eliminar(producto.Codigo);
            CargarProductos();
        }
    }

    private void btnAgregarStock_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto.");
            return;
        }

        try
        {
            int cantidad = (int)nudCantidad.Value;

            _servicio.AgregarStock(producto.Codigo, cantidad);

            CargarProductos();

            MessageBox.Show("Stock agregado correctamente.");
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error al agregar stock");
        }
    }
    private void dgvProductos_CellDoubleClick(
    object sender,
    DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        Producto? producto = Seleccionado();

        if (producto == null)
            return;

        using var form = new FormProducto(producto);

        if (form.ShowDialog() == DialogResult.OK)
        {
            try
            {
                _servicio.Actualizar(
                    producto.Codigo,
                    form.NombreIngresado,
                    form.PrecioIngresado,
                    form.CategoriaIdSeleccionada
            
                );

                CargarProductos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error al editar");
            }
        }
    }
    private void btnReportes_Click(object sender, EventArgs e)
    {
        using var form = new FormReportes(_servicio);
        form.ShowDialog();
    }

    private void btnCategorias_Click(object sender, EventArgs e)
    {
        FormCategorias formulario = new FormCategorias();
        formulario.ShowDialog();
    }
}
