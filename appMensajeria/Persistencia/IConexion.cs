using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Mensajeria.Winform.Persistencia
{
    /// <summary>
    /// Interface de la clase Conexion
    /// </summary>
    interface IConexion
    {
        /// <summary>
        /// Método que crea la conexión a sql
        /// </summary>
        /// <returns>Retorna la conexión a sql</returns>
        SqlConnection conexion();
    }
}
