namespace Personel_Kayıt_Projesi_YENİ
{
    partial class Frmraporlar
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
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet1 = new Personel_Kayıt_Projesi_YENİ.PERSONEL_VERİ_TABANI_YENİDENDataSet1();
            this.pERSONELVERİTABANIYENİDENDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet = new Personel_Kayıt_Projesi_YENİ.PERSONEL_VERİ_TABANI_YENİDENDataSet();
            this.tblPersonelYeniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Personel_YeniTableAdapter = new Personel_Kayıt_Projesi_YENİ.PERSONEL_VERİ_TABANI_YENİDENDataSetTableAdapters.Tbl_Personel_YeniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_VERİ_TABANI_YENİDENDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONELVERİTABANIYENİDENDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_VERİ_TABANI_YENİDENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelYeniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblPersonelYeniBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Personel_Kayıt_Projesi_YENİ.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(980, 559);
            this.reportViewer1.TabIndex = 0;
            // 
            // pERSONEL_VERİ_TABANI_YENİDENDataSet1
            // 
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet1.DataSetName = "PERSONEL_VERİ_TABANI_YENİDENDataSet1";
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONELVERİTABANIYENİDENDataSet1BindingSource
            // 
            this.pERSONELVERİTABANIYENİDENDataSet1BindingSource.DataSource = this.pERSONEL_VERİ_TABANI_YENİDENDataSet1;
            this.pERSONELVERİTABANIYENİDENDataSet1BindingSource.Position = 0;
            // 
            // pERSONEL_VERİ_TABANI_YENİDENDataSet
            // 
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet.DataSetName = "PERSONEL_VERİ_TABANI_YENİDENDataSet";
            this.pERSONEL_VERİ_TABANI_YENİDENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelYeniBindingSource
            // 
            this.tblPersonelYeniBindingSource.DataMember = "Tbl_Personel_Yeni";
            this.tblPersonelYeniBindingSource.DataSource = this.pERSONEL_VERİ_TABANI_YENİDENDataSet;
            // 
            // tbl_Personel_YeniTableAdapter
            // 
            this.tbl_Personel_YeniTableAdapter.ClearBeforeFill = true;
            // 
            // Frmraporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 559);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frmraporlar";
            this.Text = "Frmraporlar";
            this.Load += new System.EventHandler(this.Frmraporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_VERİ_TABANI_YENİDENDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONELVERİTABANIYENİDENDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_VERİ_TABANI_YENİDENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelYeniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pERSONELVERİTABANIYENİDENDataSet1BindingSource;
        private PERSONEL_VERİ_TABANI_YENİDENDataSet1 pERSONEL_VERİ_TABANI_YENİDENDataSet1;
        private PERSONEL_VERİ_TABANI_YENİDENDataSet pERSONEL_VERİ_TABANI_YENİDENDataSet;
        private System.Windows.Forms.BindingSource tblPersonelYeniBindingSource;
        private PERSONEL_VERİ_TABANI_YENİDENDataSetTableAdapters.Tbl_Personel_YeniTableAdapter tbl_Personel_YeniTableAdapter;
    }
}