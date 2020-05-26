using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using UTN.Mensajeria.Winform.Entidades;
using UTN.Mensajeria.Winform.Factory;
using UTN.Mensajeria.Winform.Interfaces;
using UTN.Mensajeria.Winform.BLL;
using log4net;
using UTN.Mensajeria.Winform.UI.Filtros;
using System.IO;
using System.Drawing.Imaging;
using UTN.Mensajeria.Winform.UI.Reportes.Forms;
using System.Threading;
using System.Diagnostics;

namespace UTN.Mensajeria.Winform.UI.Procesos
{
    /// <summary>
    /// Clase logica del form de Procesos
    /// </summary>
    public partial class frmProcesos : Form
    {
        #region Parametros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        Cliente pCliente = null;
        Mensajero oMensajero = null;
        EncabezadoFactura _EncabezadoFactura = new EncabezadoFactura();
        List<string> _ListPaquetes = new List<string>();
        string pnumerofactura = "";
        #endregion

        #region Metodos sin función
        private void frmProcesos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void btnListoRuta_Click(object sender, EventArgs e)
        {

        }
        private void gbPaquete_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarEnvio_Click(object sender, EventArgs e)
        {

        }
        private void cpbBarraCarga_Click(object sender, EventArgs e)
        {

        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        #endregion

        #region Gmap Functions

        /// <summary>
        /// Metodo que inicializa los componentes del mapa
        /// </summary>
        public void ComponentesIniciales()
        {
            gMapMapa.Zoom = 2;
            gMapMapa.MaxZoom = 35;
            gMapMapa.MinZoom = 2;
            gMapMapa.MouseWheelZoomEnabled = true;
            gMapMapa.RoutesEnabled = true;


            // Esto para que funcione el boton izquierdo del Mouse para mover el mapa
            gMapMapa.DragButton = MouseButtons.Left;
            // Si esta detras de un Proxy
            // GMapProvider.WebProxy = new WebProxy("192.168.120.7", 3128);
            // Se coloca el tipo de mapa 
            gMapMapa.MapProvider = GMap.NET.MapProviders.BingHybridMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            // Colocar la posicion default
            gMapMapa.Position = new PointLatLng(9.9999579356370845, -84.204883575439453);
            // Zoom por defecto
            gMapMapa.Zoom = 13;
        }

        /// <summary>
        /// Metodo que agrega la ubicación que se eligió del mapa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gMapMapa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double latitud = 0;
            double longitud = 0;

            GMapMarker currentMarker;

            try
            {
                // Obtiene la longitud y latitud
                if (e.Button == MouseButtons.Left)
                {
                    latitud = gMapMapa.FromLocalToLatLng(e.X, e.Y).Lat;
                    longitud = gMapMapa.FromLocalToLatLng(e.X, e.Y).Lng;
                }


                currentMarker = new GMarkerGoogle(gMapMapa.Position, GMarkerGoogleType.arrow);
                currentMarker.Position = gMapMapa.FromLocalToLatLng(e.X, e.Y);

                Direccion oDireccion = new Direccion()
                {
                    Latitud = latitud,
                    Longitud = longitud
                    // Ubicacion = place[0].CountryName + " " + place[0].DistrictName + " " + place[0].Address,

                };
                // Agrega la direcci/n a la lista
                this.lstUbicaciones.Items.Add(oDireccion);

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje    :{0}\n", er.Message);
                msg.AppendFormat("Source     :{0}\n", er.Source);
                msg.AppendFormat("StackTrace :{0}\n", er.StackTrace);
                MessageBox.Show(msg.ToString(), "Atención");
            }
        }

        /// <summary>
        /// Método que calcula los kilometros del viaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularKilometros_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstUbicaciones.Items.Count >= 2)
                {

                    Direccion inicial = lstUbicaciones.Items[0] as Direccion;
                    Direccion final = lstUbicaciones.Items[1] as Direccion;
                    // re zoom
                    gMapMapa.Zoom = 13;

                    // marca ruta
                    PointLatLng start = new PointLatLng(inicial.Latitud, inicial.Longitud);
                    PointLatLng end = new PointLatLng(final.Latitud, final.Longitud);
                    // Obtener el provider generico  por default GMap.NET.MapProviders.BingHybridMapProvider
                    RoutingProvider rp = gMapMapa.MapProvider as RoutingProvider;

                    // Obtener la ruta
                    MapRoute oMapRoute = rp.GetRoute(start, end, false, false, 5);

                    if (oMapRoute == null)
                    {

                        MessageBox.Show("Error al obtener ruta, puede ser un error de conexión con internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Crear Marcadores de zona
                    GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(inicial.Latitud, inicial.Longitud), GMarkerGoogleType.green);
                    GMarkerGoogle marker2 = new GMarkerGoogle(new PointLatLng(final.Latitud, final.Longitud), GMarkerGoogleType.green);

                    GMapRoute oGMapRoute = new GMapRoute(oMapRoute.Points, "Mi ruta");
                    GMapOverlay routesOverlay = new GMapOverlay("rutas");
                    routesOverlay.Routes.Add(oGMapRoute);
                    // Limpiar antiguas rutas
                    gMapMapa.Overlays.Clear();
                    gMapMapa.Overlays.Add(routesOverlay);

                    //Agregar Marcadores
                    routesOverlay.Markers.Add(marker1);
                    routesOverlay.Markers.Add(marker2);
                    gMapMapa.Overlays.Add(routesOverlay);

                    // Actualizar posicion
                    gMapMapa.UpdateRouteLocalPosition(oGMapRoute);
                    this.txtKilometros.Text = Math.Round(oMapRoute.Distance, 2).ToString();
                    AsignarTipoEnvio();
                    _EncabezadoFactura.IDEncFactura = txtNoFactura.Text;
                    _EncabezadoFactura.Fecha = DateTime.Now;
                    _EncabezadoFactura.oCliente = pCliente;
                    _EncabezadoFactura.oMensajero = oMensajero;
                    _EncabezadoFactura.oTarjeta = cboTipoTarjeta.SelectedItem as Tarjeta;


                }
                else
                {
                    MessageBox.Show("Debe escoger las rutas dando doble click en dos puntos del mapa", "Atención");

                }

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje    :{0}\n", er.Message);
                msg.AppendFormat("Source     :{0}\n", er.Source);
                msg.AppendFormat("StackTrace :{0}\n", er.StackTrace);

                MessageBox.Show(msg.ToString(), "Atención");
            }
        }

        /// <summary>
        /// Método load del gmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gMapMapa_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Filtro Mensajeros
        /// <summary>
        /// Método que abre la ventana filtro para buscar mensajeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarMensajeros_Click(object sender, EventArgs e)
        {
            frmFiltroMensajero ofrmFiltroMensajero = new frmFiltroMensajero();
            IBLLCliente _BLLCliente = new BLLCliente();
            try
            {
                // Mostrar ventan de filtro
                ofrmFiltroMensajero.ShowDialog();
                if (ofrmFiltroMensajero.DialogResult == DialogResult.OK)
                {
                    oMensajero = ofrmFiltroMensajero._Mensajero;
                    txtIDMensajero.Text = oMensajero.IDMensajero;
                    txtNombreMensajero.Text = oMensajero.Nombre;
                }

                if (oMensajero == null)
                {
                    MessageBox.Show("No existe el Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                // Log error
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Datos Automatizados
        /// <summary>
        /// Método que llena los datos del form
        /// </summary>
        public void llenarCombos()
        {
            IBLLImpuesto _BLLImpuesto = new BLLImpuesto();
            IBLLTarjeta _BLLTarjeta = new BLLTarjeta();
            List<Impuesto> _ListImpuesto = new List<Impuesto>();
            List<Tarjeta> _ListTarjeta = new List<Tarjeta>();

            try
            {
                _ListImpuesto = _BLLImpuesto.ObtenerImpuesto();
                foreach (Impuesto item in _ListImpuesto)
                {
                    txtImpuesto.Text = item.Valor.ToString();
                }
                _ListTarjeta = _BLLTarjeta.GetAllTarjeta();
                foreach (Tarjeta item in _ListTarjeta)
                {
                    cboTipoTarjeta.Items.Add(item);
                }
                cboTipoTarjeta.SelectedIndex = 0;
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                // Log error
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que asigna el tipo de envio que es
        /// </summary>
        public void AsignarTipoEnvio()
        {
            IBLLPrecioEnvio _BLLPrecioEnvio = new BLLPrecioEnvio();
            List<EnvioPaquete> _ListEnvio = new List<EnvioPaquete>();
            _ListEnvio = _BLLPrecioEnvio.ListaPrecios();
            cboTipoEnvio.Items.Clear();
            double mayor = 0;

            double kilometros = Math.Round(Convert.ToDouble(txtKilometros.Text));
            foreach (EnvioPaquete item in _ListEnvio)
            {
                if (kilometros >= item.KilometroInicial && kilometros <= item.KilometroFinal)
                {
                    cboTipoEnvio.Items.Add(item.TipoEnvio);
                }
                else
                {
                    mayor = item.KilometroFinal;
                }
            }
            if (mayor == kilometros)
            {
                MessageBox.Show("Los kilometros del trayecto no esta entre los rangos permitidos en el programa");
                cboTipoEnvio.SelectedIndex = -1;
                lstUbicaciones.Items.Clear();
            }
            else
            {
                cboTipoEnvio.SelectedIndex = 0;
            }

        }
        #endregion

        #region Agregar Paquetes
        /// <summary>
        /// Método que abre la ventana filtro para agregar paquetes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPaquetes_Click(object sender, EventArgs e)
        {
            frmInsertarPaquetes ofrmAgregarPaquetes = new frmInsertarPaquetes();
            try
            {
                // Mostrar ventan de filtro
                ofrmAgregarPaquetes.ShowDialog();
                if (ofrmAgregarPaquetes.DialogResult == DialogResult.OK)
                {
                    _ListPaquetes = ofrmAgregarPaquetes._ListArticulos;
                    foreach (string item in _ListPaquetes)
                    {
                        lstPaquetes.Items.Add(item);
                    }
                    txtCantidadPaquetes.Text = _ListPaquetes.Count().ToString();

                }

                if (_ListPaquetes == null)
                {
                    MessageBox.Show("Debe agregar al menos un paquete", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                // Log error
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Facturacion
        /// <summary>
        /// Método que guarda el detalle de factura en el encabezado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IBLLImpuesto _BLLImpuesto = new BLLImpuesto();
            IBLLPrecioEnvio _BLLPrecioEnvio = new BLLPrecioEnvio();
            IBLLFactura _BLLFactura = new BLLFactura();
            DetFactura oDetFactura = new DetFactura();
            string descripcionPaquete = "";
            string descripcionruta = "";
            try
            {
                erpErrores.Clear();
                if (_EncabezadoFactura == null)
                {
                    MessageBox.Show("Debe agregar los datos del encabezado de la factura para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtIDMensajero.Text))
                    {
                        erpErrores.SetError(txtIDMensajero, "Debe ingresar la identificación del mensajero");
                        return;
                    }
                    if (string.IsNullOrEmpty(txtNombreMensajero.Text))
                    {
                        erpErrores.SetError(txtNombreMensajero, "Debe ingresar el nombre del mensajero");
                        return;
                    }
                    if (string.IsNullOrEmpty(mskNoTarjeta.Text))
                    {
                        erpErrores.SetError(mskNoTarjeta, "Debe ingresar el número de tarjeta");
                        return;
                    }
                    int cantidad = 0;
                    foreach (var item in mskNoTarjeta.Text)
                    {
                        cantidad++;
                    }
                    if (cantidad < 16)
                    {
                        erpErrores.SetError(mskNoTarjeta, "Debe ingresar un número válido");
                        return;
                    }
                    if (Convert.ToInt32(txtCantidadPaquetes.Text) == 0 || string.IsNullOrEmpty(txtCantidadPaquetes.Text))
                    {
                        erpErrores.SetError(txtCantidadPaquetes, "Debe ingresar un paquete");
                        return;
                    }
                    if ((Convert.ToDouble(txtKilometros.Text) == 0 || string.IsNullOrEmpty(txtKilometros.Text)))
                    {
                        erpErrores.SetError(txtKilometros, "Debe ingresar una ruta válida");
                        return;
                    }
                    if (lstUbicaciones.Items.Count <= 1)
                    {
                        erpErrores.SetError(lstUbicaciones, "Debe ingresar una ruta válida");
                        return;
                    }
                    oDetFactura.CantidadKilometros = (int)Math.Round(Convert.ToDouble(txtKilometros.Text));
                    for (int i = 0; i < lstPaquetes.Items.Count; i++)
                    {
                        descripcionPaquete += lstPaquetes.Items[i].ToString() + "\n";
                    }
                    oDetFactura.DescripcionPaquete = descripcionPaquete;
                    for (int i = 0; i < lstUbicaciones.Items.Count; i++)
                    {
                        descripcionruta += lstUbicaciones.Items[i].ToString() + "\n";
                    }
                    oDetFactura.DescripcionRuta = descripcionruta;
                    oDetFactura.Impuesto = Convert.ToDouble(txtImpuesto.Text);
                    oDetFactura.NoFactura = _EncabezadoFactura.IDEncFactura;
                    oDetFactura.PrecioKilometro = _BLLPrecioEnvio.MostrarXID(cboTipoEnvio.SelectedItem.ToString()).PrecioRango;
                    oDetFactura.Secuencial = _BLLFactura.GetNextNumeroFactura();
                    oDetFactura.CantidadPaquetes = Convert.ToInt32(txtCantidadPaquetes.Text);
                    oDetFactura.TipoEnvio = _BLLPrecioEnvio.MostrarXID(cboTipoEnvio.SelectedItem.ToString());
                    _EncabezadoFactura.AgregrarDetalle(oDetFactura);
                    txtSubTotal.Text = _EncabezadoFactura.SubTotal() + "";
                    txtTotal.Text = _EncabezadoFactura.SubTotal() + ((_EncabezadoFactura.SubTotal() * _EncabezadoFactura.Impuesto())) + "";
                    oDetFactura.Total = _EncabezadoFactura.SubTotal() + ((_EncabezadoFactura.SubTotal() * _EncabezadoFactura.Impuesto()));
                    _EncabezadoFactura.XML = _EncabezadoFactura.GenerarXML();
                    File.WriteAllText(@"c:\temp\proyecto.xml", _EncabezadoFactura.GenerarXML());
                }
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                // Log error
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que hace la facturación del envío
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            IBLLFactura _BLLFactura = new BLLFactura();
            string rutaImagen = @"c:\temp\qr.png";
            string numeroFactura = "";
            if (pCliente == null)
            {
                MessageBox.Show("Debe Seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_EncabezadoFactura == null)
            {
                MessageBox.Show("No hay datos por facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_EncabezadoFactura._ListDetFactura.Count == 0)
            {
                MessageBox.Show("No hay items en la factura ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _EncabezadoFactura = _BLLFactura.GuardarFactura(_EncabezadoFactura);
            numeroFactura = _EncabezadoFactura.IDEncFactura.ToString();
            pnumerofactura = numeroFactura;

            if (_EncabezadoFactura == null)
            {
                MessageBox.Show("Error al crear factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (File.Exists(rutaImagen))
                    File.Delete(rutaImagen);

                Image quickResponseImage = QuickResponse.QuickResponseGenerador(numeroFactura.ToString(), 53);
                quickResponseImage.Save(rutaImagen, ImageFormat.Png);

                frmReporteFactura ofrmReporteFactura = new frmReporteFactura(pnumerofactura);
                ofrmReporteFactura.ShowDialog();
                if (ofrmReporteFactura.DialogResult == DialogResult.OK || ofrmReporteFactura.DialogResult == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
        #endregion

        #region Metodos del form

        /// <summary>
        /// Metodo constructor del form que inicializa los componentes
        /// </summary>
        public frmProcesos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor sobre cargado con el cliente cargado
        /// </summary>
        /// <param name="oCliente"></param>
        public frmProcesos(Cliente oCliente)
        {
            InitializeComponent();
            pCliente = oCliente;
        }

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProcesos_Load(object sender, EventArgs e)
        {
            IBLLFactura _BLLFactura = new BLLFactura();
            try
            {
                ComponentesIniciales();
                Utilitarios.CulturaInfo();
                this.txtNoFactura.Text = _BLLFactura.GetNextNumeroFactura().ToString();
                llenarCombos();
                Control.CheckForIllegalCrossThreadCalls = false;
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje    :{0}\n", er.Message);
                msg.AppendFormat("Source     :{0}\n", er.Source);
                msg.AppendFormat("StackTrace :{0}\n", er.StackTrace);

                MessageBox.Show(msg.ToString(), "Atención");
            }

            //Marcadores();
        }

        /// <summary>
        /// Método para cerrar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método que coloca todos los espacios en blanco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Si selecciona que si el from se cerrará para logear otro cliente y facturar de nuevo" + "\n" + "Si selecciona que no solo se limpiaran los campos del form", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                if (result == DialogResult.No)
                {
                    txtIDMensajero.Text = "";
                    txtNombreMensajero.Text = "";
                    cboTipoTarjeta.SelectedIndex = 0;
                    mskNoTarjeta.Text = "";
                    txtCantidadPaquetes.Text = "";
                    lstPaquetes.Items.Clear();
                    txtKilometros.Text = "";
                    lstUbicaciones.Items.Clear();
                    cboTipoEnvio.Items.Clear();
                    txtSubTotal.Text = "";
                    txtTotal.Text = "";
                    gMapMapa.Overlays.Clear();
                    gMapMapa.ReloadMap();
                    gMapMapa.Update();
                }
            }
        }
        #endregion
    }
}
