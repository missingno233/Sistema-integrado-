using Sistema_integrado.Ventanas;
using Sistema_integrado.Models;

namespace Sistema_integrado
{
    public partial class Form1 : Form
    {
        private string ventana = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void TSB_Crear_Click(object sender, EventArgs e)
        {
            ventana = "crearEditar";
            abreVentanas(ventana);
        }

        private void TSB_Consulta_Click(object sender, EventArgs e)
        {
            Models.ConexionBD()
        }

        private void TSB_Editar_Click(object sender, EventArgs e)
        {

        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {

        }

        public void abreVentanas(string Ventana)
        {
            switch (Ventana)
            {
                default:
                    break;
                case "crearEditar": 
                    {
                        VentanaCrearEditar ventana = new VentanaCrearEditar();
                        ventana.ShowDialog();
                        break;
                    }
                case "eliminar":
                    {
                        VentanaEliminar ventana = new VentanaEliminar();
                        ventana.ShowDialog();
                        break;
                    }
            }
        }
    }
}
