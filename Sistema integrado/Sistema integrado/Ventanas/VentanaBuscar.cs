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


        public VentanaBuscar()
        {
            InitializeComponent();
            paginaPredeterminada();
        }
        public VentanaBuscar(Paciente paciente)
        {
            InitializeComponent();
            cargarPaciente();
            tipo = "paciente";
        }
        public VentanaBuscar(Tutor tutor)
        {
            InitializeComponent();
            cargarTutor();
            tipo = "tutor";
        }





        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Paciente p = new();
            Tutor t = new();

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
            txtBuscarPaciente.Visible = true;
        }

        public void cargarTutor()
        {
            lblTutores.Visible = true;
            txtBuscarTutor.Visible = true;
        }


        public void paginaPredeterminada()
        {
            txtBuscarPaciente.Visible = false;
            txtBuscarTutor.Visible = false;
            lblPaciente.Visible = false; 
            lblTutores.Visible = false; 
        }
    }
}
