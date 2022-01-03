namespace Entinity_Framework_deneme
{
    partial class Form2
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
            this.DbEntinityUrunDataSet1 = new Entinity_Framework_deneme.DbEntinityUrunDataSet1();
            this.TBLURUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBLURUNTableAdapter = new Entinity_Framework_deneme.DbEntinityUrunDataSet1TableAdapters.TBLURUNTableAdapter();
            this.DbEntinityUrunDataSet = new Entinity_Framework_deneme.DbEntinityUrunDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.DbEntinityUrunDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLURUNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbEntinityUrunDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBLURUNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Entinity_Framework_deneme.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(777, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbEntinityUrunDataSet1
            // 
            this.DbEntinityUrunDataSet1.DataSetName = "DbEntinityUrunDataSet1";
            this.DbEntinityUrunDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBLURUNBindingSource
            // 
            this.TBLURUNBindingSource.DataMember = "TBLURUN";
            this.TBLURUNBindingSource.DataSource = this.DbEntinityUrunDataSet1;
            // 
            // TBLURUNTableAdapter
            // 
            this.TBLURUNTableAdapter.ClearBeforeFill = true;
            // 
            // DbEntinityUrunDataSet
            // 
            this.DbEntinityUrunDataSet.DataSetName = "DbEntinityUrunDataSet";
            this.DbEntinityUrunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbEntinityUrunDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLURUNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbEntinityUrunDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBLURUNBindingSource;
        private DbEntinityUrunDataSet1 DbEntinityUrunDataSet1;
        private DbEntinityUrunDataSet1TableAdapters.TBLURUNTableAdapter TBLURUNTableAdapter;
        private DbEntinityUrunDataSet DbEntinityUrunDataSet;
    }
}