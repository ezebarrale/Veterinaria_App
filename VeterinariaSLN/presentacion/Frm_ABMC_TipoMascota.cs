using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaBack.dominio;

namespace VeterinariaSLN.presentacion
{
    public partial class Frm_ABMC_TipoMascota : Form
    {
        List<TipoMascota> lstTipoMascotas;
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
            lstTM.DataSource = null;

            string url = "https://localhost:44350/api/TipoMascotas";
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();
            lstTipoMascotas = JsonConvert.DeserializeObject<List<TipoMascota>>(bodyJSON);

            lstTM.DataSource = lstTipoMascotas;
            lstTM.DisplayMember = "Nombre";
            lstTM.ValueMember = "IdTipoMascota";

        }

        private async void btnGuardarTM_Click(object sender, EventArgs e)
        {
            TipoMascota tm = new TipoMascota();
            tm.Nombre = txtTM.Text;

            string url = "https://localhost:44350/api/TipoMascotas";
            HttpClient cliente = new HttpClient();

            var data = JsonConvert.SerializeObject(tm);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var result = await cliente.PostAsync(url, content);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                lstTipoMascotas.Add(JsonConvert.DeserializeObject<TipoMascota>(bodyJSON));

                ActualizarLista();

                MessageBox.Show("Tipo de Mascota guardada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTM.Text = "";
            }
            else {
                MessageBox.Show("Tipo de Mascota NO fue guardada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ActualizarLista()
        {
            lstTM.DataSource = null;

            lstTM.DataSource = lstTipoMascotas;
            lstTM.DisplayMember = "Nombre";
            lstTM.ValueMember = "IdTipoMascota";
        }

        private void btnSalirTM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lstTM_Click(object sender, EventArgs e)
        {
            txtTM.Text = lstTM.SelectedItem.ToString();
            HabilitarBotones(true);

        }
        private void txtTM_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotones(false);
        }
        private void HabilitarBotones(bool s)
        {
            btnEditarTM.Enabled = s;
            btnEliminarTM.Enabled = s;
            btnGuardarTM.Enabled = !s;
        }

        private async void btnEliminarTM_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Seguro desea eliminar este tipo de mascota?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (msg.Equals(DialogResult.OK)) {
                TipoMascota tm = new TipoMascota();
                tm.IdTipoMascota = Convert.ToInt32(lstTM.SelectedValue.ToString());
                tm.Nombre = lstTM.SelectedItem.ToString();

                string url = "https://localhost:44350/api/TipoMascotas";
                HttpClient cliente = new HttpClient();

                var data = JsonConvert.SerializeObject(tm);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                var result = await cliente.PutAsync(url, content);

                if (result.IsSuccessStatusCode)
                {
                    foreach (TipoMascota oTm in lstTipoMascotas)
                    {
                        if (oTm.IdTipoMascota == tm.IdTipoMascota) {
                            lstTipoMascotas.Remove(oTm);
                            break;
                        }       
                    }
                    
                    ActualizarLista();

                    MessageBox.Show("Tipo de Mascota eliminada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtTM.Text = "";
                }
                else
                {
                    MessageBox.Show("Tipo de Mascota NO fue eliminada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
