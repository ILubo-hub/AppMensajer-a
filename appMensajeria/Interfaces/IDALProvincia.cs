using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase DALProvincia
    /// </summary>
    interface IDALProvincia
    {
        #region Obtener Provincias
        /// <summary>
        /// Método que obtiene todas las provincias que hay en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con las provincias que hay en la base de datos</returns>
        List<Provincia> MostrarProvincias();
        #endregion
    }
}
