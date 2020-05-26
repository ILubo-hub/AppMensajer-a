using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Mensajeria.Winform.Entidades
{
    /// <summary>
    /// Clase que define las propiedades del Usuario
    /// </summary>
    class Usuario
    {
        public string Login { set; get; }
        public string Password { set; get; }
        public string TipoUsuario { get; set; }
    }
}
