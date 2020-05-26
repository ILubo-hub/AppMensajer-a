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
    /// Interface de la clase BLLPrecio Envio
    /// </summary>
   public interface IBLLPrecioEnvio
    {
        #region Insertar PrecioEnvio
        /// <summary>
        /// Método que inserta el precio en la base de datos
        /// </summary>
        /// <param name="oEnvio">Objeto que se va a agregar a la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedprocedure</returns>
        EnvioPaquete InsertarPrecioEnvio(EnvioPaquete oEnvio);
        #endregion

        #region Actualizar PrecioEnvio
        /// <summary>
        /// Método que actualiza el precio en la base de datos
        /// </summary>
        /// <param name="oEnvio">Objeto que modificará en la base de datos</param>
        /// <returns>Rertorna una string con la respuesta del stored procedure</returns>
        EnvioPaquete ActualizarPrecioEnvio(EnvioPaquete oEnvio);
        #endregion

        #region Eliminar PrecioEnvio
        /// <summary>
        /// Método que elimina el envio de la base de datos
        /// </summary>
        /// <param name="id">Id del envio que se eliminará</param>
        /// <returns>Retorna una string con la respuesta del stored procedure</returns>
        string BorrarEnvio(string id);
        #endregion

        #region Obtener PreciosEnvio
        /// <summary>
        /// Método que muestra todos los precios de envio que hay en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con los precios que hay en la base de datos</returns>
        List<EnvioPaquete> ListaPrecios();
        #endregion

        #region Obtener PrecioEnvio por ID
        /// <summary>
        /// Método que muestra el paquete por ID 
        /// </summary>
        /// <param name="id">Id que buscará en la base de datos</param>
        /// <returns>Retorna el envio que se encuentre</returns>
        EnvioPaquete MostrarXID(string id);
        #endregion
    }
}
