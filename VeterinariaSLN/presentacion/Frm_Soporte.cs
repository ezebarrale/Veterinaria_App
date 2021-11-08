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
    enum TipoObj { 
        ATENCION,
        MASCOTA,
        CLIENTE
    }
    public partial class Frm_Soporte : Form
    {
        Cliente oCliente = new Cliente();
        Mascota oMascota = new Mascota();
        List<TipoMascota> lstTipoMascotas = new List<TipoMascota>();
        TipoObj tipo = new TipoObj();
        Accion modo = new Accion();
        public Frm_Soporte(Object obj, Object obj2, Accion mdo)
        {
            InitializeComponent();

            if (obj is Cliente) {
                oCliente = (Cliente)obj;
                tipo = TipoObj.CLIENTE;
                modo = mdo;
            }

            if (obj is Mascota)
            {
                oMascota  = (Mascota)obj;
                tipo = TipoObj.MASCOTA;
                oCliente = (Cliente)obj2;
                modo = mdo;
            }

        }

        private async void Frm_Soporte_Load(object sender, EventArgs e)
        {

            if (tipo == TipoObj.MASCOTA)
            {
                OptimizarForm(tipo);

                lblTitulo.Text = "Gestion de Mascotas";
                if (modo != Accion.CREATE)
                {
                    if (oMascota.Sexo == "M")
                        rdbM.Checked = true;
                    else
                        rdbF.Checked = true;
                    txtCodigo.Text = oMascota.IdMascota.ToString();
                    txtNombre.Text = oMascota.Nombre;
                    nudEdad.Text = oMascota.Edad.ToString();
                    await ObtenerTipoDeMascotas();
                    cmbTipoMascota.SelectedValue = oMascota.Tipo.IdTipoMascota;

                }
                else
                {
                    rdbM.Checked = true;
                    await ObtenerSiguienteId("Mascotas/id");
                    await ObtenerTipoDeMascotas();
                    
                }

                txtDuenio.Text = oCliente.Nombre;

            }
        }

        private async Task ObtenerSiguienteId(string str)
        {
            string url = "https://localhost:44350/api/"+str;
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                int id = JsonConvert.DeserializeObject<Int32>(bodyJSON);

                txtCodigo.Text = id.ToString();
            }
        }


        private async Task ObtenerTipoDeMascotas()
        {
            cmbTipoMascota.DataSource = null;

            string url = "https://localhost:44350/api/TipoMascotas";
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();
            lstTipoMascotas = JsonConvert.DeserializeObject<List<TipoMascota>>(bodyJSON);

            cmbTipoMascota.DataSource = lstTipoMascotas;
            cmbTipoMascota.DisplayMember = "Nombre";
            cmbTipoMascota.ValueMember = "IdTipoMascota";
        }

        private void OptimizarForm(TipoObj obj)
        {

            if (obj == TipoObj.MASCOTA)
            {
                if (modo == Accion.CREATE)
                {
                    txtNombre.Enabled = true;
                    cmbTipoMascota.Enabled = true;
                    nudEdad.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                }
                else {
                    btnNuevo.Enabled = true;
                    btnNuevo.Visible = true;
                }

                lblSexo.Visible = true;
                rdbM.Visible = true;
                rdbF.Visible = true;
                cmbTipoMascota.Visible = true;
                lblTM.Text = "Tipo de Mascota: ";
                lblEdad.Visible = true;
                nudEdad.Visible = true;
                lblDuenio.Visible = true;
                txtDuenio.Visible = true;

            }

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            if (tipo == TipoObj.CLIENTE)
            {
                txtNombre.Enabled = true;
                rdbM.Enabled = true;
                rdbF.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }

            if (tipo == TipoObj.MASCOTA)
            {
                txtNombre.Enabled = true;
                cmbTipoMascota.Enabled = true;
                nudEdad.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tipo == TipoObj.CLIENTE)
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El campo nombre esta sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtNombre.Text.Length > 20)
                {
                    MessageBox.Show("Exediste la cantidad de caracteres para el campo nombre", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult msg = MessageBox.Show("Seguro desea guardar los cambios realizados?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.OK))
                {
                    oCliente.Nombre = txtNombre.Text;

                    if (rdbM.Checked)
                        oCliente.Sexo = "M";
                    else
                        oCliente.Sexo = "F";

                    string operacion = "update";
                    string msjExito = "Se guardó el cliente con exito";
                    string msjNoExito = "No fue posible guardar el cliente ingresado";

                    //Diferenciamos si es un nuevo cliente o la actualizacion de uno existente
                    if (modo == Accion.CREATE)
                    {

                        operacion = "save";
                        msjExito = "Se guardó el cliente con exito";
                        msjNoExito = "No fue posible guardar el cliente ingresado";
                        
                    }
                    
                    string url = "https://localhost:44350/api/Clientes/"+operacion;
                    HttpClient cliente = new HttpClient();
                    var data = JsonConvert.SerializeObject(oCliente);
                    HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                    var result = await cliente.PostAsync(url, content);

                    if (result.IsSuccessStatusCode)
                    {
                        var bodyJSON = await result.Content.ReadAsStringAsync();
                        bool exito = JsonConvert.DeserializeObject<bool>(bodyJSON);

                        if (exito)
                        {
                            MessageBox.Show(msjExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show(msjNoExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show(msjNoExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    

                    

                }

            }

            if (tipo == TipoObj.MASCOTA)
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El campo nombre esta sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtNombre.Text.Length > 20)
                {
                    MessageBox.Show("Exediste la cantidad de caracteres para el campo nombre", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult msg = MessageBox.Show("Seguro desea guardar los datos ingresados?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.OK))
                {

                    string operacion = "update";
                    Object objeto = oMascota;
                    string msjExito = "Los cambios fueron realizados con exito";
                    string msjNoExito = "Los cambios NO fueron realizados con exito";

                    oMascota.Nombre = txtNombre.Text;
                    oMascota.Edad = Convert.ToInt32(nudEdad.Value);

                    if (rdbM.Checked)
                        oMascota.Sexo = "M";
                    else
                        oMascota.Sexo = "H";

                    TipoMascota tm = new TipoMascota();
                    tm.IdTipoMascota = Convert.ToInt32(cmbTipoMascota.SelectedValue.ToString());
                    tm.Nombre = cmbTipoMascota.Text;

                    oMascota.Tipo = tm;

                    //Primer caso para cuando se desea crear una nueva mascota perteneciente a un cliente existente
                    if (modo == Accion.CREATE)
                    {
                        oCliente.EliminarMascotas();
                        oCliente.AgregarMascota(oMascota);
                        operacion = "save";
                        objeto = oCliente;
                        msjExito = "Se guardó correctamente la mascota ingresada";
                        msjNoExito = "No se pudo guardar correctamente la mascota ingresada";
                    }

                    string url = "https://localhost:44350/api/Mascotas/"+operacion;
                    HttpClient cliente = new HttpClient();
                    var data = JsonConvert.SerializeObject(objeto);
                    HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                    var result = await cliente.PostAsync(url, content);

                    if (result.IsSuccessStatusCode)
                    {
                        var bodyJSON = await result.Content.ReadAsStringAsync();
                        bool exito = JsonConvert.DeserializeObject<bool>(bodyJSON);

                        if (exito)
                        {
                            MessageBox.Show(msjExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show(msjNoExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show(msjNoExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    

                }

            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (tipo == TipoObj.CLIENTE)
            {

                DialogResult msg = MessageBox.Show("Seguro desea eliminar?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.OK))
                {

                    string url = "https://localhost:44350/api/Clientes/delete";
                    HttpClient cliente = new HttpClient();
                    var data = JsonConvert.SerializeObject(oCliente);
                    HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                    var result = await cliente.PostAsync(url, content);

                    if (result.IsSuccessStatusCode)
                    {
                        var bodyJSON = await result.Content.ReadAsStringAsync();
                        bool exito = JsonConvert.DeserializeObject<bool>(bodyJSON);

                        if (exito)
                        {
                            MessageBox.Show("Se eliminó con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("No pudo ser eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("No pudo ser eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }

            }

            if (tipo == TipoObj.MASCOTA)
            {

                DialogResult msg = MessageBox.Show("Seguro desea eliminar?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.OK))
                {

                    string url = "https://localhost:44350/api/Mascotas/delete";
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
                            MessageBox.Show("Se eliminó con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("No pudo ser eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("No pudo ser eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }

            }

        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Accion.CREATE;
            HabilitarCampos();
            LimpiarCampos();

            await ObtenerSiguienteId("Mascotas/id");
        }

        private void HabilitarCampos()
        {
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombre.Enabled = true;
            nudEdad.Enabled = true;
            cmbTipoMascota.Enabled = true;

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            nudEdad.Value = 1;
            cmbTipoMascota.SelectedItem = 1;
        }
    }
}
