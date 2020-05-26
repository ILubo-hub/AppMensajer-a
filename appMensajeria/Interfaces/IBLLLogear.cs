using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase BLLLogear
    /// </summary>
    interface IBLLLogear
    {
        #region Logear
        /// <summary>
        /// Método que logea al usuario
        /// </summary>
        /// <param name="contrasenna">Usuario</param>
        /// <param name="Usuario">Contraseña</param>
        /// <returns>Retorna el usuario que se encontró</returns>
        Usuario Logear(string contrasenna, string Usuario);
        #endregion

        #region Obtener tipo usuario
        /// <summary>
        /// Método que obtiene el tipo de usuario
        /// </summary>
        /// <param name="Usuario">Usurio</param>
        /// <param name="contrasenna">Contraseña</param>
        /// <returns>Retorna el tipo de Usuario</returns>
        string ObtenerTipo(string Usuario, string contrasenna);
        #endregion
    }
}
