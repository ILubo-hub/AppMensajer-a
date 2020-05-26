using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de DALLogear
    /// </summary>
    interface IDALLogear
    {
        #region Logear
        /// <summary>
        /// Método que logea el usuario
        /// </summary>
        /// <param name="pass">Nombre de usuario</param>
        /// <param name="login">Contraseña</param>
        /// <returns>Rertorna el usuario que se registró</returns>
        Usuario Login(string pass, string login);
        #endregion

        #region Obtener tipo usuario
        /// <summary>
        /// Metodo que obtiene el tipo por ID
        /// </summary>
        /// <param name="usuario">ID compuesta</param>
        /// <param name="contrasena">ID compuesta</param>
        /// <returns>Retorna el tipo</returns>
        string ObtenerTipo(string usuario, string contrasena);
        #endregion
    }
}
