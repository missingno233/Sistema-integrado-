using Microsoft.Data.SqlClient;
using System.Data;

namespace Sistema_integrado.Models
{
    public class ConexionBD
    {
        private readonly string conexion = "";

        public ConexionBD() { }

        public ConexionBD(string conexion)
        {
            this.conexion = conexion;
        }

        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(this.conexion))
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al conectar. {ex.Message}");
                return false;
            }
        }

        //metodo principal para los comandos SQL
        public DataTable Consultando(String consulta,
            List<SqlParameter> parametros = null)
        {
            DataTable tablita = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(this.conexion))
                {
                    //abrimos conexion aunque por alguna razon no hace falta
                    conexion.Open();


                    using (SqlCommand comandito = new SqlCommand(consulta, conexion))
                    {
                        //funciona junto a SqlParameter
                        if (parametros != null)
                        {
                            comandito.Parameters.AddRange(parametros.ToArray());
                        }

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comandito))
                        {
                            adaptador.Fill(tablita);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error. {ex.Message}");
            }
            return tablita;
        }
    }
}

