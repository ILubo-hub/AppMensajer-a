using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase BLLProvincia
    /// </summary>
    interface IBLLProvincia
    {
        #region Obtener Provincias
        /// <summary>
        /// Método que muestra las provincias que hay en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con las provincias</returns>
        List<Provincia> MostrarProvincias();
        #endregion
    }
}
