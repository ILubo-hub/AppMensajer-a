using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase DALSeguridad
    /// </summary>
    interface IDALSeguridad
    {
        #region Obtener Usuarios
        /// <summary>
        /// Método que muestra todos los usuarios de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con todo los usuarios que hay en la base de datos</returns>
        List<Usuario> ObtenerUsuarios();
        #endregion

        #region Insertar Usuarios
        /// <summary>
        /// Método que agrega un usuario a la base de datos
        /// </summary>
        /// <param name="pUsuario">Usuario que se va a agregar</param>
        /// <returns>Retorna el usuario que se agregó</returns>
        Usuario AgregarUsuario(Usuario pUsuario);
        #endregion

        #region Obtener usuario por ID
        /// <summary>
        /// Método que busca usuarios por ID
        /// </summary>
        /// <param name="pass">ID compuesta</param>
        /// <param name="login">ID compuesta</param>
        /// <returns></returns>
        Usuario SelectUsuarioXID(string pass, string login);
        #endregion

        #region Eliminar usuario
        /// <summary>
        /// Método que elimina un Usuario de la base de datos
        /// </summary>
        /// <param name="pass">ID compuesta</param>
        /// <param name="login">ID compuesta</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        string EliminarUsuario(string pass, string login);
        #endregion
    }
}
