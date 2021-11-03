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
        Atencion oAtencion = new Atencion();
        Cliente oCliente = new Cliente();
        Mascota oMascota = new Mascota();
        List<TipoMascota> lstTipoMascotas = new List<TipoMascota>();
        TipoObj tipo = new TipoObj();
        Accion modo = new Accion();
        public Frm_Soporte(Object obj, Object obj2, Accion mdo)
        {
            InitializeComponent();

            if (obj is Atencion) {
                oAtencion = (Atencion)obj;
                tipo = TipoObj.ATENCION;    
            }

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
            if (tipo == TipoObj.ATENCION) {
                OptimizarForm(tipo);

                txtCodigo.Text = oAtencion.IdAtencion.ToString();
                txtNombre.Text = oAtencion.Importe.ToString();
                rtxtDescripcion.Text = oAtencion.Descripcion;
            }

            if (tipo == TipoObj.CLIENTE) {
                OptimizarForm(tipo);

                if (modo != Accion.CREATE)
                {
                    txtCodigo.Text = oCliente.Codigo.ToString();
                    txtNombre.Text = oCliente.Nombre.ToString();
                    if (oCliente.Sexo == "M")
                        rdbM.Checked = true;
                    else
                        rdbF.Checked = true;

                    lstSoporte.DataSource = oCliente.Mascotas;
                    lstSoporte.DisplayMember = "Nombre";
                    lstSoporte.ValueMember = "IdMascota";

                    lstSoporte.SelectedIndex = -1;
                }
                else {
                    await ObtenerSiguienteId("Clientes/id");
                    rdbM.Checked = true;
                }
                
            }

            if (tipo == TipoObj.MASCOTA)
            {
                OptimizarForm(tipo);

                if (modo != Accion.CREATE)
                {
                    txtCodigo.Text = oMascota.IdMascota.ToString();
                    txtNombre.Text = oMascota.Nombre;
                    nudEdad.Text = oMascota.Edad.ToString();
                    await ObtenerTipoDeMascotas();
                    cmbTipoMascota.SelectedValue = oMascota.Tipo.IdTipoMascota;

                }
                else
                {
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
            if (obj == TipoObj.ATENCION)
            {
                lblSexo.Visible = true;
                lblSexo.Text = "Fecha Atencion: " + oAtencion.Fecha;
                lblTM.Text = "Descripcion: ";
                lblNombre.Text = "Importe: ";
            }

            if (obj == TipoObj.CLIENTE)
            {
                if (modo == Accion.CREATE)
                {
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    lblTM.Visible = false;
                    lstSoporte.Visible = false;
                    rdbM.Enabled = true;
                    rdbM.Visible = true;
                    rdbF.Visible = true;
                    rdbF.Enabled = true;
                    txtNombre.Enabled = true;
                }
                else {
                    lstSoporte.Visible = true;
                    rdbM.Enabled = false;
                    rdbM.Visible = true;
                    rdbF.Visible = true;
                    rdbF.Enabled = false;
                }
                lblTM.Text = "Listado de mascotas: ";
                lblSexo.Visible = true;
                rtxtDescripcion.Visible = false;
            }

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
                lblSexo.Visible = false;
                rdbM.Visible = false;
                rdbF.Visible = false;
                cmbTipoMascota.Visible = true;
                lblTM.Text = "Tipo de Mascota: ";
                rtxtDescripcion.Visible = false;
                lstSoporte.Visible = false;
                lblEdad.Visible = true;
                nudEdad.Visible = true;
                lblDuenio.Visible = true;
                txtDuenio.Visible = true;

            }

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (tipo == TipoObj.ATENCION) {
                txtNombre.Enabled = true;
                rtxtDescripcion.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }

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

            if (tipo == TipoObj.ATENCION)
            {
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(rtxtDescripcion.Text))
                {
                    MessageBox.Show("Existen campos sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    //para cuando es un entero
                    int cantDigitos = 6;

                    //para cuando es con coma
                    for (int i = 0; i < txtNombre.Text.Length; i++)
                    {
                        if (i > 0 && i < 7 && txtNombre.Text[i].ToString() == ",")
                        {
                            cantDigitos = 9;
                        }

                    }

                    if (txtNombre.Text.Length > cantDigitos)
                    {
                        MessageBox.Show("El campo importe no debe superar los " + cantDigitos + " digitos", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        oAtencion.Importe = Convert.ToDouble(txtNombre.Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("El campo importe debe ser numerico", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (rtxtDescripcion.Text.Length > 100)
                {
                    MessageBox.Show("Exediste la cantidad de caracteres para la descripcion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult msg = MessageBox.Show("Seguro desea guardar los cambios realizados?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.OK))
                {
                    oAtencion.Descripcion = rtxtDescripcion.Text;

                    string url = "https://localhost:44350/api/Atenciones/update";
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
                            MessageBox.Show("Los cambios fueron realizados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Los cambios NO fueron realizados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }else{
                        MessageBox.Show("Los cambios NO fueron realizados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }

            }

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

                    string operacion = "new";
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

                DialogResult msg = MessageBox.Show("Seguro desea guardar los cambios realizados?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.OK))
                {

                    string operacion = "update";
                    Object objeto = oMascota;
                    string msjExito = "Los cambios fueron realizados con exito";
                    string msjNoExito = "Los cambios NO fueron realizados con exito";

                    oMascota.Nombre = txtNombre.Text;
                    oMascota.Edad = Convert.ToInt32(nudEdad.Value);

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
            if (tipo == TipoObj.ATENCION)
            {

                DialogResult msg = MessageBox.Show("Seguro desea eliminar?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.OK))
                {

                    string url = "https://localhost:44350/api/Atenciones/delete";
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Accion.CREATE;
            HabilitarCampos();
            LimpiarCampos();
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
