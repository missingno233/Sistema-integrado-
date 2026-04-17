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
    public partial class VentanaBuscar : Form
    {

        Models.ConexionBD BD = new();
        private string tipo = string.Empty;

        public VentanaBuscar(Paciente paciente)
        {
            InitializeComponent();
            paginaPredeterminada();
            cargarPaciente();
            tipo = "paciente";
        }
        public VentanaBuscar(Tutor tutor)
        {
            InitializeComponent();
            paginaPredeterminada();
            cargarTutor();
            tipo = "tutor";
        }





        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Paciente p = new();
            Tutor t = new();

            p.Nombre = txtBuscar.Text.Trim();
            t.Nombre = txtBuscar.Text.Trim();

            switch (tipo)
            {
                default:
                    break;

                case "paciente":

                    p.consulta = "SELECT FROM <NOMBRE TENTATIVO> WHERE <NOMBRE PACIENTE> = @Nombre";
                    break;
                case "tutor":
                    t.consulta = "SELECT FROM <NOMBRE TENTATIVO> WHERE <NOMBRE TUTOR> = @Nombre";
                    break;
            }
            this.Close();
        }

        public void cargarPaciente()
        {
            lblPaciente.Visible = true;
        }

        public void cargarTutor()
        {
            lblTutores.Visible = true;
        }


        public void paginaPredeterminada()
        {
            txtBuscar.Visible = false;
            lblPaciente.Visible = false;
            lblTutores.Visible = false;
        }
    }
}
