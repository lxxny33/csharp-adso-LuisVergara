namespace Practica2
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            nudEdad = new NumericUpDown();
            cmbPrograma = new ComboBox();
            rdbManana = new RadioButton();
            rdbTarde = new RadioButton();
            chkTerminos = new CheckBox();
            btnInscribir = new Button();
            lstInscritos = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(14, 43);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(131, 35);
            nudEdad.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(120, 23);
            nudEdad.TabIndex = 3;
            nudEdad.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // cmbPrograma
            // 
            cmbPrograma.FormattingEnabled = true;
            cmbPrograma.Items.AddRange(new object[] { "ADSO", "Multimedia", "Contabilidad" });
            cmbPrograma.Location = new Point(14, 75);
            cmbPrograma.Name = "cmbPrograma";
            cmbPrograma.Size = new Size(136, 23);
            cmbPrograma.TabIndex = 4;
            cmbPrograma.Text = "Seleccione programa";
            // 
            // rdbManana
            // 
            rdbManana.AutoSize = true;
            rdbManana.Location = new Point(156, 79);
            rdbManana.Name = "rdbManana";
            rdbManana.Size = new Size(68, 19);
            rdbManana.TabIndex = 5;
            rdbManana.TabStop = true;
            rdbManana.Text = "Mañana";
            rdbManana.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            rdbTarde.AutoSize = true;
            rdbTarde.Location = new Point(251, 79);
            rdbTarde.Name = "rdbTarde";
            rdbTarde.Size = new Size(54, 19);
            rdbTarde.TabIndex = 6;
            rdbTarde.TabStop = true;
            rdbTarde.Text = "Tarde";
            rdbTarde.UseVisualStyleBackColor = true;
            // 
            // chkTerminos
            // 
            chkTerminos.AutoSize = true;
            chkTerminos.Location = new Point(3, 311);
            chkTerminos.Name = "chkTerminos";
            chkTerminos.Size = new Size(132, 19);
            chkTerminos.TabIndex = 8;
            chkTerminos.Text = "Acepto los terminos";
            chkTerminos.UseVisualStyleBackColor = true;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(176, 307);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(75, 23);
            btnInscribir.TabIndex = 9;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // lstInscritos
            // 
            lstInscritos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstInscritos.FormattingEnabled = true;
            lstInscritos.Location = new Point(12, 130);
            lstInscritos.Name = "lstInscritos";
            lstInscritos.Size = new Size(120, 94);
            lstInscritos.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AcceptButton = btnInscribir;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstInscritos);
            Controls.Add(btnInscribir);
            Controls.Add(chkTerminos);
            Controls.Add(rdbTarde);
            Controls.Add(rdbManana);
            Controls.Add(cmbPrograma);
            Controls.Add(nudEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Inscripciones";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEdad;
        private NumericUpDown nudEdad;
        private ComboBox cmbPrograma;
        private RadioButton rdbManana;
        private RadioButton rdbTarde;
        private CheckBox chkTerminos;
        private Button btnInscribir;
        private ListBox lstInscritos;
        private ErrorProvider errorProvider1;
    }
}
