using Microsoft.Data.SqlClient;
using Sistema_integrado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Sistema_integrado.Ventanas
{
    public partial class VentanaCrearEditarCita : Form
    {

        Models.ConexionBD BD = new();

        private Paciente pat = new Paciente();

        private string consulta = "";
        private bool mensajeError = false;
        private string Tipo = string.Empty;


        public VentanaCrearEditarCita(Paciente pat, string seleccion)
        {
            InitializeComponent();
            this.pat = pat;

            if (seleccion == "crear")
            {
                BTN_AceptarEdicion.Visible = false;
                lblEdicion.Visible = false;
            }
            else
            {
                btnAceptar.Visible = false;
                label1.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool vacio = false;
            verificacionCancelacion(vacio);

            if (vacio)
            {
                var dialogResult = MessageBox.Show("¿Estás seguro de que deseas cancelar?" +
                    " Se perderán los cambios no guardados.", "Confirmar Cancelación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes) { this.Close(); }
            }
            else
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar ambos
            bool camposValidos = ValidarCampos(out string mensajeError);
            bool fechaValida = EsFechaHoraValida(out string mensajeFecha);

            if (camposValidos && fechaValida)
            {
                string consulta = @"INSERT INTO Pacientes "+
                    "(Nombre" +
                    ", Motivo" +
                    ", Fecha" +
                    ", Diagnostico"+
                    ", Tratamiento) " +
                    "VALUES " +
                    "(@Nombre" +
                    ", @Motivo" +
                    ", @Fecha" +
                    ", @Diagnostico" +
                    ", @Tratamiento);";

                DateTime fechaHoraCita = Calendario.SelectionStart.Date + DTP_Hora.Value.TimeOfDay;

                pat.Nombre = txtNombrePaciente.Text.Trim();
                pat.Motivo = txtMotivo.Text.Trim();
                pat.Fecha = fechaHoraCita;
                pat.Diagnostico = txtDiagnositco.Text.Trim();
                pat.Tratamiento = txtTratamiento.Text.Trim();

                MessageBox.Show($"Nombre = {pat.Nombre} \n" +
                    $"Motivo = {pat.Motivo}\n" +
                    $"Fecha = {pat.Fecha}\n" +
                    $"Diagnostico = {pat.Diagnostico}\n" +
                    $"Tratamiento = {pat.Tratamiento}\n");

                MessageBox.Show("Guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;  
                this.Close();
            }
            else
            {
                string errorCompleto = mensajeError;
                if (!string.IsNullOrEmpty(mensajeFecha))
                    errorCompleto += (string.IsNullOrEmpty(errorCompleto) ? "" : "\n") + mensajeFecha;

                MessageBox.Show(errorCompleto, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                

        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text))
            {
                mensajeError = "Por favor ingrese un nombre";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                mensajeError = "Por favor ingrese el motivo";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTratamiento.Text))
            {
                mensajeError = "Por favor ingrese un tratamiento";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiagnositco.Text))
            {
                mensajeError = "Por favor ingrese el diagnositico";
                return false;
            }
            
            return true;
        }

        private bool EsFechaHoraValida(out string mensaje)
        {
            mensaje = string.Empty;
            DateTime fecha = Calendario.SelectionStart;

            // Validar que se haya seleccionado una fecha
            if (fecha == DateTime.MinValue)
            {
                mensaje = "No se ha seleccionado ninguna fecha.";
                return false;
            }


            DateTime fechaHoraCita = fecha.Date + DTP_Hora.Value.TimeOfDay;

            if (fechaHoraCita <= DateTime.Now)
            {
                mensaje = "La fecha y hora de la cita debe ser posterior al momento actual.";
                return false;
            }

            if (fechaHoraCita > DateTime.Today.AddYears(1))
            {
                mensaje = "No se pueden agendar citas con más de un año de anticipación.";
                return false;
            }

            TimeSpan horaCita = DTP_Hora.Value.TimeOfDay;
            if (horaCita < TimeSpan.FromHours(8) || horaCita > TimeSpan.FromHours(18))
            {
                mensaje = "El horario de citas es de 08:00 a 18:00.";
                return false;
            }

            return true;
        }

        public bool verificacionCancelacion(bool vacio)
        {

            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text) ||
                string.IsNullOrWhiteSpace(txtTratamiento.Text) ||
                string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnositco.Text))
            {
                vacio = true;
            }
            else
            {
                vacio = false;
            }

            return vacio;
        }

        private void BTN_AceptarEdicion_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(out string mensajeError))
            {
                pat.consulta = "UPDATE Pacientes SET" +
                    "(Nombre" +
                    ", Raza" +
                    ", Especie" +
                    ", Peso" +
                    ", Edad) " +
                    "VALUES " +
                    "(@Nombre" +
                    ", @Raza" +
                    ", @Especie" +
                    ", @Peso" +
                    ", @Edad)";

                pat.Nombre = txtNombrePaciente.Text.Trim();
                pat.Motivo = txtMotivo.Text.Trim();
                pat.Fecha = Calendario.SelectionStart;
                pat.Diagnostico = txtDiagnositco.Text.Trim();
                pat.Tratamiento = txtTratamiento.Text.Trim();
                MessageBox.Show("salvado", "Éxito", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            this.Close();
        }
    }

}
