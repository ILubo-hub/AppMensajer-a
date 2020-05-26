using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase BLLSeguridad
    /// </summary>
    interface IBLLSeguridad
    {
        #region Obtener Usuarios
        /// <summary>
        /// Método que obtiene todos los usuarios de la base de datos
        /// </summary>
        /// <returns>Rertorna una lista de todos los usuarios</returns>
        List<Usuario> ObtenerUsuarios();
        #endregion

        #region Insertar Usuario
        /// <summary>
        /// Método que agrega un usuario a la base de datos
        /// </summary>
        /// <param name="pUsuario">Usuario que se va a agregar</param>
        /// <returns>Retorna el usuario que se agregó</returns>
        Usuario AgregarUsuario(Usuario pUsuario);
        #endregion

        #region Obtener usuario por ID
        /// <summary>
        /// Método que selecciona un usuario por id
        /// </summary>
        /// <param name="pass">ID compuesta del usuario</param>
        /// <param name="login">ID compuesta del usuario</param>
        /// <returns>Retorna el usuario que se encontró</returns>
        Usuario SelectUsuarioXID(string pass, string login);
        #endregion

        #region Eiminar Usuario
        /// <summary>
        /// Método que elimina un usuario de la base de datos
        /// </summary>
        /// <param name="pass">Nombre de usuario del usuario que se va a eliminar</param>
        /// <param name="login">Contraseña del usuario que se va a eliminar</param>
        /// <returns>Retorna una string con la respuesta del stored procedure</returns>
        string EliminarUsuario(string pass, string login);
        #endregion
    }
}
