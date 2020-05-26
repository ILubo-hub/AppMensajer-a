namespace UTN.Mensajeria.Winform.UI.Reportes.Forms
{
    partial class frmReporteCompraCliente
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
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetRecaudacion = new UTN.Mensajeria.Winform.UI.Reportes.DataSet.DataSetRecaudacion();
            this.dataTableCompraClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraClienteTableAdapter = new UTN.Mensajeria.Winform.UI.Reportes.DataSet.DataSetRecaudacionTableAdapters.CompraClienteTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecaudacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCompraClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptVisor
            // 
            reportDataSource1.Name = "DS";
            reportDataSource1.Value = this.dataTableCompraClienteBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Mensajeria.Winform.UI.Reportes.Reportes.rptCompraCliente.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(-4, 78);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.Size = new System.Drawing.Size(1474, 629);
            this.rptVisor.TabIndex = 0;
            // 
            // dataSetRecaudacion
            // 
            this.dataSetRecaudacion.DataSetName = "DataSetRecaudacion";
            this.dataSetRecaudacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableCompraClienteBindingSource
            // 
            this.dataTableCompraClienteBindingSource.DataMember = "DataTableCompraCliente";
            this.dataTableCompraClienteBindingSource.DataSource = this.dataSetRecaudacion;
            // 
            // compraClienteTableAdapter
            // 
            this.compraClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Mensajeria.Winform.Properties.Resources.SalirPequena;
            this.btnSalir.Location = new System.Drawing.Point(1358, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 67);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmReporteCompraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 706);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rptVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteCompraCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteCompraCliente";
            this.Load += new System.EventHandler(this.frmReporteCompraCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecaudacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCompraClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private DataSet.DataSetRecaudacion dataSetRecaudacion;
        private System.Windows.Forms.BindingSource dataTableCompraClienteBindingSource;
        private DataSet.DataSetRecaudacionTableAdapters.CompraClienteTableAdapter compraClienteTableAdapter;
        private System.Windows.Forms.Button btnSalir;
    }
}