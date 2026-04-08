using Microsoft.Data.SqlClient;
using Sistema_integrado.Models;
using Sistema_integrado.Ventanas;

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
            VentanaCrearEditar ventana = new VentanaCrearEditar(paciente);
            ventana.ShowDialog();
        }

        private void TSB_Consulta_Click(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM Mascotas";

            BD.Consultando(consulta);
        }

        private void TSB_Editar_Click(object sender, EventArgs e)
        {
            VentanaCrearEditar ventana = new VentanaCrearEditar(paciente);
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

        
    }
}
