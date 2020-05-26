using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTN.Mensajeria.Winform.BLL;
using UTN.Mensajeria.Winform.Interfaces;
using UTN.Mensajeria.Winform.Entidades;
using System.Collections.Generic;

namespace UTMensajeria
{
    /// <summary>
    /// Clase Test de los mantenimientos
    /// </summary>
    [TestClass]
    public class utMantenimientos
    {
        #region TestCliente
        /// <summary>
        /// Test del metodo InsertarCliente
        /// </summary>
        [TestMethod]
        public void InsertarCliente()
        {
            Cliente oCliente = new Cliente();
            Provincia pProvincia = new Provincia();
            pProvincia.CodigoProvincia = 1;
            pProvincia.IDProvincia = "San José";
            oCliente.IDCliente = "2-332-444";
            oCliente.Nombre = "ClientTest";
            oCliente.Apellidos = "Test Tester";
            oCliente.CorreoElectronico = "@test";
            oCliente.Telefono = "65651";
            oCliente.Provincia = pProvincia.IDProvincia;
            oCliente.Direccion = "Test";
            oCliente.Activo = true;
            Cliente pCliente = new Cliente();

            IBLLCliente _BLLCliente = new BLLCliente();
            pCliente = _BLLCliente.InsertarCliente(oCliente);
            System.Diagnostics.Debug.Write(oCliente.IDCliente);
        }

        /// <summary>
        /// Test del metodo buscar cliente por ID
        /// </summary>
        [TestMethod]
        public void BuscarClienteID()
        {
            string idcliente = "2-0794-0151";
            Cliente oCliente = new Cliente();
            IBLLCliente _BLLCliente = new BLLCliente();
            oCliente = _BLLCliente.BuscarClienteID(idcliente);
            System.Diagnostics.Debug.Write(oCliente.IDCliente);
        }

        /// <summary>
        /// Test del metodo Modificar cliente
        /// </summary>
        [TestMethod]
        public void ModificarCliente()
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            Cliente oCliente = new Cliente();
            oCliente.IDCliente = "2-332-444";
            oCliente.Nombre = "ClientTestMod";
            oCliente.Apellidos = "Test Tester";
            oCliente.CorreoElectronico = "@test";
            oCliente.Telefono = "65651";
            oCliente.Provincia = "Test";
            oCliente.Direccion = "Test";
            oCliente.Activo = false;

            Cliente pCliente = new Cliente();
            pCliente = _BLLCliente.ModificarCliente(oCliente);
            System.Diagnostics.Debug.Write(oCliente.IDCliente);
        }

        /// <summary>
        /// Test del metodo obtener clientes
        /// </summary>
        [TestMethod]
        public void GetAllClientes()
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            List<Cliente> _ListCliente = new List<Cliente>();
            _ListCliente = _BLLCliente.MostrarClientes();
            System.Diagnostics.Debug.Write(_ListCliente[0].IDCliente);
        }

        /// <summary>
        /// Test del metodo eliminar cliente
        /// </summary>
        [TestMethod]
        public void EliminarCliente()
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            string idCliente = "2-332-444";

            string pCliente = "";
            pCliente = _BLLCliente.EliminarCliente(idCliente);
            System.Diagnostics.Debug.Write(pCliente);
        }
        #endregion

        #region TestMensajero
        /// <summary>
        /// Test del metodo insertar mensajero
        /// </summary>
        [TestMethod]
        public void InsertarMensajero()
        {
            byte[] foto = new byte[8];
            foto[0] = 0;
            foto[1] = 1;
            foto[2] = 1;
            foto[3] = 0;
            foto[4] = 1;
            foto[5] = 1;
            foto[6] = 1;
            foto[7] = 1;
            Mensajero oMensajero = new Mensajero();
            oMensajero.IDMensajero = "2-333-444";
            oMensajero.Nombre = "MensajeroTest";
            oMensajero.Apellidos = "Test Tester";
            oMensajero.Telefono = "65651";
            oMensajero.Activo = true;
            oMensajero.Correo = "@test";
            oMensajero.Foto = foto;
            oMensajero.Sexo = "Masculino";

            Mensajero pMensajero = new Mensajero();
            IBLLMensajero _BLLMensajero = new BLLMensajero();

            pMensajero = _BLLMensajero.InsertarMensajero(oMensajero);
            System.Diagnostics.Debug.Write(pMensajero.IDMensajero);
        }

        /// <summary>
        /// Test del metodo buscar mensajero por ID
        /// </summary>
        [TestMethod]
        public void BuscarMensajeroID()
        {
            string IdMensajero = "";
            IdMensajero = "2-333-444";

            Mensajero pMensajero = new Mensajero();
            IBLLMensajero _BLLMensajero = new BLLMensajero();

            pMensajero = _BLLMensajero.BuscarMensajeroID(IdMensajero);
            System.Diagnostics.Debug.Write(pMensajero.IDMensajero);
        }

        /// <summary>
        /// Test del metodo modificar cliente
        /// </summary>
        [TestMethod]
        public void ModificarMensajero()
        {
            byte[] foto = new byte[8];
            foto[0] = 0;
            foto[1] = 1;
            foto[2] = 1;
            foto[3] = 0;
            foto[4] = 1;
            foto[5] = 1;
            foto[6] = 1;
            foto[7] = 1;
            Mensajero oMensajero = new Mensajero();
            oMensajero.IDMensajero = "2-333-444";
            oMensajero.Nombre = "MensajeroTestMod";
            oMensajero.Apellidos = "Test Tester";
            oMensajero.Telefono = "65651";
            oMensajero.Activo = false;
            oMensajero.Correo = "@test";
            oMensajero.Foto = foto;
            oMensajero.Sexo = "Masculino";

            Mensajero pMensajero = new Mensajero();
            IBLLMensajero _BLLMensajero = new BLLMensajero();

            pMensajero = _BLLMensajero.ModificarMensajero(oMensajero);
            System.Diagnostics.Debug.Write(pMensajero.IDMensajero);
        }

        /// <summary>
        /// Test del metodo Obtener mensajeros
        /// </summary>
        [TestMethod]
        public void GetAllMensajeros()
        {
            IBLLMensajero _BLLMensajero = new BLLMensajero();
            List<Mensajero> _ListMensajeros = new List<Mensajero>();
            _ListMensajeros = _BLLMensajero.MostrarMensajeros();
            System.Diagnostics.Debug.Write(_ListMensajeros[0].IDMensajero);
        }

        /// <summary>
        /// Test del metodo eliminar cliente
        /// </summary>
        [TestMethod]
        public void EliminarMensajero()
        {
            string IdMensajero = "2-333-444";
            IBLLMensajero _BLLMensajero = new BLLMensajero();
            string pMensajero = "";
            pMensajero = _BLLMensajero.EliminarMensajero(IdMensajero);
            System.Diagnostics.Debug.Write(pMensajero);
        }
        #endregion

        #region TestPrecioEnvio

        /// <summary>
        /// Test del metodo insertar precio envio
        /// </summary>
        [TestMethod]
        public void InsertarPrecioEnvio()
        {
            IBLLPrecioEnvio _BLLPrecioEnvio = new BLLPrecioEnvio();
            EnvioPaquete oEnvio = new EnvioPaquete();
            EnvioPaquete pEnvio = new EnvioPaquete();
            oEnvio.KilometroFinal = 5641;
            oEnvio.KilometroInicial = 9874;
            oEnvio.PrecioRango = 16515616;
            oEnvio.TipoEnvio = "T";

            pEnvio = _BLLPrecioEnvio.InsertarPrecioEnvio(oEnvio);
            System.Diagnostics.Debug.Write(pEnvio.TipoEnvio);
        }

        /// <summary>
        /// Test de buscar precio por ID
        /// </summary>
        [TestMethod]
        public void BuscarPrecioEnvioID()
        {
            IBLLPrecioEnvio _BLLPrecioEnvio = new BLLPrecioEnvio();
            string IDEnvio = "A";
            EnvioPaquete pEnvio = new EnvioPaquete();
            pEnvio = _BLLPrecioEnvio.MostrarXID(IDEnvio);
            System.Diagnostics.Debug.Write(pEnvio.TipoEnvio);
        }

        /// <summary>
        /// Test de modificar precio envio
        /// </summary>
        [TestMethod]
        public void ModificarPrecioEnvio()
        {
            IBLLPrecioEnvio _BLLPrecioEnvio = new BLLPrecioEnvio();
            EnvioPaquete oEnvio = new EnvioPaquete();
            EnvioPaquete pEnvio = new EnvioPaquete();
            oEnvio.KilometroFinal = 6598;
            oEnvio.KilometroInicial = 8798;
            oEnvio.PrecioRango = 23235612;
            oEnvio.TipoEnvio = "T";

            pEnvio = _BLLPrecioEnvio.ActualizarPrecioEnvio(oEnvio);
            System.Diagnostics.Debug.Write(pEnvio.TipoEnvio);
        }

        /// <summary>
        /// Test de obtener los precios
        /// </summary>
        [TestMethod]
        public void GetAllPrecio()
        {
            IBLLPrecioEnvio _BLLPrecioEnvio = new BLLPrecioEnvio();
            List<EnvioPaquete> _ListPrecios = new List<EnvioPaquete>();

            _ListPrecios = _BLLPrecioEnvio.ListaPrecios();
            System.Diagnostics.Debug.Write(_ListPrecios[0].TipoEnvio);
        }

        /// <summary>
        /// Test de eliminar precio
        /// </summary>
        [TestMethod]
        public void EliminarPrecio()
        {
            IBLLPrecioEnvio _BLLPrecioEnvio = new BLLPrecioEnvio();
            string IDEnvio = "T";
            string pEnvio = "";
            pEnvio = _BLLPrecioEnvio.BorrarEnvio(IDEnvio);
            System.Diagnostics.Debug.Write(pEnvio);
        }
        #endregion

    }
}
