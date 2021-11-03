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
    enum CONSULTA_HISTORIA { 
        SI,
        NO
    }
    public partial class Frm_ABMC_Atenciones : Form
    {
        Cliente oCliente = new Cliente();
        Mascota oMascota = new Mascota();
        Atencion oAtencion = new Atencion();
        List<Atencion> lstAtenciones = new List<Atencion>();
        CONSULTA_HISTORIA consulto = CONSULTA_HISTORIA.NO;
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
            if (String.IsNullOrEmpty(rtxtDescripcion.Text) || String.IsNullOrEmpty(txtImporte.Text))
            {
                MessageBox.Show("Existen campos sin completar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rtxtDescripcion.Text.Length > 100)
            {
                MessageBox.Show("El campo descripcion no debe superar los 100 caracteres", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                //para cuando es un entero
                int cantDigitos = 6;

                //para cuando es con coma
                for (int i = 0; i < txtImporte.Text.Length; i++)
                {
                    if (i > 0 && i < 7 && txtImporte.Text[i].ToString() == ",")
                    {
                        cantDigitos = 9;
                    }
                    
                }
                
                if (txtImporte.Text.Length > cantDigitos)
                {
                    MessageBox.Show("El campo importe no debe superar los "+ cantDigitos +" digitos", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else {
                    oAtencion.Importe = Convert.ToDouble(txtImporte.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El campo importe debe ser numerico", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            oAtencion.Descripcion = rtxtDescripcion.Text;

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

                    if (consulto == CONSULTA_HISTORIA.SI) {
                        await ActualizarHistorial();
                    }

                }
                else
                {
                    MessageBox.Show("La Atencion NO fue guardada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Atencion att in oMascota.Atenciones)
                    {
                        if (oAtencion.IdAtencion == att.IdAtencion) {
                            oMascota.Atenciones.Remove(oAtencion);
                            break;
                        }
                    }
                }
            }

        }

        private async void btnConsultarHistorial_Click(object sender, EventArgs e)
        {
            consulto = CONSULTA_HISTORIA.SI;
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

                if (lstAtenciones.Count == 0) {
                    MessageBox.Show("No existen atenciones para esta mascota", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvHistorial.CurrentCell.ColumnIndex == 4)
            {
                int codigo = Convert.ToInt32(dgvHistorial.CurrentRow.Cells["colCodigo"].Value.ToString());

                Atencion att2 = new Atencion();

                foreach (Atencion att in lstAtenciones)
                {
                    if (att.IdAtencion == codigo)
                    {
                        att2 = att;
                        break;
                    }
                }

                Frm_Soporte frmSoporte = new Frm_Soporte(att2, null, Accion.NN);
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
