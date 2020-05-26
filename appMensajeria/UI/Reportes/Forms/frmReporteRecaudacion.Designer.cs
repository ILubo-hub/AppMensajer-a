namespace UTN.Mensajeria.Winform.UI.Reportes.Forms
{
    partial class frmReporteRecaudacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableRecaudacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRecaudacion = new UTN.Mensajeria.Winform.UI.Reportes.DataSet.DataSetRecaudacion();
            this.lblFechinicial = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.recaudacionTableAdapter = new UTN.Mensajeria.Winform.UI.Reportes.DataSet.DataSetRecaudacionTableAdapters.RecaudacionTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ttpAyudas = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRecaudacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecaudacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableRecaudacionBindingSource
            // 
            this.dataTableRecaudacionBindingSource.DataMember = "DataTableRecaudacion";
            this.dataTableRecaudacionBindingSource.DataSource = this.dataSetRecaudacion;
            // 
            // dataSetRecaudacion
            // 
            this.dataSetRecaudacion.DataSetName = "DataSetRecaudacion";
            this.dataSetRecaudacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFechinicial
            // 
            this.lblFechinicial.AutoSize = true;
            this.lblFechinicial.Location = new System.Drawing.Point(535, 36);
            this.lblFechinicial.Name = "lblFechinicial";
            this.lblFechinicial.Size = new System.Drawing.Size(86, 17);
            this.lblFechinicial.TabIndex = 2;
            this.lblFechinicial.Text = "Fecha Inicial";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(637, 36);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(132, 22);
            this.dtpFechaInicial.TabIndex = 3;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(899, 36);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(128, 22);
            this.dtpFechaFinal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Final";
            // 
            // rptVisor
            // 
            reportDataSource1.Name = "DS";
            reportDataSource1.Value = this.dataTableRecaudacionBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Mensajeria.Winform.UI.Reportes.Reportes.rptReporteRecaudacion.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(2, 83);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.Size = new System.Drawing.Size(1522, 682);
            this.rptVisor.TabIndex = 7;
            // 
            // recaudacionTableAdapter
            // 
            this.recaudacionTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_salir_redondeado_filled_50;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1046, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 65);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.ttpAyudas.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_google_web_search_50;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(315, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(183, 65);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.ttpAyudas.SetToolTip(this.btnBuscar, "Buscar Recaudaciones");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ttpAyudas
            // 
            this.ttpAyudas.IsBalloon = true;
            this.ttpAyudas.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmReporteRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 740);
            this.Controls.Add(this.rptVisor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.lblFechinicial);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteRecaudacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteRecaudacion";
            this.Load += new System.EventHandler(this.frmReporteRecaudacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRecaudacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecaudacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechinicial;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private System.Windows.Forms.BindingSource dataTableRecaudacionBindingSource;
        private DataSet.DataSetRecaudacion dataSetRecaudacion;
        private DataSet.DataSetRecaudacionTableAdapters.RecaudacionTableAdapter recaudacionTableAdapter;
        private System.Windows.Forms.ToolTip ttpAyudas;
    }
}