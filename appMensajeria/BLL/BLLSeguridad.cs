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
    /// Clase de conexión entre la capa de datos y UI de Seguridad
    /// </summary>
    class BLLSeguridad : IBLLSeguridad
    {
        #region Agregar Usuario
        /// <summary>
        /// Método que agrega un usuario a la base de datos
        /// </summary>
        /// <param name="pUsuario">Usuario que se va a agregar</param>
        /// <returns>Retorna el usuario que se agregó</returns>
        public Usuario AgregarUsuario(Usuario pUsuario)
        {
            IDALSeguridad _DALSeguridad = new DALSeguridad();
            if (pUsuario == null)
            {
                throw new Exception("El usuario no puede ser nulo");
            }
            else
            {
                return _DALSeguridad.AgregarUsuario(pUsuario);
            }
        }
        #endregion

        #region Eliminar Usuario
        /// <summary>
        /// Método que elimina un usuario de la base de datos
        /// </summary>
        /// <param name="pass">Nombre de usuario del usuario que se va a eliminar</param>
        /// <param name="login">Contraseña del usuario que se va a eliminar</param>
        /// <returns>Retorna una string con la respuesta del stored procedure</returns>
        public string EliminarUsuario(string pass, string login)
        {
            IDALSeguridad _DALSeguridad = new DALSeguridad();
            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(login))
            {
                throw new Exception("No pueden haber valores nulos");
            }
            else
            {
                return _DALSeguridad.EliminarUsuario(pass, login);
            }
        }
        #endregion

        #region Obtener Usuarios
        /// <summary>
        /// Método que obtiene todos los usuarios de la base de datos
        /// </summary>
        /// <returns>Rertorna una lista de todos los usuarios</returns>
        public List<Usuario> ObtenerUsuarios()
        {
            IDALSeguridad _DALSeguridad = new DALSeguridad();
            return _DALSeguridad.ObtenerUsuarios();
        }
        #endregion

        #region Obtener Usuarios por ID
        /// <summary>
        /// Método que selecciona un usuario por id
        /// </summary>
        /// <param name="pass">ID compuesta del usuario</param>
        /// <param name="login">ID compuesta del usuario</param>
        /// <returns>Retorna el usuario que se encontró</returns>
        public Usuario SelectUsuarioXID(string pass, string login)
        {
            IDALSeguridad _DALSeguridad = new DALSeguridad();
            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(login))
            {
                throw new Exception("No pueden haber valores nulos");
            }
            else
            {
                return _DALSeguridad.SelectUsuarioXID(pass, login);
            }
        }
        #endregion
    }
}
