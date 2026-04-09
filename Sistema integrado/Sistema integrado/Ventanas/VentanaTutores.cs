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
    public partial class VentanaTutores : Form
    {
        private Tutor tutor = new();
        private String consulta = "";
        Models.ConexionBD BD = new();
        private int idseleccionado = 0;

        public VentanaTutores()
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

        private void TSB_Crear_Click(object sender, EventArgs e)
        {
            VentanaCrearEditar ventana = new(false, tutor);
            ventana.ShowDialog();
        }

        private void TSB_Consulta_Click(object sender, EventArgs e)
        {
            consulta = "SELECT " +
                "Id, Nombre, Telefono" +
                ", Direccion, Mascota " +
                "FROM Tutores " +
                "ORDER BY Nombre;";
            DataTable tabla = BD.Consultando(consulta);
            DGVTutores.DataSource = tabla;

        }

        private void TSB_Editar_Click(object sender, EventArgs e)
        {
            VentanaCrearEditar ventana = new(true, tutor);
            ventana.ShowDialog();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {

            consulta = "DELETE FROM Tutores WHERE id = @id";


            if (DGVTutores.SelectedRows != null &&
                DGVTutores.SelectedRows.Count > 0)
            {
                idseleccionado = Convert.ToInt32(DGVTutores.
                    SelectedRows[0].Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un registro a eliminar"
                    , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var parametros = new List<SqlParameter>
            {
                new SqlParameter("@id", idseleccionado)
            };


            BD.Consultando(consulta, parametros);
            TSB_Consulta_Click(sender, e);
        }

        private void TSB_Buscar_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            VentanaBuscar buscar = new(tutor);
            buscar.FormClosed += (s, args) => this.Show();
            buscar.Show();


            DataTable tablita= BD.Consultando(tutor.consulta);
            DGVTutores.DataSource = tablita;
        }
    }
}
