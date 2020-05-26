using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Mensajeria.Winform.Entidades
{
    /// <summary>
    /// Clase para definir las propiedades de la ubicación
    /// </summary>
    class Direccion
    {
        public double Latitud { set; get; }
        public double Longitud { set; get; }
        public string Ubicacion { set; get; }
        public override string ToString()
        {
            return string.Format("Latitud {0} y Longitud {1} ", Latitud, Longitud);
        }
    }
}
