using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace CrudProductos_Practica_Examen.Data
{
    public class ConexionBD
    {
        private readonly string cadenaConexion =
            @"Server=Evans-PC\SQLEXPRESS;
              Database=CrudEscolar;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        // Crear una conexión nueva cada vez que se solicite.
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        // Verificar si existe conexión con SQL Server.
        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
