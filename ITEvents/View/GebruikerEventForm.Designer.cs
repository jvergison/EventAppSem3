namespace ITEvents.View
{
    partial class GebruikerEventForm
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
            this.gebruikereventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gebruikereventTableAdapter = new ITEvents.Model.RapporteringDataSetTableAdapters.gebruikereventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rapporteringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gebruikereventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "gebruikerevent";
            reportDataSource1.Value = this.gebruikereventBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ITEvents.View.Gebruikerevent.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(790, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // rapporteringDataSet
            // 
            this.rapporteringDataSet.DataSetName = "RapporteringDataSet";
            this.rapporteringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gebruikereventBindingSource
            // 
            this.gebruikereventBindingSource.DataMember = "gebruikerevent";
            this.gebruikereventBindingSource.DataSource = this.rapporteringDataSet;
            // 
            // gebruikereventTableAdapter
            // 
            this.gebruikereventTableAdapter.ClearBeforeFill = true;
            // 
            // GebruikerEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GebruikerEventForm";
            this.Text = "GebruikerEventForm";
            this.Load += new System.EventHandler(this.GebruikerEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rapporteringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gebruikereventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gebruikereventBindingSource;
        private Model.RapporteringDataSet rapporteringDataSet;
        private Model.RapporteringDataSetTableAdapters.gebruikereventTableAdapter gebruikereventTableAdapter;
    }
}