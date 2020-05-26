namespace UTN.Mensajeria.Winform.UI.Reportes.Forms
{
    partial class frmReporteFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableFacturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRecaudacion = new UTN.Mensajeria.Winform.UI.Reportes.DataSet.DataSetRecaudacion();
            this.ttpAyudas = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.dataTableFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new UTN.Mensajeria.Winform.UI.Reportes.DataSet.DataSetRecaudacionTableAdapters.FacturaTableAdapter();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bgwWorker = new System.ComponentModel.BackgroundWorker();
            this.pbProcesos = new System.Windows.Forms.ProgressBar();
            this.lblCargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFacturaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecaudacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableFacturaBindingSource1
            // 
            this.dataTableFacturaBindingSource1.DataMember = "DataTableFactura";
            this.dataTableFacturaBindingSource1.DataSource = this.dataSetRecaudacion;
            // 
            // dataSetRecaudacion
            // 
            this.dataSetRecaudacion.DataSetName = "DataSetRecaudacion";
            this.dataSetRecaudacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ttpAyudas
            // 
            this.ttpAyudas.IsBalloon = true;
            this.ttpAyudas.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpAyudas.ToolTipTitle = "Info";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.icons8_salir_redondeado_filled_50;
            this.btnSalir.Location = new System.Drawing.Point(145, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 78);
            this.btnSalir.TabIndex = 3;
            this.ttpAyudas.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.Image = global::UTN.Mensajeria.Winform.Properties.Resources.pdfpequeno;
            this.btnExportarPdf.Location = new System.Drawing.Point(12, 4);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(97, 78);
            this.btnExportarPdf.TabIndex = 2;
            this.ttpAyudas.SetToolTip(this.btnExportarPdf, "Exportar a PDF");
            this.btnExportarPdf.UseVisualStyleBackColor = true;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // dataTableFacturaBindingSource
            // 
            this.dataTableFacturaBindingSource.DataMember = "DataTableFactura";
            this.dataTableFacturaBindingSource.DataSource = this.dataSetRecaudacion;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // rptVisor
            // 
            reportDataSource3.Name = "DS";
            reportDataSource3.Value = this.dataTableFacturaBindingSource1;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource3);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Mensajeria.Winform.UI.Reportes.Reportes.rptReporteFactura.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(2, 88);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.Size = new System.Drawing.Size(1004, 677);
            this.rptVisor.TabIndex = 4;
            // 
            // bgwWorker
            // 
            this.bgwWorker.WorkerReportsProgress = true;
            this.bgwWorker.WorkerSupportsCancellation = true;
            this.bgwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWorker_DoWork);
            this.bgwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwWorker_ProgressChanged);
            this.bgwWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwWorker_RunWorkerCompleted);
            // 
            // pbProcesos
            // 
            this.pbProcesos.Location = new System.Drawing.Point(611, 27);
            this.pbProcesos.Name = "pbProcesos";
            this.pbProcesos.Size = new System.Drawing.Size(364, 23);
            this.pbProcesos.TabIndex = 5;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(745, 60);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(234, 17);
            this.lblCargando.TabIndex = 6;
            this.lblCargando.Text = "Cargando datos, por favor espere...";
            // 
            // frmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 761);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.pbProcesos);
            this.Controls.Add(this.rptVisor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportarPdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteFactura";
            this.Load += new System.EventHandler(this.frmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFacturaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecaudacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet.DataSetRecaudacion dataSetRecaudacion;
        private System.Windows.Forms.BindingSource dataTableFacturaBindingSource;
        private DataSet.DataSetRecaudacionTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.ToolTip ttpAyudas;
        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private System.Windows.Forms.BindingSource dataTableFacturaBindingSource1;
        private System.ComponentModel.BackgroundWorker bgwWorker;
        private System.Windows.Forms.ProgressBar pbProcesos;
        private System.Windows.Forms.Label lblCargando;
    }
}