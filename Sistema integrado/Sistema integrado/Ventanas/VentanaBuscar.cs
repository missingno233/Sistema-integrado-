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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        public void cargarPaciente()
        {
            
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
