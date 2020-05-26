using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Mensajeria.Winform.DAL;
using UTN.Mensajeria.Winform.Persistencia;

namespace UTN.Mensajeria.Winform.UI.Reportes.Forms
{
    /// <summary>
    /// Clase logica del reporte de recaudacion
    /// </summary>
    public partial class frmReporteRecaudacion : Form
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Metodos del form
        /// <summary>
        /// Constructor del form
        /// </summary>
        public frmReporteRecaudacion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que sale del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Metodos sin uso
        /// <summary>
        /// Metodo load del reporte de recaudacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReporteRecaudacion_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Metodo load del report viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buscar Facturas
        /// <summary>
        /// Metodo que busca la factura segun el reango de fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IConexion con = new Conexion();
                using (SqlConnection conn = con.conexion())
                {
                    recaudacionTableAdapter.Connection = conn;
                    recaudacionTableAdapter.Fill(this.dataSetRecaudacion.DataTableRecaudacion, Convert.ToString(dtpFechaInicial.Value), Convert.ToString(dtpFechaFinal.Value));
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
        #endregion
    }
}
