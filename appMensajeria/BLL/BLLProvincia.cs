using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.DAL;
using UTN.Mensajeria.Winform.Entidades;
using UTN.Mensajeria.Winform.Interfaces;

namespace UTN.Mensajeria.Winform.BLL
{
    /// <summary>
    /// Clase de conexión entre la capa de datos y la UI de provincia
    /// </summary>
    class BLLProvincia : IBLLProvincia
    {
        #region Obtener Provincias
        /// <summary>
        /// Clase intermedio entre la capa de datos y la UI de provincia
        /// </summary>
        /// <returns>Retrorna una lista de provincias cargada en la capa de datos</returns>
        public List<Provincia> MostrarProvincias()
        {
            IDALProvincia _DALProvincia = new DALProvincia();
            return _DALProvincia.MostrarProvincias();
        }
        #endregion
    }
}
