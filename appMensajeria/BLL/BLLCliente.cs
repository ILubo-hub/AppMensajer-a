using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.DAL;
using UTN.Mensajeria.Winform.Entidades;
using UTN.Mensajeria.Winform.Interfaces;

namespace UTN.Mensajeria.Winform.BLL
{
    /// <summary>
    /// Clase de enlace de datos y grafica de cliente
    /// </summary>
    public class BLLCliente : IBLLCliente
    {
        #region Mostrar Clientes
        /// <summary>
        /// Metodo que implementa el metodo MostarCliente de la clase DAL
        /// </summary>
        /// <returns>Retorna un datatable con los clientes a mostrar</returns>
        public List<Cliente> MostrarClientes()
        {
            IDALCliente _IDALCliente = new DALCliente();
            return _IDALCliente.MostrarClientes();
        }
        #endregion

        #region Eliminar Clientes
        /// <summary>
        /// Metodo que implementa el metodo EliminarCliente de la clase DAL
        /// </summary>
        /// <param name="IdCliente">Número de identificación del mensajero que será eliminado</param>
        /// <returns>Retorna una string con el resultado del storedProcedure</returns>
        public string EliminarCliente(string IdCliente)
        {
            IDALCliente _IDALCliente = new DALCliente();
            if (string.IsNullOrEmpty(IdCliente))
            {
                throw new Exception();
            }
            else
            {
                return _IDALCliente.BorrarCliente(IdCliente);
            }
        }
        #endregion

        #region Insertar Clientes
        /// <summary>
        /// etodo que implementa el metodo InsertarCliente de la clase DAL
        /// </summary>
        /// <param name="oCliente">Cliente que será insertado en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public Cliente InsertarCliente(Cliente oCliente)
        {
            IDALCliente _IDALCliente = new DALCliente();
            if (oCliente == null)
            {
                throw new Exception("El cliente es nulo");
            }
            else
            {
                if (BuscarClienteID(oCliente.IDCliente) != null)
                {
                    return _IDALCliente.ModificarCliente(oCliente);
                }
                else
                {
                    return _IDALCliente.InsertarCliente(oCliente);
                }
            }
        }
        #endregion

        #region Modificar Clientes
        /// <summary>
        /// Metodo que implementa el mentodo ModificarCliente de la clase DAL
        /// </summary>
        /// <param name="oCliente">Cliente que modificará en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public Cliente ModificarCliente(Cliente oCliente)
        {
            IDALCliente _IDALCliente = new DALCliente();
            if (oCliente == null)
            {
                throw new Exception();
            }
            else
            {
                return _IDALCliente.ModificarCliente(oCliente);
            }
        }
        #endregion

        #region Buscar Cliente por ID
        /// <summary>
        /// Método que implementa el mismo método en la capa DAL
        /// </summary>
        /// <param name="IDCliente">ID del cliente que va a ser buscado</param>
        /// <returns>Retorna el cliente encontrado</returns>
        public Cliente BuscarClienteID(string IDCliente)
        {
            IDALCliente _IDALCliente = new DALCliente();
            if (string.IsNullOrEmpty(IDCliente))
            {
                throw new Exception("El id del cliente es nulo");
            }
            else
            {
                return _IDALCliente.BuscarClienteID(IDCliente);
            }
        }
        #endregion

        #region Buscar Cliente por filtro
        /// <summary>
        /// Método que implementa el mismo método en la capa DAL
        /// </summary>
        /// <param name="descripcion">Filtro por el que será buscado</param>
        /// <returns>Retorna una lista con los clientes encontrados</returns>
        public List<Cliente> MostrarClientesByFilter(string descripcion)
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.MostrarClientesByFilter(descripcion);
        }
        #endregion
    }
}
