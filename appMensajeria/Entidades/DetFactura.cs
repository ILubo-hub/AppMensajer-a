using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Mensajeria.Winform.Entidades
{
    /// <summary>
    /// Clase que define las propiedades de Detalle de factura
    /// </summary>
    class DetFactura
    {
        public string NoFactura { get; set; }
        public int Secuencial { get; set; }
        public double Total { get; set; }
        public int CantidadKilometros { get; set; }
        public string DescripcionRuta { get; set; }
        public double Impuesto { get; set; }
        public string DescripcionPaquete { get; set; }
        public double PrecioKilometro { get; set; }
        public int CantidadPaquetes { get; set; }
        public EnvioPaquete TipoEnvio { get; set; }




    }
}

