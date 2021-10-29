
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lstSoporte = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSoporte = new System.Windows.Forms.GroupBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.cmbTipoMascota = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTM = new System.Windows.Forms.Label();
            this.lblSoporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(34, 282);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(453, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(290, 282);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(206, 282);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lstSoporte
            // 
            this.lstSoporte.Enabled = false;
            this.lstSoporte.FormattingEnabled = true;
            this.lstSoporte.ItemHeight = 15;
            this.lstSoporte.Location = new System.Drawing.Point(32, 127);
            this.lstSoporte.Name = "lstSoporte";
            this.lstSoporte.Size = new System.Drawing.Size(337, 79);
            this.lstSoporte.TabIndex = 12;
            this.lstSoporte.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(121, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblSoporte
            // 
            this.lblSoporte.Controls.Add(this.rtxtDescripcion);
            this.lblSoporte.Controls.Add(this.lblSexo);
            this.lblSoporte.Controls.Add(this.rdbF);
            this.lblSoporte.Controls.Add(this.rdbM);
            this.lblSoporte.Controls.Add(this.cmbTipoMascota);
            this.lblSoporte.Controls.Add(this.lstSoporte);
            this.lblSoporte.Controls.Add(this.txtCodigo);
            this.lblSoporte.Controls.Add(this.lblCodigo);
            this.lblSoporte.Controls.Add(this.txtNombre);
            this.lblSoporte.Controls.Add(this.lblNombre);
            this.lblSoporte.Controls.Add(this.lblTM);
            this.lblSoporte.Location = new System.Drawing.Point(34, 29);
            this.lblSoporte.Name = "lblSoporte";
            this.lblSoporte.Size = new System.Drawing.Size(494, 230);
            this.lblSoporte.TabIndex = 10;
            this.lblSoporte.TabStop = false;
            this.lblSoporte.Text = "Soporte";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Enabled = false;
            this.rtxtDescripcion.Location = new System.Drawing.Point(32, 127);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(422, 60);
            this.rtxtDescripcion.TabIndex = 11;
            this.rtxtDescripcion.Text = "";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(291, 35);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(35, 15);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.Visible = false;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(394, 33);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 19);
            this.rdbF.TabIndex = 9;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            this.rdbF.Visible = false;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(346, 33);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(36, 19);
            this.rdbM.TabIndex = 8;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            this.rdbM.Visible = false;
            // 
            // cmbTipoMascota
            // 
            this.cmbTipoMascota.Enabled = false;
            this.cmbTipoMascota.FormattingEnabled = true;
            this.cmbTipoMascota.Location = new System.Drawing.Point(134, 98);
            this.cmbTipoMascota.Name = "cmbTipoMascota";
            this.cmbTipoMascota.Size = new System.Drawing.Size(291, 23);
            this.cmbTipoMascota.TabIndex = 6;
            this.cmbTipoMascota.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(93, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 23);
            this.txtCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(31, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(93, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTM
            // 
            this.lblTM.AutoSize = true;
            this.lblTM.Location = new System.Drawing.Point(31, 101);
            this.lblTM.Name = "lblTM";
            this.lblTM.Size = new System.Drawing.Size(97, 15);
            this.lblTM.TabIndex = 0;
            this.lblTM.Text = "Tipo de Mascota:";
            // 
            // Frm_Soporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 324);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblSoporte);
            this.Name = "Frm_Soporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Soporte";
            this.Load += new System.EventHandler(this.Frm_Soporte_Load);
            this.lblSoporte.ResumeLayout(false);
            this.lblSoporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListBox lstSoporte;
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
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnCancelar;
    }
}