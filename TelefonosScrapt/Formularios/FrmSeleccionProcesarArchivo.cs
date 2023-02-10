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
    public partial class FrmSeleccionProcesarArchivo : Form
    {
        public FrmSeleccionProcesarArchivo()
        {
            InitializeComponent();
        }

        public string usuario { set; get; }
        public string idConf { set; get; }

        private void FrmSeleccionProcesarArchivo_Load(object sender, EventArgs e)
        {
            try
            {
                fnOrigenDatos.CargarComboConf(cmbConfiguraciones);

                if (idConf != "0")
                {
                    cmbFormaData.SelectedIndex = 1;
                    cmbConfiguraciones.SelectedValue = idConf;
                }
                else
                {
                    cmbFormaData.SelectedIndex = 0;
                }
                

                if (cmbFormaData.Text == "Base de datos")
                {
                    cmbConfiguraciones.Enabled = true;
                    btnNuevaConfiguracion.Enabled = true;
                }
                else if (cmbFormaData.Text == "Excel")
                {
                    cmbConfiguraciones.Enabled = false;
                    btnNuevaConfiguracion.Enabled = false;
                }

                gboxDetallesDatos.Enabled = false;

                dgvCampos.Rows.Clear();
                dgvCondiciones.Rows.Clear();

                txtNombreConf.Clear();
                txtNombreConsulta.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message,"Telefonos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void cmbFormaData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaData.Text == "Base de datos")
            {
                cmbConfiguraciones.Enabled = true;
                btnNuevaConfiguracion.Enabled = true;

            }
            else if (cmbFormaData.Text == "Excel")
            {
                cmbConfiguraciones.Enabled = false;
                btnNuevaConfiguracion.Enabled = false;
                gboxDetallesDatos.Enabled = false;

                dgvCampos.Rows.Clear();
                dgvCondiciones.Rows.Clear();

                txtNombreConf.Clear();
                txtNombreConsulta.Clear();
            }

        }

        private void btnNuevaConfiguracion_Click(object sender, EventArgs e)
        {
            gboxDetallesDatos.Enabled = true;

            dgvCampos.Rows.Clear();
            dgvCondiciones.Rows.Clear();

            txtNombreConf.Clear();
            txtNombreConsulta.Clear();

            dgvCampos.Rows.Add("Empresa");
            dgvCampos.Rows.Add("Codigo");
            dgvCampos.Rows.Add("Numero");
            
        }

        private void btnCancelarConf_Click(object sender, EventArgs e)
        {
            gboxDetallesDatos.Enabled = false;

            dgvCampos.Rows.Clear();
            dgvCondiciones.Rows.Clear();

            txtNombreConf.Clear();
            txtNombreConsulta.Clear();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            cmbConfiguraciones.Enabled = false;
            btnNuevaConfiguracion.Enabled = false;
            gboxDetallesDatos.Enabled = false;

            dgvCampos.Rows.Clear();
            dgvCondiciones.Rows.Clear();

            txtNombreConf.Clear();
            txtNombreConsulta.Clear();
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar la información?","Telefonos",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cmbFormaData.SelectedIndex == 0)
                {

                }
                else
                {
                    DataTable condiciones = fnConvertirDatagrid.GetDataTableFromDGV(dgvCondiciones);
                    DataTable campos = fnConvertirDatagrid.GetDataTableFromDGV(dgvCampos);

                    if (fnOrigenDatos.GuardarConfiguraciones(condiciones, campos, txtNombreConsulta.Text, txtNombreConf.Text, usuario))
                    {
                        fnOrigenDatos.CargarComboConf(cmbConfiguraciones);
                        gboxDetallesDatos.Enabled = false;

                        dgvCampos.Rows.Clear();
                        dgvCondiciones.Rows.Clear();

                        txtNombreConf.Clear();
                        txtNombreConsulta.Clear();

                    }

                }


            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar la configuración?", "Telefonos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (fnOrigenDatos.GuardarConfiguracionActual(cmbConfiguraciones.SelectedValue.ToString(),usuario,cmbFormaData.SelectedIndex.ToString()))
                {
                    this.Close();
                }


            }
        }
    }
}
