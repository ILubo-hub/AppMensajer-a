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
    /// Clase de conexión entre la capa de datos y la UI de tarjeta
    /// </summary>
    class BLLTarjeta : IBLLTarjeta
    {
        #region Obtener Tarjetas
        /// <summary>
        /// Método que devuelve todas las tarjetas que hay en la base de datos
        /// </summary>
        /// <returns>Retorna las tarjetas que hay en la base de datos</returns>
        public List<Tarjeta> GetAllTarjeta()
        {
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            return _DALTarjeta.GetAllTarjeta();
        }
        #endregion
    }
}
