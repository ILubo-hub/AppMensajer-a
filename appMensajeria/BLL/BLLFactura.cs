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
    /// Capa de enlace de datos de la factura
    /// </summary>
    class BLLFactura : IBLLFactura
    {
        #region Obtener Numero Actual de factura
        /// <summary>
        /// Método que obtiene el número actual del secuence en la base de datos
        /// </summary>
        /// <returns>Retorna el número actual de la secuancia</returns>
        public int GetCurrentNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetCurrentNumeroFactura();
        }
        #endregion

        #region Obtener siguiente número de factura
        /// <summary>
        /// Método que obtiene el número que sigue del secuence en la base de datos
        /// </summary>
        /// <returns>Retorna el número siguiente de la secuancia</returns>
        public int GetNextNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetNextNumeroFactura();
        }
        #endregion

        #region Guardar Factura
        /// <summary>
        /// Metodo que guarda la dactura en la base de datos
        /// </summary>
        /// <param name="pFactura">Factura que se va a guardar en la base de datos</param>
        /// <returns>Retorna la factura que se agregró</returns>
        public EncabezadoFactura GuardarFactura(EncabezadoFactura pFactura)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GuardarFactura(pFactura);
        }
        #endregion

        #region Obtener factura por ID
        /// <summary>
        /// Metodo que obtiene la factura por ID
        /// </summary>
        /// <param name="numFact">ID de la factura que se va a buscar</param>
        /// <returns>Retorna la factura que se encuentra</returns>
        public EncabezadoFactura ObtenerFactura(string numFact)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.ObtenerFactura(numFact);
        }
        #endregion

        #region Obtener factura por IDCliente
        /// <summary>
        /// Metodo que obtiene una factura que el cliente tenga
        /// </summary>
        /// <param name="IdCliente">ID del cliente</param>
        /// <returns>Retorna una factura de la base de datos</returns>
        public EncabezadoFactura ObtenerFacturaByIDCliente(string IdCliente)
        {
            IDALFactura _DALFactura = new DALFactura();
            if (string.IsNullOrEmpty(IdCliente))
            {
                throw new Exception("El id del cliente está vacío");
            }
            else
            {
                return _DALFactura.ObtenerFacturaByIDCliente(IdCliente);
            }
        }
        #endregion

        #region Obtener factura por IDMensajero
        /// <summary>
        /// Metodo que obtiene una factura que el mensajero tenga
        /// </summary>
        /// <param name="IdMensajero">ID del mensajero</param>
        /// <returns>Retorna una factura de la base de datos</returns>
        public EncabezadoFactura ObtenerFacturaByIDMensajero(string IdMensajero)
        {
            IDALFactura _DALFactura = new DALFactura();
            if (string.IsNullOrEmpty(IdMensajero))
            {
                throw new Exception("El id del mensajero está vacío");
            }
            else
            {
                return _DALFactura.ObtenerFacturaByIDMensajero(IdMensajero);
            }
        }
        #endregion
    }
}
