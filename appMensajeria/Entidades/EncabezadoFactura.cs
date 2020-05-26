using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UTN.Mensajeria.Winform.Entidades
{
    /// <summary>
    /// Clase de encabezado de factura
    /// </summary>
    class EncabezadoFactura
    {
        public string IDEncFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente oCliente { get; set; }
        public Mensajero oMensajero { get; set; }
        public string XML { get; set; }
        public Tarjeta oTarjeta { get; set; }

        public List<DetFactura> _ListDetFactura { get; } = new List<DetFactura>();

        /// <summary>
        /// Metodo que agrega detalles de factura a el encabezado
        /// </summary>
        /// <param name="oDetFactura">Detalle de factura a agregar</param>
        public void AgregrarDetalle(DetFactura oDetFactura)
        {
            if (oDetFactura != null)
            {
                _ListDetFactura.Add(oDetFactura);
            }
            else
            {
                throw new Exception("El detalle de factura está vacío");
            }
            
        }

        /// <summary>
        /// Método que calcula el subtotal del envío 
        /// </summary>
        /// <returns>Retorna un double con el subtotal</returns>
        public double SubTotal()
        {
            double suma = 0;
            suma = _ListDetFactura.Sum(p => p.PrecioKilometro * p.CantidadKilometros);
            return suma;
        }

        /// <summary>
        /// Método que cakcula el impuesto
        /// </summary>
        /// <returns>Retorna el Impuesto</returns>
        public double Impuesto()
        {
            double Impuesto = 0;
            Impuesto = _ListDetFactura.Sum(p => p.Impuesto);
            return Impuesto;
        }

        /// <summary>
        /// Método que genera el XML con los datos de la factura
        /// </summary>
        /// <returns>Retorna el xml</returns>
        public string GenerarXML()
        {
            XmlDocument documento = new XmlDocument();
            XmlDeclaration dec = documento.CreateXmlDeclaration("1.0", null, null);
            documento.AppendChild(dec);
            XmlElement raiz = documento.CreateElement("raiz");
            documento.AppendChild(raiz);

            XmlElement idfactura = documento.CreateElement("idfactura");
            idfactura.InnerText = IDEncFactura;
            raiz.AppendChild(idfactura);

            XmlElement compania = documento.CreateElement("compania");
            compania.InnerText = "EnviosCR";
            raiz.AppendChild(compania);

            XmlElement mensajero = documento.CreateElement("mensajero");
            mensajero.InnerText = oMensajero.IDMensajero;
            raiz.AppendChild(mensajero);

            XmlElement cliente = documento.CreateElement("cliente");
            cliente.InnerText = oCliente.Nombre;
            raiz.AppendChild(cliente);

            XmlElement tipoidentificacion = documento.CreateElement("tipoidentificacion");
            tipoidentificacion.InnerText = "01";
            raiz.AppendChild(tipoidentificacion);

            XmlElement clienteid = documento.CreateElement("clienteid");
            clienteid.InnerText = oCliente.IDCliente;
            raiz.AppendChild(clienteid);

            XmlElement detalle = documento.CreateElement("detalle");
            foreach (var item in _ListDetFactura)
            {
                XmlElement secuancial = documento.CreateElement("secuancial");
                secuancial.InnerText = item.Secuencial.ToString();
                detalle.AppendChild(secuancial);

                XmlElement ruta = documento.CreateElement("ruta");
                ruta.InnerText = item.DescripcionRuta;
                detalle.AppendChild(ruta);

                XmlElement kilometros = documento.CreateElement("kilometros");
                kilometros.InnerText = item.CantidadKilometros.ToString();
                detalle.AppendChild(kilometros);

                XmlElement precioxkilometro = documento.CreateElement("precioxkilometro");
                precioxkilometro.InnerText = item.PrecioKilometro.ToString();
                detalle.AppendChild(precioxkilometro);

                XmlElement cantidadpaquetes = documento.CreateElement("cantidadpaquetes");
                cantidadpaquetes.InnerText = item.CantidadPaquetes.ToString();
                detalle.AppendChild(cantidadpaquetes);

                XmlElement descripcionpaquete = documento.CreateElement("descripcionpaquete");
                descripcionpaquete.InnerText = item.DescripcionPaquete;
                detalle.AppendChild(descripcionpaquete);
            }
            raiz.AppendChild(detalle);

            XmlElement impuesto = documento.CreateElement("impuesto");
            impuesto.InnerText = this.Impuesto().ToString();
            detalle.AppendChild(impuesto);

            XmlElement subtotal = documento.CreateElement("subtotal");
            subtotal.InnerText = this.SubTotal().ToString();
            detalle.AppendChild(subtotal);

            XmlElement total = documento.CreateElement("total");
            total.InnerText = (((this.Impuesto() * this.SubTotal()) / 100)+this.SubTotal()).ToString();
            detalle.AppendChild(total);

            documento.AppendChild(raiz);
            return documento.InnerXml;
        }
    }
}
