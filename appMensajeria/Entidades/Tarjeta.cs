using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Mensajeria.Winform.Entidades
{
    /// <summary>
    /// Clase que define las propiedades de la tarjeta
    /// </summary>
    class Tarjeta
    {
        public string IDTarjeta { get; set; }
        public string Descripcion { get; set; }

        /// <summary>
        /// Metodo toString de la tarjeta
        /// </summary>
        /// <returns>Retorna el ID mas la descripcion de la tarjeta</returns>
        public override string ToString() => $"{IDTarjeta} {Descripcion}";
    }
}
