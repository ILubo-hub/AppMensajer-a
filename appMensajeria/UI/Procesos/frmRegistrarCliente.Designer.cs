namespace UTN.Mensajeria.Winform.UI.Procesos
{
    partial class frmRegistrarCliente
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clmIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEcabezado = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
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
            this.gbAgregar.Location = new System.Drawing.Point(713, 213);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(311, 497);
            this.gbAgregar.TabIndex = 3;
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
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_agregar_archivo_26;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(19, 437);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 42);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.dgvClientes.Location = new System.Drawing.Point(72, 213);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(548, 497);
            this.dgvClientes.TabIndex = 4;
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
            // lblEcabezado
            // 
            this.lblEcabezado.AutoSize = true;
            this.lblEcabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEcabezado.Font = new System.Drawing.Font("Open Sans Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcabezado.ForeColor = System.Drawing.Color.White;
            this.lblEcabezado.Location = new System.Drawing.Point(278, 57);
            this.lblEcabezado.Name = "lblEcabezado";
            this.lblEcabezado.Size = new System.Drawing.Size(518, 82);
            this.lblEcabezado.TabIndex = 5;
            this.lblEcabezado.Text = "Registrar Cliente";
            // 
            // btnListo
            // 
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_actualizar_filled_50;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(240, 759);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(232, 68);
            this.btnListo.TabIndex = 6;
            this.btnListo.Text = "Actualizar";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_salir_redondeado_filled_50;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(741, 759);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(231, 68);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // frmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 874);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblEcabezado);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gbAgregar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarCliente";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmRegistrarCliente_Load);
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.RichTextBox rctDireccion;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.RadioButton rbActivoNo;
        private System.Windows.Forms.RadioButton rbActivoSi;
        private System.Windows.Forms.MaskedTextBox mskNumeroCedula;
        private System.Windows.Forms.Label lblNumeroCedula;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProvincia;
        private System.Windows.Forms.Label lblEcabezado;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider erpErrores;
    }
}