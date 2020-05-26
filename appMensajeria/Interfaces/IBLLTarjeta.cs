using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase BLLTarjeta
    /// </summary>
    interface IBLLTarjeta
    {
        #region Obtener Tarjetas
        /// <summary>
        /// Método que obtiene todas las tarjetas de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todas las tarjetas</returns>
        List<Tarjeta> GetAllTarjeta();
        #endregion
    }
}
