namespace Inventario.Escritorio
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvProductos = new DataGridView();
            lblValor = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnVender = new Button();
            btnAgregarStock = new Button();
            btnEliminar = new Button();
            btnReportes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(268, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inventario de productos";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(133, 60);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(97, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar producto:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(236, 57);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(201, 100);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(316, 150);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            dgvProductos.DataBindingComplete += dgvProductos_DataBindingComplete;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(359, 65);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(126, 15);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor del inventario: $0";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(516, 65);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(201, 256);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(321, 256);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(75, 23);
            btnVender.TabIndex = 7;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(217, 310);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(131, 23);
            btnAgregarStock.TabIndex = 8;
            btnAgregarStock.Text = "Agregar stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(441, 256);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(383, 310);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(102, 23);
            btnReportes.TabIndex = 10;
            btnReportes.Text = "Ver reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += this.btnReportes_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportes);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarStock);
            Controls.Add(btnVender);
            Controls.Add(btnAgregar);
            Controls.Add(nudCantidad);
            Controls.Add(lblValor);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private Label lblValor;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Button btnVender;
        private Button btnAgregarStock;
        private Button btnEliminar;
        private Button btnReportes;
    }
}
