namespace UTN.Mensajeria.Winform.UI.Procesos
{
    partial class frmInsertarPaquetes
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
            this.lblPaquete = new System.Windows.Forms.Label();
            this.txtdescrpcion = new System.Windows.Forms.TextBox();
            this.lstPaquetes = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaquete
            // 
            this.lblPaquete.AutoSize = true;
            this.lblPaquete.BackColor = System.Drawing.Color.Transparent;
            this.lblPaquete.Location = new System.Drawing.Point(49, 142);
            this.lblPaquete.Name = "lblPaquete";
            this.lblPaquete.Size = new System.Drawing.Size(82, 17);
            this.lblPaquete.TabIndex = 0;
            this.lblPaquete.Text = "Descripción";
            // 
            // txtdescrpcion
            // 
            this.txtdescrpcion.Location = new System.Drawing.Point(161, 137);
            this.txtdescrpcion.Name = "txtdescrpcion";
            this.txtdescrpcion.Size = new System.Drawing.Size(324, 22);
            this.txtdescrpcion.TabIndex = 1;
            // 
            // lstPaquetes
            // 
            this.lstPaquetes.FormattingEnabled = true;
            this.lstPaquetes.ItemHeight = 16;
            this.lstPaquetes.Location = new System.Drawing.Point(300, 191);
            this.lstPaquetes.Name = "lstPaquetes";
            this.lstPaquetes.Size = new System.Drawing.Size(475, 308);
            this.lstPaquetes.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_agregar_archivo_50;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(56, 191);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(178, 80);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_eliminar_archivo_50;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(56, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 78);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncabezado.Font = new System.Drawing.Font("Open Sans Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(227, 36);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(383, 59);
            this.lblEncabezado.TabIndex = 5;
            this.lblEncabezado.Text = "Agregar Articulos";
            // 
            // btnListo
            // 
            this.btnListo.ForeColor = System.Drawing.Color.Black;
            this.btnListo.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_comprobado_50;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(52, 389);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(182, 76);
            this.btnListo.TabIndex = 6;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // frmInsertarPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 567);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstPaquetes);
            this.Controls.Add(this.txtdescrpcion);
            this.Controls.Add(this.lblPaquete);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInsertarPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInsertarPaquetes";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmInsertarPaquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaquete;
        private System.Windows.Forms.TextBox txtdescrpcion;
        private System.Windows.Forms.ListBox lstPaquetes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.ErrorProvider erpErrores;
    }
}