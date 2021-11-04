
namespace VeterinariaSLN.presentacion
{
    partial class Frm_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsArchivo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsSalir1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSoporte = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsABMCTipoMascota = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTransaccion = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTransaccion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsABMAtenciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReportes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsReporteX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAcercaDe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsInfoApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsArchivo.SuspendLayout();
            this.cmsSoporte.SuspendLayout();
            this.cmsTransaccion.SuspendLayout();
            this.cmsReportes.SuspendLayout();
            this.cmsAcercaDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArchivo,
            this.tsSoporte,
            this.tsTransaccion,
            this.tsReportes,
            this.tsAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsArchivo
            // 
            this.tsArchivo.DropDown = this.cmsArchivo;
            this.tsArchivo.Name = "tsArchivo";
            this.tsArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsArchivo.Text = "Archivo";
            // 
            // cmsArchivo
            // 
            this.cmsArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSalir1});
            this.cmsArchivo.Name = "contextMenuStrip1";
            this.cmsArchivo.OwnerItem = this.tsArchivo;
            this.cmsArchivo.Size = new System.Drawing.Size(97, 26);
            this.cmsArchivo.Click += new System.EventHandler(this.cmsArchivo_Click);
            // 
            // tsSalir1
            // 
            this.tsSalir1.Name = "tsSalir1";
            this.tsSalir1.Size = new System.Drawing.Size(96, 22);
            this.tsSalir1.Text = "Salir";
            // 
            // tsSoporte
            // 
            this.tsSoporte.DropDown = this.cmsSoporte;
            this.tsSoporte.Name = "tsSoporte";
            this.tsSoporte.Size = new System.Drawing.Size(60, 20);
            this.tsSoporte.Text = "Soporte";
            // 
            // cmsSoporte
            // 
            this.cmsSoporte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsABMCTipoMascota});
            this.cmsSoporte.MinimumSize = new System.Drawing.Size(186, 26);
            this.cmsSoporte.Name = "cmsSoporte";
            this.cmsSoporte.OwnerItem = this.tsSoporte;
            this.cmsSoporte.Size = new System.Drawing.Size(186, 26);
            this.cmsSoporte.Click += new System.EventHandler(this.cmsSoporte_Click);
            // 
            // tsABMCTipoMascota
            // 
            this.tsABMCTipoMascota.Name = "tsABMCTipoMascota";
            this.tsABMCTipoMascota.Size = new System.Drawing.Size(185, 22);
            this.tsABMCTipoMascota.Text = "ABMC tipo mascotas";
            // 
            // tsTransaccion
            // 
            this.tsTransaccion.DropDown = this.cmsTransaccion;
            this.tsTransaccion.Name = "tsTransaccion";
            this.tsTransaccion.Size = new System.Drawing.Size(81, 20);
            this.tsTransaccion.Text = "Transaccion";
            // 
            // cmsTransaccion
            // 
            this.cmsTransaccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsABMAtenciones});
            this.cmsTransaccion.Name = "cmsTransaccion";
            this.cmsTransaccion.OwnerItem = this.tsTransaccion;
            this.cmsTransaccion.Size = new System.Drawing.Size(161, 26);
            this.cmsTransaccion.Click += new System.EventHandler(this.cmsTransaccion_Click);
            // 
            // tsABMAtenciones
            // 
            this.tsABMAtenciones.Name = "tsABMAtenciones";
            this.tsABMAtenciones.Size = new System.Drawing.Size(160, 22);
            this.tsABMAtenciones.Text = "ABM atenciones";
            // 
            // tsReportes
            // 
            this.tsReportes.DropDown = this.cmsReportes;
            this.tsReportes.Name = "tsReportes";
            this.tsReportes.Size = new System.Drawing.Size(65, 20);
            this.tsReportes.Text = "Reportes";
            // 
            // cmsReportes
            // 
            this.cmsReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReporteX});
            this.cmsReportes.Name = "cmsReportes";
            this.cmsReportes.OwnerItem = this.tsReportes;
            this.cmsReportes.Size = new System.Drawing.Size(126, 26);
            // 
            // tsReporteX
            // 
            this.tsReporteX.Name = "tsReporteX";
            this.tsReporteX.Size = new System.Drawing.Size(125, 22);
            this.tsReporteX.Text = "Reporte X";
            // 
            // tsAcercaDe
            // 
            this.tsAcercaDe.DropDown = this.cmsAcercaDe;
            this.tsAcercaDe.Name = "tsAcercaDe";
            this.tsAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.tsAcercaDe.Text = "Acerca de";
            // 
            // cmsAcercaDe
            // 
            this.cmsAcercaDe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInfoApp});
            this.cmsAcercaDe.Name = "cmsAcercaDe";
            this.cmsAcercaDe.Size = new System.Drawing.Size(193, 26);
            this.cmsAcercaDe.Click += new System.EventHandler(this.cmsAcercaDe_Click);
            // 
            // tsInfoApp
            // 
            this.tsInfoApp.Name = "tsInfoApp";
            this.tsInfoApp.Size = new System.Drawing.Size(192, 22);
            this.tsInfoApp.Text = "Informacion de la App";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Veterinaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsArchivo.ResumeLayout(false);
            this.cmsSoporte.ResumeLayout(false);
            this.cmsTransaccion.ResumeLayout(false);
            this.cmsReportes.ResumeLayout(false);
            this.cmsAcercaDe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsSoporte;
        private System.Windows.Forms.ToolStripMenuItem tsTransaccion;
        private System.Windows.Forms.ToolStripMenuItem tsReportes;
        private System.Windows.Forms.ToolStripMenuItem tsAcercaDe;
        private System.Windows.Forms.ContextMenuStrip cmsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsSalir1;
        private System.Windows.Forms.ContextMenuStrip cmsSoporte;
        private System.Windows.Forms.ToolStripMenuItem tsABMCTipoMascota;
        private System.Windows.Forms.ContextMenuStrip cmsTransaccion;
        private System.Windows.Forms.ToolStripMenuItem tsABMAtenciones;
        private System.Windows.Forms.ContextMenuStrip cmsReportes;
        private System.Windows.Forms.ToolStripMenuItem tsReporteX;
        private System.Windows.Forms.ContextMenuStrip cmsAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsInfoApp;
    }
}