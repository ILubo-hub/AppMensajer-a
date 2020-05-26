using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Mensajeria.Winform.UI.Mantenimientos;

namespace UTN.Mensajeria.Winform.UI
{
    /// <summary>
    /// frame para seleccionar el tipo de mantenimiento a escoger
    /// </summary>
    public partial class frmMantenimientos : Form
    {
        #region Métodos del Form
        /// <summary>
        /// Metodo constructor del frame que inicializa los componentes
        /// </summary>
        public frmMantenimientos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo load del frame que implementa el culture info 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            rbClientes.Select();
            Utilitarios.CulturaInfo();
        }

        /// <summary>
        /// Metodo para salir del frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Ingresar 
        /// <summary>
        /// Metodo para acceder a los mantenimientos segun el radioButton seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbClientes.Checked)
            {
                new frmMantenimientoCliente().Show();
            }
            else
            {
                if (rbMensajeros.Checked)
                {
                    new frmMantenimientoMensajero().Show();
                }
                else
                {
                    new frmMantenimientoPrecios().Show();
                }
            }
        }
        #endregion

        #region
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
