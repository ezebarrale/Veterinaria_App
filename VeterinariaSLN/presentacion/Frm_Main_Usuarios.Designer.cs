
namespace VeterinariaSLN.presentacion
{
    partial class Frm_Main_Usuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pcbOff = new System.Windows.Forms.PictureBox();
            this.pcbOn = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ckbVerPass = new System.Windows.Forms.CheckBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.ckbAdmin = new System.Windows.Forms.CheckBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUsr = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.ckbTodos = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOn)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colUser,
            this.colAdmin,
            this.colEditar,
            this.colEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.Location = new System.Drawing.Point(25, 84);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.ShowCellToolTips = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(574, 159);
            this.dgvUsuarios.TabIndex = 17;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.ToolTipText = "Codigo";
            this.colCodigo.Visible = false;
            // 
            // colUser
            // 
            this.colUser.FillWeight = 98.82014F;
            this.colUser.HeaderText = "Usuario";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            this.colUser.ToolTipText = "Usuario";
            // 
            // colAdmin
            // 
            this.colAdmin.FillWeight = 60F;
            this.colAdmin.HeaderText = "Admin?";
            this.colAdmin.Name = "colAdmin";
            this.colAdmin.ReadOnly = true;
            this.colAdmin.ToolTipText = "Admin?";
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Cambiar Contraseña";
            this.colEditar.Image = global::VeterinariaSLN.Properties.Resources.outline_key_white_24dp;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditar.ToolTipText = "Editar";
            // 
            // colEliminar
            // 
            this.colEliminar.FillWeight = 50F;
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Image = global::VeterinariaSLN.Properties.Resources.outline_clear_white_24dp;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEliminar.ToolTipText = "Eliminar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(211, 28);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 32);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(25, 32);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(167, 23);
            this.txtConsultar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el nombre de usuario que desea buscar:";
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.btnNuevo);
            this.grpUsuarios.Controls.Add(this.pcbOff);
            this.grpUsuarios.Controls.Add(this.pcbOn);
            this.grpUsuarios.Controls.Add(this.btnGuardar);
            this.grpUsuarios.Controls.Add(this.ckbVerPass);
            this.grpUsuarios.Controls.Add(this.lblAdmin);
            this.grpUsuarios.Controls.Add(this.ckbAdmin);
            this.grpUsuarios.Controls.Add(this.txtUser);
            this.grpUsuarios.Controls.Add(this.txtPass);
            this.grpUsuarios.Controls.Add(this.lblUsr);
            this.grpUsuarios.Controls.Add(this.lblPass);
            this.grpUsuarios.Location = new System.Drawing.Point(95, 51);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(621, 165);
            this.grpUsuarios.TabIndex = 7;
            this.grpUsuarios.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(428, 118);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 28);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pcbOff
            // 
            this.pcbOff.Image = global::VeterinariaSLN.Properties.Resources.outline_visibility_off_white_24dp;
            this.pcbOff.Location = new System.Drawing.Point(562, 43);
            this.pcbOff.Name = "pcbOff";
            this.pcbOff.Size = new System.Drawing.Size(26, 23);
            this.pcbOff.TabIndex = 11;
            this.pcbOff.TabStop = false;
            this.pcbOff.Visible = false;
            // 
            // pcbOn
            // 
            this.pcbOn.Image = global::VeterinariaSLN.Properties.Resources.outline_visibility_white_24dp;
            this.pcbOn.Location = new System.Drawing.Point(562, 43);
            this.pcbOn.Name = "pcbOn";
            this.pcbOn.Size = new System.Drawing.Size(26, 22);
            this.pcbOn.TabIndex = 10;
            this.pcbOn.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(524, 118);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ckbVerPass
            // 
            this.ckbVerPass.AutoSize = true;
            this.ckbVerPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbVerPass.ForeColor = System.Drawing.Color.White;
            this.ckbVerPass.Location = new System.Drawing.Point(546, 49);
            this.ckbVerPass.Margin = new System.Windows.Forms.Padding(0);
            this.ckbVerPass.Name = "ckbVerPass";
            this.ckbVerPass.Size = new System.Drawing.Size(12, 11);
            this.ckbVerPass.TabIndex = 9;
            this.ckbVerPass.UseVisualStyleBackColor = true;
            this.ckbVerPass.CheckedChanged += new System.EventHandler(this.ckbVerPass_CheckedChanged);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(58, 85);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(50, 18);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Admin?";
            // 
            // ckbAdmin
            // 
            this.ckbAdmin.AutoSize = true;
            this.ckbAdmin.ForeColor = System.Drawing.Color.White;
            this.ckbAdmin.Location = new System.Drawing.Point(127, 88);
            this.ckbAdmin.Name = "ckbAdmin";
            this.ckbAdmin.Size = new System.Drawing.Size(15, 14);
            this.ckbAdmin.TabIndex = 7;
            this.ckbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(121, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(152, 23);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(388, 42);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(137, 23);
            this.txtPass.TabIndex = 4;
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.ForeColor = System.Drawing.Color.White;
            this.lblUsr.Location = new System.Drawing.Point(58, 45);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(57, 18);
            this.lblUsr.TabIndex = 1;
            this.lblUsr.Text = "Usuario:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(303, 45);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(79, 18);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios.Location = new System.Drawing.Point(95, 9);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(197, 27);
            this.lblUsuarios.TabIndex = 6;
            this.lblUsuarios.Text = "Gestion de Usuarios";
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.ckbTodos);
            this.grpConsulta.Controls.Add(this.txtConsultar);
            this.grpConsulta.Controls.Add(this.dgvUsuarios);
            this.grpConsulta.Controls.Add(this.btnConsultar);
            this.grpConsulta.Location = new System.Drawing.Point(95, 287);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(621, 270);
            this.grpConsulta.TabIndex = 8;
            this.grpConsulta.TabStop = false;
            // 
            // ckbTodos
            // 
            this.ckbTodos.AutoSize = true;
            this.ckbTodos.ForeColor = System.Drawing.Color.White;
            this.ckbTodos.Location = new System.Drawing.Point(511, 34);
            this.ckbTodos.Name = "ckbTodos";
            this.ckbTodos.Size = new System.Drawing.Size(60, 22);
            this.ckbTodos.TabIndex = 16;
            this.ckbTodos.Text = "Todos";
            this.ckbTodos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(641, 588);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Frm_Main_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(811, 644);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main_Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOn)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.CheckBox ckbVerPass;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.CheckBox ckbAdmin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUsr;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox ckbTodos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pcbOff;
        private System.Windows.Forms.PictureBox pcbOn;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAdmin;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colEliminar;
    }
}