using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Mensajeria.Winform.UI.Reportes.Forms;

namespace UTN.Mensajeria.Winform.UI.Pincipales
{
    /// <summary>
    /// Clase logica del form de Reportes
    /// </summary>
    public partial class frmReportes : Form
    {
        #region Métodos del form
        /// <summary>
        /// Metodo constructor del form
        /// </summary>
        public frmReportes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReportes_Load(object sender, EventArgs e)
        {
            rbClientes.Select();
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

        #region Ingreso
        /// <summary>
        /// Metodo que ingresa al reporte elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbRecaudacion.Checked)
            {
                new frmReporteRecaudacion().Show();
            }
            else
            {
                new frmReporteCompraCliente().Show();
            }
        }
        #endregion
    }
}
