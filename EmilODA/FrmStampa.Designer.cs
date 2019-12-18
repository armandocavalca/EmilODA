namespace EmilODA
{
    partial class FrmStampa
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
            this.dataSet2 = new EmilODA.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODA201LBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODA201LTableAdapter = new EmilODA.DataSet2TableAdapters.ODA201LTableAdapter();
            this.DataSet3 = new EmilODA.DataSet3();
            this.ODA201PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODA201PTableAdapter = new EmilODA.DataSet3TableAdapters.ODA201PTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODA201LBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODA201PBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataIBM";
            reportDataSource1.Value = this.ODA201PBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmilODA.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // ODA201LBindingSource
            // 
            this.ODA201LBindingSource.DataMember = "ODA201L";
            this.ODA201LBindingSource.DataSource = this.dataSet2;
            // 
            // ODA201LTableAdapter
            // 
            this.ODA201LTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ODA201PBindingSource
            // 
            this.ODA201PBindingSource.DataMember = "ODA201P";
            this.ODA201PBindingSource.DataSource = this.DataSet3;
            // 
            // ODA201PTableAdapter
            // 
            this.ODA201PTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStampa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmStampa";
            this.Text = "FrmStampa";
            this.Load += new System.EventHandler(this.FrmStampa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODA201LBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODA201PBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource ODA201LBindingSource;
        private DataSet2TableAdapters.ODA201LTableAdapter ODA201LTableAdapter;
        private System.Windows.Forms.BindingSource ODA201PBindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.ODA201PTableAdapter ODA201PTableAdapter;
    }
}