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
using Veterinaria_Form.dominio;

namespace VeterinariaSLN.presentacion
{
    public partial class Frm_ABMC_TipoMascota : Form
    {
        public Frm_ABMC_TipoMascota()
        {
            InitializeComponent();
        }

        private async void Frm_ABMC_TipoMascota_Load(object sender, EventArgs e)
        {
            await CargarLista();
        }

        private async Task CargarLista()
        {
            string url = "https://localhost:44350/api/TipoMascotas";
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();
            List<TipoMascota> lstTipoMascotas = JsonConvert.DeserializeObject<List<TipoMascota>>(bodyJSON);

            lstTM.DataSource = lstTipoMascotas;
            lstTM.DisplayMember = "Nombre";
            lstTM.ValueMember = "IdTipoMascota";
        }

        private void btnGuardarTM_Click(object sender, EventArgs e)
        {



            txtTM.Text = "";
        }

        private void lstTM_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditarTM.Enabled = true;
            btnEliminarTM.Enabled = true;
        }

        private void btnSalirTM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
