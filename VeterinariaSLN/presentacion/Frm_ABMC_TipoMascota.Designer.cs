
namespace VeterinariaSLN.presentacion
{
    partial class Frm_ABMC_TipoMascota
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
            this.grpbTM = new System.Windows.Forms.GroupBox();
            this.txtTM = new System.Windows.Forms.TextBox();
            this.lblTM = new System.Windows.Forms.Label();
            this.btnGuardarTM = new System.Windows.Forms.Button();
            this.lstTM = new System.Windows.Forms.ListBox();
            this.btnEditarTM = new System.Windows.Forms.Button();
            this.btnEliminarTM = new System.Windows.Forms.Button();
            this.btnSalirTM = new System.Windows.Forms.Button();
            this.lblListTM = new System.Windows.Forms.Label();
            this.btnNuevoTM = new System.Windows.Forms.Button();
            this.grpbTM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbTM
            // 
            this.grpbTM.Controls.Add(this.txtTM);
            this.grpbTM.Controls.Add(this.lblTM);
            this.grpbTM.Location = new System.Drawing.Point(38, 49);
            this.grpbTM.Name = "grpbTM";
            this.grpbTM.Size = new System.Drawing.Size(450, 169);
            this.grpbTM.TabIndex = 1;
            this.grpbTM.TabStop = false;
            this.grpbTM.Text = "Alta de Tipo de Mascotas";
            // 
            // txtTM
            // 
            this.txtTM.Enabled = false;
            this.txtTM.Location = new System.Drawing.Point(149, 71);
            this.txtTM.Name = "txtTM";
            this.txtTM.Size = new System.Drawing.Size(259, 23);
            this.txtTM.TabIndex = 1;
            this.txtTM.TextChanged += new System.EventHandler(this.txtTM_TextChanged);
            // 
            // lblTM
            // 
            this.lblTM.AutoSize = true;
            this.lblTM.Location = new System.Drawing.Point(37, 74);
            this.lblTM.Name = "lblTM";
            this.lblTM.Size = new System.Drawing.Size(97, 15);
            this.lblTM.TabIndex = 0;
            this.lblTM.Text = "Tipo de Mascota:";
            // 
            // btnGuardarTM
            // 
            this.btnGuardarTM.Enabled = false;
            this.btnGuardarTM.Location = new System.Drawing.Point(161, 254);
            this.btnGuardarTM.Name = "btnGuardarTM";
            this.btnGuardarTM.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTM.TabIndex = 2;
            this.btnGuardarTM.Text = "Guardar";
            this.btnGuardarTM.UseVisualStyleBackColor = true;
            this.btnGuardarTM.Click += new System.EventHandler(this.btnGuardarTM_Click);
            // 
            // lstTM
            // 
            this.lstTM.FormattingEnabled = true;
            this.lstTM.ItemHeight = 15;
            this.lstTM.Location = new System.Drawing.Point(507, 79);
            this.lstTM.Name = "lstTM";
            this.lstTM.Size = new System.Drawing.Size(239, 139);
            this.lstTM.TabIndex = 3;
            this.lstTM.Click += new System.EventHandler(this.lstTM_Click);
            // 
            // btnEditarTM
            // 
            this.btnEditarTM.Enabled = false;
            this.btnEditarTM.Location = new System.Drawing.Point(261, 254);
            this.btnEditarTM.Name = "btnEditarTM";
            this.btnEditarTM.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTM.TabIndex = 5;
            this.btnEditarTM.Text = "Editar";
            this.btnEditarTM.UseVisualStyleBackColor = true;
            this.btnEditarTM.Click += new System.EventHandler(this.btnEditarTM_Click);
            // 
            // btnEliminarTM
            // 
            this.btnEliminarTM.Enabled = false;
            this.btnEliminarTM.Location = new System.Drawing.Point(357, 254);
            this.btnEliminarTM.Name = "btnEliminarTM";
            this.btnEliminarTM.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTM.TabIndex = 6;
            this.btnEliminarTM.Text = "Eliminar";
            this.btnEliminarTM.UseVisualStyleBackColor = true;
            this.btnEliminarTM.Click += new System.EventHandler(this.btnEliminarTM_Click);
            // 
            // btnSalirTM
            // 
            this.btnSalirTM.Location = new System.Drawing.Point(653, 254);
            this.btnSalirTM.Name = "btnSalirTM";
            this.btnSalirTM.Size = new System.Drawing.Size(75, 23);
            this.btnSalirTM.TabIndex = 7;
            this.btnSalirTM.Text = "Salir";
            this.btnSalirTM.UseVisualStyleBackColor = true;
            this.btnSalirTM.Click += new System.EventHandler(this.btnSalirTM_Click);
            // 
            // lblListTM
            // 
            this.lblListTM.AutoSize = true;
            this.lblListTM.Location = new System.Drawing.Point(507, 49);
            this.lblListTM.Name = "lblListTM";
            this.lblListTM.Size = new System.Drawing.Size(157, 15);
            this.lblListTM.TabIndex = 8;
            this.lblListTM.Text = "Tipo de Mascotas existentes:";
            // 
            // btnNuevoTM
            // 
            this.btnNuevoTM.Location = new System.Drawing.Point(61, 254);
            this.btnNuevoTM.Name = "btnNuevoTM";
            this.btnNuevoTM.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoTM.TabIndex = 9;
            this.btnNuevoTM.Text = "Nuevo";
            this.btnNuevoTM.UseVisualStyleBackColor = true;
            this.btnNuevoTM.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Frm_ABMC_TipoMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 314);
            this.Controls.Add(this.btnNuevoTM);
            this.Controls.Add(this.lblListTM);
            this.Controls.Add(this.btnSalirTM);
            this.Controls.Add(this.btnEliminarTM);
            this.Controls.Add(this.btnEditarTM);
            this.Controls.Add(this.lstTM);
            this.Controls.Add(this.btnGuardarTM);
            this.Controls.Add(this.grpbTM);
            this.MinimumSize = new System.Drawing.Size(804, 353);
            this.Name = "Frm_ABMC_TipoMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Mascotas";
            this.Load += new System.EventHandler(this.Frm_ABMC_TipoMascota_Load);
            this.grpbTM.ResumeLayout(false);
            this.grpbTM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbTM;
        private System.Windows.Forms.TextBox txtTM;
        private System.Windows.Forms.Label lblTM;
        private System.Windows.Forms.Button btnGuardarTM;
        private System.Windows.Forms.ListBox lstTM;
        private System.Windows.Forms.Button btnEditarTM;
        private System.Windows.Forms.Button btnEliminarTM;
        private System.Windows.Forms.Button btnSalirTM;
        private System.Windows.Forms.Label lblListTM;
        private System.Windows.Forms.Button btnNuevoTM;
    }
}