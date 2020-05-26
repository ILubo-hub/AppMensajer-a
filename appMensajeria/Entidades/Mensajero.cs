using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Mensajeria.Winform.Entidades
{
    /// <summary>
    /// Clase que define las propiedades del Mensajero
    /// </summary>
    public class Mensajero
    {
        public string IDMensajero { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public byte[] Foto { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }
        public string Telefono { get; set; }
    }
}
