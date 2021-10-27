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
        private Accion modo;
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
            if (String.IsNullOrEmpty(txtTM.Text)) {
                MessageBox.Show("Debe ingresar un tipo de mascota", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTM.Text.Length >10)
            {
                MessageBox.Show("Debe ingresar un nombre de tipo de mascota mas corto", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipoMascota tm = new TipoMascota();
            tm.Nombre = txtTM.Text;

            //Si se trata de guardar un item editado
            if (modo == Accion.UPDATE) {
                

                DialogResult msg = MessageBox.Show("Seguro desea actualizar este tipo de mascota?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (msg.Equals(DialogResult.OK))
                {
                    tm.IdTipoMascota = Convert.ToInt32(lstTM.SelectedValue.ToString());
                    string url1 = "https://localhost:44350/api/TipoMascotas";
                    HttpClient client = new HttpClient();
                    var data1 = JsonConvert.SerializeObject(tm);
                    HttpContent content1 = new StringContent(data1, System.Text.Encoding.UTF8, "application/json");
                    var result1 = await client.PutAsync(url1, content1);

                    if (result1.IsSuccessStatusCode)
                    {
                        foreach (TipoMascota oTm in lstTipoMascotas)
                        {
                            if (oTm.IdTipoMascota == tm.IdTipoMascota)
                            {
                                oTm.Nombre = tm.Nombre;
                                break;
                            }
                        }

                        ActualizarLista();

                        MessageBox.Show("Tipo de Mascota actualizada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtTM.Text = "";
                        btnEliminarTM.Enabled = false;
                        btnEditarTM.Enabled = false;
                        btnGuardarTM.Enabled = false;
                        btnNuevoTM.Enabled = true;
                        txtTM.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Tipo de Mascota NO fue eliminada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return;
            }

            //Curso normal para cuando se guarda un item nuevo

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
                btnGuardarTM.Enabled = false;
                txtTM.Enabled = false;
                btnNuevoTM.Enabled = true;
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
            txtTM.Enabled = false;
            txtTM.Text = lstTM.SelectedItem.ToString();
            HabilitarBotones(true);

        }
        private void txtTM_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtTM.Text))
                HabilitarBotones(false);
        }
        private void HabilitarBotones(bool s)
        {
            btnEditarTM.Enabled = s;
            btnEliminarTM.Enabled = s;
            btnNuevoTM.Enabled = s;
            btnGuardarTM.Enabled = !s;
        }

        private async void btnEliminarTM_Click(object sender, EventArgs e)
        {
            txtTM.Enabled = false;

            DialogResult msg = MessageBox.Show("Seguro desea eliminar este tipo de mascota?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (msg.Equals(DialogResult.OK)) {
                TipoMascota tm = new TipoMascota();
                tm.IdTipoMascota = Convert.ToInt32(lstTM.SelectedValue.ToString());
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
                    btnEliminarTM.Enabled = false;
                    btnEditarTM.Enabled = false;
                    txtTM.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Tipo de Mascota NO fue eliminada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditarTM_Click(object sender, EventArgs e)
        {
            modo = Accion.UPDATE;

            grpbTM.Text = "Editar Tipo de Mascota";
            txtTM.Enabled = true;
            btnEliminarTM.Enabled = false;
            btnEditarTM.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Accion.CREATE;

            txtTM.Enabled = true;
            txtTM.Text = "";
            if(!String.IsNullOrEmpty(txtTM.Text))
                btnGuardarTM.Enabled = true;
            btnNuevoTM.Enabled = false;
            btnEditarTM.Enabled = false;
            btnEliminarTM.Enabled = false;
        }

    }
}
