using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonosScrapt.Formularios
{
    public partial class FrmPantallaPrincipal : Form
    {

        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            btnProcesar.Enabled = false;
            btnCerrarSesion.Enabled = false;
            btnExportarExcel.Enabled = false;

            if (Funciones.fnImportarExcel.Importar("Datos", dgvData))
            {
                btnCargar.Enabled = true;
                btnProcesar.Enabled = true;
                btnCerrarSesion.Enabled = true;
                btnExportarExcel.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = true;
                btnProcesar.Enabled = true;
                btnCerrarSesion.Enabled = true;
                btnExportarExcel.Enabled = true;
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            btnProcesar.Enabled = false;
            btnCerrarSesion.Enabled = false;
            btnExportarExcel.Enabled = false;

            DataTable investigacion = (DataTable)dgvData.DataSource;
            Funciones.fnScrap.InvestigacionTelefonos(investigacion,dgvData);

            btnCargar.Enabled = true;
            btnProcesar.Enabled = true;
            btnCerrarSesion.Enabled = true;
            btnExportarExcel.Enabled = true;

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
            {
                if (dgvData.Columns.Contains("Compania"))
                {
                    Funciones.fnExportarExcel.Exportar(dgvData);
                }

            }

        }
    }
}
