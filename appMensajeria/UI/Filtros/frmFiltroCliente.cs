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

namespace UTN.Mensajeria.Winform.UI.Filtros
{
    /// <summary>
    /// Clase grafica de el filtro de clientes
    /// </summary>
    public partial class frmFiltroCliente : Form
    {
        #region Parametros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public Cliente _Cliente { get; private set; } = null;
        #endregion

        #region Metodos del Form
        /// <summary>
        /// Constructor
        /// </summary>
        public frmFiltroCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pone los espacios en blanco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
            dgvFlitro.DataSource = null;
            txtFiltro.Focus();
        }
        
        /// <summary>
        /// Cierra el form y da resultado al DialogResult
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Buscar Cliente
        /// <summary>
        /// Busca los clientes por el filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            string filtro = string.Empty;
            try
            {
                filtro = txtFiltro.Text;
                filtro = filtro.Replace(' ', '%');
                filtro = "%" + filtro + "%";
                dgvFlitro.AutoGenerateColumns = false;
                dgvFlitro.DataSource = _BLLCliente.MostrarClientesByFilter(filtro);
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

        /// <summary>
        /// Selecciona al cliente y carga el parametro cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFlitro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFlitro.RowCount > 0 && dgvFlitro.SelectedRows.Count > 0)
                {
                    if (dgvFlitro.CurrentCell.Selected)
                    {
                        _Cliente = dgvFlitro.SelectedRows[0].DataBoundItem as Cliente;
                        this.DialogResult = DialogResult.OK;
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
                MessageBox.Show("Se produjo el siguiente error :" + er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Metodos sin Uso
        private void frmFiltroCliente_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
