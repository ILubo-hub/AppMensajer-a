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
    /// Clase de acceso a datos de Provincia
    /// </summary>
    class DALProvincia : IDALProvincia
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Obtener Provincias
        /// <summary>
        /// Metodo que devuelve las provincias que hay en la base de datos
        /// </summary>
        /// <returns>Retorna una lista fuertemente tipada con las provincias que hay en la base de datos</returns>
        public List<Provincia> MostrarProvincias()
        {
            List<Provincia> _ListProvincias = new List<Provincia>();
            IConexion conexion = new Conexion();
            DataSet dt = new DataSet();
            using (SqlConnection conn = conexion.conexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [Provincia]", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {
                        Provincia _Provincia = new Provincia()
                        {
                            IDProvincia = dr["Provincia"].ToString(),
                            CodigoProvincia = Convert.ToInt32(dr["Codigo"].ToString())
                        };
                        _ListProvincias.Add(_Provincia);
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
            return _ListProvincias;
        }
        #endregion
    }
}
