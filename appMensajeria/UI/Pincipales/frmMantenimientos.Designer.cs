namespace UTN.Mensajeria.Winform.UI
{
    partial class frmMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientos));
            this.label1 = new System.Windows.Forms.Label();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.rbMensajeros = new System.Windows.Forms.RadioButton();
            this.rbPreciosEnvio = new System.Windows.Forms.RadioButton();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pbMensajeros = new System.Windows.Forms.PictureBox();
            this.pbEnvios = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimientos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.BackColor = System.Drawing.Color.Transparent;
            this.rbClientes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbClientes.ForeColor = System.Drawing.Color.White;
            this.rbClientes.Location = new System.Drawing.Point(129, 365);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(79, 21);
            this.rbClientes.TabIndex = 1;
            this.rbClientes.TabStop = true;
            this.rbClientes.Text = "Clientes";
            this.rbClientes.UseVisualStyleBackColor = false;
            // 
            // rbMensajeros
            // 
            this.rbMensajeros.AutoSize = true;
            this.rbMensajeros.BackColor = System.Drawing.Color.Transparent;
            this.rbMensajeros.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMensajeros.ForeColor = System.Drawing.Color.White;
            this.rbMensajeros.Location = new System.Drawing.Point(407, 365);
            this.rbMensajeros.Name = "rbMensajeros";
            this.rbMensajeros.Size = new System.Drawing.Size(102, 21);
            this.rbMensajeros.TabIndex = 2;
            this.rbMensajeros.TabStop = true;
            this.rbMensajeros.Text = "Mensajeros";
            this.rbMensajeros.UseVisualStyleBackColor = false;
            // 
            // rbPreciosEnvio
            // 
            this.rbPreciosEnvio.AutoSize = true;
            this.rbPreciosEnvio.BackColor = System.Drawing.Color.Transparent;
            this.rbPreciosEnvio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPreciosEnvio.ForeColor = System.Drawing.Color.White;
            this.rbPreciosEnvio.Location = new System.Drawing.Point(692, 365);
            this.rbPreciosEnvio.Name = "rbPreciosEnvio";
            this.rbPreciosEnvio.Size = new System.Drawing.Size(122, 21);
            this.rbPreciosEnvio.TabIndex = 3;
            this.rbPreciosEnvio.TabStop = true;
            this.rbPreciosEnvio.Text = "Precios Envíos";
            this.rbPreciosEnvio.UseVisualStyleBackColor = false;
            // 
            // pbClientes
            // 
            this.pbClientes.BackColor = System.Drawing.Color.Transparent;
            this.pbClientes.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.clientes;
            this.pbClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbClientes.Location = new System.Drawing.Point(91, 196);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(166, 151);
            this.pbClientes.TabIndex = 6;
            this.pbClientes.TabStop = false;
            // 
            // pbMensajeros
            // 
            this.pbMensajeros.BackColor = System.Drawing.Color.Transparent;
            this.pbMensajeros.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.icono_usuarios;
            this.pbMensajeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMensajeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMensajeros.Location = new System.Drawing.Point(372, 196);
            this.pbMensajeros.Name = "pbMensajeros";
            this.pbMensajeros.Size = new System.Drawing.Size(166, 151);
            this.pbMensajeros.TabIndex = 7;
            this.pbMensajeros.TabStop = false;
            // 
            // pbEnvios
            // 
            this.pbEnvios.BackColor = System.Drawing.Color.Transparent;
            this.pbEnvios.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources._8817;
            this.pbEnvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnvios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbEnvios.Location = new System.Drawing.Point(669, 196);
            this.pbEnvios.Name = "pbEnvios";
            this.pbEnvios.Size = new System.Drawing.Size(166, 151);
            this.pbEnvios.TabIndex = 8;
            this.pbEnvios.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.SalirPequena1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(551, 463);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(206, 64);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.ListoPequena;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(187, 463);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(212, 64);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 582);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbEnvios);
            this.Controls.Add(this.pbMensajeros);
            this.Controls.Add(this.pbClientes);
            this.Controls.Add(this.rbPreciosEnvio);
            this.Controls.Add(this.rbMensajeros);
            this.Controls.Add(this.rbClientes);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmMantenimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbClientes;
        private System.Windows.Forms.RadioButton rbMensajeros;
        private System.Windows.Forms.RadioButton rbPreciosEnvio;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.PictureBox pbMensajeros;
        private System.Windows.Forms.PictureBox pbEnvios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
    }
}