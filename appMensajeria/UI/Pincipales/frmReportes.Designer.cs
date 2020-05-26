namespace UTN.Mensajeria.Winform.UI.Pincipales
{
    partial class frmReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbEnvios = new System.Windows.Forms.PictureBox();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.rbRecaudacion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.ListoPequena;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(179, 494);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(212, 64);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.SalirPequena1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(621, 494);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(206, 64);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbEnvios
            // 
            this.pbEnvios.BackColor = System.Drawing.Color.Transparent;
            this.pbEnvios.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources._8817;
            this.pbEnvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnvios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbEnvios.Location = new System.Drawing.Point(123, 184);
            this.pbEnvios.Name = "pbEnvios";
            this.pbEnvios.Size = new System.Drawing.Size(166, 151);
            this.pbEnvios.TabIndex = 16;
            this.pbEnvios.TabStop = false;
            // 
            // pbClientes
            // 
            this.pbClientes.BackColor = System.Drawing.Color.Transparent;
            this.pbClientes.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.clientes;
            this.pbClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbClientes.Location = new System.Drawing.Point(684, 184);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(166, 151);
            this.pbClientes.TabIndex = 14;
            this.pbClientes.TabStop = false;
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.BackColor = System.Drawing.Color.Transparent;
            this.rbClientes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbClientes.ForeColor = System.Drawing.Color.White;
            this.rbClientes.Location = new System.Drawing.Point(704, 359);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(132, 21);
            this.rbClientes.TabIndex = 13;
            this.rbClientes.TabStop = true;
            this.rbClientes.Text = "Compra Clientes";
            this.rbClientes.UseVisualStyleBackColor = false;
            // 
            // rbRecaudacion
            // 
            this.rbRecaudacion.AutoSize = true;
            this.rbRecaudacion.BackColor = System.Drawing.Color.Transparent;
            this.rbRecaudacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbRecaudacion.ForeColor = System.Drawing.Color.White;
            this.rbRecaudacion.Location = new System.Drawing.Point(148, 359);
            this.rbRecaudacion.Name = "rbRecaudacion";
            this.rbRecaudacion.Size = new System.Drawing.Size(112, 21);
            this.rbRecaudacion.TabIndex = 11;
            this.rbRecaudacion.TabStop = true;
            this.rbRecaudacion.Text = "Recaudación";
            this.rbRecaudacion.UseVisualStyleBackColor = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 665);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbEnvios);
            this.Controls.Add(this.pbClientes);
            this.Controls.Add(this.rbClientes);
            this.Controls.Add(this.rbRecaudacion);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportes";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbEnvios;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.RadioButton rbClientes;
        private System.Windows.Forms.RadioButton rbRecaudacion;
    }
}