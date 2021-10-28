using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaBack.dominio;

namespace VeterinariaSLN.presentacion
{
    public partial class Frm_ABMC_Atenciones : Form
    {
        public Frm_ABMC_Atenciones(Cliente oCliente, Mascota oMascota)
        {
            InitializeComponent();
            txtClienteA.Text = oCliente.Nombre;
            txtMascotaA.Text = oMascota.Nombre;
        }
    }
}
