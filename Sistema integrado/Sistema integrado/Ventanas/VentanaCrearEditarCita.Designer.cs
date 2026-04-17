namespace Sistema_integrado.Ventanas
{
    partial class VentanaCrearEditarCita
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
            txtNombrePaciente = new TextBox();
            txtMotivo = new TextBox();
            txtDiagnositco = new TextBox();
            txtTratamiento = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            Calendario = new MonthCalendar();
            label1 = new Label();
            BTN_AceptarEdicion = new Button();
            lblEdicion = new Label();
            DTP_Hora = new DateTimePicker();
            SuspendLayout();
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePaciente.Location = new Point(283, 74);
            txtNombrePaciente.Margin = new Padding(4);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.PlaceholderText = "Paciente";
            txtNombrePaciente.Size = new Size(181, 29);
            txtNombrePaciente.TabIndex = 0;
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 12F);
            txtMotivo.Location = new Point(283, 111);
            txtMotivo.Margin = new Padding(4);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Motivo";
            txtMotivo.Size = new Size(362, 29);
            txtMotivo.TabIndex = 1;
            // 
            // txtDiagnositco
            // 
            txtDiagnositco.Font = new Font("Segoe UI", 12F);
            txtDiagnositco.Location = new Point(283, 148);
            txtDiagnositco.Margin = new Padding(4);
            txtDiagnositco.Multiline = true;
            txtDiagnositco.Name = "txtDiagnositco";
            txtDiagnositco.PlaceholderText = "Diagnostico";
            txtDiagnositco.Size = new Size(362, 76);
            txtDiagnositco.TabIndex = 2;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Font = new Font("Segoe UI", 12F);
            txtTratamiento.Location = new Point(283, 232);
            txtTratamiento.Margin = new Padding(4);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.PlaceholderText = "Tratamiento";
            txtTratamiento.Size = new Size(362, 76);
            txtTratamiento.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(158, 249);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 59);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(22, 249);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 59);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Calendario
            // 
            Calendario.Location = new Point(22, 74);
            Calendario.Name = "Calendario";
            Calendario.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(260, 30);
            label1.TabIndex = 11;
            label1.Text = "Ingrese los datos de la cita";
            // 
            // BTN_AceptarEdicion
            // 
            BTN_AceptarEdicion.Location = new Point(22, 248);
            BTN_AceptarEdicion.Name = "BTN_AceptarEdicion";
            BTN_AceptarEdicion.Size = new Size(112, 59);
            BTN_AceptarEdicion.TabIndex = 12;
            BTN_AceptarEdicion.Text = "Aceptar";
            BTN_AceptarEdicion.UseVisualStyleBackColor = true;
            BTN_AceptarEdicion.Click += BTN_AceptarEdicion_Click;
            // 
            // lblEdicion
            // 
            lblEdicion.AutoSize = true;
            lblEdicion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdicion.Location = new Point(22, 26);
            lblEdicion.Name = "lblEdicion";
            lblEdicion.Size = new Size(287, 30);
            lblEdicion.TabIndex = 13;
            lblEdicion.Text = "Modifique los datos de la cita";
            // 
            // DTP_Hora
            // 
            DTP_Hora.Format = DateTimePickerFormat.Time;
            DTP_Hora.Location = new Point(471, 75);
            DTP_Hora.Name = "DTP_Hora";
            DTP_Hora.Size = new Size(174, 29);
            DTP_Hora.TabIndex = 14;
            // 
            // VentanaCrearEditarCita
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 325);
            Controls.Add(DTP_Hora);
            Controls.Add(lblEdicion);
            Controls.Add(BTN_AceptarEdicion);
            Controls.Add(label1);
            Controls.Add(Calendario);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTratamiento);
            Controls.Add(txtDiagnositco);
            Controls.Add(txtMotivo);
            Controls.Add(txtNombrePaciente);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "VentanaCrearEditarCita";
            Text = "Cita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombrePaciente;
        private TextBox txtMotivo;
        private TextBox txtDiagnositco;
        private TextBox txtTratamiento;
        private Button btnCancelar;
        private Button btnAceptar;
        private MonthCalendar Calendario;
        private Label label1;
        private Button BTN_AceptarEdicion;
        private Label lblEdicion;
        private DateTimePicker DTP_Hora;
    } 
}