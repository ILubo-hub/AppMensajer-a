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
using UTN.Mensajeria.Winform.Factory;
using UTN.Mensajeria.Winform.Interfaces;

namespace UTN.Mensajeria.Winform.UI.Seguridad
{
    /// <summary>
    /// Clase logica del form de registro de usuarios
    /// </summary>
    public partial class frmRegistroUsuarios : Form
    {
        #region Parametros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Metodos del form
        /// <summary>
        /// Metodo constructor del form
        /// </summary>
        public frmRegistroUsuarios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que se sale del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            llenarCombo();
        }
        #endregion

        #region Cargar Usuarios
        /// <summary>
        /// Metodo que carga los usuarios existentes en el data grid view
        /// </summary>
        public void CargarUsuarios()
        {
            IBLLSeguridad _BLLSeguridad = new BLLSeguridad();
            dgvUsuarios.DataSource = _BLLSeguridad.ObtenerUsuarios();
        }
        #endregion

        #region Agregar Usuarios
        /// <summary>
        /// Metodo que agregra los usuarios a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                IBLLSeguridad _BLLSeguridad = new BLLSeguridad();
                Usuario oUsuario = new Usuario();
                if (string.IsNullOrEmpty(txtNombreUsuario.Text))
                {
                    erpErrores.SetError(txtNombreUsuario, "Debe contener un valor");
                    return;
                }
                if (string.IsNullOrEmpty(txtContrasena.Text))
                {
                    erpErrores.SetError(txtContrasena, "Debe contener un valor");
                    return;
                }
                oUsuario = _BLLSeguridad.AgregarUsuario(FactoryUsuario.ConstruirUsuario(txtNombreUsuario.Text, txtContrasena.Text, cboTipoUsuario.SelectedItem.ToString()));
                CargarUsuarios();
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
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Datos Automatizados
        /// <summary>
        /// Metodo que llena el comboBox
        /// </summary>
        public void llenarCombo()
        {
            cboTipoUsuario.Items.Add("Administrador");
            cboTipoUsuario.Items.Add("Reporteador");
            cboTipoUsuario.Items.Add("Procesos");
            cboTipoUsuario.SelectedIndex = 0;
        }
        #endregion

        #region Eliminar Usuario
        /// <summary>
        /// Metodo que elimina el usuario seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                IBLLSeguridad _BLLSeguridad = new BLLSeguridad();
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    erpErrores.SetError(dgvUsuarios, "Debe seleccionar un usuario");
                    return;
                }
                _BLLSeguridad.EliminarUsuario(dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString(), dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
                CargarUsuarios();
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
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
