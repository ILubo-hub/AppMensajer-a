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
    /// Clase de acceso a datos del impuesto
    /// </summary>
    class BLLImpuesto : IBLLImpuesto
    {
        #region Obtener Impuesto
        /// <summary>
        /// Método que obtiene la lista de impuestos de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con los impuestos de la base de datos</returns>
        public List<Impuesto> ObtenerImpuesto()
        {
            IDALImpuesto _DALImpuesto = new DALImpuesto();
            return _DALImpuesto.ObtenerImpuesto();
        }
        #endregion
    }
}
