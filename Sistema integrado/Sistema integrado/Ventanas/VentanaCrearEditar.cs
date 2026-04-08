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
        Paciente elias = new();
        Tutor tutor = new();

        private bool _paciente = false;
        private bool _tutor = false;


        public VentanaCrearEditar(Paciente paciente)
        {
            InitializeComponent();
            this.elias = paciente;


            txtAlergias.Hide();
        }
        public VentanaCrearEditar(Tutor tutor)
        {
            InitializeComponent();
            this.tutor = tutor;
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
            txtNombre.Visible = false;
            txtAlergias.Visible = false;
            txtRaza.Visible = false;
            txtEdad.Visible = false;
            txtPeso.Visible = false;
            CBEspecie.Visible = false;
            lblTitulo.Visible = false;
            lblEdicion.Visible = false;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
