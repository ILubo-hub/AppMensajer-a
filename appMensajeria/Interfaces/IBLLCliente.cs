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
    /// Interface del BLLCliente
    /// </summary>
    public interface IBLLCliente
    {
        #region Mostrar Clientes
        /// <summary>
        /// Método que muestra los clientes
        /// </summary>
        /// <returns>Retorna una lista con los clientes</returns>
        List<Cliente> MostrarClientes();
        #endregion

        #region Eliminar Clientes
        /// <summary>
        /// Método que elimina los clientes
        /// </summary>
        /// <param name="IDCliente">ID del cliente que se va a eliminar</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        string EliminarCliente(string IDCliente);
        #endregion

        #region Insertar Cliente
        /// <summary>
        /// Método que Inserta clientes
        /// </summary>
        /// <param name="oCliente">Cliente que se va a insertar</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        Cliente InsertarCliente(Cliente oCliente);
        #endregion

        #region Modificar Cliente
        /// <summary>
        /// Metodo que modifica clientes
        /// </summary>
        /// <param name="oCliente">Cliente que se modificará</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        Cliente ModificarCliente(Cliente oCliente);
        #endregion

        #region Buscar Cliente ID
        /// <summary>
        /// Método que busca clientes por ID
        /// </summary>
        /// <param name="IDCliente">ID</param>
        /// <returns>Retorna un cliente que tenaga el ID</returns>
        Cliente BuscarClienteID(string IDCliente);
        #endregion

        #region Buscar Mensajeros por filtro
        /// <summary>
        /// Método que busca clientes por filtro
        /// </summary>
        /// <param name="descripcion">filtro</param>
        /// <returns>Retorna una lista de clientes que cumplen con el filtro</returns>
        List<Cliente> MostrarClientesByFilter(string descripcion);
        #endregion
    }
}
