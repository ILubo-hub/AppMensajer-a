namespace UTN.Mensajeria.Winform.UI.Mantenimientos
{
    partial class frmMantenimientoPrecios
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
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKilometroInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlKilometroFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInsertar = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.nudKilometroFinal = new System.Windows.Forms.NumericUpDown();
            this.nudKilometroInicial = new System.Windows.Forms.NumericUpDown();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.txtTipoMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeparadorMod = new System.Windows.Forms.Label();
            this.nudKilometroFinalMod = new System.Windows.Forms.NumericUpDown();
            this.nudKilometroInicialMod = new System.Windows.Forms.NumericUpDown();
            this.mskPrecioMod = new System.Windows.Forms.MaskedTextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblPrecioMod = new System.Windows.Forms.Label();
            this.lblRangoMod = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.gbInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometroFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometroInicial)).BeginInit();
            this.gbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometroFinalMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometroInicialMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncabezado.Font = new System.Drawing.Font("Open Sans Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(443, 34);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(246, 82);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Precios";
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.clmKilometroInicial,
            this.cmlKilometroFinal,
            this.clmPrecio});
            this.dgvPrecios.Location = new System.Drawing.Point(37, 156);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.RowTemplate.Height = 24;
            this.dgvPrecios.Size = new System.Drawing.Size(444, 251);
            this.dgvPrecios.TabIndex = 0;
            this.dgvPrecios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrecios_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TipoEnvio";
            this.Column1.HeaderText = "Tipo";
            this.Column1.Name = "Column1";
            // 
            // clmKilometroInicial
            // 
            this.clmKilometroInicial.DataPropertyName = "KilometroInicial";
            this.clmKilometroInicial.HeaderText = "Kilometro Inicial";
            this.clmKilometroInicial.Name = "clmKilometroInicial";
            // 
            // cmlKilometroFinal
            // 
            this.cmlKilometroFinal.DataPropertyName = "KilometroFinal";
            this.cmlKilometroFinal.HeaderText = "Kilometro Final";
            this.cmlKilometroFinal.Name = "cmlKilometroFinal";
            // 
            // clmPrecio
            // 
            this.clmPrecio.DataPropertyName = "PrecioRango";
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.Name = "clmPrecio";
            // 
            // gbInsertar
            // 
            this.gbInsertar.BackColor = System.Drawing.Color.Transparent;
            this.gbInsertar.Controls.Add(this.txtTipo);
            this.gbInsertar.Controls.Add(this.lblTipo);
            this.gbInsertar.Controls.Add(this.lblSeparador);
            this.gbInsertar.Controls.Add(this.nudKilometroFinal);
            this.gbInsertar.Controls.Add(this.nudKilometroInicial);
            this.gbInsertar.Controls.Add(this.mskPrecio);
            this.gbInsertar.Controls.Add(this.btnInsertar);
            this.gbInsertar.Controls.Add(this.lblPrecio);
            this.gbInsertar.Controls.Add(this.lblRango);
            this.gbInsertar.ForeColor = System.Drawing.Color.White;
            this.gbInsertar.Location = new System.Drawing.Point(523, 156);
            this.gbInsertar.Name = "gbInsertar";
            this.gbInsertar.Size = new System.Drawing.Size(278, 300);
            this.gbInsertar.TabIndex = 2;
            this.gbInsertar.TabStop = false;
            this.gbInsertar.Text = "Agregar";
            this.gbInsertar.Enter += new System.EventHandler(this.gbInsertar_Enter);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(109, 37);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(134, 22);
            this.txtTipo.TabIndex = 11;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(19, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo";
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Location = new System.Drawing.Point(167, 103);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(16, 17);
            this.lblSeparador.TabIndex = 9;
            this.lblSeparador.Text = "a";
            // 
            // nudKilometroFinal
            // 
            this.nudKilometroFinal.Location = new System.Drawing.Point(202, 98);
            this.nudKilometroFinal.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudKilometroFinal.Name = "nudKilometroFinal";
            this.nudKilometroFinal.Size = new System.Drawing.Size(41, 22);
            this.nudKilometroFinal.TabIndex = 8;
            // 
            // nudKilometroInicial
            // 
            this.nudKilometroInicial.Location = new System.Drawing.Point(109, 98);
            this.nudKilometroInicial.Name = "nudKilometroInicial";
            this.nudKilometroInicial.Size = new System.Drawing.Size(41, 22);
            this.nudKilometroInicial.TabIndex = 7;
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(109, 164);
            this.mskPrecio.Mask = "000000";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(134, 22);
            this.mskPrecio.TabIndex = 6;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.Black;
            this.btnInsertar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_agregar_archivo_26;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(52, 223);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(159, 52);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(19, 164);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(19, 98);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(50, 17);
            this.lblRango.TabIndex = 1;
            this.lblRango.Text = "Rango";
            // 
            // gbModificar
            // 
            this.gbModificar.BackColor = System.Drawing.Color.Transparent;
            this.gbModificar.Controls.Add(this.txtTipoMod);
            this.gbModificar.Controls.Add(this.label1);
            this.gbModificar.Controls.Add(this.lblSeparadorMod);
            this.gbModificar.Controls.Add(this.nudKilometroFinalMod);
            this.gbModificar.Controls.Add(this.nudKilometroInicialMod);
            this.gbModificar.Controls.Add(this.mskPrecioMod);
            this.gbModificar.Controls.Add(this.btnModificar);
            this.gbModificar.Controls.Add(this.lblPrecioMod);
            this.gbModificar.Controls.Add(this.lblRangoMod);
            this.gbModificar.ForeColor = System.Drawing.Color.White;
            this.gbModificar.Location = new System.Drawing.Point(853, 156);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(270, 300);
            this.gbModificar.TabIndex = 3;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar";
            // 
            // txtTipoMod
            // 
            this.txtTipoMod.Enabled = false;
            this.txtTipoMod.Location = new System.Drawing.Point(114, 34);
            this.txtTipoMod.Name = "txtTipoMod";
            this.txtTipoMod.Size = new System.Drawing.Size(134, 22);
            this.txtTipoMod.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo";
            // 
            // lblSeparadorMod
            // 
            this.lblSeparadorMod.AutoSize = true;
            this.lblSeparadorMod.Location = new System.Drawing.Point(169, 103);
            this.lblSeparadorMod.Name = "lblSeparadorMod";
            this.lblSeparadorMod.Size = new System.Drawing.Size(16, 17);
            this.lblSeparadorMod.TabIndex = 12;
            this.lblSeparadorMod.Text = "a";
            // 
            // nudKilometroFinalMod
            // 
            this.nudKilometroFinalMod.Location = new System.Drawing.Point(205, 96);
            this.nudKilometroFinalMod.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudKilometroFinalMod.Name = "nudKilometroFinalMod";
            this.nudKilometroFinalMod.Size = new System.Drawing.Size(41, 22);
            this.nudKilometroFinalMod.TabIndex = 11;
            // 
            // nudKilometroInicialMod
            // 
            this.nudKilometroInicialMod.Location = new System.Drawing.Point(112, 96);
            this.nudKilometroInicialMod.Name = "nudKilometroInicialMod";
            this.nudKilometroInicialMod.Size = new System.Drawing.Size(41, 22);
            this.nudKilometroInicialMod.TabIndex = 10;
            // 
            // mskPrecioMod
            // 
            this.mskPrecioMod.Location = new System.Drawing.Point(112, 164);
            this.mskPrecioMod.Mask = "000000";
            this.mskPrecioMod.Name = "mskPrecioMod";
            this.mskPrecioMod.Size = new System.Drawing.Size(136, 22);
            this.mskPrecioMod.TabIndex = 9;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_editar_propiedad_26;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(57, 223);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(159, 52);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblPrecioMod
            // 
            this.lblPrecioMod.AutoSize = true;
            this.lblPrecioMod.Location = new System.Drawing.Point(24, 164);
            this.lblPrecioMod.Name = "lblPrecioMod";
            this.lblPrecioMod.Size = new System.Drawing.Size(48, 17);
            this.lblPrecioMod.TabIndex = 7;
            this.lblPrecioMod.Text = "Precio";
            // 
            // lblRangoMod
            // 
            this.lblRangoMod.AutoSize = true;
            this.lblRangoMod.Location = new System.Drawing.Point(24, 98);
            this.lblRangoMod.Name = "lblRangoMod";
            this.lblRangoMod.Size = new System.Drawing.Size(50, 17);
            this.lblRangoMod.TabIndex = 5;
            this.lblRangoMod.Text = "Rango";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_eliminar_26;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(37, 425);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(444, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.actualizarpequena;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(253, 506);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(215, 62);
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
            this.btnSalir.Location = new System.Drawing.Point(747, 506);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(215, 62);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // frmMantenimientoPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 610);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.gbInsertar);
            this.Controls.Add(this.dgvPrecios);
            this.Controls.Add(this.lblEncabezado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantenimientoPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoPrecios";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmMantenimientoPrecios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.gbInsertar.ResumeLayout(false);
            this.gbInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometroFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometroInicial)).EndInit();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometroFinalMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometroInicialMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.GroupBox gbInsertar;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblPrecioMod;
        private System.Windows.Forms.Label lblRangoMod;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.MaskedTextBox mskPrecio;
        private System.Windows.Forms.MaskedTextBox mskPrecioMod;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.NumericUpDown nudKilometroFinal;
        private System.Windows.Forms.NumericUpDown nudKilometroInicial;
        private System.Windows.Forms.Label lblSeparadorMod;
        private System.Windows.Forms.NumericUpDown nudKilometroFinalMod;
        private System.Windows.Forms.NumericUpDown nudKilometroInicialMod;
        private System.Windows.Forms.TextBox txtTipoMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKilometroInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlKilometroFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
    }
}