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

namespace UTN.Mensajeria.Winform.UI.Mantenimientos
{
    /// <summary>
    /// Clase logica del frame de mantenimientos de clientes
    /// </summary>
    public partial class frmMantenimientoCliente : Form
    {
        #region Parametros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Metodos del form
        /// <summary>
        /// Metodo constructor que define los componentes del frame
        /// </summary>
        public frmMantenimientoCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo load que llena la tabla y los combos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            llenarCombosProvincias();
            rbActivoSi.Select();
            rbActivoSiMod.Select();
            Utilitarios.CulturaInfo();
        }

        /// <summary>
        /// Metodo para salir del frane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo para dejar todos los campos en blanco despues de insertar un cliente
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
        /// Metodo para dejar todos los espacios en blanco despues de modificar un cliente
        /// </summary>
        public void EspaciosBlancoMod()
        {
            mskNumeroCedulaMod.Text = "";
            txtApellidoMod.Text = "";
            txtNombreMod.Text = "";
            txtCorreoMod.Text = "";
            mskTelefonoMod.Text = "";
            rctDireccionMod.Text = "";
            cboProvinciasMod.SelectedIndex = 0;
        }
        #endregion

        #region Datos Automatizados
        /// <summary>
        /// Metodo para llenar los combobox con las provincias del país
        /// </summary>
        public void llenarCombosProvincias()
        {
            IBLLProvincia _BLLProvincia = new BLLProvincia();
            cboProvincia.Items.Clear();
            cboProvinciasMod.Items.Clear();
            try
            {
                foreach (Provincia obj in _BLLProvincia.MostrarProvincias())
                {
                    cboProvincia.Items.Add(obj.IDProvincia);
                    cboProvinciasMod.Items.Add(obj.IDProvincia);
                }
                cboProvincia.SelectedIndex = 0;
                cboProvinciasMod.SelectedIndex = 0;
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
        /// Metodo para asignarle valor a cada campo de texto en el frame en base a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskNumeroCedulaMod.Text = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreMod.Text = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidoMod.Text = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();
            txtCorreoMod.Text = dgvClientes.SelectedRows[0].Cells[3].Value.ToString();
            if (dgvClientes.SelectedRows[0].Cells[4].Value.ToString().Equals("True"))
            {
                rbActivoSiMod.Select();
            }
            else
            {
                rbActivoNoMod.Select();
            }
            mskTelefonoMod.Text = dgvClientes.SelectedRows[0].Cells[5].Value.ToString();
            rctDireccionMod.Text = dgvClientes.SelectedRows[0].Cells[6].Value.ToString();
            cboProvinciasMod.SelectedValue = dgvClientes.SelectedRows[0].Cells[7].Value.ToString();
        }
        #endregion

        #region Mostrar Clientes
        /// <summary>
        /// Metodo para mostrar los clientes de la base de datos en el datagridview
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
        /// Metodo para actulizar los clientes de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        #endregion

        #region Eliminar Clientes
        /// <summary>
        /// Metodo para eliminar un cliente de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            IBLLFactura _BLLFactura = new BLLFactura();
            erpErrores.Clear();
            string IDCliente = "";

            try
            {
                if (string.IsNullOrEmpty(dgvClientes.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    erpErrores.SetError(dgvClientes, "Debe seleccionar un cliente de la lista");
                }
                else
                {
                    IDCliente = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
                    if (_BLLFactura.ObtenerFacturaByIDCliente(IDCliente) != null)
                    {
                        MessageBox.Show("No se puede eliminar un cliente con registros en la base de datos");
                    }
                    else
                    {
                        _BLLCliente.EliminarCliente(IDCliente);
                        MessageBox.Show("Cliente eliminado");
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

        #region Insertar Cliente
        /// <summary>
        /// Metodo para agregar el cliente a la base de datos
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

        #region Modificar Cliente
        /// <summary>
        /// Metodo para modificar los clientes de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            erpErrores.Clear();
            try
            {
                if (string.IsNullOrEmpty(txtNombreMod.Text))
                {
                    erpErrores.SetError(txtNombre, "Debe contener un valor");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtApellidoMod.Text))
                    {
                        erpErrores.SetError(txtApellido, "Debe contener un valor");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(mskTelefonoMod.Text))
                        {
                            erpErrores.SetError(mskTelefonoMod, "Debe contener un valor");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtCorreoMod.Text))
                            {
                                erpErrores.SetError(txtCorreoMod, "Debe contener un valor");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(rctDireccionMod.Text))
                                {
                                    erpErrores.SetError(rctDireccionMod, "Debe contener un valor");
                                }
                                else
                                {
                                    bool activo = false;
                                    activo = (rbActivoSiMod.Checked) ? true : false;
                                    _BLLCliente.ModificarCliente(FactoryCliente.ConstruirCliente(mskNumeroCedulaMod.Text, txtNombreMod.Text, txtApellidoMod.Text, mskTelefonoMod.Text, txtCorreoMod.Text, Convert.ToString(cboProvinciasMod.SelectedItem), rctDireccionMod.Text, activo));
                                    MessageBox.Show("Se modificó con éxito");
                                    EspaciosBlancoMod();

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

        #region Metodos sin uso

        private void gbModificar_Enter(object sender, EventArgs e)
        {
        }
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
