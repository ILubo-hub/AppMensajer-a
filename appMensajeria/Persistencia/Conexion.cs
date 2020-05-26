using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Persistencia;

namespace UTN.Mensajeria.Winform.DAL
{
    /// <summary>
    /// Clase conexion que genera la conexión a sqlServer
    /// </summary>
    class Conexion : IConexion
    {
        /// <summary>
        /// Metodo que contruye la conexión a sqlServer
        /// </summary>
        /// <returns>retorna una conexión a sqlServer</returns>
        public SqlConnection conexion()
        {
            SqlConnection con;
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=EnviosDB;User ID = AccesoProyecto; Password = iOp365Tral47");
                con.Open();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            return con;
        }
    }
}
