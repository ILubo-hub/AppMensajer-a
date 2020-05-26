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
using UTN.Mensajeria.Winform.Properties;

namespace UTN.Mensajeria.Winform.DAL
{
    /// <summary>
    /// Clase de metodos de datos del cliente
    /// </summary>
    class DALCliente : IDALCliente
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Eliminar Cliente
        /// <summary>
        /// Metodo que elimina un cliente de la base de datos
        /// </summary>
        /// <param name="IdCliente">Numero de cedula del cliente</param>
        /// <returns>retorna un string con el resultado del storedProcedure</returns>
        public string BorrarCliente(string IdCliente)
        {
            string client = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_EliminarCliente";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@id", IdCliente);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = IdCliente;
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

        #region Insertar Cliente
        /// <summary>
        /// Metodo que Inserta un cliente a la base de datos
        /// </summary>
        /// <param name="oCliente">Cliente a insertar</param>
        /// <returns>retorna una string con el resultado del storedProcedure</returns>
        public Cliente InsertarCliente(Cliente oCliente)
        {
            string client = "";
            Cliente vCliente = new Cliente();
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_InsertarCliente";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@IDCliente", oCliente.IDCliente);
                    comm.Parameters.AddWithValue("@Nombre", oCliente.Nombre);
                    comm.Parameters.AddWithValue("@Apellidos", oCliente.Apellidos);
                    comm.Parameters.AddWithValue("@Telefono", oCliente.Telefono);
                    comm.Parameters.AddWithValue("@CorreoElectronico", oCliente.CorreoElectronico);
                    comm.Parameters.AddWithValue("@Provincia", oCliente.Provincia);
                    comm.Parameters.AddWithValue("@Direccion", oCliente.Direccion);
                    comm.Parameters.AddWithValue("@Activo", oCliente.Activo);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = oCliente.IDCliente;
                    }
                    return this.BuscarClienteID(oCliente.IDCliente);
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

        #region Modificar Cliente
        /// <summary>
        /// Metodo que modifica un cliente en la base de datos
        /// </summary>
        /// <param name="oCliente">Cliente que modificará la base de datos</param>
        /// <returns>retorna una string con la respuesta del storedProcedure</returns>
        public Cliente ModificarCliente(Cliente oCliente)
        {
            string client = "";
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_ModificarCliente";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@IDCliente", oCliente.IDCliente);
                    comm.Parameters.AddWithValue("@Nombre", oCliente.Nombre);
                    comm.Parameters.AddWithValue("@Apellidos", oCliente.Apellidos);
                    comm.Parameters.AddWithValue("@Telefono", oCliente.Telefono);
                    comm.Parameters.AddWithValue("@CorreoElectronico", oCliente.CorreoElectronico);
                    comm.Parameters.AddWithValue("@Provincia", oCliente.Provincia);
                    comm.Parameters.AddWithValue("@Direccion", oCliente.Direccion);
                    comm.Parameters.AddWithValue("@Activo", oCliente.Activo);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        client = oCliente.IDCliente;
                    }
                    return this.BuscarClienteID(oCliente.IDCliente);
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

        #region Obtener Clientes
        /// <summary>
        /// Metodo que obtiene los clientes que hay en la base de datos
        /// </summary>
        /// <returns>retorna un dataTable con la información</returns>
        public List<Cliente> MostrarClientes()
        {
            List<Cliente> _ListCliente = new List<Cliente>();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [Cliente]", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {
                        Cliente oCliente = new Cliente();
                        oCliente.IDCliente = dr["IDCliente"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellidos = dr["Apellidos"].ToString();
                        oCliente.CorreoElectronico = dr["CorreoElectronico"].ToString();
                        oCliente.Activo = Convert.ToBoolean(dr["Activo"].ToString());
                        oCliente.Telefono = dr["Telefono"].ToString();
                        oCliente.Direccion = dr["Direccion"].ToString();
                        oCliente.Provincia = dr["Provincia"].ToString();

                        _ListCliente.Add(oCliente);
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
            return _ListCliente;
        }
        #endregion

        #region Buscar Cliente por ID
        /// <summary>
        /// Metodo que busca el cliente por ID
        /// </summary>
        /// <param name="IDCliente">ID del cliente</param>
        /// <returns>Retorna el cliente encontrado</returns>
        public Cliente BuscarClienteID(string IDCliente)
        {
            Cliente oCliente = new Cliente();
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [Cliente] where IDCliente= @IDCliente", conn);
                    cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        oCliente.IDCliente = dt.Rows[0][0].ToString();
                        oCliente.Nombre = dt.Rows[0][1].ToString();
                        oCliente.Apellidos = dt.Rows[0][2].ToString();
                        oCliente.CorreoElectronico = dt.Rows[0][3].ToString();
                        oCliente.Activo = Convert.ToBoolean(dt.Rows[0][4]);
                        oCliente.Telefono = dt.Rows[0][5].ToString();
                        oCliente.Direccion = dt.Rows[0][6].ToString();
                        oCliente.Provincia = dt.Rows[0][7].ToString();
                    }
                    else
                    {
                        oCliente = null;
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
            return oCliente;
        }
        #endregion

        #region Buscar Clientes por filtro
        /// <summary>
        /// Método que muestra clientes por un filtro
        /// </summary>
        /// <param name="descripcion">Filtro por el que se buscaran los clientes</param>
        /// <returns>Retorna una lista de los clientes que cumplan con el filtro</returns>
        public List<Cliente> MostrarClientesByFilter(string descripcion)
        {
            List<Cliente> _ListCliente = new List<Cliente>();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"PA_BuscarClienteByFilter", conn);
                    cmd.Parameters.AddWithValue("@Filtro", descripcion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            Cliente oCliente = new Cliente();
                            oCliente.IDCliente = dr["IDCliente"].ToString();
                            oCliente.Nombre = dr["Nombre"].ToString();
                            oCliente.Apellidos = dr["Apellidos"].ToString();
                            oCliente.Provincia = dr["Provincia"].ToString();

                            _ListCliente.Add(oCliente);
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
            return _ListCliente;
        }
        #endregion
    }
}


