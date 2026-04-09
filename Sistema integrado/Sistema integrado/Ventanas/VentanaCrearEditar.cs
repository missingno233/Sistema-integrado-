using Microsoft.Data.SqlClient;
using Sistema_integrado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_integrado.Ventanas
{
    public partial class VentanaCrearEditar : Form
    {
        Models.ConexionBD BD = new();
        Paciente elias = new();
        Tutor tutor = new();

        private bool _paciente = false;
        private bool _tutor = false;
        private bool _editar = false;
        private bool Valido = false;
        
        private string consulta = "";
        private string Tipo = string.Empty;


        public VentanaCrearEditar(bool _editar, Paciente paciente)
        {
            InitializeComponent();
            paginaPredeterminada();
            this.elias = paciente;
            Tipo = "Paciente";

            if (_editar)
            {
                cargarEdicionPaciente();
            }
            else
            {
                cargarCreacionPaciente();
            }
        }
        public VentanaCrearEditar(bool _editar, Tutor tutor)
        {
            InitializeComponent();
            paginaPredeterminada();
            this.tutor = tutor;
            Tipo = "Tutor";

            if (_editar)
            {
                cargarEdicionTutor();
            }
            else
            {
                cargarCreacionTutor();
            }
        }


        public void cargarPaciente()
        {
            txtNombre.Text = elias.Nombre;
            CBEspecie.Text = elias.Especie;
            txtRaza.Text = elias.Raza;
            txtEdad.Text = elias.Edad.ToString();
            txtPeso.Text = elias.Peso.ToString();
        }

        public void cargarTutor()
        {
            txtNombre.Text = tutor.Nombre;
            txtRaza.Text = tutor.Direccion;
            txtEdad.Text = tutor.Telefono;
        }

        public void cargarCreacionPaciente()
        {
            txtNombre.Visible = true;
            txtAlergias.Visible = true;
            txtRaza.Visible = true;
            txtEdad.Visible = true;
            txtPeso.Visible = true;
            CBEspecie.Visible = true;
            lblTitulo.Visible = true;
            lblEdicion.Visible = false;
        }
        public void cargarEdicionPaciente()
        {
            txtNombre.Visible = true;
            txtAlergias.Visible = true;
            txtRaza.Visible = true;
            txtEdad.Visible = true;
            txtPeso.Visible = true;
            CBEspecie.Visible = true;
            lblTitulo.Visible = false;
            lblEdicion.Visible = true;
        }

        public void cargarCreacionTutor()
        {
            txtTutorNombre.Visible = true;
            txtDireccion.Visible = true;
            txtTelefono.Visible = true;
            lblCreacionTutor.Visible = true;
        }
        public void cargarEdicionTutor()
        {
            txtTutorNombre.Visible = true;
            txtDireccion.Visible = true;
            txtTelefono.Visible = true;
            lblEdicionTutor.Visible = true;
        }

        public void paginaPredeterminada()
        {
            //pacientes
            txtNombre.Visible = false;
            txtAlergias.Visible = false;
            txtRaza.Visible = false;
            txtEdad.Visible = false;
            txtPeso.Visible = false;
            CBEspecie.Visible = false;
            lblTitulo.Visible = false;
            lblEdicion.Visible = false;

            //tutores
            txtDireccion.Visible = false;
            txtTutorNombre.Visible = false;
            txtTelefono.Visible = false;
            lblEdicionTutor.Visible = false;
            lblCreacionTutor.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool vacio = false;
            verificacionCancelacion(Tipo, vacio);

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
            if (ValidarCampos(out string mensajeError))
            {
                elias.Nombre = txtNombre.Text.Trim();
                elias.Raza = txtRaza.Text.Trim();
                elias.Especie = CBEspecie.SelectedItem?.ToString()?.Trim();
                elias.Peso = double.Parse(txtPeso.Text.Trim());
                elias.Edad = int.Parse(txtEdad.Text.Trim());

                MessageBox.Show("salvado", "Éxito", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }


        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                mensajeError = "Por favor ingrese un nombre";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                mensajeError = "Por favor ingrese la edad del paciente";
                return false;
            }

            if (!int.TryParse(txtEdad.Text, out int EDAD) || EDAD < 0)
            {
                mensajeError = "La edad debe ser un número válido mayor o igual a 0";
                return false;
            }

            if (CBEspecie.SelectedItem == null)
            {
                mensajeError = "Por favor seleccione la especie";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                mensajeError = "Por favor ingrese el peso";
                return false;
            }

            if (!double.TryParse(txtPeso.Text, out double peso) || peso <= 0)
            {
                mensajeError = "El peso debe ser un número mayor a 0";
                return false;
            }

            return true;
        }
                

        public bool verificacionCancelacion(string tipo, bool vacio)
        {
            switch (tipo)
            {
                default:
                    break;

                case "Paciente":
                    if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                        string.IsNullOrWhiteSpace(txtAlergias.Text) ||
                        string.IsNullOrWhiteSpace(txtRaza.Text) ||
                        string.IsNullOrWhiteSpace(txtEdad.Text) ||
                        string.IsNullOrWhiteSpace(txtPeso.Text) ||
                        string.IsNullOrWhiteSpace(CBEspecie.Text))
                    {
                        vacio = true;
                    }
                    else
                    {
                        vacio = false;
                    }
                    break;

                case "Tutor":
                    if (string.IsNullOrWhiteSpace(txtTutorNombre.Text) ||
                        string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                        string.IsNullOrWhiteSpace(txtTelefono.Text))
                    {
                        vacio = true;
                    }
                    else
                    {
                        vacio = false;
                    }
                    break;
            }
            return vacio; 
        }

    }
}
