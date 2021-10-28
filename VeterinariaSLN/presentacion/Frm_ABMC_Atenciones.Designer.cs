
namespace VeterinariaSLN.presentacion
{
    partial class Frm_ABMC_Atenciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultarHistorial = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.grpAltaAtencion = new System.Windows.Forms.GroupBox();
            this.lblClienteA = new System.Windows.Forms.Label();
            this.lblMascotaA = new System.Windows.Forms.Label();
            this.lblDescripA = new System.Windows.Forms.Label();
            this.lblIdAtencion = new System.Windows.Forms.Label();
            this.txtClienteA = new System.Windows.Forms.TextBox();
            this.txtMascotaA = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRegistrarA = new System.Windows.Forms.Button();
            this.btnSalirA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.grpAltaAtencion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(645, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnConsultarHistorial
            // 
            this.btnConsultarHistorial.Location = new System.Drawing.Point(42, 22);
            this.btnConsultarHistorial.Name = "btnConsultarHistorial";
            this.btnConsultarHistorial.Size = new System.Drawing.Size(120, 25);
            this.btnConsultarHistorial.TabIndex = 1;
            this.btnConsultarHistorial.Text = "Consultar Historial";
            this.btnConsultarHistorial.UseVisualStyleBackColor = true;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnConsultarHistorial);
            this.grpConsulta.Controls.Add(this.dataGridView1);
            this.grpConsulta.Location = new System.Drawing.Point(46, 324);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(721, 269);
            this.grpConsulta.TabIndex = 2;
            this.grpConsulta.TabStop = false;
            // 
            // grpAltaAtencion
            // 
            this.grpAltaAtencion.Controls.Add(this.btnRegistrarA);
            this.grpAltaAtencion.Controls.Add(this.richTextBox1);
            this.grpAltaAtencion.Controls.Add(this.txtMascotaA);
            this.grpAltaAtencion.Controls.Add(this.txtClienteA);
            this.grpAltaAtencion.Controls.Add(this.lblIdAtencion);
            this.grpAltaAtencion.Controls.Add(this.lblDescripA);
            this.grpAltaAtencion.Controls.Add(this.lblMascotaA);
            this.grpAltaAtencion.Controls.Add(this.lblClienteA);
            this.grpAltaAtencion.Location = new System.Drawing.Point(46, 21);
            this.grpAltaAtencion.Name = "grpAltaAtencion";
            this.grpAltaAtencion.Size = new System.Drawing.Size(721, 297);
            this.grpAltaAtencion.TabIndex = 3;
            this.grpAltaAtencion.TabStop = false;
            this.grpAltaAtencion.Text = "Alta de Atencion";
            // 
            // lblClienteA
            // 
            this.lblClienteA.AutoSize = true;
            this.lblClienteA.Location = new System.Drawing.Point(60, 60);
            this.lblClienteA.Name = "lblClienteA";
            this.lblClienteA.Size = new System.Drawing.Size(47, 15);
            this.lblClienteA.TabIndex = 0;
            this.lblClienteA.Text = "Cliente:";
            // 
            // lblMascotaA
            // 
            this.lblMascotaA.AutoSize = true;
            this.lblMascotaA.Location = new System.Drawing.Point(353, 60);
            this.lblMascotaA.Name = "lblMascotaA";
            this.lblMascotaA.Size = new System.Drawing.Size(55, 15);
            this.lblMascotaA.TabIndex = 1;
            this.lblMascotaA.Text = "Mascota:";
            // 
            // lblDescripA
            // 
            this.lblDescripA.AutoSize = true;
            this.lblDescripA.Location = new System.Drawing.Point(60, 99);
            this.lblDescripA.Name = "lblDescripA";
            this.lblDescripA.Size = new System.Drawing.Size(149, 15);
            this.lblDescripA.TabIndex = 2;
            this.lblDescripA.Text = "Descripcion de la atencion:";
            // 
            // lblIdAtencion
            // 
            this.lblIdAtencion.AutoSize = true;
            this.lblIdAtencion.Location = new System.Drawing.Point(585, 19);
            this.lblIdAtencion.Name = "lblIdAtencion";
            this.lblIdAtencion.Size = new System.Drawing.Size(88, 15);
            this.lblIdAtencion.TabIndex = 3;
            this.lblIdAtencion.Text = "ID de Atencion:";
            // 
            // txtClienteA
            // 
            this.txtClienteA.Enabled = false;
            this.txtClienteA.Location = new System.Drawing.Point(119, 57);
            this.txtClienteA.Name = "txtClienteA";
            this.txtClienteA.Size = new System.Drawing.Size(204, 23);
            this.txtClienteA.TabIndex = 4;
            // 
            // txtMascotaA
            // 
            this.txtMascotaA.Enabled = false;
            this.txtMascotaA.Location = new System.Drawing.Point(421, 57);
            this.txtMascotaA.Name = "txtMascotaA";
            this.txtMascotaA.Size = new System.Drawing.Size(216, 23);
            this.txtMascotaA.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(60, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(613, 109);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // btnRegistrarA
            // 
            this.btnRegistrarA.Location = new System.Drawing.Point(598, 260);
            this.btnRegistrarA.Name = "btnRegistrarA";
            this.btnRegistrarA.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarA.TabIndex = 7;
            this.btnRegistrarA.Text = "Registrar";
            this.btnRegistrarA.UseVisualStyleBackColor = true;
            // 
            // btnSalirA
            // 
            this.btnSalirA.Location = new System.Drawing.Point(644, 613);
            this.btnSalirA.Name = "btnSalirA";
            this.btnSalirA.Size = new System.Drawing.Size(75, 23);
            this.btnSalirA.TabIndex = 4;
            this.btnSalirA.Text = "Salir";
            this.btnSalirA.UseVisualStyleBackColor = true;
            // 
            // Frm_ABMC_Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 648);
            this.Controls.Add(this.btnSalirA);
            this.Controls.Add(this.grpAltaAtencion);
            this.Controls.Add(this.grpConsulta);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Frm_ABMC_Atenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABMC_Atenciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpAltaAtencion.ResumeLayout(false);
            this.grpAltaAtencion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultarHistorial;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.GroupBox grpAltaAtencion;
        private System.Windows.Forms.Button btnRegistrarA;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtMascotaA;
        private System.Windows.Forms.TextBox txtClienteA;
        private System.Windows.Forms.Label lblIdAtencion;
        private System.Windows.Forms.Label lblDescripA;
        private System.Windows.Forms.Label lblMascotaA;
        private System.Windows.Forms.Label lblClienteA;
        private System.Windows.Forms.Button btnSalirA;
    }
}