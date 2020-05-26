using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Mensajeria.Winform.BLL;
using UTN.Mensajeria.Winform.Entidades;
using UTN.Mensajeria.Winform.Interfaces;

namespace UTN.Mensajeria.Winform.UI.Seguridad
{
    /// <summary>
    /// Clase logica del form de acceso
    /// </summary>
    public partial class frmAccesoRegistro : Form
    {
        #region Parametros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Metodos del form
        /// <summary>
        /// Metodo construcot del form
        /// </summary>
        public frmAccesoRegistro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que cierra el form y devuelve el dialog result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
        #endregion

        #region Entrar a Registro
        /// <summary>
        /// Metodo que verifica si el usuario es administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                erpErrores.Clear();
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    erpErrores.SetError(txtUsuario, "No puede quedar vacío");
                    return;
                }
                if (string.IsNullOrEmpty(txtContrasenna.Text))
                {
                    erpErrores.SetError(txtContrasenna, "No puede quedar vacío");
                    return;
                }
                Usuario oUsuario = new Usuario();
                IBLLSeguridad _BLLSeguridad = new BLLSeguridad();
                oUsuario = _BLLSeguridad.SelectUsuarioXID(txtContrasenna.Text, txtUsuario.Text);
                if (oUsuario == null)
                {
                    throw new Exception("El usuario no existe");
                }
                else
                {
                    if (oUsuario.TipoUsuario.Equals("Procesos") || oUsuario.TipoUsuario.Equals("Reporteador"))
                    {
                        throw new Exception("Solo los usuarios administradores pueden acceder a esta opción");
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
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
                MessageBox.Show("Se produjo el siguiente error :" + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
