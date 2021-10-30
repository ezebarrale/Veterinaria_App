
namespace VeterinariaSLN.presentacion
{
    partial class Frm_Main_Atenciones
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
            this.lbl_Select = new System.Windows.Forms.Label();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblSelectCliente = new System.Windows.Forms.Label();
            this.btnGCliente = new System.Windows.Forms.Button();
            this.lsbClientes = new System.Windows.Forms.ListBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpMascota = new System.Windows.Forms.GroupBox();
            this.btnGMascota = new System.Windows.Forms.Button();
            this.lsbMascotas = new System.Windows.Forms.ListBox();
            this.lblSelectMascota = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnSalirMain = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Select
            // 
            this.lbl_Select.AutoSize = true;
            this.lbl_Select.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Select.Location = new System.Drawing.Point(64, 40);
            this.lbl_Select.Name = "lbl_Select";
            this.lbl_Select.Size = new System.Drawing.Size(686, 25);
            this.lbl_Select.TabIndex = 0;
            this.lbl_Select.Text = "Para registrar una atencion primero debe seleccionar un cliente con su mascota:";
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblSelectCliente);
            this.grpCliente.Controls.Add(this.btnGCliente);
            this.grpCliente.Controls.Add(this.lsbClientes);
            this.grpCliente.Controls.Add(this.btnBuscarCliente);
            this.grpCliente.Controls.Add(this.txtNombreCliente);
            this.grpCliente.Controls.Add(this.lblNombre);
            this.grpCliente.Location = new System.Drawing.Point(33, 98);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(368, 305);
            this.grpCliente.TabIndex = 1;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // lblSelectCliente
            // 
            this.lblSelectCliente.AutoSize = true;
            this.lblSelectCliente.Location = new System.Drawing.Point(35, 100);
            this.lblSelectCliente.Name = "lblSelectCliente";
            this.lblSelectCliente.Size = new System.Drawing.Size(175, 15);
            this.lblSelectCliente.TabIndex = 9;
            this.lblSelectCliente.Text = "Seleccione un Cliente de la lista:";
            // 
            // btnGCliente
            // 
            this.btnGCliente.Enabled = false;
            this.btnGCliente.Location = new System.Drawing.Point(107, 254);
            this.btnGCliente.Name = "btnGCliente";
            this.btnGCliente.Size = new System.Drawing.Size(146, 23);
            this.btnGCliente.TabIndex = 8;
            this.btnGCliente.Text = "Gestionar Clientes";
            this.btnGCliente.UseVisualStyleBackColor = true;
            this.btnGCliente.Click += new System.EventHandler(this.btnGCliente_Click);
            // 
            // lsbClientes
            // 
            this.lsbClientes.Enabled = false;
            this.lsbClientes.FormattingEnabled = true;
            this.lsbClientes.ItemHeight = 15;
            this.lsbClientes.Location = new System.Drawing.Point(96, 134);
            this.lsbClientes.Name = "lsbClientes";
            this.lsbClientes.Size = new System.Drawing.Size(171, 94);
            this.lsbClientes.TabIndex = 7;
            this.lsbClientes.Click += new System.EventHandler(this.lsbClientes_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(273, 46);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(96, 47);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(171, 23);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // grpMascota
            // 
            this.grpMascota.Controls.Add(this.btnGMascota);
            this.grpMascota.Controls.Add(this.lsbMascotas);
            this.grpMascota.Controls.Add(this.lblSelectMascota);
            this.grpMascota.Enabled = false;
            this.grpMascota.Location = new System.Drawing.Point(424, 98);
            this.grpMascota.Name = "grpMascota";
            this.grpMascota.Size = new System.Drawing.Size(368, 305);
            this.grpMascota.TabIndex = 2;
            this.grpMascota.TabStop = false;
            this.grpMascota.Text = "Mascota";
            // 
            // btnGMascota
            // 
            this.btnGMascota.Enabled = false;
            this.btnGMascota.Location = new System.Drawing.Point(113, 254);
            this.btnGMascota.Name = "btnGMascota";
            this.btnGMascota.Size = new System.Drawing.Size(146, 23);
            this.btnGMascota.TabIndex = 10;
            this.btnGMascota.Text = "Gestionar Mascotas";
            this.btnGMascota.UseVisualStyleBackColor = true;
            this.btnGMascota.Click += new System.EventHandler(this.btnGMascota_Click);
            // 
            // lsbMascotas
            // 
            this.lsbMascotas.FormattingEnabled = true;
            this.lsbMascotas.ItemHeight = 15;
            this.lsbMascotas.Location = new System.Drawing.Point(99, 100);
            this.lsbMascotas.Name = "lsbMascotas";
            this.lsbMascotas.Size = new System.Drawing.Size(171, 124);
            this.lsbMascotas.TabIndex = 10;
            this.lsbMascotas.Click += new System.EventHandler(this.lsbMascotas_Click);
            // 
            // lblSelectMascota
            // 
            this.lblSelectMascota.AutoSize = true;
            this.lblSelectMascota.Location = new System.Drawing.Point(39, 54);
            this.lblSelectMascota.Name = "lblSelectMascota";
            this.lblSelectMascota.Size = new System.Drawing.Size(189, 15);
            this.lblSelectMascota.TabIndex = 10;
            this.lblSelectMascota.Text = "Seleccione una Mascota de la lista:";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Enabled = false;
            this.btnRegistar.Location = new System.Drawing.Point(631, 418);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(161, 23);
            this.btnRegistar.TabIndex = 3;
            this.btnRegistar.Text = "Registrar nueva atencion";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnSalirMain
            // 
            this.btnSalirMain.Location = new System.Drawing.Point(717, 459);
            this.btnSalirMain.Name = "btnSalirMain";
            this.btnSalirMain.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMain.TabIndex = 4;
            this.btnSalirMain.Text = "Salir";
            this.btnSalirMain.UseVisualStyleBackColor = true;
            this.btnSalirMain.Click += new System.EventHandler(this.btnSalirMain_Click);
            // 
            // Frm_Main_Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 494);
            this.Controls.Add(this.btnSalirMain);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.grpMascota);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.lbl_Select);
            this.MinimumSize = new System.Drawing.Size(843, 525);
            this.Name = "Frm_Main_Atenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenciones";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpMascota.ResumeLayout(false);
            this.grpMascota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Select;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpMascota;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label lblSelectCliente;
        private System.Windows.Forms.Button btnGCliente;
        private System.Windows.Forms.ListBox lsbClientes;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.ListBox lsbMascotas;
        private System.Windows.Forms.Label lblSelectMascota;
        private System.Windows.Forms.Button btnGMascota;
        private System.Windows.Forms.Button btnSalirMain;
    }
}