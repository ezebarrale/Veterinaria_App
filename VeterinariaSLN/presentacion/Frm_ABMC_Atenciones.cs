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

namespace VeterinariaSLN.presentacion
{
    public partial class Frm_ABMC_Atenciones : Form
    {
        Cliente oCliente = new Cliente();
        Mascota oMascota = new Mascota();
        Atencion oAtencion = new Atencion();
        List<Atencion> lstAtenciones = new List<Atencion>();
        public Frm_ABMC_Atenciones(Cliente clt, Mascota msct)
        {
            InitializeComponent();
            oCliente = clt;
            oMascota = msct;
        }

        private async void Frm_ABMC_Atenciones_Load(object sender, EventArgs e)
        {
            txtClienteA.Text = oCliente.Nombre;
            txtMascotaA.Text = oMascota.Nombre;
            await MostarSiguienteID();
        }

        private async Task MostarSiguienteID()
        {
            string url = "https://localhost:44350/api/Atenciones";
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();
            oAtencion = JsonConvert.DeserializeObject<Atencion>(bodyJSON);

            lblIdAtencion.Text = "ID de Atencion: " + oAtencion.IdAtencion;
        }

        private async void btnRegistrarA_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtxtDescripcion.Text) && String.IsNullOrEmpty(txtImporte.Text)) {
                MessageBox.Show("Existen campos sin completar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            oAtencion.Descripcion = rtxtDescripcion.Text;
            oAtencion.Importe = Convert.ToDouble(txtImporte.Text);

            oMascota.SaveAtencion(oAtencion);

            string url = "https://localhost:44350/api/Atenciones";
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(oMascota);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                bool exito = JsonConvert.DeserializeObject<bool>(bodyJSON);

                if (exito) {
                    MessageBox.Show("Atencion guardada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    rtxtDescripcion.Text = "";
                    txtImporte.Text = "";

                }
                else
                {
                    MessageBox.Show("La Atencion NO fue guardada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private async void btnConsultarHistorial_Click(object sender, EventArgs e)
        {
            await ActualizarHistorial();
        }

        private async Task ActualizarHistorial()
        {
            dgvHistorial.Rows.Clear();

            string url = "https://localhost:44350/api/Atenciones/all";
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(oMascota);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                lstAtenciones = JsonConvert.DeserializeObject<List<Atencion>>(bodyJSON);

                foreach (Atencion att in lstAtenciones)
                {
                    dgvHistorial.Rows.Add(new Object[] {
                                            att.IdAtencion,
                                            att.Fecha,
                                            att.Descripcion,
                                            att.Importe
                                            });
                }
            }
        }

        private async void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvHistorial.CurrentCell.ColumnIndex == 4) {
                int codigo = Convert.ToInt32(dgvHistorial.CurrentRow.Cells["colCodigo"].Value.ToString());

                Atencion att2 = new Atencion();

                foreach (Atencion att in lstAtenciones)
                {
                    if (att.IdAtencion == codigo) {
                        att2 = att;
                        break;
                    }
                }

                Frm_Soporte frmSoporte = new Frm_Soporte(att2);
                frmSoporte.ShowDialog();

                await ActualizarHistorial();
            }
        }

        private void btnSalirA_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
