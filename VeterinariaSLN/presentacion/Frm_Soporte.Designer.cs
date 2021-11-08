
namespace VeterinariaSLN.presentacion
{
    partial class Frm_Soporte
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSoporte = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDuenio = new System.Windows.Forms.TextBox();
            this.lblDuenio = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.cmbTipoMascota = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTM = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSoporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(160, 314);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 36);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblSoporte
            // 
            this.lblSoporte.Controls.Add(this.nudEdad);
            this.lblSoporte.Controls.Add(this.txtDuenio);
            this.lblSoporte.Controls.Add(this.lblDuenio);
            this.lblSoporte.Controls.Add(this.lblEdad);
            this.lblSoporte.Controls.Add(this.lblSexo);
            this.lblSoporte.Controls.Add(this.rdbF);
            this.lblSoporte.Controls.Add(this.rdbM);
            this.lblSoporte.Controls.Add(this.cmbTipoMascota);
            this.lblSoporte.Controls.Add(this.txtCodigo);
            this.lblSoporte.Controls.Add(this.lblCodigo);
            this.lblSoporte.Controls.Add(this.txtNombre);
            this.lblSoporte.Controls.Add(this.lblNombre);
            this.lblSoporte.Controls.Add(this.lblTM);
            this.lblSoporte.Location = new System.Drawing.Point(59, 59);
            this.lblSoporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSoporte.Name = "lblSoporte";
            this.lblSoporte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSoporte.Size = new System.Drawing.Size(683, 239);
            this.lblSoporte.TabIndex = 10;
            this.lblSoporte.TabStop = false;
            // 
            // nudEdad
            // 
            this.nudEdad.Enabled = false;
            this.nudEdad.Location = new System.Drawing.Point(416, 42);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(182, 23);
            this.nudEdad.TabIndex = 17;
            this.nudEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDuenio
            // 
            this.txtDuenio.Enabled = false;
            this.txtDuenio.Location = new System.Drawing.Point(416, 95);
            this.txtDuenio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuenio.Name = "txtDuenio";
            this.txtDuenio.Size = new System.Drawing.Size(182, 23);
            this.txtDuenio.TabIndex = 16;
            // 
            // lblDuenio
            // 
            this.lblDuenio.AutoSize = true;
            this.lblDuenio.Location = new System.Drawing.Point(338, 98);
            this.lblDuenio.Name = "lblDuenio";
            this.lblDuenio.Size = new System.Drawing.Size(63, 18);
            this.lblDuenio.TabIndex = 15;
            this.lblDuenio.Text = "Dueño/a:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(359, 44);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 18);
            this.lblEdad.TabIndex = 13;
            this.lblEdad.Text = "Edad:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(359, 143);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 18);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(469, 141);
            this.rdbF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(35, 22);
            this.rdbF.TabIndex = 9;
            this.rdbF.Text = "H";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Checked = true;
            this.rdbM.Location = new System.Drawing.Point(416, 141);
            this.rdbM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(36, 22);
            this.rdbM.TabIndex = 8;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // cmbTipoMascota
            // 
            this.cmbTipoMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMascota.Enabled = false;
            this.cmbTipoMascota.FormattingEnabled = true;
            this.cmbTipoMascota.Location = new System.Drawing.Point(58, 165);
            this.cmbTipoMascota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoMascota.Name = "cmbTipoMascota";
            this.cmbTipoMascota.Size = new System.Drawing.Size(244, 26);
            this.cmbTipoMascota.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(120, 41);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 23);
            this.txtCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(58, 44);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 18);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(120, 95);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(58, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTM
            // 
            this.lblTM.AutoSize = true;
            this.lblTM.Location = new System.Drawing.Point(58, 143);
            this.lblTM.Name = "lblTM";
            this.lblTM.Size = new System.Drawing.Size(108, 18);
            this.lblTM.TabIndex = 0;
            this.lblTM.Text = "Tipo de Mascota:";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(261, 314);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 36);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(367, 314);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(667, 314);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.Location = new System.Drawing.Point(59, 314);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(59, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(53, 18);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Soporte";
            // 
            // Frm_Soporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(803, 388);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblSoporte);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Soporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Soporte";
            this.Load += new System.EventHandler(this.Frm_Soporte_Load);
            this.lblSoporte.ResumeLayout(false);
            this.lblSoporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox lblSoporte;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.ComboBox cmbTipoMascota;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTM;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDuenio;
        private System.Windows.Forms.TextBox txtDuenio;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
    }
}