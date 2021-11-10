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
    public partial class Frm_Clientes : Form
    {
        private Cliente oCliente = new Cliente();
        private Mascota oMascota = new Mascota();
        private List<TipoMascota> lstTipoMascotas = new List<TipoMascota>();
        private TipoObj tipo = new TipoObj();
        private Accion modo = new Accion();
        public Frm_Clientes(Object obj, Object obj2, Accion mdo)
        {
            InitializeComponent();

            if (obj is Cliente)
            {
                oCliente = (Cliente)obj;
                tipo = TipoObj.CLIENTE;
                modo = mdo;
            }

        }

        private async void Frm_Clientes_Load_1(object sender, EventArgs e)
        { 
            if (tipo == TipoObj.CLIENTE)
            {
                OptimizarForm(tipo);

                lblTitulo.Text = "Gestion de Clientes";
                if (modo != Accion.CREATE)
                {
                    txtCodigo.Text = oCliente.Codigo.ToString();
                    txtNombre.Text = oCliente.Nombre;
                    txtApellido.Text = oCliente.Apellido;
                    if (oCliente.Sexo == "M")
                        rdbM.Checked = true;
                    else
                        rdbF.Checked = true;
                    txtDni.Text = oCliente.Dni.ToString();
                    txtContacto.Text = oCliente.Contacto;

                    lstSoporte.DataSource = oCliente.Mascotas;
                    lstSoporte.DisplayMember = "Nombre";
                    lstSoporte.ValueMember = "IdMascota";

                    lstSoporte.SelectedIndex = -1;
                }
                else
                {
                    await ObtenerSiguienteId("Clientes/id");
                    rdbM.Checked = true;
                }

            }

        }

        private async Task ObtenerSiguienteId(string str)
        {
            string url = "https://localhost:44350/api/" + str;
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                int id = JsonConvert.DeserializeObject<Int32>(bodyJSON);

                txtCodigo.Text = id.ToString();
            }
        }


        

        private void OptimizarForm(TipoObj obj)
        {

            if (obj == TipoObj.CLIENTE)
            {
                if (modo == Accion.CREATE)
                {
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    lblTM.Visible = true;
                    lstSoporte.Visible = true;
                    rdbM.Enabled = true;
                    rdbM.Visible = true;
                    rdbF.Visible = true;
                    rdbF.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtContacto.Enabled = true;
                    txtDni.Enabled = true;
                }
                else
                {
                    lstSoporte.Visible = true;
                    rdbM.Enabled = false;
                    rdbM.Visible = true;
                    rdbF.Visible = true;
                    rdbF.Enabled = false;
                }
                lblTM.Text = "Listado de mascotas: ";
            }

            

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            if (tipo == TipoObj.CLIENTE)
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtContacto.Enabled = true;
                txtDni.Enabled = true;
                rdbM.Enabled = true;
                rdbF.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }

        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (tipo == TipoObj.CLIENTE)
            {
                Cliente oClienteN = new Cliente();

                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El campo nombre esta sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtNombre.Text.Length > 20)
                {
                    MessageBox.Show("El campo nombre no debe superar los 20 caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("El campo apellido esta sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtApellido.Text.Length > 20)
                {
                    MessageBox.Show("Exediste la cantidad de caracteres para el campo apellido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(txtContacto.Text))
                {
                    MessageBox.Show("El campo contacto esta sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtContacto.Text.Length > 20)
                {
                    MessageBox.Show("Exediste la cantidad de caracteres para el campo contacto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtNombre.Text.Length > 20)
                {
                    MessageBox.Show("Exediste la cantidad de caracteres para el campo nombre", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    oClienteN.Dni = Convert.ToInt32(txtDni.Text);

                    if (oCliente.Dni != oClienteN.Dni) {
                        //Se valida que el cliente ya exista pero contro nombre --devolver ese nombre y mostrarlo
                        string url1 = "https://localhost:44350/api/Clientes/getByDni";
                        HttpClient cliente1 = new HttpClient();
                        var data1 = JsonConvert.SerializeObject(oClienteN);
                        HttpContent content1 = new StringContent(data1, System.Text.Encoding.UTF8, "application/json");
                        var result1 = await cliente1.PostAsync(url1, content1);

                        if (result1.IsSuccessStatusCode)
                        {
                            var bodyJSON = await result1.Content.ReadAsStringAsync();
                            Cliente clt1 = JsonConvert.DeserializeObject<Cliente>(bodyJSON);

                            if (clt1.Dni == oClienteN.Dni)
                            {
                                MessageBox.Show("El Dni que ingresó ya pertenece a otro cliente: " + clt1.FakeNombre, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                    
                }
                catch (Exception ex) {

                    MessageBox.Show("El campo documento debe ser numerico", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                DialogResult msg = MessageBox.Show("Seguro desea guardar los datos ingresados?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.OK))
                {
                    oClienteN.Nombre = txtNombre.Text;
                    oClienteN.Apellido = txtApellido.Text;
                    oClienteN.Contacto = txtContacto.Text;
                    oClienteN.Codigo = oCliente.Codigo;
                    oClienteN.Mascotas = oCliente.Mascotas;
                    oClienteN.FakeNombre = oClienteN.FakeNombre;

                    if (rdbM.Checked)
                        oClienteN.Sexo = "M";
                    else
                        oClienteN.Sexo = "F";

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

                    string url = "https://localhost:44350/api/Clientes/" + operacion;
                    HttpClient cliente = new HttpClient();
                    var data = JsonConvert.SerializeObject(oClienteN);
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

        private void btnCancelar_Click(object sender, EventArgs e)
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

        }

        private async void btnNuevo_Click_1(object sender, EventArgs e)
        {
            modo = Accion.CREATE;
            HabilitarCampos();
            LimpiarCampos();

            await ObtenerSiguienteId("Clientes/id");
        }

        private void HabilitarCampos()
        {
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtContacto.Enabled = true;
            txtDni.Enabled = true;
            rdbM.Enabled = true;
            rdbF.Enabled = true;

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtContacto.Text = "";
            txtDni.Text = "";
            lstSoporte.DataSource = null;
        }
    }
}
