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
            Frm_Login frmLogin = new Frm_Login();
            frmLogin.ShowDialog();
            
        }

        private void cmsSoporte_Click(object sender, EventArgs e)
        {
            Frm_ABMC_TipoMascota frmTipoMascota = new Frm_ABMC_TipoMascota();
            frmTipoMascota.ShowDialog();
        }

        private void cmsArchivo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmsTransaccion_Opening(object sender, CancelEventArgs e)
        {
            Frm_Main_Atenciones frmMainAtenciones = new Frm_Main_Atenciones();
            frmMainAtenciones.ShowDialog();
        }
    }
}
