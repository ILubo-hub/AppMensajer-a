using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase DALImpuesto
    /// </summary>
    interface IDALImpuesto
    {
        #region Obtener Impuesto
        /// <summary>
        /// Método que obtiene el impuesto de la base de datos
        /// </summary>
        /// <returns>Una lista con los impuestos que hay</returns>
        List<Impuesto> ObtenerImpuesto();
        #endregion
    }
}
