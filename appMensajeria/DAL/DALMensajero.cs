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
    /// Clase de datos del mensajero
    /// </summary>
    class DALMensajero : IDALMensajero
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Obtener Mensajeros
        /// <summary>
        /// Metodo que muestra los mensajeros que hay en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con la información</returns>
        public List<Mensajero> MostrarMensajeros()
        {
            IConexion conexion = new Conexion();
            List<Mensajero> _ListMensajeros = new List<Mensajero>();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [Mensajero]", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {
                        Mensajero oMensajero = new Mensajero();
                        oMensajero.IDMensajero = dr["IDMensajero"].ToString();
                        oMensajero.Nombre = dr["Nombre"].ToString();
                        oMensajero.Apellidos = dr["Apellidos"].ToString();
                        oMensajero.Sexo = dr["Sexo"].ToString();
                        oMensajero.Foto = (byte[])dr["Foto"];
                        oMensajero.Correo = dr["CorreoElectronico"].ToString();
                        oMensajero.Activo = Convert.ToBoolean(dr["Activo"].ToString());
                        oMensajero.Telefono = dr["Telefono"].ToString();

                        _ListMensajeros.Add(oMensajero);
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
            return _ListMensajeros;
        }
        #endregion

        #region Instertar Mensajero
        /// <summary>
        /// Metodo que inserta un mensajero a la base de datos
        /// </summary>
        /// <param name="oMensajero">Mensajero a insertar en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public Mensajero InsertarMensajero(Mensajero oMensajero)
        {
            string client = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_InsertarMensajero";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@IDMensajero", oMensajero.IDMensajero);
                    comm.Parameters.AddWithValue("@Nombre", oMensajero.Nombre);
                    comm.Parameters.AddWithValue("@Apellidos", oMensajero.Apellidos);
                    comm.Parameters.AddWithValue("@Sexo", oMensajero.Sexo);
                    comm.Parameters.AddWithValue("@foto", oMensajero.Foto);
                    comm.Parameters.AddWithValue("@Correo", oMensajero.Correo);
                    comm.Parameters.AddWithValue("@Activo", oMensajero.Activo);
                    comm.Parameters.AddWithValue("@Telefono", oMensajero.Telefono);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = oMensajero.IDMensajero;
                    }
                    return this.BuscarMensajeroID(oMensajero.IDMensajero);
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

        #region Modificar Mensajero
        /// <summary>
        /// Metodo que modifica a un cliente en la base de datos
        /// </summary>
        /// <param name="oMensajero">Mensajero que modificará en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public Mensajero ModificarMensajero(Mensajero oMensajero)
        {
            string client = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_ModificarMensajero";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@IDMensajero", oMensajero.IDMensajero);
                    comm.Parameters.AddWithValue("@Nombre", oMensajero.Nombre);
                    comm.Parameters.AddWithValue("@Apellidos", oMensajero.Apellidos);
                    comm.Parameters.AddWithValue("@Sexo", oMensajero.Sexo);
                    comm.Parameters.AddWithValue("@foto", oMensajero.Foto);
                    comm.Parameters.AddWithValue("@Correo", oMensajero.Correo);
                    comm.Parameters.AddWithValue("@Activo", oMensajero.Activo);
                    comm.Parameters.AddWithValue("@Telefono", oMensajero.Telefono);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = oMensajero.IDMensajero;
                    }
                    return this.BuscarMensajeroID(oMensajero.IDMensajero);
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

        #region Eliminar Mensajero
        /// <summary>
        /// Metodo que elimina un Mensajero de la base de datos
        /// </summary>
        /// <param name="IDMensajero">Número de identificación del mensajero que será eliminado</param>
        /// <returns>Retorna una string con el resultado del storeProcedure</returns>
        public string BorrarMensajero(string IDMensajero)
        {
            string client = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_EliminarMensajero";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@id", IDMensajero);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = IDMensajero;
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

        #region Buscar Mensajero por ID
        /// <summary>
        /// Método que busca mensajeros por ID en la base de datos
        /// </summary>
        /// <param name="IDMensajero">ID dej mensajero</param>
        /// <returns>Retorna el mensajero que se encuentre en la base de datos</returns>
        public Mensajero BuscarMensajeroID(string IDMensajero)
        {
            Mensajero oMensajero = new Mensajero();
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [Mensajero] where IDMensajero= @IDMensajero", conn);
                    cmd.Parameters.AddWithValue("@IDMensajero", IDMensajero);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        oMensajero.IDMensajero = dt.Rows[0][0].ToString();
                        oMensajero.Nombre = dt.Rows[0][1].ToString();
                        oMensajero.Apellidos = dt.Rows[0][2].ToString();
                        oMensajero.Sexo = dt.Rows[0][3].ToString();
                        oMensajero.Foto = (byte[])(dt.Rows[0][4]);
                        oMensajero.Correo = dt.Rows[0][5].ToString();
                        oMensajero.Activo = (Boolean)dt.Rows[0][6];
                        oMensajero.Telefono = dt.Rows[0][7].ToString();
                    }
                    else
                    {
                        oMensajero = null;
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
            return oMensajero;
        }
        #endregion

        #region Buscar Mensajero por filtro
        /// <summary>
        /// Método que busca mensajeros por filtro
        /// </summary>
        /// <param name="flitro">filtro</param>
        /// <returns>Retorna una lista de mensajeros que cumplan con el filtro</returns>
        public List<Mensajero> BuscarMensajeroByFilter(string flitro)
        {
            List<Mensajero> _ListMensajero = new List<Mensajero>();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"PA_BuscarMensajeroByFilter", conn);
                    cmd.Parameters.AddWithValue("@Filtro", flitro);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            Mensajero oMensajero = new Mensajero();
                            oMensajero.IDMensajero = dr["IDMensajero"].ToString();
                            oMensajero.Nombre = dr["Nombre"].ToString();
                            oMensajero.Apellidos = dr["Apellidos"].ToString();
                            oMensajero.Foto = (byte[])dr["Foto"];

                            _ListMensajero.Add(oMensajero);
                        }

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
            return _ListMensajero;
        }
        #endregion
    }
}
