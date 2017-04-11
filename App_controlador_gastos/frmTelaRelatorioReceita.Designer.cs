namespace App_controlador_gastos
{
    partial class frmTelaRelatorioReceita
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
            this.controlador_gastosDataSet = new App_controlador_gastos.controlador_gastosDataSet();
            this.tblReceitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblReceitasTableAdapter = new App_controlador_gastos.controlador_gastosDataSetTableAdapters.tblReceitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.controlador_gastosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 34;
            reportDataSource1.Name = "dataset_tblReceitas";
            reportDataSource1.Value = this.tblReceitasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App_controlador_gastos.Relatórios.RelatorioReceita.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(736, 606);
            this.reportViewer1.TabIndex = 0;
            // 
            // controlador_gastosDataSet
            // 
            this.controlador_gastosDataSet.DataSetName = "controlador_gastosDataSet";
            this.controlador_gastosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblReceitasBindingSource
            // 
            this.tblReceitasBindingSource.DataMember = "tblReceitas";
            this.tblReceitasBindingSource.DataSource = this.controlador_gastosDataSet;
            // 
            // tblReceitasTableAdapter
            // 
            this.tblReceitasTableAdapter.ClearBeforeFill = true;
            // 
            // frmTelaRelatorioReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 609);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTelaRelatorioReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Receitas";
            this.Load += new System.EventHandler(this.frmTelaRelatorioReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlador_gastosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblReceitasBindingSource;
        private controlador_gastosDataSet controlador_gastosDataSet;
        private controlador_gastosDataSetTableAdapters.tblReceitasTableAdapter tblReceitasTableAdapter;
    }
}