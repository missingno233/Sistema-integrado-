using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using Sistema_integrado.Models;
using System.Collections.Generic;

namespace Sistema_integrado.Ventanas
{
    public partial class VentanaTutores : Form
    {
        Models.ConexionBD BD = new();

        private Tutor tutor = new();
        private String consulta = "";
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

            var parametros = new List<SqlParameter>
            {
                new("@Nombre", tutor.Nombre),
                new("@Raza", tutor.Telefono),
                new("@Especie", tutor.Direccion),
                new("@Mascota", tutor.Mascota)
            };

            DataTable tabla = BD.Consultando(tutor.consulta, parametros);
            DGVTutores.DataSource = tabla;

            TSB_Buscar_Click(sender, e);
        }

        private void TSB_Consulta_Click(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM Tutores";

            DataTable tabla = BD.Consultando(consulta);
            DGVTutores.DataSource = tabla;
        }

        private void TSB_Editar_Click(object sender, EventArgs e)
        {
            if (DGVTutores.SelectedRows != null &&
                DGVTutores.SelectedRows.Count > 0)
            {
                idseleccionado = Convert.ToInt32(DGVTutores.
                    SelectedRows[0].Cells[0].Value);

                VentanaCrearEditar ventana = new(true, tutor);
                ventana.ShowDialog();

                consulta = "UPDATE Tutores\r\n" +
                    "SET Nombre = @Nombre,\r\n    " +
                    "Telefono = @Telefono,\r\n    " +
                    "Direccion = @Direccion,\r\n    " +
                    "Mascota = @Mascota\r\n" +
                    "WHERE Id = @Id;";

                var parametros = new List<SqlParameter>
                {
                    new("@Id", idseleccionado),
                    new("@Nombre", tutor.Nombre),
                    new("@Telefono", tutor.Telefono),
                    new("@Direccion", tutor.Direccion),
                    new("@Mascota", tutor.Mascota)
                };
                DataTable tabla = BD.Consultando(consulta, parametros);
                DGVTutores.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un registro a editar"
                    , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TSB_Consulta_Click(sender, e);
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {

            consulta = "DELETE FROM Tutores WHERE id = @id";


            if (DGVTutores.SelectedRows != null &&
                DGVTutores.SelectedRows.Count > 0)
            {
                idseleccionado = Convert.ToInt32(DGVTutores.
                    SelectedRows[0].Cells[0].Value);

                var parametros = new List<SqlParameter>
                {
                    new SqlParameter("@id", idseleccionado)
                };


                BD.Consultando(consulta, parametros);
                TSB_Consulta_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un registro a eliminar"
                    , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TSB_Consulta_Click(sender, e);
        }

        private void TSB_Buscar_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            VentanaBuscar buscar = new(tutor);
            buscar.FormClosed += (s, args) => this.Show();
            buscar.Show();


            DataTable tablita = BD.Consultando(tutor.consulta);
            DGVTutores.DataSource = tablita;
            TSB_Consulta_Click(sender, e);
        }

        private void TSB_Cita_Click(object sender, EventArgs e)
        {
            VentanaCita ventana = new();
            this.Close();
            ventana.FormClosed += (s, args) => this.Show();
            ventana.Show();
        }
    }
}