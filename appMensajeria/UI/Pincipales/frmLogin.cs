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
using UTN.Mensajeria.Winform.UI.Seguridad;

namespace UTN.Mensajeria.Winform.UI
{
    /// <summary>
    /// Clase logica del frame Login
    /// </summary>
    public partial class frmLogin : Form
    {
        #region Parametros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Métodos del form
        /// <summary>
        /// Metodo constructor que inicializa los componentes del frame
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para salir de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Metodo load del frame que implementa el cultureInfo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Application.ProductName + " Versión:  " + Application.ProductVersion;
                Utilitarios.CulturaInfo();
                _MyLogControlEventos.InfoFormat("Inicio Login");
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);

                MessageBox.Show("Se produjo un error :" + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.ErrorFormat("Error {0}", er.Message);
            }

        }
        #endregion

        #region Registrarse
        /// <summary>
        /// Metodo para registrar usuarios a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmAccesoRegistro ofrmAccesoRegistro = new frmAccesoRegistro();
            IBLLCliente _BLLCliente = new BLLCliente();
            try
            {
                // Mostrar ventan de filtro
                ofrmAccesoRegistro.ShowDialog();
                if (ofrmAccesoRegistro.DialogResult == DialogResult.OK)
                {
                    new frmRegistroUsuarios().Show();
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

        #region Ingresar
        /// <summary>
        /// Metodo que utiliza la base de datos para dar acceso o denegar acceso al programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            IBLLLogear _BLLLogear = new BLLLogear();

            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    erpErrores.SetError(txtUsuario, "Debe contener un valor");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtContrasena.Text))
                    {
                        erpErrores.SetError(txtContrasena, "Debe contener un valor");
                    }
                    else
                    {
                        usuario = _BLLLogear.Logear(txtContrasena.Text, txtUsuario.Text);
                        if (usuario != null)
                        {
                            new frmPrincipal(usuario.TipoUsuario).Show();
                            _MyLogControlEventos.InfoFormat("Entró a la Aplicación");
                        }
                        else
                        {
                            MessageBox.Show("Acceso Denegado");
                        }
                    }
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

                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
            }
        }
        #endregion
    }
}
