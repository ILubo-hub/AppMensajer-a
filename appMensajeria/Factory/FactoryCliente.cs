using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.Entidades;

namespace UTN.Mensajeria.Winform.Factory
{
    /// <summary>
    /// Clase Factory del Cliente
    /// </summary>
    class FactoryCliente
    {
        /// <summary>
        /// Metodo que construye un cliente con los parametros recibidos
        /// </summary>
        /// <param name="idCliente">Número de cédula del cliente</param>
        /// <param name="Nombre">Nombre del cliente</param>
        /// <param name="Apellidos">Apellidos del cliente</param>
        /// <param name="Telefono">Telefono del cliente</param>
        /// <param name="correoElectronico">Correo electrónico del cliente</param>
        /// <param name="Provincia">Provincia del cliente</param>
        /// <param name="Direccion">Direccion del cliente</param>
        /// <param name="Activo">Grado de actividad del cliente en la base de datos</param>
        /// <returns>Retorna un objeto cliente</returns>
        public static Cliente ConstruirCliente(string idCliente, string Nombre, string Apellidos, string Telefono, string correoElectronico, string Provincia, string Direccion, bool Activo)
        {
            Cliente cliente = new Cliente();
            cliente.IDCliente = idCliente;
            cliente.Nombre = Nombre;
            cliente.Apellidos = Apellidos;
            cliente.Telefono = Telefono;
            cliente.CorreoElectronico = correoElectronico;
            cliente.Provincia = Provincia;
            cliente.Direccion = Direccion;
            cliente.Activo = Activo;

            return cliente;
        }
    }
}
