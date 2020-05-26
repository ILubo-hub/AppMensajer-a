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
    /// Clase de acceso a datos de Impuesto
    /// </summary>
    class DALImpuesto : IDALImpuesto
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Obtener Impuesto
        /// <summary>
        /// Método que obtiene el impuesto de la base de datos
        /// </summary>
        /// <returns>Retorna el impuesto que hay en la base de datos</returns>
        public List<Impuesto> ObtenerImpuesto()
        {
            List<Impuesto> _ListImpuesto = new List<Impuesto>();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"PA_MostrarImpuesto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            Impuesto _Impuesto = new Impuesto();
                            _Impuesto.Valor = Convert.ToDouble(dr["Cantidad"].ToString());
                            _Impuesto.TipoImpuesto = dr["TipoImpuesto"].ToString();

                            _ListImpuesto.Add(_Impuesto);
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
            return _ListImpuesto;
        }
        #endregion
    }
}
