using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de la clase DALFactura
    /// </summary>
    interface IDALFactura
    {
        #region Obtener siguiente numero de factura
        /// <summary>
        /// Método que devuelve el siguiente número de factura 
        /// </summary>
        /// <returns>Retorna el siguiente número de una secuancia</returns>
        int GetNextNumeroFactura();
        #endregion

        #region Obtener numero actual de factura
        /// <summary>
        /// Método que devuelve el número actual de la factura
        /// </summary>
        /// <returns>Retorna el número actual de una secuencia</returns>
        int GetCurrentNumeroFactura();
        #endregion

        #region Obtener Factura por ID
        /// <summary>
        /// Método que obtiene la factura por número de factura
        /// </summary>
        /// <param name="numFact">Número de factura</param>
        /// <returns>Retorna la factura que coincida con el número</returns>
        EncabezadoFactura ObtenerFactura(string numFact);
        #endregion

        #region Guardar Factura
        /// <summary>
        /// Método que guarda una factura 
        /// </summary>
        /// <param name="pFactura">Factura que se guardará</param>
        /// <returns>Retorna el Encabezado de factura que se guardó</returns>
        EncabezadoFactura GuardarFactura(EncabezadoFactura pFactura);
        #endregion

        #region Obtener factura por IDCliente
        /// <summary>
        /// Metodo que retorna una de las facturas que el cliente tiene
        /// </summary>
        /// <param name="IdCliente">Cliente al que se le buscan</param>
        /// <returns>Retorna una factura que el tenga</returns>
        EncabezadoFactura ObtenerFacturaByIDCliente(string IdCliente);
        #endregion

        #region Obtener factura por IDMensajero
        /// <summary>
        /// Metodo que retorna una de las facturas que el mensajero tiene
        /// </summary>
        /// <param name="IdMensajero">ID del mensajero</param>
        /// <returns>Retorna una factura que el mensajero</returns>
        EncabezadoFactura ObtenerFacturaByIDMensajero(string IdMensajero);
        #endregion
    }
}
