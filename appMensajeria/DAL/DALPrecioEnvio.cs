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
    /// Clase de acceso a datos de Envio
    /// </summary>
    class DALPrecioEnvio : IDALPrecioEnvio
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Actualizar PrecioEnvio
        /// <summary>
        /// Metodo que actualiza un valor en la base de datos con el parametro recibido
        /// </summary>
        /// <param name="oEnvio">Parametro que actualizará en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public EnvioPaquete ActualizarPrecioEnvio(EnvioPaquete oEnvio)
        {
            string client = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_ModificarPrecio";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@TipoEnvio", oEnvio.TipoEnvio);
                    comm.Parameters.AddWithValue("@Precio", oEnvio.PrecioRango);
                    comm.Parameters.AddWithValue("@KilometroInicial", oEnvio.KilometroInicial);
                    comm.Parameters.AddWithValue("@KilometroFinal", oEnvio.KilometroFinal);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = oEnvio.TipoEnvio;
                    }
                    return this.MostrarXID(oEnvio.TipoEnvio);
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
        }
        #endregion

        #region Eliminar PrecioEnvio
        /// <summary>
        /// Metodo que elimina un precio de la base de datos
        /// </summary>
        /// <param name="id">Identificación del precio a eliminar</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public string BorrarEnvio(string id)
        {
            string client = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_EliminarPrecio";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@TipoEnvio", id);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = id;
                    }
                    return client;
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
        }
        #endregion

        #region Insertar PrecioEnvio
        /// <summary>
        /// Metodo que Inserta un precio nuevo a la base de datos
        /// </summary>
        /// <param name="oEnvio">Precio a agregarse</param>
        /// <returns>Retorna una string con la respuesta del StoredProcedure</returns>
        public EnvioPaquete InsertarPrecioEnvio(EnvioPaquete oEnvio)
        {
            string client = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_InsertarPrecio";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@TipoEnvio", oEnvio.TipoEnvio);
                    comm.Parameters.AddWithValue("@PrecioRango", oEnvio.PrecioRango);
                    comm.Parameters.AddWithValue("@KilometroInicial", oEnvio.KilometroInicial);
                    comm.Parameters.AddWithValue("@KilometroFinal", oEnvio.KilometroFinal);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = oEnvio.PrecioRango.ToString();
                    }
                    return this.MostrarXID(oEnvio.TipoEnvio);
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
        }
        #endregion

        #region Obtener PreciosEnvio
        /// <summary>
        /// Método que obtiene los precios de envio de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con los precios</returns>
        public List<EnvioPaquete> ListaPrecios()
        {
            List<EnvioPaquete> _ListPrecios = new List<EnvioPaquete>();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [EnvioPaquete]", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {
                        EnvioPaquete EnvioPaquete = new EnvioPaquete();

                        EnvioPaquete.TipoEnvio = dr["TipoEnvio"].ToString();
                        EnvioPaquete.PrecioRango = Convert.ToDouble(dr["PrecioRango"].ToString());
                        EnvioPaquete.KilometroInicial = Convert.ToInt32(dr["KilometroInicial"].ToString());
                        EnvioPaquete.KilometroFinal = Convert.ToInt32(dr["KilometroFinal"].ToString());
                        _ListPrecios.Add(EnvioPaquete);
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
            return _ListPrecios;
        }
        #endregion

        #region Obtener PrecioEnvio por ID
        /// <summary>
        /// Método que busca precios por ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Retorna el Envio que se encuentre</returns>
        public EnvioPaquete MostrarXID(string id)
        {
            EnvioPaquete EnvioPaquete = new EnvioPaquete();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"PA_MostrarEnvioXID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {
                        EnvioPaquete.TipoEnvio = dr["TipoEnvio"].ToString();
                        EnvioPaquete.PrecioRango = Convert.ToDouble(dr["PrecioRango"].ToString());
                        EnvioPaquete.KilometroInicial = Convert.ToInt32(dr["KilometroInicial"].ToString());
                        EnvioPaquete.KilometroFinal = Convert.ToInt32(dr["KilometroFinal"].ToString());
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
            return EnvioPaquete;
        }
        #endregion
    }
}
