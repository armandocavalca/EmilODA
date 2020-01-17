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
            this.ODA202PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet4 = new EmilODA.DataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ODA202PTableAdapter = new EmilODA.DataSet4TableAdapters.ODA202PTableAdapter();
            this.dataSet41 = new EmilODA.DataSet4();
            this.oDA202PBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ODA202PBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDA202PBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ODA202PBindingSource
            // 
            this.ODA202PBindingSource.DataMember = "ODA202P";
            this.ODA202PBindingSource.DataSource = this.DataSet4;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.oDA202PBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmilODA.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // ODA202PTableAdapter
            // 
            this.ODA202PTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet41
            // 
            this.dataSet41.DataSetName = "DataSet4";
            this.dataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oDA202PBindingSource1
            // 
            this.oDA202PBindingSource1.DataMember = "ODA202P";
            this.oDA202PBindingSource1.DataSource = this.dataSet41;
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
            ((System.ComponentModel.ISupportInitialize)(this.ODA202PBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDA202PBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ODA202PBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.ODA202PTableAdapter ODA202PTableAdapter;
        private DataSet4 dataSet41;
        private System.Windows.Forms.BindingSource oDA202PBindingSource1;
    }
}