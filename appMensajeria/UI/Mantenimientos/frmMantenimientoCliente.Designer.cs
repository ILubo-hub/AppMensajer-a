namespace UTN.Mensajeria.Winform.UI.Mantenimientos
{
    partial class frmMantenimientoCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clmIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.rctDireccion = new System.Windows.Forms.RichTextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.rbActivoNo = new System.Windows.Forms.RadioButton();
            this.rbActivoSi = new System.Windows.Forms.RadioButton();
            this.mskNumeroCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroCedula = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.mskTelefonoMod = new System.Windows.Forms.MaskedTextBox();
            this.rctDireccionMod = new System.Windows.Forms.RichTextBox();
            this.lblActivoMod = new System.Windows.Forms.Label();
            this.rbActivoNoMod = new System.Windows.Forms.RadioButton();
            this.rbActivoSiMod = new System.Windows.Forms.RadioButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCorreoMod = new System.Windows.Forms.TextBox();
            this.mskNumeroCedulaMod = new System.Windows.Forms.MaskedTextBox();
            this.cboProvinciasMod = new System.Windows.Forms.ComboBox();
            this.lblNumeroCedulaMod = new System.Windows.Forms.Label();
            this.lblDireccionMod = new System.Windows.Forms.Label();
            this.lblProvinciaMod = new System.Windows.Forms.Label();
            this.lblCorreoMod = new System.Windows.Forms.Label();
            this.lblTelefonoMod = new System.Windows.Forms.Label();
            this.lblApellidosMod = new System.Windows.Forms.Label();
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbAgregar.SuspendLayout();
            this.gbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDCliente,
            this.clmNombre,
            this.clmApellidos,
            this.clmCorreo,
            this.clmActivo,
            this.clmTelefono,
            this.clmDireccion,
            this.clmProvincia});
            this.dgvClientes.Location = new System.Drawing.Point(32, 202);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(548, 455);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // clmIDCliente
            // 
            this.clmIDCliente.DataPropertyName = "IDCliente";
            this.clmIDCliente.HeaderText = "Id";
            this.clmIDCliente.Name = "clmIDCliente";
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmApellidos
            // 
            this.clmApellidos.DataPropertyName = "Apellidos";
            this.clmApellidos.HeaderText = "Apellidos";
            this.clmApellidos.Name = "clmApellidos";
            // 
            // clmCorreo
            // 
            this.clmCorreo.DataPropertyName = "CorreoElectronico";
            this.clmCorreo.HeaderText = "Correo";
            this.clmCorreo.Name = "clmCorreo";
            // 
            // clmActivo
            // 
            this.clmActivo.DataPropertyName = "Activo";
            this.clmActivo.HeaderText = "Activo";
            this.clmActivo.Name = "clmActivo";
            // 
            // clmTelefono
            // 
            this.clmTelefono.DataPropertyName = "Telefono";
            this.clmTelefono.HeaderText = "Telefono";
            this.clmTelefono.Name = "clmTelefono";
            // 
            // clmDireccion
            // 
            this.clmDireccion.DataPropertyName = "Direccion";
            this.clmDireccion.HeaderText = "Direccion";
            this.clmDireccion.Name = "clmDireccion";
            // 
            // clmProvincia
            // 
            this.clmProvincia.DataPropertyName = "Provincia";
            this.clmProvincia.HeaderText = "Provincia";
            this.clmProvincia.Name = "clmProvincia";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_agregar_archivo_26;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(19, 437);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(162, 49);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbAgregar
            // 
            this.gbAgregar.BackColor = System.Drawing.Color.Transparent;
            this.gbAgregar.Controls.Add(this.txtApellido);
            this.gbAgregar.Controls.Add(this.txtNombre);
            this.gbAgregar.Controls.Add(this.txtCorreo);
            this.gbAgregar.Controls.Add(this.mskTelefono);
            this.gbAgregar.Controls.Add(this.rctDireccion);
            this.gbAgregar.Controls.Add(this.lblActivo);
            this.gbAgregar.Controls.Add(this.rbActivoNo);
            this.gbAgregar.Controls.Add(this.rbActivoSi);
            this.gbAgregar.Controls.Add(this.mskNumeroCedula);
            this.gbAgregar.Controls.Add(this.lblNumeroCedula);
            this.gbAgregar.Controls.Add(this.lblDireccion);
            this.gbAgregar.Controls.Add(this.lblProvincia);
            this.gbAgregar.Controls.Add(this.cboProvincia);
            this.gbAgregar.Controls.Add(this.lblCorreo);
            this.gbAgregar.Controls.Add(this.lblTelefono);
            this.gbAgregar.Controls.Add(this.lblApellidos);
            this.gbAgregar.Controls.Add(this.lblNombre);
            this.gbAgregar.Controls.Add(this.btnAgregar);
            this.gbAgregar.ForeColor = System.Drawing.Color.White;
            this.gbAgregar.Location = new System.Drawing.Point(618, 202);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(311, 510);
            this.gbAgregar.TabIndex = 2;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(148, 112);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 22);
            this.txtApellido.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 26;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(148, 201);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(132, 22);
            this.txtCorreo.TabIndex = 25;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(148, 159);
            this.mskTelefono.Mask = "00000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(132, 22);
            this.mskTelefono.TabIndex = 23;
            // 
            // rctDireccion
            // 
            this.rctDireccion.Location = new System.Drawing.Point(121, 302);
            this.rctDireccion.Name = "rctDireccion";
            this.rctDireccion.Size = new System.Drawing.Size(159, 84);
            this.rctDireccion.TabIndex = 20;
            this.rctDireccion.Text = "";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(25, 396);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(46, 17);
            this.lblActivo.TabIndex = 18;
            this.lblActivo.Text = "Activo";
            // 
            // rbActivoNo
            // 
            this.rbActivoNo.AutoSize = true;
            this.rbActivoNo.Location = new System.Drawing.Point(228, 396);
            this.rbActivoNo.Name = "rbActivoNo";
            this.rbActivoNo.Size = new System.Drawing.Size(47, 21);
            this.rbActivoNo.TabIndex = 17;
            this.rbActivoNo.TabStop = true;
            this.rbActivoNo.Text = "No";
            this.rbActivoNo.UseVisualStyleBackColor = true;
            // 
            // rbActivoSi
            // 
            this.rbActivoSi.AutoSize = true;
            this.rbActivoSi.Location = new System.Drawing.Point(121, 396);
            this.rbActivoSi.Name = "rbActivoSi";
            this.rbActivoSi.Size = new System.Drawing.Size(41, 21);
            this.rbActivoSi.TabIndex = 16;
            this.rbActivoSi.TabStop = true;
            this.rbActivoSi.Text = "Si";
            this.rbActivoSi.UseVisualStyleBackColor = true;
            // 
            // mskNumeroCedula
            // 
            this.mskNumeroCedula.Location = new System.Drawing.Point(148, 40);
            this.mskNumeroCedula.Mask = "0-0000-0000";
            this.mskNumeroCedula.Name = "mskNumeroCedula";
            this.mskNumeroCedula.Size = new System.Drawing.Size(132, 22);
            this.mskNumeroCedula.TabIndex = 11;
            // 
            // lblNumeroCedula
            // 
            this.lblNumeroCedula.AutoSize = true;
            this.lblNumeroCedula.ForeColor = System.Drawing.Color.White;
            this.lblNumeroCedula.Location = new System.Drawing.Point(25, 40);
            this.lblNumeroCedula.Name = "lblNumeroCedula";
            this.lblNumeroCedula.Size = new System.Drawing.Size(106, 17);
            this.lblNumeroCedula.TabIndex = 10;
            this.lblNumeroCedula.Text = "Número Cédula";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(25, 302);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.ForeColor = System.Drawing.Color.White;
            this.lblProvincia.Location = new System.Drawing.Point(25, 251);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(66, 17);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "Provincia";
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(126, 251);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(154, 24);
            this.cboProvincia.TabIndex = 6;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(25, 201);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(25, 159);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(25, 112);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(25, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // gbModificar
            // 
            this.gbModificar.BackColor = System.Drawing.Color.Transparent;
            this.gbModificar.Controls.Add(this.txtApellidoMod);
            this.gbModificar.Controls.Add(this.txtNombreMod);
            this.gbModificar.Controls.Add(this.mskTelefonoMod);
            this.gbModificar.Controls.Add(this.rctDireccionMod);
            this.gbModificar.Controls.Add(this.lblActivoMod);
            this.gbModificar.Controls.Add(this.rbActivoNoMod);
            this.gbModificar.Controls.Add(this.rbActivoSiMod);
            this.gbModificar.Controls.Add(this.btnModificar);
            this.gbModificar.Controls.Add(this.txtCorreoMod);
            this.gbModificar.Controls.Add(this.mskNumeroCedulaMod);
            this.gbModificar.Controls.Add(this.cboProvinciasMod);
            this.gbModificar.Controls.Add(this.lblNumeroCedulaMod);
            this.gbModificar.Controls.Add(this.lblDireccionMod);
            this.gbModificar.Controls.Add(this.lblProvinciaMod);
            this.gbModificar.Controls.Add(this.lblCorreoMod);
            this.gbModificar.Controls.Add(this.lblTelefonoMod);
            this.gbModificar.Controls.Add(this.lblApellidosMod);
            this.gbModificar.Controls.Add(this.lblNombreMod);
            this.gbModificar.ForeColor = System.Drawing.Color.White;
            this.gbModificar.Location = new System.Drawing.Point(989, 202);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(322, 510);
            this.gbModificar.TabIndex = 3;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar";
            this.gbModificar.Enter += new System.EventHandler(this.gbModificar_Enter);
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Location = new System.Drawing.Point(163, 108);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(132, 22);
            this.txtApellidoMod.TabIndex = 34;
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(163, 71);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(132, 22);
            this.txtNombreMod.TabIndex = 33;
            // 
            // mskTelefonoMod
            // 
            this.mskTelefonoMod.Location = new System.Drawing.Point(163, 156);
            this.mskTelefonoMod.Mask = "00000000";
            this.mskTelefonoMod.Name = "mskTelefonoMod";
            this.mskTelefonoMod.Size = new System.Drawing.Size(132, 22);
            this.mskTelefonoMod.TabIndex = 32;
            // 
            // rctDireccionMod
            // 
            this.rctDireccionMod.Location = new System.Drawing.Point(141, 290);
            this.rctDireccionMod.Name = "rctDireccionMod";
            this.rctDireccionMod.Size = new System.Drawing.Size(159, 84);
            this.rctDireccionMod.TabIndex = 29;
            this.rctDireccionMod.Text = "";
            // 
            // lblActivoMod
            // 
            this.lblActivoMod.AutoSize = true;
            this.lblActivoMod.Location = new System.Drawing.Point(26, 387);
            this.lblActivoMod.Name = "lblActivoMod";
            this.lblActivoMod.Size = new System.Drawing.Size(46, 17);
            this.lblActivoMod.TabIndex = 28;
            this.lblActivoMod.Text = "Activo";
            // 
            // rbActivoNoMod
            // 
            this.rbActivoNoMod.AutoSize = true;
            this.rbActivoNoMod.Location = new System.Drawing.Point(232, 387);
            this.rbActivoNoMod.Name = "rbActivoNoMod";
            this.rbActivoNoMod.Size = new System.Drawing.Size(47, 21);
            this.rbActivoNoMod.TabIndex = 27;
            this.rbActivoNoMod.TabStop = true;
            this.rbActivoNoMod.Text = "No";
            this.rbActivoNoMod.UseVisualStyleBackColor = true;
            // 
            // rbActivoSiMod
            // 
            this.rbActivoSiMod.AutoSize = true;
            this.rbActivoSiMod.Location = new System.Drawing.Point(141, 387);
            this.rbActivoSiMod.Name = "rbActivoSiMod";
            this.rbActivoSiMod.Size = new System.Drawing.Size(41, 21);
            this.rbActivoSiMod.TabIndex = 26;
            this.rbActivoSiMod.TabStop = true;
            this.rbActivoSiMod.Text = "Si";
            this.rbActivoSiMod.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_editar_propiedad_26;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(29, 437);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(157, 49);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCorreoMod
            // 
            this.txtCorreoMod.Location = new System.Drawing.Point(163, 197);
            this.txtCorreoMod.Name = "txtCorreoMod";
            this.txtCorreoMod.Size = new System.Drawing.Size(132, 22);
            this.txtCorreoMod.TabIndex = 24;
            // 
            // mskNumeroCedulaMod
            // 
            this.mskNumeroCedulaMod.Enabled = false;
            this.mskNumeroCedulaMod.Location = new System.Drawing.Point(163, 36);
            this.mskNumeroCedulaMod.Mask = "0-0000-0000";
            this.mskNumeroCedulaMod.Name = "mskNumeroCedulaMod";
            this.mskNumeroCedulaMod.Size = new System.Drawing.Size(132, 22);
            this.mskNumeroCedulaMod.TabIndex = 20;
            // 
            // cboProvinciasMod
            // 
            this.cboProvinciasMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinciasMod.FormattingEnabled = true;
            this.cboProvinciasMod.Location = new System.Drawing.Point(141, 247);
            this.cboProvinciasMod.Name = "cboProvinciasMod";
            this.cboProvinciasMod.Size = new System.Drawing.Size(154, 24);
            this.cboProvinciasMod.TabIndex = 18;
            // 
            // lblNumeroCedulaMod
            // 
            this.lblNumeroCedulaMod.AutoSize = true;
            this.lblNumeroCedulaMod.ForeColor = System.Drawing.Color.White;
            this.lblNumeroCedulaMod.Location = new System.Drawing.Point(26, 36);
            this.lblNumeroCedulaMod.Name = "lblNumeroCedulaMod";
            this.lblNumeroCedulaMod.Size = new System.Drawing.Size(106, 17);
            this.lblNumeroCedulaMod.TabIndex = 17;
            this.lblNumeroCedulaMod.Text = "Número Cédula";
            // 
            // lblDireccionMod
            // 
            this.lblDireccionMod.AutoSize = true;
            this.lblDireccionMod.ForeColor = System.Drawing.Color.White;
            this.lblDireccionMod.Location = new System.Drawing.Point(26, 298);
            this.lblDireccionMod.Name = "lblDireccionMod";
            this.lblDireccionMod.Size = new System.Drawing.Size(67, 17);
            this.lblDireccionMod.TabIndex = 16;
            this.lblDireccionMod.Text = "Dirección";
            // 
            // lblProvinciaMod
            // 
            this.lblProvinciaMod.AutoSize = true;
            this.lblProvinciaMod.ForeColor = System.Drawing.Color.White;
            this.lblProvinciaMod.Location = new System.Drawing.Point(26, 247);
            this.lblProvinciaMod.Name = "lblProvinciaMod";
            this.lblProvinciaMod.Size = new System.Drawing.Size(66, 17);
            this.lblProvinciaMod.TabIndex = 15;
            this.lblProvinciaMod.Text = "Provincia";
            // 
            // lblCorreoMod
            // 
            this.lblCorreoMod.AutoSize = true;
            this.lblCorreoMod.ForeColor = System.Drawing.Color.White;
            this.lblCorreoMod.Location = new System.Drawing.Point(26, 197);
            this.lblCorreoMod.Name = "lblCorreoMod";
            this.lblCorreoMod.Size = new System.Drawing.Size(51, 17);
            this.lblCorreoMod.TabIndex = 14;
            this.lblCorreoMod.Text = "Correo";
            // 
            // lblTelefonoMod
            // 
            this.lblTelefonoMod.AutoSize = true;
            this.lblTelefonoMod.ForeColor = System.Drawing.Color.White;
            this.lblTelefonoMod.Location = new System.Drawing.Point(26, 155);
            this.lblTelefonoMod.Name = "lblTelefonoMod";
            this.lblTelefonoMod.Size = new System.Drawing.Size(64, 17);
            this.lblTelefonoMod.TabIndex = 13;
            this.lblTelefonoMod.Text = "Telefono";
            // 
            // lblApellidosMod
            // 
            this.lblApellidosMod.AutoSize = true;
            this.lblApellidosMod.ForeColor = System.Drawing.Color.White;
            this.lblApellidosMod.Location = new System.Drawing.Point(26, 108);
            this.lblApellidosMod.Name = "lblApellidosMod";
            this.lblApellidosMod.Size = new System.Drawing.Size(65, 17);
            this.lblApellidosMod.TabIndex = 12;
            this.lblApellidosMod.Text = "Apellidos";
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.ForeColor = System.Drawing.Color.White;
            this.lblNombreMod.Location = new System.Drawing.Point(26, 71);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(58, 17);
            this.lblNombreMod.TabIndex = 11;
            this.lblNombreMod.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_eliminar_26;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(32, 676);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(548, 36);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_actualizar_filled_50;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(270, 780);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(246, 75);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.SalirPequena1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(918, 780);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(246, 75);
            this.btnSalir.TabIndex = 6;
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
            this.lblEncabezado.Location = new System.Drawing.Point(512, 55);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(268, 82);
            this.lblEncabezado.TabIndex = 7;
            this.lblEncabezado.Text = "Clientes";
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // frmMantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 921);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.dgvClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoCliente";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmMantenimientoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mskNumeroCedula;
        private System.Windows.Forms.Label lblNumeroCedula;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCorreoMod;
        private System.Windows.Forms.MaskedTextBox mskNumeroCedulaMod;
        private System.Windows.Forms.ComboBox cboProvinciasMod;
        private System.Windows.Forms.Label lblNumeroCedulaMod;
        private System.Windows.Forms.Label lblDireccionMod;
        private System.Windows.Forms.Label lblProvinciaMod;
        private System.Windows.Forms.Label lblCorreoMod;
        private System.Windows.Forms.Label lblTelefonoMod;
        private System.Windows.Forms.Label lblApellidosMod;
        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.RadioButton rbActivoNo;
        private System.Windows.Forms.RadioButton rbActivoSi;
        private System.Windows.Forms.Label lblActivoMod;
        private System.Windows.Forms.RadioButton rbActivoNoMod;
        private System.Windows.Forms.RadioButton rbActivoSiMod;
        private System.Windows.Forms.RichTextBox rctDireccion;
        private System.Windows.Forms.RichTextBox rctDireccionMod;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.MaskedTextBox mskTelefonoMod;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProvincia;
    }
}