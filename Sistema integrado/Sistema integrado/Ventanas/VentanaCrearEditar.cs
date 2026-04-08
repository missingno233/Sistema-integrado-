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
        Paciente paciente = new();
        Tutor tutor = new();

        public VentanaCrearEditar(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
        }
        public VentanaCrearEditar(Tutor tutor)
        {
            InitializeComponent();
            this.tutor = tutor;
        }


        public VentanaCrearEditar(string nombre, string especie, 
            string raza, int edad, double peso)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            CBEspecie.Text = especie;
            txtRaza.Text = raza;
            txtEdad.Text = edad.ToString();
            txtPeso.Text = peso.ToString();

        }


    }
}
