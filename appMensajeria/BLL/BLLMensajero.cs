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
    /// Clase de enlace de capa de datos y grafica del Mensajero
    /// </summary>
    public class BLLMensajero : IBLLMensajero
    {
        #region Mostrar Mensajeros
        /// <summary>
        /// Metodo que implementa el metodo de MostrarMensajeros con la clase DAL
        /// </summary>
        /// <returns>Retorna un dataTable con la información</returns>
        public List<Mensajero> MostrarMensajeros()
        {
            IDALMensajero _IDALMensajero = new DALMensajero();
            return _IDALMensajero.MostrarMensajeros();
        }
        #endregion

        #region Insertar Mensajeros
        /// <summary>
        /// Metodo que implementa el metodo insertarMensajero en la clase DAL
        /// </summary>
        /// <param name="oMensajero">Mensajero a insertar</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public Mensajero InsertarMensajero(Mensajero oMensajero)
        {
            IDALMensajero _IDALMensajero = new DALMensajero();
            if (oMensajero == null)
            {
                throw new Exception("El mensajero es nulo");
            }
            else
            {
                if (BuscarMensajeroID(oMensajero.IDMensajero) != null)
                {
                    return _IDALMensajero.ModificarMensajero(oMensajero);
                }
                else
                {
                    return _IDALMensajero.InsertarMensajero(oMensajero);
                }
            }
        }
        #endregion

        #region Modificar Mensajero
        /// <summary>
        /// Metodo que implementa el metodo ModificarMensajero en la clase DAL
        /// </summary>
        /// <param name="oMensajero">Mensajero que modificará en la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public Mensajero ModificarMensajero(Mensajero oMensajero)
        {
            IDALMensajero _IDALMensajero = new DALMensajero();
            if (oMensajero == null)
            {
                throw new Exception();
            }
            else
            {
                return _IDALMensajero.ModificarMensajero(oMensajero);
            }
        }
        #endregion

        #region Eliminar Mensajero
        /// <summary>
        /// Metodo que implementa el metodo EliminarMensajero en la clase DAL
        /// </summary>
        /// <param name="IDMensajero">Número de identificación del mensajero que se eliminará</param>
        /// <returns>Retorna una string con la respuesta del storedProcedure</returns>
        public string EliminarMensajero(string IDMensajero)
        {
            IDALMensajero _IDALMensajero = new DALMensajero();
            if (string.IsNullOrEmpty(IDMensajero))
            {
                throw new Exception();
            }
            else
            {
                return _IDALMensajero.BorrarMensajero(IDMensajero);
            }
        }
        #endregion

        #region Buscar Mensajero por ID
        /// <summary>
        /// Método que busca el mensajero por id
        /// </summary>
        /// <param name="IDMensajero">ID que buscara en la base de datos</param>
        /// <returns>Retorna el mensajero que se encuentre</returns>
        public Mensajero BuscarMensajeroID(string IDMensajero)
        {
            IDALMensajero _IDALMensajero = new DALMensajero();
            if (string.IsNullOrEmpty(IDMensajero))
            {
                throw new Exception("El parametro mensajero de la BLL está vacío");
            }
            else
            {
                return _IDALMensajero.BuscarMensajeroID(IDMensajero);
            }
        }
        #endregion

        #region Buscar Mensajero por filtro
        /// <summary>
        /// Metodo que busca por filtro en la base de datos
        /// </summary>
        /// <param name="flitro">Filtro que buscará en la base de datos</param>
        /// <returns>Retorna una lista de mensajeros que cumplan con el filtro</returns>
        public List<Mensajero> BuscarMensajeroByFilter(string flitro)
        {
            IDALMensajero _IDALMensajero = new DALMensajero();
            if (string.IsNullOrEmpty(flitro))
            {
                throw new Exception("El parametro mensajero de la BLL está vacío");
            }
            else
            {
                return _IDALMensajero.BuscarMensajeroByFilter(flitro);
            }
        }
        #endregion
    }
}
