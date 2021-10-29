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
        TipoObj tipo = new TipoObj();
        public Frm_Soporte(Object obj)
        {
            InitializeComponent();

            if (obj is Atencion) {
                oAtencion = (Atencion)obj;
                tipo = TipoObj.ATENCION;    
            }    
                
        }

        private void Frm_Soporte_Load(object sender, EventArgs e)
        {
            if (tipo == TipoObj.ATENCION) {
                OptimizarForm(1);

                txtCodigo.Text = oAtencion.IdAtencion.ToString();
                txtNombre.Text = oAtencion.Importe.ToString();
                rtxtDescripcion.Text = oAtencion.Descripcion;
            }

        }

        private void OptimizarForm(int v)
        {
            if (v == 1)
            {
                lblSexo.Visible = true;
                lblSexo.Text = "Fecha Atencion: " + oAtencion.Fecha;
                lblTM.Text = "Descripcion: ";
                lblNombre.Text = "Importe: ";
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            rtxtDescripcion.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;


        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            if (tipo == TipoObj.ATENCION)
            {
                if (String.IsNullOrEmpty(txtNombre.Text) && String.IsNullOrEmpty(rtxtDescripcion.Text))
                {
                    MessageBox.Show("Existen campos sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    Convert.ToDouble(txtNombre.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El campo importe debe ser numerico", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtNombre.Text.Length > 8)
                {
                    MessageBox.Show("Exediste la cantidad de digitos para el importe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    oAtencion.Importe = Convert.ToDouble(txtNombre.Text);

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
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
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
        }
    }
}
