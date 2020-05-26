using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase BLLImpuesto
    /// </summary>
    interface IBLLImpuesto
    {
        #region Obtener Impuesto
        /// <summary>
        /// Método que obtiene el impuesto de la base de datos
        /// </summary>
        /// <returns>Retorna el impuesto</returns>
        List<Impuesto> ObtenerImpuesto();
        #endregion
    }
}
