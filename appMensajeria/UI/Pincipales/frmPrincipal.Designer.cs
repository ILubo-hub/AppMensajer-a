namespace UTN.Mensajeria.Winform.UI
{
    partial class frmPrincipal
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
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnMantenimientos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.lnkSalir = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncabezado.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(164, 25);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(0, 69);
            this.lblEncabezado.TabIndex = 0;
            // 
            // btnProcesos
            // 
            this.btnProcesos.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_tarea_del_sistema_50;
            this.btnProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesos.Location = new System.Drawing.Point(45, 249);
            this.btnProcesos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(246, 78);
            this.btnProcesos.TabIndex = 1;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.UseVisualStyleBackColor = true;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnMantenimientos
            // 
            this.btnMantenimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMantenimientos.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_menú_50;
            this.btnMantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientos.Location = new System.Drawing.Point(45, 157);
            this.btnMantenimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Size = new System.Drawing.Size(246, 74);
            this.btnMantenimientos.TabIndex = 2;
            this.btnMantenimientos.Text = "Mantenimientos";
            this.btnMantenimientos.UseVisualStyleBackColor = true;
            this.btnMantenimientos.Click += new System.EventHandler(this.btnMantenimientos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_vuelto_asignación_50;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(45, 345);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(246, 76);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.White;
            this.ptLogo.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.LogoProyectoTerminado;
            this.ptLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptLogo.Location = new System.Drawing.Point(373, 135);
            this.ptLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(377, 357);
            this.ptLogo.TabIndex = 4;
            this.ptLogo.TabStop = false;
            // 
            // lnkSalir
            // 
            this.lnkSalir.AutoSize = true;
            this.lnkSalir.BackColor = System.Drawing.Color.Transparent;
            this.lnkSalir.LinkColor = System.Drawing.Color.White;
            this.lnkSalir.Location = new System.Drawing.Point(703, 46);
            this.lnkSalir.Name = "lnkSalir";
            this.lnkSalir.Size = new System.Drawing.Size(17, 17);
            this.lnkSalir.TabIndex = 5;
            this.lnkSalir.TabStop = true;
            this.lnkSalir.Text = "X";
            this.lnkSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSalir_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 82);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú Principal";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UTN.Mensajeria.Winform.Properties.Resources.FrameAdministradorPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkSalir);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnMantenimientos);
            this.Controls.Add(this.btnProcesos);
            this.Controls.Add(this.lblEncabezado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Button btnMantenimientos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.LinkLabel lnkSalir;
        private System.Windows.Forms.Label label1;
    }
}