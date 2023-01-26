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


            if (Funciones.fnImportarExcel.Importar("Datos", dgvData))
            {
                btnCargar.Enabled = true;
                btnProcesar.Enabled = true;
                
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            DataTable investigacion = (DataTable)dgvData.DataSource;
            Funciones.fnScrap.InvestigacionTelefonos(investigacion,dgvData);

        }
    }
}
