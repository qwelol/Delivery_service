namespace WindowsFormsApp1
{
    partial class report_form
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
            this.Delivery_serviceDataSet = new WindowsFormsApp1.Delivery_serviceDataSet();
            this.ОтправлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ОтправлениеTableAdapter = new WindowsFormsApp1.Delivery_serviceDataSetTableAdapters.ОтправлениеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Delivery_serviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ОтправлениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ОтправлениеBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 700);
            this.reportViewer1.TabIndex = 0;
            // 
            // Delivery_serviceDataSet
            // 
            this.Delivery_serviceDataSet.DataSetName = "Delivery_serviceDataSet";
            this.Delivery_serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ОтправлениеBindingSource
            // 
            this.ОтправлениеBindingSource.DataMember = "Отправление";
            this.ОтправлениеBindingSource.DataSource = this.Delivery_serviceDataSet;
            // 
            // ОтправлениеTableAdapter
            // 
            this.ОтправлениеTableAdapter.ClearBeforeFill = true;
            // 
            // report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 584);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_form";
            this.Text = "report_form";
            this.Load += new System.EventHandler(this.report_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Delivery_serviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ОтправлениеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ОтправлениеBindingSource;
        private Delivery_serviceDataSet Delivery_serviceDataSet;
        private Delivery_serviceDataSetTableAdapters.ОтправлениеTableAdapter ОтправлениеTableAdapter;
    }
}