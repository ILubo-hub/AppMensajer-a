using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Factory
{
    /// <summary>
    /// Clase constructura del Mensajero
    /// </summary>
    class FactoryMensajero
    {
        /// <summary>
        /// Metodo que crea al mensajero con los parametros recibidos
        /// </summary>
        /// <param name="IDMensajero">Numero de Cedula del mensajero</param>
        /// <param name="Nombre">Nombbre del mensajero</param>
        /// <param name="Apellidos">Apellidos del mensajero</param>
        /// <param name="sexo">Sexo del mensajero</param>
        /// <param name="foto">Foto del mensajero</param>
        /// <param name="correo">Correo del mensajero</param>
        /// <param name="activo">Activo del mensajero</param>
        /// <param name="telefono">Telefono del mensajero</param>
        /// <returns>El objeto Mensajero construido y validado</returns>
        public static Mensajero ConstruirMensajero(string IDMensajero, string Nombre, string Apellidos, string sexo, byte[] foto, string correo, bool activo, string telefono)
        {
            Mensajero oMensajero = new Mensajero();
            oMensajero.IDMensajero = IDMensajero;
            oMensajero.Nombre = Nombre;
            oMensajero.Apellidos = Apellidos;
            oMensajero.Sexo = sexo;
            oMensajero.Foto = foto;
            oMensajero.Correo = correo;
            oMensajero.Activo = activo;
            oMensajero.Telefono = telefono;

            return oMensajero;
        }
    }
}
