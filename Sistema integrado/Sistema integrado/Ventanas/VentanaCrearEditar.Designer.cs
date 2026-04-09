namespace Sistema_integrado.Ventanas
{
    partial class VentanaCrearEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            txtPeso = new TextBox();
            txtEdad = new TextBox();
            txtAlergias = new TextBox();
            lblTitulo = new Label();
            CBEspecie = new ComboBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblEdicion = new Label();
            txtTutorNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            lblEdicionTutor = new Label();
            lblCreacionTutor = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(55, 120);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(127, 29);
            txtNombre.TabIndex = 0;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Segoe UI", 12F);
            txtRaza.Location = new Point(55, 180);
            txtRaza.Margin = new Padding(4);
            txtRaza.Name = "txtRaza";
            txtRaza.PlaceholderText = "Raza";
            txtRaza.Size = new Size(127, 29);
            txtRaza.TabIndex = 1;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 12F);
            txtPeso.Location = new Point(235, 242);
            txtPeso.Margin = new Padding(4);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Peso";
            txtPeso.Size = new Size(127, 29);
            txtPeso.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 12F);
            txtEdad.Location = new Point(235, 180);
            txtEdad.Margin = new Padding(4);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Edad";
            txtEdad.Size = new Size(52, 29);
            txtEdad.TabIndex = 4;
            // 
            // txtAlergias
            // 
            txtAlergias.Font = new Font("Segoe UI", 12F);
            txtAlergias.Location = new Point(55, 242);
            txtAlergias.Margin = new Padding(4);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.PlaceholderText = "Alergia";
            txtAlergias.Size = new Size(127, 29);
            txtAlergias.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(24, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(369, 37);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Ingrese los datos del paciente";
            // 
            // CBEspecie
            // 
            CBEspecie.FormattingEnabled = true;
            CBEspecie.Items.AddRange(new object[] { "Perro", "Gato", "Bovino", "Porcino", "Ave", "Reptil", "Roedor" });
            CBEspecie.Location = new Point(235, 120);
            CBEspecie.Name = "CBEspecie";
            CBEspecie.Size = new Size(121, 29);
            CBEspecie.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(55, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 59);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(235, 310);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 59);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblEdicion
            // 
            lblEdicion.AutoSize = true;
            lblEdicion.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdicion.Location = new Point(36, 34);
            lblEdicion.Name = "lblEdicion";
            lblEdicion.Size = new Size(343, 37);
            lblEdicion.TabIndex = 10;
            lblEdicion.Text = "Edite los datos del paciente";
            // 
            // txtTutorNombre
            // 
            txtTutorNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTutorNombre.Location = new Point(142, 120);
            txtTutorNombre.Margin = new Padding(4);
            txtTutorNombre.Name = "txtTutorNombre";
            txtTutorNombre.PlaceholderText = "Nombre";
            txtTutorNombre.Size = new Size(127, 29);
            txtTutorNombre.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(142, 180);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(127, 29);
            txtTelefono.TabIndex = 12;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(142, 242);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(127, 29);
            txtDireccion.TabIndex = 13;
            // 
            // lblEdicionTutor
            // 
            lblEdicionTutor.AutoSize = true;
            lblEdicionTutor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdicionTutor.Location = new Point(56, 34);
            lblEdicionTutor.Name = "lblEdicionTutor";
            lblEdicionTutor.Size = new Size(300, 37);
            lblEdicionTutor.TabIndex = 14;
            lblEdicionTutor.Text = "Edite los datos del tutor";
            // 
            // lblCreacionTutor
            // 
            lblCreacionTutor.AutoSize = true;
            lblCreacionTutor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreacionTutor.Location = new Point(49, 34);
            lblCreacionTutor.Name = "lblCreacionTutor";
            lblCreacionTutor.Size = new Size(326, 37);
            lblCreacionTutor.TabIndex = 15;
            lblCreacionTutor.Text = "Ingrese los datos del tutor";
            // 
            // VentanaCrearEditar
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(lblCreacionTutor);
            Controls.Add(lblEdicionTutor);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtTutorNombre);
            Controls.Add(lblEdicion);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(CBEspecie);
            Controls.Add(lblTitulo);
            Controls.Add(txtAlergias);
            Controls.Add(txtEdad);
            Controls.Add(txtPeso);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "VentanaCrearEditar";
            Text = "VentanaCrear";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtRaza;
        private TextBox txtPeso;
        private TextBox txtEdad;
        private TextBox txtAlergias;
        private Label lblTitulo;
        private ComboBox CBEspecie;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblEdicion;
        private TextBox txtTutorNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label lblEdicionTutor;
        private Label lblCreacionTutor;
    }
}