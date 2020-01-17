namespace EmilODA
{
    partial class Frm_ModuloOdf
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet4 = new EmilODA.DataSet4();
            this.ODA202PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODA202PTableAdapter = new EmilODA.DataSet4TableAdapters.ODA202PTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODA202PBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ODA202PBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmilODA.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ODA202PBindingSource
            // 
            this.ODA202PBindingSource.DataMember = "ODA202P";
            this.ODA202PBindingSource.DataSource = this.DataSet4;
            // 
            // ODA202PTableAdapter
            // 
            this.ODA202PTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ModuloOdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_ModuloOdf";
            this.Text = "Frm_ModuloOdf";
            this.Load += new System.EventHandler(this.Frm_ModuloOdf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODA202PBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ODA202PBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.ODA202PTableAdapter ODA202PTableAdapter;
    }
}