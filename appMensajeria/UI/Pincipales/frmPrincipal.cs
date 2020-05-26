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
using UTN.Mensajeria.Winform.UI.Pincipales;
using UTN.Mensajeria.Winform.UI.Procesos;

namespace UTN.Mensajeria.Winform.UI
{
    /// <summary>
    /// Frame principal donde se tiene acceso a los mantenimientos, procesos y reportes segun el tipo de perfil
    /// </summary>
    public partial class frmPrincipal : Form
    {
        #region Parametros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        string tipo = "";
        #endregion

        #region Métodos del form
        /// <summary>
        /// Metodo constructor del frame que inicializa los componentes y define que tipo de usuario entra al frame
        /// </summary>
        /// <param name="ptipo"></param>
        public frmPrincipal(string ptipo)
        {
            InitializeComponent();
            tipo = ptipo;
        }

        /// <summary>
        /// Metodo load del frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            disenoFrame();
            Utilitarios.CulturaInfo();
            _MyLogControlEventos.InfoFormat("Entró al frmPrincipal");
        }

        /// <summary>
        /// Metodo para salir del frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Mantenimientos
        /// <summary>
        /// Metodo para entrar al frame de mantenimientos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            new frmMantenimientos().Show();
        }
        #endregion

        #region Procesos
        /// <summary>
        /// Metodo para acceder a los procesos del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcesos_Click(object sender, EventArgs e)
        {
            new frmLoginCliente(tipo).Show();
            this.Dispose();
        }
        #endregion

        #region Reportes
        /// <summary>
        /// Metodo que abre el form de los reportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportes_Click(object sender, EventArgs e)
        {
            new frmReportes().Show();
        }
        #endregion

        #region Roles
        /// <summary>
        /// Metodo para definir el diseno segun sea el tipo de perfil
        /// </summary>
        public void disenoFrame()
        {
            if (tipo.Equals("Administrador"))
            {
                btnMantenimientos.Visible = true;
                btnMantenimientos.Enabled = true;
                btnProcesos.Visible = true;
                btnProcesos.Enabled = true;
                btnReportes.Visible = true;
                btnReportes.Enabled = true;
            }
            else
            {
                if (tipo.Equals("Reporteador"))
                {
                    btnMantenimientos.Visible = false;
                    btnMantenimientos.Enabled = false;
                    btnProcesos.Visible = false;
                    btnProcesos.Enabled = false;
                    btnReportes.Visible = true;
                    btnReportes.Enabled = true;
                    btnReportes.SetBounds(45, 161, 195, 69);
                }
                else
                {
                    if (tipo.Equals("Procesos"))
                    {
                        btnMantenimientos.Visible = false;
                        btnMantenimientos.Enabled = false;
                        btnProcesos.Visible = true;
                        btnProcesos.Enabled = true;
                        btnReportes.Visible = false;
                        btnReportes.Enabled = false;
                        btnProcesos.SetBounds(45, 161, 195, 69);
                    }
                }
            }
        }
        #endregion
    }
}
