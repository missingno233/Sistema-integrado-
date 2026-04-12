using Microsoft.Data.SqlClient;
using Sistema_integrado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Sistema_integrado.Ventanas
{
    public partial class VentanaCita : Form
    {
        Models.ConexionBD BD = new();
        private Paciente pat = new Paciente();
        private String consulta = "";

        public VentanaCita()
        {
            InitializeComponent();

            if (BD.ProbarConexion())
            {
                using (MemoryStream stream = new(Properties.Resources.Conectado))
                {
                    this.Icon = new Icon(stream);
                }
            }
            else
            {
                using (MemoryStream stream = new(Properties.Resources.Desconectado))
                {
                    this.Icon = new Icon(stream);
                }
            }
        }

        private void TSB_Programar_Click(object sender, EventArgs e)
        {

            VentanaCrearEditarCita ventana = new(pat, "crear");
            ventana.ShowDialog();

            var parametros = new List<SqlParameter>
            {
                    new("@NombrePaciente",pat.Nombre),
                    new("@Motivo",pat.Motivo),
                    new("@Fecha",pat.Fecha),
                    new("@Diagnostico",pat.Diagnostico),
                    new("@Tratamiento",pat.Tratamiento)
            };

            DataTable tablita = BD.Consultando(pat.consulta, parametros);
            DGV_Citas.DataSource = tablita;
        }

        private void TSB_Editar_Click(object sender, EventArgs e)
        {
            VentanaCrearEditarCita ventana = new(pat, "editar");
            ventana.ShowDialog();
            var parametros = new List<SqlParameter>
            {
                    new("@NombrePaciente",pat.Nombre),
                    new("@Motivo",pat.Motivo),
                    new("@Fecha",pat.Fecha),
                    new("@Diagnostico",pat.Diagnostico),
                    new("@Tratamiento",pat.Tratamiento)
            };  

            DataTable tablita = BD.Consultando(pat.consulta, parametros);
            DGV_Citas.DataSource = tablita;
        }
    }
}
