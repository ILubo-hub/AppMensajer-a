using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase DALTarjeta
    /// </summary>
    interface IDALTarjeta
    {
        #region Obtener Tarjetas
        /// <summary>
        /// Método que obtiene todas las tarjetas de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con las tarjetas</returns>
        List<Tarjeta> GetAllTarjeta();
        #endregion

        #region Obtener tarjetas por ID
        /// <summary>
        /// Método que obtiene las tarjetas por ID
        /// </summary>
        /// <param name="id">ID de la tarjeta</param>
        /// <returns>Retorna la tarjeta que se encontró</returns>
        Tarjeta GetTarjetID(string id);
        #endregion
    }
}
