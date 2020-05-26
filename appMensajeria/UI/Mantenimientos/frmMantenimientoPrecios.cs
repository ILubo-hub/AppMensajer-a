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
    /// Clase logica del form mantenimiento de precios
    /// </summary>
    public partial class frmMantenimientoPrecios : Form
    {
        #region Parámetros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Métodos del form
        /// <summary>
        /// Constructor que inicializa los componentes del form
        /// </summary>
        public frmMantenimientoPrecios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo constructor del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoPrecios_Load(object sender, EventArgs e)
        {
            Utilitarios.CulturaInfo();
            MostrarPrecios();
        }

        /// <summary>
        /// Metodo que cierra el frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo que coloca los espacios del apartado insertar en blanco
        /// </summary>
        public void EspaciosBlancoInsert()
        {
            txtTipo.Text = "";
            nudKilometroInicial.Value = 0;
            nudKilometroFinal.Value = 0;
            mskPrecio.Text = "";
        }

        /// <summary>
        /// Metodo que coloca los espacios del apartado modificar en blanco
        /// </summary>
        public void EspaciosBlancoMod()
        {
            txtTipoMod.Text = "";
            nudKilometroInicialMod.Value = 0;
            nudKilometroFinalMod.Value = 0;
            mskPrecioMod.Text = "";
        }
        #endregion

        #region Mostrar Precios
        /// <summary>
        /// Metodo para cargar todos los precios de la base de datos en la tabla
        /// </summary>
        public void MostrarPrecios()
        {
            List<EnvioPaquete> _listPrecios = new List<EnvioPaquete>();
            IBLLPrecioEnvio _BLLPrecioKilometro = new BLLPrecioEnvio();

            dgvPrecios.AutoGenerateColumns = false;
            //dgvPrecios.RowTemplate.Height = 100;
            dgvPrecios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            try
            {
                _listPrecios = _BLLPrecioKilometro.ListaPrecios();
                dgvPrecios.DataSource = _listPrecios;
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
        /// Metodo que atualiza los Precios de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarPrecios();
        }
        #endregion

        #region Insertar Precios
        /// <summary>
        /// Metodo que inserta el precio nuevo a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            erpErrores.Clear();
            IBLLPrecioEnvio _BLLPrecioKilometro = new BLLPrecioEnvio();
            try
            {
                if (string.IsNullOrEmpty(txtTipo.Text))
                {
                    erpErrores.SetError(txtTipo, "No puede quedar vacío");
                }
                else
                {
                    if (nudKilometroInicial.Value == 0 && nudKilometroFinal.Value == 0)
                    {
                        erpErrores.SetError(nudKilometroFinal, "No puede ser cero a ambos lados");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(mskPrecio.Text))
                        {
                            erpErrores.SetError(mskPrecio, "No puede quedar vacío");
                        }
                        else
                        {
                            EnvioPaquete oEnvio = new EnvioPaquete();
                            oEnvio.TipoEnvio = txtTipo.Text;
                            oEnvio.KilometroInicial = (int)nudKilometroInicial.Value;
                            oEnvio.KilometroFinal = (int)nudKilometroFinal.Value;
                            oEnvio.PrecioRango = Convert.ToDouble(mskPrecio.Text);
                            _BLLPrecioKilometro.InsertarPrecioEnvio(oEnvio);
                            EspaciosBlancoInsert();
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

        #region Modificar Precios
        /// <summary>
        /// Metodo que modifica el precio que hay en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            erpErrores.Clear();
            IBLLPrecioEnvio _BLLPrecioKilometro = new BLLPrecioEnvio();
            try
            {
                if (string.IsNullOrEmpty(txtTipoMod.Text))
                {
                    erpErrores.SetError(txtTipoMod, "No puede quedar vacío");
                }
                else
                {
                    if (nudKilometroInicialMod.Value == 0 && nudKilometroFinalMod.Value == 0)
                    {
                        erpErrores.SetError(nudKilometroFinalMod, "No puede ser cero a ambos lados");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(mskPrecioMod.Text))
                        {
                            erpErrores.SetError(mskPrecioMod, "No puede quedar vacío");
                        }
                        else
                        {
                            EnvioPaquete oEnvio = new EnvioPaquete();
                            oEnvio.TipoEnvio = txtTipoMod.Text;
                            oEnvio.KilometroInicial = (int)nudKilometroInicialMod.Value;
                            oEnvio.KilometroFinal = (int)nudKilometroFinalMod.Value;
                            oEnvio.PrecioRango = Convert.ToDouble(mskPrecioMod.Text);
                            _BLLPrecioKilometro.ActualizarPrecioEnvio(oEnvio);
                            EspaciosBlancoMod();
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

        #region Datos Automatizados
        /// <summary>
        /// Metodo que carga los datos en las cajas de texto del precio para modificarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPrecios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoMod.Text = dgvPrecios.SelectedRows[0].Cells[0].Value.ToString();
            nudKilometroInicialMod.Value = Convert.ToInt32(dgvPrecios.SelectedRows[0].Cells[1].Value.ToString());
            nudKilometroFinalMod.Value = Convert.ToInt32(dgvPrecios.SelectedRows[0].Cells[2].Value.ToString());
            mskPrecioMod.Text = dgvPrecios.SelectedRows[0].Cells[3].Value.ToString();
        }
        #endregion

        #region Eliminar Precios
        /// <summary>
        /// Metodo que elimina el precio seleccionado en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLPrecioEnvio _BLLPrecioKilometro = new BLLPrecioEnvio();
            try
            {
                if (string.IsNullOrEmpty(dgvPrecios.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    erpErrores.SetError(dgvPrecios, "Debe seleccionar un item de la tabla");
                }
                else
                {
                    _BLLPrecioKilometro.BorrarEnvio(dgvPrecios.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Se eliminó con éxito");
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

        #region Métodos sin uso
        private void gbInsertar_Enter(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
