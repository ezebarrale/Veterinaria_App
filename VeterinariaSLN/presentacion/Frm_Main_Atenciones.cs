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
        DELETE,
        READ,
        NN
    }
    public partial class Frm_Main_Atenciones : Form
    {
        private List<Cliente> lstClientes;
        private List<Mascota> lstMascotas;
        private Cliente oCliente = new Cliente();
        private Mascota oMascota = new Mascota();
        
        public Frm_Main_Atenciones()
        {
            InitializeComponent();
        }

        private async void btnGCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lsbClientes.SelectedValue.ToString())) {
                MessageBox.Show("Debe seleccionar un Cliente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Cliente clt in lstClientes)
            {
                if (clt.Codigo == Convert.ToInt32(lsbClientes.SelectedValue.ToString()))
                {
                    oCliente = clt;
                    break;
                }
            }

            Frm_Clientes frmClientes = new Frm_Clientes(oCliente, null, Accion.NN);
            frmClientes.Name = "Gestion de Clientes PET HOUSE";
            frmClientes.ShowDialog();

            await CompletarClientesResultado(false, true);
        }

        private async void btnGMascota_Click(object sender, EventArgs e)
        {
            Frm_Soporte frmSoporte = new Frm_Soporte(oMascota, oCliente, Accion.NN);
            frmSoporte.Name = "Gestion de Mascotas PET HOUSE";
            frmSoporte.ShowDialog();

            await CompletarClientesResultado(false, false);
        }

        private async void btnRegistar_Click(object sender, EventArgs e)
        {
            Frm_ABMC_Atenciones FrmAtenciones = new Frm_ABMC_Atenciones(oCliente, oMascota);
            FrmAtenciones.ShowDialog();

            await CompletarClientesResultado(false, true);

        }

        private async void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            await CompletarClientesResultado(true, false);
        }

        private async Task CompletarClientesResultado(bool buscar, bool nuevo)
        {
            lsbClientes.Enabled = false;
            //grpMascota.Enabled = false;
            btnRegistar.Enabled = false;
            lsbMascotas.DataSource = null;
            btnGCliente.Enabled = false;
            btnGMascota.Enabled = false;
            lsbClientes.DataSource = null;
            dgvAtenciones.Rows.Clear();


            if (txtNombreCliente.Text.Length > 20)
            {
                MessageBox.Show("Cantidad de caracteres superado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!String.IsNullOrEmpty(txtNombreCliente.Text))
            {
                string cadenaNombre = "";
                string cadenaApellido = "";

                for (int i = 0; i < txtNombreCliente.Text.Length; i++)
                {

                    if (i > 0 && txtNombreCliente.Text[i].ToString() == " ")
                    {
                        int ii = i + 1;

                        for (int j = 0; j < txtNombreCliente.Text.Length; j++)
                        {
                            if (j == ii) {
                                cadenaApellido += txtNombreCliente.Text[j];
                            }
                        }
                        break;
                    }
                    else {
                        cadenaNombre += txtNombreCliente.Text[i];
                    }

                }

                Cliente clt = new Cliente();
                clt.Nombre = cadenaNombre;
                clt.Apellido = cadenaApellido;

                string url = "https://localhost:44350/api/Clientes";
                HttpClient cliente = new HttpClient();
                var data = JsonConvert.SerializeObject(clt);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                var result = await cliente.PostAsync(url, content);

                if (result.IsSuccessStatusCode)
                {
                    var bodyJSON = await result.Content.ReadAsStringAsync();
                    lstClientes = JsonConvert.DeserializeObject<List<Cliente>>(bodyJSON);
                    
                    if (lstClientes.Count == 0 && buscar == true)
                    {
                        DialogResult resultado = MessageBox.Show("No existen clientes relacionados con ese nombre. Desea agregar uno nuevo?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            Frm_Clientes frmCliente = new Frm_Clientes(oCliente, null, Accion.CREATE);
                            frmCliente.ShowDialog();

                            return;
                        }
                        else {
                            return;
                        }
                        
                    }
                    else
                    {
                        lsbClientes.DataSource = lstClientes;
                        lsbClientes.DisplayMember = "FakeNombre";
                        lsbClientes.ValueMember = "Codigo";

                        lsbClientes.Enabled = true;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private async void lsbClientes_Click(object sender, EventArgs e)
        {
            lsbMascotas.DataSource = null;
            btnGMascota.Enabled = false;
            btnRegistar.Enabled = false;
            lsbMascotas.Enabled = false;
            btnGCliente.Enabled = true;
            dgvAtenciones.Rows.Clear();

            foreach (Cliente clt in lstClientes)
            {
                if (clt.Codigo == Convert.ToInt32(lsbClientes.SelectedValue.ToString())) {
                    oCliente = clt;
                    break;
                }
            }

            string url = "https://localhost:44350/api/Mascotas/idCliente"; // ?id_cliente=" + oCliente.Codigo;
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(oCliente);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);


            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                lstMascotas = JsonConvert.DeserializeObject<List<Mascota>>(bodyJSON);


                if (lstMascotas.Count == 0)
                {
                    DialogResult resultado = MessageBox.Show("No existen mascotas relacionados con este cliente. Desea agregar una nueva?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        Frm_Soporte frmSoporte = new Frm_Soporte(oMascota, oCliente, Accion.CREATE);
                        frmSoporte.ShowDialog();

                        lsbClientes.SelectedValue = -1;
                        btnGCliente.Enabled = false;

                        return;
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    oCliente.EliminarMascotas();

                    foreach (Mascota oMascota in lstMascotas)
                    {
                        oCliente.AgregarMascota(oMascota);
                    }
                    

                    lsbMascotas.DataSource = lstMascotas;
                    lsbMascotas.DisplayMember = "Nombre";
                    lsbMascotas.ValueMember = "IdMascota";

                    lsbMascotas.Enabled = true;
                    //grpMascota.Enabled = true;
                }
            }
        }

        private async void lsbMascotas_Click(object sender, EventArgs e)
        {
            btnGMascota.Enabled = true;
            btnRegistar.Enabled = true;
            dgvAtenciones.Rows.Clear();

            foreach (Mascota msct in oCliente.Mascotas)
            {
                if (msct.IdMascota == Convert.ToInt32(lsbMascotas.SelectedValue.ToString())) {
                    oMascota = msct;
                }
            }

            await ConsultarAtenciones();
        }

        private async Task ConsultarAtenciones()
        {

            string url = "https://localhost:44350/api/Atenciones/all";
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(oMascota);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);


            if (result.IsSuccessStatusCode)
            {
                List<Atencion> lstAtenciones;

                var bodyJSON = await result.Content.ReadAsStringAsync();
                lstAtenciones = JsonConvert.DeserializeObject<List<Atencion>>(bodyJSON);

                foreach (Atencion att in lstAtenciones)
                {
                    dgvAtenciones.Rows.Add(new Object[] {
                                            att.IdAtencion,
                                            att.oVeterinario.Nombre,
                                            att.Fecha
                                            });

                    oMascota.SaveAtencion(att);
                }
            }
        }

        private void btnSalirMain_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void dgvAtenciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAtenciones.CurrentCell.ColumnIndex == 3)
            {
                int codigo = Convert.ToInt32(dgvAtenciones.CurrentRow.Cells["cCodigo"].Value.ToString());

                foreach (Atencion att in oMascota.Atenciones)
                {
                    if (att.IdAtencion == codigo)
                    {
                        Frm_Consulta_Atenciones FrmCAtenciones = new Frm_Consulta_Atenciones(att, oMascota);
                        FrmCAtenciones.ShowDialog();

                        await CompletarClientesResultado(false, false);

                        break;
                    }
                }
            }
        }
    }
}
