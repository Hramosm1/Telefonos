using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace TelefonosScrapt.Funciones
{
    class fnOrigenDatos
    {

        public static void CargarComboConf(ComboBox cmb) 
        {
            string[] Variables = new string[1];
            string[] Valores = new string[1];

            Variables[0] = "@opcion";
            Valores[0] = "2";

            cmb.DataSource = Conexion.ConexionBaseDatos.Consulta("sp_guardarConfiguraciones", Variables, Valores);
            cmb.ValueMember = "idConfiguraciones";
            cmb.DisplayMember = "NombreConfiguracion";

        }

        public static bool GuardarConfiguraciones(DataTable gridCondiciones, DataTable gridCampos, string nombreTabla, string nombreConf, string usuario)
        {
            string[] Variables = new string[9];
            string[] Valores = new string[9];
            string Condiciones ="";
            string Campos="";
            string ColumnaCodigo = "", ColumnaEmpresa = "", ColumnaNumero = "";
            bool flag = false;
            DataTable dt;

            foreach(DataRow i in gridCondiciones.Rows)
            {
                if (i["ValorCondicion"].ToString() != "" & i["Condiciones"].ToString() != "")
                {
                    Condiciones = Condiciones + i["Condiciones"].ToString() + "=" + i["ValorCondicion"].ToString() + ",";
                }
                
            }
            foreach (DataRow i in gridCampos.Rows)
            {
                if (i["NombreTabla"].ToString().Trim() == "" & i["NombreCampo"].ToString() != "Numero")
                {
                    Campos = " " + Campos + "''" + " " + i["NombreCampo"].ToString() + ",";
                }
                else
                {
                    Campos = " " + Campos + i["NombreTabla"].ToString().Trim() + " " + i["NombreCampo"].ToString() + ",";
                }
                

                if (i["NombreCampo"].ToString() == "Numero" & i["NombreTabla"].ToString().Trim() == "")
                {
                    MessageBox.Show("El campo de teléfono no puede ir vacío", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (i["NombreCampo"].ToString() == "Numero")
                {
                    ColumnaNumero = i["NombreTabla"].ToString();
                }
                else if (i["NombreCampo"].ToString() == "Codigo")
                {
                    if(i["NombreTabla"].ToString().Trim() != "")
                    {
                        ColumnaCodigo = i["NombreTabla"].ToString();
                    }
                    else
                    {
                        ColumnaCodigo = "";
                    }
                    
                }
                else if (i["NombreCampo"].ToString() == "Empresa")
                {
                    if (i["NombreTabla"].ToString().Trim() != "")
                    {
                        ColumnaEmpresa = i["NombreTabla"].ToString();
                    }
                    else
                    {
                        ColumnaEmpresa = "";
                    }
                }

            }

            Variables[0] = "@opcion";
            Valores[0] = "1";
            Variables[1] = "@Condiciones";
            Valores[1] = Condiciones.Substring(0,Condiciones.Length - 1);
            Variables[2] = "@Campos";
            Valores[2] = Campos.Trim().Substring(0,Campos.Trim().Length - 1);
            Variables[3] = "@NombreTabla";
            Valores[3] = nombreTabla;
            Variables[4] = "@NombreConf";
            Valores[4] = nombreConf;
            Variables[5] = "@usuario";
            Valores[5] = usuario;
            Variables[6] = "@ColumnaCodigo";
            Valores[6] = ColumnaCodigo;
            Variables[7] = "@ColumnaEmpresa";
            Valores[7] = ColumnaEmpresa;
            Variables[8] = "@ColumnaNumero";
            Valores[8] = ColumnaNumero;


            dt = Conexion.ConexionBaseDatos.Consulta("sp_guardarConfiguraciones", Variables, Valores);

            if(dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Resultado"].ToString() != "ok")
                {

                    MessageBox.Show("No se guardo la información " + dt.Rows[0]["Resultado"].ToString(),"Teléfonos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Información guardada correctamente", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = true;
                }

            }

            return flag;

        }

        public static bool GuardarConfiguracionActual(string idConfiguracion, string usuario, string tipo)
        {
            bool flag = false;
            string[] Variables = new string[4];
            string[] Valores = new string[4];
            DataTable dt;

            Variables[0] = "@opcion";
            Valores[0] = "3";
            Variables[1] = "@idConfiguracion";
            Valores[1] = idConfiguracion;
            Variables[2] = "@usuario";
            Valores[2] = usuario;
            Variables[3] = "@tipoConf";
            Valores[3] = tipo;


            dt = Conexion.ConexionBaseDatos.Consulta("sp_guardarConfiguraciones", Variables, Valores);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Resultado"].ToString() != "ok")
                {

                    MessageBox.Show("No se guardó la configuración " + dt.Rows[0]["Resultado"].ToString(), "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Configuración guardada correctamente", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = true;
                }

            }

            return flag;
        }

        public static string ObtenerConfiguracion(Label NombreConf)
        {

            string[] Variables = new string[1];
            string[] Valores = new string[1];
            string id = "";
            DataTable dt;

            Variables[0] = "@opcion";
            Valores[0] = "4";

            dt = Conexion.ConexionBaseDatos.Consulta("sp_guardarConfiguraciones", Variables, Valores);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["NombreConfiguracion"].ToString() != "")
                {
                    NombreConf.Text = "Base de datos, " + dt.Rows[0]["NombreConfiguracion"].ToString();
                    id = dt.Rows[0]["idConfiguraciones"].ToString();
                }
                
            }
            else
            {
                NombreConf.Text = "Excel";
                id = "0";
            }

            return id;
        }
        public static bool ConsultaData(DataGridView grid)
        {
            DataTable dt;
            bool flag;
            string[] Variables = new string[1];
            string[] Valores = new string[1];

            Variables[0] = "@opcion";
            Valores[0] = "5";

            dt = Conexion.ConexionBaseDatos.Consulta("sp_guardarConfiguraciones", Variables, Valores);

            if (dt.Rows.Count > 0)
            {
                grid.DataSource = dt;
                flag = true;
            }
            else
            {
                flag = false;
            }


            return flag;
        }

    }


}
