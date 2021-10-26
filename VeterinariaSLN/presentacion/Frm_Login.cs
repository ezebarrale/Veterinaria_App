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
            string url = "https://localhost:44350/api/Access?usr=" + txtUsuario.Text + "&pass=" + txtPass.Text;
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();
            bool exito = JsonConvert.DeserializeObject<bool>(bodyJSON);

            if (exito)
            {
                this.Dispose();       
            }
            else
            {
                MessageBox.Show("EL usuario o contraseña ingresado no es correcto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
