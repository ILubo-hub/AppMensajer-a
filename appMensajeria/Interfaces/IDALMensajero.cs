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
    /// Interface de la clase DALMensajero
    /// </summary>
    interface IDALMensajero
    {
        #region Obtener Mensajeros
        /// <summary>
        /// Metodo que muestra los mensajeros que hay en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con la información</returns>
        List<Mensajero> MostrarMensajeros();
        #endregion

        #region Insertar Mensajero
        /// <summary>
        /// Metodo que inserta un mensajero a la base de datos
        /// </summary>
        /// <param name="oMensajero">Mensajero a insertar en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        Mensajero InsertarMensajero(Mensajero oMensajero);
        #endregion

        #region Modificar Mensajero
        /// <summary>
        /// Metodo que modifica a un cliente en la base de datos
        /// </summary>
        /// <param name="oMensajero">Mensajero que modificará en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        Mensajero ModificarMensajero(Mensajero oMensajero);
        #endregion

        #region Eliminar mensajero
        /// <summary>
        /// Metodo que elimina un Mensajero de la base de datos
        /// </summary>
        /// <param name="IDMensajero">Número de identificación del mensajero que será eliminado</param>
        /// <returns>Retorna una string con el resultado del storeProcedure</returns>
        string BorrarMensajero(string IDMensajero);
        #endregion

        #region Buscar mensajero por filtro
        /// <summary>
        /// Método que busca mensajeros por filtro
        /// </summary>
        /// <param name="flitro">filtro</param>
        /// <returns>Retorna una lista de mensajeros que cumplan con el filtro</returns>
        List<Mensajero> BuscarMensajeroByFilter(string flitro);
        #endregion

        #region Buscar mensajero por ID
        /// <summary>
        /// Método que busca mensajeros por ID en la base de datos
        /// </summary>
        /// <param name="IDMensajero">ID del mensajero</param>
        /// <returns>Retorna el mensajero que se encuentre en la base de datos</returns>
        Mensajero BuscarMensajeroID(string IDMensajero);
        #endregion
    }
}
