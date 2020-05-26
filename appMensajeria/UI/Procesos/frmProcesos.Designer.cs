namespace UTN.Mensajeria.Winform.UI.Procesos
{
    partial class frmProcesos
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
            this.gMapMapa = new GMap.NET.WindowsForms.GMapControl();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantidadPaquetes = new System.Windows.Forms.TextBox();
            this.lstUbicaciones = new System.Windows.Forms.ListBox();
            this.cboTipoEnvio = new System.Windows.Forms.ComboBox();
            this.lblTipoEnvio = new System.Windows.Forms.Label();
            this.lstPaquetes = new System.Windows.Forms.ListBox();
            this.lblDescripcionPaquete = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblDescripcioRuta = new System.Windows.Forms.Label();
            this.btnCalcularKilometros = new System.Windows.Forms.Button();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarPaquetes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoTarjeta = new System.Windows.Forms.Label();
            this.mskNoTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.btnBuscarMensajeros = new System.Windows.Forms.Button();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.txtNombreMensajero = new System.Windows.Forms.TextBox();
            this.txtIDMensajero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensajero = new System.Windows.Forms.Label();
            this.lblNoFactura = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lnklblSalir = new System.Windows.Forms.LinkLabel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapMapa
            // 
            this.gMapMapa.Bearing = 0F;
            this.gMapMapa.CanDragMap = true;
            this.gMapMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapMapa.GrayScaleMode = false;
            this.gMapMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapMapa.LevelsKeepInMemmory = 5;
            this.gMapMapa.Location = new System.Drawing.Point(770, 186);
            this.gMapMapa.MarkersEnabled = true;
            this.gMapMapa.MaxZoom = 2;
            this.gMapMapa.MinZoom = 2;
            this.gMapMapa.MouseWheelZoomEnabled = true;
            this.gMapMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapMapa.Name = "gMapMapa";
            this.gMapMapa.NegativeMode = false;
            this.gMapMapa.PolygonsEnabled = true;
            this.gMapMapa.RetryLoadTile = 0;
            this.gMapMapa.RoutesEnabled = true;
            this.gMapMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapMapa.ShowTileGridLines = false;
            this.gMapMapa.Size = new System.Drawing.Size(753, 505);
            this.gMapMapa.TabIndex = 0;
            this.gMapMapa.Zoom = 0D;
            this.gMapMapa.Load += new System.EventHandler(this.gMapMapa_Load);
            this.gMapMapa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapMapa_MouseDoubleClick);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncabezado.Font = new System.Drawing.Font("Open Sans Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(542, 35);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(500, 109);
            this.lblEncabezado.TabIndex = 2;
            this.lblEncabezado.Text = "Facturación";
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtCantidadPaquetes);
            this.groupBox1.Controls.Add(this.lstUbicaciones);
            this.groupBox1.Controls.Add(this.cboTipoEnvio);
            this.groupBox1.Controls.Add(this.lblTipoEnvio);
            this.groupBox1.Controls.Add(this.lstPaquetes);
            this.groupBox1.Controls.Add(this.lblDescripcionPaquete);
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.lblImpuesto);
            this.groupBox1.Controls.Add(this.lblDescripcioRuta);
            this.groupBox1.Controls.Add(this.btnCalcularKilometros);
            this.groupBox1.Controls.Add(this.txtKilometros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAgregarPaquetes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNoTarjeta);
            this.groupBox1.Controls.Add(this.mskNoTarjeta);
            this.groupBox1.Controls.Add(this.cboTipoTarjeta);
            this.groupBox1.Controls.Add(this.lblTipoTarjeta);
            this.groupBox1.Controls.Add(this.btnBuscarMensajeros);
            this.groupBox1.Controls.Add(this.txtNoFactura);
            this.groupBox1.Controls.Add(this.txtNombreMensajero);
            this.groupBox1.Controls.Add(this.txtIDMensajero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMensajero);
            this.groupBox1.Controls.Add(this.lblNoFactura);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(98, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 591);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_guardar_50;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(384, 510);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(193, 65);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantidadPaquetes
            // 
            this.txtCantidadPaquetes.Enabled = false;
            this.txtCantidadPaquetes.Location = new System.Drawing.Point(144, 301);
            this.txtCantidadPaquetes.Name = "txtCantidadPaquetes";
            this.txtCantidadPaquetes.Size = new System.Drawing.Size(200, 22);
            this.txtCantidadPaquetes.TabIndex = 26;
            // 
            // lstUbicaciones
            // 
            this.lstUbicaciones.FormattingEnabled = true;
            this.lstUbicaciones.ItemHeight = 16;
            this.lstUbicaciones.Location = new System.Drawing.Point(144, 453);
            this.lstUbicaciones.Name = "lstUbicaciones";
            this.lstUbicaciones.Size = new System.Drawing.Size(200, 52);
            this.lstUbicaciones.TabIndex = 25;
            // 
            // cboTipoEnvio
            // 
            this.cboTipoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEnvio.FormattingEnabled = true;
            this.cboTipoEnvio.Location = new System.Drawing.Point(144, 518);
            this.cboTipoEnvio.Name = "cboTipoEnvio";
            this.cboTipoEnvio.Size = new System.Drawing.Size(200, 24);
            this.cboTipoEnvio.TabIndex = 24;
            // 
            // lblTipoEnvio
            // 
            this.lblTipoEnvio.AutoSize = true;
            this.lblTipoEnvio.Location = new System.Drawing.Point(21, 518);
            this.lblTipoEnvio.Name = "lblTipoEnvio";
            this.lblTipoEnvio.Size = new System.Drawing.Size(75, 17);
            this.lblTipoEnvio.TabIndex = 23;
            this.lblTipoEnvio.Text = "Tipo Envio";
            // 
            // lstPaquetes
            // 
            this.lstPaquetes.FormattingEnabled = true;
            this.lstPaquetes.ItemHeight = 16;
            this.lstPaquetes.Location = new System.Drawing.Point(144, 343);
            this.lstPaquetes.Name = "lstPaquetes";
            this.lstPaquetes.Size = new System.Drawing.Size(200, 52);
            this.lstPaquetes.TabIndex = 22;
            // 
            // lblDescripcionPaquete
            // 
            this.lblDescripcionPaquete.AutoSize = true;
            this.lblDescripcionPaquete.Location = new System.Drawing.Point(21, 344);
            this.lblDescripcionPaquete.Name = "lblDescripcionPaquete";
            this.lblDescripcionPaquete.Size = new System.Drawing.Size(101, 17);
            this.lblDescripcionPaquete.TabIndex = 21;
            this.lblDescripcionPaquete.Text = "Desc. Paquete";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(144, 558);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(200, 22);
            this.txtImpuesto.TabIndex = 20;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(21, 558);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(65, 17);
            this.lblImpuesto.TabIndex = 19;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // lblDescripcioRuta
            // 
            this.lblDescripcioRuta.AutoSize = true;
            this.lblDescripcioRuta.Location = new System.Drawing.Point(21, 466);
            this.lblDescripcioRuta.Name = "lblDescripcioRuta";
            this.lblDescripcioRuta.Size = new System.Drawing.Size(78, 17);
            this.lblDescripcioRuta.TabIndex = 17;
            this.lblDescripcioRuta.Text = "Desc. Ruta";
            // 
            // btnCalcularKilometros
            // 
            this.btnCalcularKilometros.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularKilometros.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_calculadora_50;
            this.btnCalcularKilometros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularKilometros.Location = new System.Drawing.Point(384, 408);
            this.btnCalcularKilometros.Name = "btnCalcularKilometros";
            this.btnCalcularKilometros.Size = new System.Drawing.Size(193, 70);
            this.btnCalcularKilometros.TabIndex = 16;
            this.btnCalcularKilometros.Text = "Calcular";
            this.btnCalcularKilometros.UseVisualStyleBackColor = true;
            this.btnCalcularKilometros.Click += new System.EventHandler(this.btnCalcularKilometros_Click);
            // 
            // txtKilometros
            // 
            this.txtKilometros.Enabled = false;
            this.txtKilometros.Location = new System.Drawing.Point(144, 415);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(200, 22);
            this.txtKilometros.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kilometros";
            // 
            // btnAgregarPaquetes
            // 
            this.btnAgregarPaquetes.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPaquetes.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_agregar_archivo_50;
            this.btnAgregarPaquetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPaquetes.Location = new System.Drawing.Point(384, 290);
            this.btnAgregarPaquetes.Name = "btnAgregarPaquetes";
            this.btnAgregarPaquetes.Size = new System.Drawing.Size(193, 71);
            this.btnAgregarPaquetes.TabIndex = 12;
            this.btnAgregarPaquetes.Text = "Agregar Paquetes";
            this.btnAgregarPaquetes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPaquetes.UseVisualStyleBackColor = true;
            this.btnAgregarPaquetes.Click += new System.EventHandler(this.btnAgregarPaquetes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cant Paquetes";
            // 
            // lblNoTarjeta
            // 
            this.lblNoTarjeta.AutoSize = true;
            this.lblNoTarjeta.Location = new System.Drawing.Point(21, 256);
            this.lblNoTarjeta.Name = "lblNoTarjeta";
            this.lblNoTarjeta.Size = new System.Drawing.Size(79, 17);
            this.lblNoTarjeta.TabIndex = 10;
            this.lblNoTarjeta.Text = "No. Tarjeta";
            // 
            // mskNoTarjeta
            // 
            this.mskNoTarjeta.Location = new System.Drawing.Point(144, 256);
            this.mskNoTarjeta.Mask = "0000000000000000";
            this.mskNoTarjeta.Name = "mskNoTarjeta";
            this.mskNoTarjeta.Size = new System.Drawing.Size(200, 22);
            this.mskNoTarjeta.TabIndex = 9;
            // 
            // cboTipoTarjeta
            // 
            this.cboTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTarjeta.FormattingEnabled = true;
            this.cboTipoTarjeta.Location = new System.Drawing.Point(144, 202);
            this.cboTipoTarjeta.Name = "cboTipoTarjeta";
            this.cboTipoTarjeta.Size = new System.Drawing.Size(200, 24);
            this.cboTipoTarjeta.TabIndex = 8;
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(21, 209);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(85, 17);
            this.lblTipoTarjeta.TabIndex = 7;
            this.lblTipoTarjeta.Text = "Tipo Tarjeta";
            // 
            // btnBuscarMensajeros
            // 
            this.btnBuscarMensajeros.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarMensajeros.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_google_web_search_50;
            this.btnBuscarMensajeros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarMensajeros.Location = new System.Drawing.Point(384, 99);
            this.btnBuscarMensajeros.Name = "btnBuscarMensajeros";
            this.btnBuscarMensajeros.Size = new System.Drawing.Size(193, 68);
            this.btnBuscarMensajeros.TabIndex = 6;
            this.btnBuscarMensajeros.Text = "Buscar Mensajero";
            this.btnBuscarMensajeros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarMensajeros.UseVisualStyleBackColor = true;
            this.btnBuscarMensajeros.Click += new System.EventHandler(this.btnBuscarMensajeros_Click);
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Enabled = false;
            this.txtNoFactura.Location = new System.Drawing.Point(144, 40);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(200, 22);
            this.txtNoFactura.TabIndex = 5;
            // 
            // txtNombreMensajero
            // 
            this.txtNombreMensajero.Enabled = false;
            this.txtNombreMensajero.Location = new System.Drawing.Point(144, 150);
            this.txtNombreMensajero.Name = "txtNombreMensajero";
            this.txtNombreMensajero.Size = new System.Drawing.Size(200, 22);
            this.txtNombreMensajero.TabIndex = 4;
            // 
            // txtIDMensajero
            // 
            this.txtIDMensajero.Enabled = false;
            this.txtIDMensajero.Location = new System.Drawing.Point(144, 108);
            this.txtIDMensajero.Name = "txtIDMensajero";
            this.txtIDMensajero.Size = new System.Drawing.Size(200, 22);
            this.txtIDMensajero.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // lblMensajero
            // 
            this.lblMensajero.AutoSize = true;
            this.lblMensajero.Location = new System.Drawing.Point(21, 108);
            this.lblMensajero.Name = "lblMensajero";
            this.lblMensajero.Size = new System.Drawing.Size(87, 17);
            this.lblMensajero.TabIndex = 1;
            this.lblMensajero.Text = "IDMensajero";
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.Location = new System.Drawing.Point(21, 45);
            this.lblNoFactura.Name = "lblNoFactura";
            this.lblNoFactura.Size = new System.Drawing.Size(82, 17);
            this.lblNoFactura.TabIndex = 0;
            this.lblNoFactura.Text = "No. Factura";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_factura_50;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(1074, 793);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(267, 78);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_archivo_nuevo_50;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(338, 793);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(251, 78);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lnklblSalir
            // 
            this.lnklblSalir.AutoSize = true;
            this.lnklblSalir.BackColor = System.Drawing.Color.Transparent;
            this.lnklblSalir.LinkColor = System.Drawing.Color.White;
            this.lnklblSalir.Location = new System.Drawing.Point(1324, 72);
            this.lnklblSalir.Name = "lnklblSalir";
            this.lnklblSalir.Size = new System.Drawing.Size(17, 17);
            this.lnklblSalir.TabIndex = 8;
            this.lnklblSalir.TabStop = true;
            this.lnklblSalir.Text = "X";
            this.lnklblSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSalir_LinkClicked);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(767, 732);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(65, 17);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(862, 729);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(234, 22);
            this.txtSubTotal.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(1195, 732);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1270, 729);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(234, 22);
            this.txtTotal.TabIndex = 12;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 955);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lnklblSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.gMapMapa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProcesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcesos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmProcesos_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmProcesos_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapMapa;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescripcioRuta;
        private System.Windows.Forms.Button btnCalcularKilometros;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarPaquetes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoTarjeta;
        private System.Windows.Forms.MaskedTextBox mskNoTarjeta;
        private System.Windows.Forms.ComboBox cboTipoTarjeta;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Button btnBuscarMensajeros;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.TextBox txtNombreMensajero;
        private System.Windows.Forms.TextBox txtIDMensajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensajero;
        private System.Windows.Forms.Label lblNoFactura;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.ComboBox cboTipoEnvio;
        private System.Windows.Forms.Label lblTipoEnvio;
        private System.Windows.Forms.ListBox lstPaquetes;
        private System.Windows.Forms.Label lblDescripcionPaquete;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.ListBox lstUbicaciones;
        private System.Windows.Forms.LinkLabel lnklblSalir;
        private System.Windows.Forms.TextBox txtCantidadPaquetes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Timer tmrCronometro;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}