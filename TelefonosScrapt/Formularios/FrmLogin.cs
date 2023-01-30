using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonosScrapt
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            txtContraseña.PasswordChar = '*';
            txtUsuario.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string Validar = Funciones.fnLogin.ValidacionUsuario(txtUsuario.Text, txtContraseña.Text);

            if (Validar == "1")
            {
                Formularios.FrmPantallaPrincipal frm = new Formularios.FrmPantallaPrincipal();
                frm.Show();
                this.Hide();
            }
            else if (Validar == "0")
            {
                MessageBox.Show("Revise su usuario o contraseña", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Validar == "2")
            {
                MessageBox.Show("Rellene todos los campos", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                string Validar = Funciones.fnLogin.ValidacionUsuario(txtUsuario.Text, txtContraseña.Text);

                if (Validar == "1")
                {
                    Formularios.FrmPantallaPrincipal frm = new Formularios.FrmPantallaPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else if (Validar == "0")
                {
                    MessageBox.Show("Revise su usuario o contraseña", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                string Validar = Funciones.fnLogin.ValidacionUsuario(txtUsuario.Text, txtContraseña.Text);

                if (Validar == "1")
                {
                    Formularios.FrmPantallaPrincipal frm = new Formularios.FrmPantallaPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else if (Validar == "0")
                {
                    MessageBox.Show("Revise su usuario o contraseña", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
