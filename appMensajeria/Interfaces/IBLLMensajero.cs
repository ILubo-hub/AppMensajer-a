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
    /// Interface de BLLMensajero
    /// </summary>
   public interface IBLLMensajero
    {
        #region Obtener Mensajeros
        /// <summary>
        /// Método que muestra los mensajeros de la base de datos
        /// </summary>
        /// <returns>Retorna una lista con los mensajeros</returns>
        List<Mensajero> MostrarMensajeros();
        #endregion

        #region Insertar Mensajeros
        /// <summary>
        /// Método que inserta el mensajero en la base de datos
        /// </summary>
        /// <param name="oMensajero">Mensajero a insertar</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        Mensajero InsertarMensajero(Mensajero oMensajero);
        #endregion

        #region Modificar Mensajeros
        /// <summary>
        /// Método que modifica el mensajero en la base de datos
        /// </summary>
        /// <param name="oMensajero">Mensajero que modificará en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        Mensajero ModificarMensajero(Mensajero oMensajero);
        #endregion

        #region Eliminar Mensajero
        /// <summary>
        /// Método que elimina el mensajero de la base de datos
        /// </summary>
        /// <param name="IDMensajero">Número de identificación del mensajero que se eliminará</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        string EliminarMensajero(string IDMensajero);
        #endregion

        #region Buscar mensajero por filtro
        /// <summary>
        /// Metodo que busca por filtro en la base de datos
        /// </summary>
        /// <param name="flitro">Filtro que buscará en la base de datos</param>
        /// <returns>Retorna una lista de mensajeros que cumplan con el filtro</returns>
        List<Mensajero> BuscarMensajeroByFilter(string flitro);
        #endregion

        #region Buscar mensajero por ID
        /// <summary>
        /// Método que busca el mensajero por id
        /// </summary>
        /// <param name="IDMensajero">ID que buscara en la base de datos</param>
        /// <returns>Retorna el mensajero que se encuentre</returns>
        Mensajero BuscarMensajeroID(string IDMensajero);
        #endregion
    }
}
