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
            bool fechaValida = EsFechaValida(out string mensajeFecha);

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

                  
                pat.Nombre = txtNombrePaciente.Text.Trim();
                pat.Motivo = txtMotivo.Text.Trim();
                pat.Fecha = Calendario.SelectionStart;
                pat.Diagnostico = txtDiagnositco.Text.Trim();
                pat.Tratamiento = txtTratamiento.Text.Trim();


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

        private bool EsFechaValida(out string mensajeFecha)
        {
            mensajeFecha = string.Empty;
            DateTime fecha = Calendario.SelectionStart;

            if (fecha == DateTime.MinValue)
            {
                mensajeFecha = "No se ha seleccionado ninguna fecha";
                return false;
            }


            if (fecha > DateTime.Today)
            {
                mensajeFecha = "La fecha no puede ser posterior a hoy";
                return false;
            }
            if (fecha < DateTime.Today.AddYears(-30))
            {
                mensajeFecha = "La fecha es demasiado antigua (más de 30 años)";
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
