
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpAltaAtencion = new System.Windows.Forms.GroupBox();
            this.btnRegistrarDetalle = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtMascotaA = new System.Windows.Forms.TextBox();
            this.txtClienteA = new System.Windows.Forms.TextBox();
            this.lblIdAtencion = new System.Windows.Forms.Label();
            this.lblDescripA = new System.Windows.Forms.Label();
            this.lblMascotaA = new System.Windows.Forms.Label();
            this.lblClienteA = new System.Windows.Forms.Label();
            this.btnRegistrarA = new System.Windows.Forms.Button();
            this.btnSalirA = new System.Windows.Forms.Button();
            this.lblVet = new System.Windows.Forms.Label();
            this.cmbVet = new System.Windows.Forms.ComboBox();
            this.lblListD = new System.Windows.Forms.Label();
            this.lblListA = new System.Windows.Forms.Label();
            this.grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.grpAltaAtencion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.dgvHistorial);
            this.grpConsulta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpConsulta.Location = new System.Drawing.Point(71, 399);
            this.grpConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpConsulta.Size = new System.Drawing.Size(721, 244);
            this.grpConsulta.TabIndex = 2;
            this.grpConsulta.TabStop = false;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
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
            this.colDescripcion,
            this.colImporte,
            this.colAcciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.Location = new System.Drawing.Point(42, 35);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHistorial.RowTemplate.Height = 25;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(645, 183);
            this.dgvHistorial.TabIndex = 12;
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
            this.colAcciones.Text = "Eliminar";
            this.colAcciones.UseColumnTextForButtonValue = true;
            // 
            // grpAltaAtencion
            // 
            this.grpAltaAtencion.Controls.Add(this.btnRegistrarDetalle);
            this.grpAltaAtencion.Controls.Add(this.txtImporte);
            this.grpAltaAtencion.Controls.Add(this.label1);
            this.grpAltaAtencion.Controls.Add(this.rtxtDescripcion);
            this.grpAltaAtencion.Controls.Add(this.txtMascotaA);
            this.grpAltaAtencion.Controls.Add(this.txtClienteA);
            this.grpAltaAtencion.Controls.Add(this.lblIdAtencion);
            this.grpAltaAtencion.Controls.Add(this.lblDescripA);
            this.grpAltaAtencion.Controls.Add(this.lblMascotaA);
            this.grpAltaAtencion.Controls.Add(this.lblClienteA);
            this.grpAltaAtencion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpAltaAtencion.Location = new System.Drawing.Point(71, 42);
            this.grpAltaAtencion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAltaAtencion.Name = "grpAltaAtencion";
            this.grpAltaAtencion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAltaAtencion.Size = new System.Drawing.Size(721, 328);
            this.grpAltaAtencion.TabIndex = 3;
            this.grpAltaAtencion.TabStop = false;
            // 
            // btnRegistrarDetalle
            // 
            this.btnRegistrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarDetalle.Location = new System.Drawing.Point(549, 265);
            this.btnRegistrarDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrarDetalle.Name = "btnRegistrarDetalle";
            this.btnRegistrarDetalle.Size = new System.Drawing.Size(124, 34);
            this.btnRegistrarDetalle.TabIndex = 11;
            this.btnRegistrarDetalle.Text = "Registrar Detalle";
            this.btnRegistrarDetalle.UseVisualStyleBackColor = true;
            this.btnRegistrarDetalle.Click += new System.EventHandler(this.btnRegistrarDetalle_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(214, 270);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(175, 25);
            this.txtImporte.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Importe de la Atencion: ";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(60, 155);
            this.rtxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(613, 83);
            this.rtxtDescripcion.TabIndex = 6;
            this.rtxtDescripcion.Text = "";
            // 
            // txtMascotaA
            // 
            this.txtMascotaA.Enabled = false;
            this.txtMascotaA.Location = new System.Drawing.Point(421, 68);
            this.txtMascotaA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMascotaA.Name = "txtMascotaA";
            this.txtMascotaA.Size = new System.Drawing.Size(216, 25);
            this.txtMascotaA.TabIndex = 5;
            // 
            // txtClienteA
            // 
            this.txtClienteA.Enabled = false;
            this.txtClienteA.Location = new System.Drawing.Point(119, 68);
            this.txtClienteA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClienteA.Name = "txtClienteA";
            this.txtClienteA.Size = new System.Drawing.Size(204, 25);
            this.txtClienteA.TabIndex = 4;
            // 
            // lblIdAtencion
            // 
            this.lblIdAtencion.AutoSize = true;
            this.lblIdAtencion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdAtencion.Location = new System.Drawing.Point(573, 23);
            this.lblIdAtencion.Name = "lblIdAtencion";
            this.lblIdAtencion.Size = new System.Drawing.Size(114, 21);
            this.lblIdAtencion.TabIndex = 3;
            this.lblIdAtencion.Text = "ID de Atencion:";
            // 
            // lblDescripA
            // 
            this.lblDescripA.AutoSize = true;
            this.lblDescripA.Location = new System.Drawing.Point(60, 121);
            this.lblDescripA.Name = "lblDescripA";
            this.lblDescripA.Size = new System.Drawing.Size(137, 17);
            this.lblDescripA.TabIndex = 2;
            this.lblDescripA.Text = "Detalle de la atencion:";
            // 
            // lblMascotaA
            // 
            this.lblMascotaA.AutoSize = true;
            this.lblMascotaA.Location = new System.Drawing.Point(353, 72);
            this.lblMascotaA.Name = "lblMascotaA";
            this.lblMascotaA.Size = new System.Drawing.Size(61, 17);
            this.lblMascotaA.TabIndex = 1;
            this.lblMascotaA.Text = "Mascota:";
            // 
            // lblClienteA
            // 
            this.lblClienteA.AutoSize = true;
            this.lblClienteA.Location = new System.Drawing.Point(60, 72);
            this.lblClienteA.Name = "lblClienteA";
            this.lblClienteA.Size = new System.Drawing.Size(50, 17);
            this.lblClienteA.TabIndex = 0;
            this.lblClienteA.Text = "Cliente:";
            // 
            // btnRegistrarA
            // 
            this.btnRegistrarA.Enabled = false;
            this.btnRegistrarA.FlatAppearance.BorderSize = 0;
            this.btnRegistrarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarA.Location = new System.Drawing.Point(514, 661);
            this.btnRegistrarA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrarA.Name = "btnRegistrarA";
            this.btnRegistrarA.Size = new System.Drawing.Size(138, 35);
            this.btnRegistrarA.TabIndex = 14;
            this.btnRegistrarA.Text = "Registrar Atencion";
            this.btnRegistrarA.UseVisualStyleBackColor = true;
            this.btnRegistrarA.Click += new System.EventHandler(this.btnRegistrarA_Click);
            // 
            // btnSalirA
            // 
            this.btnSalirA.FlatAppearance.BorderSize = 0;
            this.btnSalirA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalirA.Location = new System.Drawing.Point(669, 661);
            this.btnSalirA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalirA.Name = "btnSalirA";
            this.btnSalirA.Size = new System.Drawing.Size(75, 34);
            this.btnSalirA.TabIndex = 15;
            this.btnSalirA.Text = "Salir";
            this.btnSalirA.UseVisualStyleBackColor = true;
            this.btnSalirA.Click += new System.EventHandler(this.btnSalirA_Click);
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Location = new System.Drawing.Point(113, 669);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(122, 18);
            this.lblVet.TabIndex = 12;
            this.lblVet.Text = "Medico Veterinario:";
            // 
            // cmbVet
            // 
            this.cmbVet.FormattingEnabled = true;
            this.cmbVet.Location = new System.Drawing.Point(241, 665);
            this.cmbVet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVet.Name = "cmbVet";
            this.cmbVet.Size = new System.Drawing.Size(175, 26);
            this.cmbVet.TabIndex = 13;
            // 
            // lblListD
            // 
            this.lblListD.AutoSize = true;
            this.lblListD.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListD.Location = new System.Drawing.Point(71, 381);
            this.lblListD.Name = "lblListD";
            this.lblListD.Size = new System.Drawing.Size(150, 22);
            this.lblListD.TabIndex = 14;
            this.lblListD.Text = "Listado de detalles:";
            // 
            // lblListA
            // 
            this.lblListA.AutoSize = true;
            this.lblListA.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListA.Location = new System.Drawing.Point(71, 22);
            this.lblListA.Name = "lblListA";
            this.lblListA.Size = new System.Drawing.Size(197, 24);
            this.lblListA.TabIndex = 15;
            this.lblListA.Text = "Alta detalle atencion:";
            // 
            // Frm_ABMC_Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(895, 715);
            this.Controls.Add(this.lblListA);
            this.Controls.Add(this.lblListD);
            this.Controls.Add(this.cmbVet);
            this.Controls.Add(this.btnSalirA);
            this.Controls.Add(this.lblVet);
            this.Controls.Add(this.grpAltaAtencion);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.btnRegistrarA);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(895, 687);
            this.Name = "Frm_ABMC_Atenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Atenciones";
            this.Load += new System.EventHandler(this.Frm_ABMC_Atenciones_Load);
            this.grpConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.grpAltaAtencion.ResumeLayout(false);
            this.grpAltaAtencion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnRegistrarDetalle;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.ComboBox cmbVet;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.Label lblListD;
        private System.Windows.Forms.Label lblListA;
    }
}