using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Mensajeria.Winform.DAL;
using UTN.Mensajeria.Winform.Persistencia;
using UTN.Mensajeria.Winform.UI.Procesos;

namespace UTN.Mensajeria.Winform.UI.Reportes.Forms
{
    /// <summary>
    /// Clase logica del form Reporte de factura
    /// </summary>
    public partial class frmReporteFactura : Form
    {
        #region Parametros
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        string idFactura = "";
        #endregion

        #region Metodos del form
        /// <summary>
        /// Metodo construcot del form
        /// </summary>
        public frmReporteFactura()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo constructor sobrecargado del form
        /// </summary>
        /// <param name="_IdFactura"></param>
        public frmReporteFactura(string _IdFactura)
        {
            InitializeComponent();
            idFactura = _IdFactura;
        }

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                bgwWorker.RunWorkerAsync();
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
        /// Metodo que cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region Exportar PDF

        /// <summary>
        /// Metodo que convierte el reporte en pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            File.Copy(@"c:\temp\reporteFactura.pdf", @"c:\temp\reporteFactura1.pdf", true);
            string ruta = @"c:\temp\reporteFactura1.pdf";
            try
            {

                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                byte[] Bytes = this.rptVisor.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }

                Process.Start(ruta);
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
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Background Worker

        /// <summary>
        /// Metodo que se hace asincronicamente con la UI del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            IConexion con = new Conexion();
            using (SqlConnection conn = con.conexion())
            {
                facturaTableAdapter.Connection = conn;
                facturaTableAdapter.Fill(this.dataSetRecaudacion.DataTableFactura, idFactura);
                i++;
                bgwWorker.ReportProgress(i);
            }
            string ruta = @"file:///" + @"C:/temp/qr.png";
            // Habilitar imagenes externas
            this.rptVisor.LocalReport.EnableExternalImages = true;
            ReportParameter param = new ReportParameter("quickresponse", ruta);
            i += 20;
            bgwWorker.ReportProgress(i);
            this.rptVisor.LocalReport.SetParameters(param);
            i += 10;
            bgwWorker.ReportProgress(i);
            this.rptVisor.RefreshReport();
            i += 20;
            bgwWorker.ReportProgress(i);
            GuardarPDF();
            i += 40;
            bgwWorker.ReportProgress(i);
            Utilitarios.EnviarCorreo("Gracias por utilizar nuestros servicios", "Envios", "natangarcia1807@gmail.com", "pruebaproyectoprogra3@gmail.com", "natangarcia1807@gmail.com", "1807chila");
            Utilitarios.EnviarCorreo("Correo al Ministerio de Hacienda", "Envios", "natangarcia1807@gmail.com", "pruebaproyectoprogra3@gmail.com", "natangarcia1807@gmail.com", "1807chila");
            i += 20;
            bgwWorker.ReportProgress(i);
        }

        /// <summary>
        /// Metodo que lleva el control del procesos del metodo asincronico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProcesos.Increment(e.ProgressPercentage);
        }

        /// <summary>
        /// Metodo que completa el metodo asincronico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblCargando.Text = "                                     Listo";
        }

        /// <summary>
        /// Metodo que guarda el pdf de la factura
        /// </summary>
        public void GuardarPDF()
        {
            string ruta = @"c:\temp\reporteFactura.pdf";
            try
            {

                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                byte[] Bytes = this.rptVisor.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
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
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion
    }
}
