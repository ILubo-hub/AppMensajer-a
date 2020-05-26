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
    /// Interface de la clase DALCLiente
    /// </summary>
    interface IDALCliente
    {
        #region Obtener Clientes
        /// <summary>
        /// Metodo que obtiene los clientes que hay en la base de datos
        /// </summary>
        /// <returns>retorna un dataTable con la información</returns>
        List<Cliente> MostrarClientes();
        #endregion

        #region Eliminar Cliente
        /// <summary>
        /// Metodo que elimina un cliente de la base de datos
        /// </summary>
        /// <param name="IdCliente">Numero de cedula del cliente</param>
        /// <returns>retorna un string con el resultado del storedProcedure</returns>
        string BorrarCliente(string IdCliente);
        #endregion

        #region Insertar Cliente
        /// <summary>
        /// Metodo que Inserta un cliente a la base de datos
        /// </summary>
        /// <param name="oCliente">Cliente a insertar</param>
        /// <returns>Retorna una string con el resultado del storedProcedure</returns>
        Cliente InsertarCliente(Cliente oCliente);
        #endregion

        #region Modificar Cliente
        /// <summary>
        /// Metodo que modifica un cliente en la base de datos
        /// </summary>
        /// <param name="oCliente">Cliente que modificará la base de datos</param>
        /// <returns>retorna una string con la respuesta del storedProcedure</returns>
        Cliente ModificarCliente(Cliente oCliente);
        #endregion

        #region Buscar cliente por ID
        /// <summary>
        /// Metodo que busca el cliente por ID
        /// </summary>
        /// <param name="IDCliente">ID del cliente</param>
        /// <returns>Retorna el cliente encontrado</returns>
        Cliente BuscarClienteID(string IDCliente);
        #endregion

        #region Buscar cliente por ID
        /// <summary>
        /// Método que muestra clientes por un filtro
        /// </summary>
        /// <param name="descripcion">Filtro por el que se buscaran los clientes</param>
        /// <returns>Retorna una lista de los clientes que cumplan con el filtro</returns>
        List<Cliente> MostrarClientesByFilter(string descripcion);
        #endregion
    }
}
