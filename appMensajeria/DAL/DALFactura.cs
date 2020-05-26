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
    /// Clase de acceso a datos de la factura
    /// </summary>
    class DALFactura : IDALFactura
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Obtener numero actual de factura
        /// <summary>
        /// Método que devuelve el número actual de la factura
        /// </summary>
        /// <returns>Retorna el número actual de una secuencia</returns>
        public int GetCurrentNumeroFactura()
        {
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            DataTable dataTable = new DataTable();
            int numero = 0;
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT current_value FROM sys.sequences WHERE name = 'SequenceNoFactura'", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dataTable = dt.Tables[0];
                    numero = Convert.ToInt32(dataTable.Rows[0][0].ToString());
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
            return numero;
        }
        #endregion

        #region Obtener siguiente numero de factura
        /// <summary>
        /// Método que devuelve el siguiente número de factura 
        /// </summary>
        /// <returns>Retorna el siguiente número de una secuancia</returns>
        public int GetNextNumeroFactura()
        {
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            DataTable dataTable = new DataTable();
            int numero = 0;
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT NEXT VALUE FOR SequenceNoFactura", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dataTable = dt.Tables[0];
                    numero = Convert.ToInt32(dataTable.Rows[0][0].ToString());
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
            return numero;
        }
        #endregion

        #region Guardar Factura
        /// <summary>
        /// Método que guarda una factura 
        /// </summary>
        /// <param name="pFactura">Factura que se guardará</param>
        /// <returns>Retorna el Encabezado de factura que se guardó</returns>
        public EncabezadoFactura GuardarFactura(EncabezadoFactura pFactura)
        {
            EncabezadoFactura oFacturaEncabezado = new EncabezadoFactura();
            SqlDataAdapter sda = new SqlDataAdapter();
            IConexion conexion = new Conexion();
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string query = @"PA_INSERT_EncFactura";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@IDEncFactura", pFactura.IDEncFactura);
                    comm.Parameters.AddWithValue("@Fecha", pFactura.Fecha);
                    comm.Parameters.AddWithValue("@IDCliente", pFactura.oCliente.IDCliente);
                    comm.Parameters.AddWithValue("@IDMensajero", pFactura.oMensajero.IDMensajero);
                    comm.Parameters.AddWithValue("@XML", pFactura.GenerarXML());
                    comm.Parameters.AddWithValue("@IDTarjeta", pFactura.oTarjeta.IDTarjeta);
                    comm.ExecuteNonQuery();
                    //while (reader.Read())
                    //{
                    //    client = pFactura.IDEncFactura;
                    //}
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
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    string queryDetalle = @"PA_INSERT_DetFactura";
                    foreach (DetFactura item in pFactura._ListDetFactura)
                    {
                        SqlCommand comm2 = new SqlCommand(queryDetalle, conn);
                        comm2.Parameters.AddWithValue("@NoFactura", item.NoFactura);
                        comm2.Parameters.AddWithValue("@Secuancial", item.Secuencial);
                        comm2.Parameters.AddWithValue("@Total", item.Total);
                        comm2.Parameters.AddWithValue("@Cantidad", item.CantidadPaquetes);
                        comm2.Parameters.AddWithValue("@Kilometros", item.CantidadKilometros);
                        comm2.Parameters.AddWithValue("@DescripcionRuta", item.DescripcionRuta);
                        comm2.Parameters.AddWithValue("@Impuesto", item.Impuesto);
                        comm2.Parameters.AddWithValue("@DescripcionPaquete", item.DescripcionPaquete);
                        comm2.Parameters.AddWithValue("@TipoEnvio", item.TipoEnvio.TipoEnvio);
                        comm2.CommandType = CommandType.StoredProcedure;
                        comm2.ExecuteNonQuery();
                        //while (reader.Read())
                        //{
                        //    client = item.NoFactura;
                        //}
                    }
                    oFacturaEncabezado = ObtenerFactura(pFactura.IDEncFactura);

                    return oFacturaEncabezado;
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

        #region Obtener Factura por ID
        /// <summary>
        /// Método que obtiene la factura por número de factura
        /// </summary>
        /// <param name="numFact">Número de factura</param>
        /// <returns>Retorna la factura que coincida con el número</returns>
        public EncabezadoFactura ObtenerFactura(string numFact)
        {
            EncabezadoFactura oEncabezado = new EncabezadoFactura();
            IConexion conexion = new Conexion();
            IDALCliente _DALCliente = new DALCliente();
            IDALMensajero _DALMensajero = new DALMensajero();
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            IDALImpuesto _DALImpuesto = new DALImpuesto();
            IDALPrecioEnvio _DALPrecioEnvio = new DALPrecioEnvio();
            DataSet ds = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT EncFactura.IDEncFactura, EncFactura.Fecha, EncFactura.IDCliente, EncFactura.IDMensajero, EncFactura.XML, EncFactura.IDTarjeta, DetFactura.NoFactura, DetFactura.Secuancial, DetFactura.Total, DetFactura.Cantidad, DetFactura.Kilometros, DetFactura.DescripcionRuta, DetFactura.Impuesto, DetFactura.DescripcionPaquete, DetFactura.TipoEnvio FROM EncFactura INNER JOIN DetFactura ON EncFactura.IDEncFactura = @IDEncabezado", conn);
                    cmd.Parameters.AddWithValue("@IDEncabezado", numFact);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        DataRow dr = ds.Tables[0].Rows[0];

                        oEncabezado.IDEncFactura = dr["IDEncFactura"].ToString();
                        oEncabezado.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                        oEncabezado.oCliente = _DALCliente.BuscarClienteID(dr["IDCliente"].ToString());
                        oEncabezado.oMensajero = _DALMensajero.BuscarMensajeroID(dr["IDMensajero"].ToString());
                        oEncabezado.XML = dr["XML"].ToString();
                        oEncabezado.oTarjeta = _DALTarjeta.GetTarjetID(dr["IDTarjeta"].ToString());

                        foreach (var item in ds.Tables[0].Rows)
                        {
                            DetFactura oFacturaDetalle = new DetFactura();
                            oFacturaDetalle.NoFactura = dr["NoFactura"].ToString();
                            oFacturaDetalle.Secuencial = int.Parse(dr["Secuancial"].ToString());
                            oFacturaDetalle.Total = double.Parse(dr["Total"].ToString());
                            oFacturaDetalle.CantidadPaquetes = Convert.ToInt32(dr["Cantidad"].ToString());
                            oFacturaDetalle.CantidadKilometros = Convert.ToInt32(dr["Kilometros"].ToString());
                            oFacturaDetalle.DescripcionRuta = dr["DescripcionRuta"].ToString();
                            foreach (Impuesto impuesto in _DALImpuesto.ObtenerImpuesto())
                            {
                                oFacturaDetalle.Impuesto += impuesto.Valor;
                            }
                            oFacturaDetalle.DescripcionPaquete = dr["DescripcionPaquete"].ToString();
                            oFacturaDetalle.TipoEnvio = _DALPrecioEnvio.MostrarXID(dr["TipoEnvio"].ToString());
                            oEncabezado.AgregrarDetalle(oFacturaDetalle);
                        }
                    }
                    else
                    {
                        oEncabezado = null;
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
            return oEncabezado;
        }
        #endregion

        #region Obtener Factura por IDCliente
        /// <summary>
        /// Metodo que busca si el cliente tiene alguna factura enm la base de datos
        /// </summary>
        /// <param name="IdCliente">Cliente al que se le va a buscar</param>
        /// <returns>Retorna una factura de las que el cliente tenga</returns>
        public EncabezadoFactura ObtenerFacturaByIDCliente(string IdCliente)
        {
            EncabezadoFactura oEncabezado = new EncabezadoFactura();
            IConexion conexion = new Conexion();
            IDALCliente _DALCliente = new DALCliente();
            IDALMensajero _DALMensajero = new DALMensajero();
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            DataSet ds = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from EncFactura where IDCliente = @IdCliente", conn);
                    cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];

                        oEncabezado.IDEncFactura = dr["IDEncFactura"].ToString();
                        oEncabezado.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                        oEncabezado.oCliente = _DALCliente.BuscarClienteID(dr["IDCliente"].ToString());
                        oEncabezado.oMensajero = _DALMensajero.BuscarMensajeroID(dr["IDMensajero"].ToString());
                        oEncabezado.XML = dr["XML"].ToString();
                        oEncabezado.oTarjeta = _DALTarjeta.GetTarjetID(dr["IDTarjeta"].ToString());
                    }
                    else
                    {
                        oEncabezado = null;
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
            return oEncabezado;
        }
        #endregion

        #region Obtener Factura por IDMensajero
        /// <summary>
        /// Metodo que busca si el mensajero tiene alguna factura en la base de datos
        /// </summary>
        /// <param name="IdMensajero">Mensajero al que se le va a buscar</param>
        /// <returns>Retorna una factura de las que el mensajero tenga</returns>
        public EncabezadoFactura ObtenerFacturaByIDMensajero(string IdMensajero)
        {
            EncabezadoFactura oEncabezado = new EncabezadoFactura();
            IConexion conexion = new Conexion();
            IDALCliente _DALCliente = new DALCliente();
            IDALMensajero _DALMensajero = new DALMensajero();
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            DataSet ds = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from EncFactura where IDMensajero = @IdMensajero", conn);
                    cmd.Parameters.AddWithValue("@IdMensajero", IdMensajero);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];

                        oEncabezado.IDEncFactura = dr["IDEncFactura"].ToString();
                        oEncabezado.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                        oEncabezado.oCliente = _DALCliente.BuscarClienteID(dr["IDCliente"].ToString());
                        oEncabezado.oMensajero = _DALMensajero.BuscarMensajeroID(dr["IDMensajero"].ToString());
                        oEncabezado.XML = dr["XML"].ToString();
                        oEncabezado.oTarjeta = _DALTarjeta.GetTarjetID(dr["IDTarjeta"].ToString());
                    }
                    else
                    {
                        oEncabezado = null;
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
            return oEncabezado;
        }
        #endregion
    }
}
