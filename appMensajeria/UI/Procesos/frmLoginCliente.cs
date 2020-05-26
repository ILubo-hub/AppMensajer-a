using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Mensajeria.Winform.BLL;
using UTN.Mensajeria.Winform.Entidades;
using UTN.Mensajeria.Winform.Interfaces;
using UTN.Mensajeria.Winform.UI.Filtros;

namespace UTN.Mensajeria.Winform.UI.Procesos
{
    /// <summary>
    /// Clase logica del form 
    /// </summary>
    public partial class frmLoginCliente : Form
    {
        #region Parámetros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private Cliente _Cliente = null;
        string tipo = "";
        #endregion

        #region Métodos del form
        /// <summary>
        /// Constructor del form
        /// </summary>
        /// <param name="ptipo">Tipo de usuario entrante</param>
        public frmLoginCliente(string ptipo)
        {
            InitializeComponent();
            tipo = ptipo;
        }

        /// <summary>
        /// Método que cierra el form tomando en cuenta el tipo de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (tipo.Equals("Administrador"))
            {
                new frmPrincipal("Administrador").Show();
            }
            else
            {
                if (tipo.Equals("Procesos"))
                {
                    new frmPrincipal("Procesos").Show();
                }
            }

        }

        /// <summary>
        /// Método de ayuda al usuario de como usar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleccionar un cliente que exista en el sistema se puede buscar en el boton de buscar cliente para más facilidad, si no existe debe registrarlo en la base de datos del sistema en el boton registrar");
        }
        #endregion

        #region Iniciar Sesión
        /// <summary>
        /// Método que inicia sesion y abre el form del proceso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();
            IBLLCliente _BLLCliente = new BLLCliente();
            if (_BLLCliente.BuscarClienteID(mskNumeroIdentificacion.Text) != null)
            {
                oCliente = _BLLCliente.BuscarClienteID(mskNumeroIdentificacion.Text);
                new frmProcesos(oCliente).Show();
                mskNumeroIdentificacion.Text = "";
            }
            else
            {
                MessageBox.Show("No esta registrado");
            }
        }
        #endregion

        #region Buscar Cliente
        /// <summary>
        /// Método que abre la ventana filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmFiltroCliente ofrmFiltroCliente = new frmFiltroCliente();
            IBLLCliente _BLLCliente = new BLLCliente();
            try
            {
                // Mostrar ventan de filtro
                ofrmFiltroCliente.ShowDialog();
                if (ofrmFiltroCliente.DialogResult == DialogResult.OK)
                {
                    _Cliente = ofrmFiltroCliente._Cliente;
                    mskNumeroIdentificacion.Text = _Cliente.IDCliente;
                }

                if (_Cliente == null)
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

        #region Métodos sin uso
        private void frmLoginCliente_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region Registrar Cliente
        /// <summary>
        /// Método que abre la ventana de registro de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            new frmRegistrarCliente().Show();
        }
        #endregion
    }
}
