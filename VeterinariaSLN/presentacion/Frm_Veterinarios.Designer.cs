
namespace VeterinariaSLN.presentacion
{
    partial class Frm_Veterinarios
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvVeterinarios = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblListado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(36, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestion de Medicos Veterinarios";
            // 
            // dgvVeterinarios
            // 
            this.dgvVeterinarios.AllowUserToAddRows = false;
            this.dgvVeterinarios.AllowUserToDeleteRows = false;
            this.dgvVeterinarios.AllowUserToResizeColumns = false;
            this.dgvVeterinarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeterinarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVeterinarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDocumento,
            this.colContacto,
            this.colSexo,
            this.colEditar,
            this.colEliminar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeterinarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVeterinarios.Location = new System.Drawing.Point(36, 148);
            this.dgvVeterinarios.Name = "dgvVeterinarios";
            this.dgvVeterinarios.ReadOnly = true;
            this.dgvVeterinarios.RowHeadersVisible = false;
            this.dgvVeterinarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVeterinarios.RowTemplate.Height = 25;
            this.dgvVeterinarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeterinarios.ShowCellToolTips = false;
            this.dgvVeterinarios.Size = new System.Drawing.Size(772, 316);
            this.dgvVeterinarios.TabIndex = 1;
            this.dgvVeterinarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeterinarios_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 70F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDocumento
            // 
            this.colDocumento.FillWeight = 70F;
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.ReadOnly = true;
            // 
            // colContacto
            // 
            this.colContacto.HeaderText = "Contacto";
            this.colContacto.Name = "colContacto";
            this.colContacto.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.FillWeight = 50F;
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colEditar
            // 
            this.colEditar.FillWeight = 40F;
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Image = global::VeterinariaSLN.Properties.Resources.outline_edit_white_24dp;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEliminar
            // 
            this.colEliminar.FillWeight = 40F;
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Image = global::VeterinariaSLN.Properties.Resources.outline_clear_white_24dp;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.White;
            this.lblListado.Location = new System.Drawing.Point(36, 103);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(285, 24);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Listado de Medicos Veterinarios:";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(733, 482);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(36, 482);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(134, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo Medico";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Frm_Veterinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(840, 567);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvVeterinarios);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Veterinarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Veterinarios";
            this.Load += new System.EventHandler(this.Frm_Veterinarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVeterinarios;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colEliminar;
    }
}