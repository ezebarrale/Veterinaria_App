
namespace VeterinariaReport
{
    partial class Frm_Reporte
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
            this.PA_REPORTE_MESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VETDataSet1 = new VeterinariaReport.VETDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_REPORTE_MESTableAdapter = new VeterinariaReport.VETDataSet1TableAdapters.PA_REPORTE_MESTableAdapter();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.btnEnviarR = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_MESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VETDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_REPORTE_MESBindingSource
            // 
            this.PA_REPORTE_MESBindingSource.DataMember = "PA_REPORTE_MES";
            this.PA_REPORTE_MESBindingSource.DataSource = this.VETDataSet1;
            // 
            // VETDataSet1
            // 
            this.VETDataSet1.DataSetName = "VETDataSet1";
            this.VETDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PA_REPORTE_MESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VeterinariaReport.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.MinimumSize = new System.Drawing.Size(906, 574);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(906, 605);
            this.reportViewer1.TabIndex = 0;
            // 
            // PA_REPORTE_MESTableAdapter
            // 
            this.PA_REPORTE_MESTableAdapter.ClearBeforeFill = true;
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(138, 248);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(120, 20);
            this.nudMes.TabIndex = 1;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEnviarR
            // 
            this.btnEnviarR.Location = new System.Drawing.Point(264, 245);
            this.btnEnviarR.Name = "btnEnviarR";
            this.btnEnviarR.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarR.TabIndex = 2;
            this.btnEnviarR.Text = "Enviar";
            this.btnEnviarR.UseVisualStyleBackColor = true;
            this.btnEnviarR.Click += new System.EventHandler(this.btnEnviarR_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.White;
            this.lblInstruccion.Location = new System.Drawing.Point(138, 209);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(170, 13);
            this.lblInstruccion.TabIndex = 3;
            this.lblInstruccion.Text = "Seleccione un mes para visualizar:";
            // 
            // Frm_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 605);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.btnEnviarR);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte";
            this.Text = "Reportes PET HOUSE";
            this.Load += new System.EventHandler(this.Frm_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_MESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VETDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_REPORTE_MESBindingSource;
        private VETDataSet1 VETDataSet1;
        private VETDataSet1TableAdapters.PA_REPORTE_MESTableAdapter PA_REPORTE_MESTableAdapter;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.Button btnEnviarR;
        private System.Windows.Forms.Label lblInstruccion;
    }
}