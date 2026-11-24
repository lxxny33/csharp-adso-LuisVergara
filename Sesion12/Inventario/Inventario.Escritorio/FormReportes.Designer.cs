namespace Inventario.Escritorio
{
    partial class FormReportes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMasValiosos = new DataGridView();
            dgvStockBajo = new DataGridView();
            lblMasValiosos = new Label();
            lblStockBajo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMasValiosos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
            SuspendLayout();
            // 
            // dgvMasValiosos
            // 
            dgvMasValiosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasValiosos.Location = new Point(21, 91);
            dgvMasValiosos.Name = "dgvMasValiosos";
            dgvMasValiosos.Size = new Size(240, 150);
            dgvMasValiosos.TabIndex = 0;
            // 
            // dgvStockBajo
            // 
            dgvStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockBajo.Location = new Point(343, 91);
            dgvStockBajo.Name = "dgvStockBajo";
            dgvStockBajo.Size = new Size(240, 150);
            dgvStockBajo.TabIndex = 1;
            // 
            // lblMasValiosos
            // 
            lblMasValiosos.AutoSize = true;
            lblMasValiosos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasValiosos.Location = new Point(54, 58);
            lblMasValiosos.Name = "lblMasValiosos";
            lblMasValiosos.Size = new Size(153, 17);
            lblMasValiosos.TabIndex = 2;
            lblMasValiosos.Text = "Productos mas valiosos";
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockBajo.Location = new Point(388, 58);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(163, 17);
            lblStockBajo.TabIndex = 3;
            lblStockBajo.Text = "Productos con stock bajo";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStockBajo);
            Controls.Add(lblMasValiosos);
            Controls.Add(dgvStockBajo);
            Controls.Add(dgvMasValiosos);
            Name = "FormReportes";
            Size = new Size(675, 341);
            ((System.ComponentModel.ISupportInitialize)dgvMasValiosos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMasValiosos;
        private DataGridView dgvStockBajo;
        private Label lblMasValiosos;
        private Label lblStockBajo;
    }
}
