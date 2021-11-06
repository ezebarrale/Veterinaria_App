using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaSLN.presentacion
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            panelIzquiedo.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AbrirFormEnPanel(object FormHijo) {

            if (this.panelContenedor.Controls.Count > 0) 
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Frm_ABMC_TipoMascota());
        }

        private void btnAtenciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Frm_Main_Atenciones());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Frm_About());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.panelContenedor.Controls.Clear();
        }
    }
}
