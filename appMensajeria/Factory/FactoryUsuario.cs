using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Factory
{
    /// <summary>
    /// Clase de construcción de Usuario
    /// </summary>
    class FactoryUsuario
    {
        /// <summary>
        /// Método que construye un usuario con los atributos
        /// </summary>
        /// <param name="login">Nombre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <param name="tipo">Tipo de Usuario</param>
        /// <returns>Retorna un objeto usuario</returns>
        public static Usuario ConstruirUsuario(string login, string pass, string tipo)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.Login = login;
            oUsuario.Password = pass;
            oUsuario.TipoUsuario = tipo;

            return oUsuario;
        }
    }
}
