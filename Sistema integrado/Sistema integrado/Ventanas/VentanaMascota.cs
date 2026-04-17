using Microsoft.Data.SqlClient;
using Sistema_integrado.Models;
using Sistema_integrado.Ventanas;
using System.Data;

namespace Sistema_integrado
{
    public partial class VentanaMascota : Form
    {

        private ConexionBD BD = new();
        private Paciente paciente = new();
        private string consulta = "";
        private int idseleccionado = 0;
        public VentanaMascota()
        {
            InitializeComponent();
        }
        private void TSB_Crear_Click(object sender, EventArgs e)
        {
            VentanaCrearEditar ventana = new VentanaCrearEditar(false, paciente);
            ventana.ShowDialog();

            var parametros = new List<SqlParameter>
            {
                new ("@Nombre", paciente.Nombre),
                new ("@Especie", paciente.Especie),
                new ("@Raza", paciente.Raza),
                new ("@Edad", paciente.Edad),
                new ("@Peso", paciente.Peso)
            };

            DataTable tabla = BD.Consultando(paciente.consulta, parametros);
            DGVMascotas.DataSource = tabla;

            TSB_Consulta_Click(sender, e);
        }

        private void TSB_Consulta_Click(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM Mascotas";

            DataTable tablita = BD.Consultando(consulta);
            DGVMascotas.DataSource = tablita;
        }

        private void TSB_Editar_Click(object sender, EventArgs e)
        {
            if (DGVMascotas.SelectedRows != null &&
                DGVMascotas.SelectedRows.Count > 0)
            {
                idseleccionado = Convert.ToInt32(DGVMascotas.
                    SelectedRows[0].Cells[0].Value);

                VentanaCrearEditar ventana = new(true, paciente);
                ventana.ShowDialog();


                var parametros = new List<SqlParameter>
                {
                    new("@Id", idseleccionado),
                    new("@Nombre", paciente.Nombre),
                    new("@Especie", paciente.Especie),
                    new("@Raza", paciente.Raza),
                    new("@Edad", paciente.Edad),
                    new("@Peso", paciente.Peso),
                };
                DataTable tabla = BD.Consultando(paciente.consulta, parametros);
                DGVMascotas.DataSource = tabla;

                TSB_Consulta_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un registro a editar"
                    , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {

            if (DGVMascotas.SelectedRows != null &&
                DGVMascotas.SelectedRows.Count > 0)
            {
                consulta = "DELETE FROM Mascotas WHERE id = @id";

                idseleccionado = Convert.ToInt32(DGVMascotas.
                    SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var parametros = new List<SqlParameter>
                    {
                        new SqlParameter("@id", idseleccionado)
                    };


                    BD.Consultando(consulta, parametros);
                    TSB_Consulta_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("El registro no ha sido eliminado.", "Eliminación cancelada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un registro a eliminar"
                    , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void TSB_BuscarMascotas_Click(object sender, EventArgs e)
        {
            Paciente pat = new Paciente();
            VentanaBuscar buscar = new(pat);
            buscar.FormClosed += (s, args) => this.Show();
            buscar.Show();


            var parametros = new List<SqlParameter>
            {
                new SqlParameter("@Nombre", pat.Nombre)
            };


            DataTable tablita = BD.Consultando(pat.consulta, parametros);
            DGVMascotas.DataSource = tablita;

            TSB_Consulta_Click(sender, e);
        }

        private void TSB_Cita_Click(object sender, EventArgs e)
        {
            VentanaCita ventana = new VentanaCita();
            this.Hide();
            ventana.FormClosed += (s, args) => this.Show();
            ventana.Show();
        }
    }
}
