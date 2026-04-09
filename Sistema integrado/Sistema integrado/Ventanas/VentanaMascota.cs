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

            consulta = "INSERT INTO [dbo].[Mascotas] \r\n " +
                "([Nombre]\r\n" +
                ",[Especie\r\n" +
                ",[Raza]\r\n" +
                ",[Edad]\r\n" +
                ",[Peso])\r\n " +
                "VALUES\r\n" +
                "(@Nombre\r\n" +
                ",@Especie\r\n" +
                ",@Raza\r\n" +
                ",@Edad\r\n" +
                ",@Peso)\r\n";
            var parametros = new List<SqlParameter>
            {
            new ("@Nombre", paciente.Nombre),
            new ("@Especie", paciente.Especie),
            new ("@Raza", paciente.Raza),
            new ("@Edad", paciente.Edad),
            new ("@Peso", paciente.Peso)
            };
            BD.Consultando(consulta, parametros);
        }

        private void TSB_Consulta_Click(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM [dbo].[Mascotas]";

            DataTable tablita = BD.Consultando(consulta);
            DGVMascotas.DataSource = tablita;
        }

        private void TSB_Editar_Click(object sender, EventArgs e)
        {
            VentanaCrearEditar ventana = new VentanaCrearEditar(true, paciente);
            ventana.ShowDialog();



        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            consulta = "DELETE FROM Mascotas WHERE id = @id";


            if (DGVMascotas.SelectedRows != null &&
                DGVMascotas.SelectedRows.Count > 0)
            {
                idseleccionado = Convert.ToInt32(DGVMascotas.
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

        private void TSB_BuscarMascotas_Click(object sender, EventArgs e)
        {

        }

        
    }
}
