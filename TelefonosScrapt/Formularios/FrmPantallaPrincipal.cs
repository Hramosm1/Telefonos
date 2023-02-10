using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonosScrapt.Funciones;

namespace TelefonosScrapt.Formularios
{
    public partial class FrmPantallaPrincipal : Form
    {

        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        string rutaArchivo;
        public string usuarioIngreso { set; get; }

        private string idTipoConf { set; get; }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            btnCargar.Enabled = false;
            btnProcesar.Enabled = false;
            btnCerrarSesion.Enabled = false;
            btnExportarExcel.Enabled = false;
            btnConfiguracion.Enabled = false;
            rutaArchivo = fnImportarExcel.Importar("Datos", dgvData);

            if (rutaArchivo != "")
            {
                btnCargar.Enabled = true;
                btnProcesar.Enabled = true;
                btnCerrarSesion.Enabled = true;
                btnExportarExcel.Enabled = true;
                btnConfiguracion.Enabled = true;
                pbInvestigacion.Value = 0;
            }
            else
            {
                btnCargar.Enabled = true;
                btnProcesar.Enabled = true;
                btnCerrarSesion.Enabled = true;
                btnExportarExcel.Enabled = true;
                btnConfiguracion.Enabled = true;
                pbInvestigacion.Value = 0;
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTipoConf == "0")
                {
                    if (dgvData.Rows.Count > 0)
                    {
                        if (idTipoConf != "0")
                        {
                            btnCargar.Enabled = false;
                        }
                        else
                        {
                            btnCargar.Enabled = true;
                        }
                        btnProcesar.Enabled = false;
                        btnCerrarSesion.Enabled = false;
                        btnExportarExcel.Enabled = false;
                        btnConfiguracion.Enabled = false;

                        DataTable investigacion = (DataTable)dgvData.DataSource;
                        fnScrap.InvestigacionTelefonos(investigacion, dgvData, pbInvestigacion, "", usuarioIngreso);

                        if (idTipoConf != "0")
                        {
                            btnCargar.Enabled = false;
                        }
                        else
                        {
                            btnCargar.Enabled = true;
                        }
                        btnProcesar.Enabled = true;
                        btnCerrarSesion.Enabled = true;
                        btnExportarExcel.Enabled = true;
                        btnConfiguracion.Enabled = true;
                        MessageBox.Show("Investigación terminada", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Favor cargue un archivo", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (idTipoConf != "0")
                    {
                        btnCargar.Enabled = false;
                    }
                    else
                    {
                        btnCargar.Enabled = true;
                    }
                    btnProcesar.Enabled = false;
                    btnCerrarSesion.Enabled = false;
                    btnExportarExcel.Enabled = false;
                    btnConfiguracion.Enabled = false;
                    while (fnOrigenDatos.ConsultaData(dgvData))
                    {
                        DataTable investigacion = (DataTable)dgvData.DataSource;
                        fnScrap.InvestigacionTelefonos(investigacion, dgvData, pbInvestigacion, rutaArchivo, usuarioIngreso);
                    }
                    MessageBox.Show("Investigación terminada", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (idTipoConf != "0")
                {
                    btnCargar.Enabled = false;
                }
                else
                {
                    btnCargar.Enabled = true;
                }
                btnProcesar.Enabled = true;
                btnCerrarSesion.Enabled = true;
                btnExportarExcel.Enabled = true;
                btnConfiguracion.Enabled = true;
                pbInvestigacion.Value = 0;
            }

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
                    fnExportarExcel.Exportar(dgvData);
                }

            }

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSeleccionProcesarArchivo frm = new FrmSeleccionProcesarArchivo();
                frm.usuario = usuarioIngreso;
                frm.idConf = idTipoConf;
                frm.ShowDialog();
                frm.Dispose();
                idTipoConf = fnOrigenDatos.ObtenerConfiguracion(lblConf);
                if (idTipoConf != "0")
                {
                    btnCargar.Enabled = false;
                }
                else
                {
                    btnCargar.Enabled = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                idTipoConf = fnOrigenDatos.ObtenerConfiguracion(lblConf);
                if (idTipoConf != "0")
                {
                    btnCargar.Enabled = false;
                }
                else
                {
                    btnCargar.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
