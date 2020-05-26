using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Interfaces
{
    /// <summary>
    /// Interface de BLLFactura
    /// </summary>
    interface IBLLFactura
    {
        #region Obtener numero siguiente de factura
        /// <summary>
        /// Método que obtiene el número que sigue del secuence en la base de datos
        /// </summary>
        /// <returns>Retorna el número siguiente de la secuancia</returns>
        int GetNextNumeroFactura();
        #endregion

        #region Obtener numero actual de factura
        /// <summary>
        /// Método que obtiene el número actual del secuence en la base de datos
        /// </summary>
        /// <returns>Retorna el número actual de la secuancia</returns>
        int GetCurrentNumeroFactura();
        #endregion

        #region Obtener factura por ID
        /// <summary>
        /// Metodo que obtiene la factura por ID
        /// </summary>
        /// <param name="numFact">ID de la factura que se va a buscar</param>
        /// <returns>Retorna la factura que se encuentra</returns>
        EncabezadoFactura ObtenerFactura(string numFact);
        #endregion

        #region Guardar Factura
        /// <summary>
        /// Metodo que guarda la factura en la base de datos
        /// </summary>
        /// <param name="pFactura">Factura a guardarse</param>
        /// <returns>La factura que se guardo</returns>
        EncabezadoFactura GuardarFactura(EncabezadoFactura pFactura);
        #endregion

        #region Obtener factura por IDCliente
        /// <summary>
        /// Metodo que retorna una de las facturas que el cliente tiene
        /// </summary>
        /// <param name="IdCliente">Cliente al que se le va a buscar</param>
        /// <returns>Retorna una factura de las que el cliente tenga</returns>
        EncabezadoFactura ObtenerFacturaByIDCliente(string IdCliente);
        #endregion

        #region Obtener factura por IDMensajero
        /// <summary>
        /// Metodo que retorna una de las facturas que el mensajero tiene
        /// </summary>
        /// <param name="IdMensajero">Mensajero al que se le va a buscar</param>
        /// <returns>Retorna una factura de las que el mensajero tenga</returns>
        EncabezadoFactura ObtenerFacturaByIDMensajero(string IdMensajero);
        #endregion
    }
}
