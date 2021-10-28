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
    public enum Tipo
    {
        CLIENTE,
        MASCOTA,
        ATENCION
    }
    public enum Accion
    {
        CREATE,
        UPDATE,
        DELETE
    }
    public partial class Frm_Main_Atenciones : Form
    {
        private List<Cliente> lstClientes;
        private List<Mascota> lstMascotas;
        Cliente oCliente = new Cliente();
        Mascota oMascota = new Mascota();
        public Frm_Main_Atenciones()
        {
            InitializeComponent();
        }

        private void btnGCliente_Click(object sender, EventArgs e)
        {
            Frm_Soporte frmSoporte = new Frm_Soporte();
            frmSoporte.ShowDialog();
        }

        private void btnGMascota_Click(object sender, EventArgs e)
        {
            Frm_Soporte frmSoporte = new Frm_Soporte();
            frmSoporte.ShowDialog();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Frm_ABMC_Atenciones FrmAtenciones = new Frm_ABMC_Atenciones(oCliente, oMascota);
            FrmAtenciones.ShowDialog();
        }

        private async void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombreCliente.Text)) {
                Cliente clt = new Cliente();
                clt.Nombre = txtNombreCliente.Text;

                string url = "https://localhost:44350/api/Clientes?nombre=" + clt.Nombre;
                HttpClient cliente = new HttpClient();
                var result = await cliente.GetAsync(url);

                if (result.IsSuccessStatusCode) {
                    var bodyJSON = await result.Content.ReadAsStringAsync();
                    lstClientes = JsonConvert.DeserializeObject<List<Cliente>>(bodyJSON);

                    lsbClientes.DataSource = lstClientes;
                    lsbClientes.DisplayMember = "Nombre";
                    lsbClientes.ValueMember = "Codigo";

                    lsbClientes.Enabled = true;
                    btnGCliente.Enabled = true;
                }

            }
            
        }

        private async void lsbClientes_Click(object sender, EventArgs e)
        {
            foreach (Cliente clt in lstClientes)
            {
                if (clt.Codigo == Convert.ToInt32(lsbClientes.SelectedValue.ToString())) {
                    oCliente = clt;
                    break;
                }
            }

            string url = "https://localhost:44350/api/Mascotas?id_cliente=" + oCliente.Codigo;
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                lstMascotas = JsonConvert.DeserializeObject<List<Mascota>>(bodyJSON);

                foreach (Mascota oMascota in lstMascotas)
                {
                    oCliente.AgregarMascota(oMascota);
                }
                
                lsbMascotas.DataSource = lstMascotas;
                lsbMascotas.DisplayMember = "Nombre";
                lsbMascotas.ValueMember = "IdMascota";
            }

            grpMascota.Enabled = true;
        }

        private void lsbMascotas_Click(object sender, EventArgs e)
        {
            btnGMascota.Enabled = true;
            btnRegistar.Enabled = true;

            foreach (Mascota msct in oCliente.Mascotas)
            {
                if (msct.IdMascota == Convert.ToInt32(lsbMascotas.SelectedValue.ToString())) {
                    oMascota = msct;
                }
            }
        }
    }
}
