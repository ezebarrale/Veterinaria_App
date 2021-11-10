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
    public partial class Frm_Main_Usuarios : Form
    {
        private Usuario oUsuario = new Usuario();
        private List<Usuario> lstUsuarios;
        private Accion modo;

        public Frm_Main_Usuarios()
        {
            InitializeComponent();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

            if (!ckbTodos.Checked)
            {
                if (String.IsNullOrEmpty(txtConsultar.Text))
                {
                    MessageBox.Show("El campo de consulta debe completarse ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtConsultar.Text.Length > 10)
                {
                    MessageBox.Show("El campo de consulta no debe superar los 20 caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else {
                txtConsultar.Text = "";
            }

            dgvUsuarios.Rows.Clear();
           
            oUsuario = new Usuario();

            if (ckbTodos.Checked)
                oUsuario.Todos = 1;
            else
                oUsuario.Todos = 0;

            oUsuario.User = txtConsultar.Text;

            string url = "https://localhost:44350/api/Access/users";
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(oUsuario);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                lstUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(bodyJSON);

                foreach (Usuario usr in lstUsuarios)
                {
                    bool admin = false;
                    if (usr.Level == 1)
                        admin = true;

                    dgvUsuarios.Rows.Add(new Object[] {
                                            usr.Codigo,
                                            usr.User,
                                            admin
                                            });

                }

            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("El campo usuario esta sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtUser.Text.Length > 10)
            {
                MessageBox.Show("El campo usuario no debe superar los 20 caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("El campo usuario esta sin completar ...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtPass.Text.Length > 10)
            {
                MessageBox.Show("El campo usuario no debe superar los 20 caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //oUsuario = new Usuario();

            oUsuario.User = txtUser.Text;
            oUsuario.Password = txtPass.Text;
            if (ckbAdmin.Checked)
            {
                oUsuario.Level = 1;
            }
            else
            {
                oUsuario.Level = 2;
            }

            string msjGral = "Seguro desea guardar el usuario ingresado?";
            string operacion = "save";
            string msjExito = "El usuario se registró con exito";
            string msjNoExito = "No se pudo registrar el usuario";

            if (modo == Accion.UPDATE) {
                msjGral = "Seguro desea editar el usuario seleccionado?";
                operacion = "update";
                msjExito = "El usuario se actualizó con exito";
                msjNoExito = "No se pudo actualizar el usuario";
            }


            DialogResult respuesta = MessageBox.Show(msjGral, "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {

                string url = "https://localhost:44350/api/Access/"+operacion;
                HttpClient cliente = new HttpClient();
                var data = JsonConvert.SerializeObject(oUsuario);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                var result = await cliente.PostAsync(url, content);

                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show(msjExito, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    return;
                }
                else
                {
                    MessageBox.Show(msjNoExito, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

        }

        private void limpiarCampos()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            ckbVerPass.Checked = false;
            ckbAdmin.Checked = false;
        }

        private void ckbVerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVerPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                pcbOff.Visible = true;
                pcbOn.Visible = false;
            }
            else {
                txtPass.PasswordChar = '*';
                pcbOff.Visible = false;
                pcbOn.Visible = true;
            }
                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int codigo = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["colCodigo"].Value.ToString());

            foreach (Usuario usr in lstUsuarios)
            {
                if (usr.Codigo == codigo)
                {
                    if (dgvUsuarios.CurrentCell.ColumnIndex == 4) //eliminar
                    {
                        DialogResult result = MessageBox.Show("Seguro desea eliminar este usuario", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            EliminarUsuario(usr);
                        }
                        else {
                            return;
                        }
                    }

                    if (dgvUsuarios.CurrentCell.ColumnIndex == 3) //editar
                    {
                        EditarUsuario(usr);
                    }

                    break;
                }
            }

        }

        private void EditarUsuario(Usuario usr)
        {
            modo = Accion.UPDATE;

            txtUser.Enabled = false;
            txtUser.Text = usr.User;
            txtPass.Text = "";
            if (usr.Level == 1)
                ckbAdmin.Checked = true;
            else
                ckbAdmin.Checked = false;

            oUsuario = usr;

        }

        private async void EliminarUsuario(Usuario usr)
        {
            string url = "https://localhost:44350/api/Access/delete";
            HttpClient cliente = new HttpClient();
            var data = JsonConvert.SerializeObject(usr);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                bool exito = JsonConvert.DeserializeObject<bool>(bodyJSON);

                if (exito)
                {
                    MessageBox.Show("El usuario se eliminó con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstUsuarios.Remove(usr);
                    ActualizarGrilla();
                    return;
                }
                else
                {
                    MessageBox.Show("El usuario no se pudo eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else {
                MessageBox.Show("El usuario no se pudo eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ActualizarGrilla()
        {
            dgvUsuarios.Rows.Clear();

            foreach (Usuario usr in lstUsuarios)
            {
                bool admin = false;
                if (usr.Level == 1)
                    admin = true;

                dgvUsuarios.Rows.Add(new Object[] {
                                            usr.Codigo,
                                            usr.User,
                                            admin
                                            });

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Accion.CREATE;
            limpiarCampos();
            txtUser.Enabled = true;
        }
    }
}
