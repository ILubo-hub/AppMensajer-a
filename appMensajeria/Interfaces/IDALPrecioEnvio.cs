using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase DALPrecioEnvio
    /// </summary>
    interface IDALPrecioEnvio
    {
        #region Insertar PrecioEnvio
        /// <summary>
        /// Metodo que Inserta un precio nuevo a la base de datos
        /// </summary>
        /// <param name="oEnvio">Precio a agregarse</param>
        /// <returns>Retorna una string con la respuesta del StoredProcedure</returns>
        EnvioPaquete InsertarPrecioEnvio(EnvioPaquete oEnvio);
        #endregion

        #region Actualizar PrecioEnvio
        /// <summary>
        /// Metodo que actualiza un valor en la base de datos con el parametro recibido
        /// </summary>
        /// <param name="oEnvio">Parametro que actualizará en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        EnvioPaquete ActualizarPrecioEnvio(EnvioPaquete oEnvio);
        #endregion

        #region Eliminar PrecioEnvio
        /// <summary>
        /// Metodo que elimina un precio de la base de datos
        /// </summary>
        /// <param name="id">Identificación del precio a eliminar</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        string BorrarEnvio(string id);
        #endregion

        #region Obtener PreciosEnvio
        /// <summary>
        /// Método que obtiene los precios de envio de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con los precios</returns>
        List<EnvioPaquete> ListaPrecios();
        #endregion

        #region Obtener Mensajero por ID
        /// <summary>
        /// Método que busca precios por ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Retorna el Envio que se encuentre</returns>
        EnvioPaquete MostrarXID(string id);
        #endregion
    }
}
