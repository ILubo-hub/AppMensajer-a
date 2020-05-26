using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Mensajeria.Winform.DAL;
using UTN.Mensajeria.Winform.Persistencia;

namespace UTN.Mensajeria.Winform.UI.Reportes.Forms
{
    /// <summary>
    /// Form del reporte de Compra por cliente
    /// </summary>
    public partial class frmReporteCompraCliente : Form
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Metodos del form
        /// <summary>
        /// Constructor del form
        /// </summary>
        public frmReporteCompraCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReporteCompraCliente_Load(object sender, EventArgs e)
        {

            try
            {
                IConexion con = new Conexion();
                using (SqlConnection conn = con.conexion())
                {
                    compraClienteTableAdapter.Connection = conn;
                    this.compraClienteTableAdapter.Fill(this.dataSetRecaudacion.DataTableCompraCliente);

                }
                this.rptVisor.RefreshReport();
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
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        #endregion
    }
}
