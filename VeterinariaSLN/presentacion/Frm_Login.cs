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
using VeterinariaSLN.presentacion;

namespace VeterinariaSLN
{
    public partial class Frm_Login : Form
    {
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

            string url = "https://localhost:44350/api/Access";
            HttpClient client = new HttpClient();

            var data = JsonConvert.SerializeObject(usr);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var result = await client.PostAsync(url, content);

            if (result.IsSuccessStatusCode)
                this.Dispose();
            else
                MessageBox.Show("EL usuario o contraseña ingresado no es correcto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
