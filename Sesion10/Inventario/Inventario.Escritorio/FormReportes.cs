using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormReportes : Form
{
    private readonly ServicioInventario _servicio;

    public FormReportes(ServicioInventario servicio)
    {
        InitializeComponent();

        _servicio = servicio;

        CargarReportes();
    }

    private void CargarReportes()
    {
        dgvMasValiosos.DataSource = _servicio.MasValiosos();

        dgvStockBajo.DataSource = _servicio.StockBajo();

        ConfigurarTabla(dgvMasValiosos);
        ConfigurarTabla(dgvStockBajo);
    }

    private void ConfigurarTabla(DataGridView tabla)
    {
        tabla.ReadOnly = true;
        tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        tabla.AllowUserToAddRows = false;
    }
}