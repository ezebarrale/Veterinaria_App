using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaBack.dominio;
using VeterinariaSLN.cliente;
using VeterinariaSLN.presentacion;

namespace VeterinariaSLN
{
    public partial class Frm_Login : Form
    {
        Frm_Menu frmMenu;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            await ValidarUsuario();

        }

        private async Task ValidarUsuario()
        {
            Usuario usr = new Usuario();
            usr.User = txtUsuario.Text;
            usr.Password = txtPass.Text;

            bool result = await ConsultarUsuarioAsync(usr);

            if (result) {
                frmMenu = new Frm_Menu(usr);
                frmMenu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("EL usuario o contraseña ingresado no es correcto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async Task<bool> ConsultarUsuarioAsync(Usuario usr)
        {
            string url = "https://localhost:44350/api/Access";
            var data = JsonConvert.SerializeObject(usr);
            bool result = await ClienteSingleton.GetInstance().PostAsync(url, data);

            return result;
        }

        private void llblSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
