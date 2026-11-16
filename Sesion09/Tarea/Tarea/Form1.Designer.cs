namespace Tarea
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            lblOrigen = new Label();
            cmbOrigen = new ComboBox();
            lblDestino = new Label();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(303, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(247, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Conversor de temperatura";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(49, 84);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(49, 112);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 2;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(48, 153);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(101, 15);
            lblOrigen.TabIndex = 3;
            lblOrigen.Text = "Unidad de origen:";
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(48, 185);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 4;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(49, 233);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(106, 15);
            lblDestino.TabIndex = 5;
            lblDestino.Text = "Unidad de destino:";
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(48, 261);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(121, 23);
            cmbDestino.TabIndex = 6;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.DodgerBlue;
            btnConvertir.ForeColor = SystemColors.ButtonHighlight;
            btnConvertir.Location = new Point(314, 327);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(198, 34);
            btnConvertir.TabIndex = 7;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(49, 393);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(lblDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(lblOrigen);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblValor;
        private TextBox txtValor;
        private Label lblOrigen;
        private ComboBox cmbOrigen;
        private Label lblDestino;
        private ComboBox cmbDestino;
        private Button btnConvertir;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
    }
}
