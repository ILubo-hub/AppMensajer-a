using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Mensajeria.Winform.UI.Procesos
{
    /// <summary>
    /// Clase logica del form
    /// </summary>
    public partial class frmInsertarPaquetes : Form
    {
        #region Parámetros
        public List<string> _ListArticulos { get; set; }
        #endregion

        #region Metodos del form
        /// <summary>
        /// Metodo constructor del form
        /// </summary>
        public frmInsertarPaquetes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInsertarPaquetes_Load(object sender, EventArgs e)
        {
            _ListArticulos = new List<string>();
        }

        /// <summary>
        /// Método que cierra el form con un redultado ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion

        #region Agregar Paquetes
        /// <summary>
        /// Método que agrega el paquete a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            erpErrores.Clear();
            if (string.IsNullOrEmpty(txtdescrpcion.Text))
            {
                erpErrores.SetError(txtdescrpcion, "Debe ingresar un valor");
            }
            else
            {
                lstPaquetes.Items.Add(txtdescrpcion.Text);
                _ListArticulos.Add(txtdescrpcion.Text);
                txtdescrpcion.Text = "";
            }

        }
        #endregion

        #region Eliminar Paquetes
        /// <summary>
        /// Método que elimina elementos de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            erpErrores.Clear();
            if (lstPaquetes.SelectedIndex == -1)
            {
                erpErrores.SetError(lstPaquetes, "Debe seleccionar el item que desea eliminar");
            }
            else
            {
                _ListArticulos.Remove(lstPaquetes.SelectedItem.ToString());
                lstPaquetes.Items.Remove(lstPaquetes.SelectedItem);
            }

        }
        #endregion
    }
}
