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
    /// Clase de datos del Login del programa
    /// </summary>
    class DALLogear : IDALLogear
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Logear
        /// <summary>
        /// Metodo que verifica si la contraseña y el usuario son corrector para permitir o denegar acceso
        /// </summary>
        /// <param name="user">Nombre de Usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns>Retorna una string con la respuesta del storedprocedure</returns>
        public Usuario Login(string pass, string login)
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

        #region Obtener Tipo
        /// <summary>
        /// Metodo que obtiene el tipo de usuario que entro al sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <returns>Retorna el tipo de usuario que es</returns>
        public string ObtenerTipo(string usuario, string contrasena)
        {
            string resultado = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select TipoUsuario from [Seguridad] where NombreUsuario=@usuario and Contrasena=@contrasena", conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    resultado = dt.Rows[0][0].ToString();
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
            return resultado;
        }
        #endregion
    }
}
