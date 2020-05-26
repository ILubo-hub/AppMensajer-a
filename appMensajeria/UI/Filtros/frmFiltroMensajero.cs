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
    /// Clase grafica del filtro de mensajeros
    /// </summary>
    public partial class frmFiltroMensajero : Form
    {
        #region
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public Mensajero _Mensajero { get; private set; } = null;
        #endregion

        #region Metodos del form
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public frmFiltroMensajero()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que coloca todos los espacios en blanco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
            dgvMensajero.DataSource = null;
        }

        /// <summary>
        /// Método que cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Buscar Mesajero
        /// <summary>
        /// Método que busca el cliente con el filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBLLMensajero _BLLMensajero = new BLLMensajero();
            dgvMensajero.AutoGenerateColumns = false;
            dgvMensajero.RowTemplate.Height = 100;
            //dgvMensajero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            string filtro = string.Empty;
            try
            {
                filtro = txtFiltro.Text;
                filtro = filtro.Replace(' ', '%');
                filtro = "%" + filtro + "%";
                dgvMensajero.AutoGenerateColumns = false;
                dgvMensajero.DataSource = _BLLMensajero.BuscarMensajeroByFilter(filtro);
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
        /// Método que selecciona el cliente y lo guarda como parametro de la clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMensajero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMensajero.RowCount > 0 && dgvMensajero.SelectedRows.Count > 0)
                {
                    if (dgvMensajero.CurrentCell.Selected)
                    {
                        _Mensajero = dgvMensajero.SelectedRows[0].DataBoundItem as Mensajero;
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

        #region Metodos sin uso

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFiltroMensajero_Load(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
