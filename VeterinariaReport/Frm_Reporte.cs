using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaReport
{
    public partial class Frm_Reporte : Form
    {
        public Frm_Reporte()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Load(object sender, EventArgs e)
        {

            CargarReporte(true);
        }

        private void btnEnviarR_Click(object sender, EventArgs e)
        {
            CargarReporte(false);
        }
        private void CargarReporte(bool v)
        {
            int mes;
            if (v)
                mes = 1;
            else
                mes = Convert.ToInt32(nudMes.Value);

            // TODO: This line of code loads data into the 'VETDataSet1.PA_REPORTE_MES' table. You can move, or remove it, as needed.
            this.PA_REPORTE_MESTableAdapter.Fill(this.VETDataSet1.PA_REPORTE_MES, mes);

            this.reportViewer1.RefreshReport();
        }

        
    }
}
