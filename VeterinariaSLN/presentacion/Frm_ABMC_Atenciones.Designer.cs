
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConsultarHistorial = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.grpAltaAtencion = new System.Windows.Forms.GroupBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarA = new System.Windows.Forms.Button();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtMascotaA = new System.Windows.Forms.TextBox();
            this.txtClienteA = new System.Windows.Forms.TextBox();
            this.lblIdAtencion = new System.Windows.Forms.Label();
            this.lblDescripA = new System.Windows.Forms.Label();
            this.lblMascotaA = new System.Windows.Forms.Label();
            this.lblClienteA = new System.Windows.Forms.Label();
            this.btnSalirA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.grpAltaAtencion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeColumns = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.ColumnHeadersHeight = 26;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colFecha,
            this.colDescripcion,
            this.colImporte,
            this.colAcciones});
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.Location = new System.Drawing.Point(42, 59);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHistorial.RowTemplate.Height = 25;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(645, 186);
            this.dgvHistorial.TabIndex = 2;
            this.dgvHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            this.colImporte.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAcciones
            // 
            this.colAcciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAcciones.Text = "Ver";
            this.colAcciones.UseColumnTextForButtonValue = true;
            // 
            // btnConsultarHistorial
            // 
            this.btnConsultarHistorial.Location = new System.Drawing.Point(42, 24);
            this.btnConsultarHistorial.Name = "btnConsultarHistorial";
            this.btnConsultarHistorial.Size = new System.Drawing.Size(149, 25);
            this.btnConsultarHistorial.TabIndex = 1;
            this.btnConsultarHistorial.Text = "Consultar Historial";
            this.btnConsultarHistorial.UseVisualStyleBackColor = true;
            this.btnConsultarHistorial.Click += new System.EventHandler(this.btnConsultarHistorial_Click);
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnConsultarHistorial);
            this.grpConsulta.Controls.Add(this.dgvHistorial);
            this.grpConsulta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpConsulta.Location = new System.Drawing.Point(71, 324);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(721, 269);
            this.grpConsulta.TabIndex = 2;
            this.grpConsulta.TabStop = false;
            // 
            // grpAltaAtencion
            // 
            this.grpAltaAtencion.Controls.Add(this.txtImporte);
            this.grpAltaAtencion.Controls.Add(this.label1);
            this.grpAltaAtencion.Controls.Add(this.btnRegistrarA);
            this.grpAltaAtencion.Controls.Add(this.rtxtDescripcion);
            this.grpAltaAtencion.Controls.Add(this.txtMascotaA);
            this.grpAltaAtencion.Controls.Add(this.txtClienteA);
            this.grpAltaAtencion.Controls.Add(this.lblIdAtencion);
            this.grpAltaAtencion.Controls.Add(this.lblDescripA);
            this.grpAltaAtencion.Controls.Add(this.lblMascotaA);
            this.grpAltaAtencion.Controls.Add(this.lblClienteA);
            this.grpAltaAtencion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpAltaAtencion.Location = new System.Drawing.Point(71, 21);
            this.grpAltaAtencion.Name = "grpAltaAtencion";
            this.grpAltaAtencion.Size = new System.Drawing.Size(721, 295);
            this.grpAltaAtencion.TabIndex = 3;
            this.grpAltaAtencion.TabStop = false;
            this.grpAltaAtencion.Text = "Alta de Atencion";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(214, 235);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(175, 25);
            this.txtImporte.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Importe de la Atencion: ";
            // 
            // btnRegistrarA
            // 
            this.btnRegistrarA.Location = new System.Drawing.Point(585, 232);
            this.btnRegistrarA.Name = "btnRegistrarA";
            this.btnRegistrarA.Size = new System.Drawing.Size(75, 29);
            this.btnRegistrarA.TabIndex = 9;
            this.btnRegistrarA.Text = "Registrar";
            this.btnRegistrarA.UseVisualStyleBackColor = true;
            this.btnRegistrarA.Click += new System.EventHandler(this.btnRegistrarA_Click);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(60, 141);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(613, 70);
            this.rtxtDescripcion.TabIndex = 6;
            this.rtxtDescripcion.Text = "";
            // 
            // txtMascotaA
            // 
            this.txtMascotaA.Enabled = false;
            this.txtMascotaA.Location = new System.Drawing.Point(421, 57);
            this.txtMascotaA.Name = "txtMascotaA";
            this.txtMascotaA.Size = new System.Drawing.Size(216, 25);
            this.txtMascotaA.TabIndex = 5;
            // 
            // txtClienteA
            // 
            this.txtClienteA.Enabled = false;
            this.txtClienteA.Location = new System.Drawing.Point(119, 57);
            this.txtClienteA.Name = "txtClienteA";
            this.txtClienteA.Size = new System.Drawing.Size(204, 25);
            this.txtClienteA.TabIndex = 4;
            // 
            // lblIdAtencion
            // 
            this.lblIdAtencion.AutoSize = true;
            this.lblIdAtencion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdAtencion.Location = new System.Drawing.Point(573, 19);
            this.lblIdAtencion.Name = "lblIdAtencion";
            this.lblIdAtencion.Size = new System.Drawing.Size(114, 21);
            this.lblIdAtencion.TabIndex = 3;
            this.lblIdAtencion.Text = "ID de Atencion:";
            // 
            // lblDescripA
            // 
            this.lblDescripA.AutoSize = true;
            this.lblDescripA.Location = new System.Drawing.Point(60, 113);
            this.lblDescripA.Name = "lblDescripA";
            this.lblDescripA.Size = new System.Drawing.Size(165, 17);
            this.lblDescripA.TabIndex = 2;
            this.lblDescripA.Text = "Descripcion de la atencion:";
            // 
            // lblMascotaA
            // 
            this.lblMascotaA.AutoSize = true;
            this.lblMascotaA.Location = new System.Drawing.Point(353, 60);
            this.lblMascotaA.Name = "lblMascotaA";
            this.lblMascotaA.Size = new System.Drawing.Size(61, 17);
            this.lblMascotaA.TabIndex = 1;
            this.lblMascotaA.Text = "Mascota:";
            // 
            // lblClienteA
            // 
            this.lblClienteA.AutoSize = true;
            this.lblClienteA.Location = new System.Drawing.Point(60, 60);
            this.lblClienteA.Name = "lblClienteA";
            this.lblClienteA.Size = new System.Drawing.Size(50, 17);
            this.lblClienteA.TabIndex = 0;
            this.lblClienteA.Text = "Cliente:";
            // 
            // btnSalirA
            // 
            this.btnSalirA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalirA.Location = new System.Drawing.Point(669, 608);
            this.btnSalirA.Name = "btnSalirA";
            this.btnSalirA.Size = new System.Drawing.Size(75, 28);
            this.btnSalirA.TabIndex = 10;
            this.btnSalirA.Text = "Salir";
            this.btnSalirA.UseVisualStyleBackColor = true;
            this.btnSalirA.Click += new System.EventHandler(this.btnSalirA_Click);
            // 
            // Frm_ABMC_Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 648);
            this.Controls.Add(this.btnSalirA);
            this.Controls.Add(this.grpAltaAtencion);
            this.Controls.Add(this.grpConsulta);
            this.MinimumSize = new System.Drawing.Size(895, 687);
            this.Name = "Frm_ABMC_Atenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABMC_Atenciones";
            this.Load += new System.EventHandler(this.Frm_ABMC_Atenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpAltaAtencion.ResumeLayout(false);
            this.grpAltaAtencion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnConsultarHistorial;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.GroupBox grpAltaAtencion;
        private System.Windows.Forms.Button btnRegistrarA;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.TextBox txtMascotaA;
        private System.Windows.Forms.TextBox txtClienteA;
        private System.Windows.Forms.Label lblIdAtencion;
        private System.Windows.Forms.Label lblDescripA;
        private System.Windows.Forms.Label lblMascotaA;
        private System.Windows.Forms.Label lblClienteA;
        private System.Windows.Forms.Button btnSalirA;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}