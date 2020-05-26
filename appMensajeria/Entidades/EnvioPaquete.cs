using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Mensajeria.Winform.Entidades
{
    /// <summary>
    /// Clase que define las propiedades de EnvioPaquete
    /// </summary>
    public class EnvioPaquete
    {
        public string TipoEnvio { get; set; }
        public double PrecioRango { get; set; }
        public int KilometroInicial { get; set; }
        public int KilometroFinal { get; set; }
    }
}
