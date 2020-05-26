using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Mensajeria.Winform.BLL;
using UTN.Mensajeria.Winform.Factory;
using UTN.Mensajeria.Winform.Interfaces;

namespace UTN.Mensajeria.Winform.UI.Mantenimientos
{
    /// <summary>
    /// Clase del frame del mantenimiento de mensajeros
    /// </summary>
    public partial class frmMantenimientoMensajero : Form
    {
        #region Parámetros
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        #endregion

        #region Métodos del From
        /// <summary>
        /// Metodo constructor que inicializa los componentes
        /// </summary>
        public frmMantenimientoMensajero()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo load del frame que implementa el metodo MostrarMensajeros y el cultureInfo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMantenimientoMensajero_Load(object sender, EventArgs e)
        {
            rbActivoSi.Checked = true;
            rbActivoSiMod.Checked = true;
            chkSexoM.Checked = true;
            chkSexoMIn.Checked = true;
            MostrarMensajeros();
            Utilitarios.CulturaInfo();
        }

        /// <summary>
        /// Metodo para salir del frame de mantenimietento de Mensajeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo que coloca todos los espacios del apartado insertar en blanco
        /// </summary>
        public void EspaciosBlancoInsertar()
        {
            mskNumeroCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            mskTelefono.Text = "";
            txtCorreo.Text = "";
            ptbFoto.Image = null;
        }

        /// <summary>
        /// Metodo que coloca todos los espacios del apartado modificar en blanco
        /// </summary>
        public void EspaciosBlancoMod()
        {
            mskNumeroCedulaMod.Text = "";
            txtNombreMod.Text = "";
            txtApellidosMod.Text = "";
            mskTelefonoMod.Text = "";
            txtCorreoMod.Text = "";
            pctFotoMod.Image = null;
        }
        #endregion

        #region Mostrar Mensajeros
        /// <summary>
        /// Metodo que carga los Mensajero que hay en la base de datos
        /// </summary>
        public void MostrarMensajeros()
        {
            IBLLMensajero _BLLMensajero = new BLLMensajero();
            dgvMensajeros.AutoGenerateColumns = false;
            dgvMensajeros.RowTemplate.Height = 100;
            //dgvMensajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            try
            {
                dgvMensajeros.DataSource = _BLLMensajero.MostrarMensajeros();
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
        /// Metodo para atualizar los mensajero que hay en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarMensajeros();
        }
        #endregion

        #region Insertar Mensajero
        /// <summary>
        /// Metodo para insertar el Mensajero a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            IBLLMensajero _BLLMensajero = new BLLMensajero();
            erpErrores.Clear();
            try
            {
                if (mskNumeroCedula.Text.Equals(" -    -"))
                {
                    erpErrores.SetError(mskNumeroCedula, "Debe contener un valor");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtNombre.Text))
                    {
                        erpErrores.SetError(txtNombre, "Debe contener un valor");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtApellidos.Text))
                        {
                            erpErrores.SetError(txtApellidos, "Debe contener un valor");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(mskTelefono.Text))
                            {
                                erpErrores.SetError(mskTelefono, "Debe contener un valor");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtCorreo.Text))
                                {
                                    erpErrores.SetError(txtCorreo, "Debe contener un valor");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(ptbFoto.Image.ToString()))
                                    {
                                        erpErrores.SetError(ptbFoto, "Debe seleccionar una foto");
                                    }
                                    else
                                    {
                                        string sexo = "";
                                        bool activo = false;
                                        sexo = (chkSexoFIn.Checked) ? "Femenino" : "Masculino";
                                        activo = (rbActivoSi.Checked) ? true : false;
                                        _BLLMensajero.InsertarMensajero(FactoryMensajero.ConstruirMensajero(mskNumeroCedula.Text, txtNombre.Text, txtApellidos.Text, sexo, ConvertirFoto(), txtCorreo.Text, activo, mskTelefono.Text));
                                        MessageBox.Show("Se insertó con éxito");
                                        EspaciosBlancoInsertar();
                                    }
                                }
                            }
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

        #region Modificar Mensajero
        /// <summary>
        /// Metodo para modificar un mensajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            IBLLMensajero _BLLMensajero = new BLLMensajero();
            erpErrores.Clear();
            try
            {
                if (mskNumeroCedulaMod.Text.Equals(" -    -"))
                {
                    erpErrores.SetError(mskNumeroCedulaMod, "Debe contener un valor");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtNombreMod.Text))
                    {
                        erpErrores.SetError(txtNombreMod, "Debe contener un valor");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtApellidosMod.Text))
                        {
                            erpErrores.SetError(txtApellidosMod, "Debe contener un valor");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(mskTelefonoMod.Text))
                            {
                                erpErrores.SetError(mskTelefonoMod, "Debe contener un valor");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtCorreoMod.Text))
                                {
                                    erpErrores.SetError(txtCorreoMod, "Debe contener un valor");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(pctFotoMod.Image.ToString()))
                                    {
                                        erpErrores.SetError(pctFotoMod, "Debe seleccionar una foto");
                                    }
                                    else
                                    {
                                        string sexo = "";
                                        bool activo = false;
                                        sexo = (chkSexoF.Checked) ? "Femenino" : "Masculino";
                                        activo = (rbActivoSiMod.Checked) ? true : false;
                                        _BLLMensajero.ModificarMensajero(FactoryMensajero.ConstruirMensajero(mskNumeroCedulaMod.Text, txtNombreMod.Text, txtApellidosMod.Text, sexo, ConvertirFotoMod(), txtCorreoMod.Text, activo, mskTelefonoMod.Text));
                                        MessageBox.Show("Se modificó con éxito");
                                        EspaciosBlancoMod();
                                    }
                                }
                            }
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

        #region Eliminar Mensajero
        /// <summary>
        /// Metodo para eliminar un mensajero de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLMensajero _BLLMensajero = new BLLMensajero();
            IBLLFactura _BLLFactura = new BLLFactura();
            erpErrores.Clear();
            string IDMensajero = "";
            try
            {
                if (dgvMensajeros.SelectedRows.Count == 0)
                {
                    erpErrores.SetError(dgvMensajeros, "Debe seleccionar un valor");
                }
                else
                {
                    IDMensajero = dgvMensajeros.SelectedRows[0].Cells[0].Value.ToString();
                    if (_BLLFactura.ObtenerFacturaByIDMensajero(IDMensajero) != null)
                    {
                        MessageBox.Show("No se pueden borrar mensajeros con registros en la base de datos");
                    }
                    else
                    {

                        _BLLMensajero.EliminarMensajero(IDMensajero);
                        MessageBox.Show("Mensajero eliminado");
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

        #region Seleccionar Foto
        /// <summary>
        /// Metodo para seleccionar la foto del Mensajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ofDialogFoto.Title = "Buscar Imágenes";
            ofDialogFoto.SupportMultiDottedExtensions = true;
            ofDialogFoto.DefaultExt = "*.jpg";
            ofDialogFoto.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";


            if (ofDialogFoto.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    ptbFoto.ImageLocation = ofDialogFoto.FileName;
                    ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat("Message        {0}\n", ex.Message);
                    msg.AppendFormat("Source         {0}\n", ex.Source);
                    msg.AppendFormat("InnerException {0}\n", ex.InnerException);
                    msg.AppendFormat("StackTrace     {0}\n", ex.StackTrace);
                    msg.AppendFormat("TargetSite     {0}\n", ex.TargetSite);
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    MessageBox.Show("Se ha producido el siguiente error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Convierte la foto que hay en el picture box en byte para guardarlo en la base de datos
        /// </summary>
        /// <returns>retirna un arreglo de bytes</returns>
        public byte[] ConvertirFoto()
        {
            try
            {
                Image image = ptbFoto.Image;
                var ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                var bytes = ms.ToArray();
                return bytes;

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
                return null;
            }

        }
        /// <summary>
        /// Convierte la foto que hay en el picture box en byte para modificarla en la base de datos
        /// </summary>
        /// <returns>retirna un arreglo de bytes</returns>
        public byte[] ConvertirFotoMod()
        {
            try
            {
                Image image = pctFotoMod.Image;
                var ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                var bytes = ms.ToArray();

                return bytes;
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
                return null;
            }

        }

        /// <summary>
        /// Metodo que convierte bytes a imagenes para mostrar una imagen de la base de datos
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>retorna una imagen</returns>
        public Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null)
                return null;
            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
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
            return bm;
        }

        /// <summary>
        /// Metodo para seleccionar la foto para modificar una antigua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeleccionarFotoMod_Click(object sender, EventArgs e)
        {
            ofDialogFoto.Title = "Buscar Imágenes";
            ofDialogFoto.SupportMultiDottedExtensions = true;
            ofDialogFoto.DefaultExt = "*.jpg";
            ofDialogFoto.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";


            if (ofDialogFoto.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    pctFotoMod.ImageLocation = ofDialogFoto.FileName;
                    pctFotoMod.SizeMode = PictureBoxSizeMode.StretchImage;
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
        }
        #endregion

        #region Datos Automatizados
        /// <summary>
        /// Metodo para cargar los datos del mensajero que se va a modificar a los respectivos campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMensajeros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskNumeroCedulaMod.Text = dgvMensajeros.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreMod.Text = dgvMensajeros.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidosMod.Text = dgvMensajeros.SelectedRows[0].Cells[2].Value.ToString();
            if (dgvMensajeros.SelectedRows[0].Cells[3].Value.ToString().Equals("Femenino"))
            {
                chkSexoF.Checked = true;
            }
            else
            {
                chkSexoM.Checked = true;
            }

            byte[] foto = (byte[])dgvMensajeros.SelectedRows[0].Cells[4].Value;
            pctFotoMod.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFotoMod.Image = Convertir_Bytes_Imagen(foto);
            txtCorreoMod.Text = dgvMensajeros.SelectedRows[0].Cells[5].Value.ToString();

            if (dgvMensajeros.SelectedRows[0].Cells[6].Value.ToString().Equals("True"))
            {
                rbActivoSiMod.Select();
            }
            else
            {
                rbActivoNoMod.Select();
            }
            mskTelefonoMod.Text = dgvMensajeros.SelectedRows[0].Cells[7].Value.ToString();
        }

        /// <summary>
        /// Metodo para desseleccionar el check box contrario al presionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSexoF_CheckedChanged(object sender, EventArgs e)
        {
            chkSexoM.Checked = false;
        }

        /// <summary>
        /// Metodo para desseleccionar el check box contrario al presionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSexoM_CheckedChanged(object sender, EventArgs e)
        {
            chkSexoF.Checked = false;
        }
        /// <summary>
        /// Metodo para desseleccionar el check box contrario al presionado en el group box Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSexoFIn_CheckedChanged(object sender, EventArgs e)
        {
            chkSexoMIn.Checked = false;
        }

        /// <summary>
        /// Metodo para desseleccionar el check box contrario al presionado en el group box Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSexoMIn_CheckedChanged(object sender, EventArgs e)
        {
            chkSexoFIn.Checked = false;
        }
        #endregion

        #region Métodos sin uso
        private void button1_Click(object sender, EventArgs e)
        {
        }
        #endregion 
    }
}

