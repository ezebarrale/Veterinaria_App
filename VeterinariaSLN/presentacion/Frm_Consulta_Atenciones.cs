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
    public partial class Frm_Consulta_Atenciones : Form
    {
        private Atencion oAtencion;
        private Veterinario oVeterinario;
        private Mascota oMascota;
        private List<Veterinario> lstVeterinarios;
        private List<DetalleAtencion> detallesA;
        public Frm_Consulta_Atenciones(Atencion att, Mascota msct)
        {
            InitializeComponent();
            oAtencion = att;
            oMascota = msct;
        }

        private async void Frm_Consulta_Atenciones_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = oAtencion.IdAtencion.ToString();
            txtFecha.Text = oAtencion.Fecha.ToString();
            txtMascota.Text = oMascota.Nombre;

            await CargarComboVeterinarios();
            cmbVet.SelectedValue = oAtencion.oVeterinario.Codigo;
            await CargarDetalles();
        }

        private async Task CargarDetalles()
        {
            string url = "https://localhost:44350/api/Atenciones/details";
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(oAtencion);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                detallesA = JsonConvert.DeserializeObject<List<DetalleAtencion>>(bodyJSON);

                foreach (DetalleAtencion dtt in detallesA)
                {
                    dgvHistorial.Rows.Add(new Object[] {
                                        dtt.IdDetalle,
                                        dtt.Descripcion,
                                        dtt.Importe
                                        });
                }
            }
            else
            {
                MessageBox.Show("No se pudieron obtener las lista de detalles de esta atencion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task CargarComboVeterinarios()
        {
            string url = "https://localhost:44350/api/Veterinarios";
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();
            lstVeterinarios = JsonConvert.DeserializeObject<List<Veterinario>>(bodyJSON);

            cmbVet.DataSource = lstVeterinarios;
            cmbVet.DisplayMember = "Nombre";
            cmbVet.ValueMember = "Codigo";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea eliminar esta atencion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string msjE = "Se eliminó con exito la Atencion";
                string msjNE = "No se pudo eliminar con exito la Atencion";
                await ModificarAtencion("delete", msjE, msjNE);

            }
            else {
                return;
            }

        }

        private async Task ModificarAtencion(string operation, string msjExito, string msjNoExito)
        {
            string url = "https://localhost:44350/api/Atenciones/"+operation;
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(oAtencion);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);


            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                bool exito = JsonConvert.DeserializeObject<bool>(bodyJSON);

                if (exito)
                {
                    MessageBox.Show(msjExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (operation == "delete")
                    {
                        oMascota.RemoveAtencion(oAtencion);
                        this.Dispose();
                    }
                    else {
                        cmbVet.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show(msjNoExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else {
                MessageBox.Show(msjNoExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cmbVet.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            int vetSelected = Convert.ToInt32(cmbVet.SelectedValue.ToString());

            foreach (Veterinario vet in lstVeterinarios)
            {
                if (vet.Codigo == vetSelected) {
                    oVeterinario = vet;
                    break;
                }
            }

            oAtencion.oVeterinario = oVeterinario;

            DialogResult result = MessageBox.Show("Seguro desea guardar los cambios sobre esta atencion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string msjE = "Se actualizó con exito la Atencion";
                string msjNE = "No se pudo actualizar con exito la Atencion";
                await ModificarAtencion("update", msjE, msjNE);

            }
            else
            {
                return;
            }

        }
    }
}
