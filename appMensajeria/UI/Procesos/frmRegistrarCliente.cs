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

namespace UTN.Mensajeria.Winform.UI.Procesos
{
    /// <summary>
    /// Clase del form que registra los clientes
    /// </summary>
    public partial class frmRegistrarCliente : Form
    {
        #region Paramtros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Metodos del form
        /// <summary>
        /// Metodo construcor del form
        /// </summary>
        public frmRegistrarCliente()
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
        /// Metodo que coloca los espacios en blanco del form
        /// </summary>
        public void EspaciosBlancoInsertar()
        {
            mskNumeroCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            mskTelefono.Text = "";
            rctDireccion.Text = "";
            cboProvincia.SelectedIndex = 0;
        }

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            llenarCombo();
            rbActivoSi.Select();
        }
        #endregion

        #region Datos Automatizados
        /// <summary>
        /// Metodo que llena los combo0s del form
        /// </summary>
        public void llenarCombo()
        {
            IBLLProvincia _BLLProvincia = new BLLProvincia();
            cboProvincia.Items.Clear();
            try
            {
                foreach (Provincia obj in _BLLProvincia.MostrarProvincias())
                {
                    cboProvincia.Items.Add(obj.IDProvincia);
                }
                cboProvincia.SelectedIndex = 0;
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

        #region Mostrar Clientes
        /// <summary>
        /// Metodo que muestra los clientes
        /// </summary>
        public void MostrarClientes()
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            try
            {
                dgvClientes.DataSource = _BLLCliente.MostrarClientes();
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

        /// <summary>
        /// Metodo que actualiza los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListo_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        #endregion

        #region Agregrar Cliente
        /// <summary>
        /// Metodo que agrega un cliente a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            erpErrores.Clear();
            try
            {
                if (mskNumeroCedula.Text.Equals(" -    -"))
                {
                    erpErrores.SetError(mskNumeroCedula, "Debe contener un valor");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtNombre.Text))
                    {
                        erpErrores.SetError(txtNombre, "Debe contener un valor");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtApellido.Text))
                        {
                            erpErrores.SetError(txtApellido, "Debe contener un valor");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(mskTelefono.Text))
                            {
                                erpErrores.SetError(mskTelefono, "Debe contener un valor");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtCorreo.Text))
                                {
                                    erpErrores.SetError(txtCorreo, "Debe contener un valor");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(rctDireccion.Text))
                                    {
                                        erpErrores.SetError(rctDireccion, "Debe contener un valor");
                                    }
                                    else
                                    {
                                        bool activo = false;
                                        activo = (rbActivoSi.Checked) ? true : false;
                                        _BLLCliente.InsertarCliente(FactoryCliente.ConstruirCliente(mskNumeroCedula.Text, txtNombre.Text, txtApellido.Text, mskTelefono.Text, txtCorreo.Text, Convert.ToString(cboProvincia.SelectedItem), rctDireccion.Text, activo));
                                        MessageBox.Show("Se insertó con éxito");
                                        EspaciosBlancoInsertar();
                                    }
                                }
                            }
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
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
