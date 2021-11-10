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
        private Cliente oCliente = new Cliente();
        private Mascota oMascota = new Mascota();
        private Atencion oAtencion = new Atencion();

        private List<Veterinario> lstVeterinarios = new List<Veterinario>();
        private int idDetalle = 1;
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
            await CargarComboVeterinarios();
        }

        private async Task CargarComboVeterinarios()
        {
            string url = "https://localhost:44350/api/Veterinarios";
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();
            lstVeterinarios = JsonConvert.DeserializeObject<List<Veterinario>>(bodyJSON);

            cmbVet.DataSource = lstVeterinarios;
            cmbVet.DisplayMember = "FakeNombre";
            cmbVet.ValueMember = "Codigo";
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

            DialogResult resultado = MessageBox.Show("Seguro desea Registrar esta Atencion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) {
                oMascota.RemoveAtenciones();

                foreach (Veterinario vet in lstVeterinarios)
                {
                    if (vet.Codigo == Convert.ToInt32(cmbVet.SelectedValue.ToString()))
                    {
                        oAtencion.oVeterinario = vet;
                    }
                }

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

                    if (exito)
                    {
                        MessageBox.Show("Atencion guardada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("La Atencion NO fue guardada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvHistorial.CurrentCell.ColumnIndex == 3)
            {
                int codigo = Convert.ToInt32(dgvHistorial.CurrentRow.Cells["colCodigo"].Value.ToString());

                foreach (DetalleAtencion det in oAtencion.Detalles)
                {
                    if (det.IdDetalle == codigo)
                    {
                        DialogResult result = MessageBox.Show("Seguro desea eliminar este detalle?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) {

                            oAtencion.RemoveDetalle(det);
                        }
                        
                        break;
                    }
                }

                ActualizarListaDetalle();
            }
        }

        private void ActualizarListaDetalle()
        {
            dgvHistorial.Rows.Clear();

            foreach (DetalleAtencion detalle in oAtencion.Detalles)
            {
                dgvHistorial.Rows.Add(new Object[] {
                                            detalle.IdDetalle,
                                            detalle.Descripcion,
                                            detalle.Importe
                                            });
            }

            if (oAtencion.Detalles.Count() == 0)
                btnRegistrarA.Enabled = false;
        }

        private void btnSalirA_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrarDetalle_Click(object sender, EventArgs e)
        {
            DetalleAtencion oDetalle = new DetalleAtencion();

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

                    if (txtImporte.Text[i].ToString() == ".")
                    {
                        MessageBox.Show("El campo importe no debe contener el caracter \" . \" (punto)", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }

                if (txtImporte.Text.Length > cantDigitos)
                {
                    MessageBox.Show("El campo importe no debe superar los " + cantDigitos + " digitos", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    try
                    {
                        oDetalle.Importe = Convert.ToDouble(txtImporte.Text);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Este campo solo admite numeros", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El campo importe debe ser numerico", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            oDetalle.Descripcion = rtxtDescripcion.Text;
            oDetalle.IdDetalle = idDetalle;

            idDetalle++;

            oAtencion.AddDetalle(oDetalle);

            dgvHistorial.Rows.Clear();
            foreach (DetalleAtencion detalle in oAtencion.Detalles)
            {
                dgvHistorial.Rows.Add(new Object[] {
                                            detalle.IdDetalle,
                                            detalle.Descripcion,
                                            detalle.Importe
                                            });
            }

            rtxtDescripcion.Text = "";
            txtImporte.Text = "";
            btnRegistrarA.Enabled = true;

        }

    }
}
