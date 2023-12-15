using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class Conexion
    {
        private readonly string conexion;
        public Conexion()
        {
            //conexion = "Server=LUNA; Database=SistemaVencejo; Integrated security=true";
            //conexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Plantilla base\\Login\\INTERNACIONAL\\SIstemaVencejo\\AccesoDatos\\DATOS\\SistemaVencejo.mdf;Integrated Security=True";
            conexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DATOS\\SistemaVencejo.mdf;Integrated Security=True";

        }
        protected SqlConnection GetConnection()
        {
          return new SqlConnection(conexion);
        }

    }
}
