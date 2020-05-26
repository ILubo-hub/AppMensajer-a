namespace UTN.Mensajeria.Winform.UI.Filtros
{
    partial class frmFiltroCliente
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
            this.dgvFlitro = new System.Windows.Forms.DataGridView();
            this.clmIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlitro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFlitro
            // 
            this.dgvFlitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlitro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDCliente,
            this.clmNombre,
            this.cmlApellidos,
            this.clmProvincia});
            this.dgvFlitro.Location = new System.Drawing.Point(348, 176);
            this.dgvFlitro.Name = "dgvFlitro";
            this.dgvFlitro.RowTemplate.Height = 24;
            this.dgvFlitro.Size = new System.Drawing.Size(603, 395);
            this.dgvFlitro.TabIndex = 0;
            this.dgvFlitro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlitro_CellDoubleClick);
            // 
            // clmIDCliente
            // 
            this.clmIDCliente.DataPropertyName = "IDCliente";
            this.clmIDCliente.HeaderText = "IdCliente";
            this.clmIDCliente.Name = "clmIDCliente";
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // cmlApellidos
            // 
            this.cmlApellidos.DataPropertyName = "Apellidos";
            this.cmlApellidos.HeaderText = "Apellidos";
            this.cmlApellidos.Name = "cmlApellidos";
            // 
            // clmProvincia
            // 
            this.clmProvincia.DataPropertyName = "Provincia";
            this.clmProvincia.HeaderText = "Provincia";
            this.clmProvincia.Name = "clmProvincia";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(35, 176);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(297, 22);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_archivo_nuevo_50;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(47, 230);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(198, 74);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_google_web_search_50;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(47, 330);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(198, 74);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_salir_redondeado_filled_50;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(47, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(198, 74);
            this.btnSalir.TabIndex = 4;
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
            this.lblEncabezado.Location = new System.Drawing.Point(281, 46);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(437, 82);
            this.lblEncabezado.TabIndex = 5;
            this.lblEncabezado.Text = "Filtro Clientes";
            // 
            // frmFiltroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 638);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvFlitro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFiltroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFiltroCliente";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmFiltroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlitro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlitro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProvincia;
    }
}