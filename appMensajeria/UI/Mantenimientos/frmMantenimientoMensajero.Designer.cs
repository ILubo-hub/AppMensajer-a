namespace UTN.Mensajeria.Winform.UI.Mantenimientos
{
    partial class frmMantenimientoMensajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoMensajero));
            this.dgvMensajeros = new System.Windows.Forms.DataGridView();
            this.clmIDMensajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApelldos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.chkSexoMIn = new System.Windows.Forms.CheckBox();
            this.chkSexoFIn = new System.Windows.Forms.CheckBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.rbActivoNo = new System.Windows.Forms.RadioButton();
            this.rbActivoSi = new System.Windows.Forms.RadioButton();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mskNumeroCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumeroCedula = new System.Windows.Forms.Label();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.mskTelefonoMod = new System.Windows.Forms.MaskedTextBox();
            this.chkSexoM = new System.Windows.Forms.CheckBox();
            this.chkSexoF = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pctFotoMod = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarFotoMod = new System.Windows.Forms.Button();
            this.rbActivoNoMod = new System.Windows.Forms.RadioButton();
            this.rbActivoSiMod = new System.Windows.Forms.RadioButton();
            this.txtCorreoMod = new System.Windows.Forms.TextBox();
            this.txtApellidosMod = new System.Windows.Forms.TextBox();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.mskNumeroCedulaMod = new System.Windows.Forms.MaskedTextBox();
            this.lblFotoMod = new System.Windows.Forms.Label();
            this.lblActivoMod = new System.Windows.Forms.Label();
            this.lblSexoMod = new System.Windows.Forms.Label();
            this.lblCorreoMod = new System.Windows.Forms.Label();
            this.lblTelefonoMod = new System.Windows.Forms.Label();
            this.lblApellidosMod = new System.Windows.Forms.Label();
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.lblNumeroCedulaMod = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.ofDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajeros)).BeginInit();
            this.gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.gbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMensajeros
            // 
            this.dgvMensajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDMensajero,
            this.clmNombre,
            this.clmApelldos,
            this.clmSexo,
            this.clmFoto,
            this.clmCorreoElectronico,
            this.clmActivo,
            this.clmTelefono});
            this.dgvMensajeros.Location = new System.Drawing.Point(39, 192);
            this.dgvMensajeros.Name = "dgvMensajeros";
            this.dgvMensajeros.RowTemplate.Height = 24;
            this.dgvMensajeros.Size = new System.Drawing.Size(548, 466);
            this.dgvMensajeros.TabIndex = 0;
            this.dgvMensajeros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMensajeros_CellDoubleClick);
            // 
            // clmIDMensajero
            // 
            this.clmIDMensajero.DataPropertyName = "IDMensajero";
            this.clmIDMensajero.HeaderText = "IDMensajero";
            this.clmIDMensajero.Name = "clmIDMensajero";
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmApelldos
            // 
            this.clmApelldos.DataPropertyName = "Apellidos";
            this.clmApelldos.HeaderText = "Apellidos";
            this.clmApelldos.Name = "clmApelldos";
            // 
            // clmSexo
            // 
            this.clmSexo.DataPropertyName = "Sexo";
            this.clmSexo.HeaderText = "Sexo";
            this.clmSexo.Name = "clmSexo";
            // 
            // clmFoto
            // 
            this.clmFoto.DataPropertyName = "Foto";
            this.clmFoto.HeaderText = "Foto";
            this.clmFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmFoto.Name = "clmFoto";
            // 
            // clmCorreoElectronico
            // 
            this.clmCorreoElectronico.DataPropertyName = "Correo";
            this.clmCorreoElectronico.HeaderText = "Correo";
            this.clmCorreoElectronico.Name = "clmCorreoElectronico";
            this.clmCorreoElectronico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCorreoElectronico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmActivo
            // 
            this.clmActivo.DataPropertyName = "Activo";
            this.clmActivo.HeaderText = "Activo";
            this.clmActivo.Name = "clmActivo";
            this.clmActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmTelefono
            // 
            this.clmTelefono.DataPropertyName = "Telefono";
            this.clmTelefono.HeaderText = "Telefono";
            this.clmTelefono.Name = "clmTelefono";
            // 
            // gbAgregar
            // 
            this.gbAgregar.BackColor = System.Drawing.Color.Transparent;
            this.gbAgregar.Controls.Add(this.mskTelefono);
            this.gbAgregar.Controls.Add(this.chkSexoMIn);
            this.gbAgregar.Controls.Add(this.chkSexoFIn);
            this.gbAgregar.Controls.Add(this.btnInsertar);
            this.gbAgregar.Controls.Add(this.ptbFoto);
            this.gbAgregar.Controls.Add(this.btnSeleccionar);
            this.gbAgregar.Controls.Add(this.rbActivoNo);
            this.gbAgregar.Controls.Add(this.rbActivoSi);
            this.gbAgregar.Controls.Add(this.txtCorreo);
            this.gbAgregar.Controls.Add(this.txtApellidos);
            this.gbAgregar.Controls.Add(this.txtNombre);
            this.gbAgregar.Controls.Add(this.mskNumeroCedula);
            this.gbAgregar.Controls.Add(this.lblFoto);
            this.gbAgregar.Controls.Add(this.lblActivo);
            this.gbAgregar.Controls.Add(this.lblSexo);
            this.gbAgregar.Controls.Add(this.lblCorreo);
            this.gbAgregar.Controls.Add(this.lblTelefono);
            this.gbAgregar.Controls.Add(this.lblApellidos);
            this.gbAgregar.Controls.Add(this.lblNombre);
            this.gbAgregar.Controls.Add(this.lblNumeroCedula);
            this.gbAgregar.ForeColor = System.Drawing.Color.White;
            this.gbAgregar.Location = new System.Drawing.Point(614, 192);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(328, 518);
            this.gbAgregar.TabIndex = 1;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(167, 172);
            this.mskTelefono.Mask = "99999999";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(139, 22);
            this.mskTelefono.TabIndex = 33;
            // 
            // chkSexoMIn
            // 
            this.chkSexoMIn.AutoSize = true;
            this.chkSexoMIn.Location = new System.Drawing.Point(246, 264);
            this.chkSexoMIn.Name = "chkSexoMIn";
            this.chkSexoMIn.Size = new System.Drawing.Size(41, 21);
            this.chkSexoMIn.TabIndex = 32;
            this.chkSexoMIn.Text = "M";
            this.chkSexoMIn.UseVisualStyleBackColor = true;
            this.chkSexoMIn.CheckedChanged += new System.EventHandler(this.chkSexoMIn_CheckedChanged);
            // 
            // chkSexoFIn
            // 
            this.chkSexoFIn.AutoSize = true;
            this.chkSexoFIn.Location = new System.Drawing.Point(167, 266);
            this.chkSexoFIn.Name = "chkSexoFIn";
            this.chkSexoFIn.Size = new System.Drawing.Size(38, 21);
            this.chkSexoFIn.TabIndex = 31;
            this.chkSexoFIn.Text = "F";
            this.chkSexoFIn.UseVisualStyleBackColor = true;
            this.chkSexoFIn.CheckedChanged += new System.EventHandler(this.chkSexoFIn_CheckedChanged);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.Black;
            this.btnInsertar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_agregar_archivo_26;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(22, 442);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(117, 53);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // ptbFoto
            // 
            this.ptbFoto.Location = new System.Drawing.Point(166, 392);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(128, 105);
            this.ptbFoto.TabIndex = 18;
            this.ptbFoto.TabStop = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionar.Location = new System.Drawing.Point(166, 354);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(128, 32);
            this.btnSeleccionar.TabIndex = 17;
            this.btnSeleccionar.Text = "Seleccionar...";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // rbActivoNo
            // 
            this.rbActivoNo.AutoSize = true;
            this.rbActivoNo.Location = new System.Drawing.Point(246, 308);
            this.rbActivoNo.Name = "rbActivoNo";
            this.rbActivoNo.Size = new System.Drawing.Size(47, 21);
            this.rbActivoNo.TabIndex = 16;
            this.rbActivoNo.TabStop = true;
            this.rbActivoNo.Text = "No";
            this.rbActivoNo.UseVisualStyleBackColor = true;
            // 
            // rbActivoSi
            // 
            this.rbActivoSi.AutoSize = true;
            this.rbActivoSi.Location = new System.Drawing.Point(166, 312);
            this.rbActivoSi.Name = "rbActivoSi";
            this.rbActivoSi.Size = new System.Drawing.Size(41, 21);
            this.rbActivoSi.TabIndex = 15;
            this.rbActivoSi.TabStop = true;
            this.rbActivoSi.Text = "Si";
            this.rbActivoSi.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(166, 221);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(140, 22);
            this.txtCorreo.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(166, 129);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(140, 22);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // mskNumeroCedula
            // 
            this.mskNumeroCedula.Location = new System.Drawing.Point(166, 34);
            this.mskNumeroCedula.Mask = "0-0000-0000";
            this.mskNumeroCedula.Name = "mskNumeroCedula";
            this.mskNumeroCedula.Size = new System.Drawing.Size(140, 22);
            this.mskNumeroCedula.TabIndex = 8;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(24, 352);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(36, 17);
            this.lblFoto.TabIndex = 7;
            this.lblFoto.Text = "Foto";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(24, 310);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(46, 17);
            this.lblActivo.TabIndex = 6;
            this.lblActivo.Text = "Activo";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(24, 265);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 17);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(24, 219);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(24, 175);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(24, 127);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumeroCedula
            // 
            this.lblNumeroCedula.AutoSize = true;
            this.lblNumeroCedula.Location = new System.Drawing.Point(24, 32);
            this.lblNumeroCedula.Name = "lblNumeroCedula";
            this.lblNumeroCedula.Size = new System.Drawing.Size(106, 17);
            this.lblNumeroCedula.TabIndex = 0;
            this.lblNumeroCedula.Text = "Número Cédula";
            // 
            // gbModificar
            // 
            this.gbModificar.BackColor = System.Drawing.Color.Transparent;
            this.gbModificar.Controls.Add(this.mskTelefonoMod);
            this.gbModificar.Controls.Add(this.chkSexoM);
            this.gbModificar.Controls.Add(this.chkSexoF);
            this.gbModificar.Controls.Add(this.btnModificar);
            this.gbModificar.Controls.Add(this.pctFotoMod);
            this.gbModificar.Controls.Add(this.btnSeleccionarFotoMod);
            this.gbModificar.Controls.Add(this.rbActivoNoMod);
            this.gbModificar.Controls.Add(this.rbActivoSiMod);
            this.gbModificar.Controls.Add(this.txtCorreoMod);
            this.gbModificar.Controls.Add(this.txtApellidosMod);
            this.gbModificar.Controls.Add(this.txtNombreMod);
            this.gbModificar.Controls.Add(this.mskNumeroCedulaMod);
            this.gbModificar.Controls.Add(this.lblFotoMod);
            this.gbModificar.Controls.Add(this.lblActivoMod);
            this.gbModificar.Controls.Add(this.lblSexoMod);
            this.gbModificar.Controls.Add(this.lblCorreoMod);
            this.gbModificar.Controls.Add(this.lblTelefonoMod);
            this.gbModificar.Controls.Add(this.lblApellidosMod);
            this.gbModificar.Controls.Add(this.lblNombreMod);
            this.gbModificar.Controls.Add(this.lblNumeroCedulaMod);
            this.gbModificar.ForeColor = System.Drawing.Color.White;
            this.gbModificar.Location = new System.Drawing.Point(984, 192);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(340, 518);
            this.gbModificar.TabIndex = 2;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar";
            // 
            // mskTelefonoMod
            // 
            this.mskTelefonoMod.Location = new System.Drawing.Point(175, 177);
            this.mskTelefonoMod.Mask = "99999999";
            this.mskTelefonoMod.Name = "mskTelefonoMod";
            this.mskTelefonoMod.Size = new System.Drawing.Size(143, 22);
            this.mskTelefonoMod.TabIndex = 31;
            // 
            // chkSexoM
            // 
            this.chkSexoM.AutoSize = true;
            this.chkSexoM.Location = new System.Drawing.Point(265, 270);
            this.chkSexoM.Name = "chkSexoM";
            this.chkSexoM.Size = new System.Drawing.Size(41, 21);
            this.chkSexoM.TabIndex = 30;
            this.chkSexoM.Text = "M";
            this.chkSexoM.UseVisualStyleBackColor = true;
            this.chkSexoM.CheckedChanged += new System.EventHandler(this.chkSexoM_CheckedChanged);
            // 
            // chkSexoF
            // 
            this.chkSexoF.AutoSize = true;
            this.chkSexoF.Location = new System.Drawing.Point(175, 270);
            this.chkSexoF.Name = "chkSexoF";
            this.chkSexoF.Size = new System.Drawing.Size(38, 21);
            this.chkSexoF.TabIndex = 29;
            this.chkSexoF.Text = "F";
            this.chkSexoF.UseVisualStyleBackColor = true;
            this.chkSexoF.CheckedChanged += new System.EventHandler(this.chkSexoF_CheckedChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_editar_propiedad_26;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(25, 442);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(127, 53);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pctFotoMod
            // 
            this.pctFotoMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFotoMod.Location = new System.Drawing.Point(178, 386);
            this.pctFotoMod.Name = "pctFotoMod";
            this.pctFotoMod.Size = new System.Drawing.Size(128, 109);
            this.pctFotoMod.TabIndex = 27;
            this.pctFotoMod.TabStop = false;
            // 
            // btnSeleccionarFotoMod
            // 
            this.btnSeleccionarFotoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarFotoMod.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionarFotoMod.Location = new System.Drawing.Point(178, 348);
            this.btnSeleccionarFotoMod.Name = "btnSeleccionarFotoMod";
            this.btnSeleccionarFotoMod.Size = new System.Drawing.Size(128, 32);
            this.btnSeleccionarFotoMod.TabIndex = 26;
            this.btnSeleccionarFotoMod.Text = "Seleccionar...";
            this.btnSeleccionarFotoMod.UseVisualStyleBackColor = true;
            this.btnSeleccionarFotoMod.Click += new System.EventHandler(this.btnSeleccionarFotoMod_Click);
            // 
            // rbActivoNoMod
            // 
            this.rbActivoNoMod.AutoSize = true;
            this.rbActivoNoMod.Location = new System.Drawing.Point(266, 313);
            this.rbActivoNoMod.Name = "rbActivoNoMod";
            this.rbActivoNoMod.Size = new System.Drawing.Size(47, 21);
            this.rbActivoNoMod.TabIndex = 25;
            this.rbActivoNoMod.TabStop = true;
            this.rbActivoNoMod.Text = "No";
            this.rbActivoNoMod.UseVisualStyleBackColor = true;
            // 
            // rbActivoSiMod
            // 
            this.rbActivoSiMod.AutoSize = true;
            this.rbActivoSiMod.Location = new System.Drawing.Point(175, 315);
            this.rbActivoSiMod.Name = "rbActivoSiMod";
            this.rbActivoSiMod.Size = new System.Drawing.Size(41, 21);
            this.rbActivoSiMod.TabIndex = 24;
            this.rbActivoSiMod.TabStop = true;
            this.rbActivoSiMod.Text = "Si";
            this.rbActivoSiMod.UseVisualStyleBackColor = true;
            // 
            // txtCorreoMod
            // 
            this.txtCorreoMod.Location = new System.Drawing.Point(178, 224);
            this.txtCorreoMod.Name = "txtCorreoMod";
            this.txtCorreoMod.Size = new System.Drawing.Size(140, 22);
            this.txtCorreoMod.TabIndex = 21;
            // 
            // txtApellidosMod
            // 
            this.txtApellidosMod.Location = new System.Drawing.Point(178, 132);
            this.txtApellidosMod.Name = "txtApellidosMod";
            this.txtApellidosMod.Size = new System.Drawing.Size(140, 22);
            this.txtApellidosMod.TabIndex = 19;
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(178, 85);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(140, 22);
            this.txtNombreMod.TabIndex = 18;
            // 
            // mskNumeroCedulaMod
            // 
            this.mskNumeroCedulaMod.Enabled = false;
            this.mskNumeroCedulaMod.Location = new System.Drawing.Point(178, 37);
            this.mskNumeroCedulaMod.Mask = "0-0000-0000";
            this.mskNumeroCedulaMod.Name = "mskNumeroCedulaMod";
            this.mskNumeroCedulaMod.Size = new System.Drawing.Size(140, 22);
            this.mskNumeroCedulaMod.TabIndex = 17;
            // 
            // lblFotoMod
            // 
            this.lblFotoMod.AutoSize = true;
            this.lblFotoMod.Location = new System.Drawing.Point(22, 357);
            this.lblFotoMod.Name = "lblFotoMod";
            this.lblFotoMod.Size = new System.Drawing.Size(36, 17);
            this.lblFotoMod.TabIndex = 15;
            this.lblFotoMod.Text = "Foto";
            // 
            // lblActivoMod
            // 
            this.lblActivoMod.AutoSize = true;
            this.lblActivoMod.Location = new System.Drawing.Point(22, 315);
            this.lblActivoMod.Name = "lblActivoMod";
            this.lblActivoMod.Size = new System.Drawing.Size(46, 17);
            this.lblActivoMod.TabIndex = 14;
            this.lblActivoMod.Text = "Activo";
            // 
            // lblSexoMod
            // 
            this.lblSexoMod.AutoSize = true;
            this.lblSexoMod.Location = new System.Drawing.Point(22, 270);
            this.lblSexoMod.Name = "lblSexoMod";
            this.lblSexoMod.Size = new System.Drawing.Size(39, 17);
            this.lblSexoMod.TabIndex = 13;
            this.lblSexoMod.Text = "Sexo";
            // 
            // lblCorreoMod
            // 
            this.lblCorreoMod.AutoSize = true;
            this.lblCorreoMod.Location = new System.Drawing.Point(22, 224);
            this.lblCorreoMod.Name = "lblCorreoMod";
            this.lblCorreoMod.Size = new System.Drawing.Size(51, 17);
            this.lblCorreoMod.TabIndex = 12;
            this.lblCorreoMod.Text = "Correo";
            // 
            // lblTelefonoMod
            // 
            this.lblTelefonoMod.AutoSize = true;
            this.lblTelefonoMod.Location = new System.Drawing.Point(22, 180);
            this.lblTelefonoMod.Name = "lblTelefonoMod";
            this.lblTelefonoMod.Size = new System.Drawing.Size(64, 17);
            this.lblTelefonoMod.TabIndex = 11;
            this.lblTelefonoMod.Text = "Telefono";
            // 
            // lblApellidosMod
            // 
            this.lblApellidosMod.AutoSize = true;
            this.lblApellidosMod.Location = new System.Drawing.Point(22, 132);
            this.lblApellidosMod.Name = "lblApellidosMod";
            this.lblApellidosMod.Size = new System.Drawing.Size(65, 17);
            this.lblApellidosMod.TabIndex = 10;
            this.lblApellidosMod.Text = "Apellidos";
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.Location = new System.Drawing.Point(22, 85);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(58, 17);
            this.lblNombreMod.TabIndex = 9;
            this.lblNombreMod.Text = "Nombre";
            // 
            // lblNumeroCedulaMod
            // 
            this.lblNumeroCedulaMod.AutoSize = true;
            this.lblNumeroCedulaMod.Location = new System.Drawing.Point(22, 37);
            this.lblNumeroCedulaMod.Name = "lblNumeroCedulaMod";
            this.lblNumeroCedulaMod.Size = new System.Drawing.Size(106, 17);
            this.lblNumeroCedulaMod.TabIndex = 8;
            this.lblNumeroCedulaMod.Text = "Número Cédula";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_eliminar_26;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(39, 674);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(548, 36);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_actualizar_filled_50;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(315, 768);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(246, 75);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.SalirPequena1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(902, 768);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(246, 75);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncabezado.Font = new System.Drawing.Font("Open Sans Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(491, 52);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(342, 82);
            this.lblEncabezado.TabIndex = 6;
            this.lblEncabezado.Text = "Mensajero";
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // frmMantenimientoMensajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1371, 898);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.dgvMensajeros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantenimientoMensajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoMensajero";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmMantenimientoMensajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajeros)).EndInit();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMensajeros;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumeroCedula;
        private System.Windows.Forms.RadioButton rbActivoNo;
        private System.Windows.Forms.RadioButton rbActivoSi;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mskNumeroCedula;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.OpenFileDialog ofDialogFoto;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pctFotoMod;
        private System.Windows.Forms.Button btnSeleccionarFotoMod;
        private System.Windows.Forms.RadioButton rbActivoNoMod;
        private System.Windows.Forms.RadioButton rbActivoSiMod;
        private System.Windows.Forms.TextBox txtCorreoMod;
        private System.Windows.Forms.TextBox txtApellidosMod;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.MaskedTextBox mskNumeroCedulaMod;
        private System.Windows.Forms.Label lblFotoMod;
        private System.Windows.Forms.Label lblActivoMod;
        private System.Windows.Forms.Label lblSexoMod;
        private System.Windows.Forms.Label lblCorreoMod;
        private System.Windows.Forms.Label lblTelefonoMod;
        private System.Windows.Forms.Label lblApellidosMod;
        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.Label lblNumeroCedulaMod;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.CheckBox chkSexoM;
        private System.Windows.Forms.CheckBox chkSexoF;
        private System.Windows.Forms.CheckBox chkSexoMIn;
        private System.Windows.Forms.CheckBox chkSexoFIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDMensajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApelldos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSexo;
        private System.Windows.Forms.DataGridViewImageColumn clmFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.MaskedTextBox mskTelefonoMod;
    }
}