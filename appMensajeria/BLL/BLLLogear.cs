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
    /// Clase de enlace entre la capa de datos y la capa grafica
    /// </summary>
    class BLLLogear : IBLLLogear
    {
        #region Logear
        /// <summary>
        /// Metodo que implementa al metodo logear de la clase DAL
        /// </summary>
        /// <param name="usuario">Nobre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public Usuario Logear(string pass, string usuario)
        {
            IDALLogear _IDALLogear = new DALLogear();
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(pass))
            {
                throw new Exception("No pueden haber valores nulos");
            }
            else
            {
                return _IDALLogear.Login(pass, usuario);
            }
        }
        #endregion

        #region Obtener Tipo Usuario
        /// <summary>
        /// Metodo que implementa el metodo ObtenerTipo de la clase DAL
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <param name="pass">Contraeña</param>
        /// <returns>Retorna una string con el tipo de usuario</returns>
        public string ObtenerTipo(string usuario, string pass)
        {
            IDALLogear _IDALLogear = new DALLogear();
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(pass))
            {
                throw new Exception();
            }
            else
            {
                return _IDALLogear.ObtenerTipo(usuario, pass);
            }
        }
        #endregion
    }
}
