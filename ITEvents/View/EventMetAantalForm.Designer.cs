﻿namespace ITEvents.View
{
    partial class EventMetAantalForm
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
            this.rapporteringDataSet = new ITEvents.Model.RapporteringDataSet();
            this.eventmetaantalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventmetaantalTableAdapter = new ITEvents.Model.RapporteringDataSetTableAdapters.eventmetaantalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rapporteringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventmetaantalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "eventmetaantal";
            reportDataSource1.Value = this.eventmetaantalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ITEvents.View.Eventmetaantal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(864, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // rapporteringDataSet
            // 
            this.rapporteringDataSet.DataSetName = "RapporteringDataSet";
            this.rapporteringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventmetaantalBindingSource
            // 
            this.eventmetaantalBindingSource.DataMember = "eventmetaantal";
            this.eventmetaantalBindingSource.DataSource = this.rapporteringDataSet;
            // 
            // eventmetaantalTableAdapter
            // 
            this.eventmetaantalTableAdapter.ClearBeforeFill = true;
            // 
            // EventMetAantalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EventMetAantalForm";
            this.Text = "EventMetAantalForm";
            this.Load += new System.EventHandler(this.EventMetAantalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rapporteringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventmetaantalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Model.RapporteringDataSet rapporteringDataSet;
        private System.Windows.Forms.BindingSource eventmetaantalBindingSource;
        private Model.RapporteringDataSetTableAdapters.eventmetaantalTableAdapter eventmetaantalTableAdapter;
    }
}