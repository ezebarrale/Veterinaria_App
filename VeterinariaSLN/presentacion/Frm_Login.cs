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
        private Frm_Menu frmMenu;
        private Usuario usr = new Usuario();

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

        private async Task<bool> ConsultarUsuarioAsync(Usuario oUsuario)
        {
            bool resultado = false;

            string url = "https://localhost:44350/api/Access";
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(oUsuario);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                usr = JsonConvert.DeserializeObject<Usuario>(bodyJSON);

                resultado = true;
            }

            return resultado;
        }

        private void llblSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
