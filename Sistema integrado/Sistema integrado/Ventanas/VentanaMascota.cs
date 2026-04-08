using Sistema_integrado.Ventanas;
using Sistema_integrado.Models;

namespace Sistema_integrado
{
    public partial class VentanaMascota : Form
    {
        private string ventana = "";
        private string consulta = "";
        public VentanaMascota()
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
        
        }

        private void TSB_Editar_Click(object sender, EventArgs e)
        {
            ventana = "crearEditar";
            abreVentanas(ventana);
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            ventana = "eliminar";
            abreVentanas(ventana);
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
