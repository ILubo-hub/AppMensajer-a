using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;
using UTN.Mensajeria.Winform.Interfaces;
using UTN.Mensajeria.Winform.Persistencia;

namespace UTN.Mensajeria.Winform.DAL
{
    /// <summary>
    /// Clase de acceso a datos de tarjeta
    /// </summary>
    class DALTarjeta : IDALTarjeta
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Obtener Tarjetas
        /// <summary>
        /// Método que obtiene todas las tarjetas de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con las tarjetas que hay en la base de datos</returns>
        public List<Tarjeta> GetAllTarjeta()
        {
            List<Tarjeta> _ListTarjeta = new List<Tarjeta>();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarTarjetas", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {
                        Tarjeta oTarjeta = new Tarjeta();
                        oTarjeta.IDTarjeta = dr["IDTarjeta"].ToString();
                        oTarjeta.Descripcion = dr["Descripcion"].ToString();

                        _ListTarjeta.Add(oTarjeta);
                    }
                }
                catch (SqlException sqlError)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(Utilitarios.CreateSQLExceptionsErrorDetails(sqlError));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
                catch (Exception er)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return _ListTarjeta;
        }
        #endregion

        #region Obtener Tarjetas por ID
        /// <summary>
        /// Método que obtiene la tarjeta por ID
        /// </summary>
        /// <param name="id">ID de la tarjeta</param>
        /// <returns>Retorna la tarjeta que se encontró</returns>
        public Tarjeta GetTarjetID(string id)
        {
            Tarjeta oTarjeta = new Tarjeta();
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [Tarjeta] where IDTarjeta = @IDTarjeta", conn);
                    cmd.Parameters.AddWithValue("@IDTarjeta", id);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        oTarjeta.IDTarjeta = dt.Rows[0][0].ToString();
                        oTarjeta.Descripcion = dt.Rows[0][1].ToString();
                    }
                    else
                    {
                        oTarjeta = null;
                    }

                }
                catch (SqlException sqlError)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(Utilitarios.CreateSQLExceptionsErrorDetails(sqlError));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
                catch (Exception er)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return oTarjeta;
        }
        #endregion
    }
}
