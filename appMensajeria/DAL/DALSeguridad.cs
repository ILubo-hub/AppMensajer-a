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
    /// Clase de acceso a datos de seguridad
    /// </summary>
    class DALSeguridad : IDALSeguridad
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Insertar Usuario
        /// <summary>
        /// Método que agrega un usuario a la base de datos 
        /// </summary>
        /// <param name="pUsuario">Usuario que se va a agregar</param>
        /// <returns>Retorna el usuario que se agregó</returns>
        public Usuario AgregarUsuario(Usuario pUsuario)
        {
            string client = "";
            Usuario oUsuario = new Usuario();
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_INSERT_Seguridad";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@NombreUsuario", pUsuario.Login);
                    comm.Parameters.AddWithValue("@Contrasena", pUsuario.Password);
                    comm.Parameters.AddWithValue("@TipoUsuario", pUsuario.TipoUsuario);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = pUsuario.Login;
                    }
                    oUsuario = this.SelectUsuarioXID(pUsuario.Password, pUsuario.Login);
                    return oUsuario;
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

        #region Eliminar Usuario
        /// <summary>
        /// Método que elimina un Usuario de la base de datos
        /// </summary>
        /// <param name="pass">ID compuesta</param>
        /// <param name="login">ID compuesta</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public string EliminarUsuario(string pass, string login)
        {
            string client = "";
            Usuario oUsuario = new Usuario();
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_DELETE_Seguridad_ByID";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@NombreUsuario", login);
                    comm.Parameters.AddWithValue("@Contrasena", pass);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = pass + login;
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

        #region Obtener Usuarios
        /// <summary>
        /// Método que muestra todos los usuarios de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todo los usuarios que hay en la base de datos</returns>
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> _ListUsuarios = new List<Usuario>();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [Seguridad]", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {
                        Usuario oUsuario = new Usuario();
                        oUsuario.Login = dr["NombreUsuario"].ToString();
                        oUsuario.Password = dr["Contrasena"].ToString();
                        oUsuario.TipoUsuario = dr["TipoUsuario"].ToString();

                        _ListUsuarios.Add(oUsuario);
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
            return _ListUsuarios;
        }
        #endregion

        #region Buscar Usuario por ID
        /// <summary>
        /// Método que busca usuarios por ID
        /// </summary>
        /// <param name="pass">ID compuesta</param>
        /// <param name="login">ID compuesta</param>
        /// <returns>Retorna el usuario que cumpla con el ID</returns>
        public Usuario SelectUsuarioXID(string pass, string login)
        {
            Usuario oUsuario = new Usuario();
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_SELECT_Seguridad_ByID", conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", login);
                    cmd.Parameters.AddWithValue("@Contrasena", pass);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        oUsuario.Login = dt.Rows[0][0].ToString();
                        oUsuario.Password = dt.Rows[0][1].ToString();
                        oUsuario.TipoUsuario = dt.Rows[0][2].ToString();
                    }
                    else
                    {
                        oUsuario = null;
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
            return oUsuario;
        }
        #endregion
    }
}
