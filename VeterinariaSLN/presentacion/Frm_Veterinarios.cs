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
    public partial class Frm_Veterinarios : Form
    {
        private Veterinario oVeterinario = new Veterinario();
        private List<Veterinario> lstVeterinarios = new List<Veterinario>();
        public Frm_Veterinarios()
        {
            InitializeComponent();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Clientes FrmVeterinarios = new Frm_Clientes(oVeterinario, null, Accion.CREATE);
            FrmVeterinarios.ShowDialog();


            await ConsultarVeterinarios();
        }

        private async void Frm_Veterinarios_Load(object sender, EventArgs e)
        {
            await ConsultarVeterinarios();

        }

        private async Task ConsultarVeterinarios()
        {
            string url = "https://localhost:44350/api/Veterinarios";
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);

            if (result.IsSuccessStatusCode)
            {
                var bodyJSON = await result.Content.ReadAsStringAsync();
                lstVeterinarios = JsonConvert.DeserializeObject<List<Veterinario>>(bodyJSON);

                CompletarGrilla();

            }
        }

        private void CompletarGrilla()
        {
            dgvVeterinarios.Rows.Clear();

            foreach (Veterinario vet in lstVeterinarios)
            {
                dgvVeterinarios.Rows.Add(new Object[] {
                                            vet.Codigo,
                                            vet.Nombre + " " +vet.Apellido,
                                            vet.Dni,
                                            vet.Contacto,
                                            vet.Sexo
                                            });

             
            }
        }

        private async void dgvVeterinarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVeterinarios.CurrentCell.ColumnIndex == 5) //Editar
            {
                int codigo = Convert.ToInt32(dgvVeterinarios.CurrentRow.Cells["colCodigo"].Value.ToString());

                foreach (Veterinario vet in lstVeterinarios)
                {
                    if (vet.Codigo == codigo) {

                        Frm_Clientes FrmVeterinarios = new Frm_Clientes(vet, null, Accion.UPDATE);
                        FrmVeterinarios.ShowDialog();

                        await ConsultarVeterinarios();
                    }
                }
                
            }

            if (dgvVeterinarios.CurrentCell.ColumnIndex == 6) //Eliminar
            {
                int codigo = Convert.ToInt32(dgvVeterinarios.CurrentRow.Cells["colCodigo"].Value.ToString());

                foreach (Veterinario vet in lstVeterinarios)
                {
                    if (vet.Codigo == codigo)
                    {
                        EliminatVeterinario(vet);
                    }
                }
            }
        }

        private async void EliminatVeterinario(Veterinario vet)
        {
            DialogResult resultado = MessageBox.Show("Seguro desea eliminar este veterinario?", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) {
                string url = "https://localhost:44350/api/Veterinarios/delete";
                HttpClient cliente = new HttpClient();
                var data = JsonConvert.SerializeObject(vet);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                var result = await cliente.PostAsync(url, content);

                if (result.IsSuccessStatusCode)
                {
                    var bodyJSON = await result.Content.ReadAsStringAsync();
                    bool exito = JsonConvert.DeserializeObject<bool>(bodyJSON);

                    if (exito)
                    {
                        MessageBox.Show("El veterinario seleccionado se eliminó con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await ConsultarVeterinarios();
                    }
                    else {
                        MessageBox.Show("El veterinario seleccionado no pudo eliminarse", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    

                }
                else {
                    MessageBox.Show("El veterinario seleccionado no pudo eliminarse", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }
    }
}
